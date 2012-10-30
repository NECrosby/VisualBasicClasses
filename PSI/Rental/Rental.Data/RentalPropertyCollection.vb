Imports System
Imports System.Collections

'-------------------------------------------------------------
' Enumeration Filter Type - Properties
'-------------------------------------------------------------
Public Enum RentalPropertyFilterType
    ID
    UnitNumber
    MaxTenantCapacity
    Address
    City
    State
    Zip
    LeaseAmount
    isVacant
    DamageDepositAmount
    hasParking
End Enum

'-------------------------------------------------------------
' Rental Property Collection Class
'-------------------------------------------------------------
Public Class RentalPropertyCollection
    Inherits System.Collections.ObjectModel.Collection(Of RentalProperty)
    '-------------------------------------------------------------
    ' Constructor
    '-------------------------------------------------------------
    Public Sub New()
        
    End Sub
    Public Sub New(ByVal searches As Rental.Data.SearchCollection(Of Rental.Data.RentalPropertyFilterType))
        Dim whereStatement As String
        whereStatement = BuildWhereStatement(searches)

        Dim tempProperties As RentalPropertyCollection = RentalPropertyCollection.QueryDatabase(whereStatement)
        For Each tempProperty In tempProperties
            If tempProperty IsNot Nothing Then
                MyBase.Add(tempProperty)
            End If
        Next
    End Sub
    Public Sub New(ByVal load As Boolean)
        If load = True Then
            Dim tempProperties As RentalPropertyCollection = RentalPropertyCollection.QueryDatabase(Nothing)
            For Each tempProperty As RentalProperty In tempProperties
                If tempProperty IsNot Nothing Then
                    MyBase.Add(tempProperty)
                End If
            Next
        End If
    End Sub

    '---------------------------------------------------
    ' Build Where Statement -- Using search Collection                                     
    '---------------------------------------------------
    Public Shared Function BuildWhereStatement(ByVal searches As Rental.Data.SearchCollection(Of Rental.Data.RentalPropertyFilterType)) As String
        Dim columnName As String = String.Empty
        Dim returnString As String = String.Empty
        Dim conditionalStatement As String = " WHERE "

        For Each newSearch As Search(Of Rental.Data.RentalPropertyFilterType) In searches
            Select Case newSearch.FilterBy
                Case RentalPropertyFilterType.Address
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} PropertyAddress = '{1}' ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.City
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} PropertyCity = '{1}' ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.DamageDepositAmount
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} DamageDepositAmount = {1} ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.hasParking
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} hasParking = {1} ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.ID
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} PropertyID = {1} ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.isVacant
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} isVacant = {1} ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.LeaseAmount
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} PropertyLeaseAmount = {1} ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.MaxTenantCapacity
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} MaxTenantCapacity = {1} ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.State
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} PropertyState = '{1}' ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.UnitNumber
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} PropertyUnitNumber = '{1}' ", conditionalStatement, newSearch.Value)

                Case RentalPropertyFilterType.Zip
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} PropertyZip = '{1}' ", conditionalStatement, newSearch.Value)

            End Select
            conditionalStatement = returnString & newSearch.QualifierToString
        Next
        Return returnString
    End Function
    '---------------------------------------------------
    ' QueryDatabase                                     
    '---------------------------------------------------
    Public Shared Function QueryDatabase(ByVal whereStatement As String) As RentalPropertyCollection
        Dim rentalProperties As New RentalPropertyCollection
        Dim queryProperty As String = "SELECT PropertyID, PropertyUnitNumber, MaxTenantCapacity, PropertyAddress, " & _
                                             "PropertyCity, PropertyState, PropertyZip, PropertyLeaseAmount," & _
                                             "isVacant, DamageDepositAmount, hasParking " & _
                                      "FROM Property"
        If Not String.IsNullOrEmpty(whereStatement) Then
            queryProperty += (" " + whereStatement)
        End If

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(queryProperty, connection)
        Dim DataAdapter As New OleDb.OleDbDataAdapter
        connection.Open()
        DataAdapter.SelectCommand = command
        Dim table As New System.Data.DataTable
        DataAdapter.Fill(table)
        rentalProperties = LoadObjectCollection(table)
        connection.Close()

        Return rentalProperties
    End Function
    '---------------------------------------------------
    ' Delete Object                        
    '---------------------------------------------------
    Public Shared Sub DeleteObject(ByVal myProperty As Rental.Data.RentalProperty)
        Dim deleteStatement As String = String.Format(System.Globalization.CultureInfo.InvariantCulture, "DELETE FROM Property WHERE PropertyID = {0} ", myProperty.ID)

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(deleteStatement, connection)

        connection.Open()
        command.CommandText = deleteStatement
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    '---------------------------------------------------
    ' Load Object Collection                          
    '---------------------------------------------------
    Public Shared Function LoadObjectCollection(ByVal table As System.Data.DataTable) As RentalPropertyCollection
        Dim rentalProperties As New RentalPropertyCollection

        If table IsNot Nothing Then
            Dim id As Integer = 0
            Dim unitNumber As String = String.Empty
            Dim maxTenantCapacity As Integer = 0
            Dim address As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty
            Dim leaseAmount As Decimal = 0
            Dim isVacant As Boolean = False
            Dim damageDepositAmount As Decimal = 0
            Dim hasParking As Boolean = True

            For Each row As System.Data.DataRow In table.Rows
                id = System.Convert.ToInt32(row("PropertyID"))
                unitNumber = row("PropertyUnitNumber").ToString
                maxTenantCapacity = System.Convert.ToInt32(row("MaxTenantCapacity"))
                address = row("PropertyAddress").ToString
                city = row("PropertyCity").ToString
                state = row("PropertyState").ToString.ToUpper
                zip = row("PropertyZip").ToString
                leaseAmount = System.Convert.ToDecimal(row("PropertyLeaseAmount"))
                isVacant = System.Convert.ToBoolean(row("isVacant"))
                damageDepositAmount = System.Convert.ToDecimal(row("DamageDepositAmount"))
                hasParking = System.Convert.ToBoolean(row("hasParking"))

                Dim rentalProperty As New RentalProperty(id, unitNumber, maxTenantCapacity, address, _
                                                         city, state, zip, leaseAmount, isVacant, damageDepositAmount, hasParking)
                rentalProperties.Add(rentalProperty)
            Next
        End If

        Return rentalProperties
    End Function
    '---------------------------------------------------
    ' Insert Into Database                                     
    '---------------------------------------------------
    Public Shared Sub InsertIntoDatabase(ByVal rentalPropertyValue As RentalProperty)
        Dim queryProperty As String = "INSERT INTO Property(PropertyUnitNumber, MaxTenantCapacity, " & _
                                                           "PropertyAddress, PropertyCity, PropertyState, " & _
                                                           "PropertyZip, PropertyLeaseAmount, isVacant, " & _
                                                           "DamageDepositAmount, hasParking) " & _
                                      "VALUES('" & rentalPropertyValue.UnitNumber.ToString & "', " & rentalPropertyValue.MaxTenantCapacity.ToString & _
                                                " , '" & rentalPropertyValue.Address.ToString & "', '" & rentalPropertyValue.City.ToString & "', '" & rentalPropertyValue.State.ToString & _
                                                "', '" & rentalPropertyValue.Zip.ToString & "', " & rentalPropertyValue.LeaseAmount.ToString & ", " & rentalPropertyValue.isVacant.ToString & _
                                                ", " & rentalPropertyValue.DamageDepositAmount.ToString & ", " & rentalPropertyValue.hasParking.ToString & ")"

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(queryProperty, connection)

        connection.Open()
        command.CommandText = queryProperty
        command.ExecuteNonQuery()
        connection.Close()

    End Sub
    '---------------------------------------------------
    ' Update Database                                     
    '---------------------------------------------------
    Public Shared Sub UpdateQuery(ByVal rentalPropertyValue As RentalProperty)
        Dim queryProperty As String = "UPDATE Property " & _
                                      "SET [PropertyUnitNumber] = '" & rentalPropertyValue.UnitNumber.ToString & "', " & _
                                        "[MaxTenantCapacity] = " & rentalPropertyValue.MaxTenantCapacity.ToString & ", " & _
                                        "[PropertyAddress] = '" & rentalPropertyValue.Address.ToString & "', " & _
                                        "[PropertyCity] = '" & rentalPropertyValue.City.ToString & "', " & _
                                        "[PropertyState] = '" & rentalPropertyValue.State.ToString & "', " & _
                                        "[PropertyZip] = '" & rentalPropertyValue.Zip.ToString & "', " & _
                                        "[PropertyLeaseAmount] = " & rentalPropertyValue.LeaseAmount.ToString & ", " & _
                                        "[isVacant] = " & rentalPropertyValue.isVacant.ToString & ", " & _
                                        "[DamageDepositAmount] = " & rentalPropertyValue.DamageDepositAmount.ToString & ", " & _
                                        "[hasParking] = " & rentalPropertyValue.hasParking.ToString & " " & _
                                      "WHERE PropertyID = " & rentalPropertyValue.ID.ToString


        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(queryProperty, connection)

        connection.Open()
        command.CommandText = queryProperty
        command.ExecuteNonQuery()
        connection.Close()

    End Sub
    '---------------------------------------------------
    ' Get Property by ID                                     
    '---------------------------------------------------
    Public Shared Function GetPropertyByID(ByVal propertyID As Int32) As RentalProperty
        Dim returnRentalProperty As RentalProperty = Nothing
        Dim queryProperty As String = "SELECT PropertyID, PropertyUnitNumber, MaxTenantCapacity, PropertyAddress, " & _
                                             "PropertyCity, PropertyState, PropertyZip, PropertyLeaseAmount, " & _
                                             "isVacant, DamageDepositAmount, hasParking " & _
                                      "FROM Property " & _
                                      "WHERE PropertyID = " & propertyID.ToString

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(queryProperty, connection)
        Dim DataAdapter As New OleDb.OleDbDataAdapter
        connection.Open()
        DataAdapter.SelectCommand = command
        Dim table As New System.Data.DataTable
        DataAdapter.Fill(table)
        returnRentalProperty = LoadObject(table)    ' this function is coded down below

        connection.Close()

        Return returnRentalProperty
    End Function

    '---------------------------------------------------
    ' Load Object                         
    '---------------------------------------------------
    Public Shared Function LoadObject(ByVal table As System.Data.DataTable) As RentalProperty
        Dim returnRentalProperty As RentalProperty = Nothing

        If table IsNot Nothing Then
            Dim id As Integer = 0
            Dim unitNumber As String = String.Empty
            Dim maxTenantCapacity As Integer = 0
            Dim address As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty
            Dim leaseAmount As Decimal = 0
            Dim isVacant As Boolean = False
            Dim damageDepositAmount As Decimal = 0
            Dim hasParking As Boolean = True

            'For Each row As System.Data.DataRow In table.Rows
            If table.Rows.Count >= 1 Then
                Dim row As System.Data.DataRow = table.Rows(0)
                id = System.Convert.ToInt32(row("PropertyID"))
                unitNumber = row("PropertyUnitNumber").ToString
                maxTenantCapacity = System.Convert.ToInt32(row("MaxTenantCapacity"))
                address = row("PropertyAddress").ToString
                city = row("PropertyCity").ToString
                state = row("PropertyState").ToString.ToUpper
                zip = row("PropertyZip").ToString
                leaseAmount = System.Convert.ToDecimal(row("PropertyLeaseAmount"))
                isVacant = System.Convert.ToBoolean(row("isVacant"))
                damageDepositAmount = System.Convert.ToDecimal(row("DamageDepositAmount"))
                hasParking = System.Convert.ToBoolean(row("hasParking"))

                returnRentalProperty = New RentalProperty(id, unitNumber, maxTenantCapacity, address, _
                                                         city, state, zip, leaseAmount, isVacant, damageDepositAmount, hasParking)
            End If
        End If

        Return returnRentalProperty
    End Function

    'Public Sub New(ByVal filter As RentalPropertyFilterType, ByVal searchValue As String)
    '    Dim whereStatement As String

    '    whereStatement = BuildWhereStatement(filter, searchValue)

    '    Dim tempProperties As RentalPropertyCollection = RentalPropertyCollection.QueryDatabase(whereStatement)
    '    For Each tempProperty In tempProperties
    '        If tempProperty IsNot Nothing Then
    '            MyBase.Add(tempProperty)
    '        End If
    '    Next
    'End Sub
    '---------------------------------------------------
    ' Build Where Statement                                     
    '---------------------------------------------------
    'Public Shared Function BuildWhereStatement(ByVal filter As RentalPropertyFilterType, ByVal searchValue As String) As String
    '    Dim columnName As String = String.Empty
    '    Dim returnString As String = String.Empty

    '    Select Case filter
    '        Case RentalPropertyFilterType.Address
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE PropertyAddress = '{0}' ", searchValue)
    '        Case RentalPropertyFilterType.City
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE PropertyCity = '{0}' ", searchValue)
    '        Case RentalPropertyFilterType.DamageDepositAmount
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE DamageDepositAmount = {0} ", searchValue)
    '        Case RentalPropertyFilterType.hasParking
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE hasParking = {0} ", searchValue)
    '        Case RentalPropertyFilterType.ID
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE PropertyID = {0} ", searchValue)
    '        Case RentalPropertyFilterType.isVacant
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE isVacant = {0} ", searchValue)
    '        Case RentalPropertyFilterType.LeaseAmount
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE PropertyLeaseAmount = {0} ", searchValue)
    '        Case RentalPropertyFilterType.MaxTenantCapacity
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE MaxTenantCapacity = {0} ", searchValue)
    '        Case RentalPropertyFilterType.State
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE PropertyState = '{0}' ", searchValue)
    '        Case RentalPropertyFilterType.UnitNumber
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE PropertyUnitNumber = '{0}' ", searchValue)
    '        Case RentalPropertyFilterType.Zip
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE PropertyZip = '{0}' ", searchValue)
    '    End Select

    '    Return returnString
    'End Function
End Class

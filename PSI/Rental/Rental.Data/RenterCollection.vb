Imports System
Imports System.Collections

'-------------------------------------------------------------
' Enumeration Filter Type - Renters
'-------------------------------------------------------------
Public Enum RenterFilterType
    ID
    FirstName
    MI
    LastName
    PermanentAddress
    PermanentCity
    PermanentState
    PermanentZip
    Phone
    Email
    isCurrentlyRenting
    EmergencyContactName
    EmergencyContactPhone
End Enum

'-------------------------------------------------------------
' Renter Collection Class
'-------------------------------------------------------------
Public Class RenterCollection
    Inherits System.Collections.ObjectModel.Collection(Of Renter)
    '-------------------------------------------------------------
    ' Constructor
    '-------------------------------------------------------------
    Public Sub New()

    End Sub
    Public Sub New(ByVal searches As Rental.Data.SearchCollection(Of Rental.Data.RenterFilterType))
        Dim whereStatement As String
        whereStatement = BuildWhereStatement(searches)
        Dim tempRenters As RenterCollection = RenterCollection.QueryDatabase(whereStatement)
        For Each tempRenter In tempRenters
            If tempRenter IsNot Nothing Then
                MyBase.Add(tempRenter)
            End If
        Next

    End Sub
    Public Sub New(ByVal load As Boolean)
        If load = True Then
            Dim tempRenters As RenterCollection = RenterCollection.QueryDatabase(Nothing)
            For Each tempRenter In tempRenters
                If tempRenter IsNot Nothing Then
                    MyBase.Add(tempRenter)
                End If
            Next
        End If
    End Sub
    '---------------------------------------------------
    ' Build Where Statement      Using Search Collection                                     
    '---------------------------------------------------
    Public Shared Function BuildWhereStatement(ByVal searches As Rental.Data.SearchCollection(Of Rental.Data.RenterFilterType)) As String
        Dim returnString As String = String.Empty
        Dim columnName As String = String.Empty
        Dim conditionalStatement As String = " WHERE "

        For Each newSearch As Search(Of Rental.Data.RenterFilterType) In searches
            Select Case newSearch.FilterBy
                Case RenterFilterType.Email
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterEmail = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.EmergencyContactName
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterEmergencyContactName = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.EmergencyContactPhone
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterEmergencyContactPhone = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.FirstName
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterFirstName = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.ID
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterID = {1} ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.isCurrentlyRenting
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} isCurrentlyRenting = {1} ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.LastName
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterLastName = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.MI
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterMI = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.PermanentAddress
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterPermanentAddress = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.PermanentCity
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterPermanentCity = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.PermanentState
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterPermanentState = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.PermanentZip
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterPermanentZip = '{1}' ", conditionalStatement, newSearch.Value)

                Case RenterFilterType.Phone
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterPhone = '{1}' ", conditionalStatement, newSearch.Value)

            End Select

            conditionalStatement = returnString & newSearch.QualifierToString
        Next

        Return returnString
    End Function
    '---------------------------------------------------
    ' Query Database                                     
    '---------------------------------------------------
    Public Shared Function QueryDatabase(ByVal whereStatement As String) As RenterCollection
        Dim renters As New RenterCollection
        Dim query As String = "SELECT RenterID, RenterFirstName, RenterMI, " & _
                                     "RenterLastName, RenterPermanentAddress, RenterPermanentCity, " & _
                                     "RenterPermanentState, RenterPermanentZip, RenterPhone, " & _
                                     "RenterEmail, isCurrentlyRenting, RenterEmergencyContactName, " & _
                                     "RenterEmergencyContactPhone " & _
                              "FROM Renter"
        If Not String.IsNullOrEmpty(whereStatement) Then
            query += (" " + whereStatement)
        End If

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(query, connection)
        Dim DataAdapter As New OleDb.OleDbDataAdapter
        connection.Open()
        DataAdapter.SelectCommand = command
        Dim table As New System.Data.DataTable
        DataAdapter.Fill(table)
        renters = LoadObjectCollection(table)
        connection.Close()

        Return renters
    End Function
    '---------------------------------------------------
    ' Delete Object                        
    '---------------------------------------------------
    Public Shared Sub DeleteObject(ByVal myRenter As Rental.Data.Renter)
        Dim deleteStatement As String = String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                                      "DELETE FROM Renter WHERE RenterID = {0} ", myRenter.ID)
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
    Private Shared Function LoadObjectCollection(ByVal table As System.Data.DataTable) As RenterCollection
        Dim renters As New RenterCollection

        If table IsNot Nothing Then
            Dim id As Integer = 0
            Dim firstName As String = String.Empty
            Dim mi As String = String.Empty
            Dim lastName As String = String.Empty
            Dim permanentAddress As String = String.Empty
            Dim permanentCity As String = String.Empty
            Dim permanentState As String = String.Empty
            Dim permanentZip As String = String.Empty
            Dim phone As String = String.Empty
            Dim email As String = String.Empty
            Dim isCurrentlyRenting As Boolean = False
            Dim emergencyContactName As String = String.Empty
            Dim emergencyContactPhone As String = String.Empty

            For Each row As System.Data.DataRow In table.Rows
                id = System.Convert.ToInt32(row("RenterID"))
                firstName = row("RenterFirstName").ToString
                mi = row("RenterMI").ToString
                lastName = row("RenterLastName").ToString
                permanentAddress = row("RenterPermanentAddress").ToString
                permanentCity = row("RenterPermanentCity").ToString
                permanentState = row("RenterPermanentState").ToString
                permanentZip = row("RenterPermanentZip").ToString
                phone = row("RenterPhone").ToString
                email = row("RenterEmail").ToString
                isCurrentlyRenting = System.Convert.ToBoolean(row("isCurrentlyRenting"))
                emergencyContactName = row("RenterEmergencyContactName").ToString
                emergencyContactPhone = row("RenterEmergencyContactPhone").ToString

                Dim renter As New Renter(id, firstName, mi, lastName, permanentAddress, permanentCity, permanentState, permanentZip, _
                                         phone, email, isCurrentlyRenting, emergencyContactName, emergencyContactPhone)
                renters.Add(renter)
            Next
        End If

        Return renters
    End Function
    '---------------------------------------------------
    ' Insert Into Database                                     
    '---------------------------------------------------
    Public Shared Sub InsertIntoDatabase(ByVal renterValue As Renter)
        Dim query As String = "INSERT INTO Renter(RenterFirstName, RenterMI, RenterLastName, " & _
                                                 "RenterPermanentAddress, RenterPermanentCity, RenterPermanentState, " & _
                                                 "RenterPermanentZip, RenterPhone, RenterEmail, " & _
                                                 "isCurrentlyRenting, RenterEmergencyContactName, RenterEmergencyContactPhone) " & _
                              "VALUES ('" & renterValue.FirstName.ToString & "', '" & renterValue.MI.ToString & "', '" & renterValue.LastName.ToString & "', " & _
                                      "'" & renterValue.PermanentAddress.ToString & "', '" & renterValue.PermanentCity.ToString & "', '" & renterValue.PermanentState & "', " & _
                                      "'" & renterValue.PermanentZip.ToString & "', '" & renterValue.Phone.ToString & "', '" & renterValue.Email.ToString & "', " & _
                                            renterValue.isCurrentlyRenting.ToString & ", '" & renterValue.EmergencyContactName & "', '" & renterValue.EmergencyContactPhone & "')"

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(query, connection)

        connection.Open()
        command.CommandText = query
        command.ExecuteNonQuery()
        connection.Close()

    End Sub
    '---------------------------------------------------
    ' Update Database                                     
    '---------------------------------------------------
    Public Shared Sub UpdateQuery(ByVal renterValue As Renter)
        Dim query As String = "UPDATE Renter " & _
                              "SET [RenterFirstName] = '" & renterValue.FirstName.ToString & "', " & _
                                  "[RenterMI] = '" & renterValue.MI.ToString & "', " & _
                                  "[RenterLastName] = '" & renterValue.LastName.ToString & "', " & _
                                  "[RenterPermanentAddress] = '" & renterValue.PermanentAddress.ToString & "', " & _
                                  "[RenterPermanentCity] = '" & renterValue.PermanentCity.ToString & "', " & _
                                  "[RenterPermanentState] = '" & renterValue.PermanentState.ToString & "', " & _
                                  "[RenterPermanentZip] = '" & renterValue.PermanentZip.ToString & "', " & _
                                  "[RenterPhone] = '" & renterValue.Phone.ToString & "', " & _
                                  "[RenterEmail] = '" & renterValue.Email.ToString & "', " & _
                                  "[isCurrentlyRenting] = " & renterValue.isCurrentlyRenting.ToString & ", " & _
                                  "[RenterEmergencyContactName] = '" & renterValue.EmergencyContactName.ToString & "', " & _
                                  "[RenterEmergencyContactPhone] = '" & renterValue.EmergencyContactPhone.ToString & "' " & _
                              "WHERE RenterID = " & renterValue.ID.ToString


        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(query, connection)

        connection.Open()
        command.CommandText = query
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    '---------------------------------------------------
    ' Get Renter by ID                                     
    '---------------------------------------------------
    Public Shared Function GetRenterByID(ByVal renterID As Int32) As Renter
        Dim returnRenter As Renter = Nothing
        Dim query As String = "SELECT RenterID, RenterFirstName, RenterMI, " & _
                                     "RenterLastName, RenterPermanentAddress, RenterPermanentCity, " & _
                                     "RenterPermanentState, RenterPermanentZip, RenterPhone, " & _
                                     "RenterEmail, isCurrentlyRenting, RenterEmergencyContactName, " & _
                                     "RenterEmergencyContactPhone " & _
                              "FROM Renter " & _
                              "WHERE RenterID = " & renterID.ToString

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(query, connection)
        Dim DataAdapter As New OleDb.OleDbDataAdapter
        connection.Open()
        DataAdapter.SelectCommand = command
        Dim table As New System.Data.DataTable
        DataAdapter.Fill(table)
        returnRenter = LoadObject(table)    ' this function is coded down below

        connection.Close()

        Return returnRenter
    End Function
    '---------------------------------------------------
    ' Load Object                         
    '---------------------------------------------------
    Public Shared Function LoadObject(ByVal table As System.Data.DataTable) As Renter
        Dim returnRenter As Renter = Nothing

        If table IsNot Nothing Then
            Dim id As Integer = 0
            Dim firstName As String = String.Empty
            Dim mi As String = String.Empty
            Dim lastName As String = String.Empty
            Dim permanentAddress As String = String.Empty
            Dim permanentCity As String = String.Empty
            Dim permanentState As String = String.Empty
            Dim permanentZip As String = String.Empty
            Dim phone As String = String.Empty
            Dim email As String = String.Empty
            Dim isCurrentlyRenting As Boolean = False
            Dim emergencyContactName As String = String.Empty
            Dim emergencyContactPhone As String = String.Empty

            If table.Rows.Count >= 1 Then
                Dim row As System.Data.DataRow = table.Rows(0)
                id = System.Convert.ToInt32(row("RenterID"))
                firstName = row("RenterFirstName").ToString
                mi = row("RenterMI").ToString
                lastName = row("RenterLastName").ToString
                permanentAddress = row("RenterPermanentAddress").ToString
                permanentCity = row("RenterPermanentCity").ToString
                permanentState = row("RenterPermanentState").ToString
                permanentZip = row("RenterPermanentZip").ToString
                phone = row("RenterPhone").ToString
                email = row("RenterEmail").ToString
                isCurrentlyRenting = System.Convert.ToBoolean(row("isCurrentlyRenting"))
                emergencyContactName = row("RenterEmergencyContactName").ToString
                emergencyContactPhone = row("RenterEmergencyContactPhone").ToString

                returnRenter = New Renter(id, firstName, mi, lastName, permanentAddress, permanentCity, permanentState, permanentZip, _
                                          phone, email, isCurrentlyRenting, emergencyContactName, emergencyContactPhone)
            End If
        End If

        Return returnRenter
    End Function

    'Public Sub New(ByVal filter As RenterFilterType, ByVal searchValue As String)
    '    Dim whereStatment As String
    '    whereStatment = BuildWhereStatement(filter, searchValue)

    '    Dim tempRenters As RenterCollection = RenterCollection.QueryDatabase(whereStatment)

    '    For Each tempRenter In tempRenters
    '        If tempRenter IsNot Nothing Then
    '            MyBase.Add(tempRenter)
    '        End If
    '    Next

    'End Sub
    '---------------------------------------------------
    ' Build Where Statement                                     
    '---------------------------------------------------
    'Public Shared Function BuildWhereStatement(ByVal filter As RenterFilterType, ByVal searchValue As String) As String
    '    Dim returnString As String = String.Empty
    '    Dim columnName As String = String.Empty

    '    Select Case filter
    '        Case RenterFilterType.Email
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterEmail = '{0}' ", searchValue)
    '        Case RenterFilterType.EmergencyContactName
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterEmergencyContactName = '{0}' ", searchValue)
    '        Case RenterFilterType.EmergencyContactPhone
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterEmergencyContactPhone = '{0}' ", searchValue)
    '        Case RenterFilterType.FirstName
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterFirstName = '{0}' ", searchValue)
    '        Case RenterFilterType.ID
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterID = {0} ", searchValue)
    '        Case RenterFilterType.isCurrentlyRenting
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE isCurrentlyRenting = {0} ", searchValue)
    '        Case RenterFilterType.LastName
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterLastName = '{0}' ", searchValue)
    '        Case RenterFilterType.MI
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterMI = '{0}' ", searchValue)
    '        Case RenterFilterType.PermanentAddress
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterPermanentAddress = '{0}' ", searchValue)
    '        Case RenterFilterType.PermanentCity
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterPermanentCity = '{0}' ", searchValue)
    '        Case RenterFilterType.PermanentState
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterPermanentState = '{0}' ", searchValue)
    '        Case RenterFilterType.PermanentZip
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterPermanentZip = '{0}' ", searchValue)
    '        Case RenterFilterType.Phone
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterPhone = '{0}' ", searchValue)
    '    End Select

    '    Return returnString
    'End Function
End Class

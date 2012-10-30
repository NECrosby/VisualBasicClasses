Imports System
Imports System.Collections

'-------------------------------------------------------------
' Enumeration Filter Type - Agreements
'-------------------------------------------------------------
Public Enum RentalAgreementFilterType
    ID
    PropertyId
    RenterId
    AgreementDate
    LeaseStartDate
    LeaseEndDate
    LeaseAmount
    hasPaidDamageDeposit
End Enum

'-------------------------------------------------------------
' Agreement Collection Class
'-------------------------------------------------------------
Public Class RentalAgreementCollection
    Inherits System.Collections.ObjectModel.Collection(Of RentalAgreement)
    '-------------------------------------------------------------
    ' Constructor
    '-------------------------------------------------------------
    Public Sub New()

    End Sub
    Public Sub New(ByVal searches As Rental.Data.SearchCollection(Of Rental.Data.RentalAgreementFilterType))
        Dim whereStatement As String

        whereStatement = BuildWhereStatement(searches)

        Dim tempAgreements As RentalAgreementCollection = RentalAgreementCollection.QueryDatabase(whereStatement)
        For Each tempAgreement In tempAgreements
            If tempAgreement IsNot Nothing Then
                MyBase.Add(tempAgreement)
            End If
        Next

    End Sub
    '---------------------------------------------------
    ' Build Where Statement -- Using Search Collection                                  
    '---------------------------------------------------
    Public Shared Function BuildWhereStatement(ByVal searches As Rental.Data.SearchCollection(Of Rental.Data.RentalAgreementFilterType)) As String
        Dim columnName As String = String.Empty
        Dim returnString As String = String.Empty
        Dim conditionalStatement As String = " WHERE "

        For Each newSearch As Search(Of Rental.Data.RentalAgreementFilterType) In searches
            Select Case newSearch.FilterBy
                Case RentalAgreementFilterType.AgreementDate
                    Dim startSearchDate As DateTime = System.Convert.ToDateTime(newSearch.Value)
                    Dim endSearchDate As DateTime
                    endSearchDate = startSearchDate.AddDays(1)
                    Dim whereStatement As String
                    whereStatement = String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0} AgreementDate >= #{1}# AND AgreementDate < #{2}#", _
                                                     conditionalStatement, startSearchDate.ToString("MM/dd/yyyy"), endSearchDate.ToString("MM/dd/yyyy"))
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, whereStatement, newSearch.Value)

                Case RentalAgreementFilterType.hasPaidDamageDeposit
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} hasPaidDamageDeposit = {1} ", conditionalStatement, newSearch.Value)

                Case RentalAgreementFilterType.ID
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} AgreementID = {1} ", conditionalStatement, newSearch.Value)

                Case RentalAgreementFilterType.LeaseAmount
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} AgreementAmount = {1} ", conditionalStatement, newSearch.Value)

                Case RentalAgreementFilterType.LeaseEndDate
                    Dim startSearchDate As DateTime = System.Convert.ToDateTime(newSearch.Value)
                    Dim endSearchDate As DateTime
                    endSearchDate = startSearchDate.AddDays(1)
                    Dim whereStatement As String
                    whereStatement = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} LeaseEndDate >= #{1}# AND LeaseEndDate < #{2}#", _
                                                    conditionalStatement, startSearchDate.ToString("MM/dd/yyyy"), endSearchDate.ToString("MM/dd/yyyy"))
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, whereStatement, newSearch.Value)

                Case RentalAgreementFilterType.LeaseStartDate
                    Dim startSearchDate As DateTime = System.Convert.ToDateTime(newSearch.Value)
                    Dim endSearchDate As DateTime
                    endSearchDate = startSearchDate.AddDays(1)
                    Dim whereStatement As String
                    whereStatement = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} LeaseStartDate >= #{1}# AND LeaseStartDate < #{2}#", _
                                                    conditionalStatement, startSearchDate.ToString("MM/dd/yyyy"), endSearchDate.ToString("MM/dd/yyyy"))
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, whereStatement, newSearch.Value)

                Case RentalAgreementFilterType.PropertyId
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} PropertyID = {1} ", conditionalStatement, newSearch.Value)

                Case RentalAgreementFilterType.RenterId
                    returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " {0} RenterID = {1} ", conditionalStatement, newSearch.Value)
            End Select
            conditionalStatement = returnString & newSearch.QualifierToString
        Next
        Return returnString
    End Function
    '---------------------------------------------------
    ' Query Database                                     
    '---------------------------------------------------
    Public Shared Function QueryDatabase(ByVal whereStatement As String) As RentalAgreementCollection
        Dim agreements As New RentalAgreementCollection
        Dim query As String = "SELECT AgreementID, PropertyID, RenterID, " & _
                                     "AgreementDate, AgreementAmount, LeaseStartDate, " & _
                                     "LeaseEndDate, hasPaidDamageDeposit " & _
                              "FROM RentalAgreement "

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
        agreements = LoadObjectCollection(table)
        connection.Close()

        Return agreements
    End Function
    '---------------------------------------------------
    ' Delete Object                       
    '---------------------------------------------------
    Public Shared Sub DeleteObject(ByVal myAgreement As Rental.Data.RentalAgreement)
        Dim deleteStatement As String = String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                                      "DELETE FROM RentalAgreement WHERE AgreementID = {0} ", myAgreement.AgreementID)
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
    Public Shared Function LoadObjectCollection(ByVal table As System.Data.DataTable) As RentalAgreementCollection
        Dim agreements As New RentalAgreementCollection

        If table IsNot Nothing Then
            Dim agreementID As Integer = 0
            Dim propertyID As Integer = 0
            Dim renterID As Integer = 0
            Dim agreementDate As DateTime = DateTime.Today
            Dim agreementAmount As Decimal = 0
            Dim leaseStartDate As DateTime = DateTime.Today
            Dim leaseEndDate As DateTime = DateTime.MaxValue
            Dim hasPaidDamageDeposit As Boolean

            For Each row As System.Data.DataRow In table.Rows
                agreementID = System.Convert.ToInt32(row("AgreementID"))
                propertyID = System.Convert.ToInt32(row("PropertyID"))
                renterID = System.Convert.ToInt32(row("RenterID"))
                agreementDate = System.Convert.ToDateTime(row("AgreementDate"))
                agreementAmount = System.Convert.ToDecimal(row("AgreementAmount"))
                leaseStartDate = System.Convert.ToDateTime(row("LeaseStartDate"))
                leaseEndDate = System.Convert.ToDateTime(row("LeaseEndDate"))
                hasPaidDamageDeposit = System.Convert.ToBoolean(row("hasPaidDamageDeposit"))

                Dim agreement As New RentalAgreement(agreementID, propertyID, renterID, agreementDate, agreementAmount, leaseStartDate, leaseEndDate, hasPaidDamageDeposit)
                agreements.Add(agreement)
            Next
        End If

        Return agreements
    End Function
    '---------------------------------------------------
    ' Insert Into Database                                     
    '---------------------------------------------------
    Public Shared Sub InsertIntoDatabase(ByVal agreementValue As RentalAgreement)
        Dim query As String = "INSERT INTO RentalAgreement(PropertyID, RenterID, " & _
                                                          "AgreementDate, AgreementAmount, LeaseStartDate, " & _
                                                          "LeaseEndDate, hasPaidDamageDeposit) " & _
                              "VALUES (" & agreementValue.PropertyID.ToString & ", " & agreementValue.RenterID.ToString & ", " & _
                                      "'" & agreementValue.AgreementDate.ToString & "', " & agreementValue.Amount.ToString & ", '" & agreementValue.StartDate & "', " & _
                                      "'" & agreementValue.EndDate.ToString & "', " & agreementValue.hasPaidDamageDeposit & ")"

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
    Public Shared Sub UpdateQuery(ByVal agreementValue As RentalAgreement)
        Dim query As String = "UPDATE RentalAgreement " & _
                              "SET [PropertyID] = " & agreementValue.PropertyID.ToString & ", " & _
                                  "[RenterID] = " & agreementValue.RenterID.ToString & ", " & _
                                  "[AgreementDate] = '" & agreementValue.AgreementDate.ToString & "', " & _
                                  "[AgreementAmount] = '" & agreementValue.Amount.ToString & "', " & _
                                  "[LeaseStartDate] = '" & agreementValue.StartDate.ToString & "', " & _
                                  "[LeaseEndDate] = '" & agreementValue.EndDate.ToString & "', " & _
                                  "[hasPaidDamageDeposit] = " & agreementValue.hasPaidDamageDeposit.ToString & " " & _
                              "WHERE AgreementID = " & agreementValue.AgreementID.ToString


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
    ' Get Agreement by ID                                     
    '---------------------------------------------------
    Public Shared Function GetAgreementByID(ByVal agreementID As Integer) As RentalAgreement
        Dim returnAgreement As RentalAgreement = Nothing

        Dim query As String = "SELECT AgreementID, PropertyID, RenterID, " & _
                                     "AgreementDate, AgreementAmount, LeaseStartDate, " & _
                                     "LeaseEndDate, hasPaidDamageDeposit " & _
                              "FROM RentalAgreement " & _
                              "WHERE AgreementID = " & agreementID.ToString

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\RentalProperty.accdb;Persist Security Info=False;"
        Dim connection As OleDb.OleDbConnection

        connection = New OleDb.OleDbConnection(connectionString)
        Dim command As New OleDb.OleDbCommand(query, connection)
        Dim DataAdapter As New OleDb.OleDbDataAdapter
        connection.Open()
        DataAdapter.SelectCommand = command
        Dim table As New System.Data.DataTable
        DataAdapter.Fill(table)
        returnAgreement = LoadObject(table)    ' this function is coded down below

        connection.Close()

        Return returnAgreement
    End Function
    '---------------------------------------------------
    ' Load Object                         
    '---------------------------------------------------
    Public Shared Function LoadObject(ByVal table As System.Data.DataTable) As RentalAgreement
        Dim returnAgreement As RentalAgreement = Nothing

        If table IsNot Nothing Then
            Dim agreementID As Integer = 0
            Dim propertyID As Integer = 0
            Dim renterID As Integer = 0
            Dim agreementDate As DateTime = DateTime.Today
            Dim agreementAmount As Decimal = 0
            Dim leaseStartDate As DateTime = DateTime.Today
            Dim leaseEndDate As DateTime = DateTime.MaxValue
            Dim hasPaidDamageDeposit As Boolean

            If table.Rows.Count > 1 Then
                Dim row As System.Data.DataRow = table.Rows(0)
                agreementID = System.Convert.ToInt32(row("AgreementID"))
                propertyID = System.Convert.ToInt32(row("PropertyID"))
                renterID = System.Convert.ToInt32(row("RenterID"))
                agreementDate = System.Convert.ToDateTime(row("AgreementDate"))
                agreementAmount = System.Convert.ToDecimal(row("AgreementAmount"))
                leaseStartDate = System.Convert.ToDateTime(row("LeaseStartDate"))
                leaseEndDate = System.Convert.ToDateTime(row("LeaseEndDate"))
                hasPaidDamageDeposit = System.Convert.ToBoolean(row("hasPaidDamageDeposit"))

                returnAgreement = New RentalAgreement(agreementID, propertyID, renterID, agreementDate, agreementAmount, leaseStartDate, leaseEndDate, hasPaidDamageDeposit)
            End If
        End If

        Return returnAgreement
    End Function

    'Public Sub New(ByVal filter As RentalAgreementFilterType, ByVal searchValue As String)
    '    Dim whereStatement As String

    '    whereStatement = BuildWhereStatement(filter, searchValue)

    '    Dim tempAgreements As RentalAgreementCollection = RentalAgreementCollection.QueryDatabase(whereStatement)
    '    For Each tempAgreement In tempAgreements
    '        If tempAgreement IsNot Nothing Then
    '            MyBase.Add(tempAgreement)
    '        End If
    '    Next
    'End Sub

    '---------------------------------------------------
    ' Build Where Statement                                     
    '---------------------------------------------------
    'Public Shared Function BuildWhereStatement(ByVal filter As RentalAgreementFilterType, ByVal searchValue As String) As String
    '    Dim columnName As String = String.Empty
    '    Dim returnString As String = String.Empty

    '    Select Case filter
    '        Case RentalAgreementFilterType.AgreementDate
    '            Dim startSearchDate As DateTime = System.Convert.ToDateTime(searchValue)
    '            Dim endSearchDate As DateTime
    '            endSearchDate = startSearchDate.AddDays(1)
    '            Dim whereStatement As String
    '            whereStatement = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE AgreementDate >= #{0}# AND AgreementDate < #{1}#", _
    '                                            startSearchDate.ToString("MM/dd/yyyy"), endSearchDate.ToString("MM/dd/yyyy"))
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, whereStatement, searchValue)

    '        Case RentalAgreementFilterType.hasPaidDamageDeposit
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE hasPaidDamageDeposit = {0} ", searchValue)

    '        Case RentalAgreementFilterType.ID
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE AgreementID = {0} ", searchValue)

    '        Case RentalAgreementFilterType.LeaseAmount
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE AgreementAmount = {0} ", searchValue)

    '        Case RentalAgreementFilterType.LeaseEndDate
    '            Dim startSearchDate As DateTime = System.Convert.ToDateTime(searchValue)
    '            Dim endSearchDate As DateTime
    '            endSearchDate = startSearchDate.AddDays(1)
    '            Dim whereStatement As String
    '            whereStatement = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE LeaseEndDate >= #{0}# AND LeaseEndDate < #{1}#", _
    '                                            startSearchDate.ToString("MM/dd/yyyy"), endSearchDate.ToString("MM/dd/yyyy"))
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, whereStatement, searchValue)

    '        Case RentalAgreementFilterType.LeaseStartDate
    '            Dim startSearchDate As DateTime = System.Convert.ToDateTime(searchValue)
    '            Dim endSearchDate As DateTime
    '            endSearchDate = startSearchDate.AddDays(1)
    '            Dim whereStatement As String
    '            whereStatement = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE LeaseStartDate >= #{0}# AND LeaseStartDate < #{1}#", _
    '                                            startSearchDate.ToString("MM/dd/yyyy"), endSearchDate.ToString("MM/dd/yyyy"))
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, whereStatement, searchValue)

    '        Case RentalAgreementFilterType.PropertyId
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE PropertyID = {0} ", searchValue)

    '        Case RentalAgreementFilterType.RenterId
    '            returnString = String.Format(System.Globalization.CultureInfo.InvariantCulture, " WHERE RenterID = {0} ", searchValue)
    '    End Select

    '    Return returnString
    'End Function
End Class



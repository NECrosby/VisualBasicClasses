Imports System
Imports System.Collections

Public Class EmployeeCollection
    Inherits System.Collections.ObjectModel.Collection(Of Employee)

    '---------------------------------------------------
    ' Query Database                                     
    '---------------------------------------------------

    Public Shared Function QueryDatabase() As EmployeeCollection
        Dim Employees As New EmployeeCollection
        Dim query As String = "SELECT empno, status, lastname, firstname, mi, phone, pager, email, " & _
        "manager, supervisor, deptname, mailstop, shift, deptno, deptdesc, hiredate, hphone, nickname, " & _
        "termdate, emptype, birth, jobtitle, fullname, jobcode, P_superno, company, isPerson, isactivediruser FROM vUserlist "
        Dim connectionString As String = "Data Source=Wrench\Wrench;Initial Catalog=TestUserlist;Trusted_Connection=True;"
        Dim connection As SqlClient.SqlConnection

        Try
            ' Create a Connection 
            connection = New SqlClient.SqlConnection(connectionString)
            ' The SQL string contains a SQL statement
            Dim command As New SqlClient.SqlCommand(query, connection)
            ' Set the Connection to the new OleDbConnection. command.Connection = connection
            ' Open the connection and execute the command. 

            Dim DataAdapter As New SqlClient.SqlDataAdapter  ' Serves as a bridge between a DataTable and a DataSource(database)
            connection.Open()                                ' Open a connection to a database
            DataAdapter.SelectCommand = command              ' Executes the Select Statement
            Dim table As New Data.DataTable                  ' DataTable to hold the result
            DataAdapter.Fill(table)                          ' Fill the DataTable via the DataAdapter
            Employees = LoadObjectCollection(table)
            connection.Close()                               ' Close the connection

        Catch ex As Exception
            MessageBox.Show(ex.Message)                      ' Show any Error 
        End Try

        Return Employees

    End Function

    '---------------------------------------------------
    ' Load Object Collection                          
    '---------------------------------------------------

    Private Shared Function LoadObjectCollection(ByVal table As Data.DataTable) As EmployeeCollection
        Dim employeeInfo As New EmployeeCollection

        If table IsNot Nothing Then
            Dim empNo As String = String.Empty
            Dim status As String = String.Empty
            Dim lastName As String = String.Empty
            Dim firstName As String = String.Empty
            Dim mi As String = String.Empty
            Dim phone As String = String.Empty
            Dim pager As String = String.Empty
            Dim email As String = String.Empty
            Dim manager As String = String.Empty
            Dim supervisor As String = String.Empty
            Dim deptName As String = String.Empty
            Dim mailStop As String = String.Empty
            Dim shift As String = String.Empty
            Dim deptNo As String = String.Empty
            Dim deptDesc As String = String.Empty
            Dim hireDate As DateTime = DateTime.MinValue
            Dim hPhone As String = String.Empty
            Dim nickname As String = String.Empty
            Dim termDate As DateTime = DateTime.MinValue
            Dim empType As String = String.Empty
            Dim birth As String = String.Empty
            Dim jobTitle As String = String.Empty
            Dim fullName As String = String.Empty
            Dim jobCode As String = String.Empty
            Dim p_superNo As String = String.Empty
            Dim company As String = String.Empty
            Dim isPerson As Integer = 0
            Dim isActiveDirUser As Integer = 0
            Dim hasBeenRehired As Boolean = False


            For Each row As Data.DataRow In table.Rows
                If Not DBNull.Value.Equals(row("empno")) Then empNo = row("empno").ToString Else empNo = String.Empty
                If Not DBNull.Value.Equals(row("status")) Then status = row("status").ToString Else status = String.Empty
                If Not DBNull.Value.Equals(row("lastName")) Then lastName = row("lastName").ToString Else lastName = String.Empty
                If Not DBNull.Value.Equals(row("firstName")) Then firstName = row("firstName").ToString Else firstName = String.Empty
                If Not DBNull.Value.Equals(row("mi")) Then mi = row("mi").ToString Else mi = String.Empty
                If Not DBNull.Value.Equals(row("phone")) Then phone = row("phone").ToString Else phone = String.Empty
                If Not DBNull.Value.Equals(row("pager")) Then pager = row("pager").ToString Else pager = String.Empty
                If Not DBNull.Value.Equals(row("email")) Then email = row("email").ToString Else email = String.Empty
                If Not DBNull.Value.Equals(row("manager")) Then manager = row("manager").ToString Else manager = String.Empty
                If Not DBNull.Value.Equals(row("supervisor")) Then supervisor = row("supervisor").ToString Else supervisor = String.Empty
                If Not DBNull.Value.Equals(row("deptName")) Then deptName = row("deptName").ToString Else deptName = String.Empty
                If Not DBNull.Value.Equals(row("mailStop")) Then mailStop = row("mailStop").ToString Else mailStop = String.Empty
                If Not DBNull.Value.Equals(row("shift")) Then shift = row("shift").ToString Else shift = String.Empty
                If Not DBNull.Value.Equals(row("deptNo")) Then deptNo = row("deptNo").ToString Else deptNo = String.Empty
                If Not DBNull.Value.Equals(row("deptDesc")) Then deptDesc = row("deptDesc").ToString Else deptDesc = String.Empty

                ' ------------------------------------------------------------------------------------------------------------------------------------
                If Not DBNull.Value.Equals(row("hireDate")) Then hireDate = System.Convert.ToDateTime(row("hireDate")) Else hireDate = DateTime.MinValue
                ' ------------------------------------------------------------------------------------------------------------------------------------

                If Not DBNull.Value.Equals(row("hphone")) Then hPhone = row("hphone").ToString Else hPhone = String.Empty
                If Not DBNull.Value.Equals(row("nickname")) Then nickname = row("nickname").ToString Else nickname = String.Empty

                ' ------------------------------------------------------------------------------------------------------------------------------------
                If Not DBNull.Value.Equals(row("termDate")) Then termDate = System.Convert.ToDateTime(row("termDate")) Else termDate = DateTime.MaxValue
                ' ------------------------------------------------------------------------------------------------------------------------------------

                If Not DBNull.Value.Equals(row("empType")) Then empType = row("empType").ToString Else empType = String.Empty

                ' ------------------------------------------------------------------------------------------------------------------------------------
                If Not DBNull.Value.Equals(row("birth")) Then birth = row("birth").ToString Else birth = String.Empty
                ' ------------------------------------------------------------------------------------------------------------------------------------

                If Not DBNull.Value.Equals(row("jobTitle")) Then jobTitle = row("jobTitle").ToString Else jobTitle = String.Empty
                If Not DBNull.Value.Equals(row("fullName")) Then fullName = row("fullName").ToString Else fullName = String.Empty
                If Not DBNull.Value.Equals(row("jobCode")) Then jobCode = row("jobCode").ToString Else jobCode = String.Empty
                If Not DBNull.Value.Equals(row("p_SuperNo")) Then p_superNo = row("p_superNo").ToString Else p_superNo = String.Empty
                If Not DBNull.Value.Equals(row("company")) Then company = row("company").ToString Else company = String.Empty

                ' ------------------------------------------------------------------------------------------------------------------------------------
                If Not DBNull.Value.Equals(row("isPerson")) Then isPerson = CInt(row("isPerson")) Else isPerson = String.Empty
                If Not DBNull.Value.Equals(row("isActiveDirUser")) Then isActiveDirUser = CInt(row("iSActiveDirUser")) Else isActiveDirUser = String.Empty
                ' ------------------------------------------------------------------------------------------------------------------------------------

                Dim employee As New Employee(empNo, status, lastName, firstName, mi, phone, pager, email, manager, supervisor, deptName, mailStop, shift, deptNo, _
                                             deptDesc, hireDate, hPhone, nickname, termDate, empType, birth, jobTitle, fullName, jobCode, p_superNo, company, _
                                             isPerson, isActiveDirUser, hasBeenRehired)
                employeeInfo.Add(employee)
            Next
        End If

        Return employeeInfo
    End Function

    '---------------------------------------------------
    ' Get Employee by Employee Number                          
    '---------------------------------------------------

    ' This function is being passed a parameter "EmployeeNumber" which is a property of an Employee Object
    ' EmployeeNumber property has a variable declared in the Employeee Object to hold the property's info
    ' from the EmployeeNumber text box on the Calculate PDO form 
    ' the function is going to return an employee info 
    Public Function GetEmployeeByEmployeeNumber(ByVal EmployeeNumber As String) As Employee
        Dim returnEmployee As Employee = Nothing                    ' Functions have to return a value

        For Each tempEmployee As Employee In Me                     ' Loop thru this collection object of employees (This function is in the Collection Object)
            If tempEmployee.EmployeeEmpNo = EmployeeNumber Then     ' Here is the condition to find the match of requested employee by number
                returnEmployee = tempEmployee                       ' This is setting the match to the return value
            End If
        Next

        Return returnEmployee                                       ' Returning the Employee info the call
    End Function


End Class



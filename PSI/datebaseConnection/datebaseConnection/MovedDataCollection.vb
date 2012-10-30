Imports System
Imports System.Collections

Public Class movedDataCollection
    Inherits System.Collections.ObjectModel.Collection(Of movedData)
    'Public Sub Add(_dateTime As String, machine As String, & _
    '               empId As String, comments As String, statusCode As String, & _
    '               type as String, lot As String)
    '    Me._dateTime = DateTime
    '    Me._machine = machine
    '    Me._empID = empID
    '    Me._comments = comments
    '    Me._statusCode = statusCode
    '    Me._type = Type
    '    Me._lot = lot
    'End Sub

    'Public Property dateTime() As DateTime
    '    Get
    '        Return dateTime
    '    End Get
    '    Set(ByVal value As DateTime)
    '        dateTime = value
    '    End Set
    'End Property

    '---------------------------------------------------
    ' QueryDatabase                                       COMMENT
    '---------------------------------------------------
    Public Shared Function QueryDatabase() As movedDataCollection
        Dim ReturnMoveDatas As New movedDataCollection

        'This is the declaration of a string variable that will hold the query text needed for access SQL commands next 5 lines
        'Dim query As String = "SELECT Date_time, machine, 'N/A' as lot, empid, status1_code, 'machine status' as type, comments " & _
        '                      "FROM  [A16 - Equip History_csv]" & _
        '                      "UNION " & _
        '                      "SELECT Date_time, machine, lot, empid, 'N/A' as status1_code, 'inline move' as type,'N/A'  as comments " & _
        '                      "FROM [A11X - Inline Moves Live Data];"

        Dim query As String = "SELECT Date_time, machine, lot, empid, status1_code, type, comments FROM [Join on Machine]WHERE machine = 'ECLIPSE5' ORDER BY comments"

        'string variable that hold the connection to the Access database, Provider is the type of DB, Source is where the database is located, Security is off.
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\practiceExercise06082011.accdb;Persist Security Info=False;"


        Dim connection As OleDb.OleDbConnection  'variable to hold the connection to a OLEDatabase
        Try 'Try block meaning try this and if this doesn't work catch the exception - 

            ' Create a Connection -- This is establishing a new connection using the connectionString variable 
            'The variable is used incase it is need many time but changes (then the change is only done to the main string variable.
            connection = New OleDb.OleDbConnection(connectionString)

            ' The query string variable contains a SQL statement
            Dim command As New OleDb.OleDbCommand(query, connection)
            'This is a variable that is a command for the connection using the query string and the connection to the new OleDB Connection.
            'THIS IS CHET COMMENT -- Set the Connection to the new OleDbConnection. command.Connection = connection
            'THIS IS CHET COMMENT -- Open the connection and execute the command. 

            Dim DataAdapter As New OleDb.OleDbDataAdapter  ' Serves as a bridge between a DataTable and a DataSource(database)
            connection.Open()                              ' Open function to connect to database
            DataAdapter.SelectCommand = command            ' runs the SQL commands after obtaining the connection to the DB 
            Dim table As New Data.DataTable                ' DataTable to hold the result
            DataAdapter.Fill(table)                        ' Fill the DataTable via the DataAdapter
            'MessageBox.Show(table.Rows.Count.ToString)    ' Opens a message box that shows then # of rows in the query
            ReturnMoveDatas = LoadObjectCollection(table)
            'Me.DataGridViewMoveData.DataSource = table    ' displays the Data Grid with query data
            connection.Close()                             ' Close the connection 

            ' displays the Data Grid with query data

            'The following code organizes the column as desired. The Column names are used and found on the 
            'Designer view of the form_naomi_comments file.


        Catch ex As Exception
            MessageBox.Show(ex.Message)                    ' Show any Error 
        End Try

        Return ReturnMoveDatas
    End Function

    '---------------------------------------------------
    ' LoadObjectCollection                          
    '---------------------------------------------------
    Private Shared Function LoadObjectCollection(ByVal table As Data.DataTable) As movedDataCollection   'Loading a Collection object with info from the DB 1 row at a time
        Dim ReturnMoveDatas As New movedDataCollection
        If table IsNot Nothing Then  'is the table (DB) is not empty then fill the Collection object
            'creating variables for the subroutine
            Dim moveDateTime As DateTime = DateTime.MinValue 'Holds the date and time of event
            Dim machine As String = String.Empty             'Holds the machine name
            Dim empid As String = String.Empty               'Holds the employee ID
            Dim status1Code As String = String.Empty         'Holds the status code of the lot
            Dim type As String = String.Empty                'Holds event type either Inline Move or Machine Status
            Dim lot As String = String.Empty                 'Holds the lot number
            Dim comments As String = String.Empty            'Holds any comments

            For Each row As Data.DataRow In table.Rows 'loop thru the table rows
                moveDateTime = System.Convert.ToDateTime(row("Date_time"))  'pulling the data from the column Date_Time in the DB
                machine = row("machine").ToString                           'pulling the machine data from DB
                empid = row("empid").ToString                               'pulling the empid from the DB 
                lot = row("lot").ToString
                status1Code = row("status1_code").ToString                  'pulling the status code from the DB
                type = row("type").ToString
                comments = row("comments").ToString                         'pulling the comments from the DB

                'variable to hold all the new data pulled from the row
                Dim move As New movedData(moveDateTime, machine, empid, comments, status1Code, type, lot)
                ReturnMoveDatas.Add(move) 'now this is adding the data to the collection object
            Next
        End If

        Return ReturnMoveDatas
    End Function

End Class

Public Class FormCalculatePDO
    Dim _employees As EmployeeCollection                            ' Declare a collection that will be used

    Public Sub New(ByVal employees As EmployeeCollection)           ' Every form HAS to have a SUB NEW
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._employees = employees
    End Sub

    Private Sub ButtonGetEmployeeInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGetEmployeeInfo.Click
        Dim myEmployee As Employee = Me._employees.GetEmployeeByEmployeeNumber(TextBoxEmployeeID.Text)

        If myEmployee IsNot Nothing Then                                ' If the employee number entered is valid supply the Fullname, Hire date
            LabelEmployeeFullName.Visible = True
            TextBoxEmployeeFullName.Visible = True
            TextBoxEmployeeFullName.Text = myEmployee.EmployeeFullname
            LabelEmployeeHireDate.Visible = True
            TextBoxHireDate.Visible = True
            TextBoxHireDate.Text = myEmployee.EmployeeHireDate
            If myEmployee.EmployeeTermDate <> DateTime.MaxValue Then    ' If the employee is still employed DO NOT display the TermDate box
                LabelTermDate.Visible = True
                TextBoxTerminationDate.Visible = True
                TextBoxTerminationDate.Text = myEmployee.EmployeeTermDate

            End If
        Else
            LabelAmountOfYearsOfService.Visible = True                  ' Display a message if the employee number is not valid
            LabelAmountOfYearsOfService.Text = "Please enter a valid employee number. Thank you!"
            TextBoxEmployeeID.Clear()
            TextBoxEmployeeID.Focus()
        End If

    End Sub

    Private Sub ButtonCalculatePDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCalculatePDO.Click
        ' myEmployee is a employee (not a NEW employee) from this collection 
        ' call the "getEmployeeByEmployeeNumber function with a parameter of employee number that was entered in the text box
        Dim myEmployee As Employee = Me._employees.GetEmployeeByEmployeeNumber(TextBoxEmployeeID.Text)
        Dim numberOfPDO As Integer

        If myEmployee IsNot Nothing Then                                ' If the employee number entered is valid supply the Fullname, Hire date
            numberOfPDO = myEmployee.CalculatePaidDaysOff

            If myEmployee.EmployeeStatus = "A" And myEmployee.EmployeeHasBeenRehired Then
                ' If active but rehired --  setting visibility and message
                LabelAmountOfYearsOfService.Visible = True
                LabelAmountOfYearsOfService.Text = "Information is not available at this time. Original Hire date is needed."
            ElseIf myEmployee.EmployeeStatus = "A" And (myEmployee.EmployeeHasBeenRehired = False) Then
                ' if active and has never been terminated or rehired
                LabelAmountOfYearsOfService.Visible = True
                LabelAmountOfPDO.Visible = True
                LabelAmountOfYearsOfService.Text = myEmployee.EmployeeFullname.ToString & " has served " & myEmployee.YearsOfService.ToString & " years."
                LabelAmountOfPDO.Text = numberOfPDO & " days of PDO will be earned this year."
            ElseIf myEmployee.EmployeeStatus = "T" Then
                ' employment has been terminated
                LabelAmountOfYearsOfService.Visible = True
                LabelAmountOfYearsOfService.Text = TextBoxEmployeeFullName.Text & " is no longer employed, but served " & myEmployee.YearsOfService.ToString & " years."
            End If
        End If
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click

        ' Clearing and resetting visibilty on text boxes and labels
        TextBoxEmployeeID.Clear()
        LabelEmployeeFullName.Visible = False
        TextBoxEmployeeFullName.Visible = False
        TextBoxEmployeeFullName.Clear()
        LabelEmployeeHireDate.Visible = False
        TextBoxHireDate.Visible = False
        TextBoxHireDate.Clear()
        LabelTermDate.Visible = False
        TextBoxTerminationDate.Visible = False
        TextBoxTerminationDate.Clear()
        LabelAmountOfYearsOfService.Visible = False
        LabelAmountOfYearsOfService.Text = String.Empty
        LabelAmountOfPDO.Visible = False
        LabelAmountOfPDO.Text = String.Empty

        TextBoxEmployeeID.Focus()
    End Sub

    Private Sub ButtonExitCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExitCalculate.Click
        Me.Close()
    End Sub
End Class
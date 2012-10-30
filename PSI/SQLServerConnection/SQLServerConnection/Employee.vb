Public Class Employee

    '---------------------------------------------------
    ' Class Level Variables                                     
    '---------------------------------------------------
    Private _empNo As String = String.Empty
    Private _status As String = String.Empty
    Private _lastName As String = String.Empty
    Private _firstName As String = String.Empty
    Private _mi As String = String.Empty
    Private _phone As String = String.Empty
    Private _pager As String = String.Empty
    Private _email As String = String.Empty
    Private _manager As String = String.Empty
    Private _supervisor As String = String.Empty
    Private _deptName As String = String.Empty
    Private _mailStop As String = String.Empty
    Private _shift As String = String.Empty
    Private _deptNo As String = String.Empty
    Private _deptDesc As String = String.Empty
    Private _hireDate As DateTime = DateTime.MinValue
    Private _hPhone As String = String.Empty
    Private _nickname As String = String.Empty
    Private _termDate As DateTime = DateTime.MinValue
    Private _empType As String = String.Empty
    Private _birth As String = String.Empty
    Private _jobTitle As String = String.Empty
    Private _fullName As String = String.Empty
    Private _jobCode As String = String.Empty
    Private _p_superNo As String = String.Empty
    Private _company As String = String.Empty
    Private _isPerson As Integer = 0
    Private _isActiveDirUser As Integer = 0
    Private _hasBeenRehired As Boolean = False


    '---------------------------------------------------
    ' Employee Constructor                                    
    '---------------------------------------------------
    Public Sub New()

    End Sub

    Public Sub New(ByVal empEmpNo As String, ByVal empStatus As String, ByVal empLastName As String, ByVal empFirstName As String, _
                   ByVal empMi As String, ByVal empPhone As String, ByVal empPager As String, ByVal empEmail As String, ByVal empManager As String, _
                   ByVal empSupervisor As String, ByVal empDeptName As String, ByVal empMailStop As String, ByVal empShift As String, _
                   ByVal empDeptNo As String, ByVal empDeptDesc As String, ByVal empHireDate As DateTime, ByVal empHphone As String, _
                   ByVal empNickname As String, ByVal empTermDate As DateTime, ByVal empEmpType As String, ByVal empBirth As String, _
                   ByVal empJobTitle As String, ByVal empFullName As String, ByVal empJobCode As String, ByVal emp_P_superNo As String, _
                   ByVal empCompany As String, ByVal empIsPerson As Integer, ByVal empIsActiveDirUser As Integer, ByVal empHasBeenRehired As Boolean)


        Me._empNo = empEmpNo
        Me._status = empStatus
        Me._lastName = empLastName
        Me._firstName = empFirstName
        Me._mi = empMi
        Me._phone = empPhone
        Me._pager = empPager
        Me._email = empEmail
        Me._manager = empManager
        Me._supervisor = empSupervisor
        Me._deptName = empDeptName
        Me._mailStop = empMailStop
        Me._shift = empShift
        Me._deptNo = empDeptNo
        Me._deptDesc = empDeptDesc
        Me._hireDate = empHireDate
        Me._hPhone = empHphone
        Me._nickname = empNickname
        Me._termDate = empTermDate
        Me._empType = empEmpType
        Me._birth = empBirth
        Me._jobTitle = empJobTitle
        Me._fullName = empFullName
        Me._jobCode = empJobCode
        Me._p_superNo = emp_P_superNo
        Me._company = empCompany
        Me._isPerson = empIsPerson
        Me._isActiveDirUser = empIsActiveDirUser
        Me._hasBeenRehired = empHasBeenRehired


    End Sub

    '---------------------------------------------------
    ' Properties                                     
    '---------------------------------------------------

    Public Property EmployeeEmpNo() As String
        Get
            Return Me._empNo
        End Get
        Set(ByVal value As String)
            Me._empNo = value
        End Set
    End Property

    Public Property EmployeeStatus() As String
        Get
            Return Me._status
        End Get
        Set(ByVal value As String)
            Me._status = value
        End Set
    End Property

    Public Property EmployeeLastName() As String
        Get
            Return Me._lastName
        End Get
        Set(ByVal value As String)
            Me._lastName = value
        End Set
    End Property

    Public Property EmployeeFirstName() As String
        Get
            Return Me._firstName
        End Get
        Set(ByVal value As String)
            Me._firstName = value
        End Set
    End Property

    Public Property EmployeeMI() As String
        Get
            Return Me._mi
        End Get
        Set(ByVal value As String)
            Me._mi = value
        End Set
    End Property

    Public Property EmployeePhone() As String
        Get
            Return Me._phone
        End Get
        Set(ByVal value As String)
            Me._phone = value
        End Set
    End Property

    Public Property EmployeePager() As String
        Get
            Return Me._pager
        End Get
        Set(ByVal value As String)
            Me._pager = value
        End Set
    End Property

    Public Property EmployeeEmail() As String
        Get
            Return Me._email
        End Get
        Set(ByVal value As String)
            Me._email = value
        End Set
    End Property

    Public Property EmployeeMananger() As String
        Get
            Return Me._manager
        End Get
        Set(ByVal value As String)
            Me._manager = value
        End Set
    End Property

    Public Property EmployeeSupervisor() As String
        Get
            Return Me._supervisor
        End Get
        Set(ByVal value As String)
            Me._supervisor = value
        End Set
    End Property

    Public Property EmployeeDeptName() As String
        Get
            Return Me._deptName
        End Get
        Set(ByVal value As String)
            Me._deptName = value
        End Set
    End Property

    Public Property EmployeeMailStop() As String
        Get
            Return Me._mailStop
        End Get
        Set(ByVal value As String)
            Me._mailStop = value
        End Set
    End Property

    Public Property EmployeeShift() As String
        Get
            Return Me._shift
        End Get
        Set(ByVal value As String)
            Me._shift = value
        End Set
    End Property

    Public Property EmployeeDeptNo() As String
        Get
            Return Me._deptNo
        End Get
        Set(ByVal value As String)
            Me._deptNo = value
        End Set
    End Property

    Public Property EmployeeDeptDesc() As String
        Get
            Return Me._deptDesc
        End Get
        Set(ByVal value As String)
            Me._deptDesc = value
        End Set
    End Property

    Public Property EmployeeHireDate() As DateTime
        Get
            Return Me._hireDate
        End Get
        Set(ByVal value As DateTime)
            Me._hireDate = value
        End Set
    End Property

    Public Property EmployeeHPhone() As String
        Get
            Return Me._hPhone
        End Get
        Set(ByVal value As String)
            Me._hPhone = value
        End Set
    End Property

    Public Property EmployeeNickname() As String
        Get
            Return Me._nickname
        End Get
        Set(ByVal value As String)
            Me._nickname = value
        End Set
    End Property

    Public Property EmployeeTermDate() As DateTime
        Get
            Return Me._termDate
        End Get
        Set(ByVal value As DateTime)
            Me._termDate = value
        End Set
    End Property

    Public Property EmployeeEmpType() As String
        Get
            Return Me._empType
        End Get
        Set(ByVal value As String)
            Me._empType = value
        End Set
    End Property

    Public Property EmployeeBirth() As String
        Get
            Return Me._birth
        End Get
        Set(ByVal value As String)
            Me._birth = value
        End Set
    End Property

    Public Property EmployeeJobTitle() As String
        Get
            Return Me._jobTitle
        End Get
        Set(ByVal value As String)
            Me._jobTitle = value
        End Set
    End Property

    Public Property EmployeeFullname() As String
        Get
            Return Me._fullName
        End Get
        Set(ByVal value As String)
            Me._fullName = value
        End Set
    End Property

    Public Property EmployeeJobCode() As String
        Get
            Return Me._jobCode
        End Get
        Set(ByVal value As String)
            Me._jobCode = value
        End Set
    End Property

    Public Property EmployeeP_SuperNo() As String
        Get
            Return Me._p_superNo
        End Get
        Set(ByVal value As String)
            Me._p_superNo = value
        End Set
    End Property

    Public Property EmployeeCompany() As String
        Get
            Return Me._company
        End Get
        Set(ByVal value As String)
            Me._company = value
        End Set
    End Property

    Public Property EmployeeIsPerson() As Integer
        Get
            Return Me._isPerson
        End Get
        Set(ByVal value As Integer)
            Me._isPerson = value
        End Set
    End Property

    Public Property EmployeeIsActiveDirUser() As Integer
        Get
            Return Me._isActiveDirUser
        End Get
        Set(ByVal value As Integer)
            Me._isActiveDirUser = value
        End Set
    End Property

    Public ReadOnly Property EmployeeHasBeenRehired() As Boolean
        Get
            If Me._status = "A" And Me._hireDate > Me._termDate Then
                Me._hasBeenRehired = True
            End If

            Return Me._hasBeenRehired
        End Get
    End Property

    Public ReadOnly Property YearsOfService() As Integer
        Get
            Dim yearsOfServiceValue As Integer
            Dim numberOfDays As TimeSpan
            Dim todaysDateTime As DateTime = DateTime.Now

            If Me._termDate <> DateTime.MaxValue Then
                numberOfDays = Me._termDate.Subtract(Me._hireDate)                      ' Statements if terminated
                yearsOfServiceValue = System.Convert.ToInt32(numberOfDays.Days / 365)

            Else
                numberOfDays = todaysDateTime.Subtract(Me._hireDate)                    ' Statements if still employed
                yearsOfServiceValue = System.Convert.ToInt32(numberOfDays.Days / 365)
            End If

            Return yearsOfServiceValue
        End Get
    End Property

    '---------------------------------------------------
    ' Calculate Paid Days Off -- Function                                     
    '---------------------------------------------------

    Public Function CalculatePaidDaysOff() As Integer

        Dim paidDaysOff As Integer = 0

        If Me.YearsOfService > 14 Then
            paidDaysOff = 25
        ElseIf Me.YearsOfService > 4 Then
            paidDaysOff = 20
        ElseIf Me.YearsOfService > 0 Then
            paidDaysOff = 15
        End If

        Return paidDaysOff
    End Function
End Class

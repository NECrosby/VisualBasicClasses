'****************************************
'   Name:  	DocconFileMoverException
'   Author: crosbyn
'   Date:   8/5/2011 2:56:29 PM
'   Desc:   An Exception Object for a the root namespace DocconFileMover
'****************************************
Option Strict On
Option Explicit On
' - Add Exception Types Here -
Public Enum DocconFileMoverExceptionType
    ArgumentException
    ArgumentNullException
    DirectoryNotFoundException
    FileNotFound
    IOException
    NotSupportedException
    PathTooLongException
    SecurityException
    UnauthorizedAccessException
    Unknown
End Enum

#Region "DocconFileMoverException"
<Serializable()> _
Public Class DocconFileMoverException
  Inherits SystemException

#Region "Class Level Variables"

    Private _Xtype As DocconFileMoverExceptionType

#End Region
#Region "Initialize"
    '************************************
    '               New
    '************************************
    Public Sub New()
        MyBase.New()
    End Sub
    '************************************
    '               New
    '************************************
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
    '************************************
    '               New
    '************************************
    Public Sub New(ByVal message As String, ByVal lowerException As Exception)
        MyBase.New(message, lowerException)
    End Sub
    '************************************
    '               New
    '************************************
    Public Sub New(ByVal message As String, ByVal nameValueType As DocconFileMoverExceptionType, ByVal lowerException As Exception)
        MyBase.New(message, lowerException)
        Me._Xtype = nameValueType
    End Sub


    '************************************
    '               New
    '************************************
    Protected Sub New(ByVal serialInfo As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(serialInfo, context)
    End Sub

#End Region
#Region "Finalize"
    ''************************************
    ''             Finalize
    ''************************************
    'Protected Overrides Sub Finalize()
    '  MyBase.Finalize()
    'End Sub
#End Region
#Region "Properties"

    ''' <summary>
    ''' An Enumerated Datatype which tells what type of Data Access Exception was thrown.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' ************************************************
    '''   ExceptionType
    ''' ************************************************
    Public ReadOnly Property ExceptionType() As DocconFileMoverExceptionType
        Get
            Return _Xtype
        End Get
    End Property
    ''' ************************************************
    '''   DataAccess
    ''' ************************************************
    'Public ReadOnly Property DataAccess() As Idc.Common.Interfaces.IDataAccess
    '    Get
    '        Return mDataAccess
    '    End Get
    'End Property
#End Region

#Region "SubRoutines"
#Region "SubRoutines.Public"

    '-- GetObjectData overrides must always have a demand for SerializationFormatter.
    '   GetObjectData is protected by a security check for 
    '   System.Security.Permissions.SecurityPermissionAttribute.SerializationFormatter security permission. 
    '   If an implementation of GetObjectData is not protected by the same security check, callers can 
    '   call the implementation to bypass security on the interface and gain access to data serialized 
    '   by the type
    '<System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter:=True)> _
    <System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter:=True)> _
            Public Overrides Sub GetObjectData(ByVal info As System.Runtime.Serialization.SerializationInfo, _
                                               ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.GetObjectData(info, context)
    End Sub
#End Region

#End Region
#Region "Functions"
#Region "Functions.Public"
    '********************************************
    '           ToString 
    '********************************************
    Public Overrides Function ToString() As String
        Dim sToString As New System.Text.StringBuilder
        'Dim i As Integer
        sToString.Append("Message: ")
        sToString.Append(MyBase.Message)
        sToString.Append(System.Environment.NewLine)

        'If Not Me.mDataAccess Is Nothing Then
        '    sToString.Append("Source: ")
        '    sToString.Append(Me.mDataAccess.Source)
        'End If
        sToString.Append(System.Environment.NewLine)

        sToString.Append("Exception Type: ")
        sToString.Append(_Xtype.ToString)
        sToString.Append(System.Environment.NewLine)

        'If Not Me.mDataAccess Is Nothing Then
        '    sToString.Append("DataAccess Object: ")
        '    sToString.Append(Me.mDataAccess.ToString)
        'End If
        sToString.Append(System.Environment.NewLine)

        If Not MyBase.InnerException Is Nothing Then
            Dim oDict As DictionaryEntry
            For Each oDict In MyBase.InnerException.Data
                sToString.Append(oDict.Key.ToString + " - " + oDict.Value.ToString)
                sToString.Append(System.Environment.NewLine)
            Next
        Else
            sToString.Append(System.Environment.NewLine)
        End If

        If Not MyBase.InnerException Is Nothing Then
            sToString.Append("Inner Exception: ")
            sToString.Append(MyBase.InnerException.ToString)
        Else
            sToString.Append("Nothing")
        End If
        sToString.Append(System.Environment.NewLine)
        sToString.Append("Data: ")

        Return sToString.ToString
    End Function
#End Region
#End Region
End Class
#End Region

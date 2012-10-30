'-------------------------------------------------------------
' Enumeration - Qualifier Type
'-------------------------------------------------------------
Public Enum QualifierType
    qualifierAND
    qualifierOR
End Enum

'-------------------------------------------------------------
' Search Class
'-------------------------------------------------------------
Public Class Search(Of T)
    '-------------------------------------------------------------
    ' Class Variables
    '-------------------------------------------------------------
    Private _FilterBy As T
    Private _Value As System.String
    Private _Qualifier As QualifierType
    '-------------------------------------------------------------
    ' Constructors
    '-------------------------------------------------------------
    Public Sub New()
        Me._Qualifier = QualifierType.qualifierAND
    End Sub
    Public Sub New(ByVal filter As T, ByVal value As String, ByVal qualifier As QualifierType)
        Me._FilterBy = FilterBy
        Me._Value = value
        Me._Qualifier = qualifier
    End Sub
    '-------------------------------------------------------------
    ' Properties
    '-------------------------------------------------------------
    Public Property FilterBy() As T
        Get
            Return Me._FilterBy
        End Get
        Set(ByVal value As T)
            Me._FilterBy = value
        End Set
    End Property
    Public Property Value() As System.String
        Get
            Return Me._Value
        End Get
        Set(ByVal value As System.String)
            _Value = value
        End Set
    End Property
    Public Property Qualifier() As QualifierType
        Get
            Return Me._Qualifier
        End Get
        Set(ByVal value As QualifierType)
            Me._Qualifier = value
        End Set
    End Property
    '-------------------------------------------------------------
    ' Functions  -- Overrides Equals, ToString -- QualifierToString
    '-------------------------------------------------------------
    Public Function QualifierToString() As String
        Dim returnValue As String = String.Empty

        If Me._Qualifier = QualifierType.qualifierAND Or Me._Qualifier = QualifierType.qualifierOR Then
            If Me._Qualifier = Data.QualifierType.qualifierAND Then
                returnValue = " AND "
            ElseIf Me._Qualifier = Data.QualifierType.qualifierOR Then
                returnValue = " OR "
            End If
        End If

        Return returnValue
    End Function
    Public Overrides Function ToString() As String
        Dim returnValue As String = String.Empty

        returnValue = String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0} {1} = {2} ", Me.QualifierToString, Me._FilterBy, Me._Value)

        Return returnValue
    End Function
    Public Overrides Function Equals(ByVal obj As Object) As Boolean
        Dim returnValue As Boolean
        If obj IsNot Nothing Then
            If TypeOf obj Is Rental.Data.Search(Of T) Then
                Dim tempSearch As Rental.Data.Search(Of T)
                tempSearch = DirectCast(obj, Rental.Data.Search(Of T))
                If tempSearch.Value = Me._Value Then
                    If tempSearch.FilterBy.ToString = Me._FilterBy.ToString Then
                        If tempSearch.Qualifier = Me._Qualifier Then
                            returnValue = True
                        Else
                            returnValue = False
                        End If
                    End If
                End If
            End If
        End If

        Return returnValue
    End Function
    'Public Overrides Function GetHashCode() As Integer
    '    Return MyBase.GetHashCode()
    'End Function
End Class

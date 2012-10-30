Public Class DocconDirectory
    '--------------------------------------------------------
    ' DocconDirectory Object - Paths for Files -- Stored in Config Manager
    '--------------------------------------------------------

    ' Completed Documents Folder
    Dim _CompletedDocumentsPath As String = String.Empty
    ' Source Path
    Dim _ProprietarySourcePath As String = String.Empty
    Dim _SpecSourcePath As String = String.Empty
    ' Old Source Path
    Dim _OldProprietarySourcePath As String = String.Empty
    Dim _OldSpecSourcePath As String = String.Empty
    ' Form or Template Path
    Dim _FormPath As String = String.Empty
    'Dim _TemplatePath As String = String.Empty
    ' Network A Path
    Dim _ProprietaryNetworkLocationAPath As String = String.Empty
    Dim _SpecNetworkLocationAPath As String = String.Empty
    ' Network B Path
    Dim _ProprietaryNetworkLocationBPath As String = String.Empty
    Dim _SpecNetworkLocationBPath As String = String.Empty

    Public Sub New()

    End Sub

    Public Property CompletedDocumentsPath() As String
        Get
            Return Me._CompletedDocumentsPath
        End Get
        Set(ByVal value As String)
            Me._CompletedDocumentsPath = value
        End Set
    End Property
    Public Property ProprietarySourcePath() As String
        Get
            Return Me._ProprietarySourcePath
        End Get
        Set(ByVal value As String)
            Me._ProprietarySourcePath = value
        End Set
    End Property
    Public Property SpecSourcePath() As String
        Get
            Return Me._SpecSourcePath
        End Get
        Set(ByVal value As String)
            Me._SpecSourcePath = value
        End Set
    End Property
    Public Property OldProprietarySourcePath() As String
        Get
            Return Me._OldProprietarySourcePath
        End Get
        Set(ByVal value As String)
            Me._OldProprietarySourcePath = value
        End Set
    End Property
    Public Property OldSpecSourcePath() As String
        Get
            Return Me._OldSpecSourcePath
        End Get
        Set(ByVal value As String)
            Me._OldSpecSourcePath = value
        End Set
    End Property
    Public Property FormPath() As String
        Get
            Return Me._FormPath
        End Get
        Set(ByVal value As String)
            Me._FormPath = value
        End Set
    End Property
    'Public Property TemplatePath() As String
    '    Get
    '        Return Me._TemplatePath
    '    End Get
    '    Set(ByVal value As String)
    '        Me._TemplatePath = value
    '    End Set
    'End Property
    Public Property ProprietaryNetworkLocationAPath() As String
        Get
            Return Me._ProprietaryNetworkLocationAPath
        End Get
        Set(ByVal value As String)
            Me._ProprietaryNetworkLocationAPath = value
        End Set
    End Property
    Public Property SpecNetworkLocationAPath() As String
        Get
            Return Me._SpecNetworkLocationAPath
        End Get
        Set(ByVal value As String)
            Me._SpecNetworkLocationAPath = value
        End Set
    End Property
    Public Property ProprietaryNetworkLocationBPath() As String
        Get
            Return Me._ProprietaryNetworkLocationBPath
        End Get
        Set(ByVal value As String)
            Me._ProprietaryNetworkLocationBPath = value
        End Set
    End Property
    Public Property SpecNetworkLocationBPath() As String
        Get
            Return Me._SpecNetworkLocationBPath
        End Get
        Set(ByVal value As String)
            Me._SpecNetworkLocationBPath = value
        End Set
    End Property
End Class

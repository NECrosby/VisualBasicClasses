Public Class FormNext
    Dim WithEvents _Xbox As Idc.Xbox

    Dim _myCompletedDocument As DocumentInformation

    Dim _Paths As DocconDirectory
    Dim _AllFilesHaveMoved As Boolean

    Dim _CompletedPath As String
    Dim _SourcePath As String
    Dim _NetworkAPath As String
    Dim _NetworkBPath As String
    Dim _FormsPath As String

    '-------------------------------------------------------------------------
    '  NEW 
    '-------------------------------------------------------------------------
    Public Sub New(ByVal completedDocument As DocumentInformation, ByVal paths As DocconDirectory, ByVal haveMoved As Boolean)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim Caption As New System.Text.StringBuilder
        Caption.Append(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                     "{0}   {1}     PC# {2}", _
                                     My.Application.Info.Title, My.Application.Info.Version.ToString, System.Environment.MachineName))
        Caption.Append(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                     "  Start Time: {0}     Logged User: {1}", _
                                     System.DateTime.Now, System.Security.Principal.WindowsIdentity.GetCurrent.Name))
        Me.Text = Caption.ToString

        Me._Paths = paths
        Me._AllFilesHaveMoved = haveMoved

        Me._myCompletedDocument = completedDocument
        Me.lblDocumentNumber.Text = Me._myCompletedDocument.DocumentNumber
        Me.lblDocumentGroup.Text = Me._myCompletedDocument.DocumentGroupToString
        Me.lblOldRevision.Text = Me._myCompletedDocument.OldRevision
        Me.lblNewRevision.Text = Me._myCompletedDocument.NewRevision
        Me.lblDocumentType.Text = Me._myCompletedDocument.DocumentTypeToString

        LoadListBoxes()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'ClearForm()
        Me.Close()
    End Sub
    '-------------------------------------------------------------------------
    '  Clear Form 
    '-------------------------------------------------------------------------
    Private Shared Sub ClearForm()
        FormMain.txtDocumentNumber.Clear()
        FormMain.cboDocumentGroup.SelectedItem = Nothing
        FormMain.txtOldRevision.Clear()
        FormMain.txtNewRevision.Clear()
        FormMain.txtDocumentNumber.Focus()
    End Sub
    '-------------------------------------------------------------------------
    '  LoadListBoxes
    '-------------------------------------------------------------------------
    Public Sub LoadListBoxes()
        '-----------------------------------------------------------------------
        '         ***  Loading List Boxes in Visual Studio 2008  ***              
        ' 1) DataSource is not suppose to be accessible.
        ' 2) Need to loop through the collection to add objects to the 
        '    CheckedListBox.
        ' 3) DisplayMember should be accessible and can be used. 
        '    Intellisense is wrong for CheckedListBox Visual Studio 2008.
        '    .NET Framework 3.5
        '-----------------------------------------------------------------------

        Me.lstFormDocuments.Enabled = False
        Me.lblFormFiles.Enabled = False

        If Me._myCompletedDocument.CompletedDocumentType = CompletedDocumentType.Document Then
            If Me._myCompletedDocument.DocumentGroup = DocumentGroupType.Spec Then
                '-----------------------------------------------------------------------
                '                 ***  Setting Path for Source & PDFs Path  ***              
                ' 1) Determine Completed Doc Type.
                ' 2) Determine which GROUP the Document Number belongs.  
                ' 3) Can only be Spec or a Proprietary Group 
                ' 4) Set the paths
                '-----------------------------------------------------------------------
                Me._CompletedPath = Me._Paths.CompletedDocumentsPath
                Me._SourcePath = Me._Paths.SpecSourcePath
                Me._NetworkAPath = Me._Paths.SpecNetworkLocationAPath
                Me._NetworkBPath = Me._Paths.SpecNetworkLocationBPath
            Else
                Me._CompletedPath = Me._Paths.CompletedDocumentsPath
                Me._SourcePath = Me._Paths.ProprietarySourcePath
                Me._NetworkAPath = String.Concat(Me._Paths.ProprietaryNetworkLocationAPath & _myCompletedDocument.DocumentGroupToString & "\")
                Me._NetworkBPath = String.Concat(Me._Paths.ProprietaryNetworkLocationBPath & _myCompletedDocument.DocumentGroupToString & "\")
            End If
        Else
            If Me._myCompletedDocument.DocumentGroup = DocumentGroupType.Spec Then
                '-----------------------------------------------------------------------
                '      ***  Setting Path for Source & PDFs & Form\Templates  ***              
                ' 1) Determine which Completed Doc Type
                ' 2) Determine which GROUP the Document Number belongs.  
                ' 3) Can only be Spec or a Proprietary Group 
                ' 4) Forms List box will be enabled.
                ' 5) Set the paths
                '-----------------------------------------------------------------------
                Me.lstFormDocuments.Enabled = True
                Me.lblFormFiles.Enabled = True
                Me._CompletedPath = Me._Paths.CompletedDocumentsPath
                Me._SourcePath = Me._Paths.SpecSourcePath
                Me._NetworkAPath = Me._Paths.SpecNetworkLocationAPath
                Me._NetworkBPath = Me._Paths.SpecNetworkLocationBPath
                Me._FormsPath = Me._Paths.FormPath
            Else
                Me.lstFormDocuments.Enabled = True
                Me.lblFormFiles.Enabled = True
                Me._CompletedPath = Me._Paths.CompletedDocumentsPath
                Me._SourcePath = Me._Paths.ProprietarySourcePath
                Me._NetworkAPath = String.Concat(Me._Paths.ProprietaryNetworkLocationAPath & _myCompletedDocument.DocumentGroupToString & "\")
                Me._NetworkBPath = String.Concat(Me._Paths.ProprietaryNetworkLocationBPath & _myCompletedDocument.DocumentGroupToString & "\")
                Me._FormsPath = Me._Paths.FormPath
            End If
        End If

        '-----------------------------------------------------------------------
        '                 ***  Loading COMPLETED List Box   *** 
        '-----------------------------------------------------------------------
        Dim completedDocuments As DocumentCollection = DocconFileMover.DocumentCollection.GetFilesForDocumentNumber(Me._myCompletedDocument, Me._CompletedPath)
        Me.lstCompletedDocuments.DisplayMember = "FileName"
        For Each tempDocument As DocumentInformation In completedDocuments
            Me.lstCompletedDocuments.Items.Add(tempDocument, True)
        Next

        '-----------------------------------------------------------------------
        '                 ***  Loading SOURCE List Box   *** 
        '-----------------------------------------------------------------------
        Dim sourceDocsToReplace As DocumentCollection = DocconFileMover.DocumentCollection.GetFilesForDocumentNumber(Me._myCompletedDocument, Me._SourcePath)
        Try
            Me.lstSourceDocuments.DisplayMember = "FileName"
            For Each tempDocument As DocumentInformation In sourceDocsToReplace
                Me.lstSourceDocuments.Items.Add(tempDocument, True)
            Next
        Catch nullX As Idc.Common.Exception
            _Xbox.Show("Null exception")
        End Try

        '-----------------------------------------------------------------------
        '                 ***  Loading PDF List Box   *** 
        ' 1) The PDF listbox contains collections from two Network Locations.
        ' 2) The collections are both added to one collection that is then  
        '    assigned to the listbox datasource.
        '-----------------------------------------------------------------------
        Dim PDFsToReplace As New DocumentCollection()
        Dim PDFsToReplaceA As DocumentCollection = DocconFileMover.DocumentCollection.GetFilesForDocumentNumber(Me._myCompletedDocument, Me._NetworkAPath)
        Dim PDFsToReplaceB As DocumentCollection = DocconFileMover.DocumentCollection.GetFilesForDocumentNumber(Me._myCompletedDocument, Me._NetworkBPath)
        PDFsToReplace.AddDocuments(PDFsToReplaceA)
        PDFsToReplace.AddDocuments(PDFsToReplaceB)

        Me.lstPDFDocuments.DisplayMember = "FileName"
        For Each tempDocument As DocumentInformation In PDFsToReplace
            Me.lstPDFDocuments.Items.Add(tempDocument, True)
        Next

        '-----------------------------------------------------------------------
        '                 ***  Loading Forms List Box   *** 
        ' 1) If the Document Type is a Form
        ' 2) Form list box is only Enabled if the Doc type is a Form\Template
        '-----------------------------------------------------------------------
        Dim formsToReplace As DocumentCollection = DocconFileMover.DocumentCollection.GetFilesForDocumentNumber(Me._myCompletedDocument, Me._FormsPath)
        If Me._myCompletedDocument.CompletedDocumentType = CompletedDocumentType.FormTemplate Then
            Me.lstFormDocuments.DisplayMember = "FileName"
            For Each tempDocument As DocumentInformation In formsToReplace
                Me.lstFormDocuments.Items.Add(tempDocument, True)
            Next
        End If
    End Sub
    Private Sub btnCheckAllSourcePDFs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAllSourcePDFs.Click
        Dim iStep As Integer

        'Check All Complete Documents
        'For iStep = 0 To lstCompletedDocuments.Items.Count - 1
        '    lstCompletedDocuments.SetItemChecked(iStep, True)
        'Next
        'Check All Source Documents 
        For iStep = 0 To lstSourceDocuments.Items.Count - 1
            lstSourceDocuments.SetItemChecked(iStep, True)
        Next
        'Check All PDFs
        For iStep = 0 To lstPDFDocuments.Items.Count - 1
            lstPDFDocuments.SetItemChecked(iStep, True)
        Next
        'Check All Forms
        For iStep = 0 To lstFormDocuments.Items.Count - 1
            lstFormDocuments.SetItemChecked(iStep, True)
        Next
    End Sub
    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        Dim iStep As Integer

        'Uncheck All Completed Documents 
        'For iStep = 0 To lstCompletedDocuments.Items.Count - 1
        '    lstCompletedDocuments.SetItemChecked(iStep, False)
        'Next
        'UNcheck All Source Documents
        For iStep = 0 To lstSourceDocuments.Items.Count - 1
            lstSourceDocuments.SetItemChecked(iStep, False)
        Next
        'UNcheck All PDFs
        For iStep = 0 To lstPDFDocuments.Items.Count - 1
            lstPDFDocuments.SetItemChecked(iStep, False)
        Next
        'UNcheck All Forms
        For iStep = 0 To lstFormDocuments.Items.Count - 1
            lstFormDocuments.SetItemChecked(iStep, False)
        Next
    End Sub
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'Dim allFilesHaveMoved As Boolean = Me._AllFilesHaveMoved

        ' The completed documents must have at least two files in order to continue.
        If lstCompletedDocuments.Items.Count < 2 Then
            _Xbox.Show("There are less than 2 files in the 'Completed_Documents' folder!")
            Me.Close()
        End If

        For iStep = 1 To lstCompletedDocuments.Items.Count
            If lstSourceDocuments.GetItemCheckState(iStep) = CheckState.Checked Then
                'DeployMoves(Me._myCompletedDocument)
            End If
        Next

        ' Test to see if the Completed Documents have all been moved 
        ' and the list box is now empty. 
        If lstCompletedDocuments.Items.Count = 0 Then
            Me._AllFilesHaveMoved = True
        Else
            Me._AllFilesHaveMoved = False
        End If
    End Sub
End Class
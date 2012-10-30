Imports System.Globalization

'****************************************************************************************************************************************
'                                           Application Notes
'----------------------------------------------------------------------------------------------------------------------------------------
' DocConFileMover 
'       This program is to be used only by DocCon.  
'       It's purpose is to move completed documents to their respective directories once they have been approved by DocCon.
'       DocConFileMover will move all parts of a document to it's source folder and move the PDF file to the Network Location
'       so that it can be viewed on the intranet.  
'       If the document is a form or template, DocConFileMover will also move the form/template to a read only folder on the 
'       Network so that it can be viewed on the intranet.
'
' Written by Naomi Crosby July-August 2011
'            Assisted By Chet Borg
' Last Modified by 
'
' Revision 1.0.0 -
'
' Glossary: 
'   Prop = Proprietary
'   Spec = Specification
'   OldSourceFiles = OldRevisionFiles
'
' Rules:
'   1) A document can never be both a Spec and Proprietary, it can only be one or the other.
'   2) A Form will always have an "F" as the last character in the filename preceding the file extension.
'   3) The Completed Documents list box must always at least have 2 files: one of which has to be a PDF.
'   4) There is one and only one version of a Form document, there is a separate file that DocCon uses to
'      track changes of a Form as a written summary of what changes were made.
'   5) Templates are treated the same as Forms concerning MOVING with two exceptions: 
'   6) Revisions will contain a "#" character in the file name.
'   7) The only files that are ever Renamed are the Source files that are moved into the Old Source Folder.
'   8) Old Source Files are also known as OldRevisionFiles.
'
'****************************************************************************************************************************************

Public Class FormMain
    '-------------------------------------------------------------------------
    '  Class Variables
    '-------------------------------------------------------------------------
    Dim WithEvents _Xbox As Idc.Xbox
    Dim _AuthDa As Idc.Common.Interfaces.IDataAccess
    Dim _UpdaterPath As String = "\\dom1\funnel\isapps\Downloadable Components\Common Tools\AppUpdateXP.exe"
    Dim _UpdateSource As String = "\\dom1\funnel\isapps\Downloadable Components\DocconFileMover"
    Dim _AppLocation As String = My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe"
    Dim _AppConfig As Idc.Configuration.AppConfig
    Dim _AllFilesHaveMoved As Boolean
    Dim _tempDocument As DocumentInformation

    '--------------------------------------------------------
    ' DocconDirectory Object - Paths for Files -- Stored in Config Manager
    '-------------------------------------------------------- 
    Dim _Paths As DocconDirectory
    '--------------------------------------------------------

    '-------------------------------------------------------------------------
    '  New
    '-------------------------------------------------------------------------
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Make sure the network is up and running
        If My.Computer.Network.IsAvailable Then
            'MessageBox.Show("Getting Data Access stuff")
            Try
                ' - Instaniate an instance to the IDC.Configuration (Encrypted Username, Encrypted Password)
                _AppConfig = New Idc.Configuration.AppConfig("TYhMfNH1o31wqmm/XpqM0Q==", "0PAOcvFPjzYDyieG8VHy0g==")

                ' - Check if there are more than one runmode, if so select one
                If Me._AppConfig.NeedToSetRunmode Then
                    Me._AppConfig.SetApplicationRunmode _
                    (Idc.Configuration.AppConfig.GetSelectedApplicationRunmode(Me._AppConfig.RunmodesAvailable))
                End If
                Me._Paths = New DocconDirectory
                LoadConfig()
                _Xbox = New Idc.Xbox(Idc.XboxType.Standard, True)
                Me._Xbox.DataAccess = Me._AppConfig.AuthorizationDataAccess

            Catch ConfigX As Idc.Configuration.ConfigurationException
                _Xbox.Show("Unable to retreiveconfiguration information", ConfigX)
            Catch DaX As Idc.Common.DataAccess.DataAccessException
                If Not _AuthDa Is Nothing Then Me._Xbox.DataAccess = _AuthDa
                _Xbox.Show("Xbox is unable to connect to Authorization Database", DaX)
                'Catch x As Exception
                'MessageBox.Show(String.Format("System X {0}", x.ToString))
            End Try

            If Not _Xbox.Application Is Nothing Then
                'cXbox.show(String.Format("Application is {0} FileName is {1}", cXbox.Application.Name, cXbox.Application.FileName))
            End If
            _Xbox.RemoteUpdatePath = Me._UpdateSource
            Me._Xbox.DisplayInternalXboxErrors = False
        Else
            _Xbox.Show("Unable to connect to the Network!")
        End If

        Me._tempDocument = New DocumentInformation
        CheckForUpdates()
        LoadFilters()

        lblVersion.Text = String.Format(Globalization.CultureInfo.InvariantCulture, "Version: " & My.Application.Info.Version.ToString)
    End Sub
    '-------------------------------------------------------------------------
    '  Load Config
    '-------------------------------------------------------------------------
    Private Sub LoadConfig()
        Dim configKey As String = String.Empty

        configKey = "UpdaterPath"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._UpdaterPath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "UpdateSource"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._UpdateSource = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "OldProprietarySource"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.OldProprietarySourcePath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "ProprietarySource"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.ProprietarySourcePath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "OldSpecSource"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.OldSpecSourcePath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "SpecSource"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.SpecSourcePath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "CompletedDocuments"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.CompletedDocumentsPath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "Forms"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.FormPath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        'configKey = "Templates"
        'If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        'Me._Paths.TemplatePath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "DocSpecNetworkLocationA"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.SpecNetworkLocationAPath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "DocProprietaryNetworkLocationA"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.ProprietaryNetworkLocationAPath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "DocSpecNetworkLocationB"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.SpecNetworkLocationBPath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue

        configKey = "DocProprietaryNetworkLocationB"
        If Not Me._AppConfig.RetrieveKeyValue(configKey) Is Nothing Then _
        Me._Paths.ProprietaryNetworkLocationBPath = Me._AppConfig.RetrieveKeyValue(configKey).ItemValue
    End Sub
    '-------------------------------------------------------------------------
    '  CheckForUpdates
    '-------------------------------------------------------------------------
    ' Want to make sure that able to start application no matter what exception is thrown.
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")> _
    Private Sub CheckForUpdates()
        'MessageBox.Show("Checking remote and local filepaths")
        ' Check if application should start or exit for update
        Dim AppStart As New Idc.ApplicationStartup
        Dim NoUpdateAvailable As Boolean
        ' - Get Source and Local DirectoryINfo objects for xbox.AreThereUpdatesAvailable
        Try
            Dim SourceDirInfo As New System.IO.DirectoryInfo(Me._UpdateSource)
            Dim sc As StringComparison
            Dim LocalDirInfo As New System.IO.DirectoryInfo(Me._AppLocation.Substring(0, Me._AppLocation.LastIndexOf("\", sc)))

            If LocalDirInfo.Exists And SourceDirInfo.Exists Then
                'Messagebox.Show("IDC xbox is checking for updates - bet this is where we fail...")
                Dim updatesAvailable As Boolean = Idc.Xbox.AreThereUpdatesAvailable(SourceDirInfo, LocalDirInfo)
                ' - get the inverse, just to make code more readable
                NoUpdateAvailable = Not updatesAvailable
            End If
        Catch Iox As System.IO.IOException
            'MessageBox.Show(String.Format("Exception getting Directory Info.", Iox.ToString)
            NoUpdateAvailable = False
        Catch x As SystemException
            'MessageBox.Show(String.format("Xbox Error - Checking for updates. {0}", x.ToString)
            NoUpdateAvailable = False
        End Try

        Dim UpdaterXpFileInfo As New IO.FileInfo(Me._UpdaterPath)
        'MessageBox.Show("Checking if AppUpdater exists.")
        If Not UpdaterXpFileInfo Is Nothing Then
            If Not UpdaterXpFileInfo.Exists Then
                NoUpdateAvailable = True
                _Xbox.Show(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                              "Unable to locate Application Updater ({0}) to update this application. " & _
                                              "Application will run with current version.", UpdaterXpFileInfo.FullName))
            End If
        Else
            NoUpdateAvailable = True
            _Xbox.Show(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                     "Unable to locate Application Updater ({0}) to update this application." & _
                                     "Application will run with current version.", UpdaterXpFileInfo.FullName))
        End If

        Try
            If AppStart.SkipUpdate Or NoUpdateAvailable Then
                Dim Caption As New System.Text.StringBuilder
                Caption.Append(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                             "{0}   {1}     PC# {2}", _
                                             My.Application.Info.Title, My.Application.Info.Version.ToString, System.Environment.MachineName))
                Caption.Append(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                             "  Start Time: {0}     Logged User: {1}", _
                                             System.DateTime.Now, System.Security.Principal.WindowsIdentity.GetCurrent.Name))
                Me.Text = Caption.ToString
            Else
                If Not UpdaterXpFileInfo Is Nothing Then
                    If UpdaterXpFileInfo.Exists Then
                        Dim args As New System.Text.StringBuilder
                        args.Append(String.Format(System.Globalization.CultureInfo.InvariantCulture, """{0}"" ", Me._UpdateSource))
                        args.Append(String.Format(System.Globalization.CultureInfo.InvariantCulture, """{0}"" ", Me._AppLocation))
                        args.Append(String.Format(System.Globalization.CultureInfo.InvariantCulture, " /SkipUpdate=TRUE "))
                        args.Append(String.Format(System.Globalization.CultureInfo.InvariantCulture, """{0}"" ", AppStart.Arguments.ToString))
                        'DeBug.WriteLine(Me.cUpdatePath)
                        Dim sOut As String = args.ToString
                        Me._Xbox.DisplayInternalXboxErrors = False
                        Try
                            ' System.Diagnostics.Process.Start(Me.cUpdaterPath, sOut)
                            Dim startInfo As New System.Diagnostics.ProcessStartInfo()

                            startInfo.Arguments = args.ToString
                            startInfo.FileName = Me._UpdaterPath
                            If Not Me._Xbox Is Nothing Then Me._Xbox.Dispose()
                            System.Diagnostics.Process.Start(startInfo)
                            System.Windows.Forms.Application.Exit()
                            Me.Close()

                        Catch Win32X As System.ComponentModel.Win32Exception
                            _Xbox.Show(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                                     "Unable to start application ({0}) to update this application with parameters({1}). ", _
                                                     UpdaterXpFileInfo.FullName, sOut), Win32X)

                        End Try
                    Else
                        _Xbox.Show(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                                 "Unable to locate application ({0}) to update this application. ", _
                                                 UpdaterXpFileInfo.FullName))
                    End If
                End If

            End If
        Catch AppX As Idc.IdcException
            _Xbox.Show(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                          "There was an IdcException - {0}", AppX))
        Catch x As System.SystemException
            _Xbox.Show(String.Format(System.Globalization.CultureInfo.InvariantCulture, _
                                          "There was an IdcException - {0}", x))
        End Try
    End Sub
    '-------------------------------------------------------------------------
    '  Load Filters
    '-------------------------------------------------------------------------
    Public Function LoadFilters() As Boolean
        Dim result As Boolean
        ' Below is referencing the IDC.COMMON library to convert an enum to fill the ComboBox list
        Dim documentGroupTypes As New Idc.Common.EnumPairCollection(Of DocumentGroupType)
        Me.cboDocumentGroup.DataSource = documentGroupTypes

        result = True
        Return result

    End Function
    '-------------------------------------------------------------------------
    '  Next Button -- moving to Next Form
    '-------------------------------------------------------------------------
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me._tempDocument.DocumentNumber = txtDocumentNumber.Text.ToUpperInvariant
        Me._tempDocument.DocumentGroup = CType(Me.cboDocumentGroup.SelectedIndex, DocumentGroupType)
        Me._tempDocument.OldRevision = txtOldRevision.Text.ToUpperInvariant '(New CultureInfo("en-US", False))
        Me._tempDocument.NewRevision = txtNewRevision.Text.ToUpperInvariant
        Me._tempDocument.FileInfo = New IO.FileInfo(Me._Paths.CompletedDocumentsPath)

        If rbDocument.Checked = True Then
            Me._tempDocument.CompletedDocumentType = DocconFileMover.CompletedDocumentType.Document   'Enum type Document
        Else
            Me._tempDocument.CompletedDocumentType = DocconFileMover.CompletedDocumentType.FormTemplate   'Enum type FormTemplate
        End If

        ' This is used to instaniate a new 'Next Form' with a parameter list
        Dim frmNext As New FormNext(Me._tempDocument, Me._Paths, Me._AllFilesHaveMoved)
        frmNext.ShowDialog()
    End Sub
    '-------------------------------------------------------------------------
    '  Enable Next Button 
    '-------------------------------------------------------------------------
    Public Sub EnableNextButton()
        If txtNewRevision.Text <> String.Empty And txtDocumentNumber.Text <> String.Empty And cboDocumentGroup.SelectedItem IsNot Nothing Then
            btnNext.Enabled = True
        Else
            btnNext.Enabled = False
        End If
    End Sub
    '-------------------------------------------------------------------------
    '  Validate Text Box Entry: Document Number
    '-------------------------------------------------------------------------
    Private Sub txtDocumentNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocumentNumber.KeyPress
        ' Allows alphanumeric, spaces, _, and Backspace to be used in textbox control
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = " " Or e.KeyChar = "_" Or System.Convert.ToInt32(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtDocumentNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDocumentNumber.TextChanged
        EnableNextButton()
    End Sub
    '-------------------------------------------------------------------------
    '  Validate Text Box Entry: old revision number
    '-------------------------------------------------------------------------
    Private Sub txtOldRevision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocumentNumber.KeyPress
        ' Allows alphanumeric, spaces, _, and Backspace to be used in textbox control
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = " " Or e.KeyChar = "_" Or System.Convert.ToInt32(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtOldRevision_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewRevision.TextChanged
        EnableNextButton()
    End Sub
    '-------------------------------------------------------------------------
    '  Validate Text Box Entry: new revision number
    '-------------------------------------------------------------------------
    Private Sub txtNewRevision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDocumentNumber.KeyPress
        ' Allows alphanumeric, spaces, _, and Backspace to be used in textbox control
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = " " Or e.KeyChar = "_" Or System.Convert.ToInt32(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNewRevision_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewRevision.TextChanged
        EnableNextButton()
    End Sub
    Private Sub cboDocumentGroup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocumentGroup.Click
        EnableNextButton()
    End Sub
    '-------------------------------------------------------------------------
    '  End Processes and Close Application
    '-------------------------------------------------------------------------
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' All threads to be closed and ended in order to close down the application correctly.
        Me._Xbox.Close()
        Me._AppConfig.Close()
    End Sub
    '-------------------------------------------------------------------------
    '  Done and Close Application
    '-------------------------------------------------------------------------
    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        Dim response As DialogResult = _Xbox.Show("File has not been moved! Do you still wish to Exit?", "Please Confirm", MessageBoxButtons.YesNo)
        If Not Me._AllFilesHaveMoved And Me.btnNext.Enabled = True Then
            If response = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    '-------------------------------------------------------------------------
    '  Show the About Form
    '-------------------------------------------------------------------------
    Private Sub FormMain_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        Dim frmAbout As New FormAbout
        frmAbout.ShowDialog()
    End Sub
End Class

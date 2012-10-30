Imports System.Globalization

Public Enum CompletedDocumentType
    Document
    FormTemplate
End Enum

Public Enum DocumentGroupType
    Spec
    CharProprietary
    DesignProprietary
    DeviceProprietary
    EtsProprietary
    ParamProprietary
    ProcessProprietary
    WrdProprietary
    ISProprietary
End Enum

Public Enum DocconFileType
    Source
    Pdf
    Form
End Enum

'=========================================================
'  *****  DOCUMENT INFORMATION CLASS   *****  
'=========================================================
Public Class DocumentInformation
    Dim WithEvents _Xbox As Idc.Xbox
    '---------------------------------------------------------
    '  Class Variables
    '---------------------------------------------------------
    Private _FileInfo As IO.FileInfo
    Private _DocumentNumber As String = String.Empty
    Private _DocumentGroup As DocumentGroupType
    Private _CompletedDocumentType As CompletedDocumentType
    Private _OldRevision As String = String.Empty
    Private _NewRevision As String = String.Empty
    Private _DocconFileType As DocconFileType    ' This is the DocCon File type - Source, PDF, FormTemplate
    Private _Directory As DocconDirectory
    'Private _FilePath As String

    '---------------------------------------------------------
    '  Constructors
    '---------------------------------------------------------
    Public Sub New()

    End Sub
    Public Sub New(ByVal fileInfo As IO.FileInfo, ByVal documentNumber As String, ByVal documentGroup As DocumentGroupType, _
                   ByVal documentType As CompletedDocumentType, ByVal oldRevision As String, ByVal newRevision As String, _
                   ByVal directory As DocconDirectory)
        Me._FileInfo = fileInfo
        Me._DocumentNumber = documentNumber
        Me._DocumentGroup = documentGroup
        Me._CompletedDocumentType = documentType
        Me._OldRevision = oldRevision
        Me._NewRevision = newRevision
        Me._Directory = directory
        'Me._FilePath = filePath
        Me._DocconFileType = SetDocconFileType(fileInfo)
    End Sub
    '---------------------------------------------------------
    '  Properties
    '---------------------------------------------------------
    Public Property FileInfo() As IO.FileInfo
        Get
            Return Me._FileInfo
        End Get
        Set(ByVal value As IO.FileInfo)
            Me._FileInfo = value
        End Set
    End Property
    Public Property DocumentNumber() As String
        Get
            Return Me._DocumentNumber
        End Get
        Set(ByVal value As String)
            Me._DocumentNumber = value
        End Set
    End Property
    Public Property DocumentGroup() As DocumentGroupType
        Get
            Return Me._DocumentGroup
        End Get
        Set(ByVal value As DocumentGroupType)
            Me._DocumentGroup = value
        End Set
    End Property
    Public Property CompletedDocumentType() As CompletedDocumentType
        Get
            Return Me._CompletedDocumentType
        End Get
        Set(ByVal value As CompletedDocumentType)
            Me._CompletedDocumentType = value
        End Set
    End Property
    Public Property OldRevision() As String
        Get
            Return Me._OldRevision
        End Get
        Set(ByVal value As String)
            Me._OldRevision = value
        End Set
    End Property
    Public Property NewRevision() As String
        Get
            Return Me._NewRevision
        End Get
        Set(ByVal value As String)
            Me._NewRevision = value
        End Set
    End Property
    Public Property DocconFileType() As DocconFileType
        Get
            Return Me._DocconFileType
        End Get
        Set(ByVal value As DocconFileType)
            Me._DocconFileType = value
        End Set
    End Property
    Public Property DocconDirectory() As DocconDirectory
        Get
            Return Me._Directory
        End Get
        Set(ByVal value As DocconDirectory)
            Me._Directory = value
        End Set
    End Property
    Public ReadOnly Property FileName() As String
        Get
            Return Me.GetFileName
        End Get
    End Property
    '---------------------------------------------------------
    '  Functions & SubRoutines 
    '---------------------------------------------------------
    Public Overrides Function ToString() As String
        Dim returnString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0}", Me._DocumentNumber)
        'Dim returnString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0}", Me.GetFileName)
        Return returnString
    End Function
    Public Function DocumentGroupToString() As String
        Dim returnValue As String = String.Empty

        If Me._DocumentGroup = DocumentGroupType.Spec Or _
        Me._DocumentGroup = DocumentGroupType.CharProprietary Or _
        Me._DocumentGroup = DocumentGroupType.DesignProprietary Or _
        Me._DocumentGroup = DocumentGroupType.DeviceProprietary Or _
        Me._DocumentGroup = DocumentGroupType.EtsProprietary Or _
        Me._DocumentGroup = DocumentGroupType.ISProprietary Or _
        Me._DocumentGroup = DocumentGroupType.ParamProprietary Or _
        Me._DocumentGroup = DocumentGroupType.ProcessProprietary Or _
        Me._DocumentGroup = DocumentGroupType.WrdProprietary Then
            If Me._DocumentGroup = DocumentGroupType.Spec Then
                returnValue = "Spec"
            ElseIf Me._DocumentGroup = DocumentGroupType.CharProprietary Then
                returnValue = "CHAR_PROP"
            ElseIf Me._DocumentGroup = DocumentGroupType.DesignProprietary Then
                returnValue = "DESIGN_PROP"
            ElseIf Me._DocumentGroup = DocumentGroupType.DeviceProprietary Then
                returnValue = "DEVICE_PROP"
            ElseIf Me._DocumentGroup = DocumentGroupType.EtsProprietary Then
                returnValue = "ETS_PROP"
            ElseIf Me._DocumentGroup = DocumentGroupType.ISProprietary Then
                returnValue = "IS_PROP"
            ElseIf Me._DocumentGroup = DocumentGroupType.ParamProprietary Then
                returnValue = "PARAM_PROP"
            ElseIf Me._DocumentGroup = DocumentGroupType.ProcessProprietary Then
                returnValue = "PROCESS_PROP"
            ElseIf Me._DocumentGroup = DocumentGroupType.WrdProprietary Then
                returnValue = "WRD_PROP"
            End If
        End If
        Return returnValue
    End Function
    Public Function DocumentTypeToString() As String
        Dim returnValue As String = String.Empty

        If Me._CompletedDocumentType = DocconFileMover.CompletedDocumentType.Document Or Me._CompletedDocumentType = DocconFileMover.CompletedDocumentType.FormTemplate Then
            If Me._CompletedDocumentType = DocconFileMover.CompletedDocumentType.Document Then
                returnValue = "Document"
            ElseIf Me._CompletedDocumentType = DocconFileMover.CompletedDocumentType.FormTemplate Then
                returnValue = "Form/Template"
            End If
        End If

        Return returnValue
    End Function
    Private Function GetFileName() As String
        Dim returnFileName As String = String.Empty

        If Not FileInfo Is Nothing Then
            If FileInfo.Exists Then
                returnFileName = FileInfo.Name.ToUpperInvariant
            Else
                returnFileName = String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0} - No file", Me._DocumentNumber)
            End If
        Else
            returnFileName = String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0} - No file", Me._DocumentNumber)
        End If

        Return returnFileName
    End Function
    Public Function DocconRenameFiles(ByVal documentName As IO.FileInfo) As String
        '======================================================================
        ' Renames the file with Filename + Old Revision "ID" 
        ' 1) Only Source files are Renamed when moving to the Old Source File Folder
        '======================================================================
        Dim returnNewFileName As String = String.Empty
        Dim iStep As Integer
        Dim fileNameLength As Integer = documentName.Name.Length
        Dim fileName As String = documentName.Name
        Dim character As String
        Dim charToTrim() As Char = {System.Convert.ToChar(Me.OldRevision, CultureInfo.InvariantCulture)}

        For iStep = fileNameLength To 1 Step -1
            character = fileName.Substring(0, 1)
            If character = "." Then Exit For
        Next

        If iStep = 0 Then
            returnNewFileName = String.Concat(fileName & "#" & Me.NewRevision)
        Else
            returnNewFileName = String.Concat(fileName.TrimEnd(charToTrim) & "#" & Me.NewRevision)
        End If

        Return returnNewFileName
    End Function
    Public Function SetDocconFileType(ByVal fileInfo As IO.FileInfo) As DocconFileType
        '--------------------------------------------------------------------------
        '                 ***  Set the DOCCON FILE TYPE  *** 
        ' 1) Determines which of the saved file types the completed doc
        '    will be saved as.
        '--------------------------------------------------------------------------
        Dim returnFileType As DocconFileType

        'If the CompletedDocumentType is a Form/template
        If Me._CompletedDocumentType = DocconFileMover.CompletedDocumentType.FormTemplate Then
            If IsAForm(fileInfo) Then
                'use the 'IsAForm' function to determine which DocCon file type to be saved.
                'This is a Form
                returnFileType = DocconFileMover.DocconFileType.Form
                'ElseIf Not IsAForm(fileInfo) Then
                '    'This is a Template - paths are different for Forms and Templates
                '    returnFileType = DocconFileMover.DocconFileType.Template
            End If
        Else
            'If the CompletedDocumentType is a Document  
            'will be a non PDF file
            If fileInfo.Extension.ToUpperInvariant = ".PDF" Then
                'If file extension is a PDF then DocCon File Type will be a PDF
                returnFileType = DocconFileMover.DocconFileType.Pdf
            Else
                returnFileType = DocconFileMover.DocconFileType.Source
            End If
        End If

        Return returnFileType
    End Function
    Public Shared Function IsAForm(ByVal fileInfo As IO.FileInfo) As Boolean
        '--------------------------------------------------------------------------
        '                 ***  Determing if Form or Template  *** 
        ' 1) The Completed Document Type MUST BE a FORM/TEMPLATE!!!
        ' 2) If the Filename has an "F" at the end of the prefix 
        '    (last character prior to the extension) this Function will return 
        '    TRUE this is a form. 
        '--------------------------------------------------------------------------
        Dim fileName As String = fileInfo.Name
        Dim result As Boolean
        Dim separator() As String = {fileInfo.Extension}
        Dim fileNameNoExtension() As String
        Dim sc As System.StringComparison

        fileNameNoExtension = fileName.Split(separator, StringSplitOptions.RemoveEmptyEntries)

        result = fileNameNoExtension(0).EndsWith("F", sc)
        Return result
    End Function
    '-------------------------------------------------------------------------
    '  MovedSourceFileToOld 
    '-------------------------------------------------------------------------
    Public Function MovedSourceFileToOldRevisionFiles(ByVal document As DocumentInformation) As Boolean
        '======================================================================
        ' Moves file from source folder to 'Old_Documents_Revision' folder
        '   1) Do not copy over previous Revised Versions.
        '======================================================================

        '*****************************************************************************************************
        ' Need to figure out how to choose the correct file from the completed docs folder to move to the
        ' correct location. 
        ' Right now it is setup as there is only one file in the completed documents but there are 2 or more.
        ' USE THE DOCCONFILETYPE to determine what the file is ....
        ' Use For each DocconFileType loop to move the correct files
        '*****************************************************************************************************

        Dim result As Boolean
        Dim sourcePath As String        ' This is the path for the file to be moved from
        Dim oldSourcePath As String     ' This is the path for the file to be moved to
        Dim fileNameToBeRenamed As String = document.FileName
        Dim newFileName As String = DocconRenameFiles(document.FileInfo)

        'Dim movedFile As IO.FileInfo
        Try
            ' Figure out which paths is to be used based on Document Group
            'If document.DocconFileType = DocconFileMover.DocconFileType.Source Then
            If document.DocumentGroup = DocumentGroupType.Spec Then
                sourcePath = Me._Directory.SpecSourcePath
                oldSourcePath = Me._Directory.OldSpecSourcePath
            Else
                sourcePath = Me._Directory.ProprietarySourcePath
                oldSourcePath = Me._Directory.OldProprietarySourcePath
            End If
            'End If

            Dim sourceFile As New IO.FileInfo(sourcePath)

            ' If the source file does not exist then the function will return false
            If Not sourceFile.Exists Then
                _Xbox.Show("The following file does not exist in the 'Completed_Documents' folder: " & sourceFile.Name)
                result = False
                Exit Function
            End If

            ' Copy the Source file to the Old Source file location and then delete then source file from the source folder location 
            My.Computer.FileSystem.RenameFile(fileNameToBeRenamed, newFileName)
            _Xbox.Show("Source file has been Renamed")
            Dim movedFile As New IO.FileInfo(oldSourcePath)
            movedFile = sourceFile.CopyTo(oldSourcePath)
            sourceFile.Delete()

            ' Test to make sure the file was moved and now exists where it should
            ' which is in the OldRevisionFiles folder
            If Not movedFile.Exists Then
                result = False
                _Xbox.Show("Files have NOT been moved correctly.")
            Else
                result = True
                _Xbox.Show("Files have been moved.")
            End If


        Catch ArgNullEx As ArgumentNullException
            Dim DocConEx As New DocconFileMoverException("Please add an Argument to the list.", ArgNullEx)
            Throw DocConEx
        Catch ArgEx As ArgumentException
            Dim DocConEx As New DocconFileMoverException("Please make sure that you have the correct amount of Arguments.", ArgEx)
            Throw DocConEx
        Catch DirNotFoundex As IO.DirectoryNotFoundException
            Dim DocConEx As New DocconFileMoverException("Directory Not Found!", DirNotFoundex)
            Throw DocConEx
        Catch PathEx As IO.PathTooLongException
            Dim DocConEx As New DocconFileMoverException("Path is not valid.", PathEx)
            Throw DocConEx
        Catch IOEx As IO.IOException
            Dim DocConEx As New DocconFileMoverException("An Error has occurred. Please contact IS for assistance.", IOEx)
            Throw DocConEx
        Catch SecEx As Security.SecurityException
            Dim DocConEx As New DocconFileMoverException("You may not have permission for this Directory.", SecEx)
            Throw DocConEx
        Catch UnauthEx As UnauthorizedAccessException
            Dim DocConEx As New DocconFileMoverException("You may not have permission for this Directory.", UnauthEx)
            Throw DocConEx
        Catch NotSupEx As NotSupportedException
            Dim DocConEx As New DocconFileMoverException("This function is not supported. Contact IS for assistance.", NotSupEx)
            Throw DocConEx
        End Try

        Return result
    End Function
    '-------------------------------------------------------------------------
    '  MovedCompletedFileToSource 
    '-------------------------------------------------------------------------
    Public Function MovedCompletedFileToSource(ByVal document As DocumentInformation) As Boolean
        '=================================================================================================
        ' Flag to show whether the Completed File has been moved to the Source
        ' location and replaced the previous source.
        ' 1) Only one version of this document is to be in the Source folder.
        '    The completed document will replace the current source.
        '    This can only be done if the current source has been moved to the old source folder already.
        '=================================================================================================

        '*****************************************************************************************************
        ' Need to figure out how to choose the correct file from the completed docs folder to move to the
        ' correct location. 
        ' Right now it is setup as there is only one file in the completed documents but there are 2 or more.
        ' USE THE DOCCONFILETYPE to determine what the file is ....
        ' Use For each DocconFileType loop to move the correct files
        '*****************************************************************************************************
        Dim result As Boolean
        Dim completedPath As String  ' This is the path for the file to be moved from
        Dim sourcePath As String     ' This is the path for the file to be moved to

        Try
            ' Figure out which paths is to be used based on Document Group
            If document.DocumentGroup = DocumentGroupType.Spec Then
                completedPath = Me._Directory.CompletedDocumentsPath
                sourcePath = Me._Directory.OldSpecSourcePath
            Else
                completedPath = Me._Directory.CompletedDocumentsPath
                sourcePath = Me._Directory.OldProprietarySourcePath
            End If

            Dim completedFile As New IO.FileInfo(completedPath)

            ' If the completed file does not exist then the function will return false
            If Not completedFile.Exists Then
                _Xbox.Show("The following file does not exist in the 'Completed_Documents' folder: " & completedFile.Name)
                result = False
                Exit Function
            End If

            ' at this point the source file should have been deleted.
            ' so if there is still a source file then it needs to be fixed.
            Dim sourceFile As IO.DirectoryInfo = New IO.DirectoryInfo(sourcePath)
            If Not sourceFile.Exists Then
                _Xbox.Show("The Source file has not been moved properly: " & sourceFile.Name)
                result = False
                Exit Function
            End If

            ' Copy the Completed file to the Source file location and then delete the Completed file from the Completed folder location 
            completedFile.CopyTo(sourcePath)
            completedFile.Delete()

            Dim movedFile As New IO.FileInfo(sourcePath)
            ' Test to make sure the file was moved and now exists where it should
            ' which is in the SourceFiles folder
            If Not movedFile.Exists Then
                result = False
                _Xbox.Show("Files have NOT been moved correctly.")
            Else
                result = True
                _Xbox.Show("Files have been moved.")
            End If

        Catch ArgNullEx As ArgumentNullException
            Dim DocConEx As New DocconFileMoverException("Please add an Argument to the list.", ArgNullEx)
            Throw DocConEx
        Catch ArgEx As ArgumentException
            Dim DocConEx As New DocconFileMoverException("Please make sure that you have the correct amount of Arguments.", ArgEx)
            Throw DocConEx
        Catch DirNotFoundex As IO.DirectoryNotFoundException
            Dim DocConEx As New DocconFileMoverException("Directory Not Found!", DirNotFoundex)
            Throw DocConEx
        Catch PathEx As IO.PathTooLongException
            Dim DocConEx As New DocconFileMoverException("Path is not valid.", PathEx)
            Throw DocConEx
        Catch IOEx As IO.IOException
            Dim DocConEx As New DocconFileMoverException("An Error has occurred. Please contact IS for assistance.", IOEx)
            Throw DocConEx
        Catch SecEx As Security.SecurityException
            Dim DocConEx As New DocconFileMoverException("You may not have permission for this Directory.", SecEx)
            Throw DocConEx
        Catch UnauthEx As UnauthorizedAccessException
            Dim DocConEx As New DocconFileMoverException("You may not have permission for this Directory.", UnauthEx)
            Throw DocConEx
        Catch NotSupEx As NotSupportedException
            Dim DocConEx As New DocconFileMoverException("This function is not supported. Contact IS for assistance.", NotSupEx)
            Throw DocConEx
        End Try

        Return result

    End Function
    '-------------------------------------------------------------------------
    '  MovedPdfToNetworkLocation 
    '-------------------------------------------------------------------------
    Public Function MovedPdfToNetworkLocation(ByVal document As DocumentInformation) As Boolean
        '======================================================================
        ' Moves PDF file from 'Completed_Documents' folder to Network locations
        ' 1) Replaces existing with new ones from Completed Documents.
        '======================================================================

        '*****************************************************************************************************
        ' Need to figure out how to choose the correct file from the completed docs folder to move to the
        ' correct location. 
        ' Right now it is setup as there is only one file in the completed documents but there are 2 or more.
        ' USE THE DOCCONFILETYPE to determine what the file is ....
        ' Use For each DocconFileType loop to move the correct files
        '*****************************************************************************************************

        Dim result As Boolean
        Dim completedPath As String  ' This is the path for the file to be moved from
        Dim networkAPath As String   ' This is the path for the file to be moved to "A" locations
        Dim networkBPath As String   ' This is the path for the file to be moved to "B" locations
        'Dim movedFile As IO.FileInfo
        Dim overwrite As Boolean = True

        Try
            ' Figure out which paths is to be used based on Document Group
            If document.DocumentGroup = DocumentGroupType.Spec Then
                completedPath = Me._Directory.CompletedDocumentsPath
                networkAPath = Me._Directory.SpecNetworkLocationAPath
                networkBPath = Me._Directory.SpecNetworkLocationBPath
            Else
                completedPath = Me._Directory.CompletedDocumentsPath
                networkAPath = Me._Directory.ProprietaryNetworkLocationAPath
                networkBPath = Me._Directory.ProprietaryNetworkLocationBPath
            End If

            Dim completedFile As New IO.FileInfo(completedPath)

            ' If the completed file does not exist then the function will return false
            If Not completedFile.Exists Then
                _Xbox.Show("The following file does not exist in the 'Completed_Documents' folder: " & completedFile.Name)
                result = False
                Exit Function
            End If

            ' Copy the Completed file to the Source file location and then delete the Completed file from the Completed folder location 
            completedFile.CopyTo(networkAPath, overwrite)
            completedFile.CopyTo(networkBPath, overwrite)
            completedFile.Delete()

            ' Test to make sure the file was moved and now exists where it should
            ' which is in the Network location folders both A and B locations
            ' Since these files overwrite the existing files the date needs 
            ' to be check to verify the move was done correctly.
            Dim movedPdfA As New IO.FileInfo(networkAPath)
            Dim movedPdfB As New IO.FileInfo(networkBPath)

            Dim movedPdfADate As DateTime = movedPdfA.LastWriteTime
            Dim movedPdfBDate As DateTime = movedPdfB.LastWriteTime

            Dim today As DateTime = DateTime.Today
            Dim tomorrow As DateTime = today.AddDays(1)

            If movedPdfADate >= today And movedPdfADate < tomorrow Then
                If movedPdfBDate >= today And movedPdfBDate < tomorrow Then
                    result = True
                    _Xbox.Show("Files have been moved.")
                Else
                    result = False
                    _Xbox.Show("Files have NOT been moved correctly.")
                End If
            End If

        Catch ArgNullEx As ArgumentNullException
            Dim DocConEx As New DocconFileMoverException("Please add an Argument to the list.", ArgNullEx)
            Throw DocConEx
        Catch ArgEx As ArgumentException
            Dim DocConEx As New DocconFileMoverException("Please make sure that you have the correct amount of Arguments.", ArgEx)
            Throw DocConEx
        Catch DirNotFoundEx As IO.DirectoryNotFoundException
            Dim DocConEx As New DocconFileMoverException("Directory Not Found!", DirNotFoundEx)
            Throw DocConEx
        Catch PathEx As IO.PathTooLongException
            Dim DocConEx As New DocconFileMoverException("Path is not valid.", PathEx)
            Throw DocConEx
        Catch IOEx As IO.IOException
            Dim DocConEx As New DocconFileMoverException("An Error has occurred. Please contact IS for assistance.", IOEx)
            Throw DocConEx
        Catch SecEx As Security.SecurityException
            Dim DocConEx As New DocconFileMoverException("You may not have permission for this Directory.", SecEx)
            Throw DocConEx
        Catch UnauthEx As UnauthorizedAccessException
            Dim DocConEx As New DocconFileMoverException("You may not have permission for this Directory.", UnauthEx)
            Throw DocConEx
        Catch NotSupEx As NotSupportedException
            Dim DocConEx As New DocconFileMoverException("This function is not supported. Contact IS for assistance.", NotSupEx)
            Throw DocConEx
        End Try

        Return result

    End Function
    '-------------------------------------------------------------------------
    '  MovedFormToForms 
    '-------------------------------------------------------------------------
    Public Function MovedFormToForms(ByVal document As DocumentInformation) As Boolean
        '======================================================================
        ' Moves FORM file from 'Completed_Documents' folder to 'FORMS' folder
        ' 1) Replaces existing with the new form file from completed documents.
        '======================================================================

        '*****************************************************************************************************
        ' Need to figure out how to choose the correct file from the completed docs folder to move to the
        ' correct location. 
        ' Right now it is setup as there is only one file in the completed documents but there are 2 or more.
        ' USE THE DOCCONFILETYPE to determine what the file is ....
        ' Use For each DocconFileType loop to move the correct files
        '*****************************************************************************************************

        Dim result As Boolean
        Dim sourcePath As String        ' This is the path for the file to be moved from
        Dim formPath As String     ' This is the path for the file to be moved to
        'Dim movedFile As IO.FileInfo
        Dim overWrite As Boolean = True

        Try
            ' Verifies that the Completed Document Type is a Form
            If document.CompletedDocumentType = DocconFileMover.CompletedDocumentType.FormTemplate Then
                sourcePath = Me._Directory.CompletedDocumentsPath
                formPath = Me._Directory.FormPath
            Else
                _Xbox.Show("This Document is not a Form\Template.")
                Exit Function
            End If

            Dim completedFile As New IO.FileInfo(sourcePath)

            ' If the source file does not exist then the function will return false
            If Not completedFile.Exists Then
                _Xbox.Show("The following file does not exist in the 'Completed_Documents' folder: " & completedFile.Name)
                result = False
                Exit Function
            End If

            ' Copy the new Form file to the Form file location 
            ' then delete then Completed Form from the Completed Document folder location 
            'movedFile = completedFile.CopyTo(formPath, overWrite)
            completedFile.CopyTo(formPath, overWrite)
            completedFile.Delete()

            ' Test to make sure the file was moved and now exists where it should
            ' which is in the Forms folder
            ' Since these files overwrite the existing files the date needs 
            ' to be check to verify the move was done correctly.
            Dim movedForm As New IO.FileInfo(formPath)
            Dim movedFormDate As DateTime = movedForm.LastWriteTime
            Dim today As DateTime = DateTime.Today
            Dim tomorrow As DateTime = today.AddDays(1)

            If movedFormDate >= today And movedFormDate < tomorrow Then
                result = True
                _Xbox.Show("Files have been moved.")
            Else
                result = False
                _Xbox.Show("Files have NOT been moved correctly.")
            End If
          

        Catch ArgNullEx As ArgumentNullException
            Dim DocConEx As New DocconFileMoverException("Please add an Argument to the list.", ArgNullEx)
            Throw DocConEx
        Catch ArgEx As ArgumentException
            Dim DocConEx As New DocconFileMoverException("Please make sure that you have the correct amount of Arguments.", ArgEx)
            Throw DocConEx
        Catch DirNotFoundEx As IO.DirectoryNotFoundException
            Dim DocConEx As New DocconFileMoverException("Directory Not Found!", DirNotFoundEx)
            Throw DocConEx
        Catch PathEx As IO.PathTooLongException
            Dim DocConEx As New DocconFileMoverException("Path is not valid.", PathEx)
            Throw DocConEx
        Catch IOEx As IO.IOException
            Dim DocConEx As New DocconFileMoverException("An Error has occurred. Please contact IS for assistance.", IOEx)
            Throw DocConEx
        Catch SecEx As Security.SecurityException
            Dim DocConEx As New DocconFileMoverException("You may not have permission for this Directory.", SecEx)
            Throw DocConEx
        Catch UnauthEx As UnauthorizedAccessException
            Dim DocConEx As New DocconFileMoverException("You may not have permission for this Directory.", UnauthEx)
            Throw DocConEx
        Catch NotSupEx As NotSupportedException
            Dim DocConEx As New DocconFileMoverException("This function is not supported. Contact IS for assistance.", NotSupEx)
            Throw DocConEx
        End Try

        Return result

    End Function
    Public Function DeployMoves(ByVal document As DocumentInformation) As Boolean
        Dim allFilesHaveMoved As Boolean
        If Not document Is Nothing Then
            Select Case Me._DocconFileType
                Case DocconFileMover.DocconFileType.Source
                    ' Source file has to be moved to OldRevisionFiles and 
                    ' Renamed so none of the prior revisions are saved over
                    ' prior to the CompletedFile moving to the Source Folder.
                    If MovedSourceFileToOldRevisionFiles(document) Then
                        allFilesHaveMoved = True
                    Else
                        allFilesHaveMoved = False
                    End If
                    ' at this point the source file should have been deleted.
                    ' so if there is still a source file then it needs to be fixed.
                    If MovedCompletedFileToSource(document) Then
                        allFilesHaveMoved = True
                    Else
                        allFilesHaveMoved = False
                    End If

                Case DocconFileMover.DocconFileType.Pdf
                    If MovedPdfToNetworkLocation(document) Then
                        allFilesHaveMoved = True
                    Else
                        allFilesHaveMoved = False
                    End If

                Case DocconFileMover.DocconFileType.Form
                    If MovedFormToForms(document) Then
                        allFilesHaveMoved = True
                    Else
                        allFilesHaveMoved = False
                    End If
            End Select
        End If

        Return allFilesHaveMoved
    End Function
    'Public Sub DeployMoves(ByVal document As DocumentInformation)

    '    If Not document Is Nothing Then
    '        Select Case Me._DocconFileType
    '            Case DocconFileMover.DocconFileType.Source
    '                ' Source file has to be moved to OldRevisionFiles and 
    '                ' Renamed so none of the prior revisions are saved over
    '                ' prior to the CompletedFile moving to the Source Folder.
    '                MovedSourceFileToOldRevisionFiles(document)
    '                ' at this point the source file should have been deleted.
    '                ' so if there is still a source file then it needs to be fixed.
    '                MovedCompletedFileToSource(document)

    '            Case DocconFileMover.DocconFileType.Pdf
    '                MovedPdfToNetworkLocation(document)

    '            Case DocconFileMover.DocconFileType.Form
    '                MovedFormToForms(document)
    '        End Select
    '    End If
    'End Sub
End Class

'=========================================================
'  *****  SOURCE DOCUMENT CLASS  *****                      ADD IN DIFFERENCE FUNCTION
'=========================================================
'Public Class SourceDocument
'    'Inherits DocumentInformation
'    '---------------------------------------------------------
'    '  Class Variables
'    '---------------------------------------------------------
'    Private _FileName As String = String.Empty
'    Private _IsActive As Boolean = True
'    Private _SourcePath As String = String.Empty
'    Private _OldSourcePath As String = String.Empty
'    '---------------------------------------------------------
'    '  Constructors
'    '---------------------------------------------------------
'    Public Sub New()

'    End Sub
'    Public Sub New(ByVal fileInfo As IO.FileInfo, ByVal isActive As Boolean)

'        Dim _OldProprietarySourcePath As String = "C:\DocConFileMover_Testing\Private\DocCon_Proprietary_Source\Old_Document_Revisions\"
'        Dim _ProprietarySourcePath As String = "C:\DocConFileMover_Testing\Private\DocCon_Proprietary_Source\Proprietary_Source\"
'        Dim _OldSpecSourcePath As String = "C:\DocConFileMover_Testing\Private\DocCon_Spec_Source\Old_Document_Revisions\"
'        Dim _SpecSourcePath As String = "C:\DocConFileMover_Testing\Private\DocCon_Spec_Source\Spec_Source\"

'        Me._FileName = fileInfo.Name
'        Me._IsActive = isActive

'        If System.Convert.ToBoolean(DocumentTypeFilterType.Document) Then
'            If System.Convert.ToBoolean(DocumentGroupFilterType.Spec) Then
'                Me._SourcePath = _SpecSourcePath
'                Me._OldSourcePath = _OldSpecSourcePath
'            Else
'                Me._SourcePath = _ProprietarySourcePath
'                Me._OldSourcePath = _OldProprietarySourcePath
'            End If
'        End If
'    End Sub
'    '---------------------------------------------------------
'    '  Properties
'    '---------------------------------------------------------
'    Public Property FileName() As String
'        Get
'            Return Me._FileName
'        End Get
'        Set(ByVal value As String)
'            Me._FileName = value
'        End Set
'    End Property
'    Public Property IsActive() As Boolean
'        Get
'            Return Me._IsActive
'        End Get
'        Set(ByVal value As Boolean)
'            Me._IsActive = value
'        End Set
'    End Property
'    '---------------------------------------------------------
'    '  Functions
'    '---------------------------------------------------------
'    Public Overrides Function ToString() As String
'        Dim returnString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0}", Me._FileName)
'        Return returnString
'    End Function
'Public Function GetOldRevisionChar(ByVal documentName As IO.FileInfo) As String
'    Dim returnRevisionChar As String = String.Empty
'    Dim fileName As String = FileInfo.Name
'    Dim fileNumber As String = Nothing
'    Dim indexOfRevisionChar As Integer
'    Dim lengthOfFileName As Integer = fileName.Length
'    Dim lengthOfFileNumber As Integer = fileNumber.Length

'    indexOfRevisionChar = lengthOfFileName - lengthOfFileNumber

'    returnRevisionChar = returnRevisionChar.Substring(lengthOfFileName, indexOfRevisionChar)
'    Return returnRevisionChar
'End Function
'End Class

''=========================================================
''  *****  PDF DOCUMENT CLASS  *****                         ADD IN DIFFERENCE FUNCTION  
''=========================================================
'Public Class PdfDocument
'    '---------------------------------------------------------
'    '  Class Variables
'    '---------------------------------------------------------
'    Private _FileName As String = String.Empty
'    Private _IsActive As Boolean
'    Private _NetworkLocationApath As String = String.Empty
'    Private _NetworkLocationBpath As String = String.Empty
'    '---------------------------------------------------------
'    '  Constructors
'    '---------------------------------------------------------
'    Public Sub New()

'    End Sub
'    Public Sub New(ByVal fileInfo As IO.FileInfo, ByVal isActive As Boolean)

'        Me._FileName = fileInfo.Name
'        Me._IsActive = isActive

'        Dim _SpecNetworkLocationAPath As String = "C:\DocConFileMover_Testing\Network_A\DocCon_Spec\"
'        Dim _SpecNetworkLocationBPath As String = "C:\DocConFileMover_Testing\Network_B\DocCon_Spec\"
'        Dim _ProprietaryNetworkLocationAPath As String = "C:\DocConFileMover_Testing\Network_A\DocCon_Proprietary\" '& myCompletedDocument.DocumentGroupToString & "\"
'        Dim _ProprietaryNetworkLocationBPath As String = "C:\DocConFileMover_Testing\Network_B\DocCon_Proprietary\" '& myCompletedDocument.DocumentGroupToString & "\"

'        If System.Convert.ToBoolean(DocumentTypeFilterType.Document) Then
'            If System.Convert.ToBoolean(DocumentGroupFilterType.Spec) Then
'                _NetworkLocationApath = _SpecNetworkLocationAPath
'                _NetworkLocationBpath = _SpecNetworkLocationBPath
'            Else
'                _NetworkLocationApath = _ProprietaryNetworkLocationAPath
'                _NetworkLocationBpath = _ProprietaryNetworkLocationBPath
'            End If
'        End If
'    End Sub
'    '---------------------------------------------------------
'    '  Properties
'    '---------------------------------------------------------
'    Public Property FileName() As String
'        Get
'            Return Me._FileName
'        End Get
'        Set(ByVal value As String)
'            Me._FileName = value
'        End Set
'    End Property
'    Public Property IsActive() As Boolean
'        Get
'            Return Me._IsActive
'        End Get
'        Set(ByVal value As Boolean)
'            Me._IsActive = value
'        End Set
'    End Property
'    '---------------------------------------------------------
'    '  Functions
'    '---------------------------------------------------------
'    Public Overrides Function ToString() As String
'        Dim returnString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0}", Me._FileName)
'        Return returnString
'    End Function
'End Class

''=========================================================
''  *****  FORM DOCUMENT CLASS  *****                    
''=========================================================
'Public Class FormDocument
'    Inherits DocumentInformation
'    '---------------------------------------------------------
'    '  Class Variables
'    '---------------------------------------------------------
'    Private _FileName As String = String.Empty
'    Private _IsActive As Boolean
'    Private _FormsPath As String
'    Private _TemplatesPath As String

'    '---------------------------------------------------------
'    '  Constructors
'    '---------------------------------------------------------
'    Public Sub New()

'    End Sub
'    Public Sub New(ByVal fileInfo As IO.FileInfo, ByVal isActive As Boolean)
'        Me._FileName = FileName
'        Me._IsActive = isActive

'        If System.Convert.ToBoolean(DocumentTypeFilterType.FormTemplate) Then
'            If DetermineFormOrTemplate(fileInfo) Then
'                Me._FormsPath = "C:\DocConFileMover_Testing\Private\Forms\"
'            ElseIf Not DetermineFormOrTemplate(fileInfo) Then
'                Me._TemplatesPath = "C:\DocConFileMover_Testing\Private\Templates\"
'            End If
'        End If

'    End Sub
'    '---------------------------------------------------------
'    '  Properties
'    '---------------------------------------------------------
'    Public Property FileName() As String
'        Get
'            Return Me._FileName
'        End Get
'        Set(ByVal value As String)
'            Me._FileName = value
'        End Set
'    End Property
'    Public Property IsActive() As Boolean
'        Get
'            Return Me._IsActive
'        End Get
'        Set(ByVal value As Boolean)
'            Me._IsActive = value
'        End Set
'    End Property
'    '---------------------------------------------------------
'    '  Functions
'    '---------------------------------------------------------
'    Public Overrides Function ToString() As String
'        Dim returnString As String = String.Format(Globalization.CultureInfo.InvariantCulture, "{0}", Me._FileName)
'        Return returnString
'    End Function
'    Public Shared Function DetermineFormOrTemplate(ByVal fileInfo As IO.FileInfo) As Boolean
'        Dim fileName As String = fileInfo.Name
'        Dim result As Boolean
'        Dim separator() As String = {fileInfo.Extension}
'        Dim fileNameNoExtension() As String
'        Dim sc As System.StringComparison

'        fileNameNoExtension = fileName.Split(separator, StringSplitOptions.RemoveEmptyEntries)

'        result = fileNameNoExtension(0).EndsWith("F", sc)
'        Return result
'    End Function
'End Class
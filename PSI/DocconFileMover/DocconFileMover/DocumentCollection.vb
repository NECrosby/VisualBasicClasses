Imports System
Imports System.Collections

Public Class DocumentCollection
    Inherits System.Collections.ObjectModel.Collection(Of DocumentInformation)

    '-------------------------------------------------------------------------
    '  Get Files 
    '-------------------------------------------------------------------------
    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")> _
    Public Shared Function GetFilesForDocumentNumber(ByVal document As DocumentInformation, ByVal path As String) As DocumentCollection
        '======================================================================
        ' 1) Finds all the files in the completed_documents folder that starts 
        '    with the document number that was enter. 
        ' 2) Fills a collection with the filenames and if the compare flag is 
        '    set, it compares the string returned, ignoring the extensions,
        '    to the document number that was entered and 
        '    the difference in filenames are added to the collection also.
        '    Meaning --  the revisions, types of files, etc.
        '======================================================================

        Dim myDocumentNumber As String = document.DocumentNumber
        'Dim myDocumentName As String = document.FileInfo.Name
        Dim myDocumentPath As String = path
        Dim myCollection As New DocumentCollection
        Try
            If myDocumentNumber IsNot Nothing Then
                If myDocumentPath IsNot Nothing Then
                    Dim myFileDirectory As New IO.DirectoryInfo(myDocumentPath)
                    ' To only get documents with the desired number
                    If myFileDirectory.Exists Then
                        Dim fileInfoArray As IO.FileInfo() = myFileDirectory.GetFiles(myDocumentNumber & "*.*")
                        For Each fileInfo As IO.FileInfo In fileInfoArray
                            Dim tempFile As New DocumentInformation(fileInfo, myDocumentNumber, document.DocumentGroup, _
                                                                    document.CompletedDocumentType, document.OldRevision, document.NewRevision, _
                                                                    document.DocconDirectory)
                            myCollection.Add(tempFile)
                        Next
                    End If
                End If
            End If

        Catch PaToLongEx As IO.PathTooLongException
            Dim DocConEx As New DocconFileMoverException("Path is too long.", PaToLongEx)
            Throw DocConEx
        Catch DirNotFoEx As IO.DirectoryNotFoundException
            Dim DocConEx As New DocconFileMoverException("Directory Not Found: " & myDocumentPath, DirNotFoEx)
            Throw DocConEx
        Catch IOex As IO.IOException
            Dim DocConEx As New DocconFileMoverException("Directory Not Found: " & myDocumentPath, IOex)
            Throw DocConEx
            'MessageBox.Show("Directory Not Found: " & myDocumentPath)
        Catch ArgNullEx As ArgumentNullException
            Dim DocConEx As New DocconFileMoverException("Please add an argument.", ArgNullEx)
            Throw DocConEx
        Catch ArgEx As ArgumentException
            Dim DocConEx As New DocconFileMoverException("Please remove invalid characters from the path.", ArgEx)
            Throw DocConEx
            'MessageBox.Show("Too many arguments for the path. Please revise.")
        Catch SecEx As Security.SecurityException
            Dim DocConEx As New DocconFileMoverException("Do not have permissions to access this Directory.", SecEx)
            Throw DocConEx
            'MessageBox.Show("Do not have permissions to access this Directory.")
        End Try

        Return myCollection
    End Function

    Public Sub AddDocuments(ByVal documentValues As DocumentCollection)
        For Each tempDocument As DocumentInformation In documentValues
            Me.Add(tempDocument)
        Next

    End Sub
End Class

'Public Class SourceFileCollection
'    Inherits System.Collections.ObjectModel.Collection(Of SourceDocument)

'End Class

'Public Class PdfCollection
'    Inherits System.Collections.ObjectModel.Collection(Of PdfDocument)

'End Class

'Public Class FormCollection
'    Inherits System.Collections.ObjectModel.Collection(Of FormDocument)

'End Class
Module StudentCollectionModule
    Public studentCollection As New Collection

    Public Sub AddRecord(ByVal s As Student)
        Try
            studentCollection.Add(s, s.ID)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module

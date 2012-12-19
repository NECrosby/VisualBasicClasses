Module PreferredCustomerCollectionModule

    ' Create a collection to hold the PreferredCustomer objects.
    Public preferredCustCollection As New Collection

    ' The AddPrefCustomer procedure adds the object referenced
    ' to the collection. It uses the CustomerNumber as the key.
    Public Sub AddPrefCustomer(ByVal prefCustomer As PreferredCustomer)
        Try
            preferredCustCollection.Add(prefCustomer, (prefCustomer.CustomerNumber).ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module

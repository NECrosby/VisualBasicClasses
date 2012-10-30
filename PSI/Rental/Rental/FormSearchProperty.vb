Public Class FormSearchProperty
    '---------------------------------------------------
    ' Class Variables
    '---------------------------------------------------
    Dim _sender As System.Windows.Forms.Form
    Dim _SearchCollection As Rental.Data.SearchCollection(Of Rental.Data.RentalPropertyFilterType)

    '---------------------------------------------------
    ' ReadOnly Property
    '---------------------------------------------------
    Public ReadOnly Property Searches() As Rental.Data.SearchCollection(Of Rental.Data.RentalPropertyFilterType)
        Get
            Return Me._SearchCollection
        End Get
    End Property
    '---------------------------------------------------
    ' Constructor
    '---------------------------------------------------
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadFilters()
        Me._SearchCollection = New Rental.Data.SearchCollection(Of Rental.Data.RentalPropertyFilterType)
    End Sub
    '---------------------------------------------------
    ' Load Filters
    '---------------------------------------------------
    Private Function LoadFilters() As Boolean
        Dim result As Boolean
        Dim listOfSearchFilters As New Idc.Common.EnumPairCollection(Of Rental.Data.RentalPropertyFilterType)
        Me.ComboBoxFilterBy.DataSource = listOfSearchFilters
        Dim listOfQualifiers As New Idc.Common.EnumPairCollection(Of Rental.Data.QualifierType)
        Me.ComboBoxQualifier.DataSource = listOfQualifiers

        result = True

        Return result
    End Function
    '---------------------------------------------------
    ' Add Button - Adds search criteria to the listbox                         
    '---------------------------------------------------
    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click

        Dim enumFilterType As Idc.Common.EnumPair = CType(Me.ComboBoxFilterBy.SelectedItem, Idc.Common.EnumPair)
        If Not enumFilterType Is Nothing Then
            Try
                Dim enumQualifierType As Idc.Common.EnumPair = CType(Me.ComboBoxQualifier.SelectedItem, Idc.Common.EnumPair)
                If Not enumFilterType Is Nothing Then
                    Try
                        Dim search As New Rental.Data.Search(Of Rental.Data.RentalPropertyFilterType)
                        search.FilterBy = DirectCast(enumFilterType.Value, Rental.Data.RentalPropertyFilterType)
                        search.Value = TextBoxSearchValue.Text
                        search.Qualifier = DirectCast(enumQualifierType.Value, Rental.Data.QualifierType)
                        Me._SearchCollection.Add(search)
                        Me.ListBoxSearchResults.DataSource = Nothing
                        Me.ListBoxSearchResults.DataSource = Me._SearchCollection
                    Catch ex As InvalidCastException
                        MessageBox.Show(ex.ToString)
                    End Try
                End If
            Catch ex As InvalidCastException
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
    '---------------------------------------------------
    ' DoubleClick to delete from listbox                         
    '---------------------------------------------------
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxSearchResults.DoubleClick
        Dim search As Rental.Data.Search(Of Rental.Data.RentalPropertyFilterType)

        If TypeOf ListBoxSearchResults.SelectedItem Is Rental.Data.Search(Of Rental.Data.RentalPropertyFilterType) Then
            search = DirectCast(ListBoxSearchResults.SelectedItem, Rental.Data.Search(Of Rental.Data.RentalPropertyFilterType))
            Me._SearchCollection.Remove(search)
            Me.ListBoxSearchResults.DataSource = Nothing
            Me.ListBoxSearchResults.DataSource = Me._SearchCollection
        End If
    End Sub
    '---------------------------------------------------
    ' Show Results -- closes form window - DGV is loading                      
    '---------------------------------------------------
    Private Sub ButtonShowResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonShowResults.Click
        Me.Close()
    End Sub
    '---------------------------------------------------
    ' Reset Button
    '---------------------------------------------------
    Private Sub ButtonResetSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonResetSearch.Click

    End Sub
End Class
Public Class FormSearchAgreements
    '---------------------------------------------------
    ' Class Variables
    '---------------------------------------------------
    Dim _sender As System.Windows.Forms.Form
    Dim _SearchCollection As Rental.Data.SearchCollection(Of Rental.Data.RentalAgreementFilterType)

    '---------------------------------------------------
    ' ReadOnly Property
    '---------------------------------------------------
    Public ReadOnly Property Searches() As Rental.Data.SearchCollection(Of Rental.Data.RentalAgreementFilterType)
        Get
            Return Me._SearchCollection   ' used to hold info for the main form when called upon
        End Get
    End Property
    '---------------------------------------------------
    ' Constructor
    '---------------------------------------------------
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadFilters()   '<--- calling to load filters to the ComboBoxes
        Me._SearchCollection = New Rental.Data.SearchCollection(Of Rental.Data.RentalAgreementFilterType)
    End Sub
    '---------------------------------------------------
    ' Load Filters
    '---------------------------------------------------
    Public Function LoadFilters() As Boolean
        Dim result As Boolean
        ' Below is referencing the IDC.COMMON library to convert a enum (Filte/Qualifier type) to fill the ComboBox list
        Dim listOfSearchFilters As New Idc.Common.EnumPairCollection(Of Rental.Data.RentalAgreementFilterType)
        Me.ComboBoxFilterBy.DataSource = listOfSearchFilters  '<---loading the FilterBy ComboBox with the Enumerated Type found in the Agreement Collection Object

        Dim listOfQualifiers As New Idc.Common.EnumPairCollection(Of Rental.Data.QualifierType)
        Me.ComboBoxQualifier.DataSource = listOfQualifiers    '<---loading the Qualifier ComboBox with the Enumerated Type found in the Search Object

        result = True
        Return result

    End Function
    '---------------------------------------------------
    ' Add Button - Adds search criteria to the listbox          --- GO THROUGH THIS AGAIN                       
    '---------------------------------------------------
    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        '---------------------------------------------------------------------------------------------------------------
        ' Referencing the IDC.COMMON Library for functionality
        ' --------------------------------------------------------
        ' When getting the Enumeration type from a CombBox, the combo box is holding an object, the select object/item 
        ' needs to be converted BACK to a Specific Enumeration Type.
        '---------------------------------------------------------------------------------------------------------------

        Dim enumFilterType As Idc.Common.EnumPair = CType(Me.ComboBoxFilterBy.SelectedItem, Idc.Common.EnumPair)    ' holder for EnumType
        If Not enumFilterType Is Nothing Then   ' testing that there is something
            Try
                Dim enumQualifierType As Idc.Common.EnumPair = CType(Me.ComboBoxQualifier.SelectedItem, Idc.Common.EnumPair)    ' holder for EnumType
                If Not enumFilterType Is Nothing Then   ' testing that there is something
                    Try
                        Dim search As New Rental.Data.Search(Of Rental.Data.RentalAgreementFilterType)  ' holder for a search object
                        search.FilterBy = DirectCast(enumFilterType.Value, Rental.Data.RentalAgreementFilterType)   ' casting the enum value to the Filter TYPE
                        search.Value = TextBoxSearchValue.Text  ' search object value property is a string data type so no conversion necessary
                        search.Qualifier = DirectCast(enumQualifierType.Value, Rental.Data.QualifierType)   ' casting to Qualifier TYPE
                        Me._SearchCollection.Add(search)    ' add this Search to the Search Collection
                        Me.ListBoxSearchResults.DataSource = Nothing    ' necessary to clear out the old
                        Me.ListBoxSearchResults.DataSource = Me._SearchCollection ' put the new in the listbox
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
    Private Sub ListBoxSearchResults_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxSearchResults.DoubleClick
        ' holder instaniated search of agreement filter type
        Dim search As Rental.Data.Search(Of Rental.Data.RentalAgreementFilterType)

        ' Test to see if the types match
        If TypeOf ListBoxSearchResults.SelectedItem Is Rental.Data.Search(Of Rental.Data.RentalAgreementFilterType) Then
            ' if they match cast the selected item as the search(agreement filter type)
            search = DirectCast(ListBoxSearchResults.SelectedItem, Rental.Data.Search(Of Rental.Data.RentalAgreementFilterType))
            ' remove it from the collection now.
            Me._SearchCollection.Remove(search)
            Me.ListBoxSearchResults.DataSource = Nothing    ' necessary to clear out the old
            Me.ListBoxSearchResults.DataSource = Me._SearchCollection ' put the new in the listbox
        End If
    End Sub
    '---------------------------------------------------
    ' Show Results -- closes form window - DGV is loading                      
    '---------------------------------------------------
    Private Sub ButtonShowResults_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonShowResults.Click
        Me.Close()
    End Sub
    '---------------------------------------------------
    ' Reset Button
    '---------------------------------------------------
End Class



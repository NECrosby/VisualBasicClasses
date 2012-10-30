Public Class Form1
    '---------------------------------------------------
    ' Class Level Variables                          
    '---------------------------------------------------
    Dim _MyProperties As Rental.Data.RentalPropertyCollection
    Dim _MyRenters As Rental.Data.RenterCollection
    Dim _MyAgreements As Rental.Data.RentalAgreementCollection
    '---------------------------------------------------
    ' New Form Constructor                         
    '---------------------------------------------------
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._MyProperties = New Rental.Data.RentalPropertyCollection
        Me._MyRenters = New Rental.Data.RenterCollection
        Me._MyAgreements = New Rental.Data.RentalAgreementCollection
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    '   RENTER SECTION
    '-----------------------------------------------------------------------------------------------------------------------------------------

    '---------------------------------------------------
    ' Query Renter                          
    '---------------------------------------------------    
    Private Sub ButtonQueryRenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQueryRenter.Click
        '--------------------------------------------------------------------------------------------------
        ' ---  Testing Info  ---
        'Me._MyRenters = Rental.Data.RenterCollection.QueryDatabase(Nothing)
        'Me.DataGridView1.DataSource = Nothing
        'Me._MyRenters = New Rental.Data.RenterCollection(Data.RenterFilterType.Phone, "6512068725")
        'Dim searches As Rental.Data.SearchCollection(Of Rental.Data.RenterFilterType)
        'Dim search As Rental.Data.Search(Of Rental.Data.RenterFilterType)
        'Dim search2 As Rental.Data.Search(Of Rental.Data.RenterFilterType)
        'searches = New Rental.Data.SearchCollection(Of Rental.Data.RenterFilterType)
        'search = New Rental.Data.Search(Of Rental.Data.RenterFilterType)
        'search2 = New Rental.Data.Search(Of Rental.Data.RenterFilterType)
        'search.FilterBy = Data.RenterFilterType.PermanentCity
        'search.Value = "hastings"
        'searches.Add(search)
        'search2.FilterBy = Data.RenterFilterType.LastName
        'search2.Value = "Crosby"
        'searches.Add(search2)
        '--------------------------------------------------------------------------------------------------

        Me.DataGridView1.DataSource = Nothing
        Me._MyRenters = Rental.Data.RenterCollection.QueryDatabase(Nothing)
        DisplayDataGridView(Me._MyRenters)
        GroupBoxAgreementDetails.Visible = False
    End Sub
    '---------------------------------------------------
    ' Search Renters                         
    '--------------------------------------------------- 
    Private Sub ButtonSearchRenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchRenter.Click
        Dim frmSearchWindow As New FormSearchRenter()
        frmSearchWindow.ShowDialog()
        Dim searches As Rental.Data.SearchCollection(Of Rental.Data.RenterFilterType)
        searches = frmSearchWindow.searches
        Me._MyRenters = New Rental.Data.RenterCollection(searches)
        DisplayDataGridView(Me._MyRenters)
    End Sub
    '---------------------------------------------------
    ' Show Renter Form                          
    '---------------------------------------------------  
    Private Sub ButtonAddRenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddRenter.Click
        Dim frmAddRenter As New FormAddRenter(Me, Nothing)
        frmAddRenter.Show()
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    '   PROPERTY SECTION  
    '-----------------------------------------------------------------------------------------------------------------------------------------

    '---------------------------------------------------
    ' Query Properties                         
    '---------------------------------------------------  
    Private Sub ButtonQueryProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQueryProperties.Click
        '--------------------------------------------------------------------------------------------------
        ' ---  Testing Info  ---
        'Dim searches As Rental.Data.SearchCollection(Of Rental.Data.RentalPropertyFilterType)
        'Dim search As Rental.Data.Search(Of Rental.Data.RentalPropertyFilterType)
        'Dim search2 As Rental.Data.Search(Of Rental.Data.RentalPropertyFilterType)
        'searches = New Rental.Data.SearchCollection(Of Rental.Data.RentalPropertyFilterType)
        'search = New Rental.Data.Search(Of Rental.Data.RentalPropertyFilterType)
        'search2 = New Rental.Data.Search(Of Rental.Data.RentalPropertyFilterType)
        'search.FilterBy = Data.RentalPropertyFilterType.hasParking
        'search.Value = "yes"
        'searches.Add(search)
        'search2.FilterBy = Data.RentalPropertyFilterType.isVacant
        'search2.Value = "no"
        'searches.Add(search2)
        'Me._MyProperties = New Rental.Data.RentalPropertyCollection(searches)
        'Me._MyProperties = Rental.Data.RentalPropertyCollection.QueryDatabase(Nothing)
        'Me.DataGridView1.DataSource = Nothing
        'Me._MyProperties = New Rental.Data.RentalPropertyCollection(Data.RentalPropertyFilterType.Zip, "55033")
        'Me.DataGridView1.DataSource = Me._MyProperties
        'Me.LabelCount.Text = String.Format("Record Count: {0}", Me._MyProperties.Count)
        '--------------------------------------------------------------------------------------------------

        Me.DataGridView1.DataSource = Nothing
        Me._MyProperties = Rental.Data.RentalPropertyCollection.QueryDatabase(Nothing)
        DisplayDataGridView(Me._MyProperties)
        GroupBoxAgreementDetails.Visible = False
    End Sub
    '---------------------------------------------------
    ' Search Property                         
    '--------------------------------------------------- 
    Private Sub ButtonSearchProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchProperty.Click
        Dim frmSearchWindow As New FormSearchProperty()
        frmSearchWindow.ShowDialog()
        Dim searches As Rental.Data.SearchCollection(Of Rental.Data.RentalPropertyFilterType)
        searches = frmSearchWindow.Searches
        Me._MyProperties = New Rental.Data.RentalPropertyCollection(searches)
        DisplayDataGridView(Me._MyProperties)

    End Sub
    '---------------------------------------------------
    ' Show Property Form                         
    '---------------------------------------------------  
    Private Sub ButtonAddProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddProperty.Click
        Dim formAddProperty As New FormAddProperty(Me, Nothing)
        formAddProperty.Show()
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    ' AGREEMENT SECTION
    '-----------------------------------------------------------------------------------------------------------------------------------------

    '---------------------------------------------------
    ' Query Rental Agreement                         
    '---------------------------------------------------  
    Private Sub ButtonQueryAgreements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQueryAgreements.Click
        '--------------------------------------------------------------------------------------------------
        ' ---  Testing Info  ---
        ' Declaring a search collection
        ' Dim searches As Rental.Data.SearchCollection(Of Rental.Data.RentalAgreementFilterType)
        ' Declaring a search object to put into the search Collection
        ' Dim search As Rental.Data.Search(Of Rental.Data.RentalAgreementFilterType)
        ' Dim search2 As Rental.Data.Search(Of Rental.Data.RentalAgreementFilterType)
        ' Instaniate the search & search collection objects
        ' searches = New Rental.Data.SearchCollection(Of Rental.Data.RentalAgreementFilterType)
        ' search = New Rental.Data.Search(Of Rental.Data.RentalAgreementFilterType)
        ' search2 = New Rental.Data.Search(Of Rental.Data.RentalAgreementFilterType)
        ' Accessing the filterBy & value properties of the search object 
        ' -- FilterBy is the Column you want to search, value is the criteria that you want to see.
        ' search.FilterBy = Data.RentalAgreementFilterType.LeaseAmount
        ' search.Value = "1000"
        ' Now adding the searched object to the search collection
        ' searches.Add(search)
        ' search2.FilterBy = Data.RentalAgreementFilterType.hasPaidDamageDeposit
        ' search2.Value = "yes"
        ' searches.Add(search2)
        '-----------------------------------------------------------------------------------------------------------------------------
        ' search.FilterBy = Data.RentalAgreementFilterType.PropertyId
        ' search.Value = 3.ToString
        ' searches.Add(search)
        ' MessageBox.Show(searches.Count.ToString)
        ' Me._MyAgreements = Rental.Data.RentalAgreementCollection.QueryDatabase(Nothing)
        ' Me.DataGridView1.DataSource = Nothing
        ' Me._MyAgreements = New Rental.Data.RentalAgreementCollection(Data.RentalAgreementFilterType.LeaseStartDate, "12/1/2011")
        '-----------------------------------------------------------------------------------------------------------------------------
        ' Going into the Rental Agreement constructor telling it what to pull into the DGV
        ' Me._MyAgreements = New Rental.Data.RentalAgreementCollection(searches)
        ' Me.DataGridView1.DataSource = Me._MyAgreements
        ' Me.LabelCount.Text = String.Format("Record Count: {0}", Me._MyAgreements.Count)
        ' DisplayDataGridView(Me._MyAgreements)
        '-----------------------------------------------------------------------------------------------------------------------------
        ' Me.DataGridView1.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"
        ' Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "MM/dd/yyyy"
        ' Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "MM/dd/yyyy"
        '-----------------------------------------------------------------------------------------------------------------------------

        Me.DataGridView1.DataSource = Nothing
        Me._MyAgreements = Rental.Data.RentalAgreementCollection.QueryDatabase(Nothing)
        DisplayDataGridView(Me._MyAgreements)
        GroupBoxAgreementDetails.Visible = True
    End Sub
    '---------------------------------------------------
    ' Search Agreement                         
    '--------------------------------------------------- 
    Private Sub ButtonSearchAgreements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchAgreements.Click
        Dim frmSearchWindow As New FormSearchAgreements()   ' new form instaniation
        frmSearchWindow.ShowDialog()                        ' show only one new form at a time
        Dim searches As Rental.Data.SearchCollection(Of Rental.Data.RentalAgreementFilterType)  ' Instaniate a search collection of rental agreement
        searches = frmSearchWindow.Searches                 ' This is where the Public read only property on the form pulls and fills the search collection object
        Me._MyAgreements = New Rental.Data.RentalAgreementCollection(searches)  ' New Agreement collection being told to pull the objects that match the criteria from the search window.
        DisplayDataGridView(Me._MyAgreements)               ' after the search window closes this is where the DGV is filled!!!
    End Sub
    '---------------------------------------------------
    ' Show Agreement Form                          
    '---------------------------------------------------
    Private Sub ButtonAddAgreements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAddAgreement.Click
        Dim frmAddAgreement As New FormRentalAgreement(Me, Nothing)
        frmAddAgreement.Show()
    End Sub
    '---------------------------------------------------
    ' Displays Agreement Details in Group Box                          
    '---------------------------------------------------
    Private Sub DataGridView1_RowSelection(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If Not e Is Nothing Then
            Dim rowIndex As Int32 = e.RowIndex      ' getting the row index assigning to a variable
            If rowIndex >= 0 Then                   ' if not default -1 then the will be edited
                Try
                    If TypeOf DataGridView1.Rows(rowIndex).DataBoundItem Is Rental.Data.RentalAgreement Then
                        Dim myAgreement As Rental.Data.RentalAgreement = DirectCast(DataGridView1.Rows(rowIndex).DataBoundItem, Rental.Data.RentalAgreement)
                        Me.LabelPropertyInformationValue.Text = myAgreement.RentalProperty.ToString
                        Me.LabelRenterInformationValue.Text = myAgreement.Renter.ToString.ToString
                    End If
                Catch IndexX As IndexOutOfRangeException
                    MessageBox.Show(IndexX.Message)
                End Try
            End If
        End If
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------------------------
    ' COMMON for Renter, Property, and Agreements
    '-----------------------------------------------------------------------------------------------------------------------------------------

    '---------------------------------------------------
    ' Edit Selected Cell Content                            
    '---------------------------------------------------
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If Not e Is Nothing Then
            Dim rowIndex As Int32 = e.RowIndex      ' getting the row index assigning to a variable
            If rowIndex >= 0 Then                   ' if not default -1 then the will be edited
                Try
                    If Not DataGridView1.Rows(rowIndex).DataBoundItem Is Nothing Then
                        If TypeOf DataGridView1.Rows(rowIndex).DataBoundItem Is Rental.Data.RentalProperty Then ' if the object is a Rental property then do the following
                            ' variable to hold the object -- has to be casted to a rental property from a row in a DGV
                            Dim myRentalProperty As Rental.Data.RentalProperty = DirectCast(DataGridView1.Rows(rowIndex).DataBoundItem, Rental.Data.RentalProperty)
                            ' variable to hold the data from the new rental property object
                            Dim frmAddProperty As New FormAddProperty(Me, myRentalProperty)
                            ' show the dialog with the info
                            frmAddProperty.ShowDialog()
                        ElseIf TypeOf DataGridView1.Rows(rowIndex).DataBoundItem Is Rental.Data.Renter Then
                            Dim myRenter As Rental.Data.Renter = DirectCast(DataGridView1.Rows(rowIndex).DataBoundItem, Rental.Data.Renter)
                            Dim frmAddRenter As New FormAddRenter(Me, myRenter)
                            frmAddRenter.ShowDialog()
                        ElseIf TypeOf DataGridView1.Rows(rowIndex).DataBoundItem Is Rental.Data.RentalAgreement Then
                            Dim myAgreement As Rental.Data.RentalAgreement = DirectCast(DataGridView1.Rows(rowIndex).DataBoundItem, Rental.Data.RentalAgreement)
                            Dim frmAddAgreement As New FormRentalAgreement(Me, myAgreement)
                            frmAddAgreement.ShowDialog()
                        End If

                    End If
                Catch IndexX As IndexOutOfRangeException
                    MessageBox.Show(IndexX.Message)
                End Try
            End If
        End If
    End Sub

    '---------------------------------------------------
    ' Displays DGV                          
    '---------------------------------------------------
    Public Sub DisplayDataGridView(ByVal obj As Object)
        If Not obj Is Nothing Then
            If TypeOf obj Is Rental.Data.RenterCollection Then
                Me.DataGridView1.DataSource = Me._MyRenters
                Me.LabelCount.Text = String.Format("Record Count: {0}", Me._MyRenters.Count)
            ElseIf TypeOf obj Is Rental.Data.RentalPropertyCollection Then
                Me.DataGridView1.DataSource = Me._MyProperties
                Me.LabelCount.Text = String.Format("Record Count: {0}", Me._MyProperties.Count)
            ElseIf TypeOf obj Is Rental.Data.RentalAgreementCollection Then
                Me.DataGridView1.DataSource = Me._MyAgreements
                Me.LabelCount.Text = String.Format("Record Count: {0}", Me._MyAgreements.Count)
                Me.DataGridView1.Columns(1).DefaultCellStyle.Format = "MM/dd/yyyy"
                Me.DataGridView1.Columns(3).DefaultCellStyle.Format = "MM/dd/yyyy"
                Me.DataGridView1.Columns(4).DefaultCellStyle.Format = "MM/dd/yyyy"
            End If
        End If
    End Sub
End Class

' Naomi Crosby
' Chapter 6 Assignment

Public Class Form1
    Const decTAX As Decimal = 0.06D
    Const intLABOR_PER_HOUR As Decimal = 20

    ' Service Charge Costs
    Const decOIL_CHANGE_COST As Decimal = 26D
    Const decLUBE_JOB_COST As Decimal = 18D
    Const decRADIATOR_FLUSH_COST As Decimal = 30D
    Const decTRANSMISSION_FLUSH_COST As Decimal = 80D
    Const decINSPECTION_COST As Decimal = 15D
    Const decREPLACE_MUFFLER_COST As Decimal = 100D
    Const decTIRE_ROTATION_COST As Decimal = 20D
    Dim strServicesPerformed As String = String.Empty

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Me.ClearOilLube()
        Me.ClearFlushes()
        Me.ClearMisc()
        Me.ClearOther()
        Me.ClearFees()
        lblServicesPerformed.Visible = False
        lblSummaryList.Visible = False
    End Sub

    Private Sub btnCalculateTotal_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculateTotal.Click
        Dim intLaborValue As Integer = 0
        Dim decPartsValue As Decimal = 0D
        Dim decServiceLaborValue As Decimal = 0D

        ' Validationg Labor input box
        If txtLabor.Text = String.Empty Then
            ' if there isn't any labor charges
            decServiceLaborValue = OilLubeCharges() + FlushCharges() + MiscCharges()
        Else
            If Integer.TryParse(txtLabor.Text, intLaborValue) Then
                intLaborValue = intLaborValue * intLABOR_PER_HOUR
                ' if there are labor charges
                decServiceLaborValue = Convert.ToDecimal(intLaborValue) + OilLubeCharges() + FlushCharges() + MiscCharges()
            Else
                MessageBox.Show("Hours worked must be billed as full hours.")
            End If
        End If

        ' -----  Display values into the Summary Labels  -----
        lblServicesLabor.Text = decServiceLaborValue.ToString("c")  ' Service & Labor Label


        ' Validating Parts input box                                ' Parts & Tax Label(tax if parts is not empty) 
        If txtParts.Text = String.Empty Then
            lblParts.Text = decPartsValue.ToString("c")
            lblTax.Text = "$0.00"
        Else
            If Decimal.TryParse(txtParts.Text, decPartsValue) Then
                lblParts.Text = decPartsValue.ToString("c")
                lblTax.Text = TaxCharges.ToString("c")
            End If
        End If
        lblTotalFees.Text = TotalCharges.ToString("c")              ' Total Fees Label

        ' Services Perform Summary List to Customer
        lblServicesPerformed.Visible = True
        lblSummaryList.Text = DisplaySummaryList(decPartsValue, intLaborValue)
        lblSummaryList.Visible = True
    End Sub

    Private Sub ClearOilLube()
        chkOilChange.Checked = False
        chkLubeJob.Checked = False
    End Sub

    Private Sub ClearFlushes()
        chkRadiatorFlush.Checked = False
        chkTransmissionFlush.Checked = False
    End Sub

    Private Sub ClearMisc()
        chkInspection.Checked = False
        chkReplaceMuffler.Checked = False
        chkTireRotation.Checked = False
    End Sub

    Private Sub ClearOther()
        txtParts.Text = String.Empty
        txtLabor.Text = String.Empty
    End Sub

    Private Sub ClearFees()
        lblServicesLabor.Text = String.Empty
        lblParts.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotalFees.Text = String.Empty
    End Sub

    Function OilLubeCharges() As Decimal
        Dim decOilLubeCharges As Decimal = 0D

        ' Oil Change checked or not
        If chkOilChange.Checked Then
            decOilLubeCharges += decOIL_CHANGE_COST
        End If
        ' Lube checked or not
        If chkLubeJob.Checked Then
            decOilLubeCharges += decLUBE_JOB_COST
        End If

        Return decOilLubeCharges
    End Function

    Function FlushCharges() As Decimal
        Dim decFlushCharges As Decimal = 0D

        ' Radiator Flush Checked or not
        If chkRadiatorFlush.Checked Then
            decFlushCharges += decRADIATOR_FLUSH_COST
        End If
        ' Transmission Flush or not
        If chkTransmissionFlush.Checked Then
            decFlushCharges += decTRANSMISSION_FLUSH_COST
        End If

        Return decFlushCharges
    End Function

    Function MiscCharges() As Decimal
        Dim decMiscCharges As Decimal = 0D

        ' inspection checked or not
        If chkInspection.Checked Then
            decMiscCharges += decINSPECTION_COST
        End If
        ' Muffler checked or not
        If chkReplaceMuffler.Checked Then
            decMiscCharges += decREPLACE_MUFFLER_COST
        End If
        ' Tire Rotated or not
        If chkTireRotation.Checked Then
            decMiscCharges += decTIRE_ROTATION_COST
        End If

        Return decMiscCharges
    End Function

    Function OtherCharges() As Decimal
        Dim decOtherCharges As Decimal = 0D
        Dim decPartsValue As Decimal = 0D
        Dim intLaborValue As Integer = 0

        ' Values have to be positive numbers & have numbers
        If txtParts.Text <> String.Empty Then
            If Decimal.TryParse(txtParts.Text, decPartsValue) Then
                If decPartsValue >= 0 Then
                    decOtherCharges += decPartsValue
                Else
                    MessageBox.Show("Parts charge cannot be negative amount.")
                End If
            Else
                MessageBox.Show("Please enter a numeric value into Parts.")
            End If
        End If

        ' Values have to be positive numbers & have numbers
        If txtLabor.Text <> String.Empty Then
            If Integer.TryParse(txtLabor.Text, intLaborValue) Then
                If intLaborValue > 0 Then
                    decOtherCharges += (intLaborValue * intLABOR_PER_HOUR)
                Else
                    MessageBox.Show("Labor charge cannot be negative amount.")
                End If
            Else
                MessageBox.Show("Please enter a numeric value into Labor.")
            End If
        End If

        Return decOtherCharges
    End Function

    Function TaxCharges() As Decimal
        Dim decTaxOnParts As Decimal = 0D
        Dim decPartsValue As Decimal = 0D

        ' Tax on parts only
        If Decimal.TryParse(txtParts.Text, decPartsValue) Then
            decTaxOnParts = decPartsValue * decTAX
        End If

        Return decTaxOnParts
    End Function

    Function TotalCharges() As Decimal
        Dim decTotalCharges As Decimal = 0D

        ' Add all the charges together
        decTotalCharges = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges()

        Return decTotalCharges
    End Function

    Function DisplaySummaryList(ByVal partsValue As Decimal, laborValue As Decimal) As String
        Dim listValue As String = String.Empty

        If chkOilChange.Checked Then
            listValue += "Oil Change" + ControlChars.NewLine
        End If
        If chkLubeJob.Checked Then
            listValue += "Lube Job" + ControlChars.NewLine
        End If
        If chkRadiatorFlush.Checked Then
            listValue += "Radiator Flush" + ControlChars.NewLine
        End If
        If chkTransmissionFlush.Checked Then
            listValue += "Transmission Flush" + ControlChars.NewLine
        End If
        If chkInspection.Checked Then
            listValue += "Inspection" + ControlChars.NewLine
        End If
        If chkReplaceMuffler.Checked Then
            listValue += "Replace Muffler" + ControlChars.NewLine
        End If
        If chkTireRotation.Checked Then
            listValue += "Tires Rotated" + ControlChars.NewLine
        End If
        If txtParts.Text <> String.Empty Then
            listValue += "Parts     " + partsValue.ToString("c") + ControlChars.NewLine
        End If

        If txtLabor.Text <> String.Empty Then
            listValue += "Labor     " + laborValue.ToString("c") + ControlChars.NewLine
        End If

        Return listValue
    End Function
End Class

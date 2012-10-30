Imports Microsoft.Office.Interop.OutlookViewCtl
Imports System.Reflection

Public Class Form1

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim outlookApplication As Microsoft.Office.Interop.Outlook.Application
        Dim contacts As Microsoft.Office.Interop.Outlook.AddressEntries
        Dim outlookNameSpace As Microsoft.Office.Interop.Outlook.NameSpace
        Dim entry As Microsoft.Office.Interop.Outlook.AddressEntry
        Dim contact As Int32

        outlookApplication = New Microsoft.Office.Interop.Outlook.Application
        outlookNameSpace = outlookApplication.GetNamespace("MAPI")
        contacts = outlookNameSpace.AddressLists("Global Address List").AddressEntries

        For contact = 1 To contacts.Count
            entry = contacts(contact)
            ListBox1.DisplayMember = "Name"
            'ListBox1.Items.Add(entry.Name & " [" & entry.Name & "]")
            ListBox1.Items.Add(Microsoft.VisualBasic.StrConv(entry.Name, VbStrConv.ProperCase))
        Next

        LabelEntryCount.Text = String.Format(Globalization.CultureInfo.InvariantCulture, "Number of Contact: {0}", contacts.Count)

        entry = Nothing
        contacts = Nothing
        outlookNameSpace = Nothing

        'outlookApplication.Quit
        ' Set outlookApplication = Nothing
    End Sub
End Class

Imports System
Imports System.Collections

Public Class EquipHistoryCollection
    Inherits System.Collections.ObjectModel.Collection(Of EquipHistory)

    '---------------------------------------------------
    ' QueryDatabase                                     
    '---------------------------------------------------

    Public Shared Function QueryDatabase() As EquipHistoryCollection
        Dim ReturnEquipHistory As New EquipHistoryCollection
        Dim queryEqHis As String = "SELECT date_time, empid, machine , status1_code, comments FROM [A16 - Equip History]"  '[A16 - Equip History] should be [EquipmentHistory]
        Dim connectionStringEqHis As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=W:\ACCESS\practiceExercise06082011.accdb;Persist Security Info=False;"
        Dim connectionEqHis As OleDb.OleDbConnection

        Try
            connectionEqHis = New OleDb.OleDbConnection(connectionStringEqHis)
            Dim commandEqHis As New OleDb.OleDbCommand(queryEqHis, connectionEqHis)
            Dim DataAdapterEqHis As New OleDb.OleDbDataAdapter
            connectionEqHis.Open()
            DataAdapterEqHis.SelectCommand = commandEqHis
            Dim tableEqHis As New Data.DataTable
            DataAdapterEqHis.Fill(tableEqHis)
            ReturnEquipHistory = LoadObjectCollection(tableEqHis)
            connectionEqHis.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return ReturnEquipHistory

    End Function

    '---------------------------------------------------
    ' LoadObjectCollection                          
    '---------------------------------------------------

    Private Shared Function LoadObjectCollection(ByVal tableEqHis As Data.DataTable) As EquipHistoryCollection
        Dim ReturnEquipHistory As New EquipHistoryCollection

        If tableEqHis IsNot Nothing Then
            Dim eqHisDateTime As DateTime = DateTime.MinValue
            Dim eqHisMachine As String = String.Empty
            Dim eqHisEmpid As String = String.Empty
            Dim eqHisStatusCode As String = String.Empty
            Dim eqHisComments As String = String.Empty
            Dim eqHisAdditionalComments As String = String.Empty

            For Each row As Data.DataRow In tableEqHis.Rows
                eqHisDateTime = System.Convert.ToDateTime(row("date_time"))
                eqHisMachine = row("machine").ToString
                eqHisEmpid = row("empid").ToString
                eqHisStatusCode = row("status1_code").ToString
                eqHisComments = row("comments").ToString

                Dim equipHistory As New EquipHistory(eqHisDateTime, eqHisMachine, eqHisEmpid, eqHisStatusCode, eqHisComments, eqHisAdditionalComments)
                ReturnEquipHistory.Add(equipHistory)
            Next
        End If

        Return ReturnEquipHistory
    End Function

End Class

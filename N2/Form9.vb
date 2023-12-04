Imports System.ComponentModel

Public Class frm_workers

    Dim ret As String
    Dim f As Form
    Private Sub dtgr_wrk_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgr_wrk.CellDoubleClick
        If e.RowIndex <> -1 Then
            ret = "wrk_edit"
            f = New frm_wrk_edit(dtgr_wrk.Rows(e.RowIndex).Cells(0).FormattedValue, dtgr_wrk.Rows(e.RowIndex).Cells(1).FormattedValue, dtgr_wrk.Rows(e.RowIndex).Cells(3).FormattedValue)
            Me.Close()
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        ret = "new_worker"
        frm_new_worker.Show()
        Me.Close()
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        ret = "mgr"
        frm_mgr.Show()
        Me.Close()
    End Sub

    Private Sub frm_workers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data("SELECT name,occupation,entry,on_leave FROM tb_workers where active='1';", dtgr_wrk)
    End Sub

    Private Sub frm_workers_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case ret
            Case "mgr"
                frm_mgr.Show()
            Case "new_worker"
                frm_new_worker.Show()
            Case "wrk_edit"
                f.Show()
            Case Else
                frm_mgr.Show()
        End Select
    End Sub
End Class
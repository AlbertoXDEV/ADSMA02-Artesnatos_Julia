Imports System.ComponentModel

Public Class frm_mgr
    Dim ret = ""
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        usr = ""
        ret = "login"
        Me.Close()
    End Sub

    Private Sub btn_client_Click(sender As Object, e As EventArgs) Handles btn_client.Click
        ret = "client_list"
        Me.Close()
    End Sub

    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click
        ret = "reports"
        Me.Close()
    End Sub

    Private Sub btn_newWorker_Click(sender As Object, e As EventArgs) Handles btn_newWorker.Click
        ret = "workers"
        Me.Close()
    End Sub

    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click
        ret = "stock"
        Me.Close()
    End Sub

    Private Sub frm_mgr_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case ret
            Case "login"
                frm_login.Show()
            Case "reports"
                frm_reports.Show()
            Case "client_list"
                frm_client_list.Show()
            Case "workers"
                frm_workers.Show()
            Case "stock"
                frm_stock.Show()
            Case Else
                usr = ""
                frm_login.Show()
        End Select
    End Sub
End Class
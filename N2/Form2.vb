Imports System.ComponentModel

Public Class frm_caixa

    Dim s As String
    Private Sub btn_newSale_Click(sender As Object, e As EventArgs) Handles btn_newSale.Click
        s = "sel_client"
        Me.Close()
    End Sub

    Private Sub btn_newClient_Click(sender As Object, e As EventArgs) Handles btn_newClient.Click
        s = "newClient(False)"
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        usr = ""
        s = "login"
        Me.Close()
    End Sub

    Private Sub frm_caixa_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case s
            Case "sel_client"
                frm_sel_client.Show()
            Case "newClient(False)"
                Dim a As New frm_newClient(False)
                a.Show()
            Case "login"
                frm_login.Show()
            Case Else
                frm_login.Show()
        End Select
    End Sub
End Class
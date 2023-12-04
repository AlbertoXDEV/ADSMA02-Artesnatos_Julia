
Imports System.ComponentModel

Public Class frm_sel_client
    Dim a, b As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        a = False

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub dtrg_clients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtrg_clients.CellContentClick
        If dtrg_clients.Columns(e.ColumnIndex).Name.Equals("btn") Then
            a = "sales"
            b = dtrg_clients.Rows(e.RowIndex).Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        a = "newClient"
        Me.Close()
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        a = "ret"
        Me.Close()
    End Sub

    Private Sub frm_sel_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data("SELECT name FROM tb_clients", dtrg_clients)
    End Sub

    Private Sub frm_sel_client_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case a
            Case "sales"
                Dim f As New frm_sales(b)
                f.Show()
            Case "newClient"
                Dim d As New frm_newClient(True)
                d.Show()
            Case "ret"
                frm_caixa.Show()
            Case Else
                frm_caixa.Show()
        End Select
    End Sub
End Class
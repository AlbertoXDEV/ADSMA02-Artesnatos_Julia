Imports System.ComponentModel

Public Class frm_edit_client
    Dim old, ret As String
    Sub New(client As String, cep As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txt_name.Text = client
        old = client
        txt_cep.Text = cep
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            sql.CommandText = "update tb_clients set name=? CEP=? where name='" & old & ";"
            prepare("name", ADODB.DataTypeEnum.adVarChar, 100, txt_name.Text)
            prepare("CEP", ADODB.DataTypeEnum.adVarChar, 100, txt_cep.Text)
            sql.Execute()
            sql.Parameters.Delete("name")
            sql.Parameters.Delete("CEP")
            MsgBox("Cliente editado", vbOKOnly, "Sucesso")
            ret = "client_list"
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Erro")
        End Try
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        ret = "client_list"
        Me.Close()
    End Sub

    Private Sub frm_edit_client_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case ret
            Case "client_list"
                frm_client_list.Show()
            Case Else
                frm_client_list.Show()
        End Select
    End Sub
End Class
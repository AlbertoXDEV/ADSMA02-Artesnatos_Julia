Imports System.ComponentModel

Public Class frm_newClient

    Dim accessPoint, ret As String

    Sub New(saleAccess As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If saleAccess Then
            accessPoint = "frm_sale"
        Else
            accessPoint = "frm_caixa"
        End If

    End Sub
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        If Not txt_name.Equals("") And Not txt_cep.Equals("") Then
            Try
                sql.CommandText = "select * from tb_clients where name='" & txt_name.Text & "';"
                rs = sql.Execute()
                If rs.EOF Then
                    sql.CommandText = "insert into tb_clients (name,CEP) values('" & txt_name.Text & "','" & txt_cep.Text & "');"
                    sql.Execute()
                    txt_cep.Clear()
                    txt_name.Clear()
                    MsgBox("Cliente cadastrado", vbOKOnly, "Sucesso")
                    If accessPoint.Equals("frm_caixa") Then
                        ret = "caixa"
                        Me.Close()
                    Else
                        ret = "sales"

                        Me.Close()
                    End If
                Else
                    MsgBox("Já existe um cliente com esse nome", vbOKOnly, "Cliente já cadastrado")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Erro")
            End Try
        End If
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        ret = "selClient"
        Me.Close()
    End Sub

    Private Sub frm_newClient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case ret
            Case "sales"
                Dim f As New frm_sales(txt_name.Text)
                f.Show()
            Case "caixa"
                frm_caixa.Show()
            Case "selClient"
                frm_sel_client.Show()
            Case Else
                frm_caixa.Show()
        End Select
    End Sub
End Class
Imports System.ComponentModel

Public Class frm_newProd

    Dim old, ret As String

    Sub New(e As Boolean, prod As String())

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If e Then
            Me.Text = "Editar produto"
            old = prod(0)
            txt_name.Text = prod(0)
            num_qtd.Value = Decimal.Parse(prod(1))
        Else
            Me.Text = "Novo produto"
        End If


    End Sub
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        If Me.Text.Equals("Editar produto") Then
            Try
                sql.CommandText = "update tb_products set name='" & txt_name.Text & "' where name='" & old & "';"
                sql.Execute()
                sql.CommandText = "update tb_stock set prod_name='" & txt_name.Text & "' qtd='" & num_qtd.Value & "' where prod_name='" & old & "';"
                sql.Execute()
                old = ""
                txt_name.Clear()
                num_qtd.ResetText()
                ret = "stock"
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "erro")
            End Try
        Else
            Try
                sql.CommandText = "insert into tb_products(name) values('" & txt_name.Text & "');"
                sql.Execute()
                sql.CommandText = "insert into tb_stock(prod_name,qtd) values('" & txt_name.Text & "','" & num_qtd.Value.ToString & "');"
                sql.Execute()
                txt_name.Clear()
                num_qtd.ResetText()
                ret = "stock"
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "erro")
            End Try
        End If
    End Sub

    Private Sub bt_cancel_Click(sender As Object, e As EventArgs) Handles bt_cancel.Click
        txt_name.Clear()
        num_qtd.ResetText()
        ret = "stock"
        Me.Close()
    End Sub

    Private Sub frm_newProd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case ret
            Case "stock"
                frm_stock.Show()
            Case Else
                frm_stock.Show()
        End Select
    End Sub
End Class
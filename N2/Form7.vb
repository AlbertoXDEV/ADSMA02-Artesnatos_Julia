Imports System.ComponentModel
Imports System.Data.OleDb

Public Class frm_stock

    Private Sub frm_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usr.Equals("CAIXA") Then
            dtgr_stk.ReadOnly = True
            btn_newProd.Visible = False
        Else
            dtgr_stk.ReadOnly = False
            btn_newProd.Visible = True
        End If
    End Sub
    Private Sub btn_newProd_Click(sender As Object, e As EventArgs) Handles btn_newProd.Click
        Dim frm As New frm_newProd(False, {""})
        frm.Show()
        Me.Hide()
    End Sub
    Private Sub frm_stock_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        get_data("SELECT prod_name,qtd FROM tb_stock;", dtgr_stk)
    End Sub

    Private Sub dtgr_stk_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgr_stk.CellEndEdit

        Try
            sql.CommandText = "update tb_stock set qtd =? where prod_name =? ;"
            prepare("qtd", ADODB.DataTypeEnum.adInteger, 100, dtgr_stk.Rows(e.RowIndex).Cells(1).Value.ToString)
            prepare("prod_name", ADODB.DataTypeEnum.adVarChar, 100, dtgr_stk.Rows(e.RowIndex).Cells(0).Value.ToString)
            sql.Execute()
            sql.Parameters.Delete("qtd")
            sql.Parameters.Delete("prod_name")

            MsgBox("Estoque atualizado", vbOKOnly, "Sucesso")
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "")
        End Try

    End Sub
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Close()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim frm As New frm_newProd(True, {get_cell_content(dtgr_stk, dtgr_stk.SelectedCells(0).RowIndex, 0), get_cell_content(dtgr_stk, dtgr_stk.SelectedCells(0).RowIndex, 1)})
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub frm_stock_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case usr
            Case "GERENCIA"
                frm_mgr.Show()

            Case "CAIXA"
                frm_caixa.Show()
        End Select
    End Sub
    Private Sub dtgr_stk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgr_stk.CellClick
        If usr.Equals("GERENCIA") Then
            btn_edit.Enabled = True
        End If
    End Sub
End Class
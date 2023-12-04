Imports System.ComponentModel

Public Class frm_reports
    Private Sub frm_mgr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data("select req_date,clt_name,prod_name,prod_qtd from tb_sales where is_request=1 and is_finished='0';", dtgr_requests)
        sql.CommandText = "select sum(b.unit_value*a.prod_qtd) from tb_sales as a left join tb_products as b on a.prod_name = b.name where req_date=curdate();"
        rs = sql.Execute()
        lbl_sls.Text = rs.Fields(0).Value.ToString
        sql.CommandText = "select sum(b.unit_value*a.prod_qtd) from tb_sales as a left join tb_products as b on a.prod_name = b.name where month(req_date)=month(curdate());"
        rs = sql.Execute()
        lbl_slsm.Text = rs.Fields(0).Value.ToString
        sql.CommandText = "SELECT  prod_name, COUNT(prod_name) AS `value_occurrence` FROM tb_sales GROUP BY prod_name ORDER BY`value_occurrence` DESC LIMIT 1"
        rs = sql.Execute
        lbl_slstd.Text = rs.Fields(0).Value.ToString
    End Sub
    Private Sub dtgr_requests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgr_requests.CellContentClick
        If dtgr_requests.Columns(e.ColumnIndex).Name.Equals("delete") Then
            Try
                sql.CommandText = "update tb_sales set is_finished='1' where clt_name='" &
                   get_cell_content(dtgr_requests, e.RowIndex, 1) & "' and prod_name='" &
                   get_cell_content(dtgr_requests, e.RowIndex, 2) & "' and prod_qtd='" &
                   get_cell_content(dtgr_requests, e.RowIndex, 3) & "';"
                sql.Execute()
                dtgr_requests.Rows.Remove(dtgr_requests.Rows(e.RowIndex))
                MsgBox("Pedido concluido", vbOKOnly, "Sucesso")
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Erro")
            End Try

        End If
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Close()
    End Sub

    Private Sub frm_reports_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frm_mgr.Show()
    End Sub
End Class
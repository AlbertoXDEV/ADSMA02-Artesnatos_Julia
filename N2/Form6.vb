Imports System.ComponentModel

Public Class frm_acct
    Private Sub frm_acct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data("select a.prod_name,b.unit_value,a.prod_qtd,(b.unit_value*a.prod_qtd) as total,a.is_request from tb_sales as a" &
                 " left join tb_products as b on a.prod_name=b.name where req_date= curdate();", dtgr_acc)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
    End Sub

    Private Sub frm_acct_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        usr = ""
        frm_login.Show()
    End Sub
End Class
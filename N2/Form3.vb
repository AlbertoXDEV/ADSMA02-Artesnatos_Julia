Imports System.ComponentModel

Public Class frm_sales
    Dim prod As String = ""

    Sub New(cl As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        lbl_client.Text = cl

    End Sub
    Private Sub frm_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data("SELECT name FROM tb_products;", dtrg_stock)
    End Sub

    Private Sub btn_add_prod_Click(sender As Object, e As EventArgs) Handles btn_add_prod.Click
        If Not prod.Equals("") Then
            If (num_qtd.Value < 1000) And (num_qtd.Value > 0) Then

                If Not dtrg_checkout.Rows.Count.Equals(0) Then
                    For i = 0 To (dtrg_checkout.Rows.Count - 1)
                        If Not prod.Equals(get_cell_content(dtrg_checkout, i, 0)) Then
                            dtrg_checkout.Rows.Add(prod, num_qtd.Value.ToString)
                            lbl_qtd.Visible = False
                            num_qtd.Value = 0
                            num_qtd.Visible = False
                            btn_add_prod.Visible = False
                        Else
                            MsgBox("Produto " & prod & " já listado." & vbNewLine & "Para alterar a quantidade, remova o produto listado e adicione-o novamente", vbOKOnly, "Erro: duplicata")
                        End If
                    Next
                Else
                    dtrg_checkout.Rows.Add(prod, num_qtd.Value.ToString)
                    lbl_qtd.Visible = False
                    num_qtd.Visible = False
                    btn_add_prod.Visible = False
                    prod = ""
                End If

            Else
                num_qtd.Value = 0

                MsgBox("Quantidade fora do esperado", vbOKOnly, "Erro")
            End If
        End If
    End Sub

    Private Sub dtrg_stock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtrg_stock.CellContentClick
        If Not e.RowIndex.Equals(-1) Then
            If dtrg_stock.Columns(e.ColumnIndex).Name.Equals("Adicionar") Then
                prod = dtrg_stock.Rows(e.RowIndex).Cells(1).Value
                lbl_qtd.Visible = True
                num_qtd.Visible = True
                btn_add_prod.Visible = True
            End If
        End If
    End Sub

    Private Sub dtrg_checkout_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtrg_checkout.CellContentClick
        If Not e.RowIndex.Equals(-1) Then
            If dtrg_checkout.Columns(e.ColumnIndex).Name.Equals("delete") Then
                dtrg_checkout.Rows.Remove(dtrg_checkout.Rows(e.RowIndex))
                lbl_qtd.Visible = False
                num_qtd.Visible = False
                btn_add_prod.Visible = False
                prod = ""
            End If
        End If
    End Sub

    Private Sub btn_sell_Click(sender As Object, e As EventArgs) Handles btn_sell.Click
        Dim can = Enumerable.Repeat(Of Boolean)(True, dtrg_checkout.Rows.Count).ToArray()
        Dim stock = Enumerable.Repeat(Of Integer)(0, dtrg_checkout.Rows.Count).ToArray()
        Dim prods = Enumerable.Repeat(Of String)("", dtrg_checkout.Rows.Count).ToArray()

        For i = 0 To (dtrg_checkout.Rows.Count - 1)
            prods(i) = get_cell_content(dtrg_checkout, i, 0)
            sql.CommandText = "select qtd from tb_stock where prod_name='" & prods(i) & "';"
            rs = sql.Execute()
            If Integer.Parse(rs.Fields(0).Value.ToString) < Integer.Parse(get_cell_content(dtrg_checkout, i, 1)) Then
                can(i) = False
            Else
                can(i) = True
                stock(i) = Integer.Parse(rs.Fields(0).Value)
            End If

        Next

        If Not dtrg_checkout.Rows.Count.Equals(0) Then
            sql.CommandText = "START TRANSACTION;"
            sql.Execute()
            Try
                For i = 0 To (dtrg_checkout.Rows.Count - 1)
                    If can(i) Then
                        sql.CommandText = "insert into tb_sales(clt_name,prod_name,prod_qtd,req_date) values('" & lbl_client.Text &
                        "','" & prods(i) & "','" &
                        dtrg_checkout.Rows(i).Cells(1).Value.ToString & "',curdate());"
                        sql.Execute()

                        sql.CommandText = "update tb_stock set qtd='" & (stock(i) - dtrg_checkout.Rows(i).Cells(1).Value).ToString &
                            "' where prod_name='" & dtrg_checkout.Rows(i).Cells(0).Value.ToString & "';"
                        sql.Execute()

                    ElseIf vbYes = MsgBox("Produto " & dtrg_checkout.Rows(i).Cells(0).Value.ToString &
                                          " não esta disponinvel em estoque" &
                                          vbNewLine & "Criar um pedido para entregar?", vbYesNo, "Estoque insuficiente") Then
                        sql.CommandText = "insert into tb_sales(clt_name,prod_name,prod_qtd,req_date,is_request,is_finished) values('" &
                        lbl_client.Text & "','" &
                        dtrg_checkout.Rows(i).Cells(0).Value & "','" & dtrg_checkout.Rows(i).Cells(1).Value & "',curdate(),'1','0');"

                        sql.Execute()
                    Else
                        MsgBox("Venda de " & dtrg_checkout.Rows(i).Cells(0).Value.ToString & " não registrada", vbOKOnly, "Cancelado")
                    End If

                Next
                sql.CommandText = "COMMIT;"
                sql.Execute()
                MsgBox("Venda registrada", vbOKOnly, "Sucesso")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "erro")
                sql.CommandText = "ROLLBACK;"
                sql.Execute()
            End Try
        End If
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Close()
    End Sub

    Private Sub frm_sales_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frm_caixa.Show()
    End Sub
End Class
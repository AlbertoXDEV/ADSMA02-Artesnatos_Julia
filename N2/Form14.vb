Imports System.ComponentModel

Public Class frm_client_list

    Dim f As Form
    Dim ret As String
    Private Sub frm_client_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data("select name from tb_clients", dtgr_clients)
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        sql = "select CEP from tb_clients where name ='" & dtgr_clients.SelectedRows(0).Cells(1).Value & "';"
        rs = sql.Execute()
        f = New frm_edit_client(dtgr_clients.SelectedRows(0).Cells(1).Value, rs.Fields(0).Value.ToString)
        ret = "edit"
    End Sub
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        ret = "mgr"
        Me.Close()
    End Sub

    Private Sub dtgr_clients_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgr_clients.CellClick
        If dtgr_clients.Columns(e.ColumnIndex).Name.Equals("delete") Then
            Try
                If vbYes = MsgBox("Tem certeza que quer excluir o cliente. Essa ação é irreversivel.", vbYesNo, "Excluir cliente") Then
                    sql.CommandText = "delete from tb_clients where name = '" & get_cell_content(dtgr_clients, e.RowIndex, 1) & "';"
                    sql.Prepared = True
                    sql.Execute()
                    dtgr_clients.Rows.RemoveAt(e.RowIndex)
                    MsgBox("Cliente excluido", vbOKOnly, "Sucesso")
                    btn_edit.Enabled = False
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Erro")
            End Try

        Else
            btn_edit.Visible = True
        End If
    End Sub

    Private Sub frm_client_list_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case ret
            Case "edit"
                f.Show()
            Case Else
                frm_mgr.Show()
        End Select
    End Sub
End Class
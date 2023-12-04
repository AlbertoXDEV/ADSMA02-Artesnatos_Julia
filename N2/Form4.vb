Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class frm_new_worker

    Dim ret As String
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        If Not txt_name.Text.Equals(Nothing) And Not cmb_occ.SelectedItem.Equals(Nothing) And
            Not txt_password.Text.Equals(Nothing) And Not txt_password2.Text.Equals(Nothing) Then
            Try
                sql.CommandText = "START TRANSACTION"
                sql.Execute()

                sql.CommandText = "insert into tb_workers(name,occupation,entry,on_leave,active) values(?,?,curdate(),0,1)"
                prepare("name", ADODB.DataTypeEnum.adVarChar, 100, txt_name.Text)
                prepare("occupation", ADODB.DataTypeEnum.adVarChar, 10, cmb_occ.SelectedItem.ToString)
                sql.Execute()
                sql.Parameters.Delete("name")
                sql.Parameters.Delete("occupation")

                Dim salt = Generate()
                Dim pass = txt_password.Text & salt
                sql.CommandText = "insert into tb_pss(wrk_name,psswd,salt) values(?,sha2('" & pass & "',224), '" & salt & "');"
                prepare("name", ADODB.DataTypeEnum.adVarChar, 100, txt_name.Text)

                sql.Execute()
                sql.Parameters.Delete("name")

                sql.CommandText = "COMMIT"
                sql.Execute()


                MsgBox("Novo funcionario cadastrado", vbOKOnly, "Sucesso")
                ret = "workers"
                Me.Close()
            Catch ex As Exception

                sql.CommandText = "ROLLBACK"
                sql.Execute()
                MsgBox(ex.Message, vbOKOnly, "Erro")
                ret = "workers"
                Me.Close()
            End Try
        End If
    End Sub
    Private Sub txt_password2_LostFocus(sender As Object, e As EventArgs) Handles txt_password2.LostFocus

        If Not txt_password.Text.Equals(Nothing) Then

            If Not txt_password.Text.Equals(txt_password2.Text) Then
                    MsgBox("As senhas informadas não coincidem", vbOKOnly, "Verificar senhas")
                    txt_password.Focus()
                    lbl_pass.ForeColor = Color.Red
                    lbl_pass2.ForeColor = Color.Red
                ElseIf lbl_pass.ForeColor.Equals(Color.Red) Then
                    lbl_pass.ForeColor = Color.Black
                    lbl_pass2.ForeColor = Color.Black
                End If

        End If
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        ret = "workers"
        Me.Close()
    End Sub

    Private Sub frm_new_worker_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case ret
            Case "workers"
                frm_workers.Show()
            Case Else
                frm_workers.Show()
        End Select
    End Sub

    Private Sub txt_password_LostFocus(sender As Object, e As EventArgs) Handles txt_password.LostFocus
        Dim fo As String = "^[a-zA-Z0-9 ]*$"
        Dim r As New Regex(fo)
        If Not r.IsMatch(txt_password.Text) Then
            MsgBox("A senha não pode conter caracters como ' e ;")
            txt_password.Focus()
        End If
    End Sub
End Class
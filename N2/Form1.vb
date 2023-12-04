Imports System.Data.SqlClient

Public Class frm_login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Application.ApplicationExit, AddressOf clean_up
        If Not conUp Then
            db_connect()
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_passwd.Text <> "" And txt_usr.Text <> "" Then
            Try
                sql.CommandText = "select occupation from tb_workers as a inner join tb_pss as b on a.name = b.wrk_name where a.name = ? and b.psswd = sha2(concat(?, b.salt),224);"
                prepare("name", ADODB.DataTypeEnum.adVarChar, 128, txt_usr.Text)
                prepare("psswd", ADODB.DataTypeEnum.adVarChar, 128, txt_passwd.Text)
                rs = sql.Execute()
                sql.Parameters.Delete("name")
                sql.Parameters.Delete("psswd")

                If Not rs.EOF Then
                    usr = rs.GetString.Replace(vbCr, String.Empty).Replace("&", String.Empty)
                    lbl_login.Visible = False
                    Select Case usr
                        Case "GERENCIA"
                            Me.Hide()
                            frm_mgr.Show()
                        Case "CAIXA"
                            frm_caixa.Show()
                            Me.Hide()
                        Case "CONTADOR"
                            frm_acct.Show()
                            Me.Hide()
                        Case Else
                            MsgBox("Dados de login mau formatados." + vbNewLine + "Contate a gerência ou o adminstrador do sistema", vbOKOnly, "Erro 2")
                            usr = ""
                    End Select
                Else
                    lbl_login.Visible = True
                    txt_usr.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message + vbNewLine + "Banco de dados não responsivo." + vbNewLine + "Contate a gerência ou o adminstrador do sistema se o problema persistir", vbOKOnly, "Erro 1")
            End Try
            txt_passwd.Text = ""
            txt_usr.Text = ""
        Else
            MsgBox("Por favor preencha todos os campos", vbOKOnly, "Campos vazios")
        End If
    End Sub
End Class

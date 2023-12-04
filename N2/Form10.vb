Public Class frm_wrk_edit

    Dim old As String
    Public Sub New(name, occu, leave)
        InitializeComponent()
        old = name.ToString
        txt_name.Text = old
        If leave = 1 Then
            chk_leave.Checked = True
        End If
        Select Case occu
            Case "GERENCIA"
                cmb_occupation.SelectedIndex = 0
            Case "CAIXA"
                cmb_occupation.SelectedIndex = 1
            Case "CONTADOR"
                cmb_occupation.SelectedIndex = 2
        End Select
    End Sub
    Private Sub frm_wrk_edit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frm_workers.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As Integer
        If chk_leave.Checked Then
            b = 1
        Else
            b = 0
        End If
        Try
            sql.CommandText = "update tb_workers set name =? ,on_leave =? , occupation=? where name = '" & old & "';"
            prepare("name", ADODB.DataTypeEnum.adVarChar, 100, txt_name.Text)
            prepare("on_leave", ADODB.DataTypeEnum.adInteger, 2, b.ToString)
            prepare("occupation", ADODB.DataTypeEnum.adVarChar, 10, cmb_occupation.SelectedItem.ToString)
            sql.Execute()
            MsgBox("Dados alterados", vbOKOnly, "sucessp")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Erro")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
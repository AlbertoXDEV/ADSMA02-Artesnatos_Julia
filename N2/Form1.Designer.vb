<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_passwd = New System.Windows.Forms.MaskedTextBox()
        Me.txt_usr = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_login)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_passwd)
        Me.Panel1.Controls.Add(Me.txt_usr)
        Me.Panel1.Location = New System.Drawing.Point(78, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 264)
        Me.Panel1.TabIndex = 0
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.ForeColor = System.Drawing.Color.Red
        Me.lbl_login.Location = New System.Drawing.Point(40, 170)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(179, 26)
        Me.lbl_login.TabIndex = 5
        Me.lbl_login.Text = "Nome ou senha inválidos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Contate a gerência se isso continuar"
        Me.lbl_login.Visible = False
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(80, 210)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(91, 27)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Entrar"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Text", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Senha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Text", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome"
        '
        'txt_passwd
        '
        Me.txt_passwd.Location = New System.Drawing.Point(33, 134)
        Me.txt_passwd.Name = "txt_passwd"
        Me.txt_passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_passwd.Size = New System.Drawing.Size(186, 20)
        Me.txt_passwd.TabIndex = 1
        '
        'txt_usr
        '
        Me.txt_usr.Location = New System.Drawing.Point(33, 62)
        Me.txt_usr.Name = "txt_usr"
        Me.txt_usr.Size = New System.Drawing.Size(186, 20)
        Me.txt_usr.TabIndex = 0
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 341)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_passwd As MaskedTextBox
    Friend WithEvents txt_usr As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_login As Label
End Class

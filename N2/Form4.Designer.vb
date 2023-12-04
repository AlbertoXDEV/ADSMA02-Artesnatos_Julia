<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_new_worker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cmb_occ = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_password2 = New System.Windows.Forms.TextBox()
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.lbl_pass2 = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(52, 45)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(469, 20)
        Me.txt_name.TabIndex = 0
        '
        'cmb_occ
        '
        Me.cmb_occ.FormattingEnabled = True
        Me.cmb_occ.Items.AddRange(New Object() {"GERENCIA", "CAIXA", "CONTADOR"})
        Me.cmb_occ.Location = New System.Drawing.Point(52, 99)
        Me.cmb_occ.Name = "cmb_occ"
        Me.cmb_occ.Size = New System.Drawing.Size(197, 21)
        Me.cmb_occ.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cargo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome"
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(316, 216)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(160, 31)
        Me.btn_new.TabIndex = 4
        Me.btn_new.Text = "Cadastrar"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.SystemColors.Window
        Me.txt_password.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_password.Location = New System.Drawing.Point(314, 100)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(205, 20)
        Me.txt_password.TabIndex = 5
        '
        'txt_password2
        '
        Me.txt_password2.Location = New System.Drawing.Point(316, 163)
        Me.txt_password2.Name = "txt_password2"
        Me.txt_password2.Size = New System.Drawing.Size(203, 20)
        Me.txt_password2.TabIndex = 6
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Location = New System.Drawing.Point(313, 80)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(90, 13)
        Me.lbl_pass.TabIndex = 7
        Me.lbl_pass.Text = "Senha temporaria"
        '
        'lbl_pass2
        '
        Me.lbl_pass2.AutoSize = True
        Me.lbl_pass2.Location = New System.Drawing.Point(313, 137)
        Me.lbl_pass2.Name = "lbl_pass2"
        Me.lbl_pass2.Size = New System.Drawing.Size(83, 13)
        Me.lbl_pass2.TabIndex = 8
        Me.lbl_pass2.Text = "Confirmar senha"
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.LightCoral
        Me.btn_return.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(84, 214)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(175, 33)
        Me.btn_return.TabIndex = 13
        Me.btn_return.Text = "Voltar"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'frm_new_worker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(599, 286)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_pass2)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.txt_password2)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_occ)
        Me.Controls.Add(Me.txt_name)
        Me.DoubleBuffered = True
        Me.Name = "frm_new_worker"
        Me.Text = "Novo funcionario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_name As TextBox
    Friend WithEvents cmb_occ As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_new As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_password2 As TextBox
    Friend WithEvents lbl_pass As Label
    Friend WithEvents lbl_pass2 As Label
    Friend WithEvents btn_return As Button
End Class

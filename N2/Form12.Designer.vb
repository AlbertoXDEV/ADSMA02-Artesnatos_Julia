<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_newClient))
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(61, 69)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(504, 20)
        Me.txt_name.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome"
        '
        'txt_cep
        '
        Me.txt_cep.Location = New System.Drawing.Point(62, 137)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(175, 20)
        Me.txt_cep.TabIndex = 2
        Me.txt_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CEP"
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.SpringGreen
        Me.btn_new.Location = New System.Drawing.Point(109, 205)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(166, 34)
        Me.btn_new.TabIndex = 4
        Me.btn_new.Text = "Cadastrar cliente"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.LightCoral
        Me.btn_return.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(345, 205)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(175, 34)
        Me.btn_return.TabIndex = 6
        Me.btn_return.Text = "Voltar"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'frm_newClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(629, 273)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_name)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_newClient"
        Me.Text = "Novo cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_return As Button
End Class

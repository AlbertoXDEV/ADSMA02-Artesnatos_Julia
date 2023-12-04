<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_wrk_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_wrk_edit))
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.cmb_occupation = New System.Windows.Forms.ComboBox()
        Me.chk_leave = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(74, 69)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(537, 20)
        Me.txt_name.TabIndex = 0
        '
        'cmb_occupation
        '
        Me.cmb_occupation.FormattingEnabled = True
        Me.cmb_occupation.Items.AddRange(New Object() {"GERENCIA", "CAIXA", "CONTADOR"})
        Me.cmb_occupation.Location = New System.Drawing.Point(74, 132)
        Me.cmb_occupation.Name = "cmb_occupation"
        Me.cmb_occupation.Size = New System.Drawing.Size(253, 21)
        Me.cmb_occupation.TabIndex = 1
        '
        'chk_leave
        '
        Me.chk_leave.AutoSize = True
        Me.chk_leave.Location = New System.Drawing.Point(450, 136)
        Me.chk_leave.Name = "chk_leave"
        Me.chk_leave.Size = New System.Drawing.Size(71, 17)
        Me.chk_leave.TabIndex = 3
        Me.chk_leave.Text = "De Férias"
        Me.chk_leave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cargo"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(388, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(117, 198)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frm_wrk_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(645, 268)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_leave)
        Me.Controls.Add(Me.cmb_occupation)
        Me.Controls.Add(Me.txt_name)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_wrk_edit"
        Me.Text = "Editar funcionario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_name As TextBox
    Friend WithEvents cmb_occupation As ComboBox
    Friend WithEvents chk_leave As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

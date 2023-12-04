<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_newProd))
        Me.btn_create = New System.Windows.Forms.Button()
        Me.bt_cancel = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.num_qtd = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.num_qtd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_create.Location = New System.Drawing.Point(250, 187)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(124, 43)
        Me.btn_create.TabIndex = 0
        Me.btn_create.Text = "Confirmar"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.Color.Red
        Me.bt_cancel.Location = New System.Drawing.Point(84, 187)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.Size = New System.Drawing.Size(128, 43)
        Me.bt_cancel.TabIndex = 1
        Me.bt_cancel.Text = "Cancelar"
        Me.bt_cancel.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(54, 43)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(361, 20)
        Me.txt_name.TabIndex = 2
        '
        'num_qtd
        '
        Me.num_qtd.Location = New System.Drawing.Point(54, 115)
        Me.num_qtd.Name = "num_qtd"
        Me.num_qtd.Size = New System.Drawing.Size(104, 20)
        Me.num_qtd.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome do produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Quantidade"
        '
        'frm_newProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(455, 266)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.num_qtd)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.btn_create)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_newProd"
        Me.Text = "Novo produto"
        CType(Me.num_qtd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_create As Button
    Friend WithEvents bt_cancel As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents num_qtd As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

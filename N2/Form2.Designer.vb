<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_caixa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_caixa))
        Me.btn_newSale = New System.Windows.Forms.Button()
        Me.btn_newClient = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_newSale
        '
        Me.btn_newSale.Location = New System.Drawing.Point(76, 105)
        Me.btn_newSale.Name = "btn_newSale"
        Me.btn_newSale.Size = New System.Drawing.Size(160, 48)
        Me.btn_newSale.TabIndex = 0
        Me.btn_newSale.Text = "Nova venda"
        Me.btn_newSale.UseVisualStyleBackColor = True
        '
        'btn_newClient
        '
        Me.btn_newClient.Location = New System.Drawing.Point(76, 178)
        Me.btn_newClient.Name = "btn_newClient"
        Me.btn_newClient.Size = New System.Drawing.Size(159, 50)
        Me.btn_newClient.TabIndex = 1
        Me.btn_newClient.Text = "Cadastrar cliente"
        Me.btn_newClient.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(106, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Sair"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_caixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(312, 392)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_newClient)
        Me.Controls.Add(Me.btn_newSale)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_caixa"
        Me.Text = "Controle de caixa"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_newSale As Button
    Friend WithEvents btn_newClient As Button
    Friend WithEvents Button3 As Button
End Class

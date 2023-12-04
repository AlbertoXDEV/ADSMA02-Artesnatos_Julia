<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_acct
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_acct))
        Me.dtgr_acc = New System.Windows.Forms.DataGridView()
        Me.prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.request = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtgr_acc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgr_acc
        '
        Me.dtgr_acc.AllowUserToAddRows = False
        Me.dtgr_acc.AllowUserToDeleteRows = False
        Me.dtgr_acc.AllowUserToOrderColumns = True
        Me.dtgr_acc.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dtgr_acc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgr_acc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod, Me.value, Me.qtd, Me.total, Me.request})
        Me.dtgr_acc.Location = New System.Drawing.Point(54, 55)
        Me.dtgr_acc.Margin = New System.Windows.Forms.Padding(2)
        Me.dtgr_acc.Name = "dtgr_acc"
        Me.dtgr_acc.RowHeadersVisible = False
        Me.dtgr_acc.RowHeadersWidth = 62
        Me.dtgr_acc.RowTemplate.Height = 28
        Me.dtgr_acc.Size = New System.Drawing.Size(683, 250)
        Me.dtgr_acc.TabIndex = 0
        '
        'prod
        '
        Me.prod.DataPropertyName = "prod_name"
        Me.prod.HeaderText = "Produto"
        Me.prod.Name = "prod"
        Me.prod.ReadOnly = True
        Me.prod.Width = 280
        '
        'value
        '
        Me.value.DataPropertyName = "unit_value"
        Me.value.HeaderText = "Valor unitário"
        Me.value.Name = "value"
        Me.value.ReadOnly = True
        '
        'qtd
        '
        Me.qtd.DataPropertyName = "prod_qtd"
        Me.qtd.HeaderText = "Quantidade"
        Me.qtd.Name = "qtd"
        Me.qtd.ReadOnly = True
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'request
        '
        Me.request.DataPropertyName = "is_request"
        Me.request.HeaderText = "Encomenda"
        Me.request.Name = "request"
        Me.request.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(300, 320)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_acct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 378)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtgr_acc)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_acct"
        Me.Text = "Livro contábil"
        CType(Me.dtgr_acc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgr_acc As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents prod As DataGridViewTextBoxColumn
    Friend WithEvents value As DataGridViewTextBoxColumn
    Friend WithEvents qtd As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents request As DataGridViewCheckBoxColumn
End Class

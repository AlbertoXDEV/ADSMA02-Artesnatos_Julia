<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stock))
        Me.dtgr_stk = New System.Windows.Forms.DataGridView()
        Me.prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_newProd = New System.Windows.Forms.Button()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.dtgr_stk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgr_stk
        '
        Me.dtgr_stk.AllowUserToAddRows = False
        Me.dtgr_stk.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dtgr_stk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgr_stk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgr_stk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prod, Me.qtd})
        Me.dtgr_stk.Location = New System.Drawing.Point(93, 46)
        Me.dtgr_stk.Margin = New System.Windows.Forms.Padding(2)
        Me.dtgr_stk.Name = "dtgr_stk"
        Me.dtgr_stk.RowHeadersVisible = False
        Me.dtgr_stk.RowHeadersWidth = 62
        Me.dtgr_stk.RowTemplate.Height = 28
        Me.dtgr_stk.Size = New System.Drawing.Size(436, 184)
        Me.dtgr_stk.TabIndex = 0
        '
        'prod
        '
        Me.prod.DataPropertyName = "prod_name"
        Me.prod.HeaderText = "Produto"
        Me.prod.MinimumWidth = 8
        Me.prod.Name = "prod"
        Me.prod.ReadOnly = True
        Me.prod.Width = 347
        '
        'qtd
        '
        Me.qtd.DataPropertyName = "qtd"
        Me.qtd.HeaderText = "Quantidade"
        Me.qtd.MinimumWidth = 8
        Me.qtd.Name = "qtd"
        Me.qtd.Width = 85
        '
        'btn_edit
        '
        Me.btn_edit.Enabled = False
        Me.btn_edit.Location = New System.Drawing.Point(93, 274)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(141, 35)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.Text = "Editar selecionado"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_newProd
        '
        Me.btn_newProd.Location = New System.Drawing.Point(251, 274)
        Me.btn_newProd.Name = "btn_newProd"
        Me.btn_newProd.Size = New System.Drawing.Size(130, 35)
        Me.btn_newProd.TabIndex = 3
        Me.btn_newProd.Text = "Novo Produto"
        Me.btn_newProd.UseVisualStyleBackColor = True
        Me.btn_newProd.Visible = False
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_info.ForeColor = System.Drawing.Color.White
        Me.lbl_info.Location = New System.Drawing.Point(90, 241)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(451, 13)
        Me.lbl_info.TabIndex = 4
        Me.lbl_info.Text = "Clique duas vezes na célula para editar a quantidade ou use o botão abaixo para m" &
    "ais opções"
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.LightCoral
        Me.btn_return.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(398, 274)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(131, 35)
        Me.btn_return.TabIndex = 10
        Me.btn_return.Text = "Voltar"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'frm_stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(624, 358)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.btn_newProd)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.dtgr_stk)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_stock"
        Me.Text = "Estoque"
        CType(Me.dtgr_stk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgr_stk As DataGridView
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_newProd As Button
    Friend WithEvents lbl_info As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents prod As DataGridViewTextBoxColumn
    Friend WithEvents qtd As DataGridViewTextBoxColumn
End Class

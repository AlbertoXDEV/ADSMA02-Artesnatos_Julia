<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales))
        Me.lbl_qtd = New System.Windows.Forms.Label()
        Me.btn_add_prod = New System.Windows.Forms.Button()
        Me.dtrg_stock = New System.Windows.Forms.DataGridView()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adicionar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.num_qtd = New System.Windows.Forms.NumericUpDown()
        Me.dtrg_checkout = New System.Windows.Forms.DataGridView()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btn_sell = New System.Windows.Forms.Button()
        Me.lbl_client = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.dtrg_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_qtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtrg_checkout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_qtd
        '
        Me.lbl_qtd.AutoSize = True
        Me.lbl_qtd.Location = New System.Drawing.Point(477, 69)
        Me.lbl_qtd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_qtd.Name = "lbl_qtd"
        Me.lbl_qtd.Size = New System.Drawing.Size(62, 13)
        Me.lbl_qtd.TabIndex = 1
        Me.lbl_qtd.Text = "Quantidade"
        Me.lbl_qtd.Visible = False
        '
        'btn_add_prod
        '
        Me.btn_add_prod.Location = New System.Drawing.Point(727, 67)
        Me.btn_add_prod.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_add_prod.Name = "btn_add_prod"
        Me.btn_add_prod.Size = New System.Drawing.Size(70, 21)
        Me.btn_add_prod.TabIndex = 2
        Me.btn_add_prod.Text = "Adicionar"
        Me.btn_add_prod.UseVisualStyleBackColor = True
        Me.btn_add_prod.Visible = False
        '
        'dtrg_stock
        '
        Me.dtrg_stock.AllowUserToAddRows = False
        Me.dtrg_stock.AllowUserToDeleteRows = False
        Me.dtrg_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtrg_stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Produto, Me.Adicionar})
        Me.dtrg_stock.Location = New System.Drawing.Point(12, 12)
        Me.dtrg_stock.Name = "dtrg_stock"
        Me.dtrg_stock.RowHeadersVisible = False
        Me.dtrg_stock.RowHeadersWidth = 62
        Me.dtrg_stock.Size = New System.Drawing.Size(444, 285)
        Me.dtrg_stock.TabIndex = 4
        '
        'Produto
        '
        Me.Produto.DataPropertyName = "name"
        Me.Produto.HeaderText = "Produto"
        Me.Produto.MinimumWidth = 8
        Me.Produto.Name = "Produto"
        Me.Produto.ReadOnly = True
        Me.Produto.Width = 340
        '
        'Adicionar
        '
        Me.Adicionar.HeaderText = "Selecionar"
        Me.Adicionar.MinimumWidth = 8
        Me.Adicionar.Name = "Adicionar"
        Me.Adicionar.ReadOnly = True
        '
        'num_qtd
        '
        Me.num_qtd.Location = New System.Drawing.Point(612, 67)
        Me.num_qtd.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.num_qtd.Name = "num_qtd"
        Me.num_qtd.Size = New System.Drawing.Size(97, 20)
        Me.num_qtd.TabIndex = 5
        Me.num_qtd.Visible = False
        '
        'dtrg_checkout
        '
        Me.dtrg_checkout.AllowUserToAddRows = False
        Me.dtrg_checkout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtrg_checkout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product, Me.qtd, Me.delete})
        Me.dtrg_checkout.Location = New System.Drawing.Point(479, 96)
        Me.dtrg_checkout.Name = "dtrg_checkout"
        Me.dtrg_checkout.ReadOnly = True
        Me.dtrg_checkout.RowHeadersVisible = False
        Me.dtrg_checkout.RowHeadersWidth = 62
        Me.dtrg_checkout.Size = New System.Drawing.Size(325, 201)
        Me.dtrg_checkout.TabIndex = 6
        '
        'product
        '
        Me.product.HeaderText = "Produto"
        Me.product.MinimumWidth = 8
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        Me.product.Width = 170
        '
        'qtd
        '
        Me.qtd.HeaderText = "Quantidade"
        Me.qtd.MinimumWidth = 8
        Me.qtd.Name = "qtd"
        Me.qtd.ReadOnly = True
        Me.qtd.Width = 75
        '
        'delete
        '
        Me.delete.HeaderText = "Retirar"
        Me.delete.MinimumWidth = 8
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.UseColumnTextForButtonValue = True
        Me.delete.Width = 75
        '
        'btn_sell
        '
        Me.btn_sell.Location = New System.Drawing.Point(479, 303)
        Me.btn_sell.Name = "btn_sell"
        Me.btn_sell.Size = New System.Drawing.Size(326, 40)
        Me.btn_sell.TabIndex = 7
        Me.btn_sell.Text = "Confirmar"
        Me.btn_sell.UseVisualStyleBackColor = True
        '
        'lbl_client
        '
        Me.lbl_client.AutoSize = True
        Me.lbl_client.Location = New System.Drawing.Point(65, 13)
        Me.lbl_client.Name = "lbl_client"
        Me.lbl_client.Size = New System.Drawing.Size(39, 13)
        Me.lbl_client.TabIndex = 8
        Me.lbl_client.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_client)
        Me.Panel1.Location = New System.Drawing.Point(480, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 37)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cliente:"
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.LightCoral
        Me.btn_return.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(154, 310)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(131, 33)
        Me.btn_return.TabIndex = 13
        Me.btn_return.Text = "Voltar"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'frm_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background2
        Me.ClientSize = New System.Drawing.Size(817, 372)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_sell)
        Me.Controls.Add(Me.dtrg_checkout)
        Me.Controls.Add(Me.num_qtd)
        Me.Controls.Add(Me.dtrg_stock)
        Me.Controls.Add(Me.btn_add_prod)
        Me.Controls.Add(Me.lbl_qtd)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales"
        Me.Text = "Vendas"
        CType(Me.dtrg_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_qtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtrg_checkout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_qtd As Label
    Friend WithEvents btn_add_prod As Button
    Friend WithEvents dtrg_stock As DataGridView
    Friend WithEvents num_qtd As NumericUpDown
    Friend WithEvents dtrg_checkout As DataGridView
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents qtd As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewButtonColumn
    Friend WithEvents btn_sell As Button
    Friend WithEvents lbl_client As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents Adicionar As DataGridViewButtonColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reports))
        Me.dtgr_requests = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_slstd = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_slsm = New System.Windows.Forms.Label()
        Me.lbl_sls = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dtgr_requests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgr_requests
        '
        Me.dtgr_requests.AllowUserToAddRows = False
        Me.dtgr_requests.AllowUserToDeleteRows = False
        Me.dtgr_requests.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dtgr_requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgr_requests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dt, Me.clt, Me.prod, Me.qtd, Me.delete})
        Me.dtgr_requests.Location = New System.Drawing.Point(37, 67)
        Me.dtgr_requests.Margin = New System.Windows.Forms.Padding(2)
        Me.dtgr_requests.Name = "dtgr_requests"
        Me.dtgr_requests.RowHeadersVisible = False
        Me.dtgr_requests.RowHeadersWidth = 62
        Me.dtgr_requests.RowTemplate.Height = 28
        Me.dtgr_requests.Size = New System.Drawing.Size(528, 264)
        Me.dtgr_requests.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pedidos a realizar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(605, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total vendido hoje"
        '
        'lbl_slstd
        '
        Me.lbl_slstd.AutoSize = True
        Me.lbl_slstd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_slstd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_slstd.Location = New System.Drawing.Point(605, 274)
        Me.lbl_slstd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_slstd.Name = "lbl_slstd"
        Me.lbl_slstd.Size = New System.Drawing.Size(0, 17)
        Me.lbl_slstd.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(605, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total vendido mensal"
        '
        'lbl_slsm
        '
        Me.lbl_slsm.AutoSize = True
        Me.lbl_slsm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_slsm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_slsm.Location = New System.Drawing.Point(605, 191)
        Me.lbl_slsm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_slsm.Name = "lbl_slsm"
        Me.lbl_slsm.Size = New System.Drawing.Size(0, 17)
        Me.lbl_slsm.TabIndex = 5
        '
        'lbl_sls
        '
        Me.lbl_sls.AutoSize = True
        Me.lbl_sls.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_sls.Location = New System.Drawing.Point(605, 110)
        Me.lbl_sls.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_sls.Name = "lbl_sls"
        Me.lbl_sls.Size = New System.Drawing.Size(0, 17)
        Me.lbl_sls.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(605, 232)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Produto mais vendido"
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.LightCoral
        Me.btn_return.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(638, 339)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(131, 55)
        Me.btn_return.TabIndex = 9
        Me.btn_return.Text = "Voltar"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'dt
        '
        Me.dt.DataPropertyName = "req_date"
        Me.dt.HeaderText = "Data do pedido"
        Me.dt.Name = "dt"
        Me.dt.ReadOnly = True
        '
        'clt
        '
        Me.clt.DataPropertyName = "clt_name"
        Me.clt.HeaderText = "Cliente"
        Me.clt.Name = "clt"
        Me.clt.ReadOnly = True
        '
        'prod
        '
        Me.prod.DataPropertyName = "prod_name"
        Me.prod.HeaderText = "Produto"
        Me.prod.Name = "prod"
        Me.prod.ReadOnly = True
        Me.prod.Width = 200
        '
        'qtd
        '
        Me.qtd.DataPropertyName = "prod_qtd"
        Me.qtd.HeaderText = "Quantidade"
        Me.qtd.Name = "qtd"
        Me.qtd.ReadOnly = True
        Me.qtd.Width = 75
        '
        'delete
        '
        Me.delete.HeaderText = "Concluir"
        Me.delete.Image = Global.N2.My.Resources.Resources.check_mark
        Me.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.delete.Name = "delete"
        Me.delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.delete.Width = 50
        '
        'frm_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background2
        Me.ClientSize = New System.Drawing.Size(826, 417)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_sls)
        Me.Controls.Add(Me.lbl_slsm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_slstd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgr_requests)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_reports"
        Me.Text = "Gerênciador empresarial"
        CType(Me.dtgr_requests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgr_requests As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_slstd As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_slsm As Label
    Friend WithEvents lbl_sls As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents dt As DataGridViewTextBoxColumn
    Friend WithEvents clt As DataGridViewTextBoxColumn
    Friend WithEvents prod As DataGridViewTextBoxColumn
    Friend WithEvents qtd As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewImageColumn
End Class

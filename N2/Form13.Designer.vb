<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sel_client
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sel_client))
        Me.dtrg_clients = New System.Windows.Forms.DataGridView()
        Me.client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.dtrg_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtrg_clients
        '
        Me.dtrg_clients.AllowUserToAddRows = False
        Me.dtrg_clients.AllowUserToDeleteRows = False
        Me.dtrg_clients.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dtrg_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtrg_clients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.client, Me.btn})
        Me.dtrg_clients.Location = New System.Drawing.Point(24, 23)
        Me.dtrg_clients.Name = "dtrg_clients"
        Me.dtrg_clients.ReadOnly = True
        Me.dtrg_clients.RowHeadersVisible = False
        Me.dtrg_clients.RowHeadersWidth = 62
        Me.dtrg_clients.Size = New System.Drawing.Size(413, 157)
        Me.dtrg_clients.TabIndex = 0
        '
        'client
        '
        Me.client.DataPropertyName = "name"
        Me.client.Frozen = True
        Me.client.HeaderText = "Cliente"
        Me.client.MinimumWidth = 8
        Me.client.Name = "client"
        Me.client.ReadOnly = True
        Me.client.Width = 310
        '
        'btn
        '
        Me.btn.HeaderText = "Selecionar"
        Me.btn.MinimumWidth = 8
        Me.btn.Name = "btn"
        Me.btn.ReadOnly = True
        Me.btn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.Cornsilk
        Me.btn_new.Location = New System.Drawing.Point(196, 192)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(241, 42)
        Me.btn_new.TabIndex = 1
        Me.btn_new.Text = "Novo cliente"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.LightCoral
        Me.btn_return.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(24, 192)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(152, 42)
        Me.btn_return.TabIndex = 3
        Me.btn_return.Text = "Voltar"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'frm_sel_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(464, 246)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.dtrg_clients)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sel_client"
        Me.Text = "Selecionar cliente"
        CType(Me.dtrg_clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtrg_clients As DataGridView
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents client As DataGridViewTextBoxColumn
    Friend WithEvents btn As DataGridViewButtonColumn
End Class

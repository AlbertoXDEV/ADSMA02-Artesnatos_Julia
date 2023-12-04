<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_client_list
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_client_list))
        Me.dtgr_clients = New System.Windows.Forms.DataGridView()
        Me.client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dtgr_clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgr_clients
        '
        Me.dtgr_clients.AllowUserToAddRows = False
        Me.dtgr_clients.AllowUserToResizeRows = False
        Me.dtgr_clients.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dtgr_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgr_clients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.client, Me.delete})
        Me.dtgr_clients.Location = New System.Drawing.Point(30, 12)
        Me.dtgr_clients.Name = "dtgr_clients"
        Me.dtgr_clients.ReadOnly = True
        Me.dtgr_clients.RowHeadersVisible = False
        Me.dtgr_clients.RowHeadersWidth = 62
        Me.dtgr_clients.Size = New System.Drawing.Size(453, 227)
        Me.dtgr_clients.TabIndex = 0
        '
        'client
        '
        Me.client.DataPropertyName = "name"
        Me.client.HeaderText = "Cliente"
        Me.client.MinimumWidth = 8
        Me.client.Name = "client"
        Me.client.ReadOnly = True
        Me.client.Width = 400
        '
        'delete
        '
        Me.delete.HeaderText = "Excluir"
        Me.delete.Image = Global.N2.My.Resources.Resources.remove
        Me.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.delete.MinimumWidth = 8
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.delete.Width = 50
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.Info
        Me.btn_edit.Enabled = False
        Me.btn_edit.Location = New System.Drawing.Point(267, 258)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(215, 46)
        Me.btn_edit.TabIndex = 1
        Me.btn_edit.Text = "Editar dados"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.LightCoral
        Me.btn_return.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(30, 258)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(200, 46)
        Me.btn_return.TabIndex = 2
        Me.btn_return.Text = "Voltar"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Excluir"
        Me.DataGridViewImageColumn1.Image = Global.N2.My.Resources.Resources.remove
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.MinimumWidth = 8
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.Width = 50
        '
        'frm_client_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background2
        Me.ClientSize = New System.Drawing.Size(509, 324)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.dtgr_clients)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_client_list"
        Me.Text = "Clientes"
        CType(Me.dtgr_clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgr_clients As DataGridView
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents client As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewImageColumn
End Class

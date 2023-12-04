<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mgr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mgr))
        Me.btn_newWorker = New System.Windows.Forms.Button()
        Me.btn_client = New System.Windows.Forms.Button()
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_stock = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_newWorker
        '
        Me.btn_newWorker.Location = New System.Drawing.Point(16, 13)
        Me.btn_newWorker.Name = "btn_newWorker"
        Me.btn_newWorker.Size = New System.Drawing.Size(102, 62)
        Me.btn_newWorker.TabIndex = 0
        Me.btn_newWorker.Text = "Gerenciar funcinarios"
        Me.btn_newWorker.UseVisualStyleBackColor = True
        '
        'btn_client
        '
        Me.btn_client.Location = New System.Drawing.Point(244, 13)
        Me.btn_client.Name = "btn_client"
        Me.btn_client.Size = New System.Drawing.Size(112, 62)
        Me.btn_client.TabIndex = 1
        Me.btn_client.Text = "Gerenciar clientes"
        Me.btn_client.UseVisualStyleBackColor = True
        '
        'btn_reports
        '
        Me.btn_reports.Location = New System.Drawing.Point(16, 122)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(102, 58)
        Me.btn_reports.TabIndex = 2
        Me.btn_reports.Text = "Visualisar relatórios"
        Me.btn_reports.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.IndianRed
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_logout.Location = New System.Drawing.Point(125, 239)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(112, 58)
        Me.btn_logout.TabIndex = 3
        Me.btn_logout.Text = "Sair"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_stock)
        Me.Panel1.Controls.Add(Me.btn_reports)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_newWorker)
        Me.Panel1.Controls.Add(Me.btn_client)
        Me.Panel1.Location = New System.Drawing.Point(106, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(369, 310)
        Me.Panel1.TabIndex = 4
        '
        'btn_stock
        '
        Me.btn_stock.Location = New System.Drawing.Point(244, 122)
        Me.btn_stock.Name = "btn_stock"
        Me.btn_stock.Size = New System.Drawing.Size(112, 58)
        Me.btn_stock.TabIndex = 4
        Me.btn_stock.Text = "Controle de estoque"
        Me.btn_stock.UseVisualStyleBackColor = True
        '
        'frm_mgr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(573, 430)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_mgr"
        Me.Text = "Gerenciador empresarial"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_newWorker As Button
    Friend WithEvents btn_client As Button
    Friend WithEvents btn_reports As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_stock As Button
End Class

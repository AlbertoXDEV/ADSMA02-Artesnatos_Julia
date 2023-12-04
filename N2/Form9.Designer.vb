<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_workers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_workers))
        Me.dtgr_wrk = New System.Windows.Forms.DataGridView()
        Me.nam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.leave = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.dtgr_wrk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgr_wrk
        '
        Me.dtgr_wrk.AllowUserToAddRows = False
        Me.dtgr_wrk.AllowUserToDeleteRows = False
        Me.dtgr_wrk.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dtgr_wrk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgr_wrk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nam, Me.occu, Me.addate, Me.leave})
        Me.dtgr_wrk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgr_wrk.Location = New System.Drawing.Point(65, 46)
        Me.dtgr_wrk.Name = "dtgr_wrk"
        Me.dtgr_wrk.ReadOnly = True
        Me.dtgr_wrk.RowHeadersVisible = False
        Me.dtgr_wrk.RowHeadersWidth = 62
        Me.dtgr_wrk.Size = New System.Drawing.Size(655, 317)
        Me.dtgr_wrk.TabIndex = 0
        '
        'nam
        '
        Me.nam.DataPropertyName = "name"
        Me.nam.HeaderText = "Nome"
        Me.nam.Name = "nam"
        Me.nam.ReadOnly = True
        Me.nam.Width = 375
        '
        'occu
        '
        Me.occu.DataPropertyName = "occupation"
        Me.occu.HeaderText = "Cargo"
        Me.occu.Name = "occu"
        Me.occu.ReadOnly = True
        '
        'addate
        '
        Me.addate.DataPropertyName = "entry"
        Me.addate.HeaderText = "Adimissão em"
        Me.addate.Name = "addate"
        Me.addate.ReadOnly = True
        '
        'leave
        '
        Me.leave.DataPropertyName = "on_leave"
        Me.leave.FalseValue = "0"
        Me.leave.HeaderText = "De férias"
        Me.leave.Name = "leave"
        Me.leave.ReadOnly = True
        Me.leave.TrueValue = "1"
        Me.leave.Width = 75
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(470, 378)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(132, 43)
        Me.btn_new.TabIndex = 10
        Me.btn_new.Text = "Contratar funcionário"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.LightCoral
        Me.btn_return.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(174, 378)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(131, 43)
        Me.btn_return.TabIndex = 11
        Me.btn_return.Text = "Voltar"
        Me.btn_return.UseVisualStyleBackColor = False
        '
        'frm_workers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.N2.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 450)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.dtgr_wrk)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_workers"
        Me.Text = "Lista de funcionarios"
        CType(Me.dtgr_wrk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgr_wrk As DataGridView
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents nam As DataGridViewTextBoxColumn
    Friend WithEvents occu As DataGridViewTextBoxColumn
    Friend WithEvents addate As DataGridViewTextBoxColumn
    Friend WithEvents leave As DataGridViewCheckBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipoRelatorio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGerarRelatorio = New System.Windows.Forms.Button()
        Me.dgvRelatorios = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.btnExcluirRelatorio = New System.Windows.Forms.Button()
        CType(Me.dgvRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(591, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Relatórios Gerenciais"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(96, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gere e gerencie os relatórios do sistema."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(94, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(324, 34)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "GERAR RELATÓRIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(94, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 34)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "TIPO DE RELATÓRIO"
        '
        'cmbTipoRelatorio
        '
        Me.cmbTipoRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoRelatorio.FormattingEnabled = True
        Me.cmbTipoRelatorio.Location = New System.Drawing.Point(103, 404)
        Me.cmbTipoRelatorio.Name = "cmbTipoRelatorio"
        Me.cmbTipoRelatorio.Size = New System.Drawing.Size(315, 28)
        Me.cmbTipoRelatorio.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(97, 459)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 34)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "DATA INICIAL"
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataInicial.Location = New System.Drawing.Point(100, 515)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(315, 26)
        Me.dtpDataInicial.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(97, 564)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 34)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "DATA FINAL"
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataFinal.Location = New System.Drawing.Point(97, 622)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(318, 26)
        Me.dtpDataFinal.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(97, 670)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 34)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "FORMATO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(97, 734)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 34)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "✔  PDF"
        '
        'btnGerarRelatorio
        '
        Me.btnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGerarRelatorio.ForeColor = System.Drawing.Color.Gold
        Me.btnGerarRelatorio.Location = New System.Drawing.Point(100, 800)
        Me.btnGerarRelatorio.Name = "btnGerarRelatorio"
        Me.btnGerarRelatorio.Size = New System.Drawing.Size(335, 82)
        Me.btnGerarRelatorio.TabIndex = 33
        Me.btnGerarRelatorio.Text = "Gerar Relatório"
        Me.btnGerarRelatorio.UseVisualStyleBackColor = True
        '
        'dgvRelatorios
        '
        Me.dgvRelatorios.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRelatorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRelatorios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRelatorios.Location = New System.Drawing.Point(468, 327)
        Me.dgvRelatorios.Name = "dgvRelatorios"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRelatorios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRelatorios.Size = New System.Drawing.Size(963, 423)
        Me.dgvRelatorios.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(462, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(387, 34)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "RELATÓRIOS GERADOS"
        '
        'btnVisualizar
        '
        Me.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisualizar.ForeColor = System.Drawing.Color.Gold
        Me.btnVisualizar.Location = New System.Drawing.Point(554, 800)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(359, 82)
        Me.btnVisualizar.TabIndex = 36
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'btnExcluirRelatorio
        '
        Me.btnExcluirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirRelatorio.ForeColor = System.Drawing.Color.Gold
        Me.btnExcluirRelatorio.Location = New System.Drawing.Point(1041, 800)
        Me.btnExcluirRelatorio.Name = "btnExcluirRelatorio"
        Me.btnExcluirRelatorio.Size = New System.Drawing.Size(390, 87)
        Me.btnExcluirRelatorio.TabIndex = 37
        Me.btnExcluirRelatorio.Text = "Excluir"
        Me.btnExcluirRelatorio.UseVisualStyleBackColor = True
        '
        'frm_relatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1720, 1061)
        Me.Controls.Add(Me.btnExcluirRelatorio)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvRelatorios)
        Me.Controls.Add(Me.btnGerarRelatorio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpDataFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDataInicial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTipoRelatorio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_relatorios"
        Me.Text = "Form6"
        CType(Me.dgvRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTipoRelatorio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtpDataInicial As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDataFinal As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGerarRelatorio As Button
    Friend WithEvents dgvRelatorios As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnExcluirRelatorio As Button
End Class

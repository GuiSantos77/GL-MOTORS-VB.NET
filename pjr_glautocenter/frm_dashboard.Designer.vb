<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_dashboard
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDataHoje = New System.Windows.Forms.Label()
        Me.lblVeiculosEstoque = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClientesCadastrados = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblVendasMes = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblFaturamentoMes = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.picGraficoVendas = New System.Windows.Forms.PictureBox()
        Me.picGraficoMarcas = New System.Windows.Forms.PictureBox()
        Me.lstAtividades = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dgvUltimosVeiculos = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.PanelForm = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnGerenciarClientes = New System.Windows.Forms.Button()
        Me.picCasa = New System.Windows.Forms.PictureBox()
        Me.picCarro = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picClientes = New System.Windows.Forms.PictureBox()
        Me.picUsuarios = New System.Windows.Forms.PictureBox()
        Me.picEstoque = New System.Windows.Forms.PictureBox()
        Me.picRelatorios = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.picSair = New System.Windows.Forms.PictureBox()
        CType(Me.picGraficoVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGraficoMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUltimosVeiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForm.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCarro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.picSair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Georgia", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(67, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Visão geral do sistema"
        '
        'lblDataHoje
        '
        Me.lblDataHoje.AutoSize = True
        Me.lblDataHoje.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDataHoje.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataHoje.ForeColor = System.Drawing.Color.White
        Me.lblDataHoje.Location = New System.Drawing.Point(869, 44)
        Me.lblDataHoje.Name = "lblDataHoje"
        Me.lblDataHoje.Size = New System.Drawing.Size(67, 29)
        Me.lblDataHoje.TabIndex = 16
        Me.lblDataHoje.Text = "data"
        '
        'lblVeiculosEstoque
        '
        Me.lblVeiculosEstoque.AutoSize = True
        Me.lblVeiculosEstoque.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblVeiculosEstoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeiculosEstoque.ForeColor = System.Drawing.Color.White
        Me.lblVeiculosEstoque.Location = New System.Drawing.Point(181, 145)
        Me.lblVeiculosEstoque.Name = "lblVeiculosEstoque"
        Me.lblVeiculosEstoque.Size = New System.Drawing.Size(30, 31)
        Me.lblVeiculosEstoque.TabIndex = 18
        Me.lblVeiculosEstoque.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(126, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "VEICULOS DISPONÍVEIS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(363, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CLIENTES CADASTRADOS"
        '
        'lblClientesCadastrados
        '
        Me.lblClientesCadastrados.AutoSize = True
        Me.lblClientesCadastrados.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblClientesCadastrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientesCadastrados.ForeColor = System.Drawing.Color.White
        Me.lblClientesCadastrados.Location = New System.Drawing.Point(495, 145)
        Me.lblClientesCadastrados.Name = "lblClientesCadastrados"
        Me.lblClientesCadastrados.Size = New System.Drawing.Size(30, 31)
        Me.lblClientesCadastrados.TabIndex = 21
        Me.lblClientesCadastrados.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(459, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "CLIENTES ATIVOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(660, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 23)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "VENDAS DO MÊS"
        '
        'lblVendasMes
        '
        Me.lblVendasMes.AutoSize = True
        Me.lblVendasMes.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblVendasMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendasMes.ForeColor = System.Drawing.Color.White
        Me.lblVendasMes.Location = New System.Drawing.Point(731, 145)
        Me.lblVendasMes.Name = "lblVendasMes"
        Me.lblVendasMes.Size = New System.Drawing.Size(30, 31)
        Me.lblVendasMes.TabIndex = 24
        Me.lblVendasMes.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(684, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "VEÍCULOS VENDIDOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(880, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(260, 23)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "FATURAMENTO DO MÊS"
        '
        'lblFaturamentoMes
        '
        Me.lblFaturamentoMes.AutoSize = True
        Me.lblFaturamentoMes.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFaturamentoMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaturamentoMes.ForeColor = System.Drawing.Color.White
        Me.lblFaturamentoMes.Location = New System.Drawing.Point(951, 145)
        Me.lblFaturamentoMes.Name = "lblFaturamentoMes"
        Me.lblFaturamentoMes.Size = New System.Drawing.Size(30, 31)
        Me.lblFaturamentoMes.TabIndex = 27
        Me.lblFaturamentoMes.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(964, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "ESTE MÊS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(35, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(340, 23)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "VENDAS DOS ÚLTIMOS 6 MESES"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(432, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(247, 23)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "VEÍCULOS POR MARCA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gold
        Me.Label13.Location = New System.Drawing.Point(849, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(256, 23)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "ATIVIDADES RECENTES"
        '
        'picGraficoVendas
        '
        Me.picGraficoVendas.Location = New System.Drawing.Point(55, 272)
        Me.picGraficoVendas.Name = "picGraficoVendas"
        Me.picGraficoVendas.Size = New System.Drawing.Size(302, 348)
        Me.picGraficoVendas.TabIndex = 32
        Me.picGraficoVendas.TabStop = False
        '
        'picGraficoMarcas
        '
        Me.picGraficoMarcas.Location = New System.Drawing.Point(413, 272)
        Me.picGraficoMarcas.Name = "picGraficoMarcas"
        Me.picGraficoMarcas.Size = New System.Drawing.Size(269, 348)
        Me.picGraficoMarcas.TabIndex = 33
        Me.picGraficoMarcas.TabStop = False
        '
        'lstAtividades
        '
        Me.lstAtividades.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lstAtividades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAtividades.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAtividades.ForeColor = System.Drawing.Color.White
        Me.lstAtividades.FormattingEnabled = True
        Me.lstAtividades.ItemHeight = 25
        Me.lstAtividades.Location = New System.Drawing.Point(719, 272)
        Me.lstAtividades.Name = "lstAtividades"
        Me.lstAtividades.Size = New System.Drawing.Size(529, 300)
        Me.lstAtividades.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gold
        Me.Label15.Location = New System.Drawing.Point(431, 641)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(423, 25)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "ÚLTIMOS VEÍCULOS CADASTRADOS"
        '
        'dgvUltimosVeiculos
        '
        Me.dgvUltimosVeiculos.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUltimosVeiculos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUltimosVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUltimosVeiculos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvUltimosVeiculos.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvUltimosVeiculos.Location = New System.Drawing.Point(90, 688)
        Me.dgvUltimosVeiculos.Name = "dgvUltimosVeiculos"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUltimosVeiculos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvUltimosVeiculos.Size = New System.Drawing.Size(1050, 309)
        Me.dgvUltimosVeiculos.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gold
        Me.Label14.Location = New System.Drawing.Point(66, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(278, 23)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "VEÍCULOS CADASTRADOS"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.ForeColor = System.Drawing.Color.White
        Me.btnAtualizar.Location = New System.Drawing.Point(329, 38)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(147, 35)
        Me.btnAtualizar.TabIndex = 40
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelForm.Controls.Add(Me.btnAtualizar)
        Me.PanelForm.Controls.Add(Me.Label14)
        Me.PanelForm.Controls.Add(Me.dgvUltimosVeiculos)
        Me.PanelForm.Controls.Add(Me.Label15)
        Me.PanelForm.Controls.Add(Me.lstAtividades)
        Me.PanelForm.Controls.Add(Me.picGraficoMarcas)
        Me.PanelForm.Controls.Add(Me.picGraficoVendas)
        Me.PanelForm.Controls.Add(Me.Label13)
        Me.PanelForm.Controls.Add(Me.Label12)
        Me.PanelForm.Controls.Add(Me.Label11)
        Me.PanelForm.Controls.Add(Me.Label10)
        Me.PanelForm.Controls.Add(Me.lblFaturamentoMes)
        Me.PanelForm.Controls.Add(Me.Label9)
        Me.PanelForm.Controls.Add(Me.Label8)
        Me.PanelForm.Controls.Add(Me.lblVendasMes)
        Me.PanelForm.Controls.Add(Me.Label7)
        Me.PanelForm.Controls.Add(Me.Label6)
        Me.PanelForm.Controls.Add(Me.lblClientesCadastrados)
        Me.PanelForm.Controls.Add(Me.Label4)
        Me.PanelForm.Controls.Add(Me.Label3)
        Me.PanelForm.Controls.Add(Me.lblVeiculosEstoque)
        Me.PanelForm.Controls.Add(Me.lblDataHoje)
        Me.PanelForm.Controls.Add(Me.Label5)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForm.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelForm.Location = New System.Drawing.Point(444, 0)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(1260, 1041)
        Me.PanelForm.TabIndex = 1
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(444, 223)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Gold
        Me.Button1.Location = New System.Drawing.Point(0, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(444, 61)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "                  DashBoard"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gold
        Me.Button2.Location = New System.Drawing.Point(0, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(444, 65)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "                 Cadastro De Veiculos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Gold
        Me.Button3.Location = New System.Drawing.Point(0, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(444, 71)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "                 Cadastro De Clientes"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Gold
        Me.Button4.Location = New System.Drawing.Point(0, 420)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(444, 65)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "                 Cadastro De Usuários"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Gold
        Me.Button5.Location = New System.Drawing.Point(0, 485)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(444, 65)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "                Estoque De Veiculos"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Gold
        Me.Button6.Location = New System.Drawing.Point(0, 550)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(444, 65)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "                Relatórios"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Gold
        Me.Button7.Location = New System.Drawing.Point(0, 615)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(444, 84)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "                Gerenciar Contas"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnGerenciarClientes
        '
        Me.btnGerenciarClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGerenciarClientes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.btnGerenciarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGerenciarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGerenciarClientes.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGerenciarClientes.ForeColor = System.Drawing.Color.Gold
        Me.btnGerenciarClientes.Location = New System.Drawing.Point(0, 699)
        Me.btnGerenciarClientes.Name = "btnGerenciarClientes"
        Me.btnGerenciarClientes.Size = New System.Drawing.Size(444, 81)
        Me.btnGerenciarClientes.TabIndex = 8
        Me.btnGerenciarClientes.Text = "                Gerenciar Clientes"
        Me.btnGerenciarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGerenciarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGerenciarClientes.UseVisualStyleBackColor = True
        '
        'picCasa
        '
        Me.picCasa.Image = CType(resources.GetObject("picCasa.Image"), System.Drawing.Image)
        Me.picCasa.Location = New System.Drawing.Point(40, 231)
        Me.picCasa.Name = "picCasa"
        Me.picCasa.Size = New System.Drawing.Size(53, 47)
        Me.picCasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCasa.TabIndex = 10
        Me.picCasa.TabStop = False
        '
        'picCarro
        '
        Me.picCarro.Image = CType(resources.GetObject("picCarro.Image"), System.Drawing.Image)
        Me.picCarro.Location = New System.Drawing.Point(40, 296)
        Me.picCarro.Name = "picCarro"
        Me.picCarro.Size = New System.Drawing.Size(53, 47)
        Me.picCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCarro.TabIndex = 11
        Me.picCarro.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 850)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(444, 188)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'picClientes
        '
        Me.picClientes.Image = CType(resources.GetObject("picClientes.Image"), System.Drawing.Image)
        Me.picClientes.Location = New System.Drawing.Point(40, 367)
        Me.picClientes.Name = "picClientes"
        Me.picClientes.Size = New System.Drawing.Size(53, 47)
        Me.picClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picClientes.TabIndex = 11
        Me.picClientes.TabStop = False
        '
        'picUsuarios
        '
        Me.picUsuarios.Image = CType(resources.GetObject("picUsuarios.Image"), System.Drawing.Image)
        Me.picUsuarios.Location = New System.Drawing.Point(40, 432)
        Me.picUsuarios.Name = "picUsuarios"
        Me.picUsuarios.Size = New System.Drawing.Size(53, 47)
        Me.picUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsuarios.TabIndex = 11
        Me.picUsuarios.TabStop = False
        '
        'picEstoque
        '
        Me.picEstoque.Image = CType(resources.GetObject("picEstoque.Image"), System.Drawing.Image)
        Me.picEstoque.Location = New System.Drawing.Point(40, 497)
        Me.picEstoque.Name = "picEstoque"
        Me.picEstoque.Size = New System.Drawing.Size(53, 47)
        Me.picEstoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEstoque.TabIndex = 11
        Me.picEstoque.TabStop = False
        '
        'picRelatorios
        '
        Me.picRelatorios.Image = CType(resources.GetObject("picRelatorios.Image"), System.Drawing.Image)
        Me.picRelatorios.Location = New System.Drawing.Point(40, 562)
        Me.picRelatorios.Name = "picRelatorios"
        Me.picRelatorios.Size = New System.Drawing.Size(53, 47)
        Me.picRelatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRelatorios.TabIndex = 11
        Me.picRelatorios.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(40, 632)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(53, 47)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(40, 714)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(53, 47)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.Black
        Me.PanelPrincipal.Controls.Add(Me.picSair)
        Me.PanelPrincipal.Controls.Add(Me.PictureBox5)
        Me.PanelPrincipal.Controls.Add(Me.PictureBox4)
        Me.PanelPrincipal.Controls.Add(Me.Button8)
        Me.PanelPrincipal.Controls.Add(Me.picRelatorios)
        Me.PanelPrincipal.Controls.Add(Me.picEstoque)
        Me.PanelPrincipal.Controls.Add(Me.picUsuarios)
        Me.PanelPrincipal.Controls.Add(Me.picClientes)
        Me.PanelPrincipal.Controls.Add(Me.PictureBox2)
        Me.PanelPrincipal.Controls.Add(Me.picCarro)
        Me.PanelPrincipal.Controls.Add(Me.picCasa)
        Me.PanelPrincipal.Controls.Add(Me.btnGerenciarClientes)
        Me.PanelPrincipal.Controls.Add(Me.Button7)
        Me.PanelPrincipal.Controls.Add(Me.Button6)
        Me.PanelPrincipal.Controls.Add(Me.Button5)
        Me.PanelPrincipal.Controls.Add(Me.Button4)
        Me.PanelPrincipal.Controls.Add(Me.Button3)
        Me.PanelPrincipal.Controls.Add(Me.Button2)
        Me.PanelPrincipal.Controls.Add(Me.Button1)
        Me.PanelPrincipal.Controls.Add(Me.PanelLogo)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(444, 1041)
        Me.PanelPrincipal.TabIndex = 0
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Georgia", 18.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Gold
        Me.Button8.Location = New System.Drawing.Point(0, 780)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(444, 77)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "                Sair do Sistema "
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'picSair
        '
        Me.picSair.Image = CType(resources.GetObject("picSair.Image"), System.Drawing.Image)
        Me.picSair.Location = New System.Drawing.Point(40, 797)
        Me.picSair.Name = "picSair"
        Me.picSair.Size = New System.Drawing.Size(53, 47)
        Me.picSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSair.TabIndex = 14
        Me.picSair.TabStop = False
        '
        'frm_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1704, 1041)
        Me.Controls.Add(Me.PanelForm)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema"
        CType(Me.picGraficoVendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGraficoMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUltimosVeiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCarro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        CType(Me.picSair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDataHoje As Label
    Friend WithEvents lblVeiculosEstoque As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblClientesCadastrados As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblVendasMes As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblFaturamentoMes As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents picGraficoVendas As PictureBox
    Friend WithEvents picGraficoMarcas As PictureBox
    Friend WithEvents lstAtividades As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents dgvUltimosVeiculos As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnGerenciarClientes As Button
    Friend WithEvents picCasa As PictureBox
    Friend WithEvents picCarro As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents picClientes As PictureBox
    Friend WithEvents picUsuarios As PictureBox
    Friend WithEvents picEstoque As PictureBox
    Friend WithEvents picRelatorios As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents picSair As PictureBox
End Class

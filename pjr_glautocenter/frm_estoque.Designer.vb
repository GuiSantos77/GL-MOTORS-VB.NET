<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_estoque
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDisponiveis = New System.Windows.Forms.Label()
        Me.lblReservados = New System.Windows.Forms.Label()
        Me.lblIndisponiveis = New System.Windows.Forms.Label()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.cmbFiltroMarca = New System.Windows.Forms.ComboBox()
        Me.cmbFiltroModelo = New System.Windows.Forms.ComboBox()
        Me.cmbFiltroAno = New System.Windows.Forms.ComboBox()
        Me.dgvEstoque = New System.Windows.Forms.DataGridView()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnAlterarStatus = New System.Windows.Forms.Button()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(113, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(519, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Estoque de Veiculos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(119, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(368, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gerencie todos os veiculos disponiveis em estoque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(118, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TOTAL DE VEÍCULOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(118, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DISPONÍVEIS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(119, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "RESERVADOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(118, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "INDISPONÍVEIS"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Gold
        Me.lblTotal.Location = New System.Drawing.Point(382, 160)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(30, 31)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "0"
        '
        'lblDisponiveis
        '
        Me.lblDisponiveis.AutoSize = True
        Me.lblDisponiveis.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponiveis.ForeColor = System.Drawing.Color.Lime
        Me.lblDisponiveis.Location = New System.Drawing.Point(382, 199)
        Me.lblDisponiveis.Name = "lblDisponiveis"
        Me.lblDisponiveis.Size = New System.Drawing.Size(30, 31)
        Me.lblDisponiveis.TabIndex = 1
        Me.lblDisponiveis.Text = "0"
        '
        'lblReservados
        '
        Me.lblReservados.AutoSize = True
        Me.lblReservados.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservados.ForeColor = System.Drawing.Color.Yellow
        Me.lblReservados.Location = New System.Drawing.Point(382, 242)
        Me.lblReservados.Name = "lblReservados"
        Me.lblReservados.Size = New System.Drawing.Size(30, 31)
        Me.lblReservados.TabIndex = 1
        Me.lblReservados.Text = "0"
        '
        'lblIndisponiveis
        '
        Me.lblIndisponiveis.AutoSize = True
        Me.lblIndisponiveis.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndisponiveis.ForeColor = System.Drawing.Color.Red
        Me.lblIndisponiveis.Location = New System.Drawing.Point(382, 285)
        Me.lblIndisponiveis.Name = "lblIndisponiveis"
        Me.lblIndisponiveis.Size = New System.Drawing.Size(30, 31)
        Me.lblIndisponiveis.TabIndex = 1
        Me.lblIndisponiveis.Text = "0"
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(689, 106)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(182, 26)
        Me.txtBusca.TabIndex = 6
        '
        'cmbFiltroMarca
        '
        Me.cmbFiltroMarca.FormattingEnabled = True
        Me.cmbFiltroMarca.Location = New System.Drawing.Point(887, 106)
        Me.cmbFiltroMarca.Name = "cmbFiltroMarca"
        Me.cmbFiltroMarca.Size = New System.Drawing.Size(110, 28)
        Me.cmbFiltroMarca.TabIndex = 7
        '
        'cmbFiltroModelo
        '
        Me.cmbFiltroModelo.FormattingEnabled = True
        Me.cmbFiltroModelo.Location = New System.Drawing.Point(1005, 106)
        Me.cmbFiltroModelo.Name = "cmbFiltroModelo"
        Me.cmbFiltroModelo.Size = New System.Drawing.Size(110, 28)
        Me.cmbFiltroModelo.TabIndex = 7
        '
        'cmbFiltroAno
        '
        Me.cmbFiltroAno.FormattingEnabled = True
        Me.cmbFiltroAno.Location = New System.Drawing.Point(1127, 105)
        Me.cmbFiltroAno.Name = "cmbFiltroAno"
        Me.cmbFiltroAno.Size = New System.Drawing.Size(110, 28)
        Me.cmbFiltroAno.TabIndex = 7
        '
        'dgvEstoque
        '
        Me.dgvEstoque.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEstoque.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEstoque.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEstoque.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvEstoque.Location = New System.Drawing.Point(575, 155)
        Me.dgvEstoque.Name = "dgvEstoque"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEstoque.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEstoque.Size = New System.Drawing.Size(789, 360)
        Me.dgvEstoque.TabIndex = 8
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(133, 386)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(328, 129)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFoto.TabIndex = 9
        Me.picFoto.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(189, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "FOTO DO VEÍCULO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(106, 543)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ALTERAR STATUS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(107, 589)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "STATUS ATUAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(107, 671)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "NOVO STATUS"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(245, 628)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(230, 28)
        Me.cmbStatus.TabIndex = 7
        '
        'btnAlterarStatus
        '
        Me.btnAlterarStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAlterarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterarStatus.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterarStatus.ForeColor = System.Drawing.Color.Gold
        Me.btnAlterarStatus.Location = New System.Drawing.Point(575, 537)
        Me.btnAlterarStatus.Name = "btnAlterarStatus"
        Me.btnAlterarStatus.Size = New System.Drawing.Size(230, 46)
        Me.btnAlterarStatus.TabIndex = 10
        Me.btnAlterarStatus.Text = "Alterar Status"
        Me.btnAlterarStatus.UseVisualStyleBackColor = False
        '
        'btnAtualizar
        '
        Me.btnAtualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.ForeColor = System.Drawing.Color.Gold
        Me.btnAtualizar.Location = New System.Drawing.Point(1165, 534)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(230, 52)
        Me.btnAtualizar.TabIndex = 10
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(710, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "BUSCAR VEÍCULO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(905, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "MARCA"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1017, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "MODELO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1153, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "ANO"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.Gold
        Me.btnExcluir.Location = New System.Drawing.Point(873, 534)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(230, 52)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "Excluir Veículo"
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'frm_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1720, 1061)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.btnAlterarStatus)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.dgvEstoque)
        Me.Controls.Add(Me.cmbFiltroAno)
        Me.Controls.Add(Me.cmbFiltroModelo)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.cmbFiltroMarca)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblIndisponiveis)
        Me.Controls.Add(Me.lblReservados)
        Me.Controls.Add(Me.lblDisponiveis)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_estoque"
        Me.Text = "Form5"
        CType(Me.dgvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDisponiveis As Label
    Friend WithEvents lblReservados As Label
    Friend WithEvents lblIndisponiveis As Label
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents cmbFiltroMarca As ComboBox
    Friend WithEvents cmbFiltroModelo As ComboBox
    Friend WithEvents cmbFiltroAno As ComboBox
    Friend WithEvents dgvEstoque As DataGridView
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnAlterarStatus As Button
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnExcluir As Button
End Class

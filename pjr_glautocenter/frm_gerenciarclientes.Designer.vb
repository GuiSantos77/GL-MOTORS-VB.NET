<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gerenciarclientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.lblTotalClientes = New System.Windows.Forms.Label()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscarCPF = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSalvarEdicao = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 56)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gerenciar Contas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(81, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(352, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Edite ou exclua clientes cadastrados no sistema."
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(77, 190)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(356, 20)
        Me.txtBusca.TabIndex = 15
        '
        'lblTotalClientes
        '
        Me.lblTotalClientes.AutoSize = True
        Me.lblTotalClientes.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalClientes.ForeColor = System.Drawing.Color.Gold
        Me.lblTotalClientes.Location = New System.Drawing.Point(541, 181)
        Me.lblTotalClientes.Name = "lblTotalClientes"
        Me.lblTotalClientes.Size = New System.Drawing.Size(70, 29)
        Me.lblTotalClientes.TabIndex = 16
        Me.lblTotalClientes.Text = "Total"
        '
        'btnAtualizar
        '
        Me.btnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtualizar.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizar.ForeColor = System.Drawing.Color.White
        Me.btnAtualizar.Location = New System.Drawing.Point(805, 175)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(321, 35)
        Me.btnAtualizar.TabIndex = 17
        Me.btnAtualizar.Text = "Atualizar"
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(48, 234)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(740, 762)
        Me.dgvClientes.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(818, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 29)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "BUSCAR POR CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(818, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "CPF"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(823, 340)
        Me.txtCPF.Mask = "000.000.000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(140, 20)
        Me.txtCPF.TabIndex = 21
        '
        'btnBuscarCPF
        '
        Me.btnBuscarCPF.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnBuscarCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCPF.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCPF.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCPF.Location = New System.Drawing.Point(978, 328)
        Me.btnBuscarCPF.Name = "btnBuscarCPF"
        Me.btnBuscarCPF.Size = New System.Drawing.Size(148, 43)
        Me.btnBuscarCPF.TabIndex = 22
        Me.btnBuscarCPF.Text = "Buscar"
        Me.btnBuscarCPF.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(818, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 29)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "EDITAR CLIENTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(820, 448)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "NOME COMPLETO"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(823, 485)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(303, 20)
        Me.txtNome.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(820, 531)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "DATA DE NASCIMENTO"
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Location = New System.Drawing.Point(823, 566)
        Me.txtDataNascimento.Mask = "00/00/0000"
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(303, 20)
        Me.txtDataNascimento.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(820, 627)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "TELEFONE"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(823, 661)
        Me.txtTelefone.Mask = "(00) 00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(303, 20)
        Me.txtTelefone.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(820, 719)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "E-MAIL"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(823, 753)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(303, 20)
        Me.txtEmail.TabIndex = 31
        '
        'btnSalvarEdicao
        '
        Me.btnSalvarEdicao.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnSalvarEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarEdicao.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvarEdicao.ForeColor = System.Drawing.Color.White
        Me.btnSalvarEdicao.Location = New System.Drawing.Point(822, 812)
        Me.btnSalvarEdicao.Name = "btnSalvarEdicao"
        Me.btnSalvarEdicao.Size = New System.Drawing.Size(304, 43)
        Me.btnSalvarEdicao.TabIndex = 32
        Me.btnSalvarEdicao.Text = "Salvar Edição"
        Me.btnSalvarEdicao.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.ForeColor = System.Drawing.Color.White
        Me.btnExcluir.Location = New System.Drawing.Point(822, 880)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(304, 43)
        Me.btnExcluir.TabIndex = 33
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(822, 953)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(304, 43)
        Me.btnLimpar.TabIndex = 34
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'frm_gerenciarclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1704, 1022)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvarEdicao)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDataNascimento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBuscarCPF)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnAtualizar)
        Me.Controls.Add(Me.lblTotalClientes)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_gerenciarclientes"
        Me.Text = "frm_gerenciarclientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents lblTotalClientes As Label
    Friend WithEvents btnAtualizar As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents btnBuscarCPF As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDataNascimento As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSalvarEdicao As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnLimpar As Button
End Class

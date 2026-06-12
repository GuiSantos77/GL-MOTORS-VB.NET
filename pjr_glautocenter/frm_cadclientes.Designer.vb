<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadclientes
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnCadastrarCliente = New System.Windows.Forms.Button()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(215, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cadastro De Clientes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(221, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 40)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Prencha os dados abaixo para cadastrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "um novo cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(218, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(218, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 38)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nome completo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(218, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(341, 38)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Data de nascimento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(222, 559)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 38)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Telefone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(226, 667)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 38)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "E-mail"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(225, 405)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(290, 32)
        Me.txtNome.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(225, 717)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(304, 32)
        Me.txtEmail.TabIndex = 10
        '
        'btnCadastrarCliente
        '
        Me.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarCliente.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarCliente.ForeColor = System.Drawing.Color.White
        Me.btnCadastrarCliente.Location = New System.Drawing.Point(225, 780)
        Me.btnCadastrarCliente.Name = "btnCadastrarCliente"
        Me.btnCadastrarCliente.Size = New System.Drawing.Size(338, 61)
        Me.btnCadastrarCliente.TabIndex = 11
        Me.btnCadastrarCliente.Text = "Cadastrar Cliente"
        Me.btnCadastrarCliente.UseVisualStyleBackColor = True
        '
        'txtCPF
        '
        Me.txtCPF.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPF.Location = New System.Drawing.Point(225, 284)
        Me.txtCPF.Mask = "000.000.000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(290, 32)
        Me.txtCPF.TabIndex = 12
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDataNascimento.Location = New System.Drawing.Point(225, 505)
        Me.txtDataNascimento.Mask = "00/00/0000"
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(294, 32)
        Me.txtDataNascimento.TabIndex = 12
        Me.txtDataNascimento.ValidatingType = GetType(Date)
        '
        'txtTelefone
        '
        Me.txtTelefone.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefone.Location = New System.Drawing.Point(225, 612)
        Me.txtTelefone.Mask = "(00) 00000-00000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(294, 32)
        Me.txtTelefone.TabIndex = 12
        '
        'frm_cadclientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1720, 1061)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtDataNascimento)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.btnCadastrarCliente)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gold
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadclientes"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnCadastrarCliente As Button
    Friend WithEvents txtCPF As MaskedTextBox
    Friend WithEvents txtDataNascimento As MaskedTextBox
    Friend WithEvents txtTelefone As MaskedTextBox
End Class

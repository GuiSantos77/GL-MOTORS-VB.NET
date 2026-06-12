<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadusuario
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbTipoConta = New System.Windows.Forms.ComboBox()
        Me.btnCriarConta = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(196, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(563, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cadastro De Usuários"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(208, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(208, 573)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(208, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 38)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo de conta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(211, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Selecione o tipo de conta que deseja criar"
        '
        'cmbTipoConta
        '
        Me.cmbTipoConta.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoConta.FormattingEnabled = True
        Me.cmbTipoConta.Location = New System.Drawing.Point(215, 364)
        Me.cmbTipoConta.Name = "cmbTipoConta"
        Me.cmbTipoConta.Size = New System.Drawing.Size(296, 33)
        Me.cmbTipoConta.TabIndex = 3
        '
        'btnCriarConta
        '
        Me.btnCriarConta.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCriarConta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCriarConta.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriarConta.ForeColor = System.Drawing.Color.White
        Me.btnCriarConta.Location = New System.Drawing.Point(206, 706)
        Me.btnCriarConta.Name = "btnCriarConta"
        Me.btnCriarConta.Size = New System.Drawing.Size(325, 85)
        Me.btnCriarConta.TabIndex = 4
        Me.btnCriarConta.Text = "Criar Conta"
        Me.btnCriarConta.UseVisualStyleBackColor = False
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(215, 514)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(296, 31)
        Me.txtNome.TabIndex = 5
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(215, 636)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(296, 31)
        Me.txtSenha.TabIndex = 5
        '
        'frm_cadusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1720, 1080)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnCriarConta)
        Me.Controls.Add(Me.cmbTipoConta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gold
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadusuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadusuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbTipoConta As ComboBox
    Friend WithEvents btnCriarConta As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtSenha As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_cadveiculos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdicionarFoto = New System.Windows.Forms.Button()
        Me.flpFotos = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblContadorFotos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtQuilometragem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.lblContadorDesc = New System.Windows.Forms.Label()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(185, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadastro De Veículos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(191, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(414, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Prencha os dados abaixo para cadastrar um novo veiculo."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(190, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "FOTOS DO VEÍCULOS"
        '
        'btnAdicionarFoto
        '
        Me.btnAdicionarFoto.FlatAppearance.BorderSize = 0
        Me.btnAdicionarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionarFoto.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarFoto.ForeColor = System.Drawing.Color.Gold
        Me.btnAdicionarFoto.Location = New System.Drawing.Point(222, 179)
        Me.btnAdicionarFoto.Name = "btnAdicionarFoto"
        Me.btnAdicionarFoto.Size = New System.Drawing.Size(279, 75)
        Me.btnAdicionarFoto.TabIndex = 6
        Me.btnAdicionarFoto.Text = "Clique para adicionar fotos"
        Me.btnAdicionarFoto.UseVisualStyleBackColor = True
        '
        'flpFotos
        '
        Me.flpFotos.AutoScroll = True
        Me.flpFotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpFotos.Location = New System.Drawing.Point(195, 260)
        Me.flpFotos.Name = "flpFotos"
        Me.flpFotos.Size = New System.Drawing.Size(343, 134)
        Me.flpFotos.TabIndex = 7
        '
        'lblContadorFotos
        '
        Me.lblContadorFotos.AutoSize = True
        Me.lblContadorFotos.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorFotos.ForeColor = System.Drawing.Color.White
        Me.lblContadorFotos.Location = New System.Drawing.Point(448, 407)
        Me.lblContadorFotos.Name = "lblContadorFotos"
        Me.lblContadorFotos.Size = New System.Drawing.Size(90, 18)
        Me.lblContadorFotos.TabIndex = 5
        Me.lblContadorFotos.Text = "0/10 fotos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(192, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 5
        '
        'cmbMarca
        '
        Me.cmbMarca.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(195, 483)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(154, 26)
        Me.cmbMarca.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(192, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(367, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Modelo"
        '
        'cmbModelo
        '
        Me.cmbModelo.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Location = New System.Drawing.Point(372, 483)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(166, 26)
        Me.cmbModelo.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(190, 533)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Ano Do Modelo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(367, 533)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 25)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Quilometragem"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(190, 620)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 25)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Valor"
        '
        'txtAno
        '
        Me.txtAno.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAno.Location = New System.Drawing.Point(195, 575)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(154, 26)
        Me.txtAno.TabIndex = 9
        '
        'txtQuilometragem
        '
        Me.txtQuilometragem.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuilometragem.Location = New System.Drawing.Point(372, 575)
        Me.txtQuilometragem.Name = "txtQuilometragem"
        Me.txtQuilometragem.Size = New System.Drawing.Size(173, 26)
        Me.txtQuilometragem.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(190, 703)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 25)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Descrição Do Veiculo"
        '
        'txtDescricao
        '
        Me.txtDescricao.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(195, 740)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(336, 108)
        Me.txtDescricao.TabIndex = 9
        '
        'lblContadorDesc
        '
        Me.lblContadorDesc.AutoSize = True
        Me.lblContadorDesc.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContadorDesc.ForeColor = System.Drawing.Color.White
        Me.lblContadorDesc.Location = New System.Drawing.Point(466, 864)
        Me.lblContadorDesc.Name = "lblContadorDesc"
        Me.lblContadorDesc.Size = New System.Drawing.Size(65, 18)
        Me.lblContadorDesc.TabIndex = 5
        Me.lblContadorDesc.Text = "0/1000"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCadastrar.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.ForeColor = System.Drawing.Color.White
        Me.btnCadastrar.Location = New System.Drawing.Point(195, 899)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(336, 95)
        Me.btnCadastrar.TabIndex = 10
        Me.btnCadastrar.Text = "Cadastrar Veículo"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(195, 659)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(336, 26)
        Me.txtValor.TabIndex = 11
        '
        'frm_cadveiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1720, 1061)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtQuilometragem)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.cmbModelo)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.flpFotos)
        Me.Controls.Add(Me.btnAdicionarFoto)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblContadorDesc)
        Me.Controls.Add(Me.lblContadorFotos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadveiculos"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdicionarFoto As Button
    Friend WithEvents flpFotos As FlowLayoutPanel
    Friend WithEvents lblContadorFotos As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbModelo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAno As TextBox
    Friend WithEvents txtQuilometragem As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lblContadorDesc As Label
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents txtValor As MaskedTextBox
End Class

Imports System.Data.SqlClient
Imports System.IO

Public Class frm_cadveiculos

    ' Lista para guardar os caminhos das fotos
    Private listaFotos As New List(Of String)


    Private Sub frm_cadveiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche marcas
        cmbMarca.Items.AddRange(New String() {
            "Chevrolet", "Ford", "Volkswagen", "Fiat", "Toyota",
            "Honda", "Hyundai", "Jeep", "Nissan", "BMW",
            "Mercedes-Benz", "Audi", "Renault", "Mitsubishi", "Volvo"
        })
        cmbMarca.SelectedIndex = -1
        cmbModelo.SelectedIndex = -1
        txtAno.MaxLength = 4
        txtDescricao.MaxLength = 1000
        lblContadorFotos.Text = "0/10 fotos"
        lblContadorDesc.Text = "0/1000"
    End Sub

    ' Quando mudar a marca, carrega os modelos
    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedIndexChanged
        cmbModelo.Items.Clear()

        If cmbMarca.SelectedIndex = -1 Then Return

        Select Case cmbMarca.SelectedItem.ToString()
            Case "Chevrolet"
                cmbModelo.Items.AddRange(New String() {"Onix", "Cruze", "Tracker", "S10", "Spin"})
            Case "Ford"
                cmbModelo.Items.AddRange(New String() {"Ka", "EcoSport", "Ranger", "Territory", "Bronco"})
            Case "Volkswagen"
                cmbModelo.Items.AddRange(New String() {"Gol", "Polo", "T-Cross", "Virtus", "Amarok"})
            Case "Fiat"
                cmbModelo.Items.AddRange(New String() {"Argo", "Cronos", "Pulse", "Strada", "Toro"})
            Case "Toyota"
                cmbModelo.Items.AddRange(New String() {"Corolla", "Hilux", "SW4", "Yaris", "RAV4"})
            Case "Honda"
                cmbModelo.Items.AddRange(New String() {"Civic", "HR-V", "CR-V", "City", "Fit"})
            Case "Hyundai"
                cmbModelo.Items.AddRange(New String() {"HB20", "Creta", "Tucson", "Santa Fe", "IX35"})
            Case "Jeep"
                cmbModelo.Items.AddRange(New String() {"Renegade", "Compass", "Commander", "Wrangler"})
            Case "Nissan"
                cmbModelo.Items.AddRange(New String() {"Kicks", "Frontier", "Versa", "Sentra"})
            Case "BMW"
                cmbModelo.Items.AddRange(New String() {"Serie 3", "Serie 5", "X1", "X3", "X5"})
            Case "Mercedes-Benz"
                cmbModelo.Items.AddRange(New String() {"Classe A", "Classe C", "GLA", "GLC", "Sprinter"})
            Case "Audi"
                cmbModelo.Items.AddRange(New String() {"A3", "A4", "Q3", "Q5", "Q7"})
            Case "Renault"
                cmbModelo.Items.AddRange(New String() {"Kwid", "Sandero", "Logan", "Duster", "Captur"})
            Case "Mitsubishi"
                cmbModelo.Items.AddRange(New String() {"L200", "Outlander", "Eclipse Cross", "ASX"})
            Case "Volvo"
                cmbModelo.Items.AddRange(New String() {"XC40", "XC60", "XC90", "S60", "V60"})
            Case Else
                cmbModelo.Items.Add("Outro")
        End Select

        cmbModelo.SelectedIndex = -1
    End Sub

    ' ===================== FOTOS =====================

    Private Sub btnAdicionarFoto_Click(sender As Object, e As EventArgs) Handles btnAdicionarFoto.Click
        If listaFotos.Count >= 10 Then
            MessageBox.Show("Máximo de 10 fotos atingido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using ofd As New OpenFileDialog()
            ofd.Title = "Selecione as fotos do veículo"
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png"
            ofd.Multiselect = True

            If ofd.ShowDialog() = DialogResult.OK Then
                For Each arquivo In ofd.FileNames
                    If listaFotos.Count >= 10 Then Exit For

                    Dim tamanho As Long = New FileInfo(arquivo).Length
                    If tamanho > 5 * 1024 * 1024 Then
                        MessageBox.Show($"'{Path.GetFileName(arquivo)}' ultrapassa 5MB e foi ignorado.",
                                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Continue For
                    End If

                    If Not listaFotos.Contains(arquivo) Then
                        listaFotos.Add(arquivo)
                    End If
                Next

                AtualizarMiniaturas()
            End If
        End Using
    End Sub

    Private Sub AtualizarMiniaturas()
        flpFotos.Controls.Clear()

        For i As Integer = 0 To listaFotos.Count - 1
            Dim index As Integer = i

            ' Painel de cada miniatura
            Dim pnl As New Panel()
            pnl.Size = New Size(110, 120)
            pnl.BackColor = Color.FromArgb(30, 30, 30)
            pnl.Cursor = Cursors.Hand

            ' PictureBox com a foto
            Dim pic As New PictureBox()
            pic.Size = New Size(100, 90)
            pic.Location = New Point(5, 5)
            pic.SizeMode = PictureBoxSizeMode.Zoom
            pic.Image = Image.FromFile(listaFotos(index))
            pic.Cursor = Cursors.Hand

            ' Botão X para remover
            Dim btnX As New Button()
            btnX.Text = "✕"
            btnX.Size = New Size(22, 22)
            btnX.Location = New Point(84, 2)
            btnX.FlatStyle = FlatStyle.Flat
            btnX.FlatAppearance.BorderSize = 0
            btnX.BackColor = Color.Red
            btnX.ForeColor = Color.White
            btnX.Font = New Font("Arial", 7, FontStyle.Bold)
            btnX.Cursor = Cursors.Hand

            ' Evento remover
            AddHandler btnX.Click, Sub(s, ev)
                                       listaFotos.RemoveAt(index)
                                       AtualizarMiniaturas()
                                   End Sub

            ' Nome do arquivo embaixo
            Dim lblNome As New Label()
            lblNome.Text = Path.GetFileName(listaFotos(index))
            lblNome.Size = New Size(100, 20)
            lblNome.Location = New Point(5, 97)
            lblNome.ForeColor = Color.Silver
            lblNome.Font = New Font("Arial", 7)
            lblNome.TextAlign = ContentAlignment.MiddleCenter

            pnl.Controls.Add(pic)
            pnl.Controls.Add(btnX)
            pnl.Controls.Add(lblNome)
            flpFotos.Controls.Add(pnl)
        Next

        lblContadorFotos.Text = $"{listaFotos.Count}/10 fotos"
    End Sub



    Private Sub txtDescricao_TextChanged(sender As Object, e As EventArgs) Handles txtDescricao.TextChanged
        lblContadorDesc.Text = $"{txtDescricao.Text.Length}/1000"
    End Sub

    'Banco

    Dim conn As SqlConnection = ObterConexao()



    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click

        ' Validações
        If cmbMarca.SelectedIndex = -1 Then
            MessageBox.Show("Selecione a marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbMarca.Focus() : Return
        End If

        If cmbModelo.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o modelo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbModelo.Focus() : Return
        End If

        If String.IsNullOrWhiteSpace(txtAno.Text) OrElse txtAno.Text.Length < 4 Then
            MessageBox.Show("Informe o ano com 4 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAno.Focus() : Return
        End If

        If String.IsNullOrWhiteSpace(txtQuilometragem.Text) Then
            MessageBox.Show("Informe a quilometragem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuilometragem.Focus() : Return
        End If

        If String.IsNullOrWhiteSpace(txtValor.Text) Then
            MessageBox.Show("Informe o valor.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtValor.Focus() : Return
        End If

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                ' Insere o veículo e retorna o ID gerado
                Dim sqlVeiculo As String = "INSERT INTO tb_veiculos (Marca, Modelo, Ano, Quilometragem, Valor, Descricao) " &
                                           "VALUES (@Marca, @Modelo, @Ano, @Quilometragem, @Valor, @Descricao); " &
                                           "SELECT SCOPE_IDENTITY();"

                Dim idVeiculo As Integer

                Using cmd As New SqlCommand(sqlVeiculo, conn)
                    cmd.Parameters.AddWithValue("@Marca", cmbMarca.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Modelo", cmbModelo.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Ano", Convert.ToInt32(txtAno.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Quilometragem", Convert.ToInt32(txtQuilometragem.Text.Trim()))
                    Dim valorTexto As String = txtValor.Text.Replace("_", "").Replace(".", "").Replace(",", ".").Trim()
                    cmd.Parameters.AddWithValue("@Valor", Decimal.Parse(valorTexto, System.Globalization.CultureInfo.InvariantCulture))
                    cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text.Trim())

                    idVeiculo = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                ' Salva as fotos como binário no banco
                If listaFotos.Count > 0 Then
                    Dim sqlFoto As String = "INSERT INTO tb_veiculos_fotos (IdVeiculo, Foto, NomeArquivo) " &
                                            "VALUES (@IdVeiculo, @Foto, @Nome)"

                    For Each caminhoFoto In listaFotos
                        Dim bytesImagem() As Byte = File.ReadAllBytes(caminhoFoto)

                        Using cmdFoto As New SqlCommand(sqlFoto, conn)
                            cmdFoto.Parameters.AddWithValue("@IdVeiculo", idVeiculo)
                            cmdFoto.Parameters.AddWithValue("@Foto", bytesImagem)
                            cmdFoto.Parameters.AddWithValue("@Nome", Path.GetFileName(caminhoFoto))
                            cmdFoto.ExecuteNonQuery()
                        End Using
                    Next
                End If

            End Using

            MessageBox.Show("Veículo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparCampos()

        Catch ex As SqlException
            MessageBox.Show("Erro ao salvar no banco:" & Environment.NewLine & ex.Message,
                            "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Erro inesperado:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' ===================== LIMPAR =====================

    Private Sub LimparCampos()
        cmbMarca.SelectedIndex = -1
        cmbModelo.SelectedIndex = -1
        cmbModelo.Items.Clear()
        txtAno.Text = ""
        txtQuilometragem.Text = ""
        txtValor.Text = ""
        txtDescricao.Text = ""
        listaFotos.Clear()
        flpFotos.Controls.Clear()
        lblContadorFotos.Text = "0/10 fotos"
        lblContadorDesc.Text = "0/1000"
        cmbMarca.Focus()
    End Sub

End Class
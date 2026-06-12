Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frm_relatorios

    Private idRelatorioSelecionado As Integer = -1

    Dim conn As SqlConnection = ObterConexao()

    Private Sub frm_relatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Preenche tipos de relatório
        cmbTipoRelatorio.Items.Clear()
        cmbTipoRelatorio.Items.Add("Veículos em Estoque")
        cmbTipoRelatorio.Items.Add("Clientes Cadastrados")
        cmbTipoRelatorio.Items.Add("Usuários do Sistema")
        cmbTipoRelatorio.SelectedIndex = -1

        ' Datas padrão
        dtpDataInicial.Value = New DateTime(DateTime.Now.Year, 1, 1)
        dtpDataFinal.Value = DateTime.Now

        ConfigurarGrid()
        CarregarRelatorios()
    End Sub

    Private Sub ConfigurarGrid()
        dgvRelatorios.AutoGenerateColumns = False
        dgvRelatorios.Columns.Clear()
        dgvRelatorios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRelatorios.MultiSelect = False
        dgvRelatorios.ReadOnly = True
        dgvRelatorios.AllowUserToAddRows = False
        dgvRelatorios.RowHeadersVisible = False

        Dim colId As New DataGridViewTextBoxColumn()
        colId.DataPropertyName = "Id"
        colId.Visible = False
        dgvRelatorios.Columns.Add(colId)

        Dim colNome As New DataGridViewTextBoxColumn()
        colNome.DataPropertyName = "NomeRelatorio"
        colNome.HeaderText = "Relatório"
        colNome.Width = 160
        dgvRelatorios.Columns.Add(colNome)

        Dim colTipo As New DataGridViewTextBoxColumn()
        colTipo.DataPropertyName = "Tipo"
        colTipo.HeaderText = "Tipo"
        colTipo.Width = 100
        dgvRelatorios.Columns.Add(colTipo)

        Dim colPeriodo As New DataGridViewTextBoxColumn()
        colPeriodo.DataPropertyName = "Periodo"
        colPeriodo.HeaderText = "Período"
        colPeriodo.Width = 160
        dgvRelatorios.Columns.Add(colPeriodo)

        Dim colData As New DataGridViewTextBoxColumn()
        colData.DataPropertyName = "DataGeracao"
        colData.HeaderText = "Data de Geração"
        colData.Width = 130
        colData.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
        dgvRelatorios.Columns.Add(colData)

        Dim colGeradoPor As New DataGridViewTextBoxColumn()
        colGeradoPor.DataPropertyName = "GeradoPor"
        colGeradoPor.HeaderText = "Gerado por"
        colGeradoPor.Width = 110
        dgvRelatorios.Columns.Add(colGeradoPor)

        dgvRelatorios.Font = New System.Drawing.Font("Georgia", 16)
        dgvRelatorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CarregarRelatorios()
        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Dim sql As String = "SELECT Id, NomeRelatorio, Tipo, Periodo, DataGeracao, GeradoPor FROM tb_relatorios ORDER BY DataGeracao DESC"
                Using cmd As New SqlCommand(sql, conn)
                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvRelatorios.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar relatórios:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGerarRelatorio_Click(sender As Object, e As EventArgs) Handles btnGerarRelatorio.Click
        If cmbTipoRelatorio.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o tipo de relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dtpDataInicial.Value > dtpDataFinal.Value Then
            MessageBox.Show("A data inicial não pode ser maior que a data final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim tipo As String = cmbTipoRelatorio.SelectedItem.ToString()
        Dim dataInicial As DateTime = dtpDataInicial.Value.Date
        Dim dataFinal As DateTime = dtpDataFinal.Value.Date.AddDays(1).AddSeconds(-1)
        Dim periodo As String = dataInicial.ToString("dd/MM/yyyy") & " - " & dtpDataFinal.Value.ToString("dd/MM/yyyy")

        ' Gera o PDF
        Dim caminhoArquivo As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                     $"Relatorio_{tipo.Replace(" ", "_")}_{DateTime.Now:ddMMyyyy_HHmm}.pdf")

        Try
            GerarPDF(tipo, dataInicial, dataFinal, caminhoArquivo)

            ' Salva o registro no banco
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Dim sql As String = "INSERT INTO tb_relatorios (NomeRelatorio, Tipo, Periodo, DataGeracao, GeradoPor, CaminhoArquivo) " &
                                    "VALUES (@Nome, @Tipo, @Periodo, @DataGeracao, @GeradoPor, @Caminho)"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Nome", tipo)
                    cmd.Parameters.AddWithValue("@Tipo", tipo.Split(" ")(0))
                    cmd.Parameters.AddWithValue("@Periodo", periodo)
                    cmd.Parameters.AddWithValue("@DataGeracao", DateTime.Now)
                    cmd.Parameters.AddWithValue("@GeradoPor", "Administrador")
                    cmd.Parameters.AddWithValue("@Caminho", caminhoArquivo)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Relatório gerado com sucesso!" & Environment.NewLine & "Salvo em: " & caminhoArquivo,
                            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CarregarRelatorios()

            ' Abre o PDF automaticamente
            Process.Start(caminhoArquivo)

        Catch ex As Exception
            MessageBox.Show("Erro ao gerar relatório:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GerarPDF(tipo As String, dataInicial As DateTime, dataFinal As DateTime, caminho As String)

        Dim doc As New Document(PageSize.A4, 40, 40, 60, 40)
        PdfWriter.GetInstance(doc, New FileStream(caminho, FileMode.Create))
        doc.Open()

        Dim corDourado As New BaseColor(201, 168, 76)

        Dim fonteTitulo As New iTextSharp.text.Font(
        iTextSharp.text.Font.FontFamily.HELVETICA,
        18,
        iTextSharp.text.Font.BOLD,
        corDourado)

        Dim fonteSubtitulo As New iTextSharp.text.Font(
        iTextSharp.text.Font.FontFamily.HELVETICA,
        10)

        Dim fonteCabecalho As New iTextSharp.text.Font(
        iTextSharp.text.Font.FontFamily.HELVETICA,
        9,
        iTextSharp.text.Font.BOLD,
        BaseColor.WHITE)

        Dim fonteDado As New iTextSharp.text.Font(
        iTextSharp.text.Font.FontFamily.HELVETICA,
        9)

        doc.Add(New Paragraph("GL MOTORS - Concessionária", fonteTitulo))
        doc.Add(New Paragraph("Relatório: " & tipo, fonteSubtitulo))
        doc.Add(New Paragraph("Período: " & dataInicial.ToString("dd/MM/yyyy") &
                          " a " & dataFinal.ToString("dd/MM/yyyy"), fonteSubtitulo))
        doc.Add(New Paragraph("Gerado em: " &
                          DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fonteSubtitulo))
        doc.Add(New Paragraph(" "))

        Using conn As SqlConnection = ObterConexao()

            conn.Open()

            Dim sql As String = ""
            Dim colunas() As String = {}

            Select Case tipo

                Case "Veículos em Estoque"

                    sql = "SELECT Marca, Modelo, Ano, Quilometragem, Valor, Status " &
                      "FROM tb_veiculos ORDER BY Marca"

                    colunas = {
                    "Marca",
                    "Modelo",
                    "Ano",
                    "KM",
                    "Valor (R$)",
                    "Status"
                }

                Case "Clientes Cadastrados"

                    sql = "SELECT " &
                      "nome AS Nome, " &
                      "cpf AS CPF, " &
                      "fone AS Telefone, " &
                      "email AS Email, " &
                      "data_nasc AS Nascimento " &
                      "FROM tb_clientes " &
                      "ORDER BY nome"

                    colunas = {
                    "Nome",
                    "CPF",
                    "Telefone",
                    "E-mail",
                    "Nascimento"
                }

                Case "Usuários do Sistema"

                    sql = "SELECT Nome, TipoUsuario, Status " &
                      "FROM tb_usuarios ORDER BY Nome"

                    colunas = {
                    "Nome",
                    "Tipo",
                    "Status"
                }

            End Select

            Using cmd As New SqlCommand(sql, conn)

                Dim dt As New DataTable()
                Dim da As New SqlDataAdapter(cmd)

                da.Fill(dt)

                Dim tabela As New PdfPTable(colunas.Length)
                tabela.WidthPercentage = 100

                For Each col As String In colunas

                    Dim cell As New PdfPCell(New Phrase(col, fonteCabecalho))
                    cell.BackgroundColor = corDourado
                    cell.Padding = 6
                    cell.HorizontalAlignment = Element.ALIGN_CENTER

                    tabela.AddCell(cell)

                Next

                Dim linhaAlternada As Boolean = False

                For Each row As DataRow In dt.Rows

                    Dim bgColor As BaseColor =
                    If(linhaAlternada,
                       New BaseColor(240, 240, 240),
                       BaseColor.WHITE)

                    For Each item In row.ItemArray

                        Dim cell As New PdfPCell(New Phrase(item.ToString(), fonteDado))
                        cell.BackgroundColor = bgColor
                        cell.Padding = 5

                        tabela.AddCell(cell)

                    Next

                    linhaAlternada = Not linhaAlternada

                Next

                doc.Add(tabela)

                doc.Add(New Paragraph(" "))
                doc.Add(New Paragraph("Total de registros: " &
                                  dt.Rows.Count.ToString(),
                                  fonteSubtitulo))

            End Using

        End Using

        doc.Close()

    End Sub

    ' Visualizar PDF
    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        If dgvRelatorios.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione um relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Convert.ToInt32(dgvRelatorios.SelectedRows(0).Cells(0).Value)

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Using cmd As New SqlCommand("SELECT CaminhoArquivo FROM tb_relatorios WHERE Id = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    Dim caminho As String = cmd.ExecuteScalar().ToString()

                    If File.Exists(caminho) Then
                        Process.Start(caminho)
                    Else
                        MessageBox.Show("Arquivo não encontrado: " & caminho, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao abrir relatório:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Excluir relatório
    Private Sub btnExcluirRelatorio_Click(sender As Object, e As EventArgs) Handles btnExcluirRelatorio.Click
        If dgvRelatorios.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione um relatório.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Deseja excluir este relatório?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

        Dim id As Integer = Convert.ToInt32(dgvRelatorios.SelectedRows(0).Cells(0).Value)

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                ' Pega o caminho antes de excluir
                Dim caminho As String = ""
                Using cmd As New SqlCommand("SELECT CaminhoArquivo FROM tb_relatorios WHERE Id = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    Dim resultado = cmd.ExecuteScalar()
                    If resultado IsNot Nothing Then caminho = resultado.ToString()
                End Using

                ' Exclui do banco
                Using cmd As New SqlCommand("DELETE FROM tb_relatorios WHERE Id = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    cmd.ExecuteNonQuery()
                End Using

                ' Exclui o arquivo PDF se existir
                If File.Exists(caminho) Then
                    File.Delete(caminho)
                End If
            End Using

            MessageBox.Show("Relatório excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CarregarRelatorios()

        Catch ex As Exception
            MessageBox.Show("Erro ao excluir:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
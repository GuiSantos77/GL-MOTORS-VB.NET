Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frm_dashboard

    Dim conn As SqlConnection = ObterConexao()

    Private Sub frm_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblDataHoje.Text = "Hoje, " & DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy",
                       New System.Globalization.CultureInfo("pt-BR"))

        If UsuarioLogado_Tipo = "Vendedor" Then
            Button1.Visible = False
            Button4.Visible = False
            Button7.Visible = False
            picCasa.Visible = False
            picCarro.Visible = False
            picClientes.Visible = False
            picUsuarios.Visible = False
            picEstoque.Visible = False
            picRelatorios.Visible = False
            picSair.Visible = False
            PictureBox5.Visible = False
            PictureBox4.Visible = False
            PictureBox2.Visible = False
            FormShow(New frm_cadclientes())
            Return
        End If

        CarregarContadores()
        CarregarUltimosVeiculos()
        CarregarGraficoVendas()
        CarregarGraficoMarcas()
        CarregarAtividades()

    End Sub

    Private Sub CarregarContadores()
        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Using cmd As New SqlCommand("SELECT COUNT(*) FROM tb_veiculos WHERE Status = 'Disponível'", conn)
                    lblVeiculosEstoque.Text = cmd.ExecuteScalar().ToString()
                End Using

                Using cmd As New SqlCommand("SELECT COUNT(*) FROM tb_clientes", conn)
                    lblClientesCadastrados.Text = cmd.ExecuteScalar().ToString()
                End Using

                Using cmd As New SqlCommand("SELECT COUNT(*) FROM tb_veiculos WHERE Status = 'Vendido' AND MONTH(DataCadastro) = MONTH(GETDATE()) AND YEAR(DataCadastro) = YEAR(GETDATE())", conn)
                    lblVendasMes.Text = cmd.ExecuteScalar().ToString()
                End Using

                Using cmd As New SqlCommand("SELECT ISNULL(SUM(Valor), 0) FROM tb_veiculos WHERE Status = 'Vendido' AND MONTH(DataCadastro) = MONTH(GETDATE()) AND YEAR(DataCadastro) = YEAR(GETDATE())", conn)
                    Dim valor As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                    lblFaturamentoMes.Text = "R$ " & valor.ToString("N2", New System.Globalization.CultureInfo("pt-BR"))
                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar contadores:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregarUltimosVeiculos()
        Try
            ConfigurarGridVeiculos()
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Dim sql As String = "SELECT TOP 5 Id, Marca, Modelo, Ano, Quilometragem, Valor, Status FROM tb_veiculos ORDER BY Id DESC"
                Using cmd As New SqlCommand(sql, conn)
                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvUltimosVeiculos.DataSource = dt
                End Using
            End Using
            ColorirStatusGrid()
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar veículos:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarGridVeiculos()
        dgvUltimosVeiculos.AutoGenerateColumns = False
        dgvUltimosVeiculos.Columns.Clear()
        dgvUltimosVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUltimosVeiculos.ReadOnly = True
        dgvUltimosVeiculos.AllowUserToAddRows = False
        dgvUltimosVeiculos.RowHeadersVisible = False

        Dim colId As New DataGridViewTextBoxColumn()
        colId.DataPropertyName = "Id"
        colId.Visible = False
        dgvUltimosVeiculos.Columns.Add(colId)

        Dim colMarca As New DataGridViewTextBoxColumn()
        colMarca.DataPropertyName = "Marca"
        colMarca.HeaderText = "Marca"
        dgvUltimosVeiculos.Columns.Add(colMarca)

        Dim colModelo As New DataGridViewTextBoxColumn()
        colModelo.DataPropertyName = "Modelo"
        colModelo.HeaderText = "Modelo"
        dgvUltimosVeiculos.Columns.Add(colModelo)

        Dim colAno As New DataGridViewTextBoxColumn()
        colAno.DataPropertyName = "Ano"
        colAno.HeaderText = "Ano"
        dgvUltimosVeiculos.Columns.Add(colAno)

        Dim colKm As New DataGridViewTextBoxColumn()
        colKm.DataPropertyName = "Quilometragem"
        colKm.HeaderText = "Quilometragem"
        dgvUltimosVeiculos.Columns.Add(colKm)

        Dim colValor As New DataGridViewTextBoxColumn()
        colValor.DataPropertyName = "Valor"
        colValor.HeaderText = "Valor"
        colValor.DefaultCellStyle.Format = "C2"
        colValor.DefaultCellStyle.FormatProvider = New System.Globalization.CultureInfo("pt-BR")
        dgvUltimosVeiculos.Columns.Add(colValor)

        Dim colStatus As New DataGridViewTextBoxColumn()
        colStatus.DataPropertyName = "Status"
        colStatus.HeaderText = "Status"
        dgvUltimosVeiculos.Columns.Add(colStatus)

        dgvUltimosVeiculos.Font = New System.Drawing.Font("Georgia", 9)
        dgvUltimosVeiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUltimosVeiculos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 40, 40)
        dgvUltimosVeiculos.DefaultCellStyle.SelectionForeColor = Color.Gold
    End Sub

    Private Sub ColorirStatusGrid()
        For Each row As DataGridViewRow In dgvUltimosVeiculos.Rows
            If row.Cells(6).Value IsNot Nothing Then
                Select Case row.Cells(6).Value.ToString()
                    Case "Disponível"
                        row.DefaultCellStyle.ForeColor = Color.LightGreen
                    Case "Reservado"
                        row.DefaultCellStyle.ForeColor = Color.Orange
                    Case "Vendido"
                        row.DefaultCellStyle.ForeColor = Color.Salmon
                    Case "Indisponível"
                        row.DefaultCellStyle.ForeColor = Color.Gray
                End Select
            End If
        Next
    End Sub

    Private Sub CarregarGraficoVendas()
        Try
            Dim chart As New Chart()
            chart.Dock = DockStyle.Fill
            chart.BackColor = Color.FromArgb(17, 17, 17)

            Dim area As New ChartArea()
            area.BackColor = Color.FromArgb(17, 17, 17)
            area.AxisX.LabelStyle.ForeColor = Color.Gray
            area.AxisX.LabelStyle.Font = New System.Drawing.Font("Georgia", 8)
            area.AxisY.LabelStyle.ForeColor = Color.Gray
            area.AxisY.LabelStyle.Font = New System.Drawing.Font("Georgia", 8)
            area.AxisX.LineColor = Color.FromArgb(50, 50, 50)
            area.AxisY.LineColor = Color.FromArgb(50, 50, 50)
            area.AxisX.MajorGrid.LineColor = Color.FromArgb(30, 30, 30)
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(30, 30, 30)
            chart.ChartAreas.Add(area)

            Dim series As New Series()
            series.ChartType = SeriesChartType.Line
            series.Color = Color.FromArgb(201, 168, 76)
            series.BorderWidth = 2
            series.MarkerStyle = MarkerStyle.Circle
            series.MarkerSize = 6
            series.MarkerColor = Color.FromArgb(201, 168, 76)

            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Dim sql As String = "SELECT FORMAT(DataCadastro, 'MMM/yy', 'pt-BR') AS Mes, COUNT(*) AS Total " &
                                    "FROM tb_veiculos WHERE Status = 'Vendido' " &
                                    "AND DataCadastro >= DATEADD(MONTH, -6, GETDATE()) " &
                                    "GROUP BY FORMAT(DataCadastro, 'MMM/yy', 'pt-BR'), YEAR(DataCadastro), MONTH(DataCadastro) " &
                                    "ORDER BY YEAR(DataCadastro), MONTH(DataCadastro)"

                Using cmd As New SqlCommand(sql, conn)
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        series.Points.AddXY(dr("Mes").ToString(), Convert.ToInt32(dr("Total")))
                    End While
                End Using
            End Using

            If series.Points.Count = 0 Then
                series.Points.AddXY("Sem dados", 0)
            End If

            chart.Series.Add(series)
            picGraficoVendas.Controls.Clear()
            picGraficoVendas.Controls.Add(chart)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub CarregarGraficoMarcas()
        Try
            Dim chart As New Chart()
            chart.Dock = DockStyle.Fill
            chart.BackColor = Color.FromArgb(17, 17, 17)

            Dim area As New ChartArea()
            area.BackColor = Color.FromArgb(17, 17, 17)
            chart.ChartAreas.Add(area)

            Dim series As New Series()
            series.ChartType = SeriesChartType.Doughnut
            series.Font = New System.Drawing.Font("Georgia", 10, FontStyle.Bold)

            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Dim sql As String = "SELECT TOP 5 Marca, COUNT(*) AS Total FROM tb_veiculos GROUP BY Marca ORDER BY Total DESC"
                Using cmd As New SqlCommand(sql, conn)
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        series.Points.AddXY(dr("Marca").ToString(), Convert.ToInt32(dr("Total")))
                    End While
                End Using
            End Using

            If series.Points.Count = 0 Then
                series.Points.AddXY("Sem dados", 1)
            End If

            ' Cores do projeto
            Dim cores() As Color = {
                Color.FromArgb(201, 168, 76),
                Color.FromArgb(150, 120, 50),
                Color.FromArgb(80, 80, 80),
                Color.FromArgb(50, 50, 50),
                Color.FromArgb(120, 120, 120)
            }

            For i As Integer = 0 To series.Points.Count - 1
                series.Points(i).Color = cores(i Mod cores.Length)
                series.Points(i).LabelForeColor = Color.White
                series.Points(i).Font = New System.Drawing.Font("Georgia", 10, FontStyle.Bold)
            Next

            ' Legenda
            Dim legenda As New Legend()
            legenda.BackColor = Color.FromArgb(17, 17, 17)
            legenda.ForeColor = Color.FromArgb(201, 168, 76)
            legenda.Font = New System.Drawing.Font("Georgia", 9, FontStyle.Bold)
            chart.Legends.Add(legenda)
            series.Legend = legenda.Name
            series.IsVisibleInLegend = True

            chart.Series.Add(series)
            picGraficoMarcas.Controls.Clear()
            picGraficoMarcas.Controls.Add(chart)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub CarregarAtividades()
        Try
            lstAtividades.Items.Clear()

            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Using cmd As New SqlCommand("SELECT TOP 3 'Novo veículo: ' + Marca + ' ' + Modelo AS Atividade, DataCadastro FROM tb_veiculos ORDER BY Id DESC", conn)
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        lstAtividades.Items.Add("🚗 " & dr("Atividade").ToString() & " — " & Convert.ToDateTime(dr("DataCadastro")).ToString("dd/MM HH:mm"))
                    End While
                End Using

                Using cmd As New SqlCommand("SELECT TOP 2 'Novo cliente: ' + Nome AS Atividade, DataCadastro FROM tb_clientes ORDER BY Id DESC", conn)
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        lstAtividades.Items.Add("👤 " & dr("Atividade").ToString() & " — " & Convert.ToDateTime(dr("DataCadastro")).ToString("dd/MM HH:mm"))
                    End While
                End Using

            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private frmAtivo As Form

    Private Sub FormShow(frm As Form)
        ActiveFormClose()
        frmAtivo = frm
        frm.TopLevel = False
        PanelForm.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub ActiveFormClose()
        If frmAtivo IsNot Nothing Then
            frmAtivo.Close()
        End If
    End Sub

    Private Sub ActiveButton(frmAtivo As Button)
        For Each ctrl As Control In PanelPrincipal.Controls
            ctrl.ForeColor = Color.Gold
        Next
        frmAtivo.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ActiveButton(Button1)
        ActiveFormClose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ActiveButton(Button2)
        FormShow(New frm_cadveiculos())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ActiveButton(Button3)
        FormShow(New frm_cadclientes())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If UsuarioLogado_Tipo = "Vendedor" Then
            MessageBox.Show("Acesso negado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ActiveButton(Button4)
        FormShow(New frm_cadusuario())
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ActiveButton(Button5)
        FormShow(New frm_estoque())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ActiveButton(Button6)
        FormShow(New frm_relatorios())
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If UsuarioLogado_Tipo = "Vendedor" Then
            MessageBox.Show("Acesso negado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ActiveButton(Button7)
        FormShow(New frm_gerenciarcontas())
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim resposta As DialogResult = MessageBox.Show(
            "Tem certeza que deseja sair do sistema?",
            "Sair do Sistema",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnGerenciarClientes_Click(sender As Object, e As EventArgs) Handles btnGerenciarClientes.Click
        ActiveButton(btnGerenciarClientes)
        FormShow(New frm_gerenciarclientes())
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        CarregarContadores()
        CarregarUltimosVeiculos()
        CarregarGraficoVendas()
        CarregarGraficoMarcas()
        CarregarAtividades()
        MessageBox.Show("Dashboard atualizado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
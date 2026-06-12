Imports System.Data.SqlClient
Imports System.IO

Public Class frm_estoque

    Private idVeiculoSelecionado As Integer = -1

    Dim conn As SqlConnection = ObterConexao()

    Private Sub frm_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        CarregarFiltros()
        CarregarEstoque()
        CarregarContadores()

        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Disponível")
        cmbStatus.Items.Add("Reservado")
        cmbStatus.Items.Add("Indisponível")
        cmbStatus.Items.Add("Vendido")
        cmbStatus.SelectedIndex = -1
    End Sub

    Private Sub ConfigurarGrid()
        dgvEstoque.AutoGenerateColumns = False
        dgvEstoque.Columns.Clear()
        dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEstoque.MultiSelect = False
        dgvEstoque.ReadOnly = True
        dgvEstoque.AllowUserToAddRows = False
        dgvEstoque.RowHeadersVisible = False

        Dim colId As New DataGridViewTextBoxColumn()
        colId.DataPropertyName = "Id"
        colId.HeaderText = "ID"
        colId.Width = 40
        colId.Visible = False
        dgvEstoque.Columns.Add(colId)

        Dim colMarca As New DataGridViewTextBoxColumn()
        colMarca.DataPropertyName = "Marca"
        colMarca.HeaderText = "Marca"
        colMarca.Width = 100
        dgvEstoque.Columns.Add(colMarca)

        Dim colModelo As New DataGridViewTextBoxColumn()
        colModelo.DataPropertyName = "Modelo"
        colModelo.HeaderText = "Modelo"
        colModelo.Width = 100
        dgvEstoque.Columns.Add(colModelo)

        Dim colAno As New DataGridViewTextBoxColumn()
        colAno.DataPropertyName = "Ano"
        colAno.HeaderText = "Ano"
        colAno.Width = 60
        dgvEstoque.Columns.Add(colAno)

        Dim colKm As New DataGridViewTextBoxColumn()
        colKm.DataPropertyName = "Quilometragem"
        colKm.HeaderText = "KM"
        colKm.Width = 80
        dgvEstoque.Columns.Add(colKm)

        Dim colValor As New DataGridViewTextBoxColumn()
        colValor.DataPropertyName = "Valor"
        colValor.HeaderText = "Valor"
        colValor.Width = 110
        colValor.DefaultCellStyle.Format = "C2"
        colValor.DefaultCellStyle.FormatProvider = New System.Globalization.CultureInfo("pt-BR")
        dgvEstoque.Columns.Add(colValor)

        Dim colStatus As New DataGridViewTextBoxColumn()
        colStatus.DataPropertyName = "Status"
        colStatus.HeaderText = "Situação"
        colStatus.Width = 100
        dgvEstoque.Columns.Add(colStatus)

        dgvEstoque.Font = New Font("Georgia", 16)

        dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CarregarEstoque(Optional filtro As String = "")
        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Dim sql As String = "SELECT v.Id, v.Marca, v.Modelo, v.Ano, v.Quilometragem, v.Valor, v.Status " &
                                    "FROM tb_veiculos v WHERE 1=1 "

                If Not String.IsNullOrWhiteSpace(txtBusca.Text) Then
                    sql &= "AND (v.Marca LIKE @Busca OR v.Modelo LIKE @Busca) "
                End If
                If cmbFiltroMarca.SelectedIndex > 0 Then
                    sql &= "AND v.Marca = @Marca "
                End If
                If cmbFiltroAno.SelectedIndex > 0 Then
                    sql &= "AND v.Ano = @Ano "
                End If

                sql &= "ORDER BY v.Id DESC"

                Using cmd As New SqlCommand(sql, conn)
                    If Not String.IsNullOrWhiteSpace(txtBusca.Text) Then
                        cmd.Parameters.AddWithValue("@Busca", "%" & txtBusca.Text.Trim() & "%")
                    End If
                    If cmbFiltroMarca.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@Marca", cmbFiltroMarca.SelectedItem.ToString())
                    End If
                    If cmbFiltroAno.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@Ano", cmbFiltroAno.SelectedItem.ToString())
                    End If

                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvEstoque.DataSource = dt
                End Using
            End Using

            ' Colore as linhas por status
            ColorirLinhas()

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar estoque:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ColorirLinhas()
        For Each row As DataGridViewRow In dgvEstoque.Rows
            If row.Cells(6).Value IsNot Nothing Then
                Select Case row.Cells(6).Value.ToString()
                    Case "Disponível"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(20, 180, 100, 20)
                        row.DefaultCellStyle.ForeColor = Color.LightGreen
                    Case "Reservado"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(20, 180, 140, 0)
                        row.DefaultCellStyle.ForeColor = Color.Orange
                    Case "Indisponível"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(20, 180, 20, 20)
                        row.DefaultCellStyle.ForeColor = Color.Salmon
                End Select
            End If
        Next
    End Sub

    Private Sub CarregarContadores()
        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Dim sql As String = "SELECT " &
                                    "COUNT(*) AS Total, " &
                                    "SUM(CASE WHEN Status = 'Disponível' THEN 1 ELSE 0 END) AS Disponiveis, " &
                                    "SUM(CASE WHEN Status = 'Reservado' THEN 1 ELSE 0 END) AS Reservados, " &
                                    "SUM(CASE WHEN Status = 'Indisponível' THEN 1 ELSE 0 END) AS Indisponiveis " &
                                    "FROM tb_veiculos"

                Using cmd As New SqlCommand(sql, conn)
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        lblTotal.Text = dr("Total").ToString()
                        lblDisponiveis.Text = dr("Disponiveis").ToString()
                        lblReservados.Text = dr("Reservados").ToString()
                        lblIndisponiveis.Text = dr("Indisponiveis").ToString()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar contadores:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregarFiltros()
        Try
            ' Marcas
            cmbFiltroMarca.Items.Clear()
            cmbFiltroMarca.Items.Add("Todas as marcas")
            Using conn As New SqlConnection(ObterConexao().ConnectionString)
                conn.Open()
                Using cmd As New SqlCommand("SELECT DISTINCT Marca FROM tb_veiculos ORDER BY Marca", conn)
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        cmbFiltroMarca.Items.Add(dr("Marca").ToString())
                    End While
                End Using
            End Using
            cmbFiltroMarca.SelectedIndex = 0

            ' Anos
            cmbFiltroAno.Items.Clear()
            cmbFiltroAno.Items.Add("Todos os anos")
            Using conn As New SqlConnection(ObterConexao().ConnectionString)
                conn.Open()
                Using cmd As New SqlCommand("SELECT DISTINCT Ano FROM tb_veiculos ORDER BY Ano DESC", conn)
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        cmbFiltroAno.Items.Add(dr("Ano").ToString())
                    End While
                End Using
            End Using
            cmbFiltroAno.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar filtros:" & Environment.NewLine & ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Ao selecionar linha no grid
    Private Sub dgvEstoque_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEstoque.SelectionChanged
        If dgvEstoque.SelectedRows.Count = 0 Then Return

        Dim row As DataGridViewRow = dgvEstoque.SelectedRows(0)
        idVeiculoSelecionado = Convert.ToInt32(row.Cells(0).Value)

        ' Carrega status atual no combobox
        Dim statusAtual As String = row.Cells(6).Value.ToString()
        cmbStatus.SelectedItem = statusAtual

        ' Carrega foto do veículo
        CarregarFoto(idVeiculoSelecionado)
    End Sub

    Private Sub CarregarFoto(idVeiculo As Integer)
        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Dim sql As String = "SELECT TOP 1 Foto FROM tb_veiculos_fotos WHERE IdVeiculo = @Id"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Id", idVeiculo)
                    Dim resultado = cmd.ExecuteScalar()

                    If resultado IsNot Nothing AndAlso resultado IsNot DBNull.Value Then
                        Dim bytes() As Byte = CType(resultado, Byte())
                        Using ms As New MemoryStream(bytes)
                            picFoto.Image = Image.FromStream(ms)
                        End Using
                    Else
                        picFoto.Image = Nothing
                    End If
                End Using
            End Using

        Catch ex As Exception
            picFoto.Image = Nothing
        End Try
    End Sub

    ' Alterar status do veículo selecionado
    Private Sub btnAlterarStatus_Click(sender As Object, e As EventArgs) Handles btnAlterarStatus.Click
        If idVeiculoSelecionado = -1 Then
            MessageBox.Show("Selecione um veículo na lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o novo status.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Dim sql As String = "UPDATE tb_veiculos SET Status = @Status WHERE Id = @Id"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Id", idVeiculoSelecionado)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Status atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CarregarEstoque()
            CarregarContadores()

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar status:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Busca e filtros
    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        CarregarEstoque()
    End Sub

    Private Sub cmbFiltroMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroMarca.SelectedIndexChanged
        cmbFiltroModelo.Items.Clear()
        cmbFiltroModelo.Items.Add("Todos os modelos")
        cmbFiltroModelo.SelectedIndex = 0

        If cmbFiltroMarca.SelectedIndex <= 0 Then Return

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Using cmd As New SqlCommand("SELECT DISTINCT Modelo FROM tb_veiculos WHERE Marca = @Marca ORDER BY Modelo", conn)
                    cmd.Parameters.AddWithValue("@Marca", cmbFiltroMarca.SelectedItem.ToString())
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        cmbFiltroModelo.Items.Add(dr("Modelo").ToString())
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar modelos:" & Environment.NewLine & ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbFiltroAno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroAno.SelectedIndexChanged
        CarregarEstoque()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        CarregarFiltros()
        CarregarEstoque()
        CarregarContadores()
    End Sub

    Private Sub btnNovoVeiculo_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        frm_dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If idVeiculoSelecionado = -1 Then
            MessageBox.Show("Selecione um veículo para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirma As DialogResult = MessageBox.Show(
            "Tem certeza que deseja excluir este veículo? Esta ação não pode ser desfeita.",
            "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirma = DialogResult.No Then Return

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                ' Exclui as fotos primeiro (chave estrangeira)
                Using cmd As New SqlCommand("DELETE FROM tb_veiculos_fotos WHERE IdVeiculo = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", idVeiculoSelecionado)
                    cmd.ExecuteNonQuery()
                End Using

                ' Exclui o veículo
                Using cmd As New SqlCommand("DELETE FROM tb_veiculos WHERE Id = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", idVeiculoSelecionado)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Veículo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            idVeiculoSelecionado = -1
            picFoto.Image = Nothing
            cmbStatus.SelectedIndex = -1
            CarregarEstoque()
            CarregarContadores()
            CarregarFiltros()

        Catch ex As SqlException
            MessageBox.Show("Erro ao excluir:" & Environment.NewLine & ex.Message,
                            "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Erro inesperado:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
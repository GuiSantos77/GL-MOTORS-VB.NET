Imports System.Data.SqlClient

Public Class frm_gerenciarcontas

    Private idUsuarioSelecionado As Integer = -1
    Private statusAtualSelecionado As String = ""

    Dim conn As SqlConnection = ObterConexao()


    Private Sub frm_gerenciarcontas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        CarregarFiltros()
        CarregarUsuarios()
        CarregarContadores()
        If UsuarioLogado_Tipo = "Vendedor" Then
            MessageBox.Show("Acesso negado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If
    End Sub

    Private Sub ConfigurarGrid()
        dgvUsuarios.AutoGenerateColumns = False
        dgvUsuarios.Columns.Clear()
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.MultiSelect = False
        dgvUsuarios.ReadOnly = True
        dgvUsuarios.AllowUserToAddRows = False
        dgvUsuarios.RowHeadersVisible = False
        dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        Dim colId As New DataGridViewTextBoxColumn()
        colId.DataPropertyName = "id_usuario"
        colId.HeaderText = "ID"
        colId.Visible = False
        dgvUsuarios.Columns.Add(colId)

        Dim colNome As New DataGridViewTextBoxColumn()
        colNome.DataPropertyName = "Nome"
        colNome.HeaderText = "Nome"
        colNome.Width = 180
        dgvUsuarios.Columns.Add(colNome)

        Dim colTipo As New DataGridViewTextBoxColumn()
        colTipo.DataPropertyName = "TipoUsuario"
        colTipo.HeaderText = "Tipo de Conta"
        colTipo.Width = 120
        dgvUsuarios.Columns.Add(colTipo)

        Dim colStatus As New DataGridViewTextBoxColumn()
        colStatus.DataPropertyName = "Status"
        colStatus.HeaderText = "Status"
        colStatus.Width = 100
        dgvUsuarios.Columns.Add(colStatus)

        Dim colData As New DataGridViewTextBoxColumn()
        colData.DataPropertyName = "DataCadastro"
        colData.HeaderText = "Desde"
        colData.Width = 100
        colData.DefaultCellStyle.Format = "dd/MM/yyyy"
        dgvUsuarios.Columns.Add(colData)

        dgvUsuarios.Font = New Font("Georgia", 16)

        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub CarregarUsuarios()
        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Dim sql As String = "SELECT id_usuario, Nome, TipoUsuario, Status, DataCadastro FROM tb_usuarios WHERE 1=1 "

                If Not String.IsNullOrWhiteSpace(txtBusca.Text) Then
                    sql &= "AND Nome LIKE @Busca "
                End If
                If cmbFiltroTipo.SelectedIndex > 0 Then
                    sql &= "AND TipoUsuario = @Tipo "
                End If
                If cmbFiltroStatus.SelectedIndex > 0 Then
                    sql &= "AND Status = @Status "
                End If

                sql &= "ORDER BY Nome"

                Using cmd As New SqlCommand(sql, conn)
                    If Not String.IsNullOrWhiteSpace(txtBusca.Text) Then
                        cmd.Parameters.AddWithValue("@Busca", "%" & txtBusca.Text.Trim() & "%")
                    End If
                    If cmbFiltroTipo.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@Tipo", cmbFiltroTipo.SelectedItem.ToString())
                    End If
                    If cmbFiltroStatus.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue("@Status", cmbFiltroStatus.SelectedItem.ToString())
                    End If

                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)

                    If dt.Rows.Count = 0 Then
                        dgvUsuarios.DataSource = Nothing
                    Else
                        dgvUsuarios.DataSource = dt
                    End If

                End Using
            End Using



        Catch ex As Exception
            MessageBox.Show("Erro ao carregar usuários:" & Environment.NewLine & ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CarregarContadores()
        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Dim sql As String = "SELECT " &
                                    "COUNT(*) AS Total, " &
                                    "SUM(CASE WHEN Status = 'Ativa' THEN 1 ELSE 0 END) AS Ativas, " &
                                    "SUM(CASE WHEN Status = 'Desativada' THEN 1 ELSE 0 END) AS Desativadas " &
                                    "FROM tb_usuarios"

                Using cmd As New SqlCommand(sql, conn)
                    Dim dr As SqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        lblTotal.Text = dr("Total").ToString()
                        lblAtivas.Text = dr("Ativas").ToString()
                        lblDesativadas.Text = dr("Desativadas").ToString()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar contadores:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CarregarFiltros()
        cmbFiltroTipo.Items.Clear()
        cmbFiltroTipo.Items.Add("Todos os tipos")
        cmbFiltroTipo.Items.Add("Admin")
        cmbFiltroTipo.Items.Add("Vendedor")
        cmbFiltroTipo.SelectedIndex = 0
        If cmbFiltroTipo.SelectedIndex > 0 Then
            SQL &= "AND TipoUsuario = @Tipo "
        End If

        cmbFiltroStatus.Items.Clear()
        cmbFiltroStatus.Items.Add("Todos os status")
        cmbFiltroStatus.Items.Add("Ativa")
        cmbFiltroStatus.Items.Add("Desativada")
        cmbFiltroStatus.SelectedIndex = 0
    End Sub

    Private Sub dgvUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsuarios.SelectionChanged
        If dgvUsuarios.SelectedRows.Count = 0 Then Return

        Dim row As DataGridViewRow = dgvUsuarios.SelectedRows(0)
        idUsuarioSelecionado = Convert.ToInt32(row.Cells(0).Value)
        statusAtualSelecionado = row.Cells(3).Value.ToString()

        ' Atualiza painel do usuário selecionado
        Dim nome As String = row.Cells(1).Value.ToString()
        Dim tipo As String = row.Cells(2).Value.ToString()
        Dim status As String = row.Cells(3).Value.ToString()

        lblNomeUsuario.Text = nome
        lblTipoStatus.Text = tipo & " · " & status

        ' Iniciais do nome
        Dim partes() As String = nome.Split(" ")
        If partes.Length >= 2 Then
            lblAvatar.Text = partes(0)(0) & partes(1)(0)
        Else
            lblAvatar.Text = nome(0)
        End If

        ' Atualiza botão conforme status
        If statusAtualSelecionado = "Ativa" Then
            btnToggleStatus.Text = "Desativar Conta"
            btnToggleStatus.BackColor = Color.FromArgb(180, 100, 0)
        Else
            btnToggleStatus.Text = "Ativar Conta"
            btnToggleStatus.BackColor = Color.FromArgb(0, 120, 50)
        End If
    End Sub

    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        If idUsuarioSelecionado = -1 Then
            MessageBox.Show("Selecione um usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim novoStatus As String = If(statusAtualSelecionado = "Ativa", "Desativada", "Ativa")
        Dim msg As String = If(novoStatus = "Desativada", "Deseja desativar esta conta?", "Deseja ativar esta conta?")

        If MessageBox.Show(msg, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Using cmd As New SqlCommand("UPDATE tb_usuarios SET Status = @Status WHERE id_usuario = @Id", conn)
                    cmd.Parameters.AddWithValue("@Status", novoStatus)
                    cmd.Parameters.AddWithValue("@Id", idUsuarioSelecionado)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Status atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            idUsuarioSelecionado = -1
            lblNomeUsuario.Text = "—"
            lblTipoStatus.Text = "—"
            lblAvatar.Text = "?"
            CarregarUsuarios()
            CarregarContadores()

        Catch ex As Exception
            MessageBox.Show("Erro:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If idUsuarioSelecionado = -1 Then
            MessageBox.Show("Selecione um usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Tem certeza que deseja excluir esta conta permanentemente? Esta ação não pode ser desfeita.",
                           "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Using cmd As New SqlCommand("DELETE FROM tb_usuarios WHERE id_usuario = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", idUsuarioSelecionado)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Conta excluída permanentemente!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            idUsuarioSelecionado = -1
            lblNomeUsuario.Text = "—"
            lblTipoStatus.Text = "—"
            lblAvatar.Text = "?"
            CarregarUsuarios()
            CarregarContadores()

        Catch ex As Exception
            MessageBox.Show("Erro:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNovoUsuario_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click, btnExcluir.Click, btnAtualizar.Click
        frm_dashboard.Show()
        Me.Close()
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        CarregarUsuarios()
        CarregarContadores()
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        CarregarUsuarios()
    End Sub

    Private Sub cmbFiltroTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroTipo.SelectedIndexChanged
        CarregarUsuarios()
    End Sub

    Private Sub cmbFiltroStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroStatus.SelectedIndexChanged
        CarregarUsuarios()
    End Sub


End Class
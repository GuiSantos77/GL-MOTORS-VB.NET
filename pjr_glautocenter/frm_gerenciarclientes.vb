Imports System.Data.SqlClient

Public Class frm_gerenciarclientes

    Private idClienteSelecionado As Integer = -1

    Dim conn As SqlConnection = ObterConexao()


    Private Sub frm_gerenciarclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGrid()
        CarregarClientes()
        txtCPF.Font = New System.Drawing.Font("Georgia", 12)
        txtNome.Font = New System.Drawing.Font("Georgia", 12)
        txtDataNascimento.Font = New System.Drawing.Font("Georgia", 12)
        txtTelefone.Font = New System.Drawing.Font("Georgia", 12)
        txtEmail.Font = New System.Drawing.Font("Georgia", 12)
    End Sub

    Private Sub ConfigurarGrid()
        dgvClientes.AutoGenerateColumns = False
        dgvClientes.Columns.Clear()
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClientes.MultiSelect = False
        dgvClientes.ReadOnly = True
        dgvClientes.AllowUserToAddRows = False
        dgvClientes.RowHeadersVisible = False
        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvClientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 40, 40)
        dgvClientes.DefaultCellStyle.SelectionForeColor = Color.Gold

        Dim colId As New DataGridViewTextBoxColumn()
        colId.DataPropertyName = "id_cliente"
        colId.Visible = False
        dgvClientes.Columns.Add(colId)

        Dim colCPF As New DataGridViewTextBoxColumn()
        colCPF.DataPropertyName = "cpf"
        colCPF.HeaderText = "CPF"
        colCPF.Width = 120
        dgvClientes.Columns.Add(colCPF)

        Dim colNome As New DataGridViewTextBoxColumn()
        colNome.DataPropertyName = "nome"
        colNome.HeaderText = "Nome Completo"
        colNome.Width = 180
        dgvClientes.Columns.Add(colNome)

        Dim colData As New DataGridViewTextBoxColumn()
        colData.DataPropertyName = "data_nasc"
        colData.HeaderText = "Nascimento"
        colData.Width = 100
        dgvClientes.Columns.Add(colData)

        Dim colTel As New DataGridViewTextBoxColumn()
        colTel.DataPropertyName = "fone"
        colTel.HeaderText = "Telefone"
        colTel.Width = 120
        dgvClientes.Columns.Add(colTel)

        Dim colEmail As New DataGridViewTextBoxColumn()
        colEmail.DataPropertyName = "email"
        colEmail.HeaderText = "E-mail"
        colEmail.Width = 160
        dgvClientes.Columns.Add(colEmail)
        dgvClientes.Font = New System.Drawing.Font("Georgia", 12)
    End Sub

    Private Sub CarregarClientes()
        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()

                Dim sql As String = "SELECT id_cliente, cpf, nome, data_nasc, fone, email FROM tb_clientes WHERE 1=1 "

                If Not String.IsNullOrWhiteSpace(txtBusca.Text) Then
                    sql &= "AND (nome LIKE @Busca OR cpf LIKE @Busca) "
                End If

                sql &= "ORDER BY nome"

                Using cmd As New SqlCommand(sql, conn)
                    If Not String.IsNullOrWhiteSpace(txtBusca.Text) Then
                        cmd.Parameters.AddWithValue("@Busca", "%" & txtBusca.Text.Trim() & "%")
                    End If

                    Dim dt As New DataTable()
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    dgvClientes.DataSource = dt
                    lblTotalClientes.Text = "Total: " & dt.Rows.Count & " clientes"
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar clientes:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.SelectedRows.Count = 0 Then Return

        Dim row As DataGridViewRow = dgvClientes.SelectedRows(0)
        idClienteSelecionado = Convert.ToInt32(row.Cells(0).Value)

        txtCPF.Text = row.Cells(1).Value.ToString()
        txtNome.Text = row.Cells(2).Value.ToString()

        If row.Cells(3).Value IsNot DBNull.Value Then
            txtDataNascimento.Text = row.Cells(3).Value.ToString()
        End If

        txtTelefone.Text = row.Cells(4).Value.ToString()
        txtEmail.Text = row.Cells(5).Value.ToString()
    End Sub

    Private Sub btnBuscarCPF_Click(sender As Object, e As EventArgs) Handles btnBuscarCPF.Click
        If String.IsNullOrWhiteSpace(txtCPF.Text) Then
            MessageBox.Show("Digite um CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Using cmd As New SqlCommand("SELECT id_cliente, cpf, nome, data_nasc, fone, email FROM tb_clientes WHERE cpf = @CPF", conn)
                    cmd.Parameters.AddWithValue("@CPF", txtCPF.Text.Trim())
                    Dim dr As SqlDataReader = cmd.ExecuteReader()

                    If dr.Read() Then
                        idClienteSelecionado = Convert.ToInt32(dr("id_cliente"))
                        txtNome.Text = dr("nome").ToString()
                        txtDataNascimento.Text = dr("data_nasc").ToString()
                        txtTelefone.Text = dr("fone").ToString()
                        txtEmail.Text = dr("email").ToString()
                        MessageBox.Show("Cliente encontrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Nenhum cliente encontrado com esse CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        LimparCampos()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao buscar cliente:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalvarEdicao_Click(sender As Object, e As EventArgs) Handles btnSalvarEdicao.Click
        If idClienteSelecionado = -1 Then
            MessageBox.Show("Selecione um cliente para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNome.Text) Then
            MessageBox.Show("Informe o nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Dim sql As String = "UPDATE tb_clientes SET nome = @Nome, data_nasc = @DataNasc, " &
                                    "fone = @Telefone, email = @Email WHERE id_cliente = @Id"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text.Trim())
                    cmd.Parameters.AddWithValue("@DataNasc", txtDataNascimento.Text.Trim())
                    cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Id", idClienteSelecionado)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparCampos()
            CarregarClientes()

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If idClienteSelecionado = -1 Then
            MessageBox.Show("Selecione um cliente para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Tem certeza que deseja excluir este cliente?",
                           "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

        Try
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Using cmd As New SqlCommand("DELETE FROM tb_clientes WHERE id_cliente = @Id", conn)
                    cmd.Parameters.AddWithValue("@Id", idClienteSelecionado)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparCampos()
            CarregarClientes()

        Catch ex As Exception
            MessageBox.Show("Erro ao excluir:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        CarregarClientes()
    End Sub

    Private Sub txtBusca_TextChanged(sender As Object, e As EventArgs) Handles txtBusca.TextChanged
        CarregarClientes()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparCampos()
    End Sub

    Private Sub LimparCampos()
        idClienteSelecionado = -1
        txtCPF.Text = ""
        txtNome.Text = ""
        txtDataNascimento.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""
        txtCPF.Focus()
    End Sub

End Class
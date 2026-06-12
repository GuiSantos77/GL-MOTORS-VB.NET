Imports System.Data.SqlClient

Public Class frm_cadclientes
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frm_cadclientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCPF.MaxLength = 14
        txtTelefone.MaxLength = 15
    End Sub

    Dim conn As SqlConnection = ObterConexao()

    Private Sub btnCadastrarCliente_Click(sender As Object, e As EventArgs) Handles btnCadastrarCliente.Click

        ' Validações
        If String.IsNullOrWhiteSpace(txtCPF.Text) Then
            MessageBox.Show("Informe o CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCPF.Focus() : Return
        End If

        If String.IsNullOrWhiteSpace(txtNome.Text) Then
            MessageBox.Show("Informe o nome completo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNome.Focus() : Return
        End If

        If String.IsNullOrWhiteSpace(txtDataNascimento.Text) Then
            MessageBox.Show("Informe a data de nascimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDataNascimento.Focus() : Return
        End If

        If String.IsNullOrWhiteSpace(txtTelefone.Text) Then
            MessageBox.Show("Informe o telefone.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelefone.Focus() : Return
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Informe o e-mail.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus() : Return
        End If

        Try
            ' Verifica se CPF já existe
            Using connVerifica As SqlConnection = ObterConexao()
                connVerifica.Open()
                Using cmdCheck As New SqlCommand("SELECT COUNT(*) FROM tb_clientes WHERE cpf = @CPF", connVerifica)
                    cmdCheck.Parameters.AddWithValue("@CPF", txtCPF.Text.Trim())
                    Dim existe As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If existe > 0 Then
                        MessageBox.Show("Já existe um cliente cadastrado com este CPF!", "CPF Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtCPF.Focus()
                        Return
                    End If
                End Using
            End Using

            ' Insere o cliente
            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Dim sql As String = "INSERT INTO tb_clientes (cpf, nome, data_nasc, fone, email) " &
                                    "VALUES (@cpf, @nome, @data_nasc, @fone, @email)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim())
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim())
                    cmd.Parameters.AddWithValue("@data_nasc", txtDataNascimento.Text.Trim())
                    cmd.Parameters.AddWithValue("@fone", txtTelefone.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparCampos()

        Catch ex As SqlException
            MessageBox.Show("Erro ao salvar no banco:" & Environment.NewLine & ex.Message,
                            "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Erro inesperado:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LimparCampos()
        txtCPF.Text = ""
        txtNome.Text = ""
        txtDataNascimento.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""
        txtCPF.Focus()
    End Sub

End Class
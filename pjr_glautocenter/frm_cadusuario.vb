Imports System.Data.SqlClient

Public Class frm_cadusuario

    Private Sub frm_cadusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UsuarioLogado_Tipo = "Vendedor" Then
            MessageBox.Show("Acesso negado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If

        cmbTipoConta.Items.Clear()
        cmbTipoConta.Items.Add("Vendedor")
        cmbTipoConta.Items.Add("Admin")
        cmbTipoConta.SelectedIndex = -1
    End Sub

    Dim conn As SqlConnection = ObterConexao()

    Private Sub btnCriarConta_Click(sender As Object, e As EventArgs) Handles btnCriarConta.Click

        If cmbTipoConta.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o tipo de conta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbTipoConta.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNome.Text) Then
            MessageBox.Show("Informe o nome do usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNome.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtSenha.Text) Then
            MessageBox.Show("Informe a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSenha.Focus()
            Return
        End If

        Dim tipoConta As String = cmbTipoConta.SelectedItem.ToString()
        Dim nome As String = txtNome.Text.Trim()
        Dim senha As String = txtSenha.Text.Trim()

        Try

            Using connVerifica As SqlConnection = ObterConexao()
                connVerifica.Open()
                Using cmdCheck As New SqlCommand("SELECT COUNT(*) FROM tb_usuarios WHERE Nome = @Nome", connVerifica)
                    cmdCheck.Parameters.AddWithValue("@Nome", nome)
                    Dim existe As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If existe > 0 Then
                        MessageBox.Show("Já existe um usuário cadastrado com este nome!", "Nome Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtNome.Focus()
                        Return
                    End If
                End Using
            End Using


            Using conn As SqlConnection = ObterConexao()
                conn.Open()
                Dim sql As String = "INSERT INTO tb_usuarios (TipoUsuario, Nome, Senha) VALUES (@TipoUsuario, @Nome, @Senha)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@TipoUsuario", tipoConta)
                    cmd.Parameters.AddWithValue("@Nome", nome)
                    cmd.Parameters.AddWithValue("@Senha", senha)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimparCampos()

        Catch ex As SqlException
            MessageBox.Show("Erro ao salvar no banco de dados:" & Environment.NewLine & ex.Message,
                            "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Erro inesperado:" & Environment.NewLine & ex.Message,
                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LimparCampos()
        cmbTipoConta.SelectedIndex = -1
        txtNome.Text = ""
        txtSenha.Text = ""
        cmbTipoConta.Focus()
    End Sub

End Class

Imports System.Data.SqlClient
Imports System.Windows

Public Class frm_login

    Public StrConnection = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pjr_glautocenter;Integrated Security=True;"

    Private Sub Login()

        If String.IsNullOrWhiteSpace(txt_usuario.Text) OrElse String.IsNullOrWhiteSpace(txt_senha.Text) Then
            MessageBox.Show("Preencha o usuário e a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using cn As New SqlConnection(StrConnection)
                cn.Open()

                ' Busca tipo e status do usuário
                Dim sql As String = "SELECT TipoUsuario, Status FROM tb_usuarios WHERE Nome=@Nome AND Senha=@Senha"

                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@Nome", txt_usuario.Text.Trim())
                    cmd.Parameters.AddWithValue("@Senha", txt_senha.Text.Trim())

                    Dim dr As SqlDataReader = cmd.ExecuteReader()

                    If dr.Read() Then
                        Dim tipoUsuario As String = dr("TipoUsuario").ToString()
                        Dim status As String = dr("Status").ToString()
                        dr.Close()

                        ' Verifica se a conta está bloqueada
                        If status = "Desativada" Then
                            MessageBox.Show("Sua conta foi bloqueada!" & Environment.NewLine &
                                        "Entre em contato com o administrador do sistema.",
                                        "Acesso Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If

                        ' Salva o usuário logado no módulo global
                        UsuarioLogado_Nome = txt_usuario.Text.Trim()
                        UsuarioLogado_Tipo = tipoUsuario

                        Me.Hide()

                        If UsuarioLogado_Tipo = "Admin" Then
                            Dim tela As New frm_dashboard
                            tela.ShowDialog()

                        ElseIf UsuarioLogado_Tipo = "Vendedor" Then
                            Dim tela As New frm_dashboard
                            tela.ShowDialog()

                        Else
                            MessageBox.Show("Tipo de usuário não reconhecido.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Show()
                            Return
                        End If

                        Me.Close()

                    Else
                        dr.Close()
                        MessageBox.Show("Usuário ou senha inválidos.", "Atenção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao conectar:" & Environment.NewLine & ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSairLogin_Click(sender As Object, e As EventArgs) Handles btnSairLogin.Click
        Application.Exit()
    End Sub

    Private Sub btnEntrarLogin_Click(sender As Object, e As EventArgs) Handles btnEntrarLogin.Click
        Login()
    End Sub

End Class
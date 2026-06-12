Imports System.Data.SqlClient

Module Module1
    Public diretorio, SQL, aux_cpf, resp, Nome, Tipo As String
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset


    Public UsuarioLogado_Nome As String = ""
    Public UsuarioLogado_Tipo As String = ""

    Public Function ObterConexao() As SqlConnection
        Return New SqlConnection("Server=(localdb)\MSSQLLocalDB;Database=pjr_glautocenter;Integrated Security=True;")
    End Function
    End Module

Imports System.Data.SqlClient

Public Class ManagerCliente
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaClientes As List(Of Cliente) = New List(Of Cliente)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getClientes() As List(Of Cliente)
        listaClientes = New List(Of Cliente)
        cmd = New SqlCommand("SELECT * FROM CLIENTES;", connectionDBManager)
        dr = cmd.ExecuteReader()

        Dim codigoNuevo As Integer
        Dim grupoNuevo As Integer
        Dim bancoNuevo As Integer
        Dim nombreNuevo As String
        Dim nifNuevo As String
        Dim direccionNueva As String
        Dim fechaNueva As Date
        Dim emailNuevo As String
        Dim clienteTemp As Cliente

        If dr.HasRows Then
            dr.Read()
            Do
                codigoNuevo = Convert.ToInt32(dr(0))
                grupoNuevo = Convert.ToInt32(dr(1))
                bancoNuevo = Convert.ToInt32(dr(2))
                nombreNuevo = dr(3).ToString().Trim()
                nifNuevo = dr(4).ToString().Trim()
                direccionNueva = dr(5).ToString().Trim()
                fechaNueva = Convert.ToDateTime(dr(6))
                emailNuevo = dr(7).ToString().Trim()

                clienteTemp = New Cliente(codigoNuevo, nombreNuevo, nifNuevo, direccionNueva, fechaNueva, bancoNuevo, grupoNuevo, emailNuevo)
                listaClientes.Add(clienteTemp)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaClientes
    End Function

    Public Sub addCliente(clientePasado As Cliente)
        Try
            Dim codigoNuevo As Integer = getIDCliente()
            cmd = New SqlCommand("INSERT INTO CLIENTES (ID_CLIENTE, ID_GRUPO, ID_BANCO, NOMBRE_CLIENTE, NIF_CLIENTE, DIRECCION_CLIENTE, FECHA_NACIMIENTO_CLIENTE, EMAIL_CLIENTE)
                            VALUES 
                            (@Codigo, 
                            @Grupo,
                            @Banco,
                            @Nombre, 
                            @Nif, 
                            @Direccion, 
                            @FechaNacimiento,
                            @Email);", connectionDBManager)
            With cmd.Parameters
                .Add("@Codigo", SqlDbType.Int).Value = codigoNuevo
                .Add("@Grupo", SqlDbType.Int).Value = clientePasado.GrupoDelCliente
                .Add("@Banco", SqlDbType.Int).Value = clientePasado.BancoDelCliente
                .Add("@Nombre", SqlDbType.Char, 100).Value = clientePasado.NombreDelCliente
                .Add("@Nif", SqlDbType.Char, 12).Value = clientePasado.NifDelCliente
                .Add("@Direccion", SqlDbType.Char, 150).Value = clientePasado.DireccionDelCliente
                .Add("@FechaNacimiento", SqlDbType.Date).Value = CDate(clientePasado.FechaDeNacimientoDelCliente.ToShortDateString)
                .Add("@Email", SqlDbType.Char, 100).Value = clientePasado.EmailDelCliente
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir un cliente: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyCliente(clientePasado As Cliente)
        cmd = New SqlCommand($"UPDATE CLIENTES
                            SET ID_GRUPO = @Grupo,
                            ID_BANCO = @Banco,
                            NOMBRE_CLIENTE = @Nombre,
                            NIF_CLIENTE = @Nif,
                            DIRECCION_CLIENTE = @Direccion, 
                            FECHA_NACIMIENTO_CLIENTE = @FechaNacimiento,                             
                            EMAIL_CLIENTE = @Email
                            WHERE ID_CLIENTE = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = clientePasado.CodigoDelCliente
            .Add("@Grupo", SqlDbType.Int).Value = clientePasado.GrupoDelCliente
            .Add("@Banco", SqlDbType.Int).Value = clientePasado.BancoDelCliente
            .Add("@Nombre", SqlDbType.Char, 100).Value = clientePasado.NombreDelCliente
            .Add("@Nif", SqlDbType.Char, 12).Value = clientePasado.NifDelCliente
            .Add("@Direccion", SqlDbType.Char, 150).Value = clientePasado.DireccionDelCliente
            .Add("@FechaNacimiento", SqlDbType.Date).Value = clientePasado.FechaDeNacimientoDelCliente
            .Add("@Email", SqlDbType.Char, 100).Value = clientePasado.EmailDelCliente
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al modificar un cliente: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteCliente(clientePasado As Cliente)
        Dim dr As DialogResult = MessageBox.Show("Se borrarán datos asociados al registro: compras y ventas, ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (dr = DialogResult.No) Then
            Return
        End If
        managerVentaAux.deleteVentaCliente(clientePasado.CodigoDelCliente)

        cmd = New SqlCommand("DELETE FROM CLIENTES WHERE ID_CLIENTE = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = clientePasado.CodigoDelCliente
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar un cliente: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteClienteGrupo(codigoGrupo As Integer)
        Dim listaCodigosCliente As List(Of Integer) = New List(Of Integer)
        cmd = New SqlCommand("SELECT ID_CLIENTE FROM CLIENTES WHERE ID_GRUPO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoGrupo
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Do
                listaCodigosCliente.Add(Convert.ToInt32(dr(0)))
            Loop While dr.Read()
        End If
        dr.Close()
        For Each numerillo As Integer In listaCodigosCliente
            managerVentaAux.deleteVentaCliente(numerillo)
        Next
        cmd = New SqlCommand("DELETE FROM CLIENTES WHERE ID_GRUPO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoGrupo
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar un cliente: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function getIDCliente() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_CLIENTE) FROM CLIENTES;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim codigoClienteNuevo As Integer = Nothing
        If maxActual IsNot DBNull.Value Then
            codigoClienteNuevo = Convert.ToInt32(maxActual) + 1
        Else
            codigoClienteNuevo = 0
        End If
        Return codigoClienteNuevo
    End Function
End Class
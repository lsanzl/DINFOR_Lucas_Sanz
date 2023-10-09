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
        listaClientes.Clear()
        cmd = New SqlCommand("SELECT * FROM CLIENTES;", connectionDBManager)
        dr = cmd.ExecuteReader()

        Dim codigoNuevo As String
        Dim nombreNuevo As String
        Dim nifNuevo As String
        Dim direccionNueva As String
        Dim fechaNueva As Date
        Dim bancoNuevo As String
        Dim grupoNuevo As String
        Dim emailNuevo As String
        Dim clienteTemp As Cliente

        If dr.HasRows Then
            dr.Read()
            Do
                codigoNuevo = dr(0).ToString()
                nombreNuevo = dr(1).ToString()
                nifNuevo = dr(2).ToString()
                direccionNueva = dr(3).ToString()
                fechaNueva = Convert.ToDateTime(dr(4))
                bancoNuevo = Convert.ToInt32(dr(5))
                grupoNuevo = Convert.ToInt32(dr(6))
                emailNuevo = dr(7).ToString()

                clienteTemp = New Cliente(codigoNuevo, nombreNuevo, nifNuevo, direccionNueva, fechaNueva, bancoNuevo, grupoNuevo, emailNuevo)
                listaClientes.Add(clienteTemp)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaClientes
    End Function

    Public Sub addCliente(clientePasado As Cliente)
        cmd = New SqlCommand($"INSERT INTO CLIENTES
                            VALUES ('{clientePasado.CodigoDelCliente}', 
                            '{clientePasado.NombreDelCliente}', 
                            '{clientePasado.NifDelCliente}', 
                            '{clientePasado.DireccionDelCliente}', 
                            '{clientePasado.FechaDeNacimientoDelCliente}', 
                            {clientePasado.BancoDelCliente},
                            {clientePasado.GrupoDelCliente}, 
                            '{clientePasado.EmailDelCliente}');", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Cliente creado")
        Else
            MessageBox.Show("Cliente no creado")
        End If
    End Sub
    Public Sub modifyCliente(clientePasado As Cliente)
        cmd = New SqlCommand($"UPDATE CLIENTES
                            SET NOMBRECLIENTE = '{clientePasado.NombreDelCliente}',
                            NIFCLIENTE = '{clientePasado.NifDelCliente}',
                            DIRECCIONCLIENTE = '{clientePasado.DireccionDelCliente}', 
                            FECHANACIMIENTOCLIENTE = {clientePasado.FechaDeNacimientoDelCliente}, 
                            BANCOCLIENTE = {clientePasado.BancoDelCliente},
                            GRUPOCLIENTE = {clientePasado.EmailDelCliente},
                            EMAILCLIENTE = '{clientePasado.EmailDelCliente}'
                            WHERE CODIGOCLIENTE = '{clientePasado.CodigoDelCliente}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Cliente modificado")
        Else
            MessageBox.Show("Cliente no modificado")
        End If
    End Sub
    Public Sub deleteCliente(clientePasado As Cliente)
        cmd = New SqlCommand($"DELETE FROM CLIENTES WHERE CODIGOCLIENTE = '{clientePasado.CodigoDelCliente}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Cliente eliminado")
        Else
            MessageBox.Show("Cliente no eliminado")
        End If
    End Sub
    Public Function checkCliente(codigoCliente As String) As Boolean
        cmd = New SqlCommand($"SELECT * FROM CLIENTES WHERE CODIGOCLIENTE = '{codigoCliente}';", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            Return True
        Else
            dr.Close()
            Return False
        End If
    End Function
End Class
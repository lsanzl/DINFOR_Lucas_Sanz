Imports System.Data.SqlClient

Public Class ManagerFactura
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaFacturas As List(Of Factura)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getFacturas() As List(Of Factura)
        listaFacturas = New List(Of Factura)
        cmd = New SqlCommand("SELECT * FROM FACTURAS;", connectionDBManager)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            Dim idFactura As Integer
            Dim listaAlbaranes As String
            Dim estado As String
            Dim fecha As DateTime
            Dim tipo As String
            dr.Read()
            Do
                idFactura = Convert.ToInt32(dr(0))
                listaAlbaranes = dr(1).ToString()
                estado = dr(2).ToString()
                fecha = CDate(dr(3))
                tipo = dr(4).ToString()

                Dim factura As Factura = New Factura(idFactura, listaAlbaranes, fecha, estado, tipo)
                listaFacturas.Add(factura)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaFacturas
    End Function

    Public Sub addFactura(f As Factura)
        Dim codigoNuevo As Integer = getIDFactura()
        cmd = New SqlCommand("INSERT INTO FACTURAS VALUES (@Codigo, @Albaranes, @Estado, @Fecha);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = codigoNuevo
            .Add("@Albaranes", SqlDbType.Char, 200).Value = f.StringDeAlbaranes
            .Add("@Estado", SqlDbType.Char, 1).Value = f.EstadoDeFactura
            .Add("@Fecha", SqlDbType.Date).Value = f.FechaDeCobro
            .Add("@Tipo", SqlDbType.Char, 1).Value = f.TipoDeFactura
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaFacturas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub modifyFactura(f As Factura)
        cmd = New SqlCommand("UPDATE FACTURAS SET
                            ALBARANES_FACTURA = @Albaranes,
                            ESTADO_FACTURA = @Estado,
                            FECHA_FACTURA = @Fecha,
                            TIPO_FACTURA = @Tipo
                            WHERE ID_FACTURA = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = f.CodigoDeFactura
            .Add("@Albaranes", SqlDbType.Char, 200).Value = f.StringDeAlbaranes
            .Add("@Estado", SqlDbType.Char, 1).Value = f.EstadoDeFactura
            .Add("@Fecha", SqlDbType.Date).Value = f.FechaDeCobro
            .Add("@Tipo", SqlDbType.Char, 1).Value = f.TipoDeFactura
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaFacturas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteFactura(f As Factura)
        cmd = New SqlCommand("DELETE FROM FACTURAS WHERE ID_FACTURA = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = f.CodigoDeFactura
        Try
            cmd.ExecuteNonQuery()
            updateListaFacturas()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Function getIDFactura() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_FACTURA) FROM FACTURAS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim idMax As Integer = 0
        If maxActual IsNot DBNull.Value Then
            idMax = Convert.ToInt32(maxActual) + 1
        End If
        Return idMax
    End Function
End Class
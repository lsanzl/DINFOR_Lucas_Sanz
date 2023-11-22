Imports System.Data.SqlClient

Public Class ManagerVencimiento
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaVencimientos As List(Of Vencimiento) = New List(Of Vencimiento)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getVencimientos() As List(Of Vencimiento)
        listaVencimientos = New List(Of Vencimiento)
        cmd = New SqlCommand("SELECT * FROM VENCIMIENTOS;", connectionDBManager)
        dr = cmd.ExecuteReader()

        Dim codigoNuevo As Integer
        Dim codigoFactura As Integer
        Dim tipoEntidad As String
        Dim clienteInt As Integer
        Dim cliente As Cliente
        Dim proveedorInt As Integer
        Dim proveedor As Proveedor
        Dim formaPagoInt As Integer
        Dim formaPago As FormaPago
        Dim numPlazos As Integer
        Dim plazoActual As Integer
        Dim importe As Double
        Dim fecha As Date
        Dim estado As Integer
        Dim importePagado As Double
        Dim vencimientoTemp As Vencimiento

        If dr.HasRows Then
            dr.Read()
            Do
                codigoNuevo = Convert.ToInt32(dr(0))
                codigoFactura = Convert.ToInt32(dr(1))
                tipoEntidad = dr(2).ToString().Trim()
                If tipoEntidad.Equals("C") Then
                    clienteInt = Convert.ToInt32(dr(3))
                    cliente = getClientePorCodigo(clienteInt)
                Else
                    proveedorInt = Convert.ToInt32(dr(4))
                    proveedor = getProveedorPorCodigo(proveedorInt)
                End If
                formaPagoInt = Convert.ToInt32(dr(5))
                formaPago = getFormaPagoPorCodigo(formaPagoInt)
                numPlazos = Convert.ToInt32(dr(6))
                plazoActual = Convert.ToInt32(dr(7))
                importe = Math.Round(Convert.ToDouble(dr(8)), 2)
                fecha = Convert.ToDateTime(dr(9))
                estado = Convert.ToInt32(dr(10))
                importePagado = Math.Round(Convert.ToDouble(dr(11)), 2)

                If tipoEntidad.Equals("C") Then
                    vencimientoTemp = New Vencimiento(codigoNuevo, codigoFactura, cliente, formaPago, numPlazos, plazoActual, importe, fecha, estado, importePagado)
                Else
                    vencimientoTemp = New Vencimiento(codigoNuevo, codigoFactura, proveedor, formaPago, numPlazos, plazoActual, importe, fecha, estado, importePagado)
                End If
                listaVencimientos.Add(vencimientoTemp)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaVencimientos
    End Function
    Public Sub addVencimiento(v As Vencimiento)
        Dim codigoNuevo As Integer = getIDVencimiento()
        Dim cliente As Integer = 0
        Dim proveedor As Integer = 0
        If v.TipoDeEntidad.Equals("C") Then
            cliente = v.ClienteDeVencimiento.CodigoDelCliente
        Else
            proveedor = v.ProveedorDeVencimiento.CodigoDeProveedor
        End If
        cmd = New SqlCommand("INSERT INTO VENCIMIENTOS VALUES 
                            (@Codigo,
                            @Factura,
                            @Tipo,
                            @Cliente,
                            @Proveedor, 
                            @FormaPago, 
                            @NumPlazos, 
                            @PlazoActual,
                            @Importe,
                            @Fecha,
                            @Estado,
                            @ImportePagado);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = codigoNuevo
            .Add("@Factura", SqlDbType.Int).Value = v.CodigoDeFactura
            .Add("@Tipo", SqlDbType.Char).Value = v.TipoDeEntidad
            .Add("@Cliente", SqlDbType.Int).Value = cliente
            .Add("@Proveedor", SqlDbType.Int).Value = proveedor
            .Add("@FormaPago", SqlDbType.Int).Value = v.FormaPagoDeVencimiento.CodigoDePago
            .Add("@NumPlazos", SqlDbType.Int).Value = v.PlazosDeVencimiento
            .Add("@PlazoActual", SqlDbType.Int).Value = v.PlazoActualDeVencimiento
            .Add("@Importe", SqlDbType.Decimal, 12, 2).Value = v.ImporteDeVencimiento
            .Add("@Fecha", SqlDbType.Date).Value = v.FechaDeVencimiento
            .Add("@Estado", SqlDbType.Int).Value = v.EstadoDeVencimiento
            .Add("@ImportePagado", SqlDbType.Decimal, 12, 2).Value = v.ImportePagado
        End With

        Try
            cmd.ExecuteNonQuery()
            updateListaVencimientos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub modifyVencimiento(v As Vencimiento)
        Dim cliente As Integer = 0
        Dim proveedor As Integer = 0
        If v.TipoDeEntidad.Equals("C") Then
            cliente = v.ClienteDeVencimiento.CodigoDelCliente
        Else
            proveedor = v.ProveedorDeVencimiento.CodigoDeProveedor
        End If

        cmd = New SqlCommand("UPDATE VENCIMIENTOS SET  
                            TIPO_ENTIDAD_VENCIMIENTO = @Tipo,
                            CLIENTE_VENCIMIENTO = @Cliente,
                            PROVEEDOR_VENCIMIENTO = @Proveedor, 
                            FORMA_PAGO_VENCIMIENTO = @FormaPago, 
                            PLAZOS_VENCIMIENTO = @NumPlazos, 
                            PLAZO_ACTUAL_VENCIMIENTO = @PlazoActual,
                            IMPORTE_VENCIMIENTO = @Importe,
                            FECHA_VENCIMIENTO = @Fecha,
                            ESTADO_VENCIMIENTO = @Estado,
                            IMPORTE_PAGADO_VENCIMIENTO = @ImportePagado
                            WHERE ID_VENCIMIENTO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = v.CodigoDeVencimiento
            .Add("@Tipo", SqlDbType.Char).Value = v.TipoDeEntidad
            .Add("@Cliente", SqlDbType.Int).Value = cliente
            .Add("@Proveedor", SqlDbType.Int).Value = proveedor
            .Add("@FormaPago", SqlDbType.Int).Value = v.FormaPagoDeVencimiento.CodigoDePago
            .Add("@NumPlazos", SqlDbType.Int).Value = v.PlazosDeVencimiento
            .Add("@PlazoActual", SqlDbType.Int).Value = v.PlazoActualDeVencimiento
            .Add("@Importe", SqlDbType.Decimal, 12, 2).Value = v.ImporteDeVencimiento
            .Add("@Fecha", SqlDbType.Date).Value = v.FechaDeVencimiento
            .Add("@Estado", SqlDbType.Int).Value = v.EstadoDeVencimiento
            .Add("@ImportePagado", SqlDbType.Decimal, 12, 2).Value = v.ImportePagado
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaVencimientos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteVencimiento(v As Vencimiento)
        cmd = New SqlCommand("DELETE FROM VENCIMIENTOS WHERE ID_VENCIMIENTO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = v.CodigoDeVencimiento
        Try
            cmd.ExecuteNonQuery()
            updateListaVencimientos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub cobrarVencimiento(v As Vencimiento)
        Dim estado As Integer = 0
        If v.ImportePagado = v.ImporteDeVencimiento Then
            estado = 1
        End If
        cmd = New SqlCommand("UPDATE VENCIMIENTOS SET 
                                ESTADO_VENCIMIENTO = @Estado,
                                IMPORTE_PAGADO_VENCIMIENTO = @ImportePagado
                                WHERE ID_VENCIMIENTO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = v.CodigoDeVencimiento
            .Add("@Estado", SqlDbType.Int).Value = estado
            .Add("@ImportePagado", SqlDbType.Decimal, 12, 2).Value = v.ImportePagado
        End With
        Try
            cmd.ExecuteNonQuery()
            updateListaVencimientos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Function getIDVencimiento() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_VENCIMIENTO) FROM VENCIMIENTOS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar()
        Dim idMax As Integer = 0
        If maxActual IsNot DBNull.Value Then
            idMax = Convert.ToInt32(maxActual) + 1
        End If
        Return idMax
    End Function
End Class
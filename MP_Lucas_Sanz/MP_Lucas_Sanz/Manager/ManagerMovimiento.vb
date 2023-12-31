﻿Imports System.Data.SqlClient

Public Class ManagerMovimiento
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaMovimientos As List(Of Movimiento) = New List(Of Movimiento)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getMovimientos() As List(Of Movimiento)
        listaMovimientos = New List(Of Movimiento)
        cmd = New SqlCommand("SELECT * FROM MOVIMIENTOS;", connectionDBManager)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Dim codigoMovimiento As Integer
            Dim clienteMovimiento As Integer
            Dim proveedorMovimiento As Integer
            Dim articuloMovimiento As Integer
            Dim cantidadMovimiento As Integer
            Dim tipoMovimiento As String
            Dim facturaMovimiento As String
            Dim fechaMovimiento As Date
            Dim stockMovimiento As Integer
            Dim movimientoTemp As Movimiento
            Dim usuarioMovimiento As Integer

            dr.Read()
            Do
                codigoMovimiento = Convert.ToInt32(dr(0))
                clienteMovimiento = Convert.ToInt32(dr(1))
                proveedorMovimiento = Convert.ToInt32(dr(2))
                articuloMovimiento = Convert.ToInt32(dr(3))
                cantidadMovimiento = Convert.ToInt32(dr(4))
                tipoMovimiento = dr(5).ToString()
                facturaMovimiento = dr(6).ToString()
                fechaMovimiento = CDate(dr(7))
                stockMovimiento = Convert.ToInt32(dr(8))

                If tipoMovimiento.Equals("V") Then
                    usuarioMovimiento = clienteMovimiento
                ElseIf tipoMovimiento.Equals("C") Then
                    usuarioMovimiento = proveedorMovimiento
                Else
                    usuarioMovimiento = 0
                End If

                movimientoTemp = New Movimiento(codigoMovimiento, tipoMovimiento, facturaMovimiento, usuarioMovimiento, fechaMovimiento, cantidadMovimiento, articuloMovimiento, stockMovimiento)
                listaMovimientos.Add(movimientoTemp)
            Loop While dr.Read()
            dr.Close()
        End If
        dr.Close()
        Return listaMovimientos
    End Function
    Public Sub addMovimiento(movimientoTemp As Movimiento)
        Dim codigoNuevo As Integer = getIDMovimiento()
        cmd = New SqlCommand("INSERT INTO MOVIMIENTOS VALUES(
                                @ID,
                                @Cliente,
                                @Proveedor,
                                @Articulo,
                                @Cantidad,
                                @Tipo,
                                @Factura,
                                @Fecha,
                                @Stock);", connectionDBManager)
        With cmd.Parameters
            .Add("@ID", SqlDbType.Int).Value = codigoNuevo
            .Add("@Cliente", SqlDbType.Int).Value = movimientoTemp.ClienteDeMovimiento
            .Add("@Proveedor", SqlDbType.Int).Value = movimientoTemp.ProveedorDeMovimiento
            .Add("@Articulo", SqlDbType.Int).Value = movimientoTemp.ArticuloDeMovimiento
            .Add("@Cantidad", SqlDbType.Int).Value = movimientoTemp.CantidadDeMovimiento
            .Add("@Tipo", SqlDbType.Char, 1).Value = movimientoTemp.TipoDeMovimiento
            .Add("@Factura", SqlDbType.Char, 10).Value = movimientoTemp.FacturaDeMovimiento
            .Add("@Fecha", SqlDbType.Date).Value = movimientoTemp.FechaDeMovimiento
            .Add("@Stock", SqlDbType.Int).Value = movimientoTemp.StockActualDeMovimiento
        End With
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaMovimientos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub modifyMovimiento(movimientoTemp As Movimiento)
        cmd = New SqlCommand("UPDATE MOVIMIENTOS SET(
                                ID_CLIENTE = @Cliente,
                                ID_PROVEEDOR = @Proveedor,
                                ID_ARTICULO = @Articulo,
                                CANTIDAD_MOVIMIENTO = @Cantidad,
                                TIPO_MOVIMIENTO = @Tipo,
                                FACTURA_MOVIMIENTO = @Factura,
                                FECHA_MOVIMIENTO = @Fecha,
                                STOCK_MOVIMIENTO = @Stock
                                WHERE ID_MOVIMIENTO = @Codigo);", connectionDBManager)
        With cmd.Parameters
            .Add("@ID", SqlDbType.Int).Value = movimientoTemp.CodigoDeMovimiento
            .Add("@Cliente", SqlDbType.Int).Value = movimientoTemp.ClienteDeMovimiento
            .Add("@Proveedor", SqlDbType.Int).Value = movimientoTemp.ProveedorDeMovimiento
            .Add("@Articulo", SqlDbType.Int).Value = movimientoTemp.ArticuloDeMovimiento
            .Add("@Cantidad", SqlDbType.Int).Value = movimientoTemp.CantidadDeMovimiento
            .Add("@Tipo", SqlDbType.Char, 1).Value = movimientoTemp.TipoDeMovimiento
            .Add("@Factura", SqlDbType.Char, 10).Value = movimientoTemp.FacturaDeMovimiento
            .Add("@Fecha", SqlDbType.Date).Value = movimientoTemp.FechaDeMovimiento
            .Add("@Stock", SqlDbType.Int).Value = movimientoTemp.StockActualDeMovimiento
        End With
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaMovimientos()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteMovimiento(movimientoTemp As Movimiento)
        cmd = New SqlCommand("DELETE FROM MOVIMIENTOS WHERE ID_MOVIMIENTO = @Codigo", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = movimientoTemp.CodigoDeMovimiento
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub reajustarStock(movimiento As Movimiento, cantidad As Integer, cantidadNueva As Integer)
        cmd = New SqlCommand("UPDATE MOVIMIENTOS SET 
                            STOCK_MOVIMIENTO = STOCK_MOVIMIENTO + @Cantidad
                            WHERE FECHA_MOVIMIENTO >= @Fecha
                            AND ID_ARTICULO = @Articulo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Cantidad", SqlDbType.Int).Value = cantidad
            .Add("@Fecha", SqlDbType.Date).Value = movimiento.FechaDeMovimiento
            .Add("@Articulo", SqlDbType.Int).Value = movimiento.ArticuloDeMovimiento
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar unidades:" + vbCrLf + ex.ToString())
        End Try
        cmd = New SqlCommand("UPDATE MOVIMIENTOS SET
                            CANTIDAD_MOVIMIENTO = @Cantidad
                            WHERE ID_MOVIMIENTO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Cantidad", SqlDbType.Int).Value = cantidadNueva
            .Add("@Codigo", SqlDbType.Int).Value = movimiento.CodigoDeMovimiento
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al actualizar unidades:" + vbCrLf + ex.ToString())
        End Try
        VariablesGlobales.updateListaMovimientos()
    End Sub
    Public Function getIDMovimiento() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_MOVIMIENTO) FROM MOVIMIENTOS;", connectionDBManager)
        Dim codigoNuevo As Integer = 0
        Try
            Dim maxActual As Object = cmd.ExecuteScalar
            If maxActual IsNot DBNull.Value Then
                codigoNuevo = Convert.ToInt32(maxActual) + 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return codigoNuevo
    End Function
End Class
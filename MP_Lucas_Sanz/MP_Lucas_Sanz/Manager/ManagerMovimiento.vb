Imports System.Data.SqlClient

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
            Dim tipoMovimiento As Char
            Dim facturaMovimiento As Integer
            Dim usuarioMovimiento As Integer
            Dim fechaMovimiento As Date
            Dim articuloMovimiento As Integer
            Dim stockMovimiento As Integer
            Dim movimientoTemp As Movimiento

            dr.Read()
            Do
                codigoMovimiento = Convert.ToInt32(dr(0))
                tipoMovimiento = dr(1).ToString()
                facturaMovimiento = Convert.ToInt32(dr(2))
                usuarioMovimiento = Convert.ToInt32(dr(3))
                fechaMovimiento = CDate(dr(4))
                articuloMovimiento = Convert.ToInt32(dr(5))
                stockMovimiento = Convert.ToInt32(dr(6))

                movimientoTemp = New Movimiento(codigoMovimiento, tipoMovimiento, facturaMovimiento, usuarioMovimiento, fechaMovimiento, articuloMovimiento, stockMovimiento)
                listaMovimientos.Add(movimientoTemp)
            Loop While dr.Read()
            dr.Close()
        End If
        dr.Close()
        Return listaMovimientos
    End Function
    Public Sub addMovimiento(movimientoTemp As Movimiento)

    End Sub
    Public Sub modifyMovimiento(movimientoTemp As Movimiento)

    End Sub
    Public Sub deleteMovimiento(movimientoTemp As Movimiento)

    End Sub
    Public Function getIDMovimiento() As Integer
        cmd = New SqlCommand("SELECT MAX(ID_MOVIMIENTO) FROM MOVIMIENTOS;", connectionDBManager)
        Dim maxActual As Object = cmd.ExecuteScalar
        Dim codigoNuevo As Integer
        If maxActual IsNot DBNull.Value Then
            codigoNuevo = Convert.ToInt32(maxActual) + 1
        Else
            codigoNuevo = 0
        End If
        Return codigoNuevo
    End Function
End Class
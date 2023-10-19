Imports System.Data.SqlClient
Imports MP_Lucas_Sanz.VariablesGlobales

Public Class ManagerFormaPago
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaFormaPagos As List(Of FormaPago) = New List(Of FormaPago)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getFormaPagos() As List(Of FormaPago)
        listaFormaPagos = New List(Of FormaPago)
        cmd = New SqlCommand("SELECT * FROM FORMASPAGO;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                Dim codigoPago As String = dr(0).ToString().Trim()
                Dim nombrePago As String = dr(1).ToString().Trim()
                Dim bancoAsignadoPago As Integer = Convert.ToInt32(dr(2))
                Dim estadoPago As Integer = Convert.ToInt32(dr(3))
                Dim numPlazosPago As Integer = Convert.ToInt32(dr(4))
                Dim diasPrimerPlazo As Integer = Convert.ToInt32(dr(5))
                Dim diasEntrePlazos As Integer = Convert.ToInt32(dr(6))

                formaPagoAux = New FormaPago(codigoPago, nombrePago, bancoAsignadoPago, estadoPago, numPlazosPago, diasPrimerPlazo, diasEntrePlazos)
                listaFormaPagos.Add(formaPagoAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaFormaPagos
    End Function
    Public Sub addFormaPago(formaPagoSQL As FormaPago)
        cmd = New SqlCommand("INSERT INTO FORMASPAGO
                            VALUES (@Codigo,
                                    @Nombre,
                                    @Banco,
                                    @Activo,
                                    @PrimerPlazo,
                                    @NumerosPlazo,
                                    @DiasPlazos);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Char, 5).Value = formaPagoSQL.CodigoDePago
            .Add("@Nombre", SqlDbType.Char, 100).Value = formaPagoSQL.NombreDePago
            .Add("@Banco", SqlDbType.Int).Value = formaPagoSQL.BancoAsignado
            .Add("@Activo", SqlDbType.Int).Value = formaPagoSQL.Activo
            .Add("@PrimerPlazo", SqlDbType.Int).Value = formaPagoSQL.PrimerPlazo
            .Add("@NumerosPlazo", SqlDbType.Int).Value = formaPagoSQL.NumeroPlazosPago
            .Add("@DiasPlazos", SqlDbType.Int).Value = formaPagoSQL.DiasPlazos
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir una forma de pago: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyFormaPago(formaPagoSQL As FormaPago)
        cmd = New SqlCommand("UPDATE FORMASPAGO
                    SET NOMBREFORMAPAGO= @Nombre,
                    BANCO= @Banco,
                    ESTADO= @Activo,
                    NUMEROPLAZOS= @NumerosPlazo,
                    PRIMERPLAZO= @PrimerPlazo,
                    DIASENTREPLAZOS= @DiasPlazos
                    WHERE CODIGOPAGO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Char, 5).Value = formaPagoSQL.CodigoDePago
            .Add("@Nombre", SqlDbType.Char, 100).Value = formaPagoSQL.NombreDePago
            .Add("@Banco", SqlDbType.Int).Value = formaPagoSQL.BancoAsignado
            .Add("@Activo", SqlDbType.Int).Value = formaPagoSQL.Activo
            .Add("@PrimerPlazo", SqlDbType.Int).Value = formaPagoSQL.PrimerPlazo
            .Add("@NumerosPlazo", SqlDbType.Int).Value = formaPagoSQL.NumeroPlazosPago
            .Add("@DiasPlazos", SqlDbType.Int).Value = formaPagoSQL.DiasPlazos
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al modificar una forma de pago: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteFormaPago(formaPagoSQL As FormaPago)
        cmd = New SqlCommand("DELETE FROM FORMASPAGO
                                WHERE CODIGOPAGO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Char, 5).Value = formaPagoSQL.CodigoDePago
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar una forma de pago: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub changeEstado(formaPagoSql As FormaPago)
        cmd = New SqlCommand("UPDATE FORMASPAGO
                                SET ESTADO = @Activo
                                WHERE CODIGOPAGO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Char, 5).Value = formaPagoSql.CodigoDePago
            .Add("@Activo", SqlDbType.Int).Value = formaPagoSql.Activo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al cambiar el estado de una forma de pago: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function checkFormaPago(codigoForma As String)
        cmd = New SqlCommand("SELECT * FROM FORMASPAGO
                            WHERE CODIGOPAGO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Char, 5).Value = codigoForma
        dr = cmd.ExecuteReader()
        If Not dr.HasRows() Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function
End Class
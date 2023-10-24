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
                Dim codigoPago As String = Convert.ToInt32(dr(0))
                Dim bancoAsignadoPago As Integer = Convert.ToInt32(dr(1))
                Dim nombrePago As String = dr(2).ToString().Trim()
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
                                    @Banco,
                                    @Nombre,
                                    @Activo,
                                    @NumerosPlazo,
                                    @PrimerPlazo,
                                    @DiasPlazos);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = formaPagoSQL.CodigoDePago
            .Add("@Banco", SqlDbType.Int).Value = formaPagoSQL.BancoAsignado
            .Add("@Nombre", SqlDbType.Char, 100).Value = formaPagoSQL.NombreDePago
            .Add("@Activo", SqlDbType.Int).Value = formaPagoSQL.Activo
            .Add("@NumerosPlazo", SqlDbType.Int).Value = formaPagoSQL.NumeroPlazosPago
            .Add("@PrimerPlazo", SqlDbType.Int).Value = formaPagoSQL.PrimerPlazo
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
                    SET NOMBRE_FORMA_PAGO= @Nombre,
                    ID_BANCO= @Banco,
                    ESTADO= @Activo,
                    NUMERO_PLAZOS= @NumerosPlazo,
                    DIAS_PRIMER_PLAZO= @PrimerPlazo,
                    DIAS_ENTRE_PLAZOS= @DiasPlazos
                    WHERE ID_FORMA_PAGO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = formaPagoSQL.CodigoDePago
            .Add("@Banco", SqlDbType.Int).Value = formaPagoSQL.BancoAsignado
            .Add("@Nombre", SqlDbType.Char, 100).Value = formaPagoSQL.NombreDePago
            .Add("@Activo", SqlDbType.Int).Value = formaPagoSQL.Activo
            .Add("@NumerosPlazo", SqlDbType.Int).Value = formaPagoSQL.NumeroPlazosPago
            .Add("@PrimerPlazo", SqlDbType.Int).Value = formaPagoSQL.PrimerPlazo
            .Add("@DiasPlazos", SqlDbType.Int).Value = formaPagoSQL.DiasPlazos
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al modificar una forma de pago: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteFormaPago(formaPagoSQL As FormaPago)
        Dim dr As DialogResult = MessageBox.Show("Se borrarán datos asociados al registro: compras y ventas, ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If (dr = DialogResult.No) Then
            Return
        End If
        managerCompraAux.deleteCompraFormaPago(formaPagoSQL.CodigoDePago)
        managerVentaAux.deleteVentaFormaPago(formaPagoSQL.CodigoDePago)

        cmd = New SqlCommand("DELETE FROM FORMASPAGO
                                WHERE ID_FORMA_PAGO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = formaPagoSQL.CodigoDePago
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar una forma de pago: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteFormaPagoBanco(codigoBanco As Integer)
        Dim listaCodigosFormasPago As List(Of Integer) = New List(Of Integer)
        cmd = New SqlCommand("SELECT ID_FORMA_PAGO FROM FORMASPAGO WHERE ID_BANCO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoBanco
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Do
                listaCodigosFormasPago.Add(Convert.ToInt32(dr(0)))
            Loop While dr.Read()
        End If
        dr.Close()
        For Each numerillo As Integer In listaCodigosFormasPago
            managerVentaAux.deleteVentaFormaPago(numerillo)
            managerCompraAux.deleteCompraFormaPago(numerillo)
        Next
        cmd = New SqlCommand("DELETE FROM FORMASPAGO WHERE ID_BANCO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoBanco
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar una forma de pago: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub changeEstado(formaPagoSql As FormaPago)
        cmd = New SqlCommand("UPDATE FORMASPAGO
                                SET ESTADO = @Activo
                                WHERE ID_FORMA_PAGO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = formaPagoSql.CodigoDePago
            .Add("@Activo", SqlDbType.Int).Value = formaPagoSql.Activo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al cambiar el estado de una forma de pago: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function checkFormaPago(codigoForma As Integer)
        cmd = New SqlCommand("SELECT * FROM FORMASPAGO
                            WHERE ID_FORMA_PAGO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoForma
        dr = cmd.ExecuteReader()
        If Not dr.HasRows() Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function
End Class
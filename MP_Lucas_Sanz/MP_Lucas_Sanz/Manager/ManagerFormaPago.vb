Imports System.Data.SqlClient
Imports MP_Lucas_Sanz.VariablesGlobales

Public Class ManagerFormaPago
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaFormaPagos As List(Of FormaPago) = New List(Of FormaPago)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getFormaPagos() As List(Of FormaPago)
        listaFormaPagos = New List(Of FormaPago)
        cmd = New SqlCommand("SELECT CODIGOPAGO, NOMBREFORMAPAGO, BANCO, 
                            ESTADO, NUMEROPLAZOS, PRIMERPLAZO, DIASENTREPLAZOS FROM FORMASPAGO;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                Dim codigoPago As String = dr(0).ToString()
                Dim nombrePago As String = dr(1).ToString()
                Dim bancoAsignadoPago As Integer = Integer.Parse(dr(2).ToString())
                Dim estadoPago As Integer = Convert.ToInt32(dr(3))
                Dim numPlazosPago As Integer = Integer.Parse(dr(4).ToString())
                Dim diasPrimerPlazo As Integer = Integer.Parse(dr(5).ToString())
                Dim diasEntrePlazos As Integer = Integer.Parse(dr(6).ToString())

                formaPagoAux = New FormaPago(codigoPago, nombrePago, bancoAsignadoPago, estadoPago, numPlazosPago, diasPrimerPlazo, diasEntrePlazos)
                listaFormaPagos.Add(formaPagoAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaFormaPagos
    End Function

    Public Sub addFormaPago(formaPagoSQL As FormaPago)
        cmd = New SqlCommand($"INSERT INTO FORMASPAGO
                            VALUES ('{formaPagoSQL.CodigoDePago}', '{formaPagoSQL.NombreDePago}',
                                    {formaPagoSQL.BancoAsignado}, {formaPagoSQL.Activo}, {formaPagoSQL.PrimerPlazo},
                                    {formaPagoSQL.NumeroPlazosPago}, {formaPagoSQL.DiasPlazos});", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Forma de Pago introducida")
        Else
            MessageBox.Show("Forma de Pago no introducida")
        End If
    End Sub

    Public Sub modifyFormaPago(formaPagoSQL As FormaPago)
        cmd = New SqlCommand($"UPDATE FORMASPAGO
                    SET NOMBREFORMAPAGO='{formaPagoSQL.NombreDePago}',
                    BANCO={formaPagoSQL.BancoAsignado},
                    ESTADO={formaPagoSQL.Activo},
                    NUMEROPLAZOS={formaPagoSQL.NumeroPlazosPago},
                    PRIMERPLAZO={formaPagoSQL.PrimerPlazo},
                    DIASENTREPLAZOS={formaPagoSQL.DiasPlazos}
                    WHERE CODIGOPAGO = '{formaPagoSQL.CodigoDePago}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Forma de Pago modificada")
        Else
            MessageBox.Show("Forma de Pago no modificada")
        End If
    End Sub

    Public Sub deleteFormaPago(formaPagoSQL As FormaPago)
        cmd = New SqlCommand($"DELETE FROM FORMASPAGO
                                WHERE CODIGOPAGO = '{formaPagoSQL.CodigoDePago}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Forma de Pago eliminada")
        Else
            MessageBox.Show("Forma de Pago no eliminada")
        End If
    End Sub

    Public Sub changeEstado(formaPagoSql As FormaPago)
        cmd = New SqlCommand($"UPDATE FORMASPAGO
                                SET ESTADO = {formaPagoSql.Activo}
                                WHERE CODIGOPAGO = '{formaPagoSql.CodigoDePago}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Estado modificado")
        Else
            MessageBox.Show("Estado no modificado")
        End If
    End Sub

    Public Function checkFormaPago(codigoForma As String)
        cmd = New SqlCommand($"SELECT * FROM FORMASPAGO
                            WHERE CODIGOPAGO = '{codigoForma}';", connectionDBManager)
        dr = cmd.ExecuteReader()
        If Not dr.HasRows() Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function

End Class
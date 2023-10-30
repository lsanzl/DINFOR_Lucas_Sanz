Imports System.Data.SqlClient

Public Class ManagerImpuesto
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaImpuestos As List(Of Impuesto) = New List(Of Impuesto)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getImpuestos() As List(Of Impuesto)
        listaImpuestos = New List(Of Impuesto)
        cmd = New SqlCommand("SELECT * FROM IMPUESTOS;", connectionDBManager)
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Dim idImpuesto As Integer
                Dim impuesto As Double
                dr.Read()
                Do
                    idImpuesto = Convert.ToInt32(dr(0))
                    impuesto = Convert.ToDouble(dr(1))

                    impuestoAux = New Impuesto(idImpuesto, impuesto)
                    listaImpuestos.Add(impuestoAux)
                Loop While dr.Read()
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return listaImpuestos
    End Function
    Public Sub addImpuesto(impuesto As Impuesto)
        Dim codigoNuevo As Integer = getIDImpuesto()
        cmd = New SqlCommand("INSERT INTO IMPUESTOS VALUES(
                            @Codigo,
                            @Impuesto);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = codigoNuevo
            .Add("@Impuesto", SqlDbType.Decimal, 5, 2).Value = impuesto.CantidadImpuesto
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Sub deleteImpuesto(impuesto As Impuesto)
        cmd = New SqlCommand("DELETE FROM IMPUESTOS WHERE
                            ID_IMPUESTO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = impuesto.CodigoDeImpuesto
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Public Function getIDImpuesto() As Integer
        Dim idMax As Integer = 0
        cmd = New SqlCommand("SELECT MAX(ID_IMPUESTO) FROM IMPUESTOS;", connectionDBManager)
        Dim objMax As Object = cmd.ExecuteScalar
        If objMax IsNot DBNull.Value Then
            idMax = Convert.ToInt32(objMax) + 1
        End If
        Return idMax
    End Function
End Class
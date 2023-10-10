Imports System.Data.SqlClient

Public Class ManagerInventario
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaInventario As List(Of Inventario) = New List(Of Inventario)
    Dim inventarioTemp As Inventario
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getInventario() As List(Of Inventario)
        cmd = New SqlCommand("SELECT * FROM INVENTARIO;", connectionDBManager)
        dr = cmd.ExecuteReader()

        listaInventario.Clear()
        If dr.HasRows Then
            dr.Read()
            Do
                inventarioTemp = New Inventario(dr(0).ToString(), Convert.ToInt32(dr(1)))
                listaInventario.Add(inventarioTemp)
            Loop While dr.Read()
            dr.Close()
        End If
        dr.Close()
        Return listaInventario
    End Function

    Public Sub addUnidades(cantidadSumar As Integer, inventarioPasado As Inventario)
        cmd = New SqlCommand($"UPDATE INVENTARIO SET 
                            UNIDADESDISPONIBLES = {inventarioPasado.UnidadesDisponibles + cantidadSumar}
                            WHERE NOMBREARTICULO = '{inventarioPasado.NombreDeArticulo}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Unidades actualizadas")
        Else
            MessageBox.Show("Unidades no actualizadas")
        End If
    End Sub
    Public Sub deleteUnidades(cantidadRestar As Integer, inventarioPasado As Inventario)
        If inventarioPasado.UnidadesDisponibles - cantidadRestar < 0 Then
            frmConfirmacionUnidadesNegativas.ShowDialog()
            If Not frmConfirmacionUnidadesNegativas.respuesta Then
                Return
            End If
        End If

        cmd = New SqlCommand($"UPDATE INVENTARIO SET 
                            UNIDADESDISPONIBLES = {inventarioPasado.UnidadesDisponibles - cantidadRestar}
                            WHERE NOMBREARTICULO = '{inventarioPasado.NombreDeArticulo}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Unidades actualizadas")
        Else
            MessageBox.Show("Unidades no actualizadas")
        End If
    End Sub
End Class
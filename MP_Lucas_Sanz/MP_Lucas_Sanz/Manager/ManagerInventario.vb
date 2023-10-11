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
                            UNIDADESDISPONIBLES = UNIDADESDISPONIBLES + {cantidadSumar}
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
                            UNIDADESDISPONIBLES = UNIDADESDISPONIBLES - {cantidadRestar}
                            WHERE NOMBREARTICULO = '{inventarioPasado.NombreDeArticulo}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Unidades actualizadas")
        Else
            MessageBox.Show("Unidades no actualizadas")
        End If
    End Sub
    Public Sub addInventario(inventarioPasado As Inventario)
        cmd = New SqlCommand($"INSERT INTO INVENTARIO 
                            VALUES ('{inventarioPasado.NombreDeArticulo}', {inventarioPasado.UnidadesDisponibles});", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Unidades introducidas")
        Else
            MessageBox.Show("Unidades no introducidas")
        End If
    End Sub
    Public Sub deleteInventario(inventarioPasado As Inventario)
        cmd = New SqlCommand($"DELETE FROM INVENTARIO WHERE
                            NOMBREARTICULO = '{inventarioPasado.NombreDeArticulo}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Unidades eliminadas")
        Else
            MessageBox.Show("Unidades no eliminadas")
        End If
    End Sub
    Public Function checkInventario(nombrePasado As String) As Boolean
        cmd = New SqlCommand($"SELECT * FROM INVENTARIO WHERE
                            NOMBREARTICULO = '{nombrePasado}';", connectionDBManager)
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
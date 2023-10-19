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
        listaInventario = New List(Of Inventario)

        cmd = New SqlCommand("SELECT * FROM INVENTARIO;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                inventarioTemp = New Inventario(dr(0).ToString().Trim(), Convert.ToInt32(dr(1)))
                listaInventario.Add(inventarioTemp)
            Loop While dr.Read()
            dr.Close()
        End If
        dr.Close()
        Return listaInventario
    End Function
    Public Sub addUnidades(cantidadSumar As Integer, inventarioPasado As Inventario)
        cmd = New SqlCommand("UPDATE INVENTARIO SET 
                            UNIDADESDISPONIBLES = UNIDADESDISPONIBLES + @CantidadSumar
                            WHERE NOMBREARTICULO = @Nombre;", connectionDBManager)
        With cmd.Parameters
            .Add("@CantidadSumar", SqlDbType.Int).Value = cantidadSumar
            .Add("@Nombre", SqlDbType.Char, 50).Value = inventarioPasado.NombreDeArticulo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al añadir unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteUnidades(cantidadRestar As Integer, inventarioPasado As Inventario)
        If inventarioPasado.UnidadesDisponibles - cantidadRestar < 0 Then
            frmConfirmacionUnidadesNegativas.ShowDialog()
            If Not frmConfirmacionUnidadesNegativas.respuesta Then
                Return
            End If
        End If

        cmd = New SqlCommand("UPDATE INVENTARIO SET 
                            UNIDADESDISPONIBLES = UNIDADESDISPONIBLES - @CantidadRestar
                            WHERE NOMBREARTICULO = @Nombre;", connectionDBManager)
        With cmd.Parameters
            .Add("@CantidadRestar", SqlDbType.Int).Value = cantidadRestar
            .Add("@Nombre", SqlDbType.Char, 50).Value = inventarioPasado.NombreDeArticulo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al restar unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub addInventario(inventarioPasado As Inventario)
        cmd = New SqlCommand("INSERT INTO INVENTARIO 
                            VALUES (@Nombre, @UnidadesDisponibles);", connectionDBManager)
        With cmd.Parameters
            .Add("@UnidadesDisponibles", SqlDbType.Int).Value = inventarioPasado.UnidadesDisponibles
            .Add("@Nombre", SqlDbType.Char, 50).Value = inventarioPasado.NombreDeArticulo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteInventario(inventarioPasado As Inventario)
        cmd = New SqlCommand("DELETE FROM INVENTARIO 
                            WHERE NOMBREARTICULO = @Nombre;", connectionDBManager)
        cmd.Parameters.Add("@Nombre", SqlDbType.Char, 50).Value = inventarioPasado.NombreDeArticulo
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar unidades: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function checkInventario(nombrePasado As String) As Boolean
        cmd = New SqlCommand("SELECT * FROM INVENTARIO WHERE
                            NOMBREARTICULO = @Nombre;", connectionDBManager)
        cmd.Parameters.Add("@Nombre", SqlDbType.Char, 50).Value = nombrePasado
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
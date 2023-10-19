Imports System.Data.SqlClient

Public Class ManagerGrupo

    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaGrupos As List(Of Grupo) = New List(Of Grupo)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getGrupos() As List(Of Grupo)
        listaGrupos = New List(Of Grupo)
        cmd = New SqlCommand("SELECT * FROM GRUPOS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                grupoAux = New Grupo(dr(0).ToString.Trim(), dr(1).ToString().Trim())
                listaGrupos.Add(grupoAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaGrupos
    End Function
    Public Sub addGrupo(grupoPasado As Grupo)
        cmd = New SqlCommand("INSERT INTO GRUPOS
                            VALUES (@Codigo, @Nombre);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Char, 5).Value = grupoPasado.CodigoDeGrupo
            .Add("@Nombre", SqlDbType.Char, 100).Value = grupoPasado.NombreDeGrupo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir un grupo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyGrupo(grupoPasado As Grupo)
        cmd = New SqlCommand("UPDATE GRUPOS
                            SET NOMBREGRUPO = @Nombre
                            WHERE CODIGOGRUPO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Char, 5).Value = grupoPasado.CodigoDeGrupo
            .Add("@Nombre", SqlDbType.Char, 100).Value = grupoPasado.NombreDeGrupo
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al modificar un grupo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteGrupo(grupoPasado As Grupo)
        cmd = New SqlCommand("DELETE FROM GRUPOS
                            WHERE CODIGOGRUPO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Char, 5).Value = grupoPasado.CodigoDeGrupo
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar un grupo: " + vbCrLf + ex.ToString())
        End Try
    End Sub

    Public Function checkGrupo(codigoPasado As String) As Boolean
        cmd = New SqlCommand("SELECT * FROM GRUPOS
                            WHERE CODIGOGRUPO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Char, 5).Value = codigoPasado
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function
End Class
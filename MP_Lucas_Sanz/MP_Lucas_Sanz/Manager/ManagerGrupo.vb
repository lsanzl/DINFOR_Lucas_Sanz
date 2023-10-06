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
        cmd = New SqlCommand("SELECT * FROM GRUPOS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                grupoAux = New Grupo(dr(0).ToString, dr(1).ToString())
                listaGrupos.Add(grupoAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaGrupos
    End Function

    Public Sub addGrupo(grupoPasado As Grupo)
        cmd = New SqlCommand($"INSERT INTO GRUPOS
                            VALUES ('{grupoPasado.CodigoDeGrupo}','{grupoPasado.NombreDeGrupo}');", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Grupo creado")
        Else
            MessageBox.Show("Grupo no creado")
        End If
    End Sub
    Public Sub modifyGrupo(grupoPasado As Grupo)
        cmd = New SqlCommand($"UPDATE GRUPOS
                            SET NOMBREGRUPO = '{grupoPasado.NombreDeGrupo}'
                            WHERE CODIGOGRUPO = '{grupoPasado.CodigoDeGrupo}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Grupo modificado")
        Else
            MessageBox.Show("Grupo no modificado")
        End If
    End Sub
    Public Sub deleteGrupo(grupoPasado As Grupo)
        cmd = New SqlCommand($"DELETE FROM GRUPOS
                            WHERE CODIGOGRUPO = '{grupoPasado.CodigoDeGrupo}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Grupo eliminado")
        Else
            MessageBox.Show("Grupo no eliminado")
        End If
    End Sub

    Public Function checkGrupo(codigoPasado As String) As Boolean
        cmd = New SqlCommand($"SELECT * FROM GRUPOS
                            WHERE CODIGOGRUPO = '{codigoPasado}';", connectionDBManager)
        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function
End Class
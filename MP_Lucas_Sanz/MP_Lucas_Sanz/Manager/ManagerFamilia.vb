Imports System.Data.SqlClient

Public Class ManagerFamilia
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaFamilias As List(Of Familia) = New List(Of Familia)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getFamilias() As List(Of Familia)
        listaFamilias = New List(Of Familia)
        cmd = New SqlCommand("SELECT * FROM FAMILIAS", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Dim familiaTemp As Familia
            dr.Read()
            Do
                familiaTemp = New Familia(dr(0).ToString().Trim(), dr(1).ToString().Trim())
                listaFamilias.Add(familiaTemp)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaFamilias
    End Function
    Public Sub addFamilia(familiaTemp As Familia)
        If checkCodigoFamilia(familiaTemp.CodigoDeFamilia) Then
            MessageBox.Show("Ya existe dicha familia")
            Return
        End If
        cmd = New SqlCommand("INSERT INTO FAMILIAS VALUES (@Codigo, 
                            @Nombre);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Char, 6).Value = familiaTemp.CodigoDeFamilia
            .Add("@Nombre", SqlDbType.Char, 100).Value = familiaTemp.NombreDeFamilia
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("No se pudo insertar la familia: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyFamilia(familiaTemp As Familia)
        cmd = New SqlCommand("UPDATE FAMILIAS SET NOMBREFAMILIA = @Nombre
                            WHERE CODIGOFAMILIA = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Char, 6).Value = familiaTemp.CodigoDeFamilia
            .Add("@Nombre", SqlDbType.Char, 100).Value = familiaTemp.NombreDeFamilia
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("No se pudo modificar la familia: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteFamilia(familiaTemp As Familia)
        cmd = New SqlCommand("DELETE FROM FAMILIAS 
                            WHERE CODIGOFAMILIA = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Char, 6).Value = familiaTemp.CodigoDeFamilia
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar la familia: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function checkCodigoFamilia(codigoPasado As String) As Boolean
        cmd = New SqlCommand("SELECT * FROM FAMILIAS 
                            WHERE CODIGOFAMILIA = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Char, 6).Value = codigoPasado
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
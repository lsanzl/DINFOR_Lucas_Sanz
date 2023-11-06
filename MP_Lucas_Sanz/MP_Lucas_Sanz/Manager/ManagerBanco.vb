Imports System.Data.SqlClient

Public Class ManagerBanco
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaBancos As List(Of Banco)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Function getBancos() As List(Of Banco)
        listaBancos = New List(Of Banco)
        cmd = New SqlCommand("SELECT * FROM BANCOS;", connectionDBManager)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            Do
                bancoAux = New Banco(Convert.ToInt32(dr(0)), dr(1).ToString().Trim())
                listaBancos.Add(bancoAux)
            Loop While dr.Read()
        End If
        dr.Close()
        Return listaBancos
    End Function

    Public Sub addBanco(bancoTemp As Banco)
        cmd = New SqlCommand("INSERT INTO BANCOS VALUES 
                                (@Codigo,
                                @Nombre);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = bancoTemp.CodigoDeBanco
            .Add("@Nombre", SqlDbType.Char, 100).Value = bancoTemp.NombreDeBanco
        End With
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaBancos()
        Catch ex As Exception
            MessageBox.Show("Error al introducir un banco: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyBanco(bancoTemp As Banco)
        cmd = New SqlCommand($"UPDATE BANCOS
                                SET NOMBRE_BANCO = @Nombre
                                WHERE ID_BANCO = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = bancoTemp.CodigoDeBanco
            .Add("@Nombre", SqlDbType.Char, 100).Value = bancoTemp.NombreDeBanco
        End With
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaBancos()
        Catch ex As Exception
            MessageBox.Show("Error al modificar un banco: " + vbCrLf + ex.ToString())
        End Try
    End Sub

    Public Sub deleteBanco(bancoTemp As Banco)
        Dim dr As DialogResult = MessageBox.Show("Se borrarán datos asociados al registro: clientes, formas de pago, compras y ventas, ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = DialogResult.No) Then
            Return
        End If
        managerFormaPagoAux.deleteFormaPagoBanco(bancoTemp.CodigoDeBanco)
        cmd = New SqlCommand("DELETE FROM BANCOS
                                WHERE ID_BANCO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = bancoTemp.CodigoDeBanco
        Try
            cmd.ExecuteNonQuery()
            VariablesGlobales.updateListaBancos()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar un banco: " + vbCrLf + ex.ToString())
        End Try
    End Sub

    Public Function checkBanco(codigoBanco As Integer) As Boolean
        cmd = New SqlCommand($"SELECT NOMBRE_BANCO
                                FROM BANCOS
                                WHERE ID_BANCO = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoBanco
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            dr.Close()
            Return True
        End If
        dr.Close()
        Return False
    End Function
End Class

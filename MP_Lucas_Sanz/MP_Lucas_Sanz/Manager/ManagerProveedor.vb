Imports System.Data.SqlClient

Public Class ManagerProveedor
    Private cmd As SqlCommand
    Private dr As SqlDataReader
    Private listaProveedores As List(Of Proveedor) = New List(Of Proveedor)
    Private connectionDBManager As SqlConnection = VariablesGlobales.connectionDB.connectionDB

    Public Sub New()
        MyBase.New()
    End Sub

    Public Function getProveedores() As List(Of Proveedor)
        cmd = New SqlCommand("SELECT * FROM PROVEEDORES", connectionDBManager)
        dr = cmd.ExecuteReader()
        listaProveedores = New List(Of Proveedor)
        If dr.HasRows Then
            Dim codigoTemp As String
            Dim nombreTemp As String
            Dim nifTemp As String
            Dim direccionTemp As String
            Dim poblacionTemp As String
            Dim telefonoTemp As Integer
            Dim proveedorTemp As Proveedor

            dr.Read()
            Do
                codigoTemp = dr(0).ToString()
                nombreTemp = dr(1).ToString()
                nifTemp = dr(2).ToString()
                direccionTemp = dr(3).ToString()
                poblacionTemp = dr(4).ToString()
                telefonoTemp = Convert.ToInt32(dr(5))

                proveedorTemp = New Proveedor(codigoTemp, nombreTemp, nifTemp, direccionTemp, poblacionTemp, telefonoTemp)
                listaProveedores.Add(proveedorTemp)
            Loop While dr.Read()
            dr.Close()
            Return listaProveedores
        End If
        dr.Close()
        Return listaProveedores
    End Function

    Public Sub addProveedor(proveedorP As Proveedor)
        cmd = New SqlCommand($"INSERT INTO PROVEEDORES
                            VALUES ('{proveedorP.CodigoDeProveedor}',
                            '{proveedorP.NombreDeProveedor}',
                            '{proveedorP.NifDeProveedor}',
                            '{proveedorP.DireccionDeProveedor}',
                            '{proveedorP.PoblacionDeProveedor}',
                            {proveedorP.TelefonoDeProveedor});", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Proveedor creado")
        Else
            MessageBox.Show("Proveedor no creado")
        End If
    End Sub
    Public Sub modifyProveedor(proveedorMod As Proveedor)
        cmd = New SqlCommand($"UPDATE PROVEEDORES
                            SET NOMBREPROVEEDOR = '{proveedorMod.NombreDeProveedor}',
                            NIFPROVEEDOR = '{proveedorMod.NifDeProveedor}',
                            DIRECCIONPROVEEDOR = '{proveedorMod.DireccionDeProveedor}',
                            POBLACIONPROVEEDOR = '{proveedorMod.PoblacionDeProveedor}',
                            TELEFONOPROVEEDOR = {proveedorMod.TelefonoDeProveedor}
                            WHERE CODIGOPROVEEDOR = '{proveedorMod.CodigoDeProveedor}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Proveedor modificado")
        Else
            MessageBox.Show("Proveedor no modificado")
        End If
    End Sub
    Public Sub deleteProveedor(proveedorDel As Proveedor)
        cmd = New SqlCommand($"DELETE FROM PROVEEDORES 
                            WHERE CODIGOPROVEEDOR = '{proveedorDel.CodigoDeProveedor}';", connectionDBManager)
        If cmd.ExecuteNonQuery() > 0 Then
            MessageBox.Show("Proveedor eliminado")
        Else
            MessageBox.Show("Proveedor no eliminado")
        End If
    End Sub
    Public Function checkCodigo(codigoPasado As String) As Boolean
        cmd = New SqlCommand($"SELECT * FROM PROVEEDORES
                            WHERE CODIGOPROVEEDOR = '{codigoPasado}';", connectionDBManager)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Close()
            Return True
        Else
            dr.Close()
            Return False
        End If
    End Function

End Class

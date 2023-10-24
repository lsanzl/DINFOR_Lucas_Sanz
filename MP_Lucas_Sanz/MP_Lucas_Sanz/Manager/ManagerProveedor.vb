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
            Dim codigoTemp As Integer
            Dim nombreTemp As String
            Dim nifTemp As String
            Dim direccionTemp As String
            Dim poblacionTemp As String
            Dim telefonoTemp As Integer
            Dim proveedorTemp As Proveedor

            dr.Read()
            Do
                codigoTemp = Convert.ToInt32(dr(0))
                nombreTemp = dr(1).ToString().Trim()
                nifTemp = dr(2).ToString().Trim()
                direccionTemp = dr(3).ToString().Trim()
                poblacionTemp = dr(4).ToString().Trim()
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
        cmd = New SqlCommand("INSERT INTO PROVEEDORES
                            VALUES 
                            (@Codigo,
                            @Nombre,
                            @Nif,
                            @Direccion,
                            @Poblacion,
                            @Telefono);", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = proveedorP.CodigoDeProveedor
            .Add("@Nombre", SqlDbType.Char, 100).Value = proveedorP.NombreDeProveedor
            .Add("@Nif", SqlDbType.Char, 12).Value = proveedorP.NifDeProveedor
            .Add("@Direccion", SqlDbType.Char, 150).Value = proveedorP.DireccionDeProveedor
            .Add("@Poblacion", SqlDbType.Char, 100).Value = proveedorP.PoblacionDeProveedor
            .Add("@Telefono", SqlDbType.Int).Value = proveedorP.TelefonoDeProveedor
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al introducir un proveedor nuevo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub modifyProveedor(proveedorMod As Proveedor)
        cmd = New SqlCommand("UPDATE PROVEEDORES
                            SET NOMBRE_PROVEEDOR = @Nombre,
                            NIF_PROVEEDOR = @Nif,
                            DIRECCION_PROVEEDOR = @Direccion,
                            POBLACION_PROVEEDOR = @Poblacion,
                            TELEFONO_PROVEEDOR = @Telefono
                            WHERE ID_PROVEEDOR = @Codigo;", connectionDBManager)
        With cmd.Parameters
            .Add("@Codigo", SqlDbType.Int).Value = proveedorMod.CodigoDeProveedor
            .Add("@Nombre", SqlDbType.Char, 100).Value = proveedorMod.NombreDeProveedor
            .Add("@Nif", SqlDbType.Char, 12).Value = proveedorMod.NifDeProveedor
            .Add("@Direccion", SqlDbType.Char, 150).Value = proveedorMod.DireccionDeProveedor
            .Add("@Poblacion", SqlDbType.Char, 100).Value = proveedorMod.PoblacionDeProveedor
            .Add("@Telefono", SqlDbType.Int).Value = proveedorMod.TelefonoDeProveedor
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al modificar un proveedor nuevo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Sub deleteProveedor(proveedorDel As Proveedor)
        Dim dr As DialogResult = MessageBox.Show("Se borrarán datos asociados al registro: compras, ¿desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (dr = DialogResult.No) Then
            Return
        End If
        managerCompraAux.deleteCompraProveedor(proveedorDel.CodigoDeProveedor)
        cmd = New SqlCommand("DELETE FROM PROVEEDORES 
                            WHERE ID_PROVEEDOR = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = proveedorDel.CodigoDeProveedor
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar un proveedor nuevo: " + vbCrLf + ex.ToString())
        End Try
    End Sub
    Public Function checkCodigo(codigoPasado As Integer) As Boolean
        cmd = New SqlCommand("SELECT * FROM PROVEEDORES
                            WHERE ID_PROVEEDOR = @Codigo;", connectionDBManager)
        cmd.Parameters.Add("@Codigo", SqlDbType.Int).Value = codigoPasado
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

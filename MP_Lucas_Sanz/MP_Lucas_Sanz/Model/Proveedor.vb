Public Class Proveedor
    Private codigoProveedor As String
    Private nombreProveedor As String
    Private nifProveedor As String
    Private direccionProveedor As String
    Private poblacionProveedor As String
    Private telefonoProveedor As Integer

    Public Property CodigoDeProveedor() As String
        Get
            Return codigoProveedor
        End Get
        Set(value As String)
            codigoProveedor = value
        End Set
    End Property
    Public Property NombreDeProveedor() As String
        Get
            Return nombreProveedor
        End Get
        Set(value As String)
            nombreProveedor = value
        End Set
    End Property
    Public Property NifDeProveedor() As String
        Get
            Return nifProveedor
        End Get
        Set(value As String)
            nifProveedor = value
        End Set
    End Property
    Public Property DireccionDeProveedor() As String
        Get
            Return direccionProveedor
        End Get
        Set(value As String)
            direccionProveedor = value
        End Set
    End Property
    Public Property PoblacionDeProveedor() As String
        Get
            Return poblacionProveedor
        End Get
        Set(value As String)
            poblacionProveedor = value
        End Set
    End Property
    Public Property TelefonoDeProveedor() As Integer
        Get
            Return telefonoProveedor
        End Get
        Set(value As Integer)
            telefonoProveedor = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(codigoPasado As String, nombrePasado As String, nifPasado As String,
                   direccionPasada As String, poblacionPasada As String, telefonoPasado As Integer)
        MyBase.New()
        CodigoDeProveedor = codigoPasado
        NombreDeProveedor = nombrePasado
        NifDeProveedor = nifPasado
        DireccionDeProveedor = direccionPasada
        PoblacionDeProveedor = poblacionPasada
        TelefonoDeProveedor = telefonoPasado
    End Sub

    Public Function getProveedores() As List(Of Proveedor)
        Return managerProveedorAux.getProveedores()
    End Function
    Public Sub addProveedor()
        managerProveedorAux.addProveedor(Me)
    End Sub
    Public Sub modifyProveedor()
        managerProveedorAux.modifyProveedor(Me)
    End Sub
    Public Sub deleteProveedor()
        managerProveedorAux.deleteProveedor(Me)
    End Sub
    Public Function checkCodigoProveedor(codigoCheck As String)
        If codigoCheck.Length > 6 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
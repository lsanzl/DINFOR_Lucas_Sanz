Public Class Cliente
    Private codigoCliente As Integer
    Private grupoCliente As Integer?
    Private bancoCliente As Integer?
    Private nombreCliente As String
    Private nif As String
    Private direccion As String
    Private fechaNacimiento As Date
    Private email As String

    Public Property CodigoDelCliente() As Integer
        Get
            Return codigoCliente
        End Get
        Set(value As Integer)
            codigoCliente = value
        End Set
    End Property
    Public Property BancoDelCliente() As Integer?
        Get
            Return bancoCliente
        End Get
        Set(value As Integer?)
            bancoCliente = value
        End Set
    End Property
    Public Property GrupoDelCliente() As Integer?
        Get
            Return grupoCliente
        End Get
        Set(value As Integer?)
            grupoCliente = value
        End Set
    End Property
    Public Property NombreDelCliente() As String
        Get
            Return nombreCliente
        End Get
        Set(value As String)
            nombreCliente = value
        End Set
    End Property
    Public Property NifDelCliente() As String
        Get
            Return nif
        End Get
        Set(value As String)
            nif = value
        End Set
    End Property
    Public Property DireccionDelCliente() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property
    Public Property FechaDeNacimientoDelCliente() As Date
        Get
            Return fechaNacimiento
        End Get
        Set(value As Date)
            fechaNacimiento = value
        End Set
    End Property
    Public Property EmailDelCliente() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(codigoPasado As Integer, nombrePasado As String, nifPasado As String, direccionPasada As String, fechaPasada As Date,
                   bancoPasado As Integer, grupoPasado As Integer, emailPasado As String)
        MyBase.New()
        CodigoDelCliente = codigoPasado
        BancoDelCliente = bancoPasado
        GrupoDelCliente = grupoPasado
        NombreDelCliente = nombrePasado
        NifDelCliente = nifPasado
        DireccionDelCliente = direccionPasada
        FechaDeNacimientoDelCliente = fechaPasada
        EmailDelCliente = emailPasado
    End Sub

    Public Sub addCliente()
        managerClienteAux.addCliente(Me)
    End Sub
    Public Sub modifyCliente()
        managerClienteAux.modifyCliente(Me)
    End Sub
    Public Sub deleteCliente()
        managerClienteAux.deleteCliente(Me)
    End Sub
End Class
﻿Public Class Compra
    Private proveedorCompra As String
    Private articuloCompra As String
    Private formaPagoCompra As String
    Private precioArticuloCompra As Double
    Private cantidadCompra As Integer
    Private precioTotalCompra As Double

    Public Property ProveedorDeCompra() As String
        Get
            Return proveedorCompra
        End Get
        Set(value As String)
            proveedorCompra = value
        End Set
    End Property
    Public Property ArticuloDeCompra() As String
        Get
            Return articuloCompra
        End Get
        Set(value As String)
            articuloCompra = value
        End Set
    End Property
    Public Property FormaDePagoCompra() As String
        Get
            Return formaPagoCompra
        End Get
        Set(value As String)
            formaPagoCompra = value
        End Set
    End Property
    Public Property PrecioDeArticuloCompra() As Double
        Get
            Return precioArticuloCompra
        End Get
        Set(value As Double)
            precioArticuloCompra = value
        End Set
    End Property
    Public Property CantidadDeCompra() As Integer
        Get
            Return cantidadCompra
        End Get
        Set(value As Integer)
            cantidadCompra = value
        End Set
    End Property
    Public Property PrecioTotalDeCompra() As Double
        Get
            Return precioTotalCompra
        End Get
        Set(value As Double)
            precioTotalCompra = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(proveedorP As String, articuloP As String, formaP As String, precioP As Double, cantidadP As Integer)
        MyBase.New()
        ProveedorDeCompra = proveedorP
        ArticuloDeCompra = articuloP
        FormaDePagoCompra = formaP
        PrecioDeArticuloCompra = precioP
        CantidadDeCompra = cantidadP
        PrecioTotalDeCompra = PrecioDeArticuloCompra * CantidadDeCompra
    End Sub

    Public Function getCompras() As List(Of Compra)
        Return managerCompraAux.getCompras()
    End Function

    Public Sub addCompra()
        managerCompraAux.addCompra(Me)
    End Sub
End Class
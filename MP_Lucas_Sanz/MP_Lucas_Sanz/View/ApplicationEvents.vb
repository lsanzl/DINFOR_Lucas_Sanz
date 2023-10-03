Namespace My
    ' Los siguientes eventos están disponibles para MyApplication:
    ' Inicio: Se genera cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: Se genera después de haberse cerrado todos los formularios de aplicación.  Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: Se genera si la aplicación encuentra una excepción no controlada.
    ' StartupNextInstance: Se genera cuando se inicia una aplicación de instancia única y dicha aplicación está ya activa. 
    ' NetworkAvailabilityChanged: Se genera cuando se conecta o desconecta la conexión de red.
    Partial Friend Class MyApplication
        Private Sub MyApplication_StartUp(sender As Object,
             e As EventArgs) Handles Me.Startup
            VariablesGlobales.connectionDB.ConectarDB()
        End Sub
        Private Sub MyApplication_Shutdown(sender As Object,
             e As EventArgs) Handles Me.Shutdown
            'Dim conexionAux As ConnectionDB = New ConnectionDB
            'conexionAux.DesconectarDB()
            VariablesGlobales.connectionDB.DesconectarDB()
        End Sub
    End Class

End Namespace

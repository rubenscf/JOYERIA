Public Class clsComunes
    Public Property CarpetaImagenes As String = "\Resources\Images\Joyeria\"
    Public Property rutaLecturaImagenes As String = "~/Resources/Images/Joyeria/"
    Public Property SinImagen As String = "sin_foto_predeterminada.jpg"
    Enum Operacion_Registro As Int16
        Nuevo = 1
        Editar = 2
        Eliminar = 3
    End Enum
    Enum Respuesta_Operacion As Int16
        Exito = 1
        Erronea = 2
    End Enum



End Class

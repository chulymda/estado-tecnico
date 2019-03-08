Imports System.Data.Sql
Imports System.Data.SqlClient



Module Conexion


    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter


    'FUNCION DE CONEXION A LA BASE DE DATOS'
    '***********************************************************************************************************************************************'

    Sub abrir()
        Try
            conexiones = New SqlConnection("Data Source=192.168.10.200;Initial Catalog=visual_mda;Persist Security Info=True;User ID=chuly;Password=Aa978645312")
            conexiones.Open()
        Catch ex As Exception
            MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            conexiones.Close() 'Cierra la conexion'
        End Try
    End Sub

    '***********************************************************************************************************************************************'



    'FUNCION DE ELIMINACION'
    '***************************************************************************************************************************************************'
    Function eliminar(ByVal id As Integer) As String
        Dim resultado As String
        Try
            enunciado = New SqlCommand("Delete from [visual_mda].[dbo].[estadoTecnico] where Id=" & id & "", conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se elimino la reservacion Correctamente"
        Catch ex As Exception
            resultado = "No se elimino elimino la reservacion correctamente" + ex.ToString

        End Try
        Return resultado

    End Function
    '***************************************************************************************************************************************************'

End Module
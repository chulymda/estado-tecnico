Imports System.Data.SqlClient
Public Class FRMFueraDeServicio

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        Dim fechaHora As String = Format(DateTimePickerFecha.Value.Date, "yyyy-MM-dd") + " " + Format(DateTimePickerHora.Value, "HH:mm:ss")
        Dim maquina As Integer
        Dim estadoTecnico As String
        Dim observaciones As String

        maquina = TextBoxNumeroDeMaquina.Text
        estadoTecnico = "Fuera de servicio"
        observaciones = TextBoxObservaciones.Text

        abrir()

        Try

            Dim cmd As SqlCommand = New SqlCommand
            With cmd
                .Parameters.AddWithValue("@maquina", maquina)
                .Parameters.AddWithValue("@fecha", fechaHora)
                .Parameters.AddWithValue("@estadoTecnico", estadoTecnico)
                .Parameters.AddWithValue("@observaciones", observaciones)
            End With
            cmd.Connection = conexiones
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "insertarEstadoTecnico"
            cmd.ExecuteNonQuery()
            conexiones.Close()
            MsgBox("REGISTRO CORRECTO")
        Catch ex As Exception
            MsgBox("ERROR AL REGISTRAR: " & ex.Message)
        End Try




        Limpiar()
    End Sub

    Sub Limpiar()
        TextBoxNumeroDeMaquina.Clear()
        TextBoxObservaciones.Clear()
    End Sub



    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        'Limpiar()
        Dim fechaHora As String = Format(DateTimePickerFecha.Value.Date, "yyyy-MM-dd") + " " + Format(DateTimePickerHora.Value, "HH:mm:ss")
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class

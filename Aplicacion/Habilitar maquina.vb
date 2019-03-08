Imports System.Data.SqlClient

Public Class Habilitar_maquina


    Sub Limpiar() 'funcion para limpiar
        TextBoxNumeroDeMaquina.Clear()
        TextBoxObservaciones.Clear()
    End Sub


    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        Limpiar()
    End Sub

    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub



    Private Sub Habilitar_maquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Visual_mdaDataSet.View_ultimoEstadoFueraDeServicio' Puede moverla o quitarla según sea necesario.
        Me.View_ultimoEstadoFueraDeServicioTableAdapter.Fill(Me.Visual_mdaDataSet.View_ultimoEstadoFueraDeServicio)

    End Sub

    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click
        'insertar registro de maquina habilitada
        Dim fechaHora As String = Format(DateTimePickerFecha.Value.Date, "yyyy-MM-dd") + " " + Format(DateTimePickerHora.Value, "HH:mm:ss")
        Dim maquina As Integer
        Dim estadoTecnico As String
        Dim observaciones As String

        maquina = TextBoxNumeroDeMaquina.Text
        estadoTecnico = "Habilitada"
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

        'TODO: esta línea de código carga datos en la tabla 'Visual_mdaDataSet.View_ultimoEstadoFueraDeServicio' Puede moverla o quitarla según sea necesario.
        Me.View_ultimoEstadoFueraDeServicioTableAdapter.Fill(Me.Visual_mdaDataSet.View_ultimoEstadoFueraDeServicio)

        Limpiar()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Selecciona el numero de maquina a habilitar
        TextBoxNumeroDeMaquina.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub
End Class
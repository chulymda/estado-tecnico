
Imports System.Data.SqlClient


Public Class Eliminar_registro

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Eliminar_registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Visual_mdaDataSet1.estadoTecnico' Puede moverla o quitarla según sea necesario.
        Me.EstadoTecnicoTableAdapter.Fill(Me.Visual_mdaDataSet1.estadoTecnico)

    End Sub


    Private Sub ButtonAceptar_Click(sender As Object, e As EventArgs) Handles ButtonAceptar.Click

        abrir()

        Try

            Dim cmd As SqlCommand = New SqlCommand
            With cmd
                .Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
            End With
            cmd.Connection = conexiones
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "eliminarRegistroEstadoTecnico"
            cmd.ExecuteNonQuery()
            conexiones.Close()
            MsgBox("REGISTRO ELIMINADO")
        Catch ex As Exception
            MsgBox("ERROR AL ELIMINAR: " & ex.Message)
        End Try
        'TODO: esta línea de código carga datos en la tabla 'Visual_mdaDataSet1.estadoTecnico' Puede moverla o quitarla según sea necesario.
        Me.EstadoTecnicoTableAdapter.Fill(Me.Visual_mdaDataSet1.estadoTecnico)

    End Sub
End Class
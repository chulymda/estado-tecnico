Public Class Formulario_inicial


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fr_fdsActualizacion As New FRMFueraDeServicio
        FRMFueraDeServicio.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fr_habilitar As New Habilitar_maquina
        fr_habilitar.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fr_eliminar As New Eliminar_registro
        fr_eliminar.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        Me.Close()
    End Sub

    Private Sub Formulario_inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Visual_mdaDataSet.View_ultimoEstadoFueraDeServicio' Puede moverla o quitarla según sea necesario.
        Me.View_ultimoEstadoFueraDeServicioTableAdapter.Fill(Me.Visual_mdaDataSet.View_ultimoEstadoFueraDeServicio)

    End Sub
    Private Sub Formulario_inicial_MouseCaptureChanged(sender As Object, e As EventArgs) Handles MyBase.MouseCaptureChanged

    End Sub

    Private Sub Formulario_inicial_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'TODO: esta línea de código carga datos en la tabla 'Visual_mdaDataSet.View_ultimoEstadoFueraDeServicio' Puede moverla o quitarla según sea necesario.
        Me.View_ultimoEstadoFueraDeServicioTableAdapter.Fill(Me.Visual_mdaDataSet.View_ultimoEstadoFueraDeServicio)
    End Sub
End Class
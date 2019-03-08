<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMFueraDeServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.TextBoxNumeroDeMaquina = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerHora = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaquinasFueraDeServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaquinasFueraDeServicioBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaquinasFueraDeServicioBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaquinaslistaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisualDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaquinaslistaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewultimoEstadoFueraDeServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.MaquinasFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaquinasFueraDeServicioBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaquinasFueraDeServicioBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaquinaslistaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisualDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaquinaslistaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox1.Controls.Add(Me.ButtonSalir)
        Me.GroupBox1.Controls.Add(Me.ButtonAceptar)
        Me.GroupBox1.Controls.Add(Me.TextBoxNumeroDeMaquina)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerHora)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerFecha)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 407)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpiar.Location = New System.Drawing.Point(297, 342)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(140, 56)
        Me.ButtonLimpiar.TabIndex = 7
        Me.ButtonLimpiar.Text = "LIMPIAR"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Location = New System.Drawing.Point(151, 342)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(140, 56)
        Me.ButtonSalir.TabIndex = 6
        Me.ButtonSalir.Text = "SALIR"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.Location = New System.Drawing.Point(5, 342)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(140, 56)
        Me.ButtonAceptar.TabIndex = 5
        Me.ButtonAceptar.Text = "ACEPTAR"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'TextBoxNumeroDeMaquina
        '
        Me.TextBoxNumeroDeMaquina.Location = New System.Drawing.Point(151, 32)
        Me.TextBoxNumeroDeMaquina.MaxLength = 7
        Me.TextBoxNumeroDeMaquina.Name = "TextBoxNumeroDeMaquina"
        Me.TextBoxNumeroDeMaquina.Size = New System.Drawing.Size(96, 23)
        Me.TextBoxNumeroDeMaquina.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxObservaciones)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 226)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Observaciones"
        '
        'TextBoxObservaciones
        '
        Me.TextBoxObservaciones.Location = New System.Drawing.Point(19, 57)
        Me.TextBoxObservaciones.Multiline = True
        Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
        Me.TextBoxObservaciones.Size = New System.Drawing.Size(489, 163)
        Me.TextBoxObservaciones.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de maquina"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha hora"
        '
        'DateTimePickerHora
        '
        Me.DateTimePickerHora.CustomFormat = ""
        Me.DateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePickerHora.Location = New System.Drawing.Point(253, 63)
        Me.DateTimePickerHora.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerHora.Name = "DateTimePickerHora"
        Me.DateTimePickerHora.ShowUpDown = True
        Me.DateTimePickerHora.Size = New System.Drawing.Size(70, 23)
        Me.DateTimePickerHora.TabIndex = 3
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.CustomFormat = ""
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(151, 63)
        Me.DateTimePickerFecha.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(96, 23)
        Me.DateTimePickerFecha.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(532, 31)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "FUERA DE SERVICIO / ACTUALIZACION"
        '
        'MaquinasFueraDeServicioBindingSource
        '
        Me.MaquinasFueraDeServicioBindingSource.DataMember = "maquinasFueraDeServicio"
        '
        'MaquinaslistaBindingSource
        '
        Me.MaquinaslistaBindingSource.DataMember = "maquinas_lista"
        '
        'MaquinaslistaBindingSource1
        '
        Me.MaquinaslistaBindingSource1.DataMember = "maquinas_lista"
        '
        'ViewultimoEstadoFueraDeServicioBindingSource
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource.DataMember = "View_ultimoEstadoFueraDeServicio"
        '
        'FRMFueraDeServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 459)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRMFueraDeServicio"
        Me.Text = "Formulario fuera de servicio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.MaquinasFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaquinasFueraDeServicioBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaquinasFueraDeServicioBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaquinaslistaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisualDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaquinaslistaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents DateTimePickerHora As DateTimePicker
    Friend WithEvents TextBoxNumeroDeMaquina As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxObservaciones As TextBox
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Label4 As Label

    Friend WithEvents MaquinasFueraDeServicioBindingSource As BindingSource

    Friend WithEvents ButtonEliminar As Button

    Friend WithEvents MaquinasFueraDeServicioBindingSource1 As BindingSource

    Friend WithEvents MaquinasFueraDeServicioBindingSource2 As BindingSource

    Friend WithEvents MaquinasFueraDeServicioBindingSource3 As BindingSource
    Friend WithEvents VisualDataSetBindingSource As BindingSource
    Friend WithEvents MaquinaslistaBindingSource As BindingSource
    Friend WithEvents MaquinaslistaBindingSource1 As BindingSource
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource As BindingSource
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Habilitar_maquina
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
        Me.ViewultimoEstadoFueraDeServicioBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewultimoEstadoFueraDeServicioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewultimoEstadoFueraDeServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewultimoEstadoFueraDeServicioBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewultimoEstadoFueraDeServicioBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.TextBoxNumeroDeMaquina = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxObservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePickerHora = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewultimoEstadoFueraDeServicioBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Visual_mdaDataSet = New Aplicacion.visual_mdaDataSet()
        Me.ViewultimoEstadoFueraDeServicioBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_ultimoEstadoFueraDeServicioTableAdapter = New Aplicacion.visual_mdaDataSetTableAdapters.View_ultimoEstadoFueraDeServicioTableAdapter()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_mdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewultimoEstadoFueraDeServicioBindingSource3
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource3.DataMember = "View_ultimoEstadoFueraDeServicio"
        '
        'ViewultimoEstadoFueraDeServicioBindingSource1
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource1.DataMember = "View_ultimoEstadoFueraDeServicio"
        '
        'ViewultimoEstadoFueraDeServicioBindingSource
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource.DataMember = "View_ultimoEstadoFueraDeServicio"
        '
        'ViewultimoEstadoFueraDeServicioBindingSource2
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource2.DataMember = "View_ultimoEstadoFueraDeServicio"
        '
        'ViewultimoEstadoFueraDeServicioBindingSource4
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource4.DataMember = "View_ultimoEstadoFueraDeServicio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBox2.Controls.Add(Me.ButtonSalir)
        Me.GroupBox2.Controls.Add(Me.ButtonAceptar)
        Me.GroupBox2.Controls.Add(Me.TextBoxNumeroDeMaquina)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerHora)
        Me.GroupBox2.Controls.Add(Me.DateTimePickerFecha)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(526, 407)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
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
        Me.TextBoxNumeroDeMaquina.Enabled = False
        Me.TextBoxNumeroDeMaquina.Location = New System.Drawing.Point(151, 32)
        Me.TextBoxNumeroDeMaquina.Name = "TextBoxNumeroDeMaquina"
        Me.TextBoxNumeroDeMaquina.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxNumeroDeMaquina.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBoxObservaciones)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(514, 226)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de maquina"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha hora"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(290, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "HABILITAR MAQUINA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1253, 513)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView1.DataSource = Me.ViewultimoEstadoFueraDeServicioBindingSource6
        Me.DataGridView1.Location = New System.Drawing.Point(564, 15)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(607, 456)
        Me.DataGridView1.TabIndex = 14
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "maquina"
        Me.DataGridViewTextBoxColumn2.HeaderText = "maquina"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn1.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "estadoTecnico"
        Me.DataGridViewTextBoxColumn3.HeaderText = "estadoTecnico"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn4.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'ViewultimoEstadoFueraDeServicioBindingSource6
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource6.DataMember = "View_ultimoEstadoFueraDeServicio"
        Me.ViewultimoEstadoFueraDeServicioBindingSource6.DataSource = Me.Visual_mdaDataSet
        '
        'Visual_mdaDataSet
        '
        Me.Visual_mdaDataSet.DataSetName = "visual_mdaDataSet"
        Me.Visual_mdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_ultimoEstadoFueraDeServicioTableAdapter
        '
        Me.View_ultimoEstadoFueraDeServicioTableAdapter.ClearBeforeFill = True
        '
        'Habilitar_maquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 563)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Habilitar_maquina"
        Me.Text = "Habilitar_maquina"
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_mdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource As BindingSource
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource1 As BindingSource
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource2 As BindingSource
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource3 As BindingSource
    Friend WithEvents MaquinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoTecnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents TextBoxNumeroDeMaquina As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxObservaciones As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePickerHora As DateTimePicker
    Friend WithEvents DateTimePickerFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource4 As BindingSource
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource5 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Visual_mdaDataSet As visual_mdaDataSet
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource6 As BindingSource
    Friend WithEvents View_ultimoEstadoFueraDeServicioTableAdapter As visual_mdaDataSetTableAdapters.View_ultimoEstadoFueraDeServicioTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class

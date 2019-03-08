<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario_inicial
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
        Me.ViewultimoEstadoFueraDeServicioBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewultimoEstadoFueraDeServicioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewultimoEstadoFueraDeServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewultimoEstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewultimoEstadoFueraDeServicioBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Visual_mdaDataSet = New Aplicacion.visual_mdaDataSet()
        Me.View_ultimoEstadoFueraDeServicioTableAdapter = New Aplicacion.visual_mdaDataSetTableAdapters.View_ultimoEstadoFueraDeServicioTableAdapter()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_mdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewultimoEstadoFueraDeServicioBindingSource1
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource1.DataMember = "View_ultimoEstadoFueraDeServicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(676, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ESTADO ACTUAL MAQUINAS FUERA DE SERVICIO"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "FUERA DE SERVICIO / ACTUALIZACION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(251, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "HABILITAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(479, 420)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(222, 57)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "ELIMINAR REGISTRO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(829, 420)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(222, 57)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "SALIR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.DataSource = Me.ViewultimoEstadoFueraDeServicioBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(37, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(931, 291)
        Me.DataGridView1.TabIndex = 6
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "maquina"
        Me.DataGridViewTextBoxColumn6.HeaderText = "maquina"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "estadoTecnico"
        Me.DataGridViewTextBoxColumn7.HeaderText = "estadoTecnico"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn8.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'ViewultimoEstadoFueraDeServicioBindingSource3
        '
        Me.ViewultimoEstadoFueraDeServicioBindingSource3.DataMember = "View_ultimoEstadoFueraDeServicio"
        Me.ViewultimoEstadoFueraDeServicioBindingSource3.DataSource = Me.Visual_mdaDataSet
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
        'Formulario_inicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 507)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Formulario_inicial"
        Me.Text = "Formulario_inicial"
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewultimoEstadoFueraDeServicioBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_mdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewultimoEstadoBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents MaquinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoTecnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource As BindingSource
    Friend WithEvents Button4 As Button
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource1 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Visual_mdaDataSet As visual_mdaDataSet
    Friend WithEvents ViewultimoEstadoFueraDeServicioBindingSource3 As BindingSource
    Friend WithEvents View_ultimoEstadoFueraDeServicioTableAdapter As visual_mdaDataSetTableAdapters.View_ultimoEstadoFueraDeServicioTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class

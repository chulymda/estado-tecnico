<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Eliminar_registro
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoTecnicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Visual_mdaDataSet1 = New Aplicacion.visual_mdaDataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonAceptar = New System.Windows.Forms.Button()
        Me.MaquinasFueraDeServicioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaquinasFueraDeServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Visual_mdaDataSet = New Aplicacion.visual_mdaDataSet()
        Me.VisualmdaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EstadoTecnicoTableAdapter = New Aplicacion.visual_mdaDataSet1TableAdapters.estadoTecnicoTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadoTecnicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_mdaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaquinasFueraDeServicioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaquinasFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visual_mdaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisualmdaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ButtonAceptar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(828, 428)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Eliminar registro"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataGridView1.DataSource = Me.EstadoTecnicoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(783, 331)
        Me.DataGridView1.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "maquina"
        Me.DataGridViewTextBoxColumn2.HeaderText = "maquina"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "estadoTecnico"
        Me.DataGridViewTextBoxColumn4.HeaderText = "estadoTecnico"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn5.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'EstadoTecnicoBindingSource
        '
        Me.EstadoTecnicoBindingSource.DataMember = "estadoTecnico"
        Me.EstadoTecnicoBindingSource.DataSource = Me.Visual_mdaDataSet1
        '
        'Visual_mdaDataSet1
        '
        Me.Visual_mdaDataSet1.DataSetName = "visual_mdaDataSet1"
        Me.Visual_mdaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(166, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 56)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAceptar.Location = New System.Drawing.Point(16, 366)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(140, 56)
        Me.ButtonAceptar.TabIndex = 6
        Me.ButtonAceptar.Text = "ELIMINAR"
        Me.ButtonAceptar.UseVisualStyleBackColor = True
        '
        'MaquinasFueraDeServicioBindingSource
        '
        Me.MaquinasFueraDeServicioBindingSource.DataMember = "maquinasFueraDeServicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(364, 31)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "REGISTROS INGRESADOS"
        '
        'Visual_mdaDataSet
        '
        Me.Visual_mdaDataSet.DataSetName = "visual_mdaDataSet"
        Me.Visual_mdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisualmdaDataSetBindingSource
        '
        Me.VisualmdaDataSetBindingSource.DataSource = Me.Visual_mdaDataSet
        Me.VisualmdaDataSetBindingSource.Position = 0
        '
        'EstadoTecnicoTableAdapter
        '
        Me.EstadoTecnicoTableAdapter.ClearBeforeFill = True
        '
        'Eliminar_registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 483)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Eliminar_registro"
        Me.Text = "Eliminar_registro"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadoTecnicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_mdaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaquinasFueraDeServicioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaquinasFueraDeServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visual_mdaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisualmdaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaquinasFueraDeServicioBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaquinaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoTecnicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonAceptar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MaquinasFueraDeServicioBindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VisualmdaDataSetBindingSource As BindingSource
    Friend WithEvents Visual_mdaDataSet As visual_mdaDataSet
    Friend WithEvents Visual_mdaDataSet1 As visual_mdaDataSet1
    Friend WithEvents EstadoTecnicoBindingSource As BindingSource
    Friend WithEvents EstadoTecnicoTableAdapter As visual_mdaDataSet1TableAdapters.estadoTecnicoTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class

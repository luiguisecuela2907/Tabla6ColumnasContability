<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        CbbTiposCuentas = New ComboBox()
        TextNombre = New TextBox()
        TextSaldo = New TextBox()
        BttAgregar = New Button()
        BttModificar = New Button()
        BttEliminar = New Button()
        BttSalir = New Button()
        dgvDataCuentas = New DataGridView()
        DatabaseManagerBindingSource = New BindingSource(components)
        CType(dgvDataCuentas, ComponentModel.ISupportInitialize).BeginInit()
        CType(DatabaseManagerBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CbbTiposCuentas
        ' 
        CbbTiposCuentas.FormattingEnabled = True
        CbbTiposCuentas.Items.AddRange(New Object() {"Activo ", "Pasivo ", "Gastos", "Ingresos ", "Capital", "Devaluacion de Activos"})
        CbbTiposCuentas.Location = New Point(124, 452)
        CbbTiposCuentas.Name = "CbbTiposCuentas"
        CbbTiposCuentas.Size = New Size(171, 33)
        CbbTiposCuentas.TabIndex = 0
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(124, 368)
        TextNombre.Margin = New Padding(4, 5, 4, 5)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(277, 31)
        TextNombre.TabIndex = 1
        ' 
        ' TextSaldo
        ' 
        TextSaldo.Location = New Point(440, 368)
        TextSaldo.Margin = New Padding(4, 5, 4, 5)
        TextSaldo.Name = "TextSaldo"
        TextSaldo.Size = New Size(171, 31)
        TextSaldo.TabIndex = 2
        ' 
        ' BttAgregar
        ' 
        BttAgregar.Location = New Point(84, 532)
        BttAgregar.Margin = New Padding(4, 5, 4, 5)
        BttAgregar.Name = "BttAgregar"
        BttAgregar.Size = New Size(107, 38)
        BttAgregar.TabIndex = 4
        BttAgregar.Text = "Agregar "
        BttAgregar.UseVisualStyleBackColor = True
        ' 
        ' BttModificar
        ' 
        BttModificar.Location = New Point(296, 532)
        BttModificar.Margin = New Padding(4, 5, 4, 5)
        BttModificar.Name = "BttModificar"
        BttModificar.Size = New Size(107, 38)
        BttModificar.TabIndex = 5
        BttModificar.Text = "Modificar "
        BttModificar.UseVisualStyleBackColor = True
        ' 
        ' BttEliminar
        ' 
        BttEliminar.Location = New Point(506, 532)
        BttEliminar.Margin = New Padding(4, 5, 4, 5)
        BttEliminar.Name = "BttEliminar"
        BttEliminar.Size = New Size(107, 38)
        BttEliminar.TabIndex = 6
        BttEliminar.Text = "Eliminar "
        BttEliminar.UseVisualStyleBackColor = True
        ' 
        ' BttSalir
        ' 
        BttSalir.Location = New Point(141, 643)
        BttSalir.Margin = New Padding(4, 5, 4, 5)
        BttSalir.Name = "BttSalir"
        BttSalir.Size = New Size(420, 38)
        BttSalir.TabIndex = 7
        BttSalir.Text = "Salir "
        BttSalir.UseVisualStyleBackColor = True
        ' 
        ' dgvDataCuentas
        ' 
        dgvDataCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDataCuentas.Location = New Point(84, 63)
        dgvDataCuentas.Margin = New Padding(4, 5, 4, 5)
        dgvDataCuentas.Name = "dgvDataCuentas"
        dgvDataCuentas.RowHeadersWidth = 62
        dgvDataCuentas.Size = New Size(560, 250)
        dgvDataCuentas.TabIndex = 8
        ' 
        ' DatabaseManagerBindingSource
        ' 
        DatabaseManagerBindingSource.DataSource = GetType(DatabaseManager)
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(726, 750)
        Controls.Add(dgvDataCuentas)
        Controls.Add(BttSalir)
        Controls.Add(BttEliminar)
        Controls.Add(BttModificar)
        Controls.Add(BttAgregar)
        Controls.Add(TextSaldo)
        Controls.Add(TextNombre)
        Controls.Add(CbbTiposCuentas)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form2"
        Text = "Form2"
        CType(dgvDataCuentas, ComponentModel.ISupportInitialize).EndInit()
        CType(DatabaseManagerBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CbbTiposCuentas As ComboBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextSaldo As TextBox
    Friend WithEvents BttAgregar As Button
    Friend WithEvents BttModificar As Button
    Friend WithEvents BttEliminar As Button
    Friend WithEvents BttSalir As Button
    Friend WithEvents dgvDataCuentas As DataGridView
    Friend WithEvents DatabaseManagerBindingSource As BindingSource
End Class

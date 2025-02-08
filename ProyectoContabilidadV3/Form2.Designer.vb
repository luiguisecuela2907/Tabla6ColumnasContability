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
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        CType(dgvDataCuentas, ComponentModel.ISupportInitialize).BeginInit()
        CType(DatabaseManagerBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' CbbTiposCuentas
        ' 
        CbbTiposCuentas.FormattingEnabled = True
        CbbTiposCuentas.Items.AddRange(New Object() {"Activo", "Pasivo", "Gasto", "Ingreso", "Capital", "Devaluacion de Activos"})
        CbbTiposCuentas.Location = New Point(6, 275)
        CbbTiposCuentas.Name = "CbbTiposCuentas"
        CbbTiposCuentas.Size = New Size(171, 29)
        CbbTiposCuentas.TabIndex = 0
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(6, 87)
        TextNombre.Margin = New Padding(4, 5, 4, 5)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(277, 29)
        TextNombre.TabIndex = 1
        ' 
        ' TextSaldo
        ' 
        TextSaldo.Location = New Point(6, 179)
        TextSaldo.Margin = New Padding(4, 5, 4, 5)
        TextSaldo.Name = "TextSaldo"
        TextSaldo.Size = New Size(171, 29)
        TextSaldo.TabIndex = 2
        ' 
        ' BttAgregar
        ' 
        BttAgregar.Location = New Point(7, 406)
        BttAgregar.Margin = New Padding(4, 5, 4, 5)
        BttAgregar.Name = "BttAgregar"
        BttAgregar.Size = New Size(107, 38)
        BttAgregar.TabIndex = 4
        BttAgregar.Text = "Agregar "
        BttAgregar.UseVisualStyleBackColor = True
        ' 
        ' BttModificar
        ' 
        BttModificar.Location = New Point(165, 406)
        BttModificar.Margin = New Padding(4, 5, 4, 5)
        BttModificar.Name = "BttModificar"
        BttModificar.Size = New Size(107, 38)
        BttModificar.TabIndex = 5
        BttModificar.Text = "Modificar "
        BttModificar.UseVisualStyleBackColor = True
        ' 
        ' BttEliminar
        ' 
        BttEliminar.Location = New Point(322, 406)
        BttEliminar.Margin = New Padding(4, 5, 4, 5)
        BttEliminar.Name = "BttEliminar"
        BttEliminar.Size = New Size(107, 38)
        BttEliminar.TabIndex = 6
        BttEliminar.Text = "Eliminar "
        BttEliminar.UseVisualStyleBackColor = True
        ' 
        ' BttSalir
        ' 
        BttSalir.BackColor = Color.IndianRed
        BttSalir.FlatStyle = FlatStyle.Flat
        BttSalir.Location = New Point(7, 454)
        BttSalir.Margin = New Padding(4, 5, 4, 5)
        BttSalir.Name = "BttSalir"
        BttSalir.Size = New Size(422, 38)
        BttSalir.TabIndex = 7
        BttSalir.Text = "Salir "
        BttSalir.UseVisualStyleBackColor = False
        ' 
        ' dgvDataCuentas
        ' 
        dgvDataCuentas.AllowUserToAddRows = False
        dgvDataCuentas.AllowUserToDeleteRows = False
        dgvDataCuentas.AllowUserToResizeColumns = False
        dgvDataCuentas.AllowUserToResizeRows = False
        dgvDataCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDataCuentas.Location = New Point(13, 89)
        dgvDataCuentas.Margin = New Padding(4, 5, 4, 5)
        dgvDataCuentas.Name = "dgvDataCuentas"
        dgvDataCuentas.RowHeadersWidth = 62
        dgvDataCuentas.Size = New Size(698, 432)
        dgvDataCuentas.TabIndex = 8
        ' 
        ' DatabaseManagerBindingSource
        ' 
        DatabaseManagerBindingSource.DataSource = GetType(DatabaseManager)
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(BttSalir)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(BttEliminar)
        GroupBox1.Controls.Add(TextNombre)
        GroupBox1.Controls.Add(BttModificar)
        GroupBox1.Controls.Add(TextSaldo)
        GroupBox1.Controls.Add(BttAgregar)
        GroupBox1.Controls.Add(CbbTiposCuentas)
        GroupBox1.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(727, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.RightToLeft = RightToLeft.No
        GroupBox1.Size = New Size(436, 509)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informacion de la Cuenta"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 21)
        Label3.TabIndex = 10
        Label3.Text = "Tipo de Cuenta"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 21)
        Label2.TabIndex = 10
        Label2.Text = "Saldo de la Cuenta"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 21)
        Label1.TabIndex = 3
        Label1.Text = "Nombre de la Cuenta"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(23, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(698, 72)
        Label4.TabIndex = 10
        Label4.Text = "Cuando desee modificar y eliminar las cuentas, haga click en la casilla en blanco del registro que desee modificar"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1175, 540)
        Controls.Add(Label4)
        Controls.Add(GroupBox1)
        Controls.Add(dgvDataCuentas)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form2"
        Text = "EcoClean - Modificar Cuentas"
        CType(dgvDataCuentas, ComponentModel.ISupportInitialize).EndInit()
        CType(DatabaseManagerBindingSource, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class

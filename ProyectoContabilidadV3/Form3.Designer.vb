<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        dgvReporte = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        CType(dgvReporte, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvReporte
        ' 
        dgvReporte.AllowUserToResizeColumns = False
        dgvReporte.AllowUserToResizeRows = False
        dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReporte.Location = New Point(0, 47)
        dgvReporte.Name = "dgvReporte"
        dgvReporte.RowHeadersWidth = 62
        dgvReporte.Size = New Size(971, 593)
        dgvReporte.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(374, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 21)
        Label1.TabIndex = 1
        Label1.Text = "l Balance de Comprobacion l"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(578, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 21)
        Label2.TabIndex = 2
        Label2.Text = "Ganancias o Perdidas"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(785, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 21)
        Label3.TabIndex = 3
        Label3.Text = "Balance General"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(977, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(299, 605)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.Location = New Point(6, 569)
        Label16.Name = "Label16"
        Label16.Size = New Size(241, 31)
        Label16.TabIndex = 14
        Label16.Text = "NEG: Debe Balance General"
        ' 
        ' Label15
        ' 
        Label15.Location = New Point(6, 538)
        Label15.Name = "Label15"
        Label15.Size = New Size(241, 31)
        Label15.TabIndex = 13
        Label15.Text = "POS: Haber Balance General"
        ' 
        ' Label14
        ' 
        Label14.Location = New Point(6, 474)
        Label14.Name = "Label14"
        Label14.Size = New Size(276, 55)
        Label14.TabIndex = 12
        Label14.Text = "Se resta Haber - Debe del Estado de Ganancias o Perdidas."
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(6, 439)
        Label13.Name = "Label13"
        Label13.Size = New Size(287, 25)
        Label13.TabIndex = 11
        Label13.Text = "Utilidad / Perdida del Ejercicio"
        ' 
        ' Label10
        ' 
        Label10.Location = New Point(6, 363)
        Label10.Name = "Label10"
        Label10.Size = New Size(276, 55)
        Label10.TabIndex = 10
        Label10.Text = "HABER: Pasivos, Capital, Devaluacion Activos"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 338)
        Label11.Name = "Label11"
        Label11.Size = New Size(120, 25)
        Label11.TabIndex = 9
        Label11.Text = "DEBE: Activos"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(6, 297)
        Label12.Name = "Label12"
        Label12.Size = New Size(153, 25)
        Label12.TabIndex = 8
        Label12.Text = "Balance General"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 242)
        Label9.Name = "Label9"
        Label9.Size = New Size(144, 25)
        Label9.TabIndex = 7
        Label9.Text = "HABER: Ingresos"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 217)
        Label8.Name = "Label8"
        Label8.Size = New Size(116, 25)
        Label8.TabIndex = 6
        Label8.Text = "DEBE: Gastos"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(6, 176)
        Label7.Name = "Label7"
        Label7.Size = New Size(201, 25)
        Label7.TabIndex = 5
        Label7.Text = "Ganancias o Perdidas"
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(6, 90)
        Label6.Name = "Label6"
        Label6.Size = New Size(277, 54)
        Label6.TabIndex = 6
        Label6.Text = "HABER: Pasivos, Ingresos, Capital, Devaluacion Activos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 25)
        Label5.TabIndex = 5
        Label5.Text = "DEBE: Activos, Gastos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(241, 25)
        Label4.TabIndex = 0
        Label4.Text = "Balance de Comprobacion"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1285, 652)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvReporte)
        Name = "Form3"
        Text = "EcoClean - Hoja de Trabajo de 6 Columnas"
        CType(dgvReporte, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvReporte As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class

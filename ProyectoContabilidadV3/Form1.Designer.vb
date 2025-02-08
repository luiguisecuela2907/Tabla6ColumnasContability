<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnCuentas = New Button()
        BtnTabla = New Button()
        BtnSalir = New Button()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnCuentas
        ' 
        BtnCuentas.Location = New Point(59, 67)
        BtnCuentas.Margin = New Padding(4, 5, 4, 5)
        BtnCuentas.Name = "BtnCuentas"
        BtnCuentas.Size = New Size(185, 48)
        BtnCuentas.TabIndex = 0
        BtnCuentas.Text = "Modificar Cuentas"
        BtnCuentas.UseVisualStyleBackColor = True
        ' 
        ' BtnTabla
        ' 
        BtnTabla.Location = New Point(59, 170)
        BtnTabla.Margin = New Padding(4, 5, 4, 5)
        BtnTabla.Name = "BtnTabla"
        BtnTabla.Size = New Size(185, 48)
        BtnTabla.TabIndex = 1
        BtnTabla.Text = "Mostrar Tabla"
        BtnTabla.UseVisualStyleBackColor = True
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = Color.IndianRed
        BtnSalir.FlatStyle = FlatStyle.Flat
        BtnSalir.Location = New Point(59, 281)
        BtnSalir.Margin = New Padding(4, 5, 4, 5)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(185, 48)
        BtnSalir.TabIndex = 2
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BtnCuentas)
        GroupBox1.Controls.Add(BtnSalir)
        GroupBox1.Controls.Add(BtnTabla)
        GroupBox1.Location = New Point(71, 201)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 393)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Thistle
        Label1.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 189)
        Label1.TabIndex = 4
        Label1.Text = "ECOCLEAN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(444, 644)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Eco Clean - Contabilidad"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnCuentas As Button
    Friend WithEvents BtnTabla As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label

End Class

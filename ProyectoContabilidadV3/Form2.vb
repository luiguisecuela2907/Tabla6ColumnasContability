Public Class Form2
    'dbManager = administrador de base de datos
    Private dbManager As DatabaseManager

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa el DatabaseManager con la ruta de la base de datos y crea la tabla si no existe
        dbManager = New DatabaseManager(".\DataBase\Cuentas.db")
        LoadData()
    End Sub

    Private Function TipoCuentaID(tipoCuenta As String) As Integer
        'Devuelve el tipo de cuenta como un valor entero para el campo tipo_id en la tabla cuentas
        Select Case tipoCuenta
            Case "Activo"
                Return 1
            Case "Pasivo"
                Return 2
            Case "Gasto"
                Return 3
            Case "Ingreso"
                Return 4
            Case "Capital"
                Return 5
            Case "Devaluacion de Activos"
                Return 6
            Case Else
                Return 1
        End Select
    End Function

    Private Sub BttAgregar_Click(sender As Object, e As EventArgs) Handles BttAgregar.Click
        ' Validar entradas antes de agregar a la base de datos
        If ValidateInputs() Then
            dbManager.ExecuteNonQuery($"INSERT INTO cuentas (tipo_id, nombre, cantidad) VALUES ('{TipoCuentaID(CbbTiposCuentas.Text)}', '{TextNombre.Text}', '{Convert.ToDouble(TextSaldo.Text)}')")
            LoadData()
        End If
    End Sub

    Private Sub BttEliminar_Click(sender As Object, e As EventArgs) Handles BttEliminar.Click
        If dgvDataCuentas.SelectedRows.Count > 0 Then
            Dim id As Integer = CInt(dgvDataCuentas.SelectedRows(0).Cells("id").Value)
            dbManager.ExecuteNonQuery($"DELETE FROM cuentas WHERE id = {id}")
            LoadData()
        Else
            MessageBox.Show("Seleccione una fila para eliminar.")
        End If
    End Sub

    Private Sub BttModificar_Click(sender As Object, e As EventArgs) Handles BttModificar.Click
        If dgvDataCuentas.SelectedRows.Count > 0 Then
            If ValidateInputs() Then
                Dim id As Integer = CInt(dgvDataCuentas.SelectedRows(0).Cells("id").Value)
                dbManager.ExecuteNonQuery($"UPDATE cuentas SET tipo_id = '{TipoCuentaID(CbbTiposCuentas.Text)}', nombre = '{TextNombre.Text}', cantidad = '{Convert.ToDouble(TextSaldo.Text)}' WHERE id = {id}")
                LoadData()
            End If
        Else
            MessageBox.Show("Seleccione una fila para modificar.")
        End If
    End Sub

    Private Sub LoadData()
        dgvDataCuentas.DataSource = dbManager.ExecuteSelectQuery("SELECT id, nombre, cantidad FROM cuentas")
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Verificar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(TextNombre.Text) Then
            MessageBox.Show("El campo Nombre no puede estar vacío.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(TextSaldo.Text) OrElse Not Double.TryParse(TextSaldo.Text, New Double()) Then
            MessageBox.Show("El campo Saldo debe ser un número válido.")
            Return False
        End If
        If String.IsNullOrWhiteSpace(CbbTiposCuentas.Text) Then
            MessageBox.Show("El campo TipoCuenta no puede estar vacío.")
            Return False
        End If
        Return True
    End Function

    Private Sub BttSalir_Click(sender As Object, e As EventArgs) Handles BttSalir.Click
        Close()
    End Sub
End Class
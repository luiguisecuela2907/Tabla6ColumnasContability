Imports System.ComponentModel.Design.Serialization

Public Class Form3
    Private dbManager As DatabaseManager
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa el DatabaseManager con la ruta de la base de datos y crea la tabla si no existe
        dbManager = New DatabaseManager(".\DataBase\Cuentas.db")
        ConfigurarDataGridView()
        CargarDatosEnDataGridView()
    End Sub
    Private Sub ConfigurarDataGridView()
        ' Configurar las columnas del DataGridView
        With dgvReporte.Columns
            'Nombre de Cuentas
            .Add(New DataGridViewTextBoxColumn() With {.Name = "colNombreCuenta", .HeaderText = "Nombre de Cuenta"})
            'Balance de comprobacion
            .Add(New DataGridViewTextBoxColumn() With {.Name = "colDebeComprobacion", .HeaderText = "Debe"})
            .Add(New DataGridViewTextBoxColumn() With {.Name = "colHaberComprobacion", .HeaderText = "Haber"})
            'Estado de Ganancias o Perdidas
            .Add(New DataGridViewTextBoxColumn() With {.Name = "colDebeGanancias", .HeaderText = "Debe"})
            .Add(New DataGridViewTextBoxColumn() With {.Name = "colHaberGanancias", .HeaderText = "Haber"})
            'Balance General
            .Add(New DataGridViewTextBoxColumn() With {.Name = "colDebeGeneral", .HeaderText = "Debe"})
            .Add(New DataGridViewTextBoxColumn() With {.Name = "colHaberGeneral", .HeaderText = "Haber"})
        End With

        dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub


    Private Sub CargarDatosEnDataGridView()
        ' Limpiar las filas del DataGridView antes de cargar nuevos datos
        dgvReporte.Rows.Clear()

        'Obtener todas las cuentas de la tabla 
        Dim dtCuentas As DataTable = dbManager.ExecuteSelectQuery("SELECT tipo_id, nombre, cantidad FROM cuentas")

        'Totales de las Columnas
        Dim totalDebeComprobacion As Decimal = 0
        Dim totalHaberComprobacion As Decimal = 0
        Dim totalDebeGanancias As Decimal = 0
        Dim totalHaberGanancias As Decimal = 0
        Dim utilEjercicio As Decimal = 0
        Dim totalDebeGeneral As Decimal = 0
        Dim totalHaberGeneral As Decimal = 0

        For Each row As DataRow In dtCuentas.Rows
            'Obtener datos principales de cada registro
            Dim tipoCuentaId As Integer = CInt(row("tipo_id"))
            Dim nombreCuenta As String = row("nombre").ToString()
            Dim cantidadCuenta As Decimal = CDec(row("cantidad"))

            Dim saldoDebeComprobacion As Decimal = 0
            Dim saldoHaberComprobacion As Decimal = 0
            Dim saldoDebeGanancias As Decimal = 0
            Dim saldoHaberGanancias As Decimal = 0
            Dim saldoDebeGeneral As Decimal = 0
            Dim saldoHaberGeneral As Decimal = 0

            'Obtener registro del nombre de la cuenta segun tipo_id
            Dim dtTipo As DataTable = dbManager.ExecuteSelectQuery($"SELECT nombre FROM tipos WHERE id = {tipoCuentaId}")

            If dtTipo.Rows.Count > 0 Then
                'Convertir nombre de la cuenta en string
                Dim tipoCuenta As String = dtTipo.Rows(0)("nombre").ToString
                'Logica para el Balance de Comprobacion
                If tipoCuenta = "Activo" OrElse tipoCuenta = "Gasto" Then
                    saldoDebeComprobacion = cantidadCuenta
                    totalDebeComprobacion += cantidadCuenta
                ElseIf tipoCuenta = "Pasivo" OrElse
                    tipoCuenta = "Ingreso" OrElse
                    tipoCuenta = "Capital" OrElse
                    tipoCuenta = "Devaluacion de Activos" Then
                    saldoHaberComprobacion = cantidadCuenta
                    totalHaberComprobacion += cantidadCuenta
                End If
                'Logica para el Estado de Ganancias o Perdidas
                If tipoCuenta = "Gasto" Then
                    saldoDebeGanancias = cantidadCuenta
                    totalDebeGanancias += cantidadCuenta
                ElseIf tipoCuenta = "Ingreso" Then
                    saldoHaberGanancias = cantidadCuenta
                    totalHaberGanancias += cantidadCuenta
                End If
                'Logica para el Balance General
                If tipoCuenta = "Activo" Then
                    saldoDebeGeneral = cantidadCuenta
                    totalDebeGeneral += cantidadCuenta
                ElseIf tipoCuenta = "Pasivo" OrElse
                    tipoCuenta = "Capital" OrElse
                    tipoCuenta = "Devaluacion de Activos" Then
                    saldoHaberGeneral = cantidadCuenta
                    totalHaberGeneral += cantidadCuenta
                End If
            End If

            'Añadir el registro al data grid
            dgvReporte.Rows.Add(nombreCuenta, saldoDebeComprobacion,
                                saldoHaberComprobacion, saldoDebeGanancias,
                                saldoHaberGanancias, saldoDebeGeneral,
                                saldoHaberGeneral)
        Next

        'Añadir fila con totales del Balance de Comprobacion
        dgvReporte.Rows.Add("Totales", totalDebeComprobacion, totalHaberComprobacion, 0, 0, 0, 0)
        'Añadir fila con la perdida o utilidad del ejercicio y totales del Balance General
        utilEjercicio = totalHaberGanancias - totalDebeGanancias
        If utilEjercicio >= 0 Then
            dgvReporte.Rows.Add("Utilidad del Ejercicio", 0, 0, totalDebeGanancias, totalHaberGanancias, 0, utilEjercicio)
            dgvReporte.Rows.Add("Totales", 0, 0, 0, 0, totalDebeGeneral, totalHaberGeneral + utilEjercicio)
        ElseIf utilEjercicio < 0 Then
            Math.Abs(utilEjercicio) 'Volver valor en positivo
            dgvReporte.Rows.Add("Perdida del Ejercicio", 0, 0, totalDebeGanancias, totalHaberGanancias, utilEjercicio, 0)
            dgvReporte.Rows.Add("Totales", 0, 0, 0, 0, totalDebeGeneral + utilEjercicio, totalHaberGeneral)
        End If
    End Sub
End Class
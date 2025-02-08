Imports System.Data.SQLite
'dbPath = data base path = ruta de base de datos

Public Class DatabaseManager
    Private connectionString As String

    ' Constructor que inicializa la cadena de conexión y crea la tabla si no existe
    Public Sub New(dbPath As String)
        connectionString = $"Data Source={dbPath};Version=3;"
    End Sub

    ' Método para abrir y devolver la conexión
    Public Function OpenConnection() As SQLiteConnection
        Dim connection As New SQLiteConnection(connectionString)
        connection.Open()
        Return connection
    End Function

    ' Método para ejecutar una consulta SELECT y devolver un DataTable
    Public Function ExecuteSelectQuery(query As String) As DataTable
        Dim dt As New DataTable()
        Using connection As SQLiteConnection = OpenConnection()
            Using command As New SQLiteCommand(query, connection)
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' Método para ejecutar una consulta que no devuelve resultados (INSERT, UPDATE, DELETE)
    Public Sub ExecuteNonQuery(query As String)
        Using connection As SQLiteConnection = OpenConnection()
            Using command As New SQLiteCommand(query, connection)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
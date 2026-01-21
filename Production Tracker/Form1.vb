Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class Form1

    Private ReadOnly _connString As String =
        "Server=(localdb)\MSSQLLocalDB;Database=ProdPractice;Trusted_Connection=True;TrustServerCertificate=True;"

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim sql As String =
            "SELECT TOP (5000) " &
            "Id, ProductionDate, Email, Employee, Permit, Task, Production, HoursWorked, Notes " &
            "FROM dbo.ProdTable " &
            "ORDER BY ProductionDate DESC, Employee;"

        Dim dt As New DataTable()

        Using conn As New SqlConnection(_connString)
            Using cmd As New SqlCommand(sql, conn)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        dgvProd.DataSource = dt
    End Sub

End Class


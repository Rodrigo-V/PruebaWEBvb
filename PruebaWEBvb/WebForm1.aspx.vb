
Imports System.Data.SqlClient


Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim conn As String = "Data Source=LAPTOP-GUIQPSQR\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True"
        Dim sel As String = "Select * from Empleado"

        Dim da As SqlDataAdapter
        Dim dt As New DataTable

        Try
            da = New SqlDataAdapter(sel, conn)
            da.Fill(dt)

            GridView1.DataSource = dt
            GridView1.DataBind()
            Label1.Text = String.Format("Total datos en la tabla 1: {0}", dt.Rows.Count)

        Catch ex As Exception
            Label1.Text = "Error: " & ex.Message

        End Try






    End Sub

End Class
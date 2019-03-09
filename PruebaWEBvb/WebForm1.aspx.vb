
Imports System.Data.SqlClient



Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim conn As New SqlConnection("Data Source=LAPTOP-GUIQPSQR\SQLEXPRESS;Initial Catalog=Farmacia;Integrated Security=True")
    Dim cmd As New SqlCommand
    Dim leer As SqlDataReader
    Dim dt As New DataTable


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            llenarGrid()
            LlenaCombo()
        End If


    End Sub


    Public Sub LlenaCombo()

        cmd.CommandType = Data.CommandType.StoredProcedure
        cmd.CommandText = "sp_uno"
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim da As New SqlDataAdapter(cmd)

        da.Fill(DS)

        DropDownList1.DataSource = DS
        DropDownList1.DataTextField = "nom_cli"
        DropDownList1.DataValueField = "nom_cli"
        DropDownList1.DataBind()

        conn.Close()

    End Sub


    Public Sub llenarGrid()

        'Armamaos el datatable
        dt.Columns.Add("ID")
        dt.Columns.Add("NOMBRE")
        dt.Columns.Add("CARGO")

        Try
            'Preguntamos si la conexion esta cerrada y la abrimos
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            'Creamos la consulta a la BBDD
            cmd.CommandText = "Select cod_emp, nom_emp, cargo from Empleado"
            cmd.Connection = (conn)

            'Ejecutamos el datareader y el ciclo while llena el datatable
            leer = cmd.ExecuteReader
            While leer.Read
                dt.Rows.Add(leer.Item("cod_emp"), leer.Item("nom_emp"), leer.Item("cargo"))
            End While

            'Llenamos el gridview
            GridView1.DataSource = dt
            GridView1.DataBind()

            'Liberamos memoria del servidor
            dt.Dispose()

        Catch ex As Exception


        Finally

            'Cerramos la conexion
            If conn.State = ConnectionState.Open Then
                conn.Close()
                leer.Close()
            End If
        End Try
    End Sub


End Class
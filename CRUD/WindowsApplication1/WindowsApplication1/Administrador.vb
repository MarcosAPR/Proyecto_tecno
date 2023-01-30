'Librerias para conectar a Sql'
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data

Public Class Administrador
    'Variables para conectar'
    Dim con As New SqlConnection(My.Settings.loginVSConnectionString)
    Dim proceso, mensaje As String
    'conectar a Sql'
    Sub EjecutarEnSQL(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Ocultar el form'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
    'Ocultar todos los botones cuando cargue el form'
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtActualizar.Visible = False
        BtBuscar.Visible = False
        BtEliminar.Visible = False
        BtIngresar.Visible = False
        BtMostrar.Visible = False
    End Sub
    'Proceso de buscar'
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        Try
            Dim da As New SqlDataAdapter("select* from Curd where Nombre = '" + TxtNombre.Text + "'", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Proceso de actualizar'
    Private Sub BtActualizar_Click(sender As Object, e As EventArgs) Handles BtActualizar.Click
        Try
            Dim da As New SqlDataAdapter("update Curd set Nombre = '" + TxtNombre.Text + "', Apellido = '" + TxtApellido.Text + "', Edad = '" + TxtEdad.Text + "', Email = '" + TxtEmail.Text + "', Telefono = '" + TxtTelefono.Text + "' where Id = '" + txtId.Text + "'", con)
            Dim ds As New DataSet
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim da As New SqlDataAdapter("select* from Curd", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Proceso de ingresar'
    Private Sub BtIngresar_Click(sender As Object, e As EventArgs) Handles BtIngresar.Click
        Try
            Dim da As New SqlDataAdapter("insert into Curd values ('" + txtId.Text + "','" + TxtNombre.Text + "','" + TxtApellido.Text + "','" + TxtEdad.Text + "','" + TxtEmail.Text + "','" + TxtTelefono.Text + "')", con)
            Dim ds As New DataSet
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim da As New SqlDataAdapter("select* from Curd", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Proceso de eliminar'
    Private Sub BtEliminar_Click(sender As Object, e As EventArgs) Handles BtEliminar.Click
        Try
            Dim da As New SqlDataAdapter("delete curd where Id = '" + txtId.Text + "'", con)
            Dim ds As New DataSet
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Dim da As New SqlDataAdapter("select* from Curd", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Limpiar textbox'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtId.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtEdad.Text = ""
        TxtEmail.Text = ""
        TxtTelefono.Text = ""
        Try
            Dim da As New SqlDataAdapter("select* from Curd", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Proceso de mostrar'
    Private Sub BtMostrar_Click(sender As Object, e As EventArgs) Handles BtMostrar.Click
        Try
            Dim da As New SqlDataAdapter("select* from Curd", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
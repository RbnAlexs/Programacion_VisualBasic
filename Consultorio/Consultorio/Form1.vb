Imports System.Data.OleDb
Imports System.Data


Public Class Registro

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Documents and Settings\Byen\Mis documentos\Visual Studio 2010\Projects\consultorio\consultorio\consultorio.accdb;")
    Dim IdPaciente As Integer = 0

    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ConsultorioDataSet.Tabla1' Puede moverla o quitarla según sea necesario.
        Me.Tabla1TableAdapter.Fill(Me.ConsultorioDataSet.Tabla1)
        LoadGrid("")
    End Sub

    Private Sub TxtSearch_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.LostFocus
        If TxtSearch.TextLength = 0 Then
            TxtSearch.Text = "Escribe aqui el nombre para buscar, Ej:Mario"
            TxtSearch.ForeColor = Color.BlueViolet


        End If

    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged

        LoadGrid(TxtSearch.Text)
    End Sub

    Public Sub LoadGrid(ByVal SearchString As String)
        con.Open()
        IdPaciente = 0
        Dim dt As New DataTable("consultorio")
        Dim rs As OleDb.OleDbDataAdapter
        If SearchString = "" Or SearchString = "Escribe aqui el nombre para buscar, Ej: Mario" Then
            rs = New OleDb.OleDbDataAdapter("SELECT * FROM consultorio", con)
        Else
            rs = New OleDb.OleDbDataAdapter("SELECT * FROM consultorio WHERE nombre LIKE '" & SearchString & "%' OR apellido LIKE '", con)
        End If

        rs.Fill(dt)

        Dim Index As Integer
        List1.Items.Clear()
        For Index = 0 To dt.Rows.Count - 1
            Dim lst As New ListViewItem

            lst.Text = dt.Rows(Index).Item("ID")
            lst.SubItems.Add(dt.Rows(Index).Item("Nombre"))
            lst.SubItems.Add(dt.Rows(Index).Item("Domicilio"))
            lst.SubItems.Add(dt.Rows(Index).Item("Observaciones"))
            lst.SubItems.Add(dt.Rows(Index).Item("Edad"))
            List1.Items.Add(lst)

        Next

        rs.Dispose()
        con.Close()
    End Sub



    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        If MsgBox("Realmente desea salir?", vbYesNo + vbQuestion, "Salir del programa") = vbYes Then
            Close()
        End If
    End Sub


    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        If IdPaciente = 0 Then
            MsgBox("Selecciona 0primero un registro de la lista")
            Exit Sub

        End If
        If MsgBox("En verdad deseas eliminar este registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
            con.Open()
            Dim rs As New OleDb.OleDbCommand("DELETE FROM consultorio WHERE IdPaciente*" & IdPaciente & " ", con)
            con.Close()
            LoadGrid("")

        End If
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click
        If IdPaciente = 0 Then
            MsgBox("Favor de seleccionar un registro primero!")
            Exit Sub
        End If
        con.Open()
        
    End Sub

    Private Sub Tabla1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabla1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tabla1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ConsultorioDataSet)

    End Sub
End Class

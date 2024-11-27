Imports System.ComponentModel
Imports System.IO

Public Class Formulario
    Dim FICHERO_GENEROS As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Ficheros\Generos.txt")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerGeneros()
        Listado.leerPeliculas()
        idAutoNum()
    End Sub
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim item As New ListViewItem(txtBx_id.Text)
        Listado.listView_guardar.Items.Add(item)
        item.SubItems.Add(txtBx_titulo.Text)
        item.SubItems.Add(txtBx_director.Text)
        item.SubItems.Add(txtBx_protagonista.Text)
        item.SubItems.Add(txtBx_año.Text)
        item.SubItems.Add(cmbBx_genero.Text)
        item.SubItems.Add(txtBx_calificación.Text)
        CheckedListBox.Items.Add(txtBx_titulo.Text)
        If Not cmbBx_genero.Items.Contains(cmbBx_genero.Text) Then
            cmbBx_genero.Items.Add(cmbBx_genero.Text)
        End If

        limpiar()
        idAutoNum()
        Listado.actuaizarPeliculas()



    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiar()
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        For i As Integer = CheckedListBox.CheckedIndices.Count - 1 To 0 Step -1
            Dim index As Integer = CheckedListBox.CheckedIndices(i)

            Dim pelicula As String = CheckedListBox.Items(index).ToString()

            CheckedListBox.Items.RemoveAt(index)

            For Each item As ListViewItem In Listado.listView_guardar.Items
                If item.SubItems(1).Text = pelicula Then
                    Listado.listView_guardar.Items.Remove(item)
                    Exit For
                End If
            Next
        Next

        Dim id As Integer = 0
        For Each item As ListViewItem In Listado.listView_guardar.Items
            item.Text = id
            id = id + 1
        Next
        Listado.actuaizarPeliculas()
        idAutoNum()
    End Sub

    Private Sub limpiar()
        txtBx_titulo.Clear()
        txtBx_director.Clear()
        txtBx_protagonista.Clear()
        txtBx_año.Clear()
        cmbBx_genero.SelectedIndex = -1
        txtBx_calificación.Clear()

    End Sub
    Private Sub idAutoNum()
        txtBx_id.Text = Listado.listView_guardar.Items.Count()
    End Sub


    Private Sub leerGeneros()
        Try
            Using reader As StreamReader = New StreamReader(FICHERO_GENEROS)
                Dim linea As String

                While (reader.Peek >= 0)
                    linea = reader.ReadLine
                    cmbBx_genero.Items.Add(linea)
                    Listado.cmbBx_gen_filtro.Items.Add(linea)
                End While

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al leer los generos: " & ex.Message)
        End Try
    End Sub
    Public Sub guardarGeneros()
        borrarGeneros()

        Try
            Using writer As StreamWriter = New StreamWriter(FICHERO_GENEROS, True)
                For i As Integer = 0 To cmbBx_genero.Items.Count - 1
                    writer.WriteLine(cmbBx_genero.Items(i).ToString())
                Next
                writer.Flush()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar los generos: " & ex.Message)
        End Try
    End Sub


    Private Sub borrarGeneros()
        Try
            Using writer As StreamWriter = New StreamWriter(FICHERO_GENEROS, False)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al borrar los generos: " & ex.Message)
        End Try
    End Sub


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Dim pelisSelec As Integer = txtBx_id.Text
        Dim item As ListViewItem = Listado.listView_guardar.Items(pelisSelec)

        item.SubItems(1).Text = txtBx_titulo.Text
        item.SubItems(2).Text = txtBx_director.Text
        item.SubItems(3).Text = txtBx_protagonista.Text
        item.SubItems(4).Text = txtBx_año.Text
        item.SubItems(5).Text = cmbBx_genero.Text
        item.SubItems(6).Text = txtBx_calificación.Text
        limpiar()
        idAutoNum()
        btn_guardar.Visible = False

    End Sub

    Private Sub Formulario_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        guardarGeneros()
        Listado.guardarPeliculas()
        Application.Exit()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub



    Private Sub txtBx_titulo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBx_titulo.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbBx_genero.Focus()
        End If
    End Sub

    Private Sub cmbBx_genero_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbBx_genero.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtBx_año.Focus()
        End If
    End Sub

    Private Sub txtBx_año_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBx_año.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtBx_director.Focus()
        End If
    End Sub

    Private Sub txtBx_director_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBx_director.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtBx_protagonista.Focus()
        End If
    End Sub

    Private Sub txtBx_protagonista_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBx_protagonista.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtBx_calificación.Focus()
        End If
    End Sub

    Private Sub txtBx_calificación_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBx_calificación.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_agregar.Focus()
        End If
    End Sub

    Private Sub btn_verPeliculas_Click(sender As Object, e As EventArgs) Handles btn_verPeliculas.Click
        Listado.Show()
        Me.Hide()
    End Sub
End Class


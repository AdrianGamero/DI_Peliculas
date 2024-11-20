﻿Imports System.ComponentModel
Imports System.IO

Public Class Formulario
    Dim FICHERO_PELICULAS As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Ficheros\Peliculas.txt")
    Dim FICHERO_GENEROS As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Ficheros\Generos.txt")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerGeneros()
        leerPeliculas()
        idAutoNum()
        duplicarListView()

    End Sub
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim item As New ListViewItem(txtBx_id.Text)
        ListView1.Items.Add(item)
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
        duplicarListView()


    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiar()
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        For i As Integer = CheckedListBox.CheckedIndices.Count - 1 To 0 Step -1
            Dim index As Integer = CheckedListBox.CheckedIndices(i)

            Dim pelicula As String = CheckedListBox.Items(index).ToString()

            CheckedListBox.Items.RemoveAt(index)

            For Each item As ListViewItem In ListView1.Items
                If item.SubItems(1).Text = pelicula Then
                    ListView1.Items.Remove(item)
                    Exit For
                End If
            Next
        Next

        Dim id As Integer = 0
        For Each item As ListViewItem In ListView1.Items
            item.Text = id
            id = id + 1
        Next
        duplicarListView()
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
        txtBx_id.Text = ListView1.Items.Count()
    End Sub

    Private Sub leerPeliculas()
        Try
            Using reader As StreamReader = New StreamReader(FICHERO_PELICULAS)
                Dim linea As String

                While (reader.Peek >= 0)
                    linea = reader.ReadLine
                    Dim palabras() As String = linea.Split(","c)
                    Dim item As New ListViewItem(palabras(0))
                    ListView1.Items.Add(item)
                    CheckedListBox.Items.Add(palabras(1))
                    For i As Integer = 1 To palabras.Length - 1
                        item.SubItems.Add(palabras(i))
                    Next

                End While

            End Using
            borrarPeliculas()

        Catch ex As Exception
            MessageBox.Show("Error al leer las peliculas: " & ex.Message)
        End Try
    End Sub
    Private Sub guardarPeliculas()
        Try
            Using writer As StreamWriter = New StreamWriter(FICHERO_PELICULAS, True)
                For Each item As ListViewItem In ListView1.Items
                    Dim linea As String = item.Text
                    For i As Integer = 1 To item.SubItems.Count - 1
                        linea &= "," & item.SubItems(i).Text
                    Next
                    writer.WriteLine(linea)
                Next
                writer.Flush()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guradar las peliculas: " & ex.Message)
        End Try
    End Sub

    Private Sub leerGeneros()
        Try
            Using reader As StreamReader = New StreamReader(FICHERO_GENEROS)
                Dim linea As String

                While (reader.Peek >= 0)
                    linea = reader.ReadLine
                    cmbBx_genero.Items.Add(linea)
                    cmbBx_gen_filtro.Items.Add(linea)
                End While

            End Using
            borrarGeneros()
        Catch ex As Exception
            MessageBox.Show("Error al leer los generos: " & ex.Message)
        End Try
    End Sub
    Private Sub guardarGeneros()
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

    Private Sub borrarPeliculas()
        Try
            Using writer As StreamWriter = New StreamWriter(FICHERO_PELICULAS, False)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al borrar las peliculas: " & ex.Message)
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




    Private Sub ListView_mostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_mostrar.SelectedIndexChanged
        If ListView_mostrar.SelectedItems.Count > 0 Then
            Dim item As ListViewItem = ListView_mostrar.SelectedItems(0)
            txtBx_id.Text = item.Text
            txtBx_titulo.Text = item.SubItems(1).Text
            txtBx_director.Text = item.SubItems(2).Text
            txtBx_protagonista.Text = item.SubItems(3).Text
            txtBx_año.Text = item.SubItems(4).Text
            cmbBx_genero.Text = item.SubItems(5).Text
            txtBx_calificación.Text = item.SubItems(6).Text
            btn_guardar.Visible = True
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click

        Dim pelisSelec As Integer = txtBx_id.Text
        Dim item As ListViewItem = ListView1.Items(pelisSelec)

        item.SubItems(1).Text = txtBx_titulo.Text
        item.SubItems(2).Text = txtBx_director.Text
        item.SubItems(3).Text = txtBx_protagonista.Text
        item.SubItems(4).Text = txtBx_año.Text
        item.SubItems(5).Text = cmbBx_genero.Text
        item.SubItems(6).Text = txtBx_calificación.Text
        limpiar()
        idAutoNum()
        duplicarListView()
        btn_guardar.Visible = False

    End Sub

    Private Sub Formulario_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        guardarGeneros()
        guardarPeliculas()
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
        btn_agregar.Focus()
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        grBx_filtros.Visible = True
    End Sub

    Private Sub cmbBx_cali_fil_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_cfiltrar_Click(sender As Object, e As EventArgs) Handles btn_cfiltrar.Click
        ' Limpiar la lista de destino
        ListView_mostrar.Items.Clear()

        ' Establecer valores por defecto si los campos están vacíos
        Dim añoMinimo As Integer = If(String.IsNullOrWhiteSpace(txtBx_año_min.Text), 1900, CInt(txtBx_año_min.Text))
        Dim añoMaximo As Integer = If(String.IsNullOrWhiteSpace(txtBx_año_max.Text), 2024, CInt(txtBx_año_max.Text))
        Dim calificacionMinima As Double = If(String.IsNullOrWhiteSpace(txtB_cali_min.Text), 0, CDbl(txtB_cali_min.Text))
        Dim calificacionMaxima As Double = If(String.IsNullOrWhiteSpace(txtB_cali_max.Text), 10, CDbl(txtB_cali_max.Text))

        ' Recorrer los elementos del ListView original
        For Each itemOrigen As ListViewItem In ListView1.Items
            ' Verificar filtros de año
            If itemOrigen.SubItems(4).Text >= añoMinimo.ToString() AndAlso itemOrigen.SubItems(4).Text <= añoMaximo.ToString() Then
                ' Verificar filtros de calificación
                If itemOrigen.SubItems(6).Text >= calificacionMinima.ToString() AndAlso itemOrigen.SubItems(6).Text <= calificacionMaxima.ToString() Then
                    ' Verificar filtro de género (si no se seleccionó nada, se omite este filtro)
                    If String.IsNullOrWhiteSpace(cmbBx_gen_filtro.Text) OrElse itemOrigen.SubItems(5).Text = cmbBx_gen_filtro.Text Then
                        ' Crear un nuevo elemento para el ListView destino
                        Dim nuevoItem As ListViewItem = New ListViewItem(itemOrigen.Text)
                        For i As Integer = 1 To itemOrigen.SubItems.Count - 1
                            nuevoItem.SubItems.Add(itemOrigen.SubItems(i).Text)
                        Next
                        ' Agregar el nuevo ítem al ListView destino
                        ListView_mostrar.Items.Add(nuevoItem)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub duplicarListView()
        If ListView_mostrar.Columns.Count = 0 Then
            For Each columna As ColumnHeader In ListView_mostrar.Columns
                ListView1.Columns.Add(DirectCast(columna.Clone(), ColumnHeader))
            Next
        End If

        ListView_mostrar.Items.Clear()
        For Each itemOrigen As ListViewItem In ListView1.Items
            Dim nuevoItem As ListViewItem = New ListViewItem(itemOrigen.Text)
            For i As Integer = 1 To itemOrigen.SubItems.Count - 1
                nuevoItem.SubItems.Add(itemOrigen.SubItems(i).Text)
            Next
            ListView_mostrar.Items.Add(nuevoItem)
        Next
    End Sub
End Class


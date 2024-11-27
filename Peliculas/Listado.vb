Imports System.ComponentModel
Imports System.IO

Public Class Listado
    Dim FICHERO_PELICULAS As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Ficheros\Peliculas.txt")
    Private Sub Listado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actuaizarPeliculas()
    End Sub


    Private Sub btn_cfiltrar_Click(sender As Object, e As EventArgs) Handles btn_cfiltrar.Click
        actuaizarPeliculas()
        If Not IsNumeric(txtBx_año_max.Text) Or Not IsNumeric(txtBx_año_min.Text) Or Not IsNumeric(txtB_cali_max.Text) Or Not IsNumeric(txtB_cali_min.Text) Then
            MessageBox.Show(" El año y la calificaión deben ser numericos")
        Else
            Dim añoMin As Integer = If(String.IsNullOrWhiteSpace(txtBx_año_min.Text), 0, CInt(txtBx_año_min.Text))
            Dim añoMax As Integer = If(String.IsNullOrWhiteSpace(txtBx_año_max.Text), Integer.MaxValue, CInt(txtBx_año_max.Text))
            Dim calificacionMin As Double = If(String.IsNullOrWhiteSpace(txtB_cali_min.Text), 0, CDbl(txtB_cali_min.Text))
            Dim calificacionMax As Double = If(String.IsNullOrWhiteSpace(txtB_cali_max.Text), 10, CDbl(txtB_cali_max.Text))
            Dim genero As String = If(String.IsNullOrWhiteSpace(cmbBx_gen_filtro.Text), "", cmbBx_gen_filtro.Text.ToLower())

            For Each item As ListViewItem In listView_mostrar.Items
                Dim año As Integer = CInt(item.SubItems(4).Text)
                Dim calificacion As Double = CDbl(item.SubItems(6).Text)
                Dim generoPelicula As String = item.SubItems(5).Text.ToLower()

                If año < añoMin OrElse año > añoMax OrElse
               calificacion < calificacionMin OrElse calificacion > calificacionMax OrElse
               (Not String.IsNullOrEmpty(genero) AndAlso Not generoPelicula.Contains(genero)) Then
                    item.Remove()
                End If
            Next

            grBx_filtros.Visible = False
        End If



    End Sub



    Private Sub ListView_mostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listView_mostrar.SelectedIndexChanged

        If listView_mostrar.SelectedItems.Count > 0 Then
            Dim item = listView_mostrar.SelectedItems(0)
            Formulario.txtBx_id.Text = item.Text
            Formulario.txtBx_titulo.Text = item.SubItems(1).Text
            Formulario.txtBx_director.Text = item.SubItems(2).Text
            Formulario.txtBx_protagonista.Text = item.SubItems(3).Text
            Formulario.txtBx_año.Text = item.SubItems(4).Text
            Formulario.cmbBx_genero.Text = item.SubItems(5).Text
            Formulario.txtBx_calificación.Text = item.SubItems(6).Text
            Formulario.btn_guardar.Visible = True
        End If
        Formulario.Show()
        Me.Hide()
    End Sub

    Public Sub guardarPeliculas()
        borrarPeliculas()
        Try
            Using writer As StreamWriter = New StreamWriter(FICHERO_PELICULAS, True)
                For Each item As ListViewItem In listView_guardar.Items
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

    Public Sub leerPeliculas()
        Try
            Using reader As StreamReader = New StreamReader(FICHERO_PELICULAS)
                Dim linea As String

                While (reader.Peek >= 0)
                    linea = reader.ReadLine
                    Dim palabras() As String = linea.Split(","c)
                    Dim item As New ListViewItem(palabras(0))
                    listView_guardar.Items.Add(item)
                    Formulario.CheckedListBox.Items.Add(palabras(1))
                    For i As Integer = 1 To palabras.Length - 1
                        item.SubItems.Add(palabras(i))
                    Next

                End While

            End Using
            actuaizarPeliculas()


        Catch ex As Exception
            MessageBox.Show("Error al leer las peliculas: " & ex.Message)
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

    Public Sub actuaizarPeliculas()
        listView_mostrar.Items.Clear()
        For Each item As ListViewItem In listView_guardar.Items
            listView_mostrar.Items.Add(CType(item.Clone(), ListViewItem))
        Next
    End Sub

    Private Sub btn_cancel_fil_Click(sender As Object, e As EventArgs) Handles btn_cancel_fil.Click
        limpiar()
        grBx_filtros.Visible = False
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        limpiar()
        actuaizarPeliculas()
        grBx_filtros.Visible = False
    End Sub
    Private Sub limpiar()
        txtBx_año_min.Clear()
        txtBx_año_max.Clear()
        txtB_cali_min.Clear()
        txtB_cali_max.Clear()
        cmbBx_gen_filtro.SelectedIndex = -1
    End Sub

    Private Sub btn_atras_Click(sender As Object, e As EventArgs) Handles btn_atras.Click
        Formulario.Show()
        Me.Hide()
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        grBx_filtros.Visible = True
    End Sub

    Private Sub Listado_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        guardarPeliculas()
        Formulario.guardarGeneros()
        Application.Exit()
    End Sub


End Class

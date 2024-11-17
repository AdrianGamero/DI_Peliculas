Imports System.IO

Public Class Formulario
    Dim FICHERO_PELICULAS As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Ficheros\peliculas.txt")
    Dim FICHERO_GENEROS As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\..\Ficheros\generos.txt")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        limpiar()
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiar()
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
                    For i As Integer = 0 To item.SubItems.Count - 1
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


End Class


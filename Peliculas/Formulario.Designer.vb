<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtBx_id = New TextBox()
        lbl_contacto = New Label()
        lbl_nombre = New Label()
        txtBx_titulo = New TextBox()
        cmbBx_genero = New ComboBox()
        lbl_genero = New Label()
        grBx_nuevo = New GroupBox()
        btn_guardar = New Button()
        txtBx_director = New TextBox()
        lbl_director = New Label()
        txtBx_protagonista = New TextBox()
        lbl_protagonista = New Label()
        txtBx_año = New TextBox()
        lbl_año = New Label()
        txtBx_calificación = New TextBox()
        lbl_calificacion = New Label()
        btn_salir = New Button()
        btn_cancelar = New Button()
        btn_agregar = New Button()
        grBx_eliminar = New GroupBox()
        CheckedListBox = New CheckedListBox()
        btn_eliminar = New Button()
        btn_verPeliculas = New Button()
        grBx_nuevo.SuspendLayout()
        grBx_eliminar.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBx_id
        ' 
        txtBx_id.Location = New Point(113, 46)
        txtBx_id.Margin = New Padding(3, 2, 3, 2)
        txtBx_id.Name = "txtBx_id"
        txtBx_id.ReadOnly = True
        txtBx_id.Size = New Size(50, 23)
        txtBx_id.TabIndex = 0
        ' 
        ' lbl_contacto
        ' 
        lbl_contacto.AutoSize = True
        lbl_contacto.ImageAlign = ContentAlignment.MiddleRight
        lbl_contacto.Location = New Point(29, 49)
        lbl_contacto.Name = "lbl_contacto"
        lbl_contacto.Size = New Size(18, 15)
        lbl_contacto.TabIndex = 1
        lbl_contacto.Text = "ID"
        lbl_contacto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbl_nombre
        ' 
        lbl_nombre.AutoSize = True
        lbl_nombre.ImageAlign = ContentAlignment.MiddleRight
        lbl_nombre.Location = New Point(29, 89)
        lbl_nombre.Name = "lbl_nombre"
        lbl_nombre.Size = New Size(51, 15)
        lbl_nombre.TabIndex = 6
        lbl_nombre.Text = "Nombre"
        lbl_nombre.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_titulo
        ' 
        txtBx_titulo.Location = New Point(113, 86)
        txtBx_titulo.Margin = New Padding(3, 2, 3, 2)
        txtBx_titulo.Name = "txtBx_titulo"
        txtBx_titulo.Size = New Size(126, 23)
        txtBx_titulo.TabIndex = 5
        ' 
        ' cmbBx_genero
        ' 
        cmbBx_genero.FormattingEnabled = True
        cmbBx_genero.Location = New Point(113, 130)
        cmbBx_genero.Margin = New Padding(3, 2, 3, 2)
        cmbBx_genero.Name = "cmbBx_genero"
        cmbBx_genero.Size = New Size(126, 23)
        cmbBx_genero.TabIndex = 14
        ' 
        ' lbl_genero
        ' 
        lbl_genero.AutoSize = True
        lbl_genero.Location = New Point(29, 133)
        lbl_genero.Name = "lbl_genero"
        lbl_genero.Size = New Size(45, 15)
        lbl_genero.TabIndex = 13
        lbl_genero.Text = "Género"
        lbl_genero.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' grBx_nuevo
        ' 
        grBx_nuevo.Controls.Add(btn_guardar)
        grBx_nuevo.Controls.Add(txtBx_director)
        grBx_nuevo.Controls.Add(lbl_director)
        grBx_nuevo.Controls.Add(txtBx_protagonista)
        grBx_nuevo.Controls.Add(lbl_genero)
        grBx_nuevo.Controls.Add(lbl_protagonista)
        grBx_nuevo.Controls.Add(txtBx_año)
        grBx_nuevo.Controls.Add(lbl_año)
        grBx_nuevo.Controls.Add(txtBx_calificación)
        grBx_nuevo.Controls.Add(lbl_calificacion)
        grBx_nuevo.Controls.Add(btn_salir)
        grBx_nuevo.Controls.Add(btn_cancelar)
        grBx_nuevo.Controls.Add(btn_agregar)
        grBx_nuevo.Controls.Add(txtBx_id)
        grBx_nuevo.Controls.Add(lbl_contacto)
        grBx_nuevo.Controls.Add(txtBx_titulo)
        grBx_nuevo.Controls.Add(lbl_nombre)
        grBx_nuevo.Controls.Add(cmbBx_genero)
        grBx_nuevo.ForeColor = SystemColors.ButtonHighlight
        grBx_nuevo.Location = New Point(40, 11)
        grBx_nuevo.Margin = New Padding(3, 2, 3, 2)
        grBx_nuevo.Name = "grBx_nuevo"
        grBx_nuevo.Padding = New Padding(3, 2, 3, 2)
        grBx_nuevo.Size = New Size(546, 231)
        grBx_nuevo.TabIndex = 15
        grBx_nuevo.TabStop = False
        grBx_nuevo.Text = "Nueva pelicula"
        ' 
        ' btn_guardar
        ' 
        btn_guardar.ForeColor = Color.Black
        btn_guardar.Location = New Point(50, 194)
        btn_guardar.Margin = New Padding(3, 2, 3, 2)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(82, 22)
        btn_guardar.TabIndex = 26
        btn_guardar.Text = "GUARDAR"
        btn_guardar.UseVisualStyleBackColor = True
        btn_guardar.Visible = False
        ' 
        ' txtBx_director
        ' 
        txtBx_director.Location = New Point(347, 89)
        txtBx_director.Margin = New Padding(3, 2, 3, 2)
        txtBx_director.Name = "txtBx_director"
        txtBx_director.Size = New Size(171, 23)
        txtBx_director.TabIndex = 24
        ' 
        ' lbl_director
        ' 
        lbl_director.AutoSize = True
        lbl_director.ImageAlign = ContentAlignment.MiddleRight
        lbl_director.Location = New Point(263, 92)
        lbl_director.Name = "lbl_director"
        lbl_director.Size = New Size(49, 15)
        lbl_director.TabIndex = 25
        lbl_director.Text = "Director"
        lbl_director.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_protagonista
        ' 
        txtBx_protagonista.Location = New Point(347, 133)
        txtBx_protagonista.Margin = New Padding(3, 2, 3, 2)
        txtBx_protagonista.Name = "txtBx_protagonista"
        txtBx_protagonista.Size = New Size(171, 23)
        txtBx_protagonista.TabIndex = 22
        ' 
        ' lbl_protagonista
        ' 
        lbl_protagonista.AutoSize = True
        lbl_protagonista.ImageAlign = ContentAlignment.MiddleRight
        lbl_protagonista.Location = New Point(263, 136)
        lbl_protagonista.Name = "lbl_protagonista"
        lbl_protagonista.Size = New Size(74, 15)
        lbl_protagonista.TabIndex = 23
        lbl_protagonista.Text = "Protagonista"
        lbl_protagonista.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_año
        ' 
        txtBx_año.Location = New Point(292, 46)
        txtBx_año.Margin = New Padding(3, 2, 3, 2)
        txtBx_año.Name = "txtBx_año"
        txtBx_año.Size = New Size(50, 23)
        txtBx_año.TabIndex = 21
        ' 
        ' lbl_año
        ' 
        lbl_año.AutoSize = True
        lbl_año.Location = New Point(215, 49)
        lbl_año.Name = "lbl_año"
        lbl_año.Size = New Size(29, 15)
        lbl_año.TabIndex = 20
        lbl_año.Text = "Año"
        lbl_año.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_calificación
        ' 
        txtBx_calificación.Location = New Point(468, 46)
        txtBx_calificación.Margin = New Padding(3, 2, 3, 2)
        txtBx_calificación.Name = "txtBx_calificación"
        txtBx_calificación.Size = New Size(50, 23)
        txtBx_calificación.TabIndex = 18
        ' 
        ' lbl_calificacion
        ' 
        lbl_calificacion.AutoSize = True
        lbl_calificacion.ImageAlign = ContentAlignment.MiddleRight
        lbl_calificacion.Location = New Point(384, 49)
        lbl_calificacion.Name = "lbl_calificacion"
        lbl_calificacion.Size = New Size(69, 15)
        lbl_calificacion.TabIndex = 19
        lbl_calificacion.Text = "Calificación"
        lbl_calificacion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btn_salir
        ' 
        btn_salir.ForeColor = Color.Black
        btn_salir.Location = New Point(436, 194)
        btn_salir.Margin = New Padding(3, 2, 3, 2)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(82, 22)
        btn_salir.TabIndex = 17
        btn_salir.Text = "SALIR"
        btn_salir.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.ForeColor = Color.Black
        btn_cancelar.Location = New Point(255, 194)
        btn_cancelar.Margin = New Padding(3, 2, 3, 2)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(82, 22)
        btn_cancelar.TabIndex = 16
        btn_cancelar.Text = "CANCELAR"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_agregar
        ' 
        btn_agregar.ForeColor = Color.Black
        btn_agregar.Location = New Point(50, 194)
        btn_agregar.Margin = New Padding(3, 2, 3, 2)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(82, 22)
        btn_agregar.TabIndex = 15
        btn_agregar.Text = "AGREGAR"
        btn_agregar.UseVisualStyleBackColor = True
        ' 
        ' grBx_eliminar
        ' 
        grBx_eliminar.Controls.Add(CheckedListBox)
        grBx_eliminar.Controls.Add(btn_eliminar)
        grBx_eliminar.ForeColor = Color.White
        grBx_eliminar.Location = New Point(690, 12)
        grBx_eliminar.Name = "grBx_eliminar"
        grBx_eliminar.Size = New Size(150, 230)
        grBx_eliminar.TabIndex = 17
        grBx_eliminar.TabStop = False
        grBx_eliminar.Text = "Eliminar"
        ' 
        ' CheckedListBox
        ' 
        CheckedListBox.Font = New Font("Segoe UI", 10.0F)
        CheckedListBox.FormattingEnabled = True
        CheckedListBox.Location = New Point(6, 22)
        CheckedListBox.Name = "CheckedListBox"
        CheckedListBox.Size = New Size(138, 164)
        CheckedListBox.TabIndex = 2
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.ForeColor = Color.Black
        btn_eliminar.Location = New Point(41, 193)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(70, 23)
        btn_eliminar.TabIndex = 1
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' btn_verPeliculas
        ' 
        btn_verPeliculas.Location = New Point(347, 265)
        btn_verPeliculas.Name = "btn_verPeliculas"
        btn_verPeliculas.Size = New Size(198, 34)
        btn_verPeliculas.TabIndex = 18
        btn_verPeliculas.Text = "Ver peliculas"
        btn_verPeliculas.UseVisualStyleBackColor = True
        ' 
        ' Formulario
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(877, 322)
        Controls.Add(btn_verPeliculas)
        Controls.Add(grBx_eliminar)
        Controls.Add(grBx_nuevo)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Formulario"
        Text = " "
        grBx_nuevo.ResumeLayout(False)
        grBx_nuevo.PerformLayout()
        grBx_eliminar.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtBx_id As TextBox
    Friend WithEvents lbl_contacto As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txtBx_titulo As TextBox
    Friend WithEvents cmbBx_genero As ComboBox
    Friend WithEvents lbl_genero As Label
    Friend WithEvents grBx_nuevo As GroupBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents grBx_eliminar As GroupBox
    Friend WithEvents txtBx_año As TextBox
    Friend WithEvents lbl_año As Label
    Friend WithEvents txtBx_calificación As TextBox
    Friend WithEvents lbl_calificacion As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents txtBx_protagonista As TextBox
    Friend WithEvents lbl_protagonista As Label
    Friend WithEvents txtBx_director As TextBox
    Friend WithEvents lbl_director As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_verPeliculas As Button

End Class
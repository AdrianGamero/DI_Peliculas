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
        grBx_filtros = New GroupBox()
        txtBx_año_max = New TextBox()
        txtBx_año_min = New TextBox()
        txtB_cali_max = New TextBox()
        txtB_cali_min = New TextBox()
        btn_cancel_fil = New Button()
        btn_cfiltrar = New Button()
        lbl_año_fil = New Label()
        lbl_cali_fil = New Label()
        lbl_gen_fil = New Label()
        cmbBx_gen_filtro = New ComboBox()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        grBx_eliminar = New GroupBox()
        CheckedListBox = New CheckedListBox()
        btn_eliminar = New Button()
        btn_filtrar = New Button()
        ListView_mostrar = New ListView()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        grBx_nuevo.SuspendLayout()
        grBx_filtros.SuspendLayout()
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
        ' grBx_filtros
        ' 
        grBx_filtros.Controls.Add(txtBx_año_max)
        grBx_filtros.Controls.Add(txtBx_año_min)
        grBx_filtros.Controls.Add(txtB_cali_max)
        grBx_filtros.Controls.Add(txtB_cali_min)
        grBx_filtros.Controls.Add(btn_cancel_fil)
        grBx_filtros.Controls.Add(btn_cfiltrar)
        grBx_filtros.Controls.Add(lbl_año_fil)
        grBx_filtros.Controls.Add(lbl_cali_fil)
        grBx_filtros.Controls.Add(lbl_gen_fil)
        grBx_filtros.Controls.Add(cmbBx_gen_filtro)
        grBx_filtros.ForeColor = Color.White
        grBx_filtros.Location = New Point(276, 11)
        grBx_filtros.Name = "grBx_filtros"
        grBx_filtros.Size = New Size(368, 189)
        grBx_filtros.TabIndex = 27
        grBx_filtros.TabStop = False
        grBx_filtros.Text = "Filtros"
        grBx_filtros.Visible = False
        ' 
        ' txtBx_año_max
        ' 
        txtBx_año_max.Location = New Point(167, 133)
        txtBx_año_max.Name = "txtBx_año_max"
        txtBx_año_max.PlaceholderText = "Max."
        txtBx_año_max.Size = New Size(52, 23)
        txtBx_año_max.TabIndex = 11
        ' 
        ' txtBx_año_min
        ' 
        txtBx_año_min.Location = New Point(98, 133)
        txtBx_año_min.Name = "txtBx_año_min"
        txtBx_año_min.PlaceholderText = "Min."
        txtBx_año_min.Size = New Size(52, 23)
        txtBx_año_min.TabIndex = 10
        ' 
        ' txtB_cali_max
        ' 
        txtB_cali_max.Location = New Point(167, 86)
        txtB_cali_max.Name = "txtB_cali_max"
        txtB_cali_max.PlaceholderText = "Max."
        txtB_cali_max.Size = New Size(52, 23)
        txtB_cali_max.TabIndex = 9
        ' 
        ' txtB_cali_min
        ' 
        txtB_cali_min.Location = New Point(98, 86)
        txtB_cali_min.Name = "txtB_cali_min"
        txtB_cali_min.PlaceholderText = "Min."
        txtB_cali_min.Size = New Size(52, 23)
        txtB_cali_min.TabIndex = 8
        ' 
        ' btn_cancel_fil
        ' 
        btn_cancel_fil.ForeColor = Color.Black
        btn_cancel_fil.Location = New Point(277, 105)
        btn_cancel_fil.Name = "btn_cancel_fil"
        btn_cancel_fil.Size = New Size(75, 23)
        btn_cancel_fil.TabIndex = 7
        btn_cancel_fil.Text = "Cancelar"
        btn_cancel_fil.UseVisualStyleBackColor = True
        ' 
        ' btn_cfiltrar
        ' 
        btn_cfiltrar.ForeColor = Color.Black
        btn_cfiltrar.Location = New Point(277, 61)
        btn_cfiltrar.Name = "btn_cfiltrar"
        btn_cfiltrar.Size = New Size(75, 23)
        btn_cfiltrar.TabIndex = 6
        btn_cfiltrar.Text = "Filtrar"
        btn_cfiltrar.UseVisualStyleBackColor = True
        ' 
        ' lbl_año_fil
        ' 
        lbl_año_fil.AutoSize = True
        lbl_año_fil.Location = New Point(21, 136)
        lbl_año_fil.Name = "lbl_año_fil"
        lbl_año_fil.Size = New Size(29, 15)
        lbl_año_fil.TabIndex = 5
        lbl_año_fil.Text = "Año"
        ' 
        ' lbl_cali_fil
        ' 
        lbl_cali_fil.AutoSize = True
        lbl_cali_fil.Location = New Point(20, 89)
        lbl_cali_fil.Name = "lbl_cali_fil"
        lbl_cali_fil.Size = New Size(69, 15)
        lbl_cali_fil.TabIndex = 3
        lbl_cali_fil.Text = "Calificación"
        ' 
        ' lbl_gen_fil
        ' 
        lbl_gen_fil.AutoSize = True
        lbl_gen_fil.Location = New Point(21, 46)
        lbl_gen_fil.Name = "lbl_gen_fil"
        lbl_gen_fil.Size = New Size(45, 15)
        lbl_gen_fil.TabIndex = 1
        lbl_gen_fil.Text = "Género"
        ' 
        ' cmbBx_gen_filtro
        ' 
        cmbBx_gen_filtro.FormattingEnabled = True
        cmbBx_gen_filtro.Location = New Point(98, 43)
        cmbBx_gen_filtro.Name = "cmbBx_gen_filtro"
        cmbBx_gen_filtro.Size = New Size(121, 23)
        cmbBx_gen_filtro.TabIndex = 0
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.LightSkyBlue
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader7, ColumnHeader8, ColumnHeader4, ColumnHeader5, ColumnHeader3})
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HideSelection = True
        ListView1.Location = New Point(40, 283)
        ListView1.Margin = New Padding(3, 2, 3, 2)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(800, 167)
        ListView1.TabIndex = 16
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ListView1.Visible = False
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Id"
        ColumnHeader1.Width = 30
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Titulo"
        ColumnHeader2.Width = 200
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Director"
        ColumnHeader7.Width = 170
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Protagonista"
        ColumnHeader8.Width = 170
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Año"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Genero"
        ColumnHeader5.Width = 90
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Calificación"
        ColumnHeader3.Width = 80
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
        CheckedListBox.Font = New Font("Segoe UI", 10F)
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
        ' btn_filtrar
        ' 
        btn_filtrar.Location = New Point(759, 255)
        btn_filtrar.Name = "btn_filtrar"
        btn_filtrar.Size = New Size(75, 23)
        btn_filtrar.TabIndex = 18
        btn_filtrar.Text = "Filtrar"
        btn_filtrar.UseVisualStyleBackColor = True
        ' 
        ' ListView_mostrar
        ' 
        ListView_mostrar.BackColor = Color.LightSkyBlue
        ListView_mostrar.Columns.AddRange(New ColumnHeader() {ColumnHeader6, ColumnHeader9, ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader13, ColumnHeader14})
        ListView_mostrar.FullRowSelect = True
        ListView_mostrar.GridLines = True
        ListView_mostrar.HideSelection = True
        ListView_mostrar.Location = New Point(40, 283)
        ListView_mostrar.Margin = New Padding(3, 2, 3, 2)
        ListView_mostrar.MultiSelect = False
        ListView_mostrar.Name = "ListView_mostrar"
        ListView_mostrar.Size = New Size(800, 167)
        ListView_mostrar.TabIndex = 28
        ListView_mostrar.UseCompatibleStateImageBehavior = False
        ListView_mostrar.View = View.Details
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Id"
        ColumnHeader6.Width = 30
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Titulo"
        ColumnHeader9.Width = 200
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Director"
        ColumnHeader10.Width = 170
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "Protagonista"
        ColumnHeader11.Width = 170
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.Text = "Año"
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "Genero"
        ColumnHeader13.Width = 90
        ' 
        ' ColumnHeader14
        ' 
        ColumnHeader14.Text = "Calificación"
        ColumnHeader14.Width = 80
        ' 
        ' Formulario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(877, 477)
        Controls.Add(ListView_mostrar)
        Controls.Add(grBx_filtros)
        Controls.Add(btn_filtrar)
        Controls.Add(grBx_eliminar)
        Controls.Add(grBx_nuevo)
        Controls.Add(ListView1)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Formulario"
        Text = " "
        grBx_nuevo.ResumeLayout(False)
        grBx_nuevo.PerformLayout()
        grBx_filtros.ResumeLayout(False)
        grBx_filtros.PerformLayout()
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
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents grBx_eliminar As GroupBox
    Friend WithEvents txtBx_año As TextBox
    Friend WithEvents lbl_año As Label
    Friend WithEvents txtBx_calificación As TextBox
    Friend WithEvents lbl_calificacion As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents txtBx_protagonista As TextBox
    Friend WithEvents lbl_protagonista As Label
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents txtBx_director As TextBox
    Friend WithEvents lbl_director As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents grBx_filtros As GroupBox
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents lbl_cali_fil As Label
    Friend WithEvents lbl_gen_fil As Label
    Friend WithEvents cmbBx_gen_filtro As ComboBox
    Friend WithEvents lbl_año_fil As Label
    Friend WithEvents btn_cancel_fil As Button
    Friend WithEvents btn_cfiltrar As Button
    Friend WithEvents txtB_cali_max As TextBox
    Friend WithEvents txtB_cali_min As TextBox
    Friend WithEvents txtBx_año_max As TextBox
    Friend WithEvents txtBx_año_min As TextBox
    Friend WithEvents ListView_mostrar As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader

End Class

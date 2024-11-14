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
        txtBx_nombre = New TextBox()
        cmbBx_genero = New ComboBox()
        lbl_genero = New Label()
        GroupBox1 = New GroupBox()
        txtBx_año = New TextBox()
        lbl_año = New Label()
        txtBx_calificación = New TextBox()
        lbl_calificacion = New Label()
        btn_salir = New Button()
        btn_cancelar = New Button()
        btn_agregar = New Button()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        GroupBox2 = New GroupBox()
        ListView2 = New ListView()
        btn_eliminar = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBx_id
        ' 
        txtBx_id.Location = New Point(132, 46)
        txtBx_id.Margin = New Padding(3, 2, 3, 2)
        txtBx_id.Name = "txtBx_id"
        txtBx_id.ReadOnly = True
        txtBx_id.Size = New Size(52, 23)
        txtBx_id.TabIndex = 0
        ' 
        ' lbl_contacto
        ' 
        lbl_contacto.AutoSize = True
        lbl_contacto.ImageAlign = ContentAlignment.MiddleRight
        lbl_contacto.Location = New Point(48, 49)
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
        lbl_nombre.Location = New Point(48, 85)
        lbl_nombre.Name = "lbl_nombre"
        lbl_nombre.Size = New Size(51, 15)
        lbl_nombre.TabIndex = 6
        lbl_nombre.Text = "Nombre"
        lbl_nombre.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_nombre
        ' 
        txtBx_nombre.Location = New Point(132, 82)
        txtBx_nombre.Margin = New Padding(3, 2, 3, 2)
        txtBx_nombre.Name = "txtBx_nombre"
        txtBx_nombre.Size = New Size(126, 23)
        txtBx_nombre.TabIndex = 5
        ' 
        ' cmbBx_genero
        ' 
        cmbBx_genero.FormattingEnabled = True
        cmbBx_genero.Location = New Point(395, 82)
        cmbBx_genero.Margin = New Padding(3, 2, 3, 2)
        cmbBx_genero.Name = "cmbBx_genero"
        cmbBx_genero.Size = New Size(126, 23)
        cmbBx_genero.TabIndex = 14
        ' 
        ' lbl_genero
        ' 
        lbl_genero.AutoSize = True
        lbl_genero.Location = New Point(318, 85)
        lbl_genero.Name = "lbl_genero"
        lbl_genero.Size = New Size(45, 15)
        lbl_genero.TabIndex = 13
        lbl_genero.Text = "Género"
        lbl_genero.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtBx_año)
        GroupBox1.Controls.Add(lbl_año)
        GroupBox1.Controls.Add(txtBx_calificación)
        GroupBox1.Controls.Add(lbl_calificacion)
        GroupBox1.Controls.Add(btn_salir)
        GroupBox1.Controls.Add(btn_cancelar)
        GroupBox1.Controls.Add(btn_agregar)
        GroupBox1.Controls.Add(cmbBx_genero)
        GroupBox1.Controls.Add(txtBx_id)
        GroupBox1.Controls.Add(lbl_genero)
        GroupBox1.Controls.Add(lbl_contacto)
        GroupBox1.Controls.Add(txtBx_nombre)
        GroupBox1.Controls.Add(lbl_nombre)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(40, 11)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(650, 225)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nuevo contacto"
        ' 
        ' txtBx_año
        ' 
        txtBx_año.Location = New Point(395, 46)
        txtBx_año.Margin = New Padding(3, 2, 3, 2)
        txtBx_año.Name = "txtBx_año"
        txtBx_año.Size = New Size(49, 23)
        txtBx_año.TabIndex = 21
        ' 
        ' lbl_año
        ' 
        lbl_año.AutoSize = True
        lbl_año.Location = New Point(318, 49)
        lbl_año.Name = "lbl_año"
        lbl_año.Size = New Size(29, 15)
        lbl_año.TabIndex = 20
        lbl_año.Text = "Año"
        lbl_año.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_calificación
        ' 
        txtBx_calificación.Location = New Point(132, 122)
        txtBx_calificación.Margin = New Padding(3, 2, 3, 2)
        txtBx_calificación.Name = "txtBx_calificación"
        txtBx_calificación.Size = New Size(126, 23)
        txtBx_calificación.TabIndex = 18
        ' 
        ' lbl_calificacion
        ' 
        lbl_calificacion.AutoSize = True
        lbl_calificacion.ImageAlign = ContentAlignment.MiddleRight
        lbl_calificacion.Location = New Point(48, 125)
        lbl_calificacion.Name = "lbl_calificacion"
        lbl_calificacion.Size = New Size(69, 15)
        lbl_calificacion.TabIndex = 19
        lbl_calificacion.Text = "Calificación"
        lbl_calificacion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btn_salir
        ' 
        btn_salir.ForeColor = Color.Black
        btn_salir.Location = New Point(448, 191)
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
        btn_cancelar.Location = New Point(284, 191)
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
        btn_agregar.Location = New Point(50, 191)
        btn_agregar.Margin = New Padding(3, 2, 3, 2)
        btn_agregar.Name = "btn_agregar"
        btn_agregar.Size = New Size(82, 22)
        btn_agregar.TabIndex = 15
        btn_agregar.Text = "AGREGAR"
        btn_agregar.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.LightSkyBlue
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.HideSelection = True
        ListView1.Location = New Point(121, 270)
        ListView1.Margin = New Padding(3, 2, 3, 2)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(800, 167)
        ListView1.TabIndex = 16
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Nº Contacto"
        ColumnHeader1.Width = 95
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "                  Nombre"
        ColumnHeader2.Width = 200
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "    Tipo"
        ColumnHeader3.Width = 70
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "        e-mail"
        ColumnHeader4.Width = 120
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "    Móvil"
        ColumnHeader5.Width = 80
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "          Dirección"
        ColumnHeader6.Width = 150
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Población"
        ColumnHeader7.Width = 80
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btn_eliminar)
        GroupBox2.Controls.Add(ListView2)
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(731, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(272, 225)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' ListView2
        ' 
        ListView2.Location = New Point(6, 22)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(189, 190)
        ListView2.TabIndex = 0
        ListView2.UseCompatibleStateImageBehavior = False
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Location = New Point(212, 187)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(75, 23)
        btn_eliminar.TabIndex = 1
        btn_eliminar.Text = "Eliminar"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' Formulario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(1027, 477)
        Controls.Add(GroupBox2)
        Controls.Add(ListView1)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Formulario"
        Text = " "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtBx_id As TextBox
    Friend WithEvents lbl_contacto As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txtBx_nombre As TextBox
    Friend WithEvents cmbBx_genero As ComboBox
    Friend WithEvents lbl_genero As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBx_año As TextBox
    Friend WithEvents lbl_año As Label
    Friend WithEvents txtBx_calificación As TextBox
    Friend WithEvents lbl_calificacion As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents ListView2 As ListView

End Class

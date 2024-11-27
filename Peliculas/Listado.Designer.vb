<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Listado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grBx_filtros = New GroupBox()
        btn_limpiar = New Button()
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
        listView_guardar = New ListView()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        btn_filtrar = New Button()
        listView_mostrar = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        btn_atras = New Button()
        grBx_filtros.SuspendLayout()
        SuspendLayout()
        ' 
        ' grBx_filtros
        ' 
        grBx_filtros.Controls.Add(btn_limpiar)
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
        grBx_filtros.Location = New Point(224, 12)
        grBx_filtros.Name = "grBx_filtros"
        grBx_filtros.Size = New Size(368, 189)
        grBx_filtros.TabIndex = 28
        grBx_filtros.TabStop = False
        grBx_filtros.Text = "Filtros"
        grBx_filtros.Visible = False
        ' 
        ' btn_limpiar
        ' 
        btn_limpiar.ForeColor = Color.Black
        btn_limpiar.Location = New Point(277, 128)
        btn_limpiar.Name = "btn_limpiar"
        btn_limpiar.Size = New Size(75, 23)
        btn_limpiar.TabIndex = 12
        btn_limpiar.Text = "Limpiar"
        btn_limpiar.UseVisualStyleBackColor = True
        ' 
        ' txtBx_año_max
        ' 
        txtBx_año_max.Location = New Point(167, 133)
        txtBx_año_max.Name = "txtBx_año_max"
        txtBx_año_max.PlaceholderText = "Max."
        txtBx_año_max.Size = New Size(52, 23)
        txtBx_año_max.TabIndex = 11
        txtBx_año_max.Tag = "2024"
        ' 
        ' txtBx_año_min
        ' 
        txtBx_año_min.Location = New Point(98, 133)
        txtBx_año_min.Name = "txtBx_año_min"
        txtBx_año_min.PlaceholderText = "Min."
        txtBx_año_min.Size = New Size(52, 23)
        txtBx_año_min.TabIndex = 10
        txtBx_año_min.Tag = "1800"
        ' 
        ' txtB_cali_max
        ' 
        txtB_cali_max.Location = New Point(167, 86)
        txtB_cali_max.Name = "txtB_cali_max"
        txtB_cali_max.PlaceholderText = "Max."
        txtB_cali_max.Size = New Size(52, 23)
        txtB_cali_max.TabIndex = 9
        txtB_cali_max.Tag = "10"
        ' 
        ' txtB_cali_min
        ' 
        txtB_cali_min.Location = New Point(98, 86)
        txtB_cali_min.Name = "txtB_cali_min"
        txtB_cali_min.PlaceholderText = "Min."
        txtB_cali_min.Size = New Size(52, 23)
        txtB_cali_min.TabIndex = 8
        txtB_cali_min.Tag = "0"
        ' 
        ' btn_cancel_fil
        ' 
        btn_cancel_fil.ForeColor = Color.Black
        btn_cancel_fil.Location = New Point(277, 86)
        btn_cancel_fil.Name = "btn_cancel_fil"
        btn_cancel_fil.Size = New Size(75, 23)
        btn_cancel_fil.TabIndex = 7
        btn_cancel_fil.Text = "Cancelar"
        btn_cancel_fil.UseVisualStyleBackColor = True
        ' 
        ' btn_cfiltrar
        ' 
        btn_cfiltrar.ForeColor = Color.Black
        btn_cfiltrar.Location = New Point(277, 46)
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
        ' listView_guardar
        ' 
        listView_guardar.BackColor = Color.LightSkyBlue
        listView_guardar.Columns.AddRange(New ColumnHeader() {ColumnHeader6, ColumnHeader9, ColumnHeader10, ColumnHeader11, ColumnHeader12, ColumnHeader13, ColumnHeader14})
        listView_guardar.FullRowSelect = True
        listView_guardar.GridLines = True
        listView_guardar.HideSelection = True
        listView_guardar.Location = New Point(11, 51)
        listView_guardar.Margin = New Padding(3, 2, 3, 2)
        listView_guardar.MultiSelect = False
        listView_guardar.Name = "listView_guardar"
        listView_guardar.Size = New Size(800, 388)
        listView_guardar.TabIndex = 29
        listView_guardar.UseCompatibleStateImageBehavior = False
        listView_guardar.View = View.Details
        listView_guardar.Visible = False
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
        ' btn_filtrar
        ' 
        btn_filtrar.Location = New Point(736, 12)
        btn_filtrar.Name = "btn_filtrar"
        btn_filtrar.Size = New Size(75, 23)
        btn_filtrar.TabIndex = 30
        btn_filtrar.Text = "Filtrar"
        btn_filtrar.UseVisualStyleBackColor = True
        ' 
        ' listView_mostrar
        ' 
        listView_mostrar.BackColor = Color.LightSkyBlue
        listView_mostrar.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader7, ColumnHeader8})
        listView_mostrar.FullRowSelect = True
        listView_mostrar.GridLines = True
        listView_mostrar.HideSelection = True
        listView_mostrar.Location = New Point(11, 51)
        listView_mostrar.Margin = New Padding(3, 2, 3, 2)
        listView_mostrar.MultiSelect = False
        listView_mostrar.Name = "listView_mostrar"
        listView_mostrar.Size = New Size(800, 388)
        listView_mostrar.TabIndex = 31
        listView_mostrar.UseCompatibleStateImageBehavior = False
        listView_mostrar.View = View.Details
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
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Director"
        ColumnHeader3.Width = 170
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Protagonista"
        ColumnHeader4.Width = 170
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Año"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Genero"
        ColumnHeader7.Width = 90
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Calificación"
        ColumnHeader8.Width = 80
        ' 
        ' btn_atras
        ' 
        btn_atras.Location = New Point(11, 12)
        btn_atras.Name = "btn_atras"
        btn_atras.Size = New Size(75, 23)
        btn_atras.TabIndex = 32
        btn_atras.Text = "Atrás"
        btn_atras.UseVisualStyleBackColor = True
        ' 
        ' Listado
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(823, 450)
        Controls.Add(btn_atras)
        Controls.Add(grBx_filtros)
        Controls.Add(listView_mostrar)
        Controls.Add(listView_guardar)
        Controls.Add(btn_filtrar)
        Name = "Listado"
        Text = "Listado"
        grBx_filtros.ResumeLayout(False)
        grBx_filtros.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grBx_filtros As GroupBox
    Friend WithEvents txtBx_año_max As TextBox
    Friend WithEvents txtBx_año_min As TextBox
    Friend WithEvents txtB_cali_max As TextBox
    Friend WithEvents txtB_cali_min As TextBox
    Friend WithEvents btn_cancel_fil As Button
    Friend WithEvents btn_cfiltrar As Button
    Friend WithEvents lbl_año_fil As Label
    Friend WithEvents lbl_cali_fil As Label
    Friend WithEvents lbl_gen_fil As Label
    Friend WithEvents cmbBx_gen_filtro As ComboBox
    Friend WithEvents listView_guardar As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents listView_mostrar As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_atras As Button
End Class

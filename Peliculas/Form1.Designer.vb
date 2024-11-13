﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtBx_contacto = New TextBox()
        lbl_contacto = New Label()
        lbl_tipo_contacto = New Label()
        cmbBx_tipo_contacto = New ComboBox()
        lbl_nombre = New Label()
        txtBx_nombre = New TextBox()
        lbl_email = New Label()
        txtBx_email = New TextBox()
        lbl_movil = New Label()
        txtBx_movil = New TextBox()
        lbl_direccion = New Label()
        txtBx_direccion = New TextBox()
        cmbBx_poblacion = New ComboBox()
        lbl_poblacion = New Label()
        GroupBox1 = New GroupBox()
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
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBx_contacto
        ' 
        txtBx_contacto.Location = New Point(132, 46)
        txtBx_contacto.Margin = New Padding(3, 2, 3, 2)
        txtBx_contacto.Name = "txtBx_contacto"
        txtBx_contacto.ReadOnly = True
        txtBx_contacto.Size = New Size(52, 23)
        txtBx_contacto.TabIndex = 0
        ' 
        ' lbl_contacto
        ' 
        lbl_contacto.AutoSize = True
        lbl_contacto.ImageAlign = ContentAlignment.MiddleRight
        lbl_contacto.Location = New Point(48, 49)
        lbl_contacto.Name = "lbl_contacto"
        lbl_contacto.Size = New Size(73, 15)
        lbl_contacto.TabIndex = 1
        lbl_contacto.Text = "Nº Contacto"
        lbl_contacto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lbl_tipo_contacto
        ' 
        lbl_tipo_contacto.AutoSize = True
        lbl_tipo_contacto.Location = New Point(386, 49)
        lbl_tipo_contacto.Name = "lbl_tipo_contacto"
        lbl_tipo_contacto.Size = New Size(96, 15)
        lbl_tipo_contacto.TabIndex = 3
        lbl_tipo_contacto.Text = "Tipo de contacto"
        lbl_tipo_contacto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbBx_tipo_contacto
        ' 
        cmbBx_tipo_contacto.FormattingEnabled = True
        cmbBx_tipo_contacto.Items.AddRange(New Object() {"Amigo", "Conocido", "Familia", "Clase"})
        cmbBx_tipo_contacto.Location = New Point(499, 46)
        cmbBx_tipo_contacto.Margin = New Padding(3, 2, 3, 2)
        cmbBx_tipo_contacto.Name = "cmbBx_tipo_contacto"
        cmbBx_tipo_contacto.Size = New Size(126, 23)
        cmbBx_tipo_contacto.TabIndex = 4
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
        ' lbl_email
        ' 
        lbl_email.AutoSize = True
        lbl_email.ImageAlign = ContentAlignment.MiddleRight
        lbl_email.Location = New Point(48, 118)
        lbl_email.Name = "lbl_email"
        lbl_email.Size = New Size(41, 15)
        lbl_email.TabIndex = 8
        lbl_email.Text = "E-mail"
        lbl_email.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_email
        ' 
        txtBx_email.Location = New Point(132, 116)
        txtBx_email.Margin = New Padding(3, 2, 3, 2)
        txtBx_email.Name = "txtBx_email"
        txtBx_email.Size = New Size(236, 23)
        txtBx_email.TabIndex = 7
        ' 
        ' lbl_movil
        ' 
        lbl_movil.AutoSize = True
        lbl_movil.Location = New Point(445, 99)
        lbl_movil.Name = "lbl_movil"
        lbl_movil.Size = New Size(37, 15)
        lbl_movil.TabIndex = 10
        lbl_movil.Text = "Movil"
        lbl_movil.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_movil
        ' 
        txtBx_movil.Location = New Point(499, 96)
        txtBx_movil.Margin = New Padding(3, 2, 3, 2)
        txtBx_movil.Name = "txtBx_movil"
        txtBx_movil.Size = New Size(126, 23)
        txtBx_movil.TabIndex = 9
        ' 
        ' lbl_direccion
        ' 
        lbl_direccion.AutoSize = True
        lbl_direccion.ImageAlign = ContentAlignment.MiddleRight
        lbl_direccion.Location = New Point(48, 150)
        lbl_direccion.Name = "lbl_direccion"
        lbl_direccion.Size = New Size(57, 15)
        lbl_direccion.TabIndex = 12
        lbl_direccion.Text = "Dirección"
        lbl_direccion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtBx_direccion
        ' 
        txtBx_direccion.Location = New Point(132, 148)
        txtBx_direccion.Margin = New Padding(3, 2, 3, 2)
        txtBx_direccion.Name = "txtBx_direccion"
        txtBx_direccion.Size = New Size(236, 23)
        txtBx_direccion.TabIndex = 11
        ' 
        ' cmbBx_poblacion
        ' 
        cmbBx_poblacion.FormattingEnabled = True
        cmbBx_poblacion.Location = New Point(499, 142)
        cmbBx_poblacion.Margin = New Padding(3, 2, 3, 2)
        cmbBx_poblacion.Name = "cmbBx_poblacion"
        cmbBx_poblacion.Size = New Size(126, 23)
        cmbBx_poblacion.TabIndex = 14
        ' 
        ' lbl_poblacion
        ' 
        lbl_poblacion.AutoSize = True
        lbl_poblacion.Location = New Point(422, 145)
        lbl_poblacion.Name = "lbl_poblacion"
        lbl_poblacion.Size = New Size(60, 15)
        lbl_poblacion.TabIndex = 13
        lbl_poblacion.Text = "Población"
        lbl_poblacion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_salir)
        GroupBox1.Controls.Add(btn_cancelar)
        GroupBox1.Controls.Add(btn_agregar)
        GroupBox1.Controls.Add(lbl_tipo_contacto)
        GroupBox1.Controls.Add(cmbBx_poblacion)
        GroupBox1.Controls.Add(txtBx_contacto)
        GroupBox1.Controls.Add(lbl_poblacion)
        GroupBox1.Controls.Add(lbl_contacto)
        GroupBox1.Controls.Add(lbl_direccion)
        GroupBox1.Controls.Add(cmbBx_tipo_contacto)
        GroupBox1.Controls.Add(txtBx_direccion)
        GroupBox1.Controls.Add(txtBx_nombre)
        GroupBox1.Controls.Add(lbl_movil)
        GroupBox1.Controls.Add(lbl_nombre)
        GroupBox1.Controls.Add(txtBx_movil)
        GroupBox1.Controls.Add(txtBx_email)
        GroupBox1.Controls.Add(lbl_email)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(215, 11)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(650, 225)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nuevo contacto"
        ' 
        ' btn_salir
        ' 
        btn_salir.ForeColor = Color.Black
        btn_salir.Location = New Point(518, 191)
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(1027, 477)
        Controls.Add(ListView1)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = " "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtBx_contacto As TextBox
    Friend WithEvents lbl_contacto As Label
    Friend WithEvents lbl_tipo_contacto As Label
    Friend WithEvents cmbBx_tipo_contacto As ComboBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txtBx_nombre As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents txtBx_email As TextBox
    Friend WithEvents lbl_movil As Label
    Friend WithEvents txtBx_movil As TextBox
    Friend WithEvents lbl_direccion As Label
    Friend WithEvents txtBx_direccion As TextBox
    Friend WithEvents cmbBx_poblacion As ComboBox
    Friend WithEvents lbl_poblacion As Label
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
    Friend WithEvents Label1 As Label

End Class

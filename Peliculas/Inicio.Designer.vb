﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        btn_iniciar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Image = My.Resources.Resources.Logo_150px
        Label1.Location = New Point(325, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 150)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(275, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 37)
        Label2.TabIndex = 1
        Label2.Text = "Gestor de películas"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5000
        ' 
        ' btn_iniciar
        ' 
        btn_iniciar.BackColor = Color.SkyBlue
        btn_iniciar.Cursor = Cursors.Hand
        btn_iniciar.FlatStyle = FlatStyle.Flat
        btn_iniciar.Font = New Font("Segoe UI", 20F)
        btn_iniciar.ForeColor = Color.Black
        btn_iniciar.Location = New Point(275, 267)
        btn_iniciar.Name = "btn_iniciar"
        btn_iniciar.Size = New Size(250, 68)
        btn_iniciar.TabIndex = 2
        btn_iniciar.Text = "Iniciar"
        btn_iniciar.UseVisualStyleBackColor = False
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(784, 383)
        Controls.Add(btn_iniciar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Inicio"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_iniciar As Button
End Class

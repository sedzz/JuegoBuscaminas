﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoginRegistro
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
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnConectarse = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.btnVerContraseña = New System.Windows.Forms.Button()
        Me.lblGuion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(316, 201)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(150, 27)
        Me.txtContraseña.TabIndex = 10
        Me.txtContraseña.Text = "Contraseña"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(316, 145)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(150, 27)
        Me.txtUsuario.TabIndex = 9
        Me.txtUsuario.Text = "Usuario"
        '
        'btnConectarse
        '
        Me.btnConectarse.Location = New System.Drawing.Point(339, 243)
        Me.btnConectarse.Name = "btnConectarse"
        Me.btnConectarse.Size = New System.Drawing.Size(100, 28)
        Me.btnConectarse.TabIndex = 8
        Me.btnConectarse.Text = "Conectarse"
        Me.btnConectarse.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(339, 277)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(100, 32)
        Me.btnRegistro.TabIndex = 7
        Me.btnRegistro.Text = "Registrarse"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'btnVerContraseña
        '
        Me.btnVerContraseña.Location = New System.Drawing.Point(486, 201)
        Me.btnVerContraseña.Name = "btnVerContraseña"
        Me.btnVerContraseña.Size = New System.Drawing.Size(31, 31)
        Me.btnVerContraseña.TabIndex = 11
        Me.btnVerContraseña.UseVisualStyleBackColor = True
        '
        'lblGuion
        '
        Me.lblGuion.Enabled = False
        Me.lblGuion.Location = New System.Drawing.Point(472, 151)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(178, 27)
        Me.lblGuion.TabIndex = 12
        Me.lblGuion.Text = "El nombre no puede incluir '-'"
        '
        'FrmLoginRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGuion)
        Me.Controls.Add(Me.btnVerContraseña)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnConectarse)
        Me.Controls.Add(Me.btnRegistro)
        Me.Name = "FrmLoginRegistro"
        Me.Text = "FrmLoginRegistro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnConectarse As Button
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnVerContraseña As Button
    Friend WithEvents lblGuion As Label
End Class

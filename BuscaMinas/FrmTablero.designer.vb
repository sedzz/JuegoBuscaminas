﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTablero
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
        Me.components = New System.ComponentModel.Container()
        Me.tm1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblNumeroDeBombas = New System.Windows.Forms.Label()
        Me.lblFotoBomba = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tm1
        '
        Me.tm1.Interval = 150
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(258, 9)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(27, 29)
        Me.lblTimer.TabIndex = 0
        Me.lblTimer.Text = "  "
        '
        'lblNumeroDeBombas
        '
        Me.lblNumeroDeBombas.AutoSize = True
        Me.lblNumeroDeBombas.Location = New System.Drawing.Point(88, 20)
        Me.lblNumeroDeBombas.Name = "lblNumeroDeBombas"
        Me.lblNumeroDeBombas.Size = New System.Drawing.Size(0, 16)
        Me.lblNumeroDeBombas.TabIndex = 1
        '
        'lblFotoBomba
        '
        Me.lblFotoBomba.Location = New System.Drawing.Point(24, 9)
        Me.lblFotoBomba.Name = "lblFotoBomba"
        Me.lblFotoBomba.Size = New System.Drawing.Size(45, 29)
        Me.lblFotoBomba.TabIndex = 2
        '
        'FrmTablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lblFotoBomba)
        Me.Controls.Add(Me.lblNumeroDeBombas)
        Me.Controls.Add(Me.lblTimer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmTablero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tm1 As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblNumeroDeBombas As Label
    Friend WithEvents lblFotoBomba As Label
End Class

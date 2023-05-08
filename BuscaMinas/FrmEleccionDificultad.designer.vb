<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEleccionDificultad
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
        Me.btnFacil = New System.Windows.Forms.Button()
        Me.btnMedio = New System.Windows.Forms.Button()
        Me.btnDificil = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJugadorActual = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFacil
        '
        Me.btnFacil.Location = New System.Drawing.Point(671, 23)
        Me.btnFacil.Name = "btnFacil"
        Me.btnFacil.Size = New System.Drawing.Size(90, 55)
        Me.btnFacil.TabIndex = 0
        Me.btnFacil.Text = "Fácil"
        Me.btnFacil.UseVisualStyleBackColor = True
        '
        'btnMedio
        '
        Me.btnMedio.Location = New System.Drawing.Point(671, 105)
        Me.btnMedio.Name = "btnMedio"
        Me.btnMedio.Size = New System.Drawing.Size(90, 53)
        Me.btnMedio.TabIndex = 1
        Me.btnMedio.Text = "Medio"
        Me.btnMedio.UseVisualStyleBackColor = True
        '
        'btnDificil
        '
        Me.btnDificil.Location = New System.Drawing.Point(671, 186)
        Me.btnDificil.Name = "btnDificil"
        Me.btnDificil.Size = New System.Drawing.Size(90, 56)
        Me.btnDificil.TabIndex = 2
        Me.btnDificil.Text = "Difícil"
        Me.btnDificil.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 56)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BUSCAMINAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Jugador : "
        '
        'txtJugadorActual
        '
        Me.txtJugadorActual.Location = New System.Drawing.Point(84, 17)
        Me.txtJugadorActual.Name = "txtJugadorActual"
        Me.txtJugadorActual.Size = New System.Drawing.Size(67, 22)
        Me.txtJugadorActual.TabIndex = 9
        Me.txtJugadorActual.Text = "Anónimo"
        '
        'FrmEleccionDificultad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(794, 434)
        Me.Controls.Add(Me.txtJugadorActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDificil)
        Me.Controls.Add(Me.btnMedio)
        Me.Controls.Add(Me.btnFacil)
        Me.MaximizeBox = False
        Me.Name = "FrmEleccionDificultad"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFacil As Button
    Friend WithEvents btnMedio As Button
    Friend WithEvents btnDificil As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJugadorActual As TextBox
End Class

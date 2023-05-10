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
        Me.txtJugadorActual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDificil = New System.Windows.Forms.Button()
        Me.btnMedio = New System.Windows.Forms.Button()
        Me.btnFacil = New System.Windows.Forms.Button()
        Me.btnMarcador = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtJugadorActual
        '
        Me.txtJugadorActual.Location = New System.Drawing.Point(844, 455)
        Me.txtJugadorActual.Name = "txtJugadorActual"
        Me.txtJugadorActual.Size = New System.Drawing.Size(67, 22)
        Me.txtJugadorActual.TabIndex = 19
        Me.txtJugadorActual.Text = "Anónimo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(772, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Jugador : "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(467, 78)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "BUSCAMINAS"
        '
        'btnDificil
        '
        Me.btnDificil.Location = New System.Drawing.Point(778, 229)
        Me.btnDificil.Name = "btnDificil"
        Me.btnDificil.Size = New System.Drawing.Size(117, 70)
        Me.btnDificil.TabIndex = 16
        Me.btnDificil.Text = "Difícil"
        Me.btnDificil.UseVisualStyleBackColor = True
        '
        'btnMedio
        '
        Me.btnMedio.Location = New System.Drawing.Point(394, 233)
        Me.btnMedio.Name = "btnMedio"
        Me.btnMedio.Size = New System.Drawing.Size(117, 67)
        Me.btnMedio.TabIndex = 15
        Me.btnMedio.Text = "Medio"
        Me.btnMedio.UseVisualStyleBackColor = True
        '
        'btnFacil
        '
        Me.btnFacil.Location = New System.Drawing.Point(17, 229)
        Me.btnFacil.Name = "btnFacil"
        Me.btnFacil.Size = New System.Drawing.Size(117, 69)
        Me.btnFacil.TabIndex = 14
        Me.btnFacil.Text = "Fácil"
        Me.btnFacil.UseVisualStyleBackColor = True
        '
        'btnMarcador
        '
        Me.btnMarcador.Location = New System.Drawing.Point(307, 421)
        Me.btnMarcador.Name = "btnMarcador"
        Me.btnMarcador.Size = New System.Drawing.Size(290, 53)
        Me.btnMarcador.TabIndex = 20
        Me.btnMarcador.Text = "Rankings"
        Me.btnMarcador.UseVisualStyleBackColor = True
        '
        'FrmEleccionDificultad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(931, 500)
        Me.Controls.Add(Me.btnMarcador)
        Me.Controls.Add(Me.txtJugadorActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDificil)
        Me.Controls.Add(Me.btnMedio)
        Me.Controls.Add(Me.btnFacil)
        Me.MaximizeBox = False
        Me.Name = "FrmEleccionDificultad"
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtJugadorActual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDificil As Button
    Friend WithEvents btnMedio As Button
    Friend WithEvents btnFacil As Button
    Friend WithEvents btnMarcador As Button
End Class

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDificil = New System.Windows.Forms.Button()
        Me.btnMedio = New System.Windows.Forms.Button()
        Me.btnFacil = New System.Windows.Forms.Button()
        Me.btnMarcador = New System.Windows.Forms.Button()
        Me.txtJugadorActual = New System.Windows.Forms.TextBox()
        Me.btnParaAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.btnDificil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDificil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDificil.Location = New System.Drawing.Point(778, 229)
        Me.btnDificil.Name = "btnDificil"
        Me.btnDificil.Size = New System.Drawing.Size(117, 70)
        Me.btnDificil.TabIndex = 16
        Me.btnDificil.Text = "Difícil"
        Me.btnDificil.UseVisualStyleBackColor = True
        '
        'btnMedio
        '
        Me.btnMedio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMedio.Location = New System.Drawing.Point(394, 233)
        Me.btnMedio.Name = "btnMedio"
        Me.btnMedio.Size = New System.Drawing.Size(117, 67)
        Me.btnMedio.TabIndex = 15
        Me.btnMedio.Text = "Medio"
        Me.btnMedio.UseVisualStyleBackColor = True
        '
        'btnFacil
        '
        Me.btnFacil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFacil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
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
        'txtJugadorActual
        '
        Me.txtJugadorActual.Enabled = False
        Me.txtJugadorActual.Location = New System.Drawing.Point(923, 485)
        Me.txtJugadorActual.Name = "txtJugadorActual"
        Me.txtJugadorActual.Size = New System.Drawing.Size(10, 22)
        Me.txtJugadorActual.TabIndex = 19
        Me.txtJugadorActual.Text = "Anónimo"
        Me.txtJugadorActual.Visible = False
        '
        'btnParaAtras
        '
        Me.btnParaAtras.Location = New System.Drawing.Point(53, 415)
        Me.btnParaAtras.Name = "btnParaAtras"
        Me.btnParaAtras.Size = New System.Drawing.Size(197, 58)
        Me.btnParaAtras.TabIndex = 21
        Me.btnParaAtras.Text = "Volver"
        Me.btnParaAtras.UseVisualStyleBackColor = True
        '
        'FrmEleccionDificultad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(931, 500)
        Me.Controls.Add(Me.btnParaAtras)
        Me.Controls.Add(Me.btnMarcador)
        Me.Controls.Add(Me.txtJugadorActual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDificil)
        Me.Controls.Add(Me.btnMedio)
        Me.Controls.Add(Me.btnFacil)
        Me.MaximizeBox = False
        Me.Name = "FrmEleccionDificultad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDificil As Button
    Friend WithEvents btnMedio As Button
    Friend WithEvents btnFacil As Button
    Friend WithEvents btnMarcador As Button
    Friend WithEvents txtJugadorActual As TextBox
    Friend WithEvents btnParaAtras As Button
End Class

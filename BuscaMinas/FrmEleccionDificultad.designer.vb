<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEleccionDificultad
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
        Me.btnFacil = New System.Windows.Forms.Button()
        Me.btnMedio = New System.Windows.Forms.Button()
        Me.btnDificil = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(661, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Registrarse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(661, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Conectarse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(638, 268)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 27)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "usuario"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(638, 324)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 27)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "contraseña"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 56)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BUSCAMINAS"
        '
        'FrmEleccionDificultad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDificil)
        Me.Controls.Add(Me.btnMedio)
        Me.Controls.Add(Me.btnFacil)
        Me.Name = "FrmEleccionDificultad"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFacil As Button
    Friend WithEvents btnMedio As Button
    Friend WithEvents btnDificil As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
End Class

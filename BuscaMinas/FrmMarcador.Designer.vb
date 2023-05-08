<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarcador
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
        Me.lstMarcador = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstMarcador
        '
        Me.lstMarcador.FormattingEnabled = True
        Me.lstMarcador.ItemHeight = 16
        Me.lstMarcador.Location = New System.Drawing.Point(154, 57)
        Me.lstMarcador.Name = "lstMarcador"
        Me.lstMarcador.Size = New System.Drawing.Size(611, 372)
        Me.lstMarcador.TabIndex = 0
        '
        'Marcador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.lstMarcador)
        Me.Name = "Marcador"
        Me.Text = "Marcador"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMarcador As ListBox
End Class

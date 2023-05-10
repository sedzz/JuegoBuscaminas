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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbUltimasPuntuaciones = New System.Windows.Forms.GroupBox()
        Me.lstMarcadorUltimos = New System.Windows.Forms.ListBox()
        Me.gbMejoresPuntuaciones = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbUltimasPuntuaciones.SuspendLayout()
        Me.gbMejoresPuntuaciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMarcador
        '
        Me.lstMarcador.FormattingEnabled = True
        Me.lstMarcador.ItemHeight = 23
        Me.lstMarcador.Location = New System.Drawing.Point(30, 38)
        Me.lstMarcador.Name = "lstMarcador"
        Me.lstMarcador.Size = New System.Drawing.Size(360, 142)
        Me.lstMarcador.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.GroupBox1.Controls.Add(Me.gbUltimasPuntuaciones)
        Me.GroupBox1.Controls.Add(Me.gbMejoresPuntuaciones)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(909, 317)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RANKING"
        '
        'gbUltimasPuntuaciones
        '
        Me.gbUltimasPuntuaciones.Controls.Add(Me.lstMarcadorUltimos)
        Me.gbUltimasPuntuaciones.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUltimasPuntuaciones.Location = New System.Drawing.Point(464, 47)
        Me.gbUltimasPuntuaciones.Name = "gbUltimasPuntuaciones"
        Me.gbUltimasPuntuaciones.Size = New System.Drawing.Size(421, 233)
        Me.gbUltimasPuntuaciones.TabIndex = 14
        Me.gbUltimasPuntuaciones.TabStop = False
        Me.gbUltimasPuntuaciones.Text = "ULTIMAS PUNTUACIONES"
        '
        'lstMarcadorUltimos
        '
        Me.lstMarcadorUltimos.FormattingEnabled = True
        Me.lstMarcadorUltimos.ItemHeight = 23
        Me.lstMarcadorUltimos.Location = New System.Drawing.Point(30, 37)
        Me.lstMarcadorUltimos.Name = "lstMarcadorUltimos"
        Me.lstMarcadorUltimos.Size = New System.Drawing.Size(360, 142)
        Me.lstMarcadorUltimos.TabIndex = 1
        '
        'gbMejoresPuntuaciones
        '
        Me.gbMejoresPuntuaciones.Controls.Add(Me.lstMarcador)
        Me.gbMejoresPuntuaciones.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMejoresPuntuaciones.Location = New System.Drawing.Point(17, 46)
        Me.gbMejoresPuntuaciones.Name = "gbMejoresPuntuaciones"
        Me.gbMejoresPuntuaciones.Size = New System.Drawing.Size(420, 234)
        Me.gbMejoresPuntuaciones.TabIndex = 13
        Me.gbMejoresPuntuaciones.TabStop = False
        Me.gbMejoresPuntuaciones.Text = "MEJORES PUNTUACIONES"
        '
        'FrmMarcador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmMarcador"
        Me.Text = "Marcador"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbUltimasPuntuaciones.ResumeLayout(False)
        Me.gbMejoresPuntuaciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMarcador As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbUltimasPuntuaciones As GroupBox
    Friend WithEvents gbMejoresPuntuaciones As GroupBox
    Friend WithEvents lstMarcadorUltimos As ListBox
End Class

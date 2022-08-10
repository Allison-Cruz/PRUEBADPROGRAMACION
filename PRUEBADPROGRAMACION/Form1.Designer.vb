<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.btnMorado = New System.Windows.Forms.Button()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnAzul = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnRosado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(191, 35)
        Me.txtColores.Multiline = True
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(297, 192)
        Me.txtColores.TabIndex = 17
        '
        'btnMorado
        '
        Me.btnMorado.Location = New System.Drawing.Point(55, 117)
        Me.btnMorado.Name = "btnMorado"
        Me.btnMorado.Size = New System.Drawing.Size(75, 23)
        Me.btnMorado.TabIndex = 16
        Me.btnMorado.Text = "Morado"
        Me.btnMorado.UseVisualStyleBackColor = True
        '
        'btnAmarillo
        '
        Me.btnAmarillo.Location = New System.Drawing.Point(55, 159)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(75, 23)
        Me.btnAmarillo.TabIndex = 15
        Me.btnAmarillo.Text = "Amarillo"
        Me.btnAmarillo.UseVisualStyleBackColor = True
        '
        'btnAzul
        '
        Me.btnAzul.Location = New System.Drawing.Point(55, 75)
        Me.btnAzul.Name = "btnAzul"
        Me.btnAzul.Size = New System.Drawing.Size(75, 23)
        Me.btnAzul.TabIndex = 14
        Me.btnAzul.Text = "Azul"
        Me.btnAzul.UseVisualStyleBackColor = True
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(55, 35)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(75, 23)
        Me.btnRojo.TabIndex = 12
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'btnRosado
        '
        Me.btnRosado.Location = New System.Drawing.Point(55, 204)
        Me.btnRosado.Name = "btnRosado"
        Me.btnRosado.Size = New System.Drawing.Size(75, 23)
        Me.btnRosado.TabIndex = 18
        Me.btnRosado.Text = "Rosado"
        Me.btnRosado.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(530, 258)
        Me.Controls.Add(Me.btnRosado)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.btnMorado)
        Me.Controls.Add(Me.btnAmarillo)
        Me.Controls.Add(Me.btnAzul)
        Me.Controls.Add(Me.btnRojo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtColores As TextBox
    Friend WithEvents btnMorado As Button
    Friend WithEvents btnAmarillo As Button
    Friend WithEvents btnAzul As Button
    Friend WithEvents btnRojo As Button
    Friend WithEvents btnRosado As Button
End Class

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
        Me.List1 = New System.Windows.Forms.ListBox
        Me.List2 = New System.Windows.Forms.ListBox
        Me.Command1 = New System.Windows.Forms.Button
        Me.Commant2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(37, 35)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(99, 147)
        Me.List1.TabIndex = 0
        '
        'List2
        '
        Me.List2.FormattingEnabled = True
        Me.List2.Location = New System.Drawing.Point(161, 34)
        Me.List2.Name = "List2"
        Me.List2.Size = New System.Drawing.Size(117, 147)
        Me.List2.TabIndex = 1
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(21, 201)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(114, 35)
        Me.Command1.TabIndex = 2
        Me.Command1.Text = "Button1"
        Me.Command1.UseVisualStyleBackColor = True
        '
        'Commant2
        '
        Me.Commant2.Location = New System.Drawing.Point(171, 202)
        Me.Commant2.Name = "Commant2"
        Me.Commant2.Size = New System.Drawing.Size(106, 33)
        Me.Commant2.TabIndex = 3
        Me.Commant2.Text = "Button2"
        Me.Commant2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 267)
        Me.Controls.Add(Me.Commant2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.List2)
        Me.Controls.Add(Me.List1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents List2 As System.Windows.Forms.ListBox
    Friend WithEvents Command1 As System.Windows.Forms.Button
    Friend WithEvents Commant2 As System.Windows.Forms.Button

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Numeros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Numeros))
        Me.operacion = New System.Windows.Forms.ComboBox
        Me.num1 = New System.Windows.Forms.TextBox
        Me.num2 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.num3 = New System.Windows.Forms.TextBox
        Me.num4 = New System.Windows.Forms.TextBox
        Me.Resultado = New System.Windows.Forms.TextBox
        Me.Res = New System.Windows.Forms.Label
        Me.num5 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'operacion
        '
        Me.operacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operacion.FormattingEnabled = True
        Me.operacion.Items.AddRange(New Object() {"Calcular cúal es menor (A ó B)", "Calcular cúal es mayor (A ó B)", "Indicar si los números introducidos son distintos (A<>B)", "Ordenar de mayor a menor (A y B)", "Operaciones: Si A>B [(A+B) y (A/B)] ó Si B>A [(A*B) y (A-B)]", "Introducir cinco números y visualizarlos en orden creciente ", "Introducir cinco números y visualizarlos en orden decreciente", "Visualizar los números entre 10 y 20 que sean pares", "Calculadora"})
        Me.operacion.Location = New System.Drawing.Point(11, 12)
        Me.operacion.Name = "operacion"
        Me.operacion.Size = New System.Drawing.Size(376, 21)
        Me.operacion.TabIndex = 0
        Me.operacion.Text = "Elige una opción y a continuación ingresa los números"
        '
        'num1
        '
        Me.num1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(77, 70)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(43, 20)
        Me.num1.TabIndex = 1
        Me.num1.Text = "0"
        Me.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num1.Visible = False
        '
        'num2
        '
        Me.num2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num2.Location = New System.Drawing.Point(196, 70)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(45, 20)
        Me.num2.TabIndex = 2
        Me.num2.Text = "0"
        Me.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num2.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(300, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'num3
        '
        Me.num3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num3.Location = New System.Drawing.Point(28, 106)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(43, 20)
        Me.num3.TabIndex = 5
        Me.num3.Text = "0"
        Me.num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num3.Visible = False
        '
        'num4
        '
        Me.num4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num4.Location = New System.Drawing.Point(141, 106)
        Me.num4.Name = "num4"
        Me.num4.Size = New System.Drawing.Size(53, 20)
        Me.num4.TabIndex = 6
        Me.num4.Text = "0"
        Me.num4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num4.Visible = False
        '
        'Resultado
        '
        Me.Resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resultado.Location = New System.Drawing.Point(104, 137)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.ReadOnly = True
        Me.Resultado.Size = New System.Drawing.Size(190, 20)
        Me.Resultado.TabIndex = 8
        Me.Resultado.Text = "0"
        Me.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Resultado.Visible = False
        '
        'Res
        '
        Me.Res.AutoSize = True
        Me.Res.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Res.Enabled = False
        Me.Res.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Res.Location = New System.Drawing.Point(31, 137)
        Me.Res.Name = "Res"
        Me.Res.Size = New System.Drawing.Size(67, 13)
        Me.Res.TabIndex = 9
        Me.Res.Text = "Respuesta"
        Me.Res.Visible = False
        '
        'num5
        '
        Me.num5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num5.Location = New System.Drawing.Point(240, 106)
        Me.num5.Name = "num5"
        Me.num5.Size = New System.Drawing.Size(54, 20)
        Me.num5.TabIndex = 7
        Me.num5.Text = "0"
        Me.num5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num5.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "A"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(179, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "B"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "C"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(127, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "D"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(226, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "E"
        Me.Label6.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Lista de numeros"})
        Me.ListBox1.Location = New System.Drawing.Point(300, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(100, 134)
        Me.ListBox1.TabIndex = 15
        Me.ListBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 31)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(148, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 56)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Calcular"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Numeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(406, 232)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Res)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.num5)
        Me.Controls.Add(Me.num4)
        Me.Controls.Add(Me.num3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.operacion)
        Me.Name = "Numeros"
        Me.Text = "Números e ingresa los números"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents operacion As System.Windows.Forms.ComboBox
    Friend WithEvents num1 As System.Windows.Forms.TextBox
    Friend WithEvents num2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents num3 As System.Windows.Forms.TextBox
    Friend WithEvents num4 As System.Windows.Forms.TextBox
    Friend WithEvents Resultado As System.Windows.Forms.TextBox
    Friend WithEvents Res As System.Windows.Forms.Label
    Friend WithEvents num5 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class

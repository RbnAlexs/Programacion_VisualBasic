<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.siete = New System.Windows.Forms.Button
        Me.ocho = New System.Windows.Forms.Button
        Me.nueve = New System.Windows.Forms.Button
        Me.cuatro = New System.Windows.Forms.Button
        Me.cinco = New System.Windows.Forms.Button
        Me.seis = New System.Windows.Forms.Button
        Me.uno = New System.Windows.Forms.Button
        Me.dos = New System.Windows.Forms.Button
        Me.cero = New System.Windows.Forms.Button
        Me.tres = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.sumar = New System.Windows.Forms.Button
        Me.restar = New System.Windows.Forms.Button
        Me.multiplicar = New System.Windows.Forms.Button
        Me.dividir = New System.Windows.Forms.Button
        Me.salir = New System.Windows.Forms.Button
        Me.borrar = New System.Windows.Forms.Button
        Me.igual = New System.Windows.Forms.Button
        Me.Sig = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'siete
        '
        Me.siete.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siete.Location = New System.Drawing.Point(50, 63)
        Me.siete.Name = "siete"
        Me.siete.Size = New System.Drawing.Size(44, 28)
        Me.siete.TabIndex = 0
        Me.siete.Text = "7"
        Me.siete.UseVisualStyleBackColor = True
        '
        'ocho
        '
        Me.ocho.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ocho.Location = New System.Drawing.Point(100, 63)
        Me.ocho.Name = "ocho"
        Me.ocho.Size = New System.Drawing.Size(44, 28)
        Me.ocho.TabIndex = 1
        Me.ocho.Text = "8"
        Me.ocho.UseVisualStyleBackColor = True
        '
        'nueve
        '
        Me.nueve.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nueve.Location = New System.Drawing.Point(148, 63)
        Me.nueve.Name = "nueve"
        Me.nueve.Size = New System.Drawing.Size(44, 28)
        Me.nueve.TabIndex = 2
        Me.nueve.Text = "9"
        Me.nueve.UseVisualStyleBackColor = True
        '
        'cuatro
        '
        Me.cuatro.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuatro.Location = New System.Drawing.Point(50, 97)
        Me.cuatro.Name = "cuatro"
        Me.cuatro.Size = New System.Drawing.Size(44, 28)
        Me.cuatro.TabIndex = 3
        Me.cuatro.Text = "4"
        Me.cuatro.UseVisualStyleBackColor = True
        '
        'cinco
        '
        Me.cinco.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cinco.Location = New System.Drawing.Point(100, 97)
        Me.cinco.Name = "cinco"
        Me.cinco.Size = New System.Drawing.Size(44, 28)
        Me.cinco.TabIndex = 4
        Me.cinco.Text = "5"
        Me.cinco.UseVisualStyleBackColor = True
        '
        'seis
        '
        Me.seis.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seis.Location = New System.Drawing.Point(150, 97)
        Me.seis.Name = "seis"
        Me.seis.Size = New System.Drawing.Size(44, 28)
        Me.seis.TabIndex = 5
        Me.seis.Text = "6"
        Me.seis.UseVisualStyleBackColor = True
        '
        'uno
        '
        Me.uno.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uno.Location = New System.Drawing.Point(50, 131)
        Me.uno.Name = "uno"
        Me.uno.Size = New System.Drawing.Size(44, 28)
        Me.uno.TabIndex = 6
        Me.uno.Text = "1"
        Me.uno.UseVisualStyleBackColor = True
        '
        'dos
        '
        Me.dos.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dos.Location = New System.Drawing.Point(100, 131)
        Me.dos.Name = "dos"
        Me.dos.Size = New System.Drawing.Size(44, 28)
        Me.dos.TabIndex = 7
        Me.dos.Text = "2"
        Me.dos.UseVisualStyleBackColor = True
        '
        'cero
        '
        Me.cero.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cero.Location = New System.Drawing.Point(100, 165)
        Me.cero.Name = "cero"
        Me.cero.Size = New System.Drawing.Size(44, 28)
        Me.cero.TabIndex = 8
        Me.cero.Text = "0"
        Me.cero.UseVisualStyleBackColor = True
        '
        'tres
        '
        Me.tres.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tres.Location = New System.Drawing.Point(150, 131)
        Me.tres.Name = "tres"
        Me.tres.Size = New System.Drawing.Size(44, 28)
        Me.tres.TabIndex = 9
        Me.tres.Text = "3"
        Me.tres.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextBox1.Location = New System.Drawing.Point(68, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(142, 21)
        Me.TextBox1.TabIndex = 10
        '
        'sumar
        '
        Me.sumar.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumar.Location = New System.Drawing.Point(213, 63)
        Me.sumar.Name = "sumar"
        Me.sumar.Size = New System.Drawing.Size(53, 96)
        Me.sumar.TabIndex = 11
        Me.sumar.Text = "+"
        Me.sumar.UseVisualStyleBackColor = True
        '
        'restar
        '
        Me.restar.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restar.Location = New System.Drawing.Point(272, 129)
        Me.restar.Name = "restar"
        Me.restar.Size = New System.Drawing.Size(56, 26)
        Me.restar.TabIndex = 12
        Me.restar.Text = "-"
        Me.restar.UseVisualStyleBackColor = True
        '
        'multiplicar
        '
        Me.multiplicar.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplicar.Location = New System.Drawing.Point(272, 96)
        Me.multiplicar.Name = "multiplicar"
        Me.multiplicar.Size = New System.Drawing.Size(56, 26)
        Me.multiplicar.TabIndex = 13
        Me.multiplicar.Text = "*"
        Me.multiplicar.UseVisualStyleBackColor = True
        '
        'dividir
        '
        Me.dividir.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dividir.Location = New System.Drawing.Point(272, 65)
        Me.dividir.Name = "dividir"
        Me.dividir.Size = New System.Drawing.Size(56, 26)
        Me.dividir.TabIndex = 14
        Me.dividir.Text = "/"
        Me.dividir.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.Location = New System.Drawing.Point(150, 198)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(60, 37)
        Me.salir.TabIndex = 15
        Me.salir.Text = "SALIR"
        Me.salir.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrar.Location = New System.Drawing.Point(24, 198)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(70, 37)
        Me.borrar.TabIndex = 16
        Me.borrar.Text = "LIMPIAR"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'igual
        '
        Me.igual.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.igual.Location = New System.Drawing.Point(213, 165)
        Me.igual.Name = "igual"
        Me.igual.Size = New System.Drawing.Size(115, 28)
        Me.igual.TabIndex = 17
        Me.igual.Text = "="
        Me.igual.UseVisualStyleBackColor = True
        '
        'Sig
        '
        Me.Sig.AutoSize = True
        Me.Sig.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sig.ForeColor = System.Drawing.Color.Red
        Me.Sig.Location = New System.Drawing.Point(12, 22)
        Me.Sig.Name = "Sig"
        Me.Sig.Size = New System.Drawing.Size(22, 18)
        Me.Sig.TabIndex = 18
        Me.Sig.Text = " 0"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 236)
        Me.Controls.Add(Me.Sig)
        Me.Controls.Add(Me.igual)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.dividir)
        Me.Controls.Add(Me.multiplicar)
        Me.Controls.Add(Me.restar)
        Me.Controls.Add(Me.sumar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tres)
        Me.Controls.Add(Me.cero)
        Me.Controls.Add(Me.dos)
        Me.Controls.Add(Me.uno)
        Me.Controls.Add(Me.seis)
        Me.Controls.Add(Me.cinco)
        Me.Controls.Add(Me.cuatro)
        Me.Controls.Add(Me.nueve)
        Me.Controls.Add(Me.ocho)
        Me.Controls.Add(Me.siete)
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents siete As System.Windows.Forms.Button
    Friend WithEvents ocho As System.Windows.Forms.Button
    Friend WithEvents nueve As System.Windows.Forms.Button
    Friend WithEvents cuatro As System.Windows.Forms.Button
    Friend WithEvents cinco As System.Windows.Forms.Button
    Friend WithEvents seis As System.Windows.Forms.Button
    Friend WithEvents uno As System.Windows.Forms.Button
    Friend WithEvents dos As System.Windows.Forms.Button
    Friend WithEvents cero As System.Windows.Forms.Button
    Friend WithEvents tres As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents sumar As System.Windows.Forms.Button
    Friend WithEvents restar As System.Windows.Forms.Button
    Friend WithEvents multiplicar As System.Windows.Forms.Button
    Friend WithEvents dividir As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents borrar As System.Windows.Forms.Button
    Friend WithEvents igual As System.Windows.Forms.Button
    Friend WithEvents Sig As System.Windows.Forms.Label
End Class

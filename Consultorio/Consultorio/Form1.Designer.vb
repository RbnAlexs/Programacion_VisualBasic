<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtApe = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtObservP = New System.Windows.Forms.TextBox
        Me.txtPesoP = New System.Windows.Forms.TextBox
        Me.txtEstaturaP = New System.Windows.Forms.TextBox
        Me.txtN = New System.Windows.Forms.TextBox
        Me.txtEstadoP = New System.Windows.Forms.TextBox
        Me.txtMunicP = New System.Windows.Forms.TextBox
        Me.txtCalleNumColP = New System.Windows.Forms.TextBox
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Salir = New System.Windows.Forms.Button
        Me.Eliminar = New System.Windows.Forms.Button
        Me.Agregar = New System.Windows.Forms.Button
        Me.Actualizar = New System.Windows.Forms.Button
        Me.ConsultorioDataSet = New Consultorio.consultorioDataSet
        Me.Tabla1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabla1TableAdapter = New Consultorio.consultorioDataSetTableAdapters.Tabla1TableAdapter
        Me.TableAdapterManager = New Consultorio.consultorioDataSetTableAdapters.TableAdapterManager
        Me.Tabla1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.Tabla1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Tabla1DataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabla1BindingNavigator.SuspendLayout()
        CType(Me.Tabla1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(218, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "APELLIDO "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "ID*"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtID.Location = New System.Drawing.Point(13, 193)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(50, 20)
        Me.txtID.TabIndex = 38
        '
        'txtApe
        '
        Me.txtApe.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtApe.Location = New System.Drawing.Point(195, 193)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(112, 20)
        Me.txtApe.TabIndex = 37
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtNombre.Location = New System.Drawing.Point(69, 193)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(120, 20)
        Me.txtNombre.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(136, 263)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(254, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Email"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(118, 227)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 59
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(229, 227)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 58
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(596, 374)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "OBSERVACIONES"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(79, 432)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "PESO"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(279, 412)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "ESTATURA"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(44, 378)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "FECHA DE NACIEMIENTO (DD/MM/AA)"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(543, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "ESTADO"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(292, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "MUNICIPIO O DELEGACIÓN"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(42, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "CALLE, NÚMERO Y COLONIA"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "DIRECCION"
        '
        'txtObservP
        '
        Me.txtObservP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservP.Location = New System.Drawing.Point(599, 397)
        Me.txtObservP.Multiline = True
        Me.txtObservP.Name = "txtObservP"
        Me.txtObservP.Size = New System.Drawing.Size(325, 167)
        Me.txtObservP.TabIndex = 49
        '
        'txtPesoP
        '
        Me.txtPesoP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPesoP.Location = New System.Drawing.Point(74, 409)
        Me.txtPesoP.Name = "txtPesoP"
        Me.txtPesoP.Size = New System.Drawing.Size(72, 20)
        Me.txtPesoP.TabIndex = 48
        '
        'txtEstaturaP
        '
        Me.txtEstaturaP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtEstaturaP.Location = New System.Drawing.Point(282, 389)
        Me.txtEstaturaP.Name = "txtEstaturaP"
        Me.txtEstaturaP.Size = New System.Drawing.Size(72, 20)
        Me.txtEstaturaP.TabIndex = 47
        '
        'txtN
        '
        Me.txtN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtN.Location = New System.Drawing.Point(82, 355)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(84, 20)
        Me.txtN.TabIndex = 46
        '
        'txtEstadoP
        '
        Me.txtEstadoP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtEstadoP.Location = New System.Drawing.Point(479, 303)
        Me.txtEstadoP.Name = "txtEstadoP"
        Me.txtEstadoP.Size = New System.Drawing.Size(202, 20)
        Me.txtEstadoP.TabIndex = 45
        '
        'txtMunicP
        '
        Me.txtMunicP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMunicP.Location = New System.Drawing.Point(271, 303)
        Me.txtMunicP.Name = "txtMunicP"
        Me.txtMunicP.Size = New System.Drawing.Size(202, 20)
        Me.txtMunicP.TabIndex = 44
        '
        'txtCalleNumColP
        '
        Me.txtCalleNumColP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCalleNumColP.Location = New System.Drawing.Point(9, 303)
        Me.txtCalleNumColP.Name = "txtCalleNumColP"
        Me.txtCalleNumColP.Size = New System.Drawing.Size(256, 20)
        Me.txtCalleNumColP.TabIndex = 43
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(362, 162)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(100, 20)
        Me.TxtSearch.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(304, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Buscar"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(499, 205)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 64
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(499, 240)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Eliminar.TabIndex = 65
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(580, 185)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Agregar.TabIndex = 66
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Actualizar
        '
        Me.Actualizar.Location = New System.Drawing.Point(606, 227)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Actualizar.TabIndex = 67
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'ConsultorioDataSet
        '
        Me.ConsultorioDataSet.DataSetName = "consultorioDataSet"
        Me.ConsultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabla1BindingSource
        '
        Me.Tabla1BindingSource.DataMember = "Tabla1"
        Me.Tabla1BindingSource.DataSource = Me.ConsultorioDataSet
        '
        'Tabla1TableAdapter
        '
        Me.Tabla1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Tabla1TableAdapter = Me.Tabla1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Consultorio.consultorioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tabla1BindingNavigator
        '
        Me.Tabla1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tabla1BindingNavigator.BindingSource = Me.Tabla1BindingSource
        Me.Tabla1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tabla1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tabla1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tabla1BindingNavigatorSaveItem})
        Me.Tabla1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tabla1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tabla1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tabla1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tabla1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tabla1BindingNavigator.Name = "Tabla1BindingNavigator"
        Me.Tabla1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tabla1BindingNavigator.Size = New System.Drawing.Size(831, 25)
        Me.Tabla1BindingNavigator.TabIndex = 68
        Me.Tabla1BindingNavigator.Text = "BindingNavigator1"
        Me.Tabla1BindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 20)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Tabla1BindingNavigatorSaveItem
        '
        Me.Tabla1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tabla1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Tabla1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tabla1BindingNavigatorSaveItem.Name = "Tabla1BindingNavigatorSaveItem"
        Me.Tabla1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tabla1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Tabla1DataGridView
        '
        Me.Tabla1DataGridView.AutoGenerateColumns = False
        Me.Tabla1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Tabla1DataGridView.DataSource = Me.Tabla1BindingSource
        Me.Tabla1DataGridView.Location = New System.Drawing.Point(29, 1)
        Me.Tabla1DataGridView.Name = "Tabla1DataGridView"
        Me.Tabla1DataGridView.Size = New System.Drawing.Size(444, 155)
        Me.Tabla1DataGridView.TabIndex = 68
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_PACIENTE"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_PACIENTE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APELLIDO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CALLENUMCOL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CALLENUMCOL"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MUNICIPIO"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MUNICIPIO"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ESTADO"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NACIMIENTO"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NACIMIENTO"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ESTATURA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ESTATURA"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PESO"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PESO"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn10.HeaderText = "OBSERVACIONES"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(831, 568)
        Me.Controls.Add(Me.Tabla1DataGridView)
        Me.Controls.Add(Me.Tabla1BindingNavigator)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtObservP)
        Me.Controls.Add(Me.txtPesoP)
        Me.Controls.Add(Me.txtEstaturaP)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.txtEstadoP)
        Me.Controls.Add(Me.txtMunicP)
        Me.Controls.Add(Me.txtCalleNumColP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "Registro"
        Me.Text = "Consultorio"
        CType(Me.ConsultorioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabla1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabla1BindingNavigator.ResumeLayout(False)
        Me.Tabla1BindingNavigator.PerformLayout()
        CType(Me.Tabla1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtObservP As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoP As System.Windows.Forms.TextBox
    Friend WithEvents txtEstaturaP As System.Windows.Forms.TextBox
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoP As System.Windows.Forms.TextBox
    Friend WithEvents txtMunicP As System.Windows.Forms.TextBox
    Friend WithEvents txtCalleNumColP As System.Windows.Forms.TextBox
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Agregar As System.Windows.Forms.Button
    Friend WithEvents Actualizar As System.Windows.Forms.Button
    Friend WithEvents ConsultorioDataSet As Consultorio.consultorioDataSet
    Friend WithEvents Tabla1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabla1TableAdapter As Consultorio.consultorioDataSetTableAdapters.Tabla1TableAdapter
    Friend WithEvents TableAdapterManager As Consultorio.consultorioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tabla1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tabla1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tabla1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

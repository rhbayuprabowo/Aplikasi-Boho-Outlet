<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCPemasok
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPemasok))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ImageButtonMenyaring = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonMenyegarkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonHapus = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonEdit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonTambah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DatagridPemasok = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.KodePemasokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPemasokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodePosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GambarDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TabelPemasokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PictureboxPemasok = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tabel_PemasokTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_PemasokTableAdapter()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.ImageButtonMenyaring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonHapus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridPemasok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelPemasokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureboxPemasok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonMenyaring)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonMenyegarkan)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonHapus)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonEdit)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonTambah)
        Me.BunifuGradientPanel2.Controls.Add(Me.DatagridPemasok)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuDropdown1)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 187)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1111, 473)
        Me.BunifuGradientPanel2.TabIndex = 11
        '
        'ImageButtonMenyaring
        '
        Me.ImageButtonMenyaring.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ImageButtonMenyaring.Image = CType(resources.GetObject("ImageButtonMenyaring.Image"), System.Drawing.Image)
        Me.ImageButtonMenyaring.ImageActive = Nothing
        Me.ImageButtonMenyaring.Location = New System.Drawing.Point(663, 68)
        Me.ImageButtonMenyaring.Name = "ImageButtonMenyaring"
        Me.ImageButtonMenyaring.Size = New System.Drawing.Size(35, 35)
        Me.ImageButtonMenyaring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonMenyaring.TabIndex = 8
        Me.ImageButtonMenyaring.TabStop = False
        Me.ImageButtonMenyaring.Zoom = 10
        '
        'ImageButtonMenyegarkan
        '
        Me.ImageButtonMenyegarkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ImageButtonMenyegarkan.Image = CType(resources.GetObject("ImageButtonMenyegarkan.Image"), System.Drawing.Image)
        Me.ImageButtonMenyegarkan.ImageActive = Nothing
        Me.ImageButtonMenyegarkan.Location = New System.Drawing.Point(167, 62)
        Me.ImageButtonMenyegarkan.Name = "ImageButtonMenyegarkan"
        Me.ImageButtonMenyegarkan.Size = New System.Drawing.Size(40, 40)
        Me.ImageButtonMenyegarkan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonMenyegarkan.TabIndex = 7
        Me.ImageButtonMenyegarkan.TabStop = False
        Me.ImageButtonMenyegarkan.Zoom = 10
        '
        'ImageButtonHapus
        '
        Me.ImageButtonHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ImageButtonHapus.Image = CType(resources.GetObject("ImageButtonHapus.Image"), System.Drawing.Image)
        Me.ImageButtonHapus.ImageActive = Nothing
        Me.ImageButtonHapus.Location = New System.Drawing.Point(121, 63)
        Me.ImageButtonHapus.Name = "ImageButtonHapus"
        Me.ImageButtonHapus.Size = New System.Drawing.Size(40, 40)
        Me.ImageButtonHapus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonHapus.TabIndex = 6
        Me.ImageButtonHapus.TabStop = False
        Me.ImageButtonHapus.Zoom = 10
        '
        'ImageButtonEdit
        '
        Me.ImageButtonEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ImageButtonEdit.Image = CType(resources.GetObject("ImageButtonEdit.Image"), System.Drawing.Image)
        Me.ImageButtonEdit.ImageActive = Nothing
        Me.ImageButtonEdit.Location = New System.Drawing.Point(75, 63)
        Me.ImageButtonEdit.Name = "ImageButtonEdit"
        Me.ImageButtonEdit.Size = New System.Drawing.Size(40, 40)
        Me.ImageButtonEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonEdit.TabIndex = 5
        Me.ImageButtonEdit.TabStop = False
        Me.ImageButtonEdit.Zoom = 10
        '
        'ImageButtonTambah
        '
        Me.ImageButtonTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ImageButtonTambah.Image = CType(resources.GetObject("ImageButtonTambah.Image"), System.Drawing.Image)
        Me.ImageButtonTambah.ImageActive = Nothing
        Me.ImageButtonTambah.Location = New System.Drawing.Point(29, 62)
        Me.ImageButtonTambah.Name = "ImageButtonTambah"
        Me.ImageButtonTambah.Size = New System.Drawing.Size(40, 40)
        Me.ImageButtonTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonTambah.TabIndex = 4
        Me.ImageButtonTambah.TabStop = False
        Me.ImageButtonTambah.Zoom = 10
        '
        'DatagridPemasok
        '
        Me.DatagridPemasok.AllowUserToAddRows = False
        Me.DatagridPemasok.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridPemasok.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridPemasok.AutoGenerateColumns = False
        Me.DatagridPemasok.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DatagridPemasok.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridPemasok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridPemasok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridPemasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridPemasok.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodePemasokDataGridViewTextBoxColumn, Me.NamaPemasokDataGridViewTextBoxColumn, Me.TeleponDataGridViewTextBoxColumn, Me.HPDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.KotaDataGridViewTextBoxColumn, Me.KodePosDataGridViewTextBoxColumn, Me.GambarDataGridViewImageColumn})
        Me.DatagridPemasok.DataSource = Me.TabelPemasokBindingSource
        Me.DatagridPemasok.DoubleBuffered = True
        Me.DatagridPemasok.EnableHeadersVisualStyles = False
        Me.DatagridPemasok.GridColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DatagridPemasok.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DatagridPemasok.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DatagridPemasok.Location = New System.Drawing.Point(29, 110)
        Me.DatagridPemasok.Name = "DatagridPemasok"
        Me.DatagridPemasok.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridPemasok.Size = New System.Drawing.Size(1053, 329)
        Me.DatagridPemasok.TabIndex = 3
        '
        'KodePemasokDataGridViewTextBoxColumn
        '
        Me.KodePemasokDataGridViewTextBoxColumn.DataPropertyName = "Kode Pemasok"
        Me.KodePemasokDataGridViewTextBoxColumn.HeaderText = "Kode Pemasok"
        Me.KodePemasokDataGridViewTextBoxColumn.Name = "KodePemasokDataGridViewTextBoxColumn"
        '
        'NamaPemasokDataGridViewTextBoxColumn
        '
        Me.NamaPemasokDataGridViewTextBoxColumn.DataPropertyName = "Nama Pemasok"
        Me.NamaPemasokDataGridViewTextBoxColumn.HeaderText = "Nama Pemasok"
        Me.NamaPemasokDataGridViewTextBoxColumn.Name = "NamaPemasokDataGridViewTextBoxColumn"
        '
        'TeleponDataGridViewTextBoxColumn
        '
        Me.TeleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.Name = "TeleponDataGridViewTextBoxColumn"
        '
        'HPDataGridViewTextBoxColumn
        '
        Me.HPDataGridViewTextBoxColumn.DataPropertyName = "HP"
        Me.HPDataGridViewTextBoxColumn.HeaderText = "HP"
        Me.HPDataGridViewTextBoxColumn.Name = "HPDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'KotaDataGridViewTextBoxColumn
        '
        Me.KotaDataGridViewTextBoxColumn.DataPropertyName = "Kota"
        Me.KotaDataGridViewTextBoxColumn.HeaderText = "Kota"
        Me.KotaDataGridViewTextBoxColumn.Name = "KotaDataGridViewTextBoxColumn"
        '
        'KodePosDataGridViewTextBoxColumn
        '
        Me.KodePosDataGridViewTextBoxColumn.DataPropertyName = "Kode Pos"
        Me.KodePosDataGridViewTextBoxColumn.HeaderText = "Kode Pos"
        Me.KodePosDataGridViewTextBoxColumn.Name = "KodePosDataGridViewTextBoxColumn"
        '
        'GambarDataGridViewImageColumn
        '
        Me.GambarDataGridViewImageColumn.DataPropertyName = "Gambar"
        Me.GambarDataGridViewImageColumn.HeaderText = "Gambar"
        Me.GambarDataGridViewImageColumn.Name = "GambarDataGridViewImageColumn"
        '
        'TabelPemasokBindingSource
        '
        Me.TabelPemasokBindingSource.DataMember = "Tabel Pemasok"
        Me.TabelPemasokBindingSource.DataSource = Me.Database_Boho_OutletDataSet
        '
        'Database_Boho_OutletDataSet
        '
        Me.Database_Boho_OutletDataSet.DataSetName = "Database_Boho_OutletDataSet"
        Me.Database_Boho_OutletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintText = "Pencarian"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(705, 68)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(185, 35)
        Me.BunifuMaterialTextbox1.TabIndex = 2
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 3
        Me.BunifuDropdown1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BunifuDropdown1.Items = New String(-1) {}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(897, 67)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(185, 35)
        Me.BunifuDropdown1.TabIndex = 1
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(24, 21)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(110, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Pemasok"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel8)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel7)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel6)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureboxPemasok)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(1111, 187)
        Me.BunifuGradientPanel1.TabIndex = 10
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(701, 135)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(79, 21)
        Me.BunifuCustomLabel8.TabIndex = 11
        Me.BunifuCustomLabel8.Text = "Kode Pos"
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(701, 94)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(47, 21)
        Me.BunifuCustomLabel7.TabIndex = 10
        Me.BunifuCustomLabel7.Text = "Kota"
        Me.BunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(701, 56)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(70, 21)
        Me.BunifuCustomLabel6.TabIndex = 9
        Me.BunifuCustomLabel6.Text = "Alamat"
        Me.BunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(163, 135)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(30, 21)
        Me.BunifuCustomLabel5.TabIndex = 8
        Me.BunifuCustomLabel5.Text = "HP"
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(163, 94)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(72, 21)
        Me.BunifuCustomLabel4.TabIndex = 7
        Me.BunifuCustomLabel4.Text = "Telepon"
        Me.BunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(163, 56)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(123, 21)
        Me.BunifuCustomLabel3.TabIndex = 6
        Me.BunifuCustomLabel3.Text = "Kode Pemasok"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 169)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1111, 35)
        Me.BunifuSeparator1.TabIndex = 5
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'PictureboxPemasok
        '
        Me.PictureboxPemasok.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureboxPemasok.Location = New System.Drawing.Point(29, 56)
        Me.PictureboxPemasok.Name = "PictureboxPemasok"
        Me.PictureboxPemasok.Size = New System.Drawing.Size(100, 100)
        Me.PictureboxPemasok.TabIndex = 4
        Me.PictureboxPemasok.TabStop = False
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(24, 17)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(184, 25)
        Me.BunifuCustomLabel2.TabIndex = 3
        Me.BunifuCustomLabel2.Text = "Nama Pemasok"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tabel_PemasokTableAdapter
        '
        Me.Tabel_PemasokTableAdapter.ClearBeforeFill = True
        '
        'UCPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "UCPemasok"
        Me.Size = New System.Drawing.Size(1111, 660)
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.ImageButtonMenyaring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonHapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridPemasok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelPemasokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureboxPemasok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageButtonMenyaring As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ImageButtonMenyegarkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonHapus As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonEdit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonTambah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DatagridPemasok As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PictureboxPemasok As PictureBox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents KodePemasokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPemasokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodePosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GambarDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents TabelPemasokBindingSource As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_PemasokTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_PemasokTableAdapter
End Class

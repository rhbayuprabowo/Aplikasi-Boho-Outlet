<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBarang
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCBarang))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.LabelHargaJual = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelHargaBeli = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelJumlah = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelMerekBarang = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelKategoriBarang = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelKodeBarang = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PictureboxBarang = New System.Windows.Forms.PictureBox()
        Me.LabelNamaBarang = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxPencarian = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DatagridBarang = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategoriBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MerekBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaJualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GambarDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BindingSourceBarang = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.ImageButtonTambah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonEdit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonHapus = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonMenyegarkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Tabel_BarangTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_BarangTableAdapter()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureboxBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonHapus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelHargaJual)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelHargaBeli)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelJumlah)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelMerekBarang)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelKategoriBarang)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelKodeBarang)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureboxBarang)
        Me.BunifuGradientPanel1.Controls.Add(Me.LabelNamaBarang)
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
        Me.BunifuGradientPanel1.TabIndex = 2
        '
        'LabelHargaJual
        '
        Me.LabelHargaJual.AutoSize = True
        Me.LabelHargaJual.BackColor = System.Drawing.Color.Transparent
        Me.LabelHargaJual.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelHargaJual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelHargaJual.Location = New System.Drawing.Point(701, 135)
        Me.LabelHargaJual.Name = "LabelHargaJual"
        Me.LabelHargaJual.Size = New System.Drawing.Size(95, 21)
        Me.LabelHargaJual.TabIndex = 9
        Me.LabelHargaJual.Text = "Harga Jual"
        Me.LabelHargaJual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelHargaBeli
        '
        Me.LabelHargaBeli.AutoSize = True
        Me.LabelHargaBeli.BackColor = System.Drawing.Color.Transparent
        Me.LabelHargaBeli.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelHargaBeli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelHargaBeli.Location = New System.Drawing.Point(701, 94)
        Me.LabelHargaBeli.Name = "LabelHargaBeli"
        Me.LabelHargaBeli.Size = New System.Drawing.Size(88, 21)
        Me.LabelHargaBeli.TabIndex = 8
        Me.LabelHargaBeli.Text = "Harga Beli"
        Me.LabelHargaBeli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelJumlah
        '
        Me.LabelJumlah.AutoSize = True
        Me.LabelJumlah.BackColor = System.Drawing.Color.Transparent
        Me.LabelJumlah.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelJumlah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelJumlah.Location = New System.Drawing.Point(701, 56)
        Me.LabelJumlah.Name = "LabelJumlah"
        Me.LabelJumlah.Size = New System.Drawing.Size(67, 21)
        Me.LabelJumlah.TabIndex = 7
        Me.LabelJumlah.Text = "Jumlah"
        Me.LabelJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelMerekBarang
        '
        Me.LabelMerekBarang.AutoSize = True
        Me.LabelMerekBarang.BackColor = System.Drawing.Color.Transparent
        Me.LabelMerekBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelMerekBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelMerekBarang.Location = New System.Drawing.Point(163, 135)
        Me.LabelMerekBarang.Name = "LabelMerekBarang"
        Me.LabelMerekBarang.Size = New System.Drawing.Size(119, 21)
        Me.LabelMerekBarang.TabIndex = 6
        Me.LabelMerekBarang.Text = "Merek Barang"
        Me.LabelMerekBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelKategoriBarang
        '
        Me.LabelKategoriBarang.AutoSize = True
        Me.LabelKategoriBarang.BackColor = System.Drawing.Color.Transparent
        Me.LabelKategoriBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelKategoriBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelKategoriBarang.Location = New System.Drawing.Point(163, 94)
        Me.LabelKategoriBarang.Name = "LabelKategoriBarang"
        Me.LabelKategoriBarang.Size = New System.Drawing.Size(137, 21)
        Me.LabelKategoriBarang.TabIndex = 5
        Me.LabelKategoriBarang.Text = "Kategori Barang"
        Me.LabelKategoriBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelKodeBarang
        '
        Me.LabelKodeBarang.AutoSize = True
        Me.LabelKodeBarang.BackColor = System.Drawing.Color.Transparent
        Me.LabelKodeBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LabelKodeBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelKodeBarang.Location = New System.Drawing.Point(163, 56)
        Me.LabelKodeBarang.Name = "LabelKodeBarang"
        Me.LabelKodeBarang.Size = New System.Drawing.Size(111, 21)
        Me.LabelKodeBarang.TabIndex = 4
        Me.LabelKodeBarang.Text = "Kode Barang"
        Me.LabelKodeBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'PictureboxBarang
        '
        Me.PictureboxBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureboxBarang.Location = New System.Drawing.Point(29, 56)
        Me.PictureboxBarang.Name = "PictureboxBarang"
        Me.PictureboxBarang.Size = New System.Drawing.Size(100, 100)
        Me.PictureboxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureboxBarang.TabIndex = 2
        Me.PictureboxBarang.TabStop = False
        '
        'LabelNamaBarang
        '
        Me.LabelNamaBarang.AutoSize = True
        Me.LabelNamaBarang.BackColor = System.Drawing.Color.Transparent
        Me.LabelNamaBarang.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.LabelNamaBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelNamaBarang.Location = New System.Drawing.Point(24, 17)
        Me.LabelNamaBarang.Name = "LabelNamaBarang"
        Me.LabelNamaBarang.Size = New System.Drawing.Size(164, 25)
        Me.LabelNamaBarang.TabIndex = 1
        Me.LabelNamaBarang.Text = "Nama Barang"
        Me.LabelNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(24, 21)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(90, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Barang"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxPencarian
        '
        Me.TextboxPencarian.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxPencarian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxPencarian.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxPencarian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxPencarian.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxPencarian.HintText = "Pencarian"
        Me.TextboxPencarian.isPassword = False
        Me.TextboxPencarian.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxPencarian.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxPencarian.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxPencarian.LineThickness = 3
        Me.TextboxPencarian.Location = New System.Drawing.Point(897, 68)
        Me.TextboxPencarian.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxPencarian.Name = "TextboxPencarian"
        Me.TextboxPencarian.Size = New System.Drawing.Size(185, 35)
        Me.TextboxPencarian.TabIndex = 2
        Me.TextboxPencarian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DatagridBarang
        '
        Me.DatagridBarang.AllowUserToAddRows = False
        Me.DatagridBarang.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridBarang.AutoGenerateColumns = False
        Me.DatagridBarang.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DatagridBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.KategoriBarangDataGridViewTextBoxColumn, Me.MerekBarangDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn, Me.HargaBeliDataGridViewTextBoxColumn, Me.HargaJualDataGridViewTextBoxColumn, Me.GambarDataGridViewImageColumn})
        Me.DatagridBarang.DataSource = Me.BindingSourceBarang
        Me.DatagridBarang.DoubleBuffered = True
        Me.DatagridBarang.EnableHeadersVisualStyles = False
        Me.DatagridBarang.GridColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DatagridBarang.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DatagridBarang.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DatagridBarang.Location = New System.Drawing.Point(29, 110)
        Me.DatagridBarang.Name = "DatagridBarang"
        Me.DatagridBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridBarang.Size = New System.Drawing.Size(1053, 329)
        Me.DatagridBarang.TabIndex = 3
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        '
        'KategoriBarangDataGridViewTextBoxColumn
        '
        Me.KategoriBarangDataGridViewTextBoxColumn.DataPropertyName = "Kategori Barang"
        Me.KategoriBarangDataGridViewTextBoxColumn.HeaderText = "Kategori Barang"
        Me.KategoriBarangDataGridViewTextBoxColumn.Name = "KategoriBarangDataGridViewTextBoxColumn"
        '
        'MerekBarangDataGridViewTextBoxColumn
        '
        Me.MerekBarangDataGridViewTextBoxColumn.DataPropertyName = "Merek Barang"
        Me.MerekBarangDataGridViewTextBoxColumn.HeaderText = "Merek Barang"
        Me.MerekBarangDataGridViewTextBoxColumn.Name = "MerekBarangDataGridViewTextBoxColumn"
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        '
        'SatuanDataGridViewTextBoxColumn
        '
        Me.SatuanDataGridViewTextBoxColumn.DataPropertyName = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.HeaderText = "Satuan"
        Me.SatuanDataGridViewTextBoxColumn.Name = "SatuanDataGridViewTextBoxColumn"
        '
        'HargaBeliDataGridViewTextBoxColumn
        '
        Me.HargaBeliDataGridViewTextBoxColumn.DataPropertyName = "Harga Beli"
        Me.HargaBeliDataGridViewTextBoxColumn.HeaderText = "Harga Beli"
        Me.HargaBeliDataGridViewTextBoxColumn.Name = "HargaBeliDataGridViewTextBoxColumn"
        '
        'HargaJualDataGridViewTextBoxColumn
        '
        Me.HargaJualDataGridViewTextBoxColumn.DataPropertyName = "Harga Jual"
        Me.HargaJualDataGridViewTextBoxColumn.HeaderText = "Harga Jual"
        Me.HargaJualDataGridViewTextBoxColumn.Name = "HargaJualDataGridViewTextBoxColumn"
        '
        'GambarDataGridViewImageColumn
        '
        Me.GambarDataGridViewImageColumn.DataPropertyName = "Gambar"
        Me.GambarDataGridViewImageColumn.HeaderText = "Gambar"
        Me.GambarDataGridViewImageColumn.Name = "GambarDataGridViewImageColumn"
        '
        'BindingSourceBarang
        '
        Me.BindingSourceBarang.DataMember = "Tabel Barang"
        Me.BindingSourceBarang.DataSource = Me.Database_Boho_OutletDataSet
        '
        'Database_Boho_OutletDataSet
        '
        Me.Database_Boho_OutletDataSet.DataSetName = "Database_Boho_OutletDataSet"
        Me.Database_Boho_OutletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonMenyegarkan)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonHapus)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonEdit)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonTambah)
        Me.BunifuGradientPanel2.Controls.Add(Me.DatagridBarang)
        Me.BunifuGradientPanel2.Controls.Add(Me.TextboxPencarian)
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
        Me.BunifuGradientPanel2.TabIndex = 3
        '
        'Tabel_BarangTableAdapter
        '
        Me.Tabel_BarangTableAdapter.ClearBeforeFill = True
        '
        'UCBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "UCBarang"
        Me.Size = New System.Drawing.Size(1111, 660)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureboxBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonHapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelHargaJual As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelHargaBeli As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelJumlah As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelMerekBarang As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelKategoriBarang As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelKodeBarang As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PictureboxBarang As PictureBox
    Friend WithEvents LabelNamaBarang As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxPencarian As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DatagridBarang As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ImageButtonTambah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonEdit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonHapus As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonMenyegarkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BindingSourceBarang As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_BarangTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_BarangTableAdapter
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KategoriBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MerekBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaBeliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaJualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GambarDataGridViewImageColumn As DataGridViewImageColumn
End Class

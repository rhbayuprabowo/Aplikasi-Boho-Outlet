<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FReturPembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FReturPembelian))
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxHarga = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TextboxNamaBarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.TextboxJumlah = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ImageButtonKeluar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ButtonKeluar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonSimpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxKodeBarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxNomorReturPembelian = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelPemasok = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TextboxKeterangan = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ButtonBaru = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BindingSourceReturPembelian = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.Tabel_Retur_PembelianTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_Retur_PembelianTableAdapter()
        Me.ImageButtonKodeBarang = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPemasok.SuspendLayout()
        CType(Me.BindingSourceReturPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonKodeBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(414, 153)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(104, 21)
        Me.BunifuCustomLabel1.TabIndex = 70
        Me.BunifuCustomLabel1.Text = "Keterangan"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxHarga
        '
        Me.TextboxHarga.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxHarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxHarga.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHarga.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHarga.HintText = ""
        Me.TextboxHarga.isPassword = False
        Me.TextboxHarga.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHarga.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxHarga.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHarga.LineThickness = 3
        Me.TextboxHarga.Location = New System.Drawing.Point(422, 114)
        Me.TextboxHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxHarga.Name = "TextboxHarga"
        Me.TextboxHarga.Size = New System.Drawing.Size(185, 35)
        Me.TextboxHarga.TabIndex = 69
        Me.TextboxHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextboxNamaBarang
        '
        Me.TextboxNamaBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxNamaBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxNamaBarang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxNamaBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaBarang.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaBarang.HintText = ""
        Me.TextboxNamaBarang.isPassword = False
        Me.TextboxNamaBarang.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaBarang.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxNamaBarang.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaBarang.LineThickness = 3
        Me.TextboxNamaBarang.Location = New System.Drawing.Point(226, 178)
        Me.TextboxNamaBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxNamaBarang.Name = "TextboxNamaBarang"
        Me.TextboxNamaBarang.Size = New System.Drawing.Size(185, 35)
        Me.TextboxNamaBarang.TabIndex = 68
        Me.TextboxNamaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextboxJumlah
        '
        Me.TextboxJumlah.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxJumlah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxJumlah.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxJumlah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxJumlah.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxJumlah.HintText = ""
        Me.TextboxJumlah.isPassword = False
        Me.TextboxJumlah.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxJumlah.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxJumlah.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxJumlah.LineThickness = 3
        Me.TextboxJumlah.Location = New System.Drawing.Point(226, 114)
        Me.TextboxJumlah.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxJumlah.Name = "TextboxJumlah"
        Me.TextboxJumlah.Size = New System.Drawing.Size(185, 35)
        Me.TextboxJumlah.TabIndex = 67
        Me.TextboxJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(222, 89)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(67, 21)
        Me.BunifuCustomLabel2.TabIndex = 66
        Me.BunifuCustomLabel2.Text = "Jumlah"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageButtonKeluar
        '
        Me.ImageButtonKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ImageButtonKeluar.Image = CType(resources.GetObject("ImageButtonKeluar.Image"), System.Drawing.Image)
        Me.ImageButtonKeluar.ImageActive = Nothing
        Me.ImageButtonKeluar.Location = New System.Drawing.Point(610, 3)
        Me.ImageButtonKeluar.Name = "ImageButtonKeluar"
        Me.ImageButtonKeluar.Size = New System.Drawing.Size(30, 30)
        Me.ImageButtonKeluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonKeluar.TabIndex = 62
        Me.ImageButtonKeluar.TabStop = False
        Me.ImageButtonKeluar.Zoom = 10
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(29, 34)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(189, 25)
        Me.BunifuCustomLabel15.TabIndex = 26
        Me.BunifuCustomLabel15.Text = "Retur Pembelian"
        Me.BunifuCustomLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonKeluar
        '
        Me.ButtonKeluar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonKeluar.BorderRadius = 0
        Me.ButtonKeluar.ButtonText = "Keluar"
        Me.ButtonKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonKeluar.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonKeluar.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonKeluar.Iconimage = Nothing
        Me.ButtonKeluar.Iconimage_right = Nothing
        Me.ButtonKeluar.Iconimage_right_Selected = Nothing
        Me.ButtonKeluar.Iconimage_Selected = Nothing
        Me.ButtonKeluar.IconMarginLeft = 0
        Me.ButtonKeluar.IconMarginRight = 0
        Me.ButtonKeluar.IconRightVisible = True
        Me.ButtonKeluar.IconRightZoom = 0R
        Me.ButtonKeluar.IconVisible = True
        Me.ButtonKeluar.IconZoom = 90.0R
        Me.ButtonKeluar.IsTab = False
        Me.ButtonKeluar.Location = New System.Drawing.Point(331, 274)
        Me.ButtonKeluar.Name = "ButtonKeluar"
        Me.ButtonKeluar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonKeluar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonKeluar.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonKeluar.selected = False
        Me.ButtonKeluar.Size = New System.Drawing.Size(133, 48)
        Me.ButtonKeluar.TabIndex = 40
        Me.ButtonKeluar.Text = "Keluar"
        Me.ButtonKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonKeluar.Textcolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonKeluar.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSimpan.BorderRadius = 0
        Me.ButtonSimpan.ButtonText = "Simpan"
        Me.ButtonSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSimpan.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonSimpan.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonSimpan.Iconimage = Nothing
        Me.ButtonSimpan.Iconimage_right = Nothing
        Me.ButtonSimpan.Iconimage_right_Selected = Nothing
        Me.ButtonSimpan.Iconimage_Selected = Nothing
        Me.ButtonSimpan.IconMarginLeft = 0
        Me.ButtonSimpan.IconMarginRight = 0
        Me.ButtonSimpan.IconRightVisible = True
        Me.ButtonSimpan.IconRightZoom = 0R
        Me.ButtonSimpan.IconVisible = True
        Me.ButtonSimpan.IconZoom = 90.0R
        Me.ButtonSimpan.IsTab = False
        Me.ButtonSimpan.Location = New System.Drawing.Point(470, 274)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonSimpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonSimpan.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonSimpan.selected = False
        Me.ButtonSimpan.Size = New System.Drawing.Size(133, 48)
        Me.ButtonSimpan.TabIndex = 39
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonSimpan.Textcolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonSimpan.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(222, 153)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(120, 21)
        Me.BunifuCustomLabel11.TabIndex = 32
        Me.BunifuCustomLabel11.Text = "Nama Barang"
        Me.BunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxKodeBarang
        '
        Me.TextboxKodeBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxKodeBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxKodeBarang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxKodeBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodeBarang.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodeBarang.HintText = ""
        Me.TextboxKodeBarang.isPassword = False
        Me.TextboxKodeBarang.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodeBarang.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxKodeBarang.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodeBarang.LineThickness = 3
        Me.TextboxKodeBarang.Location = New System.Drawing.Point(34, 178)
        Me.TextboxKodeBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxKodeBarang.Name = "TextboxKodeBarang"
        Me.TextboxKodeBarang.Size = New System.Drawing.Size(143, 35)
        Me.TextboxKodeBarang.TabIndex = 31
        Me.TextboxKodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(30, 153)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(111, 21)
        Me.BunifuCustomLabel10.TabIndex = 30
        Me.BunifuCustomLabel10.Text = "Kode Barang"
        Me.BunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxNomorReturPembelian
        '
        Me.TextboxNomorReturPembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxNomorReturPembelian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxNomorReturPembelian.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxNomorReturPembelian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorReturPembelian.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorReturPembelian.HintText = ""
        Me.TextboxNomorReturPembelian.isPassword = False
        Me.TextboxNomorReturPembelian.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorReturPembelian.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxNomorReturPembelian.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorReturPembelian.LineThickness = 3
        Me.TextboxNomorReturPembelian.Location = New System.Drawing.Point(34, 114)
        Me.TextboxNomorReturPembelian.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxNomorReturPembelian.Name = "TextboxNomorReturPembelian"
        Me.TextboxNomorReturPembelian.Size = New System.Drawing.Size(185, 35)
        Me.TextboxNomorReturPembelian.TabIndex = 27
        Me.TextboxNomorReturPembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(30, 89)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(194, 21)
        Me.BunifuCustomLabel8.TabIndex = 26
        Me.BunifuCustomLabel8.Text = "Nomor Retur Pembelian"
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelPemasok
        '
        Me.PanelPemasok.BackgroundImage = CType(resources.GetObject("PanelPemasok.BackgroundImage"), System.Drawing.Image)
        Me.PanelPemasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPemasok.Controls.Add(Me.ImageButtonKodeBarang)
        Me.PanelPemasok.Controls.Add(Me.TextboxKeterangan)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel5)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelPemasok.Controls.Add(Me.TextboxHarga)
        Me.PanelPemasok.Controls.Add(Me.TextboxNamaBarang)
        Me.PanelPemasok.Controls.Add(Me.TextboxJumlah)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelPemasok.Controls.Add(Me.ImageButtonKeluar)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel15)
        Me.PanelPemasok.Controls.Add(Me.ButtonKeluar)
        Me.PanelPemasok.Controls.Add(Me.ButtonSimpan)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel11)
        Me.PanelPemasok.Controls.Add(Me.TextboxKodeBarang)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel10)
        Me.PanelPemasok.Controls.Add(Me.TextboxNomorReturPembelian)
        Me.PanelPemasok.Controls.Add(Me.ButtonBaru)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel8)
        Me.PanelPemasok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPemasok.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.PanelPemasok.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.PanelPemasok.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.PanelPemasok.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.PanelPemasok.Location = New System.Drawing.Point(0, 0)
        Me.PanelPemasok.Name = "PanelPemasok"
        Me.PanelPemasok.Quality = 10
        Me.PanelPemasok.Size = New System.Drawing.Size(640, 350)
        Me.PanelPemasok.TabIndex = 7
        '
        'TextboxKeterangan
        '
        Me.TextboxKeterangan.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxKeterangan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxKeterangan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxKeterangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKeterangan.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKeterangan.HintText = ""
        Me.TextboxKeterangan.isPassword = False
        Me.TextboxKeterangan.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKeterangan.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxKeterangan.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKeterangan.LineThickness = 3
        Me.TextboxKeterangan.Location = New System.Drawing.Point(419, 178)
        Me.TextboxKeterangan.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxKeterangan.Name = "TextboxKeterangan"
        Me.TextboxKeterangan.Size = New System.Drawing.Size(185, 35)
        Me.TextboxKeterangan.TabIndex = 73
        Me.TextboxKeterangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(418, 90)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(59, 21)
        Me.BunifuCustomLabel5.TabIndex = 72
        Me.BunifuCustomLabel5.Text = "Harga"
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonBaru
        '
        Me.ButtonBaru.Activecolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonBaru.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonBaru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonBaru.BorderRadius = 0
        Me.ButtonBaru.ButtonText = "Baru"
        Me.ButtonBaru.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBaru.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonBaru.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonBaru.Iconimage = Nothing
        Me.ButtonBaru.Iconimage_right = Nothing
        Me.ButtonBaru.Iconimage_right_Selected = Nothing
        Me.ButtonBaru.Iconimage_Selected = Nothing
        Me.ButtonBaru.IconMarginLeft = 0
        Me.ButtonBaru.IconMarginRight = 0
        Me.ButtonBaru.IconRightVisible = True
        Me.ButtonBaru.IconRightZoom = 0R
        Me.ButtonBaru.IconVisible = True
        Me.ButtonBaru.IconZoom = 90.0R
        Me.ButtonBaru.IsTab = False
        Me.ButtonBaru.Location = New System.Drawing.Point(34, 274)
        Me.ButtonBaru.Name = "ButtonBaru"
        Me.ButtonBaru.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonBaru.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonBaru.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonBaru.selected = False
        Me.ButtonBaru.Size = New System.Drawing.Size(133, 48)
        Me.ButtonBaru.TabIndex = 22
        Me.ButtonBaru.Text = "Baru"
        Me.ButtonBaru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonBaru.Textcolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonBaru.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BindingSourceReturPembelian
        '
        Me.BindingSourceReturPembelian.DataMember = "Tabel Retur Pembelian"
        Me.BindingSourceReturPembelian.DataSource = Me.Database_Boho_OutletDataSet
        '
        'Database_Boho_OutletDataSet
        '
        Me.Database_Boho_OutletDataSet.DataSetName = "Database_Boho_OutletDataSet"
        Me.Database_Boho_OutletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabel_Retur_PembelianTableAdapter
        '
        Me.Tabel_Retur_PembelianTableAdapter.ClearBeforeFill = True
        '
        'ImageButtonKodeBarang
        '
        Me.ImageButtonKodeBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ImageButtonKodeBarang.Image = Global.Aplikasi_Boho_Outlet.My.Resources.Resources.More_96px1
        Me.ImageButtonKodeBarang.ImageActive = Nothing
        Me.ImageButtonKodeBarang.Location = New System.Drawing.Point(184, 180)
        Me.ImageButtonKodeBarang.Name = "ImageButtonKodeBarang"
        Me.ImageButtonKodeBarang.Size = New System.Drawing.Size(30, 30)
        Me.ImageButtonKodeBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonKodeBarang.TabIndex = 74
        Me.ImageButtonKodeBarang.TabStop = False
        Me.ImageButtonKodeBarang.Zoom = 10
        '
        'FReturPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 350)
        Me.Controls.Add(Me.PanelPemasok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FReturPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retur Pembelian"
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPemasok.ResumeLayout(False)
        Me.PanelPemasok.PerformLayout()
        CType(Me.BindingSourceReturPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonKodeBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxHarga As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TextboxNamaBarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents TextboxJumlah As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ImageButtonKeluar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ButtonKeluar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonSimpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxKodeBarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxNomorReturPembelian As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PanelPemasok As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ButtonBaru As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxKeterangan As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BindingSourceReturPembelian As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_Retur_PembelianTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_Retur_PembelianTableAdapter
    Friend WithEvents ImageButtonKodeBarang As Bunifu.Framework.UI.BunifuImageButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FBarang))
        Me.PanelPemasok = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TextboxJumlah = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DropdownMerekBarang = New Bunifu.Framework.UI.BunifuDropdown()
        Me.DropdownKategoriBarang = New Bunifu.Framework.UI.BunifuDropdown()
        Me.DropdownSatuan = New Bunifu.Framework.UI.BunifuDropdown()
        Me.ImageButtonKeluar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TextboxHargaBeli = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxHargaJual = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureboxBarang = New System.Windows.Forms.PictureBox()
        Me.ButtonKeluar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonSimpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonHapusGambar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonPilihGambar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxNamaBarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxKodeBarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ButtonBaru = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BindingSourceBarang = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.Tabel_BarangTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_BarangTableAdapter()
        Me.PanelPemasok.SuspendLayout()
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureboxBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPemasok
        '
        Me.PanelPemasok.BackgroundImage = CType(resources.GetObject("PanelPemasok.BackgroundImage"), System.Drawing.Image)
        Me.PanelPemasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPemasok.Controls.Add(Me.TextboxJumlah)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelPemasok.Controls.Add(Me.DropdownMerekBarang)
        Me.PanelPemasok.Controls.Add(Me.DropdownKategoriBarang)
        Me.PanelPemasok.Controls.Add(Me.DropdownSatuan)
        Me.PanelPemasok.Controls.Add(Me.ImageButtonKeluar)
        Me.PanelPemasok.Controls.Add(Me.TextboxHargaBeli)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel14)
        Me.PanelPemasok.Controls.Add(Me.TextboxHargaJual)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel7)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel5)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel13)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel15)
        Me.PanelPemasok.Controls.Add(Me.PictureboxBarang)
        Me.PanelPemasok.Controls.Add(Me.ButtonKeluar)
        Me.PanelPemasok.Controls.Add(Me.ButtonSimpan)
        Me.PanelPemasok.Controls.Add(Me.ButtonHapusGambar)
        Me.PanelPemasok.Controls.Add(Me.ButtonPilihGambar)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel11)
        Me.PanelPemasok.Controls.Add(Me.TextboxNamaBarang)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel10)
        Me.PanelPemasok.Controls.Add(Me.TextboxKodeBarang)
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
        Me.PanelPemasok.Size = New System.Drawing.Size(760, 500)
        Me.PanelPemasok.TabIndex = 5
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
        Me.TextboxJumlah.Location = New System.Drawing.Point(200, 277)
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
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(30, 284)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(67, 21)
        Me.BunifuCustomLabel2.TabIndex = 66
        Me.BunifuCustomLabel2.Text = "Jumlah"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DropdownMerekBarang
        '
        Me.DropdownMerekBarang.BackColor = System.Drawing.Color.Transparent
        Me.DropdownMerekBarang.BorderRadius = 3
        Me.DropdownMerekBarang.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownMerekBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DropdownMerekBarang.Items = New String() {"Adidas", "Nike", "Vans"}
        Me.DropdownMerekBarang.Location = New System.Drawing.Point(200, 235)
        Me.DropdownMerekBarang.Name = "DropdownMerekBarang"
        Me.DropdownMerekBarang.NomalColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownMerekBarang.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownMerekBarang.selectedIndex = -1
        Me.DropdownMerekBarang.Size = New System.Drawing.Size(185, 35)
        Me.DropdownMerekBarang.TabIndex = 65
        '
        'DropdownKategoriBarang
        '
        Me.DropdownKategoriBarang.BackColor = System.Drawing.Color.Transparent
        Me.DropdownKategoriBarang.BorderRadius = 3
        Me.DropdownKategoriBarang.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownKategoriBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DropdownKategoriBarang.Items = New String() {"Topi", "Baju", "Celana", "Sepatu"}
        Me.DropdownKategoriBarang.Location = New System.Drawing.Point(200, 194)
        Me.DropdownKategoriBarang.Name = "DropdownKategoriBarang"
        Me.DropdownKategoriBarang.NomalColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownKategoriBarang.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownKategoriBarang.selectedIndex = -1
        Me.DropdownKategoriBarang.Size = New System.Drawing.Size(185, 35)
        Me.DropdownKategoriBarang.TabIndex = 64
        '
        'DropdownSatuan
        '
        Me.DropdownSatuan.BackColor = System.Drawing.Color.Transparent
        Me.DropdownSatuan.BorderRadius = 3
        Me.DropdownSatuan.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DropdownSatuan.Items = New String() {"PCS"}
        Me.DropdownSatuan.Location = New System.Drawing.Point(547, 277)
        Me.DropdownSatuan.Name = "DropdownSatuan"
        Me.DropdownSatuan.NomalColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownSatuan.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownSatuan.selectedIndex = -1
        Me.DropdownSatuan.Size = New System.Drawing.Size(185, 35)
        Me.DropdownSatuan.TabIndex = 63
        '
        'ImageButtonKeluar
        '
        Me.ImageButtonKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ImageButtonKeluar.Image = CType(resources.GetObject("ImageButtonKeluar.Image"), System.Drawing.Image)
        Me.ImageButtonKeluar.ImageActive = Nothing
        Me.ImageButtonKeluar.Location = New System.Drawing.Point(727, 3)
        Me.ImageButtonKeluar.Name = "ImageButtonKeluar"
        Me.ImageButtonKeluar.Size = New System.Drawing.Size(30, 30)
        Me.ImageButtonKeluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonKeluar.TabIndex = 62
        Me.ImageButtonKeluar.TabStop = False
        Me.ImageButtonKeluar.Zoom = 10
        '
        'TextboxHargaBeli
        '
        Me.TextboxHargaBeli.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxHargaBeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxHargaBeli.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxHargaBeli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHargaBeli.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHargaBeli.HintText = ""
        Me.TextboxHargaBeli.isPassword = False
        Me.TextboxHargaBeli.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHargaBeli.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxHargaBeli.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHargaBeli.LineThickness = 3
        Me.TextboxHargaBeli.Location = New System.Drawing.Point(200, 320)
        Me.TextboxHargaBeli.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxHargaBeli.Name = "TextboxHargaBeli"
        Me.TextboxHargaBeli.Size = New System.Drawing.Size(185, 35)
        Me.TextboxHargaBeli.TabIndex = 59
        Me.TextboxHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(30, 327)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(88, 21)
        Me.BunifuCustomLabel14.TabIndex = 58
        Me.BunifuCustomLabel14.Text = "Harga Beli"
        Me.BunifuCustomLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxHargaJual
        '
        Me.TextboxHargaJual.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxHargaJual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxHargaJual.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxHargaJual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHargaJual.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHargaJual.HintText = ""
        Me.TextboxHargaJual.isPassword = False
        Me.TextboxHargaJual.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHargaJual.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxHargaJual.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHargaJual.LineThickness = 3
        Me.TextboxHargaJual.Location = New System.Drawing.Point(547, 319)
        Me.TextboxHargaJual.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxHargaJual.Name = "TextboxHargaJual"
        Me.TextboxHargaJual.Size = New System.Drawing.Size(185, 35)
        Me.TextboxHargaJual.TabIndex = 57
        Me.TextboxHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(422, 327)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(95, 21)
        Me.BunifuCustomLabel7.TabIndex = 56
        Me.BunifuCustomLabel7.Text = "Harga Jual"
        Me.BunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(422, 284)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(67, 21)
        Me.BunifuCustomLabel5.TabIndex = 53
        Me.BunifuCustomLabel5.Text = "Satuan"
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(30, 242)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(119, 21)
        Me.BunifuCustomLabel1.TabIndex = 45
        Me.BunifuCustomLabel1.Text = "Merek Barang"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(421, 30)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(105, 25)
        Me.BunifuCustomLabel13.TabIndex = 44
        Me.BunifuCustomLabel13.Text = "Gambar"
        Me.BunifuCustomLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(29, 34)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(90, 25)
        Me.BunifuCustomLabel15.TabIndex = 26
        Me.BunifuCustomLabel15.Text = "Barang"
        Me.BunifuCustomLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureboxBarang
        '
        Me.PictureboxBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureboxBarang.Location = New System.Drawing.Point(426, 109)
        Me.PictureboxBarang.Name = "PictureboxBarang"
        Me.PictureboxBarang.Size = New System.Drawing.Size(140, 140)
        Me.PictureboxBarang.TabIndex = 43
        Me.PictureboxBarang.TabStop = False
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
        Me.ButtonKeluar.Location = New System.Drawing.Point(460, 417)
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
        Me.ButtonSimpan.Location = New System.Drawing.Point(599, 417)
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
        'ButtonHapusGambar
        '
        Me.ButtonHapusGambar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonHapusGambar.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonHapusGambar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonHapusGambar.BorderRadius = 0
        Me.ButtonHapusGambar.ButtonText = "Hapus Gambar"
        Me.ButtonHapusGambar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHapusGambar.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonHapusGambar.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonHapusGambar.Iconimage = Nothing
        Me.ButtonHapusGambar.Iconimage_right = Nothing
        Me.ButtonHapusGambar.Iconimage_right_Selected = Nothing
        Me.ButtonHapusGambar.Iconimage_Selected = Nothing
        Me.ButtonHapusGambar.IconMarginLeft = 0
        Me.ButtonHapusGambar.IconMarginRight = 0
        Me.ButtonHapusGambar.IconRightVisible = True
        Me.ButtonHapusGambar.IconRightZoom = 0R
        Me.ButtonHapusGambar.IconVisible = True
        Me.ButtonHapusGambar.IconZoom = 90.0R
        Me.ButtonHapusGambar.IsTab = False
        Me.ButtonHapusGambar.Location = New System.Drawing.Point(599, 163)
        Me.ButtonHapusGambar.Name = "ButtonHapusGambar"
        Me.ButtonHapusGambar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonHapusGambar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonHapusGambar.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonHapusGambar.selected = False
        Me.ButtonHapusGambar.Size = New System.Drawing.Size(133, 48)
        Me.ButtonHapusGambar.TabIndex = 38
        Me.ButtonHapusGambar.Text = "Hapus Gambar"
        Me.ButtonHapusGambar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonHapusGambar.Textcolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonHapusGambar.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ButtonPilihGambar
        '
        Me.ButtonPilihGambar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonPilihGambar.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonPilihGambar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPilihGambar.BorderRadius = 0
        Me.ButtonPilihGambar.ButtonText = "Pilih Gambar"
        Me.ButtonPilihGambar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPilihGambar.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonPilihGambar.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonPilihGambar.Iconimage = Nothing
        Me.ButtonPilihGambar.Iconimage_right = Nothing
        Me.ButtonPilihGambar.Iconimage_right_Selected = Nothing
        Me.ButtonPilihGambar.Iconimage_Selected = Nothing
        Me.ButtonPilihGambar.IconMarginLeft = 0
        Me.ButtonPilihGambar.IconMarginRight = 0
        Me.ButtonPilihGambar.IconRightVisible = True
        Me.ButtonPilihGambar.IconRightZoom = 0R
        Me.ButtonPilihGambar.IconVisible = True
        Me.ButtonPilihGambar.IconZoom = 90.0R
        Me.ButtonPilihGambar.IsTab = False
        Me.ButtonPilihGambar.Location = New System.Drawing.Point(599, 109)
        Me.ButtonPilihGambar.Name = "ButtonPilihGambar"
        Me.ButtonPilihGambar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonPilihGambar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonPilihGambar.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonPilihGambar.selected = False
        Me.ButtonPilihGambar.Size = New System.Drawing.Size(133, 48)
        Me.ButtonPilihGambar.TabIndex = 37
        Me.ButtonPilihGambar.Text = "Pilih Gambar"
        Me.ButtonPilihGambar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonPilihGambar.Textcolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonPilihGambar.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(30, 201)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(137, 21)
        Me.BunifuCustomLabel11.TabIndex = 32
        Me.BunifuCustomLabel11.Text = "Kategori Barang"
        Me.BunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TextboxNamaBarang.Location = New System.Drawing.Point(200, 152)
        Me.TextboxNamaBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxNamaBarang.Name = "TextboxNamaBarang"
        Me.TextboxNamaBarang.Size = New System.Drawing.Size(185, 35)
        Me.TextboxNamaBarang.TabIndex = 31
        Me.TextboxNamaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(30, 159)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(120, 21)
        Me.BunifuCustomLabel10.TabIndex = 30
        Me.BunifuCustomLabel10.Text = "Nama Barang"
        Me.BunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TextboxKodeBarang.Location = New System.Drawing.Point(200, 109)
        Me.TextboxKodeBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxKodeBarang.Name = "TextboxKodeBarang"
        Me.TextboxKodeBarang.Size = New System.Drawing.Size(185, 35)
        Me.TextboxKodeBarang.TabIndex = 27
        Me.TextboxKodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.ButtonBaru.Location = New System.Drawing.Point(34, 417)
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
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(30, 116)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(111, 21)
        Me.BunifuCustomLabel8.TabIndex = 26
        Me.BunifuCustomLabel8.Text = "Kode Barang"
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Tabel_BarangTableAdapter
        '
        Me.Tabel_BarangTableAdapter.ClearBeforeFill = True
        '
        'FBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 500)
        Me.Controls.Add(Me.PanelPemasok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FBarang"
        Me.PanelPemasok.ResumeLayout(False)
        Me.PanelPemasok.PerformLayout()
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureboxBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPemasok As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ImageButtonKeluar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TextboxHargaBeli As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxHargaJual As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureboxBarang As PictureBox
    Friend WithEvents ButtonKeluar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonSimpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonHapusGambar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonPilihGambar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxNamaBarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxKodeBarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ButtonBaru As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DropdownMerekBarang As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents DropdownKategoriBarang As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents DropdownSatuan As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents TextboxJumlah As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BindingSourceBarang As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_BarangTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_BarangTableAdapter
End Class

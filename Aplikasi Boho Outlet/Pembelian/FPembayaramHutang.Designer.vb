<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPembayaramHutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPembayaramHutang))
        Me.ButtonBarang = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxNamaPemasok = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ImageButtonKeluar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ButtonKeluar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PanelPemasok = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.DropdownStatus = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextboxNomorPembelian = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DatepickerTanggalPembayaran = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ButtonSimpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxKodePemasok = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxNomorPembayaranHutang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ButtonBaru = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BindingSourcePembayaranHutang = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.Tabel_Pembayaran_HutangTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_Pembayaran_HutangTableAdapter()
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPemasok.SuspendLayout()
        CType(Me.BindingSourcePembayaranHutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonBarang
        '
        Me.ButtonBarang.Activecolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonBarang.BorderRadius = 0
        Me.ButtonBarang.ButtonText = "..."
        Me.ButtonBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBarang.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonBarang.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonBarang.Iconimage = Nothing
        Me.ButtonBarang.Iconimage_right = Nothing
        Me.ButtonBarang.Iconimage_right_Selected = Nothing
        Me.ButtonBarang.Iconimage_Selected = Nothing
        Me.ButtonBarang.IconMarginLeft = 0
        Me.ButtonBarang.IconMarginRight = 0
        Me.ButtonBarang.IconRightVisible = True
        Me.ButtonBarang.IconRightZoom = 0R
        Me.ButtonBarang.IconVisible = True
        Me.ButtonBarang.IconZoom = 90.0R
        Me.ButtonBarang.IsTab = False
        Me.ButtonBarang.Location = New System.Drawing.Point(385, 117)
        Me.ButtonBarang.Name = "ButtonBarang"
        Me.ButtonBarang.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonBarang.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonBarang.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonBarang.selected = False
        Me.ButtonBarang.Size = New System.Drawing.Size(36, 28)
        Me.ButtonBarang.TabIndex = 71
        Me.ButtonBarang.Text = "..."
        Me.ButtonBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonBarang.Textcolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonBarang.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(30, 153)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(148, 21)
        Me.BunifuCustomLabel1.TabIndex = 70
        Me.BunifuCustomLabel1.Text = "Nomor Pembelian"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxNamaPemasok
        '
        Me.TextboxNamaPemasok.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxNamaPemasok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxNamaPemasok.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxNamaPemasok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaPemasok.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaPemasok.HintText = ""
        Me.TextboxNamaPemasok.isPassword = False
        Me.TextboxNamaPemasok.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaPemasok.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxNamaPemasok.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaPemasok.LineThickness = 3
        Me.TextboxNamaPemasok.Location = New System.Drawing.Point(236, 181)
        Me.TextboxNamaPemasok.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxNamaPemasok.Name = "TextboxNamaPemasok"
        Me.TextboxNamaPemasok.Size = New System.Drawing.Size(185, 35)
        Me.TextboxNamaPemasok.TabIndex = 68
        Me.TextboxNamaPemasok.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(239, 25)
        Me.BunifuCustomLabel15.TabIndex = 26
        Me.BunifuCustomLabel15.Text = "Pembayaran Hutang"
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
        'PanelPemasok
        '
        Me.PanelPemasok.BackgroundImage = CType(resources.GetObject("PanelPemasok.BackgroundImage"), System.Drawing.Image)
        Me.PanelPemasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPemasok.Controls.Add(Me.DropdownStatus)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel5)
        Me.PanelPemasok.Controls.Add(Me.BunifuFlatButton1)
        Me.PanelPemasok.Controls.Add(Me.TextboxNomorPembelian)
        Me.PanelPemasok.Controls.Add(Me.DatepickerTanggalPembayaran)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel3)
        Me.PanelPemasok.Controls.Add(Me.ButtonBarang)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelPemasok.Controls.Add(Me.TextboxNamaPemasok)
        Me.PanelPemasok.Controls.Add(Me.ImageButtonKeluar)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel15)
        Me.PanelPemasok.Controls.Add(Me.ButtonKeluar)
        Me.PanelPemasok.Controls.Add(Me.ButtonSimpan)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel11)
        Me.PanelPemasok.Controls.Add(Me.TextboxKodePemasok)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel10)
        Me.PanelPemasok.Controls.Add(Me.TextboxNomorPembayaranHutang)
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
        Me.PanelPemasok.TabIndex = 8
        '
        'DropdownStatus
        '
        Me.DropdownStatus.BackColor = System.Drawing.Color.Transparent
        Me.DropdownStatus.BorderRadius = 3
        Me.DropdownStatus.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DropdownStatus.Items = New String() {"Lunas", "Belum Lunas"}
        Me.DropdownStatus.Location = New System.Drawing.Point(436, 181)
        Me.DropdownStatus.Name = "DropdownStatus"
        Me.DropdownStatus.NomalColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownStatus.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DropdownStatus.selectedIndex = -1
        Me.DropdownStatus.Size = New System.Drawing.Size(168, 35)
        Me.DropdownStatus.TabIndex = 79
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(432, 157)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(59, 21)
        Me.BunifuCustomLabel5.TabIndex = 78
        Me.BunifuCustomLabel5.Text = "Status"
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "..."
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(183, 181)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(36, 28)
        Me.BunifuFlatButton1.TabIndex = 77
        Me.BunifuFlatButton1.Text = "..."
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextboxNomorPembelian
        '
        Me.TextboxNomorPembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxNomorPembelian.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxNomorPembelian.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxNomorPembelian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorPembelian.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorPembelian.HintText = ""
        Me.TextboxNomorPembelian.isPassword = False
        Me.TextboxNomorPembelian.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorPembelian.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxNomorPembelian.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorPembelian.LineThickness = 3
        Me.TextboxNomorPembelian.Location = New System.Drawing.Point(34, 178)
        Me.TextboxNomorPembelian.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxNomorPembelian.Name = "TextboxNomorPembelian"
        Me.TextboxNomorPembelian.Size = New System.Drawing.Size(143, 35)
        Me.TextboxNomorPembelian.TabIndex = 76
        Me.TextboxNomorPembelian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DatepickerTanggalPembayaran
        '
        Me.DatepickerTanggalPembayaran.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DatepickerTanggalPembayaran.BorderRadius = 0
        Me.DatepickerTanggalPembayaran.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DatepickerTanggalPembayaran.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatepickerTanggalPembayaran.FormatCustom = Nothing
        Me.DatepickerTanggalPembayaran.Location = New System.Drawing.Point(436, 114)
        Me.DatepickerTanggalPembayaran.Name = "DatepickerTanggalPembayaran"
        Me.DatepickerTanggalPembayaran.Size = New System.Drawing.Size(168, 35)
        Me.DatepickerTanggalPembayaran.TabIndex = 75
        Me.DatepickerTanggalPembayaran.Value = New Date(2017, 10, 8, 0, 18, 57, 398)
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(432, 89)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(180, 21)
        Me.BunifuCustomLabel3.TabIndex = 74
        Me.BunifuCustomLabel3.Text = "Tanggal Pembayaran"
        Me.BunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(232, 153)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(132, 21)
        Me.BunifuCustomLabel11.TabIndex = 32
        Me.BunifuCustomLabel11.Text = "Nama Pemasok"
        Me.BunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxKodePemasok
        '
        Me.TextboxKodePemasok.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxKodePemasok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxKodePemasok.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxKodePemasok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodePemasok.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodePemasok.HintText = ""
        Me.TextboxKodePemasok.isPassword = False
        Me.TextboxKodePemasok.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodePemasok.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxKodePemasok.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodePemasok.LineThickness = 3
        Me.TextboxKodePemasok.Location = New System.Drawing.Point(236, 114)
        Me.TextboxKodePemasok.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxKodePemasok.Name = "TextboxKodePemasok"
        Me.TextboxKodePemasok.Size = New System.Drawing.Size(143, 35)
        Me.TextboxKodePemasok.TabIndex = 31
        Me.TextboxKodePemasok.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(232, 89)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(123, 21)
        Me.BunifuCustomLabel10.TabIndex = 30
        Me.BunifuCustomLabel10.Text = "Kode Pemasok"
        Me.BunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxNomorPembayaranHutang
        '
        Me.TextboxNomorPembayaranHutang.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxNomorPembayaranHutang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxNomorPembayaranHutang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxNomorPembayaranHutang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorPembayaranHutang.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorPembayaranHutang.HintText = ""
        Me.TextboxNomorPembayaranHutang.isPassword = False
        Me.TextboxNomorPembayaranHutang.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorPembayaranHutang.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxNomorPembayaranHutang.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNomorPembayaranHutang.LineThickness = 3
        Me.TextboxNomorPembayaranHutang.Location = New System.Drawing.Point(34, 114)
        Me.TextboxNomorPembayaranHutang.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxNomorPembayaranHutang.Name = "TextboxNomorPembayaranHutang"
        Me.TextboxNomorPembayaranHutang.Size = New System.Drawing.Size(185, 35)
        Me.TextboxNomorPembayaranHutang.TabIndex = 27
        Me.TextboxNomorPembayaranHutang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(30, 89)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(167, 21)
        Me.BunifuCustomLabel8.TabIndex = 26
        Me.BunifuCustomLabel8.Text = "Nomor Pembayaran"
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BindingSourcePembayaranHutang
        '
        Me.BindingSourcePembayaranHutang.DataMember = "Tabel Pembayaran Hutang"
        Me.BindingSourcePembayaranHutang.DataSource = Me.Database_Boho_OutletDataSet
        '
        'Database_Boho_OutletDataSet
        '
        Me.Database_Boho_OutletDataSet.DataSetName = "Database_Boho_OutletDataSet"
        Me.Database_Boho_OutletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabel_Pembayaran_HutangTableAdapter
        '
        Me.Tabel_Pembayaran_HutangTableAdapter.ClearBeforeFill = True
        '
        'FPembayaramHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 350)
        Me.Controls.Add(Me.PanelPemasok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FPembayaramHutang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembayaram Hutang"
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPemasok.ResumeLayout(False)
        Me.PanelPemasok.PerformLayout()
        CType(Me.BindingSourcePembayaranHutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonBarang As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxNamaPemasok As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ImageButtonKeluar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ButtonKeluar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PanelPemasok As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ButtonSimpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxKodePemasok As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxNomorPembayaranHutang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ButtonBaru As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DatepickerTanggalPembayaran As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TextboxNomorPembelian As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DropdownStatus As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BindingSourcePembayaranHutang As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_Pembayaran_HutangTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_Pembayaran_HutangTableAdapter
End Class

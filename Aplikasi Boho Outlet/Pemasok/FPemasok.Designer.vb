<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPemasok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FPemasok))
        Me.ImageButtonKeluar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TextboxKodePos = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxKota = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxAlamat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureboxPemasok = New System.Windows.Forms.PictureBox()
        Me.ButtonKeluar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonSimpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonHapusGambar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ButtonPilihGambar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextboxTelepon = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxNamaPemasok = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TextboxKodePemasok = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ButtonBaru = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PanelPemasok = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.TextboxHP = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BindingSourcePemasok = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.Tabel_PemasokTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_PemasokTableAdapter()
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureboxPemasok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPemasok.SuspendLayout()
        CType(Me.BindingSourcePemasok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TextboxKodePos
        '
        Me.TextboxKodePos.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxKodePos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxKodePos.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxKodePos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodePos.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodePos.HintText = ""
        Me.TextboxKodePos.isPassword = False
        Me.TextboxKodePos.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodePos.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxKodePos.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKodePos.LineThickness = 3
        Me.TextboxKodePos.Location = New System.Drawing.Point(547, 324)
        Me.TextboxKodePos.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxKodePos.Name = "TextboxKodePos"
        Me.TextboxKodePos.Size = New System.Drawing.Size(185, 35)
        Me.TextboxKodePos.TabIndex = 59
        Me.TextboxKodePos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(422, 331)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(79, 21)
        Me.BunifuCustomLabel14.TabIndex = 58
        Me.BunifuCustomLabel14.Text = "Kode Pos"
        Me.BunifuCustomLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxKota
        '
        Me.TextboxKota.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxKota.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxKota.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxKota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKota.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKota.HintText = ""
        Me.TextboxKota.isPassword = False
        Me.TextboxKota.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKota.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxKota.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKota.LineThickness = 3
        Me.TextboxKota.Location = New System.Drawing.Point(200, 324)
        Me.TextboxKota.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxKota.Name = "TextboxKota"
        Me.TextboxKota.Size = New System.Drawing.Size(185, 35)
        Me.TextboxKota.TabIndex = 57
        Me.TextboxKota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(30, 324)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(47, 21)
        Me.BunifuCustomLabel7.TabIndex = 56
        Me.BunifuCustomLabel7.Text = "Kota"
        Me.BunifuCustomLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextboxAlamat
        '
        Me.TextboxAlamat.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxAlamat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxAlamat.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxAlamat.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxAlamat.HintText = ""
        Me.TextboxAlamat.isPassword = False
        Me.TextboxAlamat.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxAlamat.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxAlamat.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxAlamat.LineThickness = 3
        Me.TextboxAlamat.Location = New System.Drawing.Point(200, 281)
        Me.TextboxAlamat.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxAlamat.Name = "TextboxAlamat"
        Me.TextboxAlamat.Size = New System.Drawing.Size(532, 35)
        Me.TextboxAlamat.TabIndex = 54
        Me.TextboxAlamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(30, 288)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(70, 21)
        Me.BunifuCustomLabel5.TabIndex = 53
        Me.BunifuCustomLabel5.Text = "Alamat"
        Me.BunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(30, 245)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(30, 21)
        Me.BunifuCustomLabel1.TabIndex = 45
        Me.BunifuCustomLabel1.Text = "HP"
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
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(110, 25)
        Me.BunifuCustomLabel15.TabIndex = 26
        Me.BunifuCustomLabel15.Text = "Pemasok"
        Me.BunifuCustomLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureboxPemasok
        '
        Me.PictureboxPemasok.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureboxPemasok.Location = New System.Drawing.Point(426, 105)
        Me.PictureboxPemasok.Name = "PictureboxPemasok"
        Me.PictureboxPemasok.Size = New System.Drawing.Size(140, 140)
        Me.PictureboxPemasok.TabIndex = 43
        Me.PictureboxPemasok.TabStop = False
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
        Me.ButtonHapusGambar.Location = New System.Drawing.Point(599, 159)
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
        Me.ButtonPilihGambar.Location = New System.Drawing.Point(599, 105)
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
        'TextboxTelepon
        '
        Me.TextboxTelepon.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxTelepon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxTelepon.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxTelepon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxTelepon.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxTelepon.HintText = ""
        Me.TextboxTelepon.isPassword = False
        Me.TextboxTelepon.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxTelepon.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxTelepon.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxTelepon.LineThickness = 3
        Me.TextboxTelepon.Location = New System.Drawing.Point(200, 195)
        Me.TextboxTelepon.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxTelepon.Name = "TextboxTelepon"
        Me.TextboxTelepon.Size = New System.Drawing.Size(185, 35)
        Me.TextboxTelepon.TabIndex = 33
        Me.TextboxTelepon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(30, 202)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(72, 21)
        Me.BunifuCustomLabel11.TabIndex = 32
        Me.BunifuCustomLabel11.Text = "Telepon"
        Me.BunifuCustomLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TextboxNamaPemasok.Location = New System.Drawing.Point(200, 152)
        Me.TextboxNamaPemasok.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxNamaPemasok.Name = "TextboxNamaPemasok"
        Me.TextboxNamaPemasok.Size = New System.Drawing.Size(185, 35)
        Me.TextboxNamaPemasok.TabIndex = 31
        Me.TextboxNamaPemasok.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(30, 159)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(132, 21)
        Me.BunifuCustomLabel10.TabIndex = 30
        Me.BunifuCustomLabel10.Text = "Nama Pemasok"
        Me.BunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.TextboxKodePemasok.Location = New System.Drawing.Point(200, 109)
        Me.TextboxKodePemasok.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxKodePemasok.Name = "TextboxKodePemasok"
        Me.TextboxKodePemasok.Size = New System.Drawing.Size(185, 35)
        Me.TextboxKodePemasok.TabIndex = 27
        Me.TextboxKodePemasok.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(123, 21)
        Me.BunifuCustomLabel8.TabIndex = 26
        Me.BunifuCustomLabel8.Text = "Kode Pemasok"
        Me.BunifuCustomLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelPemasok
        '
        Me.PanelPemasok.BackgroundImage = CType(resources.GetObject("PanelPemasok.BackgroundImage"), System.Drawing.Image)
        Me.PanelPemasok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelPemasok.Controls.Add(Me.TextboxHP)
        Me.PanelPemasok.Controls.Add(Me.ImageButtonKeluar)
        Me.PanelPemasok.Controls.Add(Me.TextboxKodePos)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel14)
        Me.PanelPemasok.Controls.Add(Me.TextboxKota)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel7)
        Me.PanelPemasok.Controls.Add(Me.TextboxAlamat)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel5)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel13)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel15)
        Me.PanelPemasok.Controls.Add(Me.PictureboxPemasok)
        Me.PanelPemasok.Controls.Add(Me.ButtonKeluar)
        Me.PanelPemasok.Controls.Add(Me.ButtonSimpan)
        Me.PanelPemasok.Controls.Add(Me.ButtonHapusGambar)
        Me.PanelPemasok.Controls.Add(Me.ButtonPilihGambar)
        Me.PanelPemasok.Controls.Add(Me.TextboxTelepon)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel11)
        Me.PanelPemasok.Controls.Add(Me.TextboxNamaPemasok)
        Me.PanelPemasok.Controls.Add(Me.BunifuCustomLabel10)
        Me.PanelPemasok.Controls.Add(Me.TextboxKodePemasok)
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
        Me.PanelPemasok.TabIndex = 4
        '
        'TextboxHP
        '
        Me.TextboxHP.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextboxHP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxHP.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.TextboxHP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHP.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHP.HintText = ""
        Me.TextboxHP.isPassword = False
        Me.TextboxHP.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHP.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxHP.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxHP.LineThickness = 3
        Me.TextboxHP.Location = New System.Drawing.Point(200, 238)
        Me.TextboxHP.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxHP.Name = "TextboxHP"
        Me.TextboxHP.Size = New System.Drawing.Size(185, 35)
        Me.TextboxHP.TabIndex = 63
        Me.TextboxHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BindingSourcePemasok
        '
        Me.BindingSourcePemasok.DataMember = "Tabel Pemasok"
        Me.BindingSourcePemasok.DataSource = Me.Database_Boho_OutletDataSet
        '
        'Database_Boho_OutletDataSet
        '
        Me.Database_Boho_OutletDataSet.DataSetName = "Database_Boho_OutletDataSet"
        Me.Database_Boho_OutletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabel_PemasokTableAdapter
        '
        Me.Tabel_PemasokTableAdapter.ClearBeforeFill = True
        '
        'FPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 500)
        Me.Controls.Add(Me.PanelPemasok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FPemasok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FPemasok"
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureboxPemasok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPemasok.ResumeLayout(False)
        Me.PanelPemasok.PerformLayout()
        CType(Me.BindingSourcePemasok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageButtonKeluar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TextboxKodePos As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxKota As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxAlamat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureboxPemasok As PictureBox
    Friend WithEvents ButtonKeluar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonSimpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonHapusGambar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ButtonPilihGambar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TextboxTelepon As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxNamaPemasok As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TextboxKodePemasok As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ButtonBaru As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PanelPemasok As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents TextboxHP As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BindingSourcePemasok As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_PemasokTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_PemasokTableAdapter
End Class

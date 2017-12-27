<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMasuk))
        Me.ButtonMasuk = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TextboxKataSandi = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TextboxNamaPengguna = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LabelKataSandi = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.LabelNamaPengguna = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ImageButtonKeluar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LabelMasuk = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.Tabel_MasukTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_MasukTableAdapter()
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonMasuk
        '
        Me.ButtonMasuk.Activecolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonMasuk.BorderRadius = 0
        Me.ButtonMasuk.ButtonText = "Masuk"
        Me.ButtonMasuk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMasuk.DisabledColor = System.Drawing.Color.Gray
        Me.ButtonMasuk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonMasuk.Iconcolor = System.Drawing.Color.Transparent
        Me.ButtonMasuk.Iconimage = Nothing
        Me.ButtonMasuk.Iconimage_right = Nothing
        Me.ButtonMasuk.Iconimage_right_Selected = Nothing
        Me.ButtonMasuk.Iconimage_Selected = Nothing
        Me.ButtonMasuk.IconMarginLeft = 0
        Me.ButtonMasuk.IconMarginRight = 0
        Me.ButtonMasuk.IconRightVisible = True
        Me.ButtonMasuk.IconRightZoom = 0R
        Me.ButtonMasuk.IconVisible = True
        Me.ButtonMasuk.IconZoom = 90.0R
        Me.ButtonMasuk.IsTab = False
        Me.ButtonMasuk.Location = New System.Drawing.Point(30, 245)
        Me.ButtonMasuk.Name = "ButtonMasuk"
        Me.ButtonMasuk.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ButtonMasuk.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ButtonMasuk.OnHoverTextColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonMasuk.selected = False
        Me.ButtonMasuk.Size = New System.Drawing.Size(241, 48)
        Me.ButtonMasuk.TabIndex = 30
        Me.ButtonMasuk.Text = "Masuk"
        Me.ButtonMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ButtonMasuk.Textcolor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ButtonMasuk.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TextboxKataSandi
        '
        Me.TextboxKataSandi.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxKataSandi.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKataSandi.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxKataSandi.BorderThickness = 3
        Me.TextboxKataSandi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxKataSandi.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxKataSandi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxKataSandi.isPassword = True
        Me.TextboxKataSandi.Location = New System.Drawing.Point(13, 180)
        Me.TextboxKataSandi.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxKataSandi.Name = "TextboxKataSandi"
        Me.TextboxKataSandi.Size = New System.Drawing.Size(274, 44)
        Me.TextboxKataSandi.TabIndex = 29
        Me.TextboxKataSandi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'TextboxNamaPengguna
        '
        Me.TextboxNamaPengguna.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxNamaPengguna.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaPengguna.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TextboxNamaPengguna.BorderThickness = 3
        Me.TextboxNamaPengguna.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextboxNamaPengguna.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextboxNamaPengguna.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TextboxNamaPengguna.isPassword = False
        Me.TextboxNamaPengguna.Location = New System.Drawing.Point(13, 110)
        Me.TextboxNamaPengguna.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxNamaPengguna.Name = "TextboxNamaPengguna"
        Me.TextboxNamaPengguna.Size = New System.Drawing.Size(274, 44)
        Me.TextboxNamaPengguna.TabIndex = 28
        Me.TextboxNamaPengguna.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelKataSandi
        '
        Me.LabelKataSandi.AutoSize = True
        Me.LabelKataSandi.BackColor = System.Drawing.Color.Transparent
        Me.LabelKataSandi.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelKataSandi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelKataSandi.Location = New System.Drawing.Point(12, 160)
        Me.LabelKataSandi.Name = "LabelKataSandi"
        Me.LabelKataSandi.Size = New System.Drawing.Size(69, 16)
        Me.LabelKataSandi.TabIndex = 27
        Me.LabelKataSandi.Text = "Kata Sandi"
        '
        'LabelNamaPengguna
        '
        Me.LabelNamaPengguna.AutoSize = True
        Me.LabelNamaPengguna.BackColor = System.Drawing.Color.Transparent
        Me.LabelNamaPengguna.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNamaPengguna.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelNamaPengguna.Location = New System.Drawing.Point(12, 90)
        Me.LabelNamaPengguna.Name = "LabelNamaPengguna"
        Me.LabelNamaPengguna.Size = New System.Drawing.Size(102, 16)
        Me.LabelNamaPengguna.TabIndex = 26
        Me.LabelNamaPengguna.Text = "Nama Pengguna"
        '
        'ImageButtonKeluar
        '
        Me.ImageButtonKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ImageButtonKeluar.Image = CType(resources.GetObject("ImageButtonKeluar.Image"), System.Drawing.Image)
        Me.ImageButtonKeluar.ImageActive = Nothing
        Me.ImageButtonKeluar.Location = New System.Drawing.Point(270, 0)
        Me.ImageButtonKeluar.Name = "ImageButtonKeluar"
        Me.ImageButtonKeluar.Size = New System.Drawing.Size(30, 30)
        Me.ImageButtonKeluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonKeluar.TabIndex = 25
        Me.ImageButtonKeluar.TabStop = False
        Me.ImageButtonKeluar.Zoom = 10
        '
        'LabelMasuk
        '
        Me.LabelMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelMasuk.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelMasuk.Font = New System.Drawing.Font("Century Gothic", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMasuk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.LabelMasuk.Location = New System.Drawing.Point(0, 0)
        Me.LabelMasuk.Name = "LabelMasuk"
        Me.LabelMasuk.Size = New System.Drawing.Size(300, 62)
        Me.LabelMasuk.TabIndex = 24
        Me.LabelMasuk.Text = "Masuk"
        Me.LabelMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Tabel Masuk"
        Me.BindingSource1.DataSource = Me.Database_Boho_OutletDataSet
        '
        'Database_Boho_OutletDataSet
        '
        Me.Database_Boho_OutletDataSet.DataSetName = "Database_Boho_OutletDataSet"
        Me.Database_Boho_OutletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabel_MasukTableAdapter
        '
        Me.Tabel_MasukTableAdapter.ClearBeforeFill = True
        '
        'FMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 320)
        Me.Controls.Add(Me.ButtonMasuk)
        Me.Controls.Add(Me.TextboxKataSandi)
        Me.Controls.Add(Me.TextboxNamaPengguna)
        Me.Controls.Add(Me.LabelKataSandi)
        Me.Controls.Add(Me.LabelNamaPengguna)
        Me.Controls.Add(Me.ImageButtonKeluar)
        Me.Controls.Add(Me.LabelMasuk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masuk"
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonMasuk As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TextboxKataSandi As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TextboxNamaPengguna As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LabelKataSandi As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents LabelNamaPengguna As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ImageButtonKeluar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents LabelMasuk As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_MasukTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_MasukTableAdapter
End Class

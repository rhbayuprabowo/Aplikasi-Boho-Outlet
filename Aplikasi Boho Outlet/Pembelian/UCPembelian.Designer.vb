<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPembelian))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ImageButtonTambah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonEdit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonHapus = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonMenyegarkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DataGridPembelian = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.NomorPembelianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalPembelianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodePemasokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPemasokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourcePembelian = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Tabel_PembelianTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_PembelianTableAdapter()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonHapus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourcePembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(24, 21)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(128, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Pembelian"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuImageButton5.Image = CType(resources.GetObject("BunifuImageButton5.Image"), System.Drawing.Image)
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(663, 68)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(35, 35)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 8
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'DataGridPembelian
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridPembelian.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridPembelian.AutoGenerateColumns = False
        Me.DataGridPembelian.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridPembelian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridPembelian.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPembelian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomorPembelianDataGridViewTextBoxColumn, Me.TanggalPembelianDataGridViewTextBoxColumn, Me.KodePemasokDataGridViewTextBoxColumn, Me.NamaPemasokDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn, Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.SatuanDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridPembelian.DataSource = Me.BindingSourcePembelian
        Me.DataGridPembelian.DoubleBuffered = True
        Me.DataGridPembelian.EnableHeadersVisualStyles = False
        Me.DataGridPembelian.GridColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DataGridPembelian.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DataGridPembelian.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DataGridPembelian.Location = New System.Drawing.Point(29, 109)
        Me.DataGridPembelian.Name = "DataGridPembelian"
        Me.DataGridPembelian.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridPembelian.Size = New System.Drawing.Size(1053, 520)
        Me.DataGridPembelian.TabIndex = 9
        '
        'NomorPembelianDataGridViewTextBoxColumn
        '
        Me.NomorPembelianDataGridViewTextBoxColumn.DataPropertyName = "Nomor Pembelian"
        Me.NomorPembelianDataGridViewTextBoxColumn.HeaderText = "Nomor Pembelian"
        Me.NomorPembelianDataGridViewTextBoxColumn.Name = "NomorPembelianDataGridViewTextBoxColumn"
        '
        'TanggalPembelianDataGridViewTextBoxColumn
        '
        Me.TanggalPembelianDataGridViewTextBoxColumn.DataPropertyName = "Tanggal Pembelian"
        Me.TanggalPembelianDataGridViewTextBoxColumn.HeaderText = "Tanggal Pembelian"
        Me.TanggalPembelianDataGridViewTextBoxColumn.Name = "TanggalPembelianDataGridViewTextBoxColumn"
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
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
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
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "Harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'BindingSourcePembelian
        '
        Me.BindingSourcePembelian.DataMember = "Tabel Pembelian"
        Me.BindingSourcePembelian.DataSource = Me.Database_Boho_OutletDataSet
        '
        'Database_Boho_OutletDataSet
        '
        Me.Database_Boho_OutletDataSet.DataSetName = "Database_Boho_OutletDataSet"
        Me.Database_Boho_OutletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.DataGridPembelian)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButton5)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonMenyegarkan)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonHapus)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonEdit)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonTambah)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuDropdown1)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(1111, 660)
        Me.BunifuGradientPanel2.TabIndex = 8
        '
        'Tabel_PembelianTableAdapter
        '
        Me.Tabel_PembelianTableAdapter.ClearBeforeFill = True
        '
        'UCPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Name = "UCPembelian"
        Me.Size = New System.Drawing.Size(1111, 660)
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonHapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourcePembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ImageButtonTambah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonEdit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonHapus As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonMenyegarkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DataGridPembelian As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents NomorPembelianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalPembelianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodePemasokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPemasokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SatuanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingSourcePembelian As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Tabel_PembelianTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_PembelianTableAdapter
End Class

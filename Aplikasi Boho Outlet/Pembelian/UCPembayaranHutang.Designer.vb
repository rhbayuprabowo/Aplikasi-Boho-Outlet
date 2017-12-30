<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPembayaranHutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPembayaranHutang))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ImageButtonMenyegarkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonTambah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DatagridPenyesuaian = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.NomorPembayaranDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalPembayaranDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomorPembelianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodePemasokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPemasokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourcePembayaranHutang = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.TextboxPencarian = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tabel_Pembayaran_HutangTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_Pembayaran_HutangTableAdapter()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridPenyesuaian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourcePembayaranHutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonMenyegarkan)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonTambah)
        Me.BunifuGradientPanel2.Controls.Add(Me.DatagridPenyesuaian)
        Me.BunifuGradientPanel2.Controls.Add(Me.TextboxPencarian)
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
        Me.BunifuGradientPanel2.TabIndex = 6
        '
        'ImageButtonMenyegarkan
        '
        Me.ImageButtonMenyegarkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ImageButtonMenyegarkan.Image = CType(resources.GetObject("ImageButtonMenyegarkan.Image"), System.Drawing.Image)
        Me.ImageButtonMenyegarkan.ImageActive = Nothing
        Me.ImageButtonMenyegarkan.Location = New System.Drawing.Point(75, 62)
        Me.ImageButtonMenyegarkan.Name = "ImageButtonMenyegarkan"
        Me.ImageButtonMenyegarkan.Size = New System.Drawing.Size(40, 40)
        Me.ImageButtonMenyegarkan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonMenyegarkan.TabIndex = 7
        Me.ImageButtonMenyegarkan.TabStop = False
        Me.ImageButtonMenyegarkan.Zoom = 10
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
        'DatagridPenyesuaian
        '
        Me.DatagridPenyesuaian.AllowUserToAddRows = False
        Me.DatagridPenyesuaian.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridPenyesuaian.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridPenyesuaian.AutoGenerateColumns = False
        Me.DatagridPenyesuaian.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DatagridPenyesuaian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridPenyesuaian.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridPenyesuaian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridPenyesuaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridPenyesuaian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomorPembayaranDataGridViewTextBoxColumn, Me.TanggalPembayaranDataGridViewTextBoxColumn, Me.NomorPembelianDataGridViewTextBoxColumn, Me.KodePemasokDataGridViewTextBoxColumn, Me.NamaPemasokDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.DatagridPenyesuaian.DataSource = Me.BindingSourcePembayaranHutang
        Me.DatagridPenyesuaian.DoubleBuffered = True
        Me.DatagridPenyesuaian.EnableHeadersVisualStyles = False
        Me.DatagridPenyesuaian.GridColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DatagridPenyesuaian.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DatagridPenyesuaian.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DatagridPenyesuaian.Location = New System.Drawing.Point(29, 110)
        Me.DatagridPenyesuaian.Name = "DatagridPenyesuaian"
        Me.DatagridPenyesuaian.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridPenyesuaian.Size = New System.Drawing.Size(1053, 516)
        Me.DatagridPenyesuaian.TabIndex = 3
        '
        'NomorPembayaranDataGridViewTextBoxColumn
        '
        Me.NomorPembayaranDataGridViewTextBoxColumn.DataPropertyName = "Nomor Pembayaran"
        Me.NomorPembayaranDataGridViewTextBoxColumn.HeaderText = "Nomor Pembayaran"
        Me.NomorPembayaranDataGridViewTextBoxColumn.Name = "NomorPembayaranDataGridViewTextBoxColumn"
        '
        'TanggalPembayaranDataGridViewTextBoxColumn
        '
        Me.TanggalPembayaranDataGridViewTextBoxColumn.DataPropertyName = "Tanggal Pembayaran"
        Me.TanggalPembayaranDataGridViewTextBoxColumn.HeaderText = "Tanggal Pembayaran"
        Me.TanggalPembayaranDataGridViewTextBoxColumn.Name = "TanggalPembayaranDataGridViewTextBoxColumn"
        '
        'NomorPembelianDataGridViewTextBoxColumn
        '
        Me.NomorPembelianDataGridViewTextBoxColumn.DataPropertyName = "Nomor Pembelian"
        Me.NomorPembelianDataGridViewTextBoxColumn.HeaderText = "Nomor Pembelian"
        Me.NomorPembelianDataGridViewTextBoxColumn.Name = "NomorPembelianDataGridViewTextBoxColumn"
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
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
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
        Me.TextboxPencarian.Location = New System.Drawing.Point(897, 67)
        Me.TextboxPencarian.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxPencarian.Name = "TextboxPencarian"
        Me.TextboxPencarian.Size = New System.Drawing.Size(185, 35)
        Me.TextboxPencarian.TabIndex = 2
        Me.TextboxPencarian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(24, 21)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(239, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Pembayaran Hutang"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tabel_Pembayaran_HutangTableAdapter
        '
        Me.Tabel_Pembayaran_HutangTableAdapter.ClearBeforeFill = True
        '
        'UCPembayaranHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Name = "UCPembayaranHutang"
        Me.Size = New System.Drawing.Size(1111, 660)
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridPenyesuaian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourcePembayaranHutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ImageButtonMenyegarkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonTambah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DatagridPenyesuaian As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TextboxPencarian As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BindingSourcePembayaranHutang As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_Pembayaran_HutangTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_Pembayaran_HutangTableAdapter
    Friend WithEvents NomorPembayaranDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalPembayaranDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomorPembelianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodePemasokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPemasokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

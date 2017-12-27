<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCPenyesuaian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPenyesuaian))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonTambah = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonMenyegarkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DatagridPenyesuaian = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BindingSourcePenyesuaian = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_Boho_OutletDataSet = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSet()
        Me.Tabel_PenyesuaianTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_PenyesuaianTableAdapter()
        Me.NomorPenyesuaianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridPenyesuaian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.BindingSourcePenyesuaian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DatagridPenyesuaian
        '
        Me.DatagridPenyesuaian.AllowUserToAddRows = False
        Me.DatagridPenyesuaian.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridPenyesuaian.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DatagridPenyesuaian.AutoGenerateColumns = False
        Me.DatagridPenyesuaian.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DatagridPenyesuaian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridPenyesuaian.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridPenyesuaian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DatagridPenyesuaian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridPenyesuaian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomorPenyesuaianDataGridViewTextBoxColumn, Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DatagridPenyesuaian.DataSource = Me.BindingSourcePenyesuaian
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
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(148, 25)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Penyesuaian"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButton5)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonMenyegarkan)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonTambah)
        Me.BunifuGradientPanel2.Controls.Add(Me.DatagridPenyesuaian)
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
        Me.BunifuGradientPanel2.TabIndex = 4
        '
        'BindingSourcePenyesuaian
        '
        Me.BindingSourcePenyesuaian.DataMember = "Tabel Penyesuaian"
        Me.BindingSourcePenyesuaian.DataSource = Me.Database_Boho_OutletDataSet
        '
        'Database_Boho_OutletDataSet
        '
        Me.Database_Boho_OutletDataSet.DataSetName = "Database_Boho_OutletDataSet"
        Me.Database_Boho_OutletDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabel_PenyesuaianTableAdapter
        '
        Me.Tabel_PenyesuaianTableAdapter.ClearBeforeFill = True
        '
        'NomorPenyesuaianDataGridViewTextBoxColumn
        '
        Me.NomorPenyesuaianDataGridViewTextBoxColumn.DataPropertyName = "Nomor Penyesuaian"
        Me.NomorPenyesuaianDataGridViewTextBoxColumn.HeaderText = "Nomor Penyesuaian"
        Me.NomorPenyesuaianDataGridViewTextBoxColumn.Name = "NomorPenyesuaianDataGridViewTextBoxColumn"
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
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        '
        'UCPenyesuaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Name = "UCPenyesuaian"
        Me.Size = New System.Drawing.Size(1111, 660)
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridPenyesuaian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.BindingSourcePenyesuaian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonTambah As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents ImageButtonMenyegarkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DatagridPenyesuaian As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents NomorPenyesuaianDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingSourcePenyesuaian As BindingSource
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents Tabel_PenyesuaianTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_PenyesuaianTableAdapter
End Class

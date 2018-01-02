<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDataPemasok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FDataPemasok))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ImageButtonKeluar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ImageButtonMenyegarkan = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DatagridData = New Bunifu.Framework.UI.BunifuCustomDataGrid()
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
        Me.TextboxPencarian = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.LabelDataPemasok = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Tabel_PemasokTableAdapter = New Aplikasi_Boho_Outlet.Database_Boho_OutletDataSetTableAdapters.Tabel_PemasokTableAdapter()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelPemasokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonKeluar)
        Me.BunifuGradientPanel2.Controls.Add(Me.ImageButtonMenyegarkan)
        Me.BunifuGradientPanel2.Controls.Add(Me.DatagridData)
        Me.BunifuGradientPanel2.Controls.Add(Me.TextboxPencarian)
        Me.BunifuGradientPanel2.Controls.Add(Me.LabelDataPemasok)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(880, 540)
        Me.BunifuGradientPanel2.TabIndex = 9
        '
        'ImageButtonKeluar
        '
        Me.ImageButtonKeluar.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ImageButtonKeluar.Image = CType(resources.GetObject("ImageButtonKeluar.Image"), System.Drawing.Image)
        Me.ImageButtonKeluar.ImageActive = Nothing
        Me.ImageButtonKeluar.Location = New System.Drawing.Point(850, 3)
        Me.ImageButtonKeluar.Name = "ImageButtonKeluar"
        Me.ImageButtonKeluar.Size = New System.Drawing.Size(30, 30)
        Me.ImageButtonKeluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonKeluar.TabIndex = 63
        Me.ImageButtonKeluar.TabStop = False
        Me.ImageButtonKeluar.Zoom = 10
        '
        'ImageButtonMenyegarkan
        '
        Me.ImageButtonMenyegarkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ImageButtonMenyegarkan.Image = CType(resources.GetObject("ImageButtonMenyegarkan.Image"), System.Drawing.Image)
        Me.ImageButtonMenyegarkan.ImageActive = Nothing
        Me.ImageButtonMenyegarkan.Location = New System.Drawing.Point(29, 63)
        Me.ImageButtonMenyegarkan.Name = "ImageButtonMenyegarkan"
        Me.ImageButtonMenyegarkan.Size = New System.Drawing.Size(40, 40)
        Me.ImageButtonMenyegarkan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageButtonMenyegarkan.TabIndex = 7
        Me.ImageButtonMenyegarkan.TabStop = False
        Me.ImageButtonMenyegarkan.Zoom = 10
        '
        'DatagridData
        '
        Me.DatagridData.AllowUserToAddRows = False
        Me.DatagridData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatagridData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridData.AutoGenerateColumns = False
        Me.DatagridData.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DatagridData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DatagridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodePemasokDataGridViewTextBoxColumn, Me.NamaPemasokDataGridViewTextBoxColumn, Me.TeleponDataGridViewTextBoxColumn, Me.HPDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.KotaDataGridViewTextBoxColumn, Me.KodePosDataGridViewTextBoxColumn, Me.GambarDataGridViewImageColumn})
        Me.DatagridData.DataSource = Me.TabelPemasokBindingSource
        Me.DatagridData.DoubleBuffered = True
        Me.DatagridData.EnableHeadersVisualStyles = False
        Me.DatagridData.GridColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DatagridData.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.DatagridData.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.DatagridData.Location = New System.Drawing.Point(29, 110)
        Me.DatagridData.Name = "DatagridData"
        Me.DatagridData.ReadOnly = True
        Me.DatagridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DatagridData.Size = New System.Drawing.Size(820, 400)
        Me.DatagridData.TabIndex = 3
        '
        'KodePemasokDataGridViewTextBoxColumn
        '
        Me.KodePemasokDataGridViewTextBoxColumn.DataPropertyName = "Kode Pemasok"
        Me.KodePemasokDataGridViewTextBoxColumn.HeaderText = "Kode Pemasok"
        Me.KodePemasokDataGridViewTextBoxColumn.Name = "KodePemasokDataGridViewTextBoxColumn"
        Me.KodePemasokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaPemasokDataGridViewTextBoxColumn
        '
        Me.NamaPemasokDataGridViewTextBoxColumn.DataPropertyName = "Nama Pemasok"
        Me.NamaPemasokDataGridViewTextBoxColumn.HeaderText = "Nama Pemasok"
        Me.NamaPemasokDataGridViewTextBoxColumn.Name = "NamaPemasokDataGridViewTextBoxColumn"
        Me.NamaPemasokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeleponDataGridViewTextBoxColumn
        '
        Me.TeleponDataGridViewTextBoxColumn.DataPropertyName = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.HeaderText = "Telepon"
        Me.TeleponDataGridViewTextBoxColumn.Name = "TeleponDataGridViewTextBoxColumn"
        Me.TeleponDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HPDataGridViewTextBoxColumn
        '
        Me.HPDataGridViewTextBoxColumn.DataPropertyName = "HP"
        Me.HPDataGridViewTextBoxColumn.HeaderText = "HP"
        Me.HPDataGridViewTextBoxColumn.Name = "HPDataGridViewTextBoxColumn"
        Me.HPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KotaDataGridViewTextBoxColumn
        '
        Me.KotaDataGridViewTextBoxColumn.DataPropertyName = "Kota"
        Me.KotaDataGridViewTextBoxColumn.HeaderText = "Kota"
        Me.KotaDataGridViewTextBoxColumn.Name = "KotaDataGridViewTextBoxColumn"
        Me.KotaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KodePosDataGridViewTextBoxColumn
        '
        Me.KodePosDataGridViewTextBoxColumn.DataPropertyName = "Kode Pos"
        Me.KodePosDataGridViewTextBoxColumn.HeaderText = "Kode Pos"
        Me.KodePosDataGridViewTextBoxColumn.Name = "KodePosDataGridViewTextBoxColumn"
        Me.KodePosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GambarDataGridViewImageColumn
        '
        Me.GambarDataGridViewImageColumn.DataPropertyName = "Gambar"
        Me.GambarDataGridViewImageColumn.HeaderText = "Gambar"
        Me.GambarDataGridViewImageColumn.Name = "GambarDataGridViewImageColumn"
        Me.GambarDataGridViewImageColumn.ReadOnly = True
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
        Me.TextboxPencarian.Location = New System.Drawing.Point(664, 68)
        Me.TextboxPencarian.Margin = New System.Windows.Forms.Padding(4)
        Me.TextboxPencarian.Name = "TextboxPencarian"
        Me.TextboxPencarian.Size = New System.Drawing.Size(185, 35)
        Me.TextboxPencarian.TabIndex = 2
        Me.TextboxPencarian.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LabelDataPemasok
        '
        Me.LabelDataPemasok.AutoSize = True
        Me.LabelDataPemasok.BackColor = System.Drawing.Color.Transparent
        Me.LabelDataPemasok.Font = New System.Drawing.Font("Century Gothic", 16.0!)
        Me.LabelDataPemasok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.LabelDataPemasok.Location = New System.Drawing.Point(24, 21)
        Me.LabelDataPemasok.Name = "LabelDataPemasok"
        Me.LabelDataPemasok.Size = New System.Drawing.Size(170, 25)
        Me.LabelDataPemasok.TabIndex = 0
        Me.LabelDataPemasok.Text = "Data Pemasok"
        Me.LabelDataPemasok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tabel_PemasokTableAdapter
        '
        Me.Tabel_PemasokTableAdapter.ClearBeforeFill = True
        '
        'FDataPemasok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 540)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FDataPemasok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pemasok"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.ImageButtonKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageButtonMenyegarkan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelPemasokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_Boho_OutletDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ImageButtonMenyegarkan As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DatagridData As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TextboxPencarian As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents LabelDataPemasok As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Database_Boho_OutletDataSet As Database_Boho_OutletDataSet
    Friend WithEvents TabelPemasokBindingSource As BindingSource
    Friend WithEvents Tabel_PemasokTableAdapter As Database_Boho_OutletDataSetTableAdapters.Tabel_PemasokTableAdapter
    Friend WithEvents KodePemasokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaPemasokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeleponDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodePosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GambarDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents ImageButtonKeluar As Bunifu.Framework.UI.BunifuImageButton
End Class

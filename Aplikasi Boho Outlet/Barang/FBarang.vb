Public Class FBarang

    Private Tambah As Boolean = True

    Public Sub EditData(TambahBaru As Boolean, KodeBarang As String)

        Me.Tambah = TambahBaru

        If (Not TambahBaru) Then

            Dim Data = Tabel_BarangTableAdapter.GetDataByKodeBarang(KodeBarang)

            TextboxKodeBarang.Text = Data(0).Kode_Barang
            TextboxNamaBarang.Text = Data(0).Nama_Barang
            DropdownKategoriBarang.selectedIndex = Data(0).Kategori_Barang
            DropdownMerekBarang.selectedIndex = Data(0).Merek_Barang
            TextboxJumlah.Text = Data(0).Jumlah
            DropdownSatuan.selectedIndex = Data(0).Satuan
            TextboxHargaBeli.Text = Data(0).Harga_Beli
            TextboxHargaJual.Text = Data(0).Harga_Jual
            'PictureboxBarang.Image = Data(0).Gambar

        End If

    End Sub

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        If (Tambah) Then
            'Untuk fungsi data baru
            Tabel_BarangTableAdapter.InsertQueryByKodeBarang(TextboxKodeBarang.Text,
                                                           TextboxNamaBarang.Text,
                                                           DropdownKategoriBarang.selectedValue,
                                                           DropdownMerekBarang.selectedValue,
                                                           TextboxJumlah.Text,
                                                           DropdownSatuan.selectedValue,
                                                           TextboxHargaBeli.Text,
                                                           TextboxHargaJual.Text,
                                                           Nothing)

        Else

            Tabel_BarangTableAdapter.UpdateQueryByKodeBarang(TextboxKodeBarang.Text,
                                                           TextboxNamaBarang.Text,
                                                           DropdownKategoriBarang.selectedValue,
                                                           DropdownMerekBarang.selectedValue,
                                                           TextboxJumlah.Text,
                                                           DropdownSatuan.selectedValue,
                                                           TextboxHargaBeli.Text,
                                                           TextboxHargaJual.Text,
                                                           Nothing,
                                                           TextboxKodeBarang.Text)

        End If

        TextboxKodeBarang.Text = ""
        TextboxNamaBarang.Text = ""
        DropdownKategoriBarang.Clear()
        DropdownMerekBarang.Clear()
        TextboxJumlah.Text = ""
        DropdownSatuan.Clear()
        TextboxHargaBeli.Text = ""
        TextboxHargaJual.Text = ""

    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click

        TextboxKodeBarang.Text = ""
        TextboxNamaBarang.Text = ""
        DropdownKategoriBarang.Clear()
        DropdownMerekBarang.Clear()
        TextboxJumlah.Text = ""
        DropdownSatuan.Clear()
        TextboxHargaBeli.Text = ""
        TextboxHargaJual.Text = ""

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Keluar()

    End Sub

End Class
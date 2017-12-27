Public Class FPembelian

    Private Tambah As Boolean = True

    Public Sub EditData(TambahBaru As Boolean, NomorPembelian As String)

        Me.Tambah = TambahBaru

        If (Not TambahBaru) Then

            Dim Data = Tabel_PembelianTableAdapter.GetDataByNomorPembelian(NomorPembelian)

            TextboxNomorPembelian.Text = Data(0).Nomor_Pembelian
            DatepickerTanggalPembelian.Value = Data(0).Tanggal_Pembelian
            TextboxKodePemasok.Text = Data(0).Kode_Pemasok
            TextboxNamaPemasok.Text = Data(0).Nama_Pemasok

            For i = 0 To Data.Count - 1

                DatagridPembelian.Rows.Add(Data(i).Kode_Barang,
                                           Data(i).Nama_Barang,
                                           Data(i).Jumlah,
                                           Data(i).Satuan,
                                           Data(i).Harga,
                                           Data(i).Total)

            Next

        End If

    End Sub

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        If (Tambah) Then
            'untuk fungsi data baru
            With DatagridPembelian
                .EndEdit()

                For RowIndex = 0 To .Rows.Count - 1
                    Tabel_PembelianTableAdapter.InsertQueryByNomorPembelian(TextboxNomorPembelian.Text,
                                               DatepickerTanggalPembelian.Value.ToShortDateString(),
                                               TextboxKodePemasok.Text,
                                               TextboxNamaPemasok.Text,
                                               TextboxKeterangan.Text,
                                               .Item(0, RowIndex).Value.ToString, 'Kode Barang
                                               .Item(1, RowIndex).Value.ToString, 'Nama Barang
                                               .Item(2, RowIndex).Value.ToString, 'Jumlah
                                               .Item(3, RowIndex).Value.ToString, 'Satuan
                                               .Item(4, RowIndex).Value.ToString, 'Harga
                                               .Item(5, RowIndex).Value.ToString) 'Total
                Next

                TextboxNomorPembelian.Text = ""
                DatepickerTanggalPembelian.Value = Date.Now
                TextboxKodePemasok.Text = ""
                TextboxNamaPemasok.Text = ""
                TextboxKeterangan.Text = ""
                .Rows.Clear()


            End With

        Else
            'untuk fungsi edit data
            With DatagridPembelian
                .EndEdit()
                For RowIndex = 0 To .Rows.Count - 1

                    Tabel_PembelianTableAdapter.UpdateQueryByNomorPembelian(TextboxNomorPembelian.Text,
                                               DatepickerTanggalPembelian.Value.ToShortDateString(),
                                               TextboxKodePemasok.Text,
                                               TextboxNamaPemasok.Text,
                                               TextboxKeterangan.Text,
                                               .Item(0, RowIndex).Value.ToString, 'Kode Barang
                                               .Item(1, RowIndex).Value.ToString, 'Nama Barang
                                               .Item(2, RowIndex).Value.ToString, 'Jumlah
                                               .Item(3, RowIndex).Value.ToString, 'Satuan
                                               .Item(4, RowIndex).Value.ToString, 'Harga
                                               .Item(5, RowIndex).Value.ToString, 'Total
                                               TextboxNomorPembelian.Text)

                Next

                TextboxNomorPembelian.Text = ""
                DatepickerTanggalPembelian.Value = Date.Now
                TextboxKodePemasok.Text = ""
                TextboxNamaPemasok.Text = ""
                TextboxKeterangan.Text = ""
                .Rows.Clear()

            End With

        End If

    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click

        DatagridPembelian.Rows.Add()

    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click

        DatagridPembelian.Rows.Remove(DatagridPembelian.CurrentRow)

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub BIBKeluar_Click(sender As Object, e As EventArgs) Handles BIBKeluar.Click

        Keluar()

    End Sub

End Class
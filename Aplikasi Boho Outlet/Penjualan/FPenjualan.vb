Public Class FPenjualan

    Private Tambah As Boolean = True

    Public Sub EditData(TambahBaru As Boolean, NomorPenjualan As String)

        Me.Tambah = TambahBaru

        If (Not TambahBaru) Then

            Dim Data = Tabel_PenjualanTableAdapter.GetDataByNomorPenjualan(NomorPenjualan)

            TextboxNomorPenjualan.Text = Data(0).Nomor_Penjualan
            TextboxNamaPelanggan.Text = Data(0).Nama_Pelanggan
            DatepickerTanggalPenjualan.Value = Data(0).Tanggal_Penjualan

            For i = 0 To Data.Count - 1

                DatagridPenjualan.Rows.Add(Data(i).Kode_Barang,
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
            With DatagridPenjualan
                .EndEdit()

                For RowIndex = 0 To .Rows.Count - 1
                    Tabel_PenjualanTableAdapter.InsertQueryByNomorPenjualan(TextboxNomorPenjualan.Text,
                                                                            TextboxNamaPelanggan.Text,
                                                                            DatepickerTanggalPenjualan.Value.ToShortDateString(),
                                                                            .Item(0, RowIndex).Value.ToString, 'Kode Barang
                                                                            .Item(1, RowIndex).Value.ToString, 'Nama Barang
                                                                            .Item(2, RowIndex).Value.ToString, 'Jumlah
                                                                            .Item(3, RowIndex).Value.ToString, 'Satuan
                                                                            .Item(4, RowIndex).Value.ToString, 'Harga
                                                                            .Item(5, RowIndex).Value.ToString) 'Total
                Next

                TextboxNomorPenjualan.Text = ""
                TextboxNamaPelanggan.Text = ""
                DatepickerTanggalPenjualan.Value = Date.Now
                .Rows.Clear()


            End With

        Else
            'untuk fungsi edit data
            With DatagridPenjualan
                .EndEdit()
                For RowIndex = 0 To .Rows.Count - 1

                    Tabel_PenjualanTableAdapter.UpdateQueryByNomorPenjualan(TextboxNomorPenjualan.Text,
                                                                            TextboxNamaPelanggan.Text,
                                                                            DatepickerTanggalPenjualan.Value.ToShortDateString(),
                                                                            .Item(0, RowIndex).Value.ToString, 'Kode Barang
                                                                            .Item(1, RowIndex).Value.ToString, 'Nama Barang
                                                                            .Item(2, RowIndex).Value.ToString, 'Jumlah
                                                                            .Item(3, RowIndex).Value.ToString, 'Satuan
                                                                            .Item(4, RowIndex).Value.ToString, 'Harga
                                                                            .Item(5, RowIndex).Value.ToString, 'Total
                                                                            TextboxNomorPenjualan.Text)

                Next

                TextboxNomorPenjualan.Text = ""
                TextboxNamaPelanggan.Text = ""
                DatepickerTanggalPenjualan.Value = Date.Now
                .Rows.Clear()

            End With

        End If

    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click

        DatagridPenjualan.Rows.Add()

    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click

        DatagridPenjualan.Rows.Remove(DatagridPenjualan.CurrentRow)

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub BIBKeluar_Click(sender As Object, e As EventArgs) Handles BIBKeluar.Click

        Keluar()

    End Sub

End Class
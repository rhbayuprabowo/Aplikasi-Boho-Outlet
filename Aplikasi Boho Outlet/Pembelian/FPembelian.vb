Imports System.IO
Imports Bunifu.Framework.UI
Public Class FPembelian

    Private Tambah As Boolean = True
    Private fileName As String = ""

    Public Sub EditData(TambahBaru As Boolean, NomorPembelian As String)

        Me.Tambah = TambahBaru

        If (Not TambahBaru) Then

            Dim Data = Tabel_PembelianTableAdapter.GetDataByNomorPembelian(NomorPembelian)

            TextboxNomorPembelian.Text = Data(0).Nomor_Pembelian
            DatepickerTanggalPembelian.Value = Data(0).Tanggal_Pembelian
            TextboxKodePemasok.Text = Data(0).Kode_Pemasok
            TextboxNamaPemasok.Text = Data(0).Nama_Pemasok
            TextboxKeterangan.Text = Data(0).Keterangan

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

    Private Sub FPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load

        DatepickerTanggalPembelian.Value = Date.Now

        Using data_tabel As DataTable = Tabel_PembelianTableAdapter.GetData()

        End Using

    End Sub

    Private Sub ValidatingTextBoxes(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextboxNomorPembelian.Validating,
                                                                                                         TextboxKodePemasok.Validating,
                                                                                                         TextboxNamaPemasok.Validating,
                                                                                                         TextboxKeterangan.Validating


        Dim TextBoxes = DirectCast(sender, BunifuMaterialTextbox).Text
        Dim IsError As String = ErrorMessageNomorPembelian(TextBoxes)
        If Not IsError = "" Then
            TooltipError(DirectCast(sender, BunifuMaterialTextbox), IsError)
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(255, 20, 20)
            e.Cancel = True
        Else
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(48, 48, 48)
        End If
    End Sub

    Private Function ErrorMessageNomorPembelian(TextBoxes As String) As String
        If TextBoxes.Length = 0 Then
            Return "Tidak boleh kosong.!!!"
        Else
            Return ""
        End If
    End Function

    Private Sub TooltipError(TextBoxes As BunifuMaterialTextbox, Pesan As String)
        Dim toolTip1 As New ToolTip With {
            .ShowAlways = True
        }
        toolTip1.Show(Pesan, TextBoxes, 0, -25, 1000)
    End Sub

End Class
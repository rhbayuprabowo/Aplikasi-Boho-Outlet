﻿Imports System.IO
Imports Bunifu.Framework.UI
Public Class FPenjualan

    'Private Tambah As Boolean = True
    Private fileName As String = ""

    'Public Sub EditData(TambahBaru As Boolean, NomorPenjualan As String)

    '    Me.Tambah = TambahBaru

    '    If (Not TambahBaru) Then

    '        Dim Data = Tabel_PenjualanTableAdapter.GetDataByNomorPenjualan(NomorPenjualan)

    '        TextboxNomorPenjualan.Text = Data(0).Nomor_Penjualan
    '        TextboxNamaPelanggan.Text = Data(0).Nama_Pelanggan
    '        DatepickerTanggalPenjualan.Value = Data(0).Tanggal_Penjualan

    '        For i = 0 To Data.Count - 1

    '            DatagridPenjualan.Rows.Add(Data(i).Kode_Barang,
    '                                       Data(i).Nama_Barang,
    '                                       Data(i).Jumlah,
    '                                       Data(i).Satuan,
    '                                       Data(i).Harga,
    '                                       Data(i).Total)

    '        Next

    '    End If

    'End Sub

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        'If (Tambah) Then
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

                    Tabel_BarangTableAdapter.UpdateQueryJumlahDiKurang(Convert.ToUInt32(.Item(2, RowIndex).Value.ToString),
                                                                                   .Item(0, RowIndex).Value.ToString)
                Next

                TextboxNomorPenjualan.Text = ""
                TextboxNamaPelanggan.Text = ""
                DatepickerTanggalPenjualan.Value = Date.Now
                .Rows.Clear()


            End With

        'Else
        '    'untuk fungsi edit data
        '    With DatagridPenjualan
        '        .EndEdit()
        '        For RowIndex = 0 To .Rows.Count - 1

        '            Tabel_PenjualanTableAdapter.UpdateQueryByNomorPenjualan(TextboxNomorPenjualan.Text,
        '                                                                    TextboxNamaPelanggan.Text,
        '                                                                    DatepickerTanggalPenjualan.Value.ToShortDateString(),
        '                                                                    .Item(0, RowIndex).Value.ToString, 'Kode Barang
        '                                                                    .Item(1, RowIndex).Value.ToString, 'Nama Barang
        '                                                                    .Item(2, RowIndex).Value.ToString, 'Jumlah
        '                                                                    .Item(3, RowIndex).Value.ToString, 'Satuan
        '                                                                    .Item(4, RowIndex).Value.ToString, 'Harga
        '                                                                    .Item(5, RowIndex).Value.ToString, 'Total
        '                                                                    TextboxNomorPenjualan.Text)

        '        Next

        '        TextboxNomorPenjualan.Text = ""
        '        TextboxNamaPelanggan.Text = ""
        '        DatepickerTanggalPenjualan.Value = Date.Now
        '        .Rows.Clear()

        '    End With

        'End If

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

    Private Sub FPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DatepickerTanggalPenjualan.Value = Date.Now

        Using data_tabel = Tabel_PenjualanTableAdapter.GetData()
            If data_tabel.Rows.Count = 0 Then
                TextboxNomorPenjualan.Text = "NPEN-" + 1.ToString("D4")
            Else
                Dim NomorArray = data_tabel(data_tabel.Count - 1).Nomor_Penjualan.Split("-"c)
                Dim NomorPenjualan = Convert.ToInt32(NomorArray(1)) + 1
                TextboxNomorPenjualan.Text = "NPEN-" + NomorPenjualan.ToString("D4")
            End If
        End Using

    End Sub

    Private Sub ValidatingTextBoxes(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextboxNomorPenjualan.Validating


        Dim TextBoxes = DirectCast(sender, BunifuMaterialTextbox).Text
        Dim IsError As String = ErrorMessageNomorPenjualan(TextBoxes)
        If Not IsError = "" Then
            TooltipError(DirectCast(sender, BunifuMaterialTextbox), IsError)
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(255, 20, 20)
            e.Cancel = True
        Else
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(48, 48, 48)
        End If
    End Sub

    Private Function ErrorMessageNomorPenjualan(TextBoxes As String) As String
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

    Private Sub DatagridPenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles DatagridPenjualan.KeyDown
        If DatagridPenjualan.Rows.Count > 0 And e.KeyCode = Keys.F2 Then
            Dim FormData = New FDataBarang
            FormData.ShowDialog()
            DatagridPenjualan.Item(0, DatagridPenjualan.CurrentCell.RowIndex).Value = FormData.Kode_Barang
            DatagridPenjualan.Item(1, DatagridPenjualan.CurrentCell.RowIndex).Value = FormData.Nama_Barang
            DatagridPenjualan.Item(3, DatagridPenjualan.CurrentCell.RowIndex).Value = FormData.Satuan
            DatagridPenjualan.Item(4, DatagridPenjualan.CurrentCell.RowIndex).Value = FormData.Harga
            DatagridPenjualan.EndEdit()
            FormData.Dispose()
        End If
    End Sub

    Private Sub DatagridPenjualan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridPenjualan.CellDoubleClick
        DatagridPenjualan.BeginEdit(True)
    End Sub

    Private Sub DatagridPenjualan_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DatagridPenjualan.CellEndEdit

        If e.ColumnIndex = 2 Then
            DatagridPenjualan.Item(5, e.RowIndex).Value = CInt(DatagridPenjualan.Item(2, e.RowIndex).Value) * CInt(DatagridPenjualan.Item(4, e.RowIndex).Value)
        End If

    End Sub
End Class
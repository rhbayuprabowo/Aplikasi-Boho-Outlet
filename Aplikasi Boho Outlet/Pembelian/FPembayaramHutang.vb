Imports System.IO
Imports Bunifu.Framework.UI
Public Class FPembayaramHutang

    Private fileName As String = ""

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        Tabel_Pembayaran_HutangTableAdapter.InsertQueryByNomorPembayaran(TextboxNomorPembayaranHutang.Text,
                                                                         DatepickerTanggalPembayaran.Value.ToShortDateString(),
                                                                         TextboxNomorPembelian.Text,
                                                                         TextboxKodePemasok.Text,
                                                                         TextboxNamaPemasok.Text,
                                                                         DropdownStatus.selectedValue)

        TextboxNomorPembayaranHutang.Text = ""
        DatepickerTanggalPembayaran.Value = Date.Now
        TextboxNomorPembelian.Text = ""
        TextboxKodePemasok.Text = ""
        TextboxNamaPemasok.Text = ""
        DropdownStatus.Clear()

    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click

        TextboxNomorPembayaranHutang.Text = ""
        DatepickerTanggalPembayaran.Value = Date.Now
        TextboxNomorPembelian.Text = ""
        TextboxKodePemasok.Text = ""
        TextboxNamaPemasok.Text = ""
        DropdownStatus.Clear()

    End Sub

    Private Sub Keluar()

        Me.Close()

    End Sub

    Private Sub ButtonKeluar_Click(sender As Object, e As EventArgs) Handles ButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub ImageButtonKeluar_Click(sender As Object, e As EventArgs) Handles ImageButtonKeluar.Click

        Keluar()

    End Sub

    Private Sub FPembayaramHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DatepickerTanggalPembayaran.Value = Date.Now

        Using data_tabel = Tabel_Pembayaran_HutangTableAdapter.GetData()
            If data_tabel.Rows.Count = 0 Then
                TextboxNomorPembayaranHutang.Text = "NPEMH-" + 1.ToString("D4")
            Else
                Dim NomorArray = data_tabel(data_tabel.Count - 1).Nomor_Pembayaran.Split("-"c)
                Dim NomorPembayaranHutang = Convert.ToInt32(NomorArray(1)) + 1
                TextboxNomorPembayaranHutang.Text = "NPEMH-" + NomorPembayaranHutang.ToString("D4")
            End If
        End Using

    End Sub

    Private Sub ValidatingTextBoxes(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextboxNomorPembayaranHutang.Validating,
                                                                                                        TextboxNomorPembelian.Validating,
                                                                                                        TextboxKodePemasok.Validating,
                                                                                                        TextboxNamaPemasok.Validating

        Dim TextBoxes = DirectCast(sender, BunifuMaterialTextbox).Text
        Dim IsError As String = ErrorMessageNomorPembayaranHutang(TextBoxes)
        If Not IsError = "" Then
            TooltipError(DirectCast(sender, BunifuMaterialTextbox), IsError)
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(255, 20, 20)
            e.Cancel = True
        Else
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(48, 48, 48)
        End If
    End Sub

    Private Function ErrorMessageNomorPembayaranHutang(TextBoxes As String) As String
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

    Private Sub ImageButtonKodePemasok_Click(sender As Object, e As EventArgs) Handles ImageButtonKodePemasok.Click
        Dim FormData = New FDataPemasok
        FormData.ShowDialog()
        TextboxKodePemasok.Text = FormData.Kode_Pemasok
        TextboxNamaPemasok.Text = FormData.Nama_Pemasok
        FormData.Dispose()
    End Sub

    Private Sub BunifuImageNomorPembelian_Click(sender As Object, e As EventArgs) Handles BunifuImageNomorPembelian.Click

        Dim FormData = New FDataPembelian
        FormData.ShowDialog()
        TextboxNomorPembelian.Text = FormData.Nomor_Pembelian
        FormData.Dispose()

    End Sub
End Class
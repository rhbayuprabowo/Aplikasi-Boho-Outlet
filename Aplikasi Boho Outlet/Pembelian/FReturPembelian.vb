Imports System.IO
Imports Bunifu.Framework.UI
Public Class FReturPembelian

    Private fileName As String = ""

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click

        Tabel_Retur_PembelianTableAdapter.InsertQueryByNomorReturPembelian(TextboxNomorReturPembelian.Text,
                                                                   TextboxKodeBarang.Text,
                                                                   TextboxNamaBarang.Text,
                                                                   TextboxJumlah.Text,
                                                                   TextboxHarga.Text,
                                                                   TextboxKeterangan.Text)

        TextboxNomorReturPembelian.Text = ""
        TextboxKodeBarang.Text = ""
        TextboxNamaBarang.Text = ""
        TextboxJumlah.Text = ""
        TextboxHarga.Text = ""
        TextboxKeterangan.Text = ""

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

    Private Sub ValidatingTextBoxes(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextboxNomorReturPembelian.Validating,
                                                                                                         TextboxKodeBarang.Validating,
                                                                                                         TextboxNamaBarang.Validating,
                                                                                                         TextboxJumlah.Validating,
                                                                                                         TextboxHarga.Validating,
                                                                                                         TextboxKeterangan.Validating

        Dim TextBoxes = DirectCast(sender, BunifuMaterialTextbox).Text
        Dim IsError As String = ErrorMessageNomorReturPembelian(TextBoxes)
        If Not IsError = "" Then
            TooltipError(DirectCast(sender, BunifuMaterialTextbox), IsError)
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(255, 20, 20)
            e.Cancel = True
        Else
            DirectCast(sender, BunifuMaterialTextbox).LineFocusedColor = Color.FromArgb(48, 48, 48)
        End If
    End Sub

    Private Function ErrorMessageNomorReturPembelian(TextBoxes As String) As String
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
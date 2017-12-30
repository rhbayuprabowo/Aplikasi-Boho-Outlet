﻿Public Class UCPenyesuaian

    Private Sub UCPenyesuaian_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Tabel_PenyesuaianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penyesuaian)

    End Sub

    Private Sub ImageButtonTambah_Click(sender As Object, e As EventArgs) Handles ImageButtonTambah.Click

        FPenyesuaian.ShowDialog()

        Me.Tabel_PenyesuaianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penyesuaian)

    End Sub

    Private Sub ImageButtonMenyegarkan_Click(sender As Object, e As EventArgs) Handles ImageButtonMenyegarkan.Click

        Me.Tabel_PenyesuaianTableAdapter.Fill(Me.Database_Boho_OutletDataSet.Tabel_Penyesuaian)

    End Sub

    Private Sub TextboxPencarian_KeyDown(sender As Object, e As KeyEventArgs) Handles TextboxPencarian.KeyDown

        If e.KeyCode = Keys.Enter Then

            Me.Tabel_PenyesuaianTableAdapter.FillByFilterPencarian(Me.Database_Boho_OutletDataSet.Tabel_Penyesuaian, "%" + TextboxPencarian.Text + "%")
            TextboxPencarian.Text = ""

        End If

    End Sub

End Class

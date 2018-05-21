Public Class Oberflaeche

    Private Sub DateiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateiToolStripMenuItem.Click

    End Sub

    Private Sub BearbeitungToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BearbeitungToolStripMenuItem.Click

    End Sub

    Private Sub InfoUndSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoUndSupportToolStripMenuItem.Click

    End Sub

    Private Sub NutzungsbedingungenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NutzungsbedingungenToolStripMenuItem.Click
        Nutzungsbedingungen.Show()

    End Sub

    Private Sub HilfeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HilfeToolStripMenuItem.Click
        Hilfe.Show()

    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        Info.Show()

    End Sub

    Private Sub SupportAnfragenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub NeuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NeuToolStripMenuItem.Click
        RichTextBox1.Clear()

    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖffnenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        Dim text As String = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
        RichTextBox1.Text = text

    End Sub

    Private Sub BeendenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Close()


    End Sub

    Private Sub AusschneidenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AusschneidenToolStripMenuItem.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub KopierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KopierenToolStripMenuItem.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub EinfügenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinfügenToolStripMenuItem.Click
        RichTextBox1.Paste()

    End Sub

    Private Sub RückgänigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RückgänigToolStripMenuItem.Click
        RichTextBox1.Undo()

    End Sub

    Private Sub AllesMarkierenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllesMarkierenToolStripMenuItem.Click
        RichTextBox1.SelectAll()

    End Sub

    Private Sub LöschenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LöschenToolStripMenuItem.Click

    End Sub

    Private Sub SuchenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeichernToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        System.IO.File.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text)

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Dokument As New Bitmap(RichTextBox1.Width, RichTextBox1.Height)
        Me.DrawToBitmap(Dokument, New Rectangle(0, 0, RichTextBox1.Width, RichTextBox1.Height))
        e.Graphics.DrawImage(Dokument, 0, 0)

    End Sub

    Private Sub DruckenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DruckenToolStripMenuItem.Click
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub ReadmitxtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadmitxtToolStripMenuItem.Click
        readmi.Show()

    End Sub
End Class

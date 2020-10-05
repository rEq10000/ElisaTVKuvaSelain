Imports System.Drawing.Imaging

Public Class Form1
    Dim down = False
    Dim myBrush = Brushes.Red
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If CheckBox1.Checked = True Then
            down = True
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If CheckBox1.Checked = True And down = True Then
            PictureBox1.CreateGraphics.FillEllipse(myBrush, e.X, e.Y, TrackBar1.Value, TrackBar1.Value)
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        down = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        PictureBox1.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            PictureBox1.Load("http://thumbs.elisaviihde.fi/thumbnails/" + TextBox1.Text + ".jpg")
        Catch ex As Exception
            MessageBox.Show("Kuvaa ei löytynyt.")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            PictureBox1.Load("http://thumbs.elisaviihde.fi/thumbnails/" + TextBox1.Text + "_655x368.jpg")
        Catch ex As Exception
            MessageBox.Show("Kuvaa ei löytynyt.")
        End Try

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label1.Text = TrackBar1.Value
    End Sub

    Private Sub PunainenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PunainenToolStripMenuItem.Click
        myBrush = Brushes.Red
    End Sub

    Private Sub VihreäToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VihreäToolStripMenuItem.Click
        myBrush = Brushes.Green
    End Sub

    Private Sub SininenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SininenToolStripMenuItem.Click
        myBrush = Brushes.Blue
    End Sub

    Private Sub KeltainenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeltainenToolStripMenuItem.Click
        myBrush = Brushes.Yellow
    End Sub

    Private Sub MustaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MustaToolStripMenuItem.Click
        myBrush = Brushes.Black
    End Sub

    Private Sub ValkoinenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValkoinenToolStripMenuItem.Click
        myBrush = Brushes.White
    End Sub


    Private Sub TallennaKuvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TallennaKuvaToolStripMenuItem.Click
        Try
            Dim sfd As SaveFileDialog = New SaveFileDialog()
            sfd.Filter = "Image File(*.jpg) | *.jpg"
            If sfd.ShowDialog = DialogResult.OK Then
                If sfd.FileName.EndsWith("jpg") Then
                    PictureBox1.Image.Save(sfd.FileName, ImageFormat.Jpeg)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        System.Diagnostics.Process.Start("https://elisaviihde.fi/ohjelmaopas/ohjelma/" + TextBox1.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        System.Diagnostics.Process.Start("http://thumbs.elisaviihde.fi/thumbnails/" + TextBox1.Text + ".jpg")
        System.Diagnostics.Process.Start("http://thumbs.elisaviihde.fi/thumbnails/" + TextBox1.Text + "_655x368.jpg")
    End Sub

    Private Sub MeneOhjelmasivulleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeneOhjelmasivulleToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://elisaviihde.fi/ohjelmaopas/ohjelma/" + TextBox1.Text)
    End Sub

    Private Sub MeneKuvasivulleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeneKuvasivulleToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://thumbs.elisaviihde.fi/thumbnails/" + TextBox1.Text + ".jpg")
        System.Diagnostics.Process.Start("http://thumbs.elisaviihde.fi/thumbnails/" + TextBox1.Text + "_655x368.jpg")
    End Sub




End Class
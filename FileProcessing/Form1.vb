Imports System.IO

Public Class Form1
    Dim filePath As String = "sample.txt"

    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Try
            Using writer As New StreamWriter(filePath, True) ' True to append
                writer.WriteLine("Hello, this is a test file!")
                writer.WriteLine("Second line of text.")
            End Using

            MessageBox.Show("Data written successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Using reader As New StreamReader(filePath)
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show(content, "File Content:")
        End Using
    End Sub

    Private Sub ButtonReadPerLine_Click(sender As Object, e As EventArgs) Handles ButtonReadPerLine.Click
        Using reader As New StreamReader(filePath)
            Dim line As String = reader.ReadLine()
            MessageBox.Show(line)
        End Using
    End Sub
End Class

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        Me.TopLevel = True
        Me.TopMost = True

        Label1.Text = Form1.Label2.Text + "個"

        Dim SR As System.IO.StreamReader = IO.File.OpenText("C:\Users\ed4u2\Desktop\WindowsApp2\WindowsApp2\0.0.csv")
        '沒有要讀取的字元或資料，則為 -1'
        While SR.Peek <> -1
            ListBox1.Items.Add(SR.ReadLine())
        End While
        SR.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form2.Show()
        Form2.Enabled = True
        Me.Close()
        Me.Enabled = False
        Form1.Close()
        Form1.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label1_click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox1.Items.Add(TextBox1.Text + Label1.Text)

        Dim SW As IO.StreamWriter = IO.File.CreateText("C:\Users\ed4u2\Desktop\WindowsApp2\WindowsApp2\0.0.csv")
        '存listbox1之中items'
        For Each S As String In ListBox1.Items
            SW.WriteLine(S)
        Next
        SW.Close()


        Button1.Enabled = False

    End Sub
End Class
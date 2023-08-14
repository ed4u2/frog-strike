Public Class Form1
    Private counter As Integer
    Private a, c, score As Integer

    Dim Rnd As New Random()
    Dim b1, b2, b3, b4, b5 As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter = counter - 1
        Label1.Text = counter.ToString + "秒"

        If counter = 0 Then
            Timer1.Stop()
            Form3.Show()


        End If
    End Sub
    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.Z Then
            a = 1
        ElseIf e.KeyCode = Keys.X Then
            a = 2
        ElseIf e.KeyCode = Keys.C Then
            a = 3
        End If
        If PictureBox1.Visible = True Then
            c = 1
        ElseIf PictureBox5.Visible = True Then
            c = 2
        ElseIf PictureBox6.Visible = True Then
            c = 3
        End If

        '第一排146 第二排271 第三排395 第四排526'
        If a = c Then
            score = score + 1
            Label2.Text = score
            Select Case c
                Case 1
                    PictureBox1.Visible = False
                Case 2
                    PictureBox5.Visible = False
                Case 3
                    PictureBox6.Visible = False
            End Select
            If PictureBox7.Visible = True Then
                PictureBox7.Visible = False
                PictureBox1.Visible = True
            ElseIf PictureBox8.Visible = True Then
                PictureBox8.Visible = False
                PictureBox5.Visible = True
            ElseIf PictureBox9.Visible = True Then
                PictureBox9.Visible = False
                PictureBox6.Visible = True
            End If
            If PictureBox10.Visible = True Then
                PictureBox10.Visible = False
                PictureBox7.Visible = True
            ElseIf PictureBox11.Visible = True Then
                PictureBox11.Visible = False
                PictureBox8.Visible = True
            ElseIf PictureBox12.Visible = True Then
                PictureBox12.Visible = False
                PictureBox9.Visible = True
            End If
            If PictureBox13.Visible = True Then
                PictureBox13.Visible = False
                PictureBox10.Visible = True
            ElseIf PictureBox14.Visible = True Then
                PictureBox14.Visible = False
                PictureBox11.Visible = True
            ElseIf PictureBox15.Visible = True Then
                PictureBox15.Visible = False
                PictureBox12.Visible = True
            End If

            b5 = Rnd.Next(1, 4)
            Select Case b5
                Case 1
                    PictureBox13.Visible = True
                Case 2
                    PictureBox14.Visible = True
                Case 3
                    PictureBox15.Visible = True
            End Select
        End If


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Enabled = True

        counter = 30

        Timer1.Interval = 1000

        Timer1.Enabled = True

        b1 = Rnd.Next(1, 4)
        b2 = Rnd.Next(1, 4)
        b3 = Rnd.Next(1, 4)
        b4 = Rnd.Next(1, 4)


        Select Case b1
            Case 1
                PictureBox1.Visible = True
            Case 2
                PictureBox5.Visible = True
            Case 3
                PictureBox6.Visible = True
        End Select

        Select Case b2
            Case 1
                PictureBox7.Visible = True
            Case 2
                PictureBox8.Visible = True
            Case 3
                PictureBox9.Visible = True
        End Select

        Select Case b3
            Case 1
                PictureBox10.Visible = True
            Case 2
                PictureBox11.Visible = True
            Case 3
                PictureBox12.Visible = True
        End Select

        Select Case b4
            Case 1
                PictureBox13.Visible = True
            Case 2
                PictureBox14.Visible = True
            Case 3
                PictureBox15.Visible = True
        End Select

    End Sub
End Class

Structure student
    Dim name As String
    Dim roll As String
    Dim dept As String
    Dim adrr As String
    Dim ph As String
    Dim f As Boolean

End Structure


Public Class Form1
    Dim count As Integer = 6
    Dim nxt_position As Integer = 0
    Dim prev_position As Integer = 0
    Dim f As Boolean = True
    Dim f3 As Form3
    Dim total As Integer = 6
    Dim Curr_pos As Integer = 0
    Dim s(100) As student

    Public Function visibility(ByVal Flag As Boolean)
        TextBox3.Visible = Flag
        Label6.Visible = Flag
    End Function


    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
        Dim dialog As DialogResult
        dialog = MessageBox.Show("do you want to save this", "Save", MessageBoxButtons.YesNo)
        If dialog = MsgBoxResult.Yes Then
            s(count).roll = ComboBox1.Text + "00" + count.ToString
            s(count).adrr = TextBox4.Text
            s(count).dept = ComboBox1.Text
            s(count).name = TextBox1.Text
            s(count).ph = TextBox5.Text
            s(count).f = True
            TextBox2.Text = s(count).roll
            count = count + 1
            total = total + 1
        End If
        TabControl1.SelectTab(0)

    End Sub


    Private Sub EDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDIT.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = False
        Button1.Visible = False
        Button5.Visible = True
    End Sub

    Private Function edd()
        visibility(True)
        f = False
        Dim i As Integer
        For i = 0 To count - 1
            If TextBox3.Text = s(i).roll And s(i).f = True Then
                f = True
                Exit For
            End If
        Next
        If f = True Then
            s(i).adrr = TextBox4.Text
            s(i).name = TextBox1.Text
            s(i).ph = TextBox5.Text
        Else
            Label7.Visible = True
        End If
    End Function


    Private Sub SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH.Click
        Button5.Visible = False
        sear()
    End Sub

    Private Function sear()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        ComboBox1.Enabled = False
        Button1.Visible = False
        '   TextBox3.Text = s(0).roll
        Dim f As Boolean = False
        Dim i As Integer = 0
        For i = 0 To count - 1
            If TextBox3.Text = s(i).roll And s(i).f = True Then
                f = True
                Exit For
            End If
        Next
        '    TextBox3.Text = vbNullString
        If f = True Then
            TextBox2.Text = s(i).roll
            TextBox4.Text = s(i).adrr
            ComboBox1.Text = s(i).dept
            TextBox1.Text = s(i).name
            TextBox5.Text = s(i).ph
            Label7.Visible = False
            EDIT.Visible = True
            DELETE.Visible = True
            TabControl1.SelectTab(2)
        Else
            Label7.Visible = True
        End If


    End Function
    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        Button1.Visible = False
        Dim i As Integer
        Dim f As Boolean = False
        Dim dialog As DialogResult
        dialog = MessageBox.Show("do you want to Delet this", "Delet", MessageBoxButtons.YesNo)
        If dialog = MsgBoxResult.Yes Then
            For i = 0 To count - 1
                If TextBox3.Text = s(i).roll And s(i).f = True Then
                    s(i).f = False
                    total = total - 1
                    f = True
                    Exit For

                End If

            Next
            If f = True Then
                Label7.Visible = False
                PREV.Visible = False
                Button3.Visible = False

                TextBox1.Clear()
                TextBox2.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                ComboBox1.ResetText()
                TabControl1.SelectTab(0)
            Else
                Label7.Visible = True
            End If
        End If



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EDIT.Visible = False
        DELETE.Visible = False
        Button1.Visible = False

        s(0).name = "AAAAA"
        s(0).roll = "CSE001"
        s(0).dept = "CSE"
        s(0).f = True
        s(0).adrr = "Kolkata"
        s(0).ph = "0123456789"


        s(1).name = "BBBBB"
        s(1).roll = "EE001"
        s(1).dept = "EE"
        s(1).f = True
        s(1).adrr = "Delhi"
        s(1).ph = "0123456789"

        s(2).name = "CCCCCC"
        s(2).roll = "ECE003"
        s(2).dept = "ECE"
        s(2).f = True
        s(2).adrr = "Mumbai"
        s(2).ph = "0123456789"

        s(3).name = "DDDDDD"
        s(3).roll = "ME004"
        s(3).dept = "ME"
        s(3).f = True
        s(3).adrr = "Agra"
        s(3).ph = "0123456789"

        s(4).name = "EEEEE"
        s(4).roll = "ECE005"
        s(4).dept = "ECE"
        s(4).f = True
        s(4).adrr = "Kashmir"
        s(4).ph = "0123456789"

        s(5).name = "FFFFFF"
        s(5).roll = "EE006"
        s(5).dept = "EE"
        s(5).f = True
        s(5).adrr = "Jharkhand"
        s(5).ph = "0123456789"

    End Sub

    Private Sub DISPLAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DISPLAY.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        ComboBox1.Enabled = False
        Button1.Visible = False
        first()
        TabControl1.SelectTab(1)

    End Sub

    Private Function addi()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.ResetText()
        TextBox1.Enabled = True
        TextBox2.Enabled = False
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
    End Function

    Private Function first()
        Dim j As Integer = 0
        Dim i As Integer
        Dim str As String
        'TextBox6.Text = ""
        prev_position = -1
        Curr_pos = 0
        DataGridView1.Rows.Clear()
        For i = 0 To count - 1
            If s(i).f = True And j < 5 Then
                j = j + 1
                Curr_pos = Curr_pos + 1
                'str = "name-  " + s(i).name + "       dept  :" + s(i).dept + "     roll-  " + s(i).roll + "    address-  " + s(i).adrr + "    ph.no-  +91" + s(i).ph + " "
                DataGridView1.Rows.Add(s(i).name, s(i).roll, s(i).dept, s(i).adrr, s(i).ph)
                'TextBox6.AppendText(str & Environment.NewLine)
                'TextBox6.AppendText(" " & Environment.NewLine)

            ElseIf j = 5 Then

                Exit For

            End If
        Next
        nxt_position = i
        '  TextBox6.Text = str
        If Curr_pos < total Then
            Button3.Visible = True
        Else
            Button3.Visible = False
        End If
        If Curr_pos - 5 > 0 Then
            PREV.Visible = True
        Else
            PREV.Visible = False
        End If
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim j As Integer = 0
        Dim i As Integer
        Dim str As String
        'TextBox6.Text = ""
        prev_position = nxt_position - 1
        DataGridView1.Rows.Clear()
        For i = nxt_position To count - 1
            If s(i).f = True And j < 5 Then
                j = j + 1
                Curr_pos = Curr_pos + 1
                ' str = "NAME-  " + s(i).name + "    ROLL-  " + s(i).roll + "    ADDRESS-  " + s(i).adrr + "    Ph.NO-  +91" + s(i).ph + " "
                DataGridView1.Rows.Add(s(i).name, s(i).roll, s(i).dept, s(i).adrr, s(i).ph)
                ' TextBox6.AppendText(str & Environment.NewLine)
                '  TextBox6.AppendText(" " & Environment.NewLine)

            ElseIf j = 5 Then
                Exit For

            End If
        Next
        nxt_position = i
        If Curr_pos < total Then
            Button3.Visible = True
        Else
            Button3.Visible = False
        End If
        If Curr_pos - 5 > 0 Then
            PREV.Visible = True
        Else
            PREV.Visible = False
        End If
    End Sub

    Private Sub PREV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PREV.Click
        Dim j As Integer = 0
        Dim i As Integer
        Dim str As String
        'TextBox6.Text = ""
        nxt_position = prev_position + 1
        DataGridView1.Rows.Clear()
        For i = prev_position To 0 Step -1
            If s(i).f = True And j < 5 Then
                j = j + 1
                ' str = "NAME-  " + s(i).name + "    ROLL-  " + s(i).roll + "    ADDRESS-  " + s(i).adrr + "    Ph.NO-  +91" + s(i).ph + " "
                DataGridView1.Rows.Add(s(i).name, s(i).roll, s(i).dept, s(i).adrr, s(i).ph)
                ' TextBox6.AppendText(str & Environment.NewLine)
                ' TextBox6.AppendText(" " & Environment.NewLine)

            ElseIf j = 5 Then
                Exit For
            End If
        Next
        prev_position = i
        Curr_pos = Curr_pos - 5
        If Curr_pos - 5 > 0 Then
            PREV.Visible = True
        Else
            PREV.Visible = False
        End If

        If Curr_pos < total Then
            Button3.Visible = True
        Else
            Button3.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button5.Visible = False
        Button1.Visible = True
        addi()
        TabControl1.SelectTab(2)
        DELETE.Visible = False
        EDIT.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        edd()
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectTab(0)
    End Sub

End Class

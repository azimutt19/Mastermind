Public Class Form1
    Dim i = 0, tentativas = 0
    Dim a, b, c, d, amarelo, azul, laranja, rosa, roxo, verde As Integer

    Dim rand As New Random


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a = rand.Next(6)
        b = rand.Next(6)
        Do While b = a
            b = rand.Next(6)
        Loop
        c = rand.Next(6)
        Do While c = a Or c = b
            c = rand.Next(6)
        Loop
        d = rand.Next(6)
        Do While d = a Or d = b Or d = c
            d = rand.Next(6)
        Loop

        For i = 0 To 100
            If ListBox1.SelectedItems.Count = 1 And ListBox2.SelectedItems.Count = 1 And ListBox3.SelectedItems.Count = 1 AndAlso ListBox4.SelectedItems.Count = 1 Then
                tentativas = tentativas + 1
                ListBox1.ClearSelected()
                ListBox2.ClearSelected()
                ListBox3.ClearSelected()
                ListBox4.ClearSelected()
                i = i + 1
            End If
        Next
        tb_tentativas.Text = tentativas



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem Is "Amarelo" And a = 0 Then
            TextBox1.Text = ListBox1.SelectedItem
        End If
        If ListBox1.SelectedItem Is "Azul" And a = 1 Then
            TextBox1.Text = ListBox1.SelectedItem
        End If
        If ListBox1.SelectedItem Is "Laranja" And a = 2 Then
            TextBox1.Text = ListBox1.SelectedItem
        End If
        If ListBox1.SelectedItem Is "Rosa" And a = 3 Then
            TextBox1.Text = ListBox1.SelectedItem
        End If
        If ListBox1.SelectedItem Is "Roxo" And a = 4 Then
            TextBox1.Text = ListBox1.SelectedItem
        End If
        If ListBox1.SelectedItem Is "Verde" And a = 5 Then
            TextBox1.Text = ListBox1.SelectedItem
        End If
        If ListBox1.SelectedItems.Count > 0 Then
            ListBox1.Enabled = False
        End If

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tb_tentativas_TextChanged(sender As Object, e As EventArgs) Handles tb_tentativas.TextChanged

    End Sub

    Private Sub btn_reiniciar_Click(sender As Object, e As EventArgs) Handles btn_reiniciar.Click
        tb_tentativas.Text = 0
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()
        ListBox3.ClearSelected()
        ListBox4.ClearSelected()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ListBox1.Enabled = True
        ListBox2.Enabled = True
        ListBox3.Enabled = True
        ListBox4.Enabled = True

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedItem Is "Amarelo" And b = 0 Then
            TextBox2.Text = ListBox2.SelectedItem
        End If
        If ListBox2.SelectedItem Is "Azul" And b = 1 Then
            TextBox2.Text = ListBox2.SelectedItem
        End If
        If ListBox2.SelectedItem Is "Laranja" And b = 2 Then
            TextBox2.Text = ListBox2.SelectedItem
        End If
        If ListBox2.SelectedItem Is "Rosa" And b = 3 Then
            TextBox2.Text = ListBox2.SelectedItem
        End If
        If ListBox2.SelectedItem Is "Roxo" And b = 4 Then
            TextBox2.Text = ListBox2.SelectedItem
        End If
        If ListBox2.SelectedItem Is "Verde" And b = 5 Then
            TextBox2.Text = ListBox2.SelectedItem
        End If
        If ListBox2.SelectedItems.Count > 0 Then
            ListBox2.Enabled = False
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        If ListBox3.SelectedItem Is "Amarelo" And c = 0 Then
            TextBox3.Text = ListBox3.SelectedItem
        End If
        If ListBox3.SelectedItem Is "Azul" And c = 1 Then
            TextBox3.Text = ListBox3.SelectedItem
        End If
        If ListBox3.SelectedItem Is "Laranja" And c = 2 Then
            TextBox3.Text = ListBox3.SelectedItem
        End If
        If ListBox3.SelectedItem Is "Rosa" And c = 3 Then
            TextBox3.Text = ListBox3.SelectedItem
        End If
        If ListBox3.SelectedItem Is "Roxo" And c = 4 Then
            TextBox3.Text = ListBox3.SelectedItem
        End If
        If ListBox3.SelectedItem Is "Verde" And c = 5 Then
            TextBox3.Text = ListBox3.SelectedItem
        End If
        If ListBox3.SelectedItems.Count > 0 Then
            ListBox3.Enabled = False
        End If
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedItem Is "Amarelo" And d = 0 Then
            TextBox4.Text = ListBox4.SelectedItem
        End If
        If ListBox4.SelectedItem Is "Azul" And d = 1 Then
            TextBox4.Text = ListBox4.SelectedItem
        End If
        If ListBox4.SelectedItem Is "Laranja" And d = 2 Then
            TextBox4.Text = ListBox4.SelectedItem
        End If
        If ListBox4.SelectedItem Is "Rosa" And d = 3 Then
            TextBox4.Text = ListBox4.SelectedItem
        End If
        If ListBox4.SelectedItem Is "Roxo" And d = 4 Then
            TextBox4.Text = ListBox4.SelectedItem
        End If
        If ListBox4.SelectedItem Is "Verde" And d = 5 Then
            TextBox4.Text = ListBox4.SelectedItem
        End If
        If ListBox4.SelectedItems.Count > 0 Then
            ListBox4.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" And TextBox3.Text IsNot "" AndAlso TextBox4.Text IsNot "" Then
            MsgBox("Parabéns, ganhou!!")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" And TextBox3.Text IsNot "" AndAlso TextBox4.Text IsNot "" Then
            MsgBox("Parabéns, ganhou!! ")
        End If
    End Sub
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_proxima.Click
        tb_tentativas.Text = Val(tb_tentativas.Text) + 1
        ListBox1.ClearSelected()
        ListBox2.ClearSelected()
        ListBox3.ClearSelected()
        ListBox4.ClearSelected()
        If TextBox1.Text Is "" Then
            ListBox1.Enabled = True
        End If
        If TextBox2.Text Is "" Then
            ListBox2.Enabled = True
        End If
        If TextBox3.Text Is "" Then
            ListBox3.Enabled = True
        End If
        If TextBox4.Text Is "" Then
            ListBox4.Enabled = True
        End If



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" And TextBox3.Text IsNot "" AndAlso TextBox4.Text IsNot "" Then
            MsgBox("Parabéns, ganhou!!")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" And TextBox3.Text IsNot "" AndAlso TextBox4.Text IsNot "" Then
            MsgBox("Parabéns, ganhou!!")
        End If
    End Sub

    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Dim resp As Integer
        resp = MsgBox("Tem a certeza que pretende abandonar a aplicação?", MsgBoxStyle.YesNo, "Abandonar")
        If resp = 6 Then
            Application.Exit()
        End If
    End Sub
End Class

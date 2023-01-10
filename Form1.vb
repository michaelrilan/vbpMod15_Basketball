Public Class Form1


    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim playerIndex As Integer = CInt(Math.Floor(Rnd() * 4))
        Dim action As Integer = CInt(Math.Floor(Rnd() * 3))


        Dim var_name_p1_blue As String
        Dim var_num_p1_blue As Integer
        Dim var_name_p2_blue As String
        Dim var_num_p2_blue As Integer

        Dim var_name_p1_red As String
        Dim var_num_p1_red As Integer
        Dim var_name_p2_red As String
        Dim var_num_p2_red As Integer

        var_name_p1_blue = name_p1_blue.Text
        var_num_p1_blue = num_p1_blue.Text
        var_name_p2_blue = name_p2_blue.Text
        var_num_p2_blue = num_p2_blue.Text

        var_name_p1_red = name_p1_red.Text
        var_num_p1_red = num_p1_red.Text
        var_name_p2_red = name_p2_red.Text
        var_num_p2_red = num_p2_red.Text


        Dim actionString As String = ""
        Dim player_wht_name As String = ""
        Dim player_wht_num As String = ""
        Dim player_wht_team As String = ""


        Select Case action
            Case 0
                actionString = "dribbles"
            Case 1
                actionString = "passes"
            Case 2
                actionString = "shoots"
        End Select



        Select Case playerIndex
            Case 0
                player_wht_name = var_name_p1_blue
                player_wht_num = var_num_p1_blue
                player_wht_team = "Blues"


            Case 1
                player_wht_name = var_name_p2_blue
                player_wht_num = var_num_p2_blue
                player_wht_team = "Blues"
            Case 2
                player_wht_name = var_name_p1_red
                player_wht_num = var_num_p1_red
                player_wht_team = "Reds"
            Case 3
                player_wht_name = var_name_p2_red
                player_wht_num = var_num_p2_red
                player_wht_team = "Reds"
        End Select
        outputt.Text = player_wht_name & ", number " & player_wht_num & " of the " & player_wht_team & " " & actionString & " the ball!"



    End Sub
End Class
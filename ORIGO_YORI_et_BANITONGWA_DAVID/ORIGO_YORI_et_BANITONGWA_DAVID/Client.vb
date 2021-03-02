Imports System.Data.OleDb
Public Class frnclient
    Dim connect As New OleDbConnection
    Dim rd As OleDbDataReader
    Private Sub frnclient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
        End If
        lister()
        lblclient1.Text = frnbienvenue.nomclient1
        MsgBox("La société MB est une société spécialisé dans la location de véhicules. Elle met à la disposition de ses clients, un large panel de véhicules. Quelle bonne affaire pour vous...Consultez vite nos offres!", MsgBoxStyle.Information, "Bienvenue")
    End Sub

    Sub lister()
        DGVClient.Rows.Clear()
        Dim command As String
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
        End If
        command = "select [Marque] , [Prixdelocation] , [Vitesse] , [Etatdedisponibilite] , [Description] , [Quantite] from Voiture"
        Dim cmd As New OleDbCommand(command, connect)
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read
                DGVClient.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
            Loop
        End If

        rd.Close()
        connect.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pctbox3.Click
        frnbienvenue.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pctbox1.Click
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
        End If
        lister()
    End Sub

    Sub lister_disponible()
        DGVClient.Rows.Clear()
        Dim command As String
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
        End If
        command = "select [Marque] , [Prixdelocation] , [Vitesse] , [Etatdedisponibilite] , [Description] , [Quantite] from Voiture where  [Etatdedisponibilite] = 'disponible' "

        Dim cmd As New OleDbCommand(command, connect)
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read
                DGVClient.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
            Loop
        End If

        rd.Close()
        connect.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pctbox2.Click
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
        End If
        lister_disponible()
    End Sub


    Dim marque1 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idvoiture As String
        Dim nb As Integer
        Dim qtee As Integer
        Dim command1 As String
        Dim command2 As String
        Dim etatcommande As String = "En cours"

        If txtquantiteclient.Text = "" Then
            MsgBox("Veuillez saisir le nombre de voiture à louer.", MsgBoxStyle.Information, "Commande")
        Else
            nb = txtquantiteclient.Text()
            If connect.State = ConnectionState.Closed Then
                connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
                connect.Open()
            End If

            command2 = "SELECT * FROM Voiture WHERE [Marque] LIKE '%" & marque1 & "%'"
            Dim cmd2 As New OleDbCommand(command2, connect)

            rd = cmd2.ExecuteReader

            If rd.Read Then
                idvoiture = rd.GetValue(0)
                qtee = rd.GetValue(6)
            End If

            If nb < 0 Then
                MsgBox("La quantité doit être une valeur positive.", MsgBoxStyle.Information, "Commande")
            ElseIf nb = 0 Then
                MsgBox("La quantité vaut 0.", MsgBoxStyle.Information, "Commande")
            ElseIf nb > qtee Then
                MsgBox("La quantité saisie est superieur au stock disponible.", MsgBoxStyle.Information, "Commande")
            Else

                command1 = "INSERT  into Commande (  [IDClient] , [IDVoiture] , [EtatCommande] , [QuantiteCommande] , [DateCommande]) values ( '" & frnbienvenue.idclient1 & "','" & idvoiture & "','" & etatcommande & "'," & nb & ", NOW() )"


                Dim cmd1 As New OleDbCommand(command1, connect)

                cmd1.Parameters.Add(New OleDbParameter("IDClient", CType(frnbienvenue.idclient1, String)))
                cmd1.Parameters.Add(New OleDbParameter("IDVoiture", CType(idvoiture, String)))
                cmd1.Parameters.Add(New OleDbParameter("EtatCommande", CType(etatcommande, String)))
                cmd1.Parameters.Add(New OleDbParameter("QuantiteCommande", CType(nb, Integer)))

                MsgBox("Commande envoyé", MsgBoxStyle.Information, "Commande")

                Dim r As Integer

                r = cmd1.ExecuteNonQuery()

                If (r <> 0) Then
                    Try

                        cmd1.Dispose()
                        connect.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If



    End Sub



    Public Sub populateDatagridView(valueToSearch As String)
        DGVClient.Rows.Clear()
        Dim command1 As String

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
        End If

        command1 = "select [Marque] , [Prixdelocation] , [Vitesse] , [Etatdedisponibilite] , [Description] , [Quantite] from Voiture WHERE [Marque] LIKE '%" & valueToSearch & "%'"
        Dim cmd As New OleDbCommand(command1, connect)
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read
                DGVClient.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
            Loop
        End If

        rd.Close()
        connect.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        populateDatagridView(txtrechercheclient.Text)
    End Sub

    Private Sub pctbox1_MouseHover(sender As Object, e As EventArgs) Handles pctbox1.MouseHover
        pctbox1.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub pctbox1_MouseLeave(sender As Object, e As EventArgs) Handles pctbox1.MouseLeave
        pctbox1.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub pctbox2_MouseHover(sender As Object, e As EventArgs) Handles pctbox2.MouseHover
        pctbox2.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub pctbox2_MouseLeave(sender As Object, e As EventArgs) Handles pctbox2.MouseLeave
        pctbox2.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub pctbox3_MouseHover(sender As Object, e As EventArgs) Handles pctbox3.MouseHover
        pctbox3.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub pctbox3_MouseLeave(sender As Object, e As EventArgs) Handles pctbox3.MouseLeave
        pctbox3.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = Color.SpringGreen
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(192, 255, 192)
    End Sub

    Private Sub frnclient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dia As DialogResult
        dia = MessageBox.Show("Voulez-vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo)

        If dia = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub



    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frnhistoriquecommandeclient.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub DGVClient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClient.CellContentClick

    End Sub

    Private Sub DGVClient_SelectionChanged(sender As Object, e As EventArgs) Handles DGVClient.SelectionChanged
        marque1 = DGVClient.Rows(DGVClient.CurrentRow.Index).Cells(0).Value
    End Sub
End Class
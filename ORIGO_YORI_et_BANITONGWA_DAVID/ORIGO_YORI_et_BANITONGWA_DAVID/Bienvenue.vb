Imports System.Data.OleDb

Public Class frnbienvenue

    Public idclient1 As String
    Public nomclient1 As String
    Dim logrd As OleDbDataReader

    Private Sub txtemailconnexion_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub frnbienvenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb")
        connect.Open()
        txtemailconnexion.Clear()
        txtmotdepasseconnexion.Clear()
        lblbienvenue.Text = "3 essaie"
    End Sub

    Private Sub linkbienvenue_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkbienvenue.LinkClicked
        frncreationcompte.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblbienvenue.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frnbienvenue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dia As DialogResult
        dia = MessageBox.Show("Voulez-vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo)

        If dia = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        If txtemailconnexion.Text = "" Or txtmotdepasseconnexion.Text = "" Then
            MsgBox("Champ non saisie", MsgBoxStyle.Information, "Connexion")
        Else
            Static compt As Integer = 2
            lblbienvenue.Text = compt & " essaie"

            Dim chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            Dim connect As New OleDbConnection(chemin)

            If (compt = 0) Then
                MsgBox("Le nombre d'essaie est epuisé", MsgBoxStyle.Information, "Connexion")
                Me.Close()
            Else
                If connect.State = ConnectionState.Closed Then
                    connect.ConnectionString = chemin
                    connect.Open()
                End If

                Dim logincmd As OleDbCommand = New OleDbCommand("SELECT * FROM Client WHERE [EmailClient] = '" & txtemailconnexion.Text.Trim & "' AND [MotdepasseClient] = '" & txtmotdepasseconnexion.Text.Trim & "'", connect)
                Dim logrd As OleDbDataReader = logincmd.ExecuteReader()

                If (logrd.Read()) Then
                    idclient1 = logrd.GetValue(0)
                    nomclient1 = logrd.GetValue(1) + " " + logrd.GetValue(2)
                    MsgBox("Connexion reussie", MsgBoxStyle.Information, "Connexion")
                    frnclient.Show()
                    Me.Hide()
                    connect.Close()
                    compt = 3
                Else
                    compt -= 1
                    MsgBox("Email ou Mot de passe Incorrect", MsgBoxStyle.Exclamation, "Connexion")
                End If

            End If

        End If
    End Sub

    Private Sub BunifuPictureBox3_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox3.Click
        frnconnexionadmin.Show()
        Me.Hide()
    End Sub
End Class

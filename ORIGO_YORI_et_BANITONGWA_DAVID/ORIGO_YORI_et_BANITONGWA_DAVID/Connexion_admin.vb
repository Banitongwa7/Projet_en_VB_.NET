Imports System.Data.OleDb
Public Class frnconnexionadmin
    Dim connect As New OleDbConnection
    Public usern As String


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frnbienvenue.Show()
        Me.Hide()
    End Sub

    Private Sub frnconnexionadmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dia As DialogResult
        dia = MessageBox.Show("Voulez-vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo)

        If dia = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub frnconnexionadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"

        connect.Open()

        Dim logincmd As OleDbCommand = New OleDbCommand("select * from Admin where [UsernameAdmin] = '" & txtusernameadmin.Text & "' and [MotdepasseAdmin] = '" & txtmotdepasseadmin.Text & "'", connect)
        Dim logrd As OleDbDataReader = logincmd.ExecuteReader()

        If (logrd.Read() = True) Then
            usern = txtusernameadmin.Text
            MsgBox("Connexion reussie", MsgBoxStyle.OkOnly, "Connexion")
            frnsociete.Show()
            Me.Hide()
        Else
            MsgBox("Username ou Mot de passe Incorrect", MsgBoxStyle.Critical, "Connexion")
        End If

        connect.Close()
    End Sub
End Class
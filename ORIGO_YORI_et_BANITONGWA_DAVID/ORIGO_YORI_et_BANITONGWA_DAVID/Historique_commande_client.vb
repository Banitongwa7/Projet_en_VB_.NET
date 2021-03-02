Imports System.Data.OleDb
Public Class frnhistoriquecommandeclient
    Dim connect As New OleDbConnection
    Dim rd As OleDbDataReader
    Public chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frnclient.Show()
        Me.Hide()
    End Sub

    Private Sub frnhistoriquecommandeclient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = chemin
            connect.Open()
        End If
        lister_demande_commande()
    End Sub


    Public Sub lister_demande_commande()
        DGVCO.Rows.Clear()
        Dim command1 As String


        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = chemin
            connect.Open()
        End If

        command1 = "select [IDClient] , [IDVoiture] , [EtatCommande] , [QuantiteCommande] , [DateCommande] from Commande where [IDClient] = '" & frnbienvenue.idclient1 & "'"


        Dim cmd1 As New OleDbCommand(command1, connect)

        rd = cmd1.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read()
                DGVCO.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
            Loop

        End If
        connect.Close()
    End Sub

    Private Sub frnhistoriquecommandeclient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dia As DialogResult
        dia = MessageBox.Show("Voulez-vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo)

        If dia = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class
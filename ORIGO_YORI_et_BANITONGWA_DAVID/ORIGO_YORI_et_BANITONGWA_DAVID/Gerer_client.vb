Imports System.Data.OleDb
Public Class frngererclient
    Dim connect As New OleDbConnection
    Dim rd As OleDbDataReader
    Private Sub frngererclient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dia As DialogResult
        dia = MessageBox.Show("Voulez-vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo)

        If dia = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub frngererclient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
            lister()
        End If
    End Sub

    Sub lister()
        DGVGEST.Rows.Clear()
        Dim command As String
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        command = "select [IDClient] , [NomClient] , [PrenomClient] , [EmailClient] , [TelephoneClient] from Client"
        Dim cmd As New OleDbCommand(command, connect)
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read
                DGVGEST.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
            Loop
        End If

        rd.Close()
        connect.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frnsociete.Show()
        Me.Hide()
    End Sub
End Class
Imports System.Data.OleDb

Public Class frncreationcompte
    Dim connect As New OleDbConnection
    Dim chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
    Dim rd As OleDbDataReader


    Private Sub frncreationcompte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
        Dim connect As New OleDbConnection(chemin)
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = chemin
            connect.Open()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frnbienvenue.Show()
        Me.Hide()
    End Sub

    Private Sub frncreationcompte_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dia As DialogResult
        dia = MessageBox.Show("Voulez-vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo)

        If dia = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub


    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim command As String

        Dim chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
        Dim connect As New OleDbConnection(chemin)

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = chemin
            connect.Open()
        End If

        command = "INSERT INTO Client ([NomClient],[PrenomClient],[EmailClient],[TelephoneClient],[MotdepasseClient]) VALUES ('" & txtnomcreation.Text.Trim & "','" & txtprenomcreation.Text.Trim & "',' " & txtemailcreation.Text.Trim & " ','" & txttelephonecreation.Text.Trim & "',' " & txtmotdepassecreation.Text.Trim & " ')"


        Dim cmd As New OleDbCommand(command, connect)
        cmd.Parameters.Add(New OleDbParameter("NomClient", CType(txtnomcreation.Text.Trim, String)))
        cmd.Parameters.Add(New OleDbParameter("PrenomClient", CType(txtprenomcreation.Text.Trim, String)))
        cmd.Parameters.Add(New OleDbParameter("EmailClient", CType(txtemailcreation.Text.Trim, String)))
        cmd.Parameters.Add(New OleDbParameter("TelephoneClient", CType(txttelephonecreation.Text.Trim, String)))
        cmd.Parameters.Add(New OleDbParameter("MotdepasseClient", CType(txtmotdepassecreation.Text.Trim, String)))
        MsgBox("Enregistrement reussi", MsgBoxStyle.Information, "Inscription")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connect.Close()
            txtnomcreation.Clear()
            txtprenomcreation.Clear()
            txtmotdepassecreation.Clear()
            txtemailcreation.Clear()
            txttelephonecreation.Clear()
            txtconfirmermotdepasse.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
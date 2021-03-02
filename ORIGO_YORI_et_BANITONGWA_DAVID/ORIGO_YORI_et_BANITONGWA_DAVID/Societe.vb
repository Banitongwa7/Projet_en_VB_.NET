Imports System.Data.OleDb
Public Class frnsociete
    Dim connect As New OleDbConnection
    Dim rd As OleDbDataReader
    Private Sub frnsociete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbladminsociete.Text = frnconnexionadmin.usern
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
        End If
        cboetatajout.Items.Add("Louer")
        cboetatajout.Items.Add("Disponible")
        connect.Close()
        lister()
    End Sub

    Sub lister()
        DGVSociete.Rows.Clear()
        Dim command As String
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
            connect.Open()
        End If
        command = "select * from Voiture"
        Dim cmd As New OleDbCommand(command, connect)
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read
                DGVSociete.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
            Loop
        End If

        rd.Close()
        connect.Close()
    End Sub

    Private Sub DeconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeconnexionToolStripMenuItem.Click
        frnconnexionadmin.Show()
        Me.Hide()
    End Sub

    Private Sub DGVSociete_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub LocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationToolStripMenuItem.Click
        frnlocationsociete.Show()
        Me.Hide()
    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientToolStripMenuItem.Click
        frngererclient.Show()
        Me.Hide()
    End Sub

    Private Sub frnsociete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If
        command = " DELETE from Voiture where [Marque] = '" & txtmarqueajout.Text & "'"

        Dim cmd As New OleDbCommand(command, connect)
        MsgBox("Suppression Réussie", MsgBoxStyle.Information, "Supprimer une autre voiture")
        Dim r As Integer

        r = cmd.ExecuteNonQuery()

        If (r <> 0) Then
            Try

                cmd.Dispose()
                connect.Close()
                txtmarqueajout.Clear()
                Txtprixdelocation.Clear()
                TxtVitesse.Clear()
                TxtDescription.Clear()
                TxtQuantité.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        lister()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Dim command As String

        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"

        connect.Open()
        command = "INSERT  into Voiture (  [Marque] , [Prixdelocation] , [Vitesse] , [Etatdedisponibilite] , [Description] , [Quantite]) values ( '" & txtmarqueajout.Text & "','" & Txtprixdelocation.Text & "','" & TxtVitesse.Text & "','" & cboetatajout.SelectedItem.ToString & "','" & TxtDescription.Text & "','" & TxtQuantité.Text & "')"

        Dim cmd As New OleDbCommand(command, connect)
        cmd.Parameters.Add(New OleDbParameter("Marque", CType(txtmarqueajout.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Prixdelocation", CType(Txtprixdelocation.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Vitesse", CType(TxtVitesse.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Etatdedisponibilite", CType(cboetatajout.SelectedItem.ToString, String)))
        cmd.Parameters.Add(New OleDbParameter("Description", CType(TxtDescription.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Quantite", CType(TxtQuantité.Text, Integer)))

        MsgBox("Enregistrement reussi", MsgBoxStyle.Information, "Ajout avec succès")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connect.Close()
            txtmarqueajout.Clear()
            Txtprixdelocation.Clear()
            TxtVitesse.Clear()
            TxtDescription.Clear()
            TxtQuantité.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        txtmarqueajout.Clear()
        Txtprixdelocation.Clear()
        TxtVitesse.Clear()
        TxtDescription.Clear()
        TxtQuantité.Clear()

        lister()
    End Sub

    Private Sub DGVSociete_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSociete.CellContentClick

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        txtmarqueajout.Clear()
        Txtprixdelocation.Clear()
        TxtVitesse.Clear()
        TxtDescription.Clear()
        TxtQuantité.Clear()
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        Dim command As String

        connect.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"

        connect.Open()
        command = " UPDATE Voiture set [Marque] = '" & txtmarqueajout.Text & "', [Prixdelocation] = '" & Txtprixdelocation.Text & "', [Vitesse] = '" & TxtVitesse.Text & "', [Etatdedisponibilite] = '" & cboetatajout.SelectedItem.ToString & "', [Description] = '" & TxtDescription.Text & "', [Quantite] = '" & TxtQuantité.Text & "' where [Marque] = '" & txtmarqueajout.Text & "'"
        Dim cmd As New OleDbCommand(command, connect)
        MsgBox("Modification Réussie", MsgBoxStyle.Information, "Modification d'une autre voiture")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connect.Close()
            txtmarqueajout.Clear()
            Txtprixdelocation.Clear()
            TxtVitesse.Clear()
            TxtDescription.Clear()
            TxtQuantité.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtmarqueajout.Clear()
        Txtprixdelocation.Clear()
        TxtVitesse.Clear()
        TxtDescription.Clear()
        TxtQuantité.Clear()

        lister()
    End Sub

    Private Sub DGVSociete_SelectionChanged(sender As Object, e As EventArgs) Handles DGVSociete.SelectionChanged
        txtmarqueajout.Text = DGVSociete.Rows(DGVSociete.CurrentRow.Index).Cells(1).Value
        Txtprixdelocation.Text = DGVSociete.Rows(DGVSociete.CurrentRow.Index).Cells(2).Value
        TxtVitesse.Text = DGVSociete.Rows(DGVSociete.CurrentRow.Index).Cells(3).Value
        cboetatajout.Text = DGVSociete.Rows(DGVSociete.CurrentRow.Index).Cells(4).Value
        TxtDescription.Text = DGVSociete.Rows(DGVSociete.CurrentRow.Index).Cells(5).Value
        TxtQuantité.Text = DGVSociete.Rows(DGVSociete.CurrentRow.Index).Cells(6).Value
    End Sub
End Class
Imports System.Data.OleDb
Public Class frnlocationsociete
    Dim connect As New OleDbConnection
    Dim rd As OleDbDataReader
    Dim idclient2 As String
    Dim idvoiture2 As String
    Dim idc As String
    Dim nbrv As Integer
    Dim etat1 As String
    Dim chemin As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\david\source\repos\ORIGO_YORI_et_BANITONGWA_DAVID\ORIGO_YORI_et_BANITONGWA_DAVID\BD_Societe_MB.accdb"

    Private Sub frnlocationsociete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = chemin
            connect.Open()
        End If

        connect.Close()
        lister()
    End Sub


    Sub lister()
        DGVLOC.Rows.Clear()
        Dim command As String
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = chemin
            connect.Open()
        End If
        command = "select * from Commande"
        Dim cmd As New OleDbCommand(command, connect)
        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read
                DGVLOC.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
            Loop
        End If

        rd.Close()
        connect.Close()
    End Sub

    Private Sub frnlocationsociete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dia As DialogResult
        dia = MessageBox.Show("Voulez-vous fermer l'application ?", "Quitter", MessageBoxButtons.YesNo)

        If dia = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub DGVLOC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub cmdrejetter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frnsociete.Show()
        Me.Hide()
    End Sub

    Private Sub DGVLOC_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLOC.CellContentClick

    End Sub

    Private Sub DGVLOC_SelectionChanged(sender As Object, e As EventArgs) Handles DGVLOC.SelectionChanged
        idc = DGVLOC.Rows(DGVLOC.CurrentRow.Index).Cells(0).Value
        idclient2 = DGVLOC.Rows(DGVLOC.CurrentRow.Index).Cells(1).Value
        idvoiture2 = DGVLOC.Rows(DGVLOC.CurrentRow.Index).Cells(2).Value
        etat1 = DGVLOC.Rows(DGVLOC.CurrentRow.Index).Cells(3).Value
        nbrv = DGVLOC.Rows(DGVLOC.CurrentRow.Index).Cells(4).Value
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Dim command As String
        Dim mt As String = "Commande rejetter"
        Dim test As Integer

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = chemin
            connect.Open()
        End If

        test = mt.CompareTo(etat1)

        If (test) Then
            command = " UPDATE Commande set [EtatCommande] = '" & mt & "' where [IDCommande] = " & idc & " and [IDClient] = '" & idclient2 & "' and [IDVoiture] = '" & idvoiture2 & "'"
            Dim cmd As New OleDbCommand(command, connect)

            MsgBox("Operation reussie", MsgBoxStyle.Information, "Gestion commande")

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                connect.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            lister()
        Else
            MsgBox("La commande est déjà rejetter", MsgBoxStyle.Information, "Commande")
        End If

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Dim command As String
        Dim command1 As String
        Dim command2 As String
        Dim qtee1 As Integer
        Dim soust As Integer
        Dim nbrv1 As Integer
        Dim test As Integer
        Dim mt As String = "Commande valider"

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = chemin
            connect.Open()
        End If

        test = mt.CompareTo(etat1)

        If test Then
            nbrv1 = CInt(nbrv)

            command1 = "select * from Voiture where [IDVoiture]=" & idvoiture2 & ";"

            Dim cmd2 As New OleDbCommand(command1, connect)
            rd = cmd2.ExecuteReader

            If rd.Read() Then
                qtee1 = rd.GetValue(6)
            End If

            If qtee1 = 0 Then
                MsgBox("Le stock de la marque est epuisé", MsgBoxStyle.Information, "Commande")
            ElseIf qtee1 < nbrv1 Then
                MsgBox("La quantite commandé est superieur au stock disponible", MsgBoxStyle.Information, "Commande")
            Else
                command = " UPDATE Commande set [EtatCommande] = '" & mt & "' where [IDCommande] = " & idc & " and [IDClient] = '" & idclient2 & "' and [IDVoiture] = '" & idvoiture2 & "'"
                Dim cmd As New OleDbCommand(command, connect)

                MsgBox("Operation reussie", MsgBoxStyle.Information, "Gestion commande")

                soust = qtee1 - nbrv1

                command2 = "update Voiture set [Quantite]=" & soust & " where  [IDVoiture]=" & idvoiture2 & ";"
                Dim cmd3 As New OleDbCommand(command2, connect)

                Try
                    cmd.ExecuteNonQuery()
                    cmd3.ExecuteNonQuery()
                    cmd3.Dispose()
                    cmd.Dispose()
                    connect.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                lister()
            End If
        Else
            MsgBox("La commande est déjà valider", MsgBoxStyle.Information, "Commande")
        End If
    End Sub
End Class
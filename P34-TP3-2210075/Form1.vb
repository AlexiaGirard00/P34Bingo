Public Class Form1

    Dim lstCartesBingo As New List(Of Carte)

    Dim lstToutesBoules As New List(Of Integer)

    Dim lstBouleOut As New List(Of Integer)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelCarteBingo.Visible = False
        PanelBoulier.Visible = False
    End Sub
    Public Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click

        btnJouer.Enabled = False

        lstCartesBingo.Clear()
        lstBouleOut.Clear()
        txtBouleOut.Text = ""


        Dim nouvPartie As Boolean = True

        While nouvPartie = True
            If cbMode.SelectedIndex < 0 Then
                MessageBox.Show("Veuillez choisir le mode.")
                btnJouer.Enabled = True
                Return
            End If

            PanelCarteBingo.Visible = True
            PanelBoulier.Visible = True

            Dim nbJoueur = numNbJoueur.Value

            For i As Integer = 1 To nbJoueur
                Dim newCarte As New Carte()
                newCarte.MdiParent = Me
                PanelCarteBingo.Controls.Add(newCarte)
                newCarte.Show()
                newCarte.Nom = i.ToString()
                newCarte.lblNomCarte.Text = newCarte.Nom
                lstCartesBingo.Add(newCarte)
            Next


            lstCartesBingo.First.Show()

            For Each ctrl As Control In gbInitierBingo.Controls
                ctrl.Enabled = False
            Next

            Dim nombre As Integer
            Dim valide As Boolean

            If cbMode.SelectedIndex = 0 Then
                Do While valide = False
                    nombre = SortirBoule()
                    For Each carte As Carte In lstCartesBingo
                        carte.CheckCarte(nombre)

                        Application.DoEvents()

                        Threading.Thread.Sleep(50)

                        If carte.ModeColonne() = True Then
                            ModeTrue(carte)
                            valide = True
                        ElseIf carte.ModeLigne() = True Then
                            ModeTrue(carte)
                            valide = True
                        ElseIf carte.ModeDiago() = True Then
                            ModeTrue(carte)
                            valide = True
                        End If
                    Next
                Loop
            End If

            If cbMode.SelectedIndex = 1 Then
                Do While valide = False
                    nombre = SortirBoule()
                    For Each carte As Carte In lstCartesBingo
                        carte.CheckCarte(nombre)

                        Application.DoEvents()

                        Threading.Thread.Sleep(50)

                        If carte.ModeCartePleine() = True Then
                            ModeTrue(carte)
                            valide = True
                        End If
                    Next
                Loop
            End If

            If cbMode.SelectedIndex = 2 Then
                Do While valide = False
                    nombre = SortirBoule()
                    For Each carte As Carte In lstCartesBingo
                        carte.CheckCarte(nombre)

                        Application.DoEvents()

                        Threading.Thread.Sleep(50)

                        If carte.Mode4Coins() = True Then
                            ModeTrue(carte)
                            valide = True
                        End If
                    Next
                Loop
            End If

            If cbMode.SelectedIndex = 3 Then
                Do While valide = False
                    nombre = SortirBoule()
                    For Each carte As Carte In lstCartesBingo
                        carte.CheckCarte(nombre)

                        Application.DoEvents()

                        Threading.Thread.Sleep(50)

                        If carte.ModeX() = True Then
                            ModeTrue(carte)
                            valide = True
                        End If
                    Next
                Loop
            End If

            If cbMode.SelectedIndex = 4 Then
                Do While valide = False
                    nombre = SortirBoule()
                    For Each carte As Carte In lstCartesBingo
                        carte.CheckCarte(nombre)

                        Application.DoEvents()

                        Threading.Thread.Sleep(50)

                        If carte.ModeCroix() = True Then
                            ModeTrue(carte)
                            valide = True
                        End If
                    Next
                Loop
            End If

            Dim dr As DialogResult
            dr = MessageBox.Show("Une autre partie ?", "", MessageBoxButtons.YesNo)

            If dr = DialogResult.No Then
                Exit While
            ElseIf dr = DialogResult.Yes Then

                For Each ctrl As Control In gbInitierBingo.Controls
                    ctrl.Enabled = True
                Next

                For Each carte1 As Carte In lstCartesBingo
                    PanelCarteBingo.Controls.Remove(carte1)
                    carte1.Dispose()
                Next

                PanelCarteBingo.Visible = False
                PanelBoulier.Visible = False

                Return
            End If

        End While

        Result()

    End Sub


    Private Function RandomBoule() As Integer
        Dim rnd = New Random()
        Dim rndBoule As Integer

        While True
            rndBoule = rnd.Next(1, 76)
            If lstBouleOut.Contains(rndBoule) Then
                rndBoule = rnd.Next(1, 76)
            Else
                lstBouleOut.Add(rndBoule)
                lstToutesBoules.Add(rndBoule)
                Exit While
            End If
        End While

        Return rndBoule

    End Function

    Private Function SortirBoule() As Integer
        Dim nb As Integer = RandomBoule()
        lblNumBoule.Text = nb.ToString()
        txtBouleOut.Text += nb.ToString() + " "
        Return nb
    End Function

    Private Sub ModeTrue(carte As Carte)
        Dim strNom As String = ""

        strNom = carte.Nom + " " + carte.ModeWin + vbCrLf + "Nombre de boules : " + lstBouleOut.Count.ToString()
        MessageBox.Show(strNom)

        For Each carte1 As Carte In lstCartesBingo
            PanelCarteBingo.Controls.Remove(carte1)
        Next

        PanelCarteBingo.Controls.Add(carte)
        carte.Show()
    End Sub

    Private Sub Result()
        Dim lstBouleString As New List(Of String)

        For Each boule In lstToutesBoules
            lstBouleString.Add(boule.ToString())
        Next

        Dim groups = lstBouleString.GroupBy(Function(value) value)

        Dim txtResult As New TextBox()
        txtResult.Multiline = True
        txtResult.ScrollBars = ScrollBars.Vertical
        txtResult.Dock = DockStyle.Fill

        For Each boule In groups
            txtResult.Text += boule(0) & " récurrence: " & boule.Count.ToString() + vbCrLf
        Next

        For Each carte1 As Carte In lstCartesBingo
            PanelCarteBingo.Controls.Remove(carte1)
        Next

        PanelCarteBingo.Controls.Add(txtResult)
        txtResult.Show()
    End Sub
End Class

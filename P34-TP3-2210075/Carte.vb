Public Class Carte

    Dim lstNbUtiliser As New List(Of Integer)
    Private Property _Nom As String
    Public Property Nom As String

        Get
            Return _Nom
        End Get
        Set(value As String)
            _Nom = "Joueur" + " " + value
        End Set

    End Property

    Public Property ModeWin As String
    Public Property LigneWin As String
    Public Property ColonneWin As String
    Public Property DiagoWin As String


    Private Sub Carte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblN3.BackColor = Color.FromArgb(94, 178, 133)

        Dim lstColumnB As New List(Of Integer)()
        Dim lstColumnI As New List(Of Integer)()
        Dim lstColumnN As New List(Of Integer)()
        Dim lstColumnG As New List(Of Integer)()
        Dim lstColumnO As New List(Of Integer)()



        For b As Integer = 1 To 15
            lstColumnB.Add(b)
        Next

        For i As Integer = 16 To 30
            lstColumnI.Add(i)
        Next

        For n As Integer = 31 To 45
            lstColumnN.Add(n)
        Next

        For g As Integer = 46 To 60
            lstColumnG.Add(g)
        Next

        For o As Integer = 61 To 75
            lstColumnO.Add(o)
        Next

        AjouterNombres("lblB", lstColumnB)
        AjouterNombres("lblI", lstColumnI)
        AjouterNombres("lblN", lstColumnN)
        AjouterNombres("lblG", lstColumnG)
        AjouterNombres("lblO", lstColumnO)


    End Sub

    Private Sub AjouterNombres(lblName As String, lst As List(Of Integer))

        Dim rnd As New Random()
        Dim nb As Integer

        For Each ctrl As Label In gbLblBingo.Controls
            If ctrl.Name.Substring(0, 4) = lblName Then
                If ctrl.Name <> "lblN3" Then
                    While True
                        nb = rnd.Next(lst.First, lst.Last)
                        ctrl.Text = nb
                        If lstNbUtiliser.Contains(nb) Then
                            nb = rnd.Next(lst.First, lst.Last)
                            ctrl.Text = nb
                        Else
                            lstNbUtiliser.Add(nb)
                            Exit While
                        End If
                    End While
                Else
                    ctrl.Text = "FREE"
                End If
            End If
        Next
    End Sub

    Public Sub CheckCarte(numeroBoule As Integer)

        For Each lbl In gbLblBingo.Controls
            If lbl.Text = numeroBoule.ToString() Then
                lbl.BackColor = Color.FromArgb(94, 178, 133)
            End If
        Next
    End Sub

    Public Function ModeLigne() As Boolean
        Dim lstLigne1 As New List(Of Label)
        Dim lstLigne2 As New List(Of Label)
        Dim lstLigne3 As New List(Of Label)
        Dim lstLigne4 As New List(Of Label)
        Dim lstLigne5 As New List(Of Label)

        For Each lbl In gbLblBingo.Controls
            If lbl.Name.Substring(4) = "1" Then
                lstLigne1.Add(lbl)
            ElseIf lbl.Name.Substring(4) = "2" Then
                lstLigne2.Add(lbl)
            ElseIf lbl.Name.Substring(4) = "3" Then
                lstLigne3.Add(lbl)
            ElseIf lbl.Name.Substring(4) = "4" Then
                lstLigne4.Add(lbl)
            Else
                lstLigne5.Add(lbl)
            End If
        Next


        If CheckLigne(lstLigne1) Then
            ModeWin = "ligne 1 !"
            Return True
        ElseIf CheckLigne(lstLigne2) Then
            ModeWin = "ligne 2 !"
            Return True
        ElseIf CheckLigne(lstLigne3) Then
            ModeWin = "ligne 3 !"
            Return True
        ElseIf CheckLigne(lstLigne4) Then
            ModeWin = "ligne 4 !"
            Return True
        ElseIf CheckLigne(lstLigne5) Then
            ModeWin = "ligne 5 !"
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ModeColonne() As Boolean
        Dim lstColonneB As New List(Of Label)
        Dim lstColonneI As New List(Of Label)
        Dim lstColonneN As New List(Of Label)
        Dim lstColonneG As New List(Of Label)
        Dim lstColonneO As New List(Of Label)

        For Each lbl In gbLblBingo.Controls
            If lbl.Name.Substring(3, 1) = "B" Then
                lstColonneB.Add(lbl)
            ElseIf lbl.Name.Substring(3, 1) = "I" Then
                lstColonneI.Add(lbl)
            ElseIf lbl.Name.Substring(3, 1) = "N" Then
                lstColonneN.Add(lbl)
            ElseIf lbl.Name.Substring(3, 1) = "G" Then
                lstColonneG.Add(lbl)
            Else
                lstColonneO.Add(lbl)
            End If
        Next

        If CheckLigne(lstColonneB) Then
            ModeWin = "colonne B !"
            Return True
        ElseIf CheckLigne(lstColonneI) Then
            ModeWin = "colonne I !"
            Return True
        ElseIf CheckLigne(lstColonneN) Then
            ModeWin = "colonne N !"
            Return True
        ElseIf CheckLigne(lstColonneG) Then
            ModeWin = "colonne G !"
            Return True
        ElseIf CheckLigne(lstColonneO) Then
            ModeWin = "colonne O !"
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ModeDiago() As Boolean

        Dim lstDiagoGaucheDroite As New List(Of Label)({lblB1, lblI2, lblN3, lblG4, lblO5})
        Dim lstDiagoDroiteGauche As New List(Of Label)({lblB5, lblI4, lblN3, lblG2, lblO1})

        If CheckLigne(lstDiagoGaucheDroite) Then
            ModeWin = "diagonale !"
            Return True
        ElseIf CheckLigne(lstDiagoDroiteGauche) Then
            ModeWin = "diagonale !"
            Return True
        Else
            Return False
        End If


    End Function

    Public Function ModeCartePleine() As Boolean

        Dim countlbl As Integer = 0

        For Each lbl As Label In gbLblBingo.Controls
            If lbl.BackColor = Color.FromArgb(94, 178, 133) Then
                countlbl += 1
                If countlbl = 25 Then
                    ModeWin = "pleine !"
                    Return True
                End If
            End If
        Next

        Return False

    End Function

    Public Function Mode4Coins() As Boolean

        If lblB1.BackColor = Color.FromArgb(94, 178, 133) And lblB5.BackColor = Color.FromArgb(94, 178, 133) And
            lblO1.BackColor = Color.FromArgb(94, 178, 133) And lblO5.BackColor = Color.FromArgb(94, 178, 133) Then
            ModeWin = "quatre coins !"
            Return True
        End If

        Return False
    End Function

    Public Function ModeX() As Boolean

        Dim lstDiagoGaucheDroite As New List(Of Label)({lblB1, lblI2, lblN3, lblG4, lblO5})
        Dim lstDiagoDroiteGauche As New List(Of Label)({lblB5, lblI4, lblN3, lblG2, lblO1})
        If CheckLigne(lstDiagoDroiteGauche) And CheckLigne(lstDiagoGaucheDroite) Then
            ModeWin = "X !"
            Return True
        End If

        Return False
    End Function

    Public Function ModeCroix() As Boolean
        Dim lstlabelN As New List(Of Label)
        Dim lstLabel3 As New List(Of Label)

        For Each lbl As Label In gbLblBingo.Controls
            If lbl.Name.Substring(0, 4) = "lblN" Then
                lstlabelN.Add(lbl)
            End If

            If lbl.Name.Substring(4) = "3" Then
                lstLabel3.Add(lbl)
            End If
        Next

        If CheckLigne(lstlabelN) And CheckLigne(lstLabel3) Then
            ModeWin = " croix !"
            Return True
        Else
            Return False
        End If

    End Function

    Private Function CheckLigne(lst As List(Of Label)) As Boolean

        Dim count As Integer = 0

        For Each lbl In lst
            If lbl.BackColor = Color.FromArgb(94, 178, 133) Then
                count += 1
            End If
        Next

        If count = 5 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
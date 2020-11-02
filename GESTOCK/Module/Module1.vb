Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Module Module1
    Public chemin As String = String.Format("Data Source=WHANNOU;Initial Catalog=GESTOCK;Integrated Security=True", Application.StartupPath)
    Public cnx As New SqlConnection
    Public cmdcombo As SqlCommand = cnx.CreateCommand
    Public myreader As SqlDataReader
    Public valG As SqlDataReader
    Public dr As SqlDataReader
    Public cmd As SqlCommand
    Public strSql As String
    Public test As Integer
    Public ObjetDataTable As DataTable
    Public ObjetDataRow As DataRow
    Public RowNumber As Integer
    Public ObjetCommandBuilder As SqlCommandBuilder
    Public ObjetCommand As SqlCommand
    Public recuperateur_de_statut As String
    Public utiDataSet As New DataSet() 'Attention au New
    Public utiDataAdapter As SqlDataAdapter
    Public ListeProduitDataAdapter As SqlDataAdapter
    Public ObjetConnection As SqlConnection
    Public ListeProduitDataSet As New DataSet()
    Public tblActifUser As DataTable = New DataTable()
    Public MonDataAdapteur As SqlDataAdapter
    Public MonDataSet As New DataSet()
    Public MonDataAdapteur1 As SqlDataAdapter
    Public MonDataSet1 As New DataSet()
    Public MonDataAdapteur2 As SqlDataAdapter
    Public MonDataSet2 As New DataSet()
    Public MonDataAdapteur3 As SqlDataAdapter
    Public MonDataSet3 As New DataSet()
    Public MonDataAdapteur4 As SqlDataAdapter
    Public MonDataSet4 As New DataSet()
    Public MonDataAdapteur5 As SqlDataAdapter
    Public MonDataSet5 As New DataSet()
    Dim codeCollege As String
    Public CptLigne As Integer


    ' Permet de se connecter à une base de données
    '"" source est la chaîne de connexion

    Public Sub se_connecter(ByVal source As String)
        Try
            cnx.ConnectionString = source
            cnx.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'déclaration des différents messages
    Public EN As String = "Enregistrement effectué avec succès"
    Public MO As String = "Modification effectuée avec succès"
    Public SU As String = "Suppression effectuée avec succès"
    Public MI As String = "Mise à jour éffectuée avec succès"

    'Permet de remplir un dataGridView
    Public Sub remplirGridvide(ByVal LeDataSet As DataSet, ByVal LeDataAdapteur As SqlDataAdapter, ByVal LaTable As String, ByVal LeDataGrid As DataGridView, ByVal LaRequête As String)
        Try
            LeDataSet.Clear()
            strSql = LaRequête
            cnx = New SqlConnection()
            cnx.ConnectionString = chemin
            cnx.Open()
            cmd = New SqlCommand(strSql)
            LeDataAdapteur = New SqlDataAdapter(cmd)
            cmd.Connection() = cnx
            LeDataAdapteur.Fill(LeDataSet, LaTable)
            ObjetDataTable = LeDataSet.Tables(LaTable)
            LeDataGrid.DataSource = ObjetDataTable
        Catch ex As Exception

        End Try
    End Sub

    'permet de charger les informations d'un attribut dans un combo
    ' lachaîne est la requête et nomcombo le nom du combo
    Public Sub Combo(ByVal Lachaîne As String, ByVal NomCombo As ComboBox)
        Try
            Dim Machaîne As String
            cnx = New SqlConnection(chemin)
            cmd = cnx.CreateCommand
            cnx.Open()
            Machaîne = "" & Lachaîne & ""
            cmd.CommandType = CommandType.Text
            cmd.CommandText = Machaîne
            myreader = cmd.ExecuteReader
            NomCombo.Items.Clear()
            While myreader.Read
                NomCombo.Items.Add(myreader(0))
            End While
            myreader.Close()
        Catch ex As Exception

        End Try
    End Sub

    'Permet d'exécuter des requêtes(faire des enregistrements, modifications et des suppressions= avec la gestion des msgbox
    '"" req est la requête
    '"" msg est le msg
    Public Sub instruction(ByVal req As String, Optional ByVal msg As String = "")
        ObjetCommand = cnx.CreateCommand
        Try
            ObjetCommand.CommandText = req
            ObjetCommand.ExecuteNonQuery()
            If msg <> "" Then
                MsgBox(msg)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub parcourir(ByVal req As String)
        Try
            cmd = cnx.CreateCommand
            cmd.CommandText = req
            ' ObjetCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Permet de gérer les problèmes liés aux apostrophes
    Public Function recup(ByVal Sstring As String) As String
        Try
            Sstring = Replace(Sstring, "'", Chr(180))
            Return Sstring
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    'Premet d'incrémenter avec précision du textbox
    '"" Table est le nom de la table dans la base de données
    '"" champ est le nomb du champ dans la base de données
    '"" text0 est le nom du textbox
    Public Sub incrémenter_numero(ByVal Table As String, ByVal Champ As String, ByVal text0 As System.Windows.Forms.TextBox)
        Try
            'dr.Close()
            cmd = cnx.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select top 1 " & Champ & " from " & Table & " order by " & Champ & " desc "
            myreader = cmd.ExecuteReader
            If myreader.Read Then
                If myreader.GetValue(0) >= 1000 Then
                    text0.Text = myreader.GetValue(0) + 1
                ElseIf myreader.GetValue(0) >= 100 Then
                    text0.Text = "0" & myreader.GetValue(0) + 1
                ElseIf myreader.GetValue(0) >= 10 Then
                    text0.Text = "0" & "0" & myreader.GetValue(0) + 1
                ElseIf myreader.GetValue(0) < 10 Then
                    text0.Text = "0" & "0" & "0" & myreader.GetValue(0) + 1
                End If
            Else
                text0.Text = "0" & "0" & "0" & 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myreader.Close()
    End Sub
    Public Function NumeroAutoFac(ByVal vTable As String, ByVal vChamp As String, Optional ByVal LeCaractere As String = "") As String

        Try
            Dim vnum As String
            Dim Mycom As SqlCommand = cnx.CreateCommand
            Mycom.CommandText = "select max(" & vChamp & ") as LeGrd from " & vTable
            Dim dr As SqlDataReader
            dr = Mycom.ExecuteReader
            If Not dr.Read Then
                vnum = 1
            Else
                If dr.IsDBNull(0) Then
                    vnum = 1
                Else
                    vnum = Val(Right(dr("LeGrd"), Len(dr("LeGrd")) - 3)) + 1
                End If
            End If
            If vnum < 10 Then
                NumeroAutoFac = LeCaractere & "000" & vnum
            Else
                If vnum < 100 Then
                    NumeroAutoFac = LeCaractere & "00" & vnum
                Else
                    If vnum < 1000 Then
                        NumeroAutoFac = LeCaractere & "0" & vnum
                    Else
                        NumeroAutoFac = LeCaractere & vnum
                    End If
                End If
            End If
            dr.Close()
        Catch ex As Exception

        End Try

    End Function
    Public Function Jinverse(ByVal LaDate As Date) As Date
        If LaDate.Day > 12 Then Jinverse = LaDate : Exit Function
        Jinverse = IIf(IsDate(LaDate.Month & "/" & LaDate.Day & "/" & LaDate.Year), CDate(LaDate.Month & "/" & LaDate.Day & "/" & LaDate.Year), LaDate)
    End Function

    Public Sub reader(ByVal reqs As String)
        Try
            cnx = New SqlConnection(chemin)
            Dim Mycom As SqlCommand = cnx.CreateCommand
            cnx.Open()
            Mycom.CommandText = reqs
            valG = Mycom.ExecuteReader
            If valG.Read Then
                If valG.IsDBNull(0) Then
                    test = -1
                Else
                    test = 1
                End If
            Else
                test = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Pour proposer une assistante d'aide de saisie à l'utilisateur 
    'Ce code charge les données dans l'autocompletecustomesource du contrôle 
    Public Sub LoardAutoCompletesource(ByVal DtbTable As DataTable, ByVal NameBox As TextBox, ByVal NomColonne As String)
        Try
            For i As Integer = 0 To DtbTable.Rows.Count - 1
                NameBox.AutoCompleteCustomSource.Add(DtbTable.Rows(i).Item(NomColonne).ToString)

            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Sub SaisirChiffre(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case e.KeyChar
            Case Is = "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Microsoft.VisualBasic.vbBack

            Case Else
                e.Handled = True
        End Select
    End Sub
    Public Sub SaisirToutSanEspace(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case e.KeyChar
            Case Is = "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", Microsoft.VisualBasic.vbBack
            Case Else
                e.Handled = True
        End Select
    End Sub


    ' Pour cyptage mot de passe
    Public Function CalculMD5Hash(ByVal FileContent As String) As String
        Dim arHash As Byte() = New MD5CryptoServiceProvider().ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(FileContent))
        Return ByteArrayToString(arHash)
    End Function

    Public Function ByteArrayToString(ByVal arrInput() As Byte) As String
        Dim i As Integer
        Dim sOutput As New StringBuilder(arrInput.Length)
        For i = 0 To arrInput.Length - 1
            sOutput.Append(arrInput(i).ToString("X2"))
        Next
        Return sOutput.ToString()
        'My.Settings.MaChaineDeBase
    End Function

End Module

﻿''' <summary>
''' Class de zone de point. Elle a pour but la création d'aire contenant plusieurs point dont la position est déterminé de manière aléatoire.
''' Cette classe nécessite le module algèbre, qui contient les fonction de génératino d'un point aléatoire et le calcul de la distance entre 2 points
''' 
''' </summary>
Public Class Well

    Private ID As String                'Numéro d'identification du puits
    Private WellCoord As New Point()    'Coordonnées du puit sur une plaque
    Private Largeur As Double           'largeur de la zone contenant les points 
    Private Longueur As Double          'longeur de la zone contenant les points
    Private DistanceMin As Double       'distance minimum séparant les points
    Private CountOfPoints As Double     'Nombre de point dans la zone

    Private MaxIteration As UInteger = 10000    'Nombre d'iération pour trouver les points
    Private PointsList As New List(Of Point)    'tableau de point contenant les points


    ''' <summary>
    ''' Tableau des point peuplant la zone
    ''' </summary>
    ''' <returns>Retourne un tableau du type arraylist</returns>
    Public Property _PointsList As List(Of Point)
        Get
            Return PointsList
        End Get
        Set(value As List(Of Point))
            PointsList = value
        End Set
    End Property

    ''' <summary>
    ''' largeur de la zone
    ''' </summary>
    ''' <returns>Retourne une valeur du type double</returns>
    Public Property _AreaWidth As Double
        Get
            Return Largeur
        End Get
        Set(value As Double)
            Largeur = value
        End Set
    End Property


    ''' <summary>
    ''' longueur de la zone
    ''' </summary>
    ''' <returns>Retourne une valeur du type double</returns>
    Public Property _AreaHeight As Double
        Get
            Return Longueur
        End Get
        Set(value As Double)
            Longueur = value
        End Set
    End Property


    ''' <summary>
    ''' Distance minimum entre chaque point
    ''' </summary>
    ''' <returns>Retourne une valeur de type double</returns>
    Public Property _Clearance As Double
        Get
            Return DistanceMin
        End Get
        Set(value As Double)
            DistanceMin = value
        End Set
    End Property

    ''' <summary>
    ''' nombre de point a trouver
    ''' </summary>
    ''' <returns>retourne une valeur du type double</returns>
    Public Property _CountOfPoints As Double
        Get
            Return CountOfPoints
        End Get
        Set(value As Double)
            CountOfPoints = value
        End Set
    End Property

    ''' <summary>
    ''' Maximum d'iteration pour trouver les points aléatoire
    ''' </summary>
    ''' <returns>le nombre maximum d'itération pour trouver les points aléatoire</returns>
    Public Property _MaxIteration As UInteger
        Get
            Return MaxIteration
        End Get
        Set(value As UInteger)
            MaxIteration = value
        End Set
    End Property

    ''' <summary>
    ''' Numéro d'identification du puit
    ''' </summary>
    ''' <returns></returns>
    Public Property _ID As String
        Get
            Return ID
        End Get
        Set(value As String)
            ID = value
        End Set
    End Property

    ''' <summary>
    ''' Coordonnées XY du point sur une plaque.
    ''' </summary>
    ''' <returns>Donnée du type point</returns>
    Public Property _WellCoord As Point
        Get
            Return WellCoord
        End Get
        Set(value As Point)
            WellCoord = value
        End Set
    End Property

    ''' <summary>
    ''' Contruction de la zone avec les paramètre par défaut : largeur 10, Longueur 10, Distance mini 1, nombre de point 1
    ''' </summary>
    Public Sub New()
        Largeur = 10
        Longueur = 10
        DistanceMin = 1
        CountOfPoints = 1
        WellCoord = New Point(1, 1)

    End Sub

    ''' <summary>
    ''' Construction de la zone avec les attributs données
    ''' </summary>
    ''' <param name="CoteA">largeur de la zone</param>
    ''' <param name="CoteB">Longueur de la zone</param>
    ''' <param name="Distance">Distance minimal entre les points</param>
    ''' <param name="Count">Nombre de point contenu dans la zone</param>
    Public Sub New(ByVal CoteA As Double, ByVal CoteB As Double, ByVal Distance As Double, ByVal Count As Double, ByVal X As Double, ByVal Y As Double)

        Largeur = CoteA
        Longueur = CoteB
        DistanceMin = Distance
        CountOfPoints = Count
        WellCoord.X = X
        WellCoord.Y = Y

    End Sub

    ''' <summary>
    ''' Génération des points dans la zone
    ''' </summary>
    Public Sub GeneratePoints()

        Dim Iteration As Integer = 0    'compteur d'itérations
        Dim Count As Integer = 0        'compteur de points trouvés
        Dim Flag As Boolean = False     'Indique si un point a été trouvé
        Dim Distance As Integer = 0     ' distance calculé entre 2 point
        Dim RndPoint As New Point()     'Point aléatoire 

        'Génération du premier point que l'on ajout au tableau de point aléatoire
        RndPoint = GenOnePoint(Largeur, Longueur)
        PointsList.Add(RndPoint)

        'Recherche d'un nombre de point aléatoire. S'arrête si il a a assés de points trouvés ou si la boucle a fait assés d'itération
        While (Count < CountOfPoints - 1) And (Iteration < MaxIteration)
            RndPoint = GenOnePoint(Largeur, Longueur)                           'génération d'un point
            Flag = False                                                        'indicateur de point trouvé mis à false

            For j As Integer = 0 To PointsList.Count - 1                        'Parcours du tableau de points valides

                Distance = Pythagore(PointsList(j), RndPoint)                   'Calcul de la distance entre le point généré et le point indexé du tableau de point valide
                If Distance < DistanceMin Then                                  'Si la distance n'est pas assés grand. L'indicateur est mis à true
                    Flag = True
                End If

            Next

            If Flag = False Then                                'si l'indicateur est toujours à false, alors le point est ajouté au tableau de point valide
                PointsList.Add(RndPoint)
                Count += 1                                      'Le nombre de point aléatoire trouvé est incrémenté
            End If

            Iteration += 1                                      'le compteur d'itération est incrémenté
        End While

        SortPoint(PointsList)                                   'Trie les points par X croissant

    End Sub


    ''' <summary>
    ''' Addition de 2 puits
    ''' </summary>
    ''' <param name="WellA">Puit A</param>
    ''' <param name="WellB">Puit B</param>
    ''' <returns> Un puit qui contient les point A et B</returns>
    Shared Operator +(ByVal WellA As Well, ByVal WellB As Well) As Well

        Dim Result As New Well()
        Result = WellA
        Result.PointsList.AddRange(WellB.PointsList)
        Return Result

    End Operator

End Class

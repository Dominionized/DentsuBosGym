Module variablesGlobales

    Public Const CARDIO_IND As Integer = 120
    Public Const CARDIO_FAM As Integer = 160
    Public Const MUSCU_IND As Integer = 110
    Public Const MUSCU_FAM As Integer = 140
    Public Const KICK_IND As Integer = 100
    Public Const KICK_FAM As Integer = 130
    Public Const RABAIS_2_ACT_IND As Double = 0.1
    Public Const RABAIS_2_ACT_FAM As Double = 0
    Public Const RABAIS_3_ACT_IND As Double = 0.15
    Public Const RABAIS_3_ACT_FAM As Double = 0.1
    Public Const RABAIS_9_MOIS_IND As Double = 0.1
    Public Const RABAIS_9_MOIS_FAM As Double = 0.15
    Public Const RABAIS_12_MOIS_IND As Double = 0.15
    Public Const RABAIS_12_MOIS_FAM As Double = 0.2
    Public Const TAX_TPS As Double = 0.05
    Public Const TAX_TVQ As Double = 0.0975

    Public nom As String
    Public isFamilial As Boolean
    Public isCardio As Boolean
    Public isMuscu As Boolean
    Public isKick As Boolean
    Public moisAbonnement As Integer
    Public nbAct As Integer

    Public isCardioInteger As Integer
    Public isMuscuInteger As Integer
    Public isKickInteger As Integer
    Public prixBrut As Double
    Public rabaisAct As Double
    Public rabaisMois As Double
    Public sousTotal As Double
    Public prixRabais As Double
    Public tps As Double
    Public tvq As Double
    Public prixFinal As Double
    Public type As String = "Individuel"

End Module

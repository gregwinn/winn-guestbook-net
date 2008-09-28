Public Class Core
    '=======================================================================
    'Do NOT EDIT, The version constant will allow us to support you better.
    '=======================================================================
    Public Const VersionIn = "1.0"
    Public Const LongVersion = "1.0.1"

    Public Shared Function GoogleAnalyticsDisplay()
        If WinnGuestbook.Config.GoogleAnalytics = "none" Then
            Return "false"
        Else
            Return "true"
        End If
    End Function
End Class

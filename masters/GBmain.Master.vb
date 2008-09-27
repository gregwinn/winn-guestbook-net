Public Partial Class GBmain
    Inherits System.Web.UI.MasterPage

    Public Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        SqlDataSource1.Insert()
    End Sub
End Class
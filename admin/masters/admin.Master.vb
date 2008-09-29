Public Partial Class admin
    Inherits System.Web.UI.MasterPage

    Protected Sub DataList2_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DataList2.ItemCommand
        If e.CommandName = "ApproveThisPost" Then

        End If
    End Sub
End Class
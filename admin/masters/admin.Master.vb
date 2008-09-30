Public Partial Class admin
    Inherits System.Web.UI.MasterPage

    Protected Sub DataList2_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DataList2.ItemCommand
        Dim cmd As New SqlDataSource
        cmd.ConnectionString = ConfigurationManager.ConnectionStrings("WinnGuestbook_dbConnectionString").ToString
        If e.CommandName = "ApproveThisPost" Then
            cmd.UpdateCommand = "UPDATE rev1_posts SET status = 2 WHERE id = @id"
            cmd.UpdateParameters.Add("id", e.CommandArgument)
            cmd.Update()
            DataList2.DataBind()
        ElseIf e.CommandName = "DeleteThisPost" Then
            cmd.DeleteCommand = "DELETE FROM rev1_posts WHERE id = @id"
            cmd.DeleteParameters.Add("id", e.CommandArgument)
            cmd.Delete()
            DataList2.DataBind()
        ElseIf e.CommandName = "MarkAsSpam" Then
        End If
    End Sub

    Protected Sub DataList1_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DataList1.ItemCommand
        Dim cmd As New SqlDataSource
        cmd.ConnectionString = ConfigurationManager.ConnectionStrings("WinnGuestbook_dbConnectionString").ToString
        If e.CommandName = "DeleteThisPost" Then
            cmd.DeleteCommand = "DELETE FROM rev1_posts WHERE id = @id"
            cmd.DeleteParameters.Add("id", e.CommandArgument)
            cmd.Delete()
            DataList1.DataBind()
        ElseIf e.CommandName = "ArchiveThisPost" Then
            cmd.UpdateCommand = "UPDATE rev1_posts SET status = 3 WHERE id = @id"
            cmd.UpdateParameters.Add("id", e.CommandArgument)
            cmd.Update()
            DataList1.DataBind()
        End If
    End Sub

    Protected Sub DataList3_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DataList3.ItemCommand
        Dim cmd As New SqlDataSource
        cmd.ConnectionString = ConfigurationManager.ConnectionStrings("WinnGuestbook_dbConnectionString").ToString
        If e.CommandName = "ApproveThisPost" Then
            cmd.UpdateCommand = "UPDATE rev1_posts SET status = 2 WHERE id = @id"
            cmd.UpdateParameters.Add("id", e.CommandArgument)
            cmd.Update()
            DataList3.DataBind()
        ElseIf e.CommandName = "DeleteThisPost" Then
            cmd.DeleteCommand = "DELETE FROM rev1_posts WHERE id = @id"
            cmd.DeleteParameters.Add("id", e.CommandArgument)
            cmd.Delete()
            DataList3.DataBind()
        End If
    End Sub
End Class
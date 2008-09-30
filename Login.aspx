<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/admin/masters/admin.Master" CodeBehind="Login.aspx.vb" Inherits="WinnGuestbook.WebForm6" 
    title="Winn Guestbook Admin Area Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="LogoTitle" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SubNav" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ActivePosts" runat="server">
        <div id="login">
            <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" 
                BorderStyle="Solid" BorderWidth="1px" DisplayRememberMe="False" 
                Font-Names="Verdana" Font-Size="9pt" 
                DestinationPageUrl="~/admin/Default.aspx" Width="260px">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:Login>
        </div>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="PostsOnHold" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ArchivedPosts" runat="server">
</asp:Content>


<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="header.ascx.vb" Inherits="WinnGuestbook.header" %>
<h1>Winn Guestbook [.NET]</h1>
        <ul>
            <li><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/admin/Default.aspx">Dashboard</asp:HyperLink></li>
            <li><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/admin/Default.aspx">Active</asp:HyperLink></li>
            <li><asp:LoginStatus ID="LoginStatus1" runat="server" /></li>
        </ul>
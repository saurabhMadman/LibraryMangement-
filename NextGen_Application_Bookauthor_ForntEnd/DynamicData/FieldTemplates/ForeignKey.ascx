<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="NextGen_Application_Bookauthor_ForntEnd.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />


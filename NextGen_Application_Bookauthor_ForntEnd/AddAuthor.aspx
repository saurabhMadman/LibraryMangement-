<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAuthor.aspx.cs" Inherits="NextGen_Application_Bookauthor_ForntEnd.AddAuthor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Image ID="Image1" runat="server" Height="247px" ImageUrl="~/ImageUrl/Author-680-x-300.jpg" Style="margin-left: 44px" Width="1089px" />
    <br />
    <marquee style="color: aqua"><h2>"Insert Your New Record"</h2></marquee>
    <br />
    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView ID="FormView1" runat="server"
        ItemType="NextGen_Application_BookAuthor.Author"
        InsertMethod="FormView1_InsertItem" DefaultMode="Insert" RenderOuterTable="True" OnItemInserted="FormView1_ItemInserted"
        CellPadding="4" ForeColor="#333333" Height="79px" Width="421px">

        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />

        <InsertItemTemplate>
            <fieldset>
                <ol>
                    <asp:DynamicEntity runat="server" Mode="Insert" />
                </ol>
            </fieldset>
            <asp:Button runat="server" Text="Insert" CommandName="Insert" />
            <asp:Button runat="server" Text="Cancel" CausesValidation="false" OnClick="Unnamed_Click" />
        </InsertItemTemplate>



        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />



    </asp:FormView>



</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="NextGen_Application_Bookauthor_ForntEnd.AddBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Image ID="Image1" runat="server" Height="313px" ImageUrl="~/ImageUrl/3.jpg" Style="margin-left: 5px" Width="1215px" />
    <br />
    <marquee style="color: aqua"><h2>"Insert Your New Record"</h2></marquee>
    <br />
    <asp:ValidationSummary runat="server" ShowModelStateErrors="true" />
    <asp:FormView ID="FormView1" runat="server"
        ItemType="NextGen_Application_BookAuthor.Book"
        InsertMethod="FormView1_InsertItem" DefaultMode="Insert" OnItemInserted="FormView1_ItemInserted" CellPadding="4" ForeColor="#333333" Width="427px">

        <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />

        <InsertItemTemplate>
            <fieldset>
                <ol>
                    <asp:DynamicEntity runat="server" Mode="Insert" />
                </ol>
            </fieldset>
            <asp:Button runat="server" Text="Insert" CommandName="Insert" />
            <asp:Button runat="server" Text="Cancel" CausesValidation="false" OnClick="cancel_Button_Click" />
        </InsertItemTemplate>



        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />



    </asp:FormView>



</asp:Content>



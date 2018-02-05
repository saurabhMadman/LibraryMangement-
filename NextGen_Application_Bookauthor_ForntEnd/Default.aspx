<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NextGen_Application_Bookauthor_ForntEnd._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    <asp:Image ID="Image1" runat="server" Height="428px" ImageUrl="~/ImageUrl/collage-of-elmore-leonard-books.jpg" Width="1130px" Style="margin-left: 28px" />
    <br />
    <marquee style="color: aqua"><h4>"Search for Any books you want"</h4></marquee>
    <br />
    &nbsp&nbsp&nbsp
    <asp:Label ID="lblmsg" runat="server" Text="SelectAuthorName" BackColor="#0099CC" Font-Bold="False" ForeColor="White" Font-Size="Large"></asp:Label>
    &nbsp&nbsp&nbsp
    <asp:DropDownList ID="DropDownList" runat="server" DataSourceID="SqlDataSource1" DataTextField="FistName" DataValueField="Aid" Height="30px" Width="197px" AutoPostBack="True" BackColor="#FFFF66">
    </asp:DropDownList>

    <div class="jumbotron">
        <h4 style="background-color: #99CCFF; font-family: Arial, Helvetica, sans-serif; font-size: large;">REQUESTED BOOKS</h4>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NextGen_Application_Bookauthor_DataAccess.BookAuthor_DataAccessLayerConnectionString %>" SelectCommand="SELECT [Aid], [FistName] FROM [Authors]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NextGen_Application_Bookauthor_DataAccess.BookAuthor_DataAccessLayerConnectionString %>" SelectCommand="SELECT [Bid], [BookName], [Genre], [Publication], [Description], [AuthorId] FROM [Books] WHERE ([AuthorId] = @AuthorId)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList" Name="AuthorId" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="2" DataKeyNames="Bid" DataSourceID="SqlDataSource2" ForeColor="Black" GridLines="None" AllowPaging="True" Width="971px" Height="16px" Style="margin-left: 43px" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:BoundField DataField="BookName" HeaderText="BookName" SortExpression="BookName" />
                <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
                <asp:BoundField DataField="Publication" HeaderText="Publication" SortExpression="Publication" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
    </div>
    <br />
    <br />
</asp:Content>

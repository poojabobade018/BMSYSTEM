<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CBILL.aspx.vb" Inherits="BMSYSTEM.CBILL" MasterPageFile="~/ADMIN.Master" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <body>
    <form id="form1" >
        <div style="background-color: #FFCC99">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="REPORT OF CLIENT BILLS "></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Report Date :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="repd" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btshow" runat="server" Text="SHOW DETAILS" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
     </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" DynamicHorizontalOffset="2" Font-Bold="True" Font-Names="Verdana" Font-Size="Medium" ForeColor="#660033" Height="16px" Orientation="Horizontal" RenderingMode="Table" StaticSubMenuIndent="10px" style="text-align: center; color: #FF0000; background-color: #FFFFFF" Width="1345px">
                    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#B5C7DE" />
                    <DynamicSelectedStyle BackColor="#507CD1" />
                    <Items>
                        <asp:MenuItem NavigateUrl="~/suppl.aspx" Text="SUPPLIER DETAILS" Value="SUPPLIER DETAILS"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/staffd.aspx" Text="STAFF DETAILS" Value="STAFF DETAILS"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/cletord.aspx" Text="CLIENT ORDER" Value="CLIENT ORDER"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/measdel.aspx" Text="MEASUREMENT" Value="MEASUREMENT"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/rates.aspx" Text="RATE DETAILS" Value="RATE DETAILS"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/billdet.aspx" Text="BILL DETAILS" Value="BILL DETAILS"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/CDATAIL.aspx" Text="CLIENT DETAILS TABLE" Value="CLIENT DETAILS TABLE"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#507CD1" />
                </asp:Menu>
            </asp:Content>


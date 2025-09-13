<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CDATAIL.aspx.vb" Inherits="BMSYSTEM.CDATAIL" MasterPageFile="~/ADMIN.Master" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <body>
    <form id="form1">
        <div style="background-color: #FFCC99">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="REPORT OF CLIENT DETAILS"></asp:Label>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Report Date :"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="redate" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Bshow" runat="server" Text="SHOW DETAILS" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>

     </asp:Content>


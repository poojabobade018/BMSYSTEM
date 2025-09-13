<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="blousecatlog.aspx.vb" Inherits="BMSYSTEM.catlog" MasterPageFile="~/USER.Master" %>

  <asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" >
        <div style="background-position: right center; height: 775px; width: 1445px; background-color: #FFCC99; background-repeat: no-repeat; background-attachment: inherit; background-image: url('pic/blousepat.PNG');">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="18pt" Text="CATLOG  DETAILS"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Catlog Id"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="Txtcat" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Costume Type"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtcostt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text=" Basic Rate"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtbac" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Butup" runat="server" Text="UPLOAD" />
            &nbsp;
            <asp:TextBox ID="Txtupp" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="237px" Width="241px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image2" runat="server" Height="222px" Width="216px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload2" runat="server" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Butupppp" runat="server" Text="UPLOAD" />
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtup" runat="server" Width="153px"></asp:TextBox>
&nbsp;&nbsp;
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Bsave" runat="server" Text="SAVE" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Butcan" runat="server" Text="CANCEL" />
            <br />
            <br />
        </div>
    </form>
    </asp:Content>


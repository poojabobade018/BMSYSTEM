<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Aboutus.aspx.vb" Inherits="BMSYSTEM.Aboutus" MasterPageFile="~/USER.Master" %>

 <asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            text-decoration: underline;
            text-align: center;
            color: #FF0000;
            background-color: #66FFCC;
        }
    </style>

    <form id="form1">
        <div style="height: 1396px; width: 1708px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20pt" style="text-decoration: underline; text-align: center" Text="ABOUT  US"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <h2 class="auto-style2">&quot;Enhancing your inner beauty&quot;</h2>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1">&nbsp; Having provided exceptional ethnic fashion through the digital space to our treasured customers over the years, we have come to understand your fashion needs better. As an extension of our service, we are offering the most skilled, reliable online tailoring service to help you realise your style goals. Our highly professional and, at the same time, customer-centric approach will help you have a pleasant experience in getting customised fashion. Customer stitch Blouse, Salwar Suits, Anarkali Suits, Kurti Top, Lehenga and ethnic Bottomwear in styles and fit that complement you perfectly!</span><br class="auto-style1" />
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; When you choose to stitch clothes that suit you, both personality and fit-wise, you end up with the most amazing set of clothes that speak to your style! Our easy-to-understand website and extremely reachable customer care services. With everything that is available online for your convenience, it is only right to offer custom-stitching services for you in the digital world too. No long, tiring and disappointing wait at the tailors shop and struggling to explain to them your style wish; just sit back, let the AC run and browse through ALL imaginable designs right here at one place - at great prices too! Our team of fashion designers will personally design these outfits for you and give the tailor accurate instructions. </span>
            <br class="auto-style1" />
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Yes, you will have your own designer coordinating your style for you! You can coordinate your order through call or whatsapp, and share all the necessary details in a way that is comfortable to you. Our pick-up facility will collect the fabric you want stitched; if you need help with selection of fabric - we are here to help you with that too! From buying and selection of fabric of your choice, to picking up add-on style features that will go in the final outfit, </span>
            <br class="auto-style1" />
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; we will take care of all the requirements for you. If you want a particular type of embellishment on your outfit, our value added services include talented craftspersons that will bring your ideas to life. While you dream of your customised attire, we will work hard to turn it into a gorgeous reality. Customer happiness is our primary goal! It will be a sure thrill to see your design sketch transformed into a final outfit when it is delivered to you destination. Our faster stitching and delivery service (currently available only in PUNE) will ensure that your most awaited online order is there for you just when you need it.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <br class="auto-style1" />
            <span class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Go ahead, send us the details of that outfit you’ve been meaning to stitch for so long. You can trust our online stitching site to take your many ideas and transform them into final outfits. A stitch in time saves nine, they say, but stitch here at POOJA TAILOR.com and save more than time - save yourself from ill-fitting clothes and boring fashion!!!!!</span></div>
    </form>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Menu ID="Menu1" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Medium" ForeColor="#990000" Orientation="Horizontal" StaticSubMenuIndent="10px" Width="1500px" Font-Bold="True">
                    <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#FFFBD6" />
                    <DynamicSelectedStyle BackColor="#FFCC66" />
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Home.aspx" Text="HOME" Value="HOME"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/Aboutus.aspx" Text="ABOUT US" Value="ABOUT US"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/contus.aspx" Text="CONTACT US" Value="CONTACT US"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/customerenq.aspx" Text="CUSTOMER ENQUIRY" Value="CUSTOMER ENQUIRY"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/blousecatlog.aspx" Text="BLOUSE CATLOG" Value="BLOUSE CATLOG"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/catlogtraditional.aspx" Text="TRADITIONS CATLOG" Value="TRADITIONS CATLOG"></asp:MenuItem>
                        <asp:MenuItem NavigateUrl="~/western.aspx" Text="WESTERN CATLOG" Value="WESTERN CATLOG"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#FFCC66" />
                </asp:Menu>
            </asp:Content>

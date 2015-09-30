<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Exam.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:LinkButton Text="Add a country" runat="server" PostBackUrl="~/AddNewCountry.aspx" />
            <br />
            <br />
            <asp:Label Text="Keyword: " runat="server" />
            <asp:TextBox runat="server" ID="searchTxtBox" OnTextChanged="searchTxtBox_TextChanged" />
            <br />

            <asp:Button Text="Search" runat="server" OnClick="searchBtn_Click" ID="searchBtn" />
            <br />
            <br />
            <asp:Repeater runat="server" ID="countryRepeater">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("Country") %>' />
                    <br />
                    <asp:Label Text='<%# Eval("City") %>' runat="server" />
                    <br />
                    <asp:Label Text='<%# Eval("Population") %>' runat="server" />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:Repeater> 
    </div>
    </form>
</body>
</html>

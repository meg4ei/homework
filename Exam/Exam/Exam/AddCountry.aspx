<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCountry.aspx.cs" Inherits="Exam.AddCountry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton Text="Search for a country" runat="server" PostBackUrl="~/SearchCountry.aspx"/>
        <br />
        <br />
        <asp:Label Text="Country: " runat="server" ID="countryLabel" />
        <asp:TextBox runat="server" id="countryTxtBox" OnTextChanged="countryTxtBox_TextChanged" />  
        <br />
        <br />
        <asp:Label Text="City:  " runat="server" ID="cityLabel" />
        <asp:TextBox runat="server" id="cityTxtBox" />
        <br />
        <br />
        <asp:Label Text="Population:  " runat="server" ID="populationLabel" />
        <asp:TextBox runat="server" id="populationTxtBox" TextMode="Date" />
        <br />
        <br />
        <asp:Button Text="Add information" ID="AddInformationBtn" runat="server" OnClick="addInformationBtn_Click"/>
        <asp:Label Text="!!!!" runat="server" ForeColor="Red" ID="resultLabel"/>
    
    </div>
    </form>
</body>
</html>

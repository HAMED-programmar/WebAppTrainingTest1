<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebAppTest1.loginTest1.login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/csstest1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="mydiv">
             نام کاربری
            <br />
            <input typy="text" id="textusername" runat="server" maxlength="20" />
            <br />
            رمز عبور 
            <br />
            <input type="password" id="password" runat="server" maxlength="8" />
            <hr />
           
           <asp:Button ID="btnopen" runat="server" text="ورود" OnClick="btnopen_Click" />
            <br />
            <label id="lberror" runat="server"></label>
        </div>
    </form>
</body>
</html>

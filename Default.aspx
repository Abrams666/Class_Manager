<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Account_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Class Manager</title>
    <link href="Default.css" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.cdnfonts.com/css/poppins" rel="stylesheet">
        <style>
        body {
  background-image: url('/picture/bg1.jpg');
  background-repeat: no-repeat;
}
.account label {
              position: relative;
              transition: top 0.3s, font-size 0.3s;
            }
            
            .account input:focus + label,
            .account input:valid + label,
            .account input:not(:placeholder-shown) + label {
              top: 0;
              font-size: medium;
            }
            .password label {
              position: relative;
              transition: top 0.3s, font-size 0.3s;
            }
            
            .password input:focus + label,
            .password input:valid + label,
            .password input:not(:placeholder-shown) + label {
              top: 0;
              font-size: medium;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="title">
        <h1 class="titletitle">Class Manager</h1>
        <br/>
        <p>A website makes classes better!</p>
        </div>
        <div class="box">
        <h1 class="signuploginlabel2" >登入</h1>
        <div class="account">
        <asp:Label ID="accountlabel" CssClass="signuploginlabel" runat="server" Text="Label">帳號</asp:Label>
        <asp:Label ID="accounterrormessage" CssClass="errormessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br/>
        <br/>
        <asp:TextBox ID="accountbox" CssClass="signuploginbox" runat="server"></asp:TextBox>
        </div>
        <div class="password">
        <asp:Label ID="passwordlabel" CssClass="signuploginlabel" runat="server" Text="Label">密碼</asp:Label>
        <asp:Label ID="passworderrormessage" CssClass="errormessage" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br/>
        <br/>
        <asp:TextBox ID="passwordbox" CssClass="signuploginbox" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <br/>
        <div>
        <asp:Button ID="loginbutton" CssClass="button" runat="server" Text="登入" />
        <asp:Button ID="choosesignup" CssClass="button" runat="server" Text="註冊" />
        </div>
        </div>
    </form>
    <script>
        const accountBox = document.getElementById('accountbox');
        const accountLabel = document.getElementById('accountlabel');
        
        accountBox.addEventListener('focus', () => {
          accountLabel.style.top = '0';
          accountLabel.style.fontSize = 'medium';
        });
        
        accountBox.addEventListener('blur', () => {
          if (!accountBox.value) {
            accountLabel.style.top = '';
            accountLabel.style.fontSize = '';
          }
        });
        
        // Optional: Set initial state based on the presence of value
        if (accountBox.value) {
          accountLabel.style.top = '0';
          accountLabel.style.fontSize = 'medium';
        }
        const passBox = document.getElementById('passwordbox');
        const passLabel = document.getElementById('passwordlabel');
        
        passBox.addEventListener('focus', () => {
          passLabel.style.top = '0';
          passLabel.style.fontSize = 'medium';
        });
        
        passBox.addEventListener('blur', () => {
          if (!accountBox.value) {
            passLabel.style.top = '';
            passLabel.style.fontSize = '';
          }
        });
        
        // Optional: Set initial state based on the presence of value
        if (passBox.value) {
          passLabel.style.top = '0';
          passLabel.style.fontSize = 'medium';
        }
      </script>
</body>
</html>

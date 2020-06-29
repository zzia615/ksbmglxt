<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ksbmglxt.Login" %>

<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <title>用户登录 - <%=WebData.SystemTitle %></title>
    <link href="layui/css/layui.css" rel="stylesheet" />
    <style>
        body{
            background:#1e4319;
            background:url("img/bg.jpg");
            background-size:cover;
        }
        .login-form{
            margin:50px auto;
            width:350px;
            min-height:100px;
            background:rgba(255, 255, 255, 0.82);
            padding:20px;
            border-radius:5px;
        }
    </style>
</head>
<body class="layui-layout-body">
    <form runat="server" class="layui-form login-form">
        <div style="text-align:center;padding-bottom:20px;">
            <h2>用户登录</h2>
        </div>
        <div class="layui-form-item">
          <label class="layui-form-label">账号</label>
          <div class="layui-input-block">
              <asp:TextBox ID="name" runat="server" CssClass="layui-input"></asp:TextBox>
          </div>
          <div style="margin-left:110px">
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="账号不能为空" ControlToValidate="name" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
          </div>  
        </div>
        <div class="layui-form-item">
          <label class="layui-form-label">密码</label>
          <div class="layui-input-block">
              <asp:TextBox TextMode="Password" ID="pwd" runat="server" CssClass="layui-input"></asp:TextBox>
          </div>
          <div style="margin-left:110px">
          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" ControlToValidate="pwd" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
          </div>  
        </div>
        <div class="layui-form-item"> 
            <div class="layui-input-block">
                <asp:Button ID="login" runat="server" Text="用户登录" CssClass="layui-btn" OnClick="login_Click"/>
            </div>
        </div>
    </form>
<script src="layui/layui.js"></script>
<script>
//JavaScript代码区域
layui.use('element', function(){
  var element = layui.element;
  
});
</script>
</body>
</html>

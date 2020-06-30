<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="ChangePwd.aspx.cs" Inherits="ksbmglxt.ChangePwd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="layui-form">
    <div class="layui-form-item">
        <label class="layui-form-label">账号</label>
        <div class="layui-input-block">
            <asp:TextBox ID="yhzh" runat="server" CssClass="layui-input" Enabled="false"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="账号不能为空" ControlToValidate="yhzh" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">姓名</label>
        <div class="layui-input-block">
            <asp:TextBox ID="yhxm" runat="server" CssClass="layui-input" Enabled="false"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="姓名不能为空" ControlToValidate="yhxm" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">角色</label>
        <div class="layui-input-block">
            <asp:TextBox ID="yhjs" runat="server" CssClass="layui-input" Enabled="false"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="角色不能为空" ControlToValidate="yhjs" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">新密码</label>
        <div class="layui-input-block">
            <asp:TextBox ID="yhmm" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" ControlToValidate="yhmm" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>    
    <div class="layui-form-item">
        <label class="layui-form-label">重复密码</label>
        <div class="layui-input-block">
            <asp:TextBox ID="yhmm1" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="密码不能为空" ControlToValidate="yhmm1" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>    
    <div class="layui-form-item"> 
        <div class="layui-input-block">
            <asp:Button ID="Button1" runat="server" Text="修改" CssClass="layui-btn" OnClick="Button1_Click"/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Yhxx.aspx" CssClass="layui-btn layui-btn-primary">返回列表</asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>

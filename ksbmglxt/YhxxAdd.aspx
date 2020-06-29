<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="YhxxAdd.aspx.cs" Inherits="ksbmglxt.YhxxAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="layui-form">
    <div class="layui-form-item">
        <label class="layui-form-label">账号</label>
        <div class="layui-input-block">
            <asp:TextBox ID="yhzh" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="账号不能为空" ControlToValidate="yhzh" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">姓名</label>
        <div class="layui-input-block">
            <asp:TextBox ID="yhxm" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="姓名不能为空" ControlToValidate="yhxm" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">密码</label>
        <div class="layui-input-block">
            <asp:TextBox ID="yhmm" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空" ControlToValidate="yhmm" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">角色</label>
        <div class="layui-input-block">
            <select runat="server" id="yhjs">
                <option value="">请选择用户角色</option>
                <option value="普通管理员">普通管理员</option>
                <option value="系统管理员">系统管理员</option>
            </select>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="角色不能为空" ControlToValidate="yhjs" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item"> 
        <div class="layui-input-block">
            <asp:Button ID="Button1" runat="server" Text="新增" CssClass="layui-btn" OnClick="Button1_Click"/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Yhxx.aspx" CssClass="layui-btn layui-btn-primary">返回列表</asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>

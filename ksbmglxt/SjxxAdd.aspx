<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="SjxxAdd.aspx.cs" Inherits="ksbmglxt.SjxxAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="layui-form">
    <div class="layui-form-item">
        <label class="layui-form-label">名称</label>
        <div class="layui-input-block">
            <asp:TextBox ID="mc" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="名称不能为空" ControlToValidate="mc" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">类别</label>
        <div class="layui-input-block">
            <asp:TextBox ID="lb" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="类别不能为空" ControlToValidate="lb" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">说明</label>
        <div class="layui-input-block">
            <asp:TextBox ID="sm" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
    </div>
    <div class="layui-form-item"> 
        <div class="layui-input-block">
            <asp:Button ID="Button1" runat="server" Text="新增" CssClass="layui-btn" OnClick="Button1_Click"/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Sjxx.aspx" CssClass="layui-btn layui-btn-primary">返回列表</asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>

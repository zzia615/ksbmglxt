<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="SjxxUpload.aspx.cs" Inherits="ksbmglxt.SjxxUpload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="layui-form">
    
    <div hidden>
        <asp:Label ID="sjid" runat="server" Text="Label"></asp:Label>
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">选择文件</label>
        <div class="layui-input-block">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
    </div>
    <div class="layui-form-item"> 
        <div class="layui-input-block">
            <asp:Button ID="Button1" runat="server" Text="上传" CssClass="layui-btn" OnClick="Button1_Click"/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Sjxx.aspx" CssClass="layui-btn layui-btn-primary">返回列表</asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>

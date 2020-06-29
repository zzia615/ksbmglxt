<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="TkxxAdd.aspx.cs" Inherits="ksbmglxt.TkxxAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="layui-form">
    <div class="layui-form-item">
        <label class="layui-form-label">题目</label>
        <div class="layui-input-block">
            <asp:TextBox ID="mc" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="题目不能为空" ControlToValidate="mc" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">结果</label>
        <div class="layui-input-block">
            <asp:TextBox ID="jg" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="结果不能为空" ControlToValidate="jg" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        </div>  
    </div>
    <div class="layui-form-item">
        <label class="layui-form-label">分数</label>
        <div class="layui-input-block">
            <asp:TextBox ID="fs" runat="server" CssClass="layui-input"></asp:TextBox>
        </div>
        <div style="margin-left:110px">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="分数不能为空" ControlToValidate="fs" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="分数1-100" ControlToValidate="fs" ForeColor="Red" Display="Dynamic" MaximumValue="100" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        </div> 
    </div>
    <div class="layui-form-item"> 
        <div class="layui-input-block">
            <asp:Button ID="Button1" runat="server" Text="新增" CssClass="layui-btn" OnClick="Button1_Click"/>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Tkxx.aspx" CssClass="layui-btn layui-btn-primary">返回列表</asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>

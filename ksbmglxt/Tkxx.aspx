<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Tkxx.aspx.cs" Inherits="ksbmglxt.Tkxx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="layui-inline">
    <div class="layui-input-inline">
        <select runat="server" id="tjlb">
            <option value="">请选择类别</option>
            <option value="id">编码</option>
            <option value="mc">题目</option>
        </select>
    </div>
    <div class="layui-input-inline">
        <asp:TextBox ID="tjnr" runat="server" CssClass="layui-input"></asp:TextBox>
    </div>
    <div class="layui-input-inline">
        <asp:Button ID="Button1" runat="server" Text="查询" CssClass="layui-btn" OnClick="Button1_Click"/>
    </div>
    <div class="layui-input-inline">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="TkxxAdd.aspx" CssClass="layui-btn">新增</asp:HyperLink>
    </div>
</div>
<div>
    <asp:GridView ID="GridView1" runat="server" CssClass="layui-table" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="id">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="编码" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="mc" HeaderText="题目" SortExpression="mc" />
            <asp:BoundField DataField="jg" HeaderText="结果" SortExpression="jg" />
            <asp:BoundField DataField="fs" HeaderText="分数" SortExpression="fs" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "TkxxEdit.aspx?id="+Eval("id")%>' Text="编辑" CssClass="layui-btn layui-btn-sm"></asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "TkxxDelete.aspx?id="+Eval("id")%>' Text="删除" CssClass="layui-btn layui-btn-sm layui-btn-danger"></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ksbmglxtConStr %>" SelectCommand="SELECT * FROM [Tkxx]"></asp:SqlDataSource>
</div>
</asp:Content>

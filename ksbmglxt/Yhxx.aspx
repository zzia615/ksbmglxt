<%@ Page Title="" Language="C#" MasterPageFile="~/MainSite.Master" AutoEventWireup="true" CodeBehind="Yhxx.aspx.cs" Inherits="ksbmglxt.Yhxx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="layui-inline">
    <div class="layui-input-inline">
        <select runat="server" id="tjlb">
            <option value="">请选择类别</option>
            <option value="yhzh">账号</option>
            <option value="yhxm">姓名</option>
            <option value="yhjs">角色</option>
        </select>
    </div>
    <div class="layui-input-inline">
        <asp:TextBox ID="tjnr" runat="server" CssClass="layui-input"></asp:TextBox>
    </div>
    <div class="layui-input-inline">
        <asp:Button ID="Button1" runat="server" Text="查询" CssClass="layui-btn" OnClick="Button1_Click"/>
    </div>
    <%if (Session[WebData.登录用户类别].AsString() == "系统管理员")
        {%>
    <div class="layui-input-inline">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="YhxxAdd.aspx" CssClass="layui-btn">新增</asp:HyperLink>
    </div>
        <%} %>
</div>
<div>
    <asp:GridView ID="GridView1" runat="server" CssClass="layui-table" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="yhzh">
        <Columns>
            <asp:BoundField DataField="yhzh" HeaderText="账号" ReadOnly="True" SortExpression="yhzh" />
            <asp:BoundField DataField="yhxm" HeaderText="姓名" SortExpression="yhxm" />
            <asp:BoundField DataField="yhmm" HeaderText="密码" DataFormatString="******" SortExpression="yhmm" />
            <asp:BoundField DataField="yhjs" HeaderText="角色" SortExpression="yhjs" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "YhxxEdit.aspx?yhzh="+Eval("yhzh")%>' Text="编辑" CssClass="layui-btn layui-btn-sm"></asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# "YhxxDelete.aspx?yhzh="+Eval("yhzh")%>' Text="删除" CssClass="layui-btn layui-btn-sm layui-btn-danger"></asp:HyperLink>
               </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ksbmglxtConStr %>" SelectCommand="SELECT * FROM [Yhxx]"></asp:SqlDataSource>
</div>
</asp:Content>

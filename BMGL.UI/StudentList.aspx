<%@ Page Title="部门信息管理" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="BMGL.UI.StudentList" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div class="titlebar">
        <div>成员信息管理</div>
    </div>

    <div class="newbt">
        <div>
            <a href="/StudentAdd.aspx">
                <input type="button" id="add" value="添加成员"  />
            </a>
        </div>
    </div>
    <div class="list" <%--style="background:url(images/a8.jpg);color:white;"--%>>
        <table class="listtb">
            <asp:Repeater ID="rpData" runat="server">
                <HeaderTemplate>
                    <%--标题头模板--%>
                    <tr<%-- style="background:url(images/4.jpg)"--%>>
                        <th>学号</th>
                        <th>姓名</th>
                        <th>职位</th>
                        <th>联系电话</th>
                        <th>操作</th>
                    </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <%--内容项模板--%>
                    <tr<%-- style="background-color:black;color:white;"--%>>
                        <td><%#Eval("s_Num") %></td>
                        <td><%#Eval("s_Name") %></td>
                        <td><%#Eval("s_Post") %></td>
                        <td><%#Eval("s_Phone") %></td>
                        <td><a href="StudentEdit.aspx?s_Num=<%#Eval("s_Num") %>>">修改</a> | <a href="StudentDelete.ashx?s_Num=<%#Eval("s_Num") %>" onclick="return confirm('确定删除?');">删除</a></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <br />
    </div>
</asp:Content>

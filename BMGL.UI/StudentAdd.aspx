<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="StudentAdd.aspx.cs" Inherits="GDCP.UI.StudentAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>学生添加页面</title>
    <!--引用css样式-->
    <link href="css/Validform.css" rel="stylesheet" />
    <!--引用js脚本-->
    <script src="scripts/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="scripts/My97DatePicker/WdatePicker.js"></script>    
    <script src="scripts/Validform_v5.3.2.js"></script>
    <script type="text/javascript">
        $(function () {
            //验证
            $("#form1").Validform({
                tiptype: 2,
                showAllError: true
            });

            $("#cphMain_fuFile").change(function () {
                //1、获取FileUpload上传的图片文件
                var file = document.getElementById("cphMain_fuFile").files[0];
                //2、将图片文件转换为URL字符串
                var src = window.URL.createObjectURL(file);
                //3、设置image标签的src属性，即可显示图片
                $("#photo").attr("src", src);              

            });
        });   
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div class="titlebar">
        <div>增加成员</div>
    </div>
    <div class="list">
        <table class="listtb" style="width: 80%">
            <tr>
                <th>学号</th>
                <td style="width: 50%">
                    <asp:TextBox ID="txtStudentNo" runat="server" datatype="s" nullmsg="请输入学号" ></asp:TextBox>                 
                </td>
                <td style="width: 30%">
                    <div class="Validform_checktip">*学生的学号</div>
                </td>
            </tr>
            <tr>
                <th>姓名</th>
                <td style="width: 50%">
                    <asp:TextBox ID="txtStudentName" runat="server" datatype="s" nullmsg="请输入姓名" ></asp:TextBox>
              
                </td>
                <td style="width: 30%">
                    <div class="Validform_checktip">*学生的姓名</div>
                </td>
            </tr>
            <tr>
                <th>手机号码</th>
                <td style="width: 50%">
                    <asp:TextBox ID="txtPhone" runat="server" datatype="*" nullmsg="请输入手机号码"></asp:TextBox>                  
                </td>
                <td style="width: 30%">
                    <div class="Validform_checktip">*学生的手机号码</div>
                </td>
            </tr>
            <tr>
                <th>家庭住址</th>
                <td style="width: 50%">
                    <asp:TextBox ID="txtAddress"  runat="server" datatype="s" nullmsg="请输入家庭地址"></asp:TextBox>               
                </td>
                <td style="width: 30%">
                    <div class="Validform_checktip">*学生的家庭地址</div>
                </td>
            </tr>
            <tr>
                <th></th>
                <td>
                    &nbsp;<asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="提交" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <input type="button" value="取消" onclick="window.location = '/StudentList.aspx'" />
                </td>
                <td></td>
            </tr>
        </table>
    </div>
</asp:Content>


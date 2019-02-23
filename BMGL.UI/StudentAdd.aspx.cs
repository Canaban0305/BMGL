using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BMGL.BLL;
using BMGL.Model;
using System.IO;


namespace GDCP.UI
{
    using System.Drawing;

    public partial class StudentAdd : System.Web.UI.Page
    {

        private StudentManager bll = new StudentManager();
        //创建各管理类的对象

        //在页面加载完毕后执行
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取用户输入的数据
            string s_Name = txtStudentName.Text.Trim();
            string s_Num = txtStudentNo.Text.Trim();

            //添加用户
            //1、构造用户实体对象
            Student model = new Student();
            model.s_Name = s_Name;
            //model.UserPwd = userPwd;
            //model.Status = status;

            //2、调用业务逻辑层添加用户
            int result = bll.Add(model);

            if (result > 0)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('添加用户成功！');window.location.href='UsersList.aspx'</script>");
            }
            else
            {
                if (result == -1)
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('用户名已存在！')</script>");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('添加用户失败！')</script>");
                }
            }

        }
    }
}
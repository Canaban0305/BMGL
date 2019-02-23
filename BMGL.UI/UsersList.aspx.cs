using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using BMGL.BLL;
using BMGL.Model;

namespace BMGL.UI
{
    public partial class UsersList : System.Web.UI.Page
    {
        private UsersManager bll = new UsersManager();
        private StudentManager blls = new StudentManager();

        protected StringBuilder sb = new StringBuilder(200);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //调用业务逻辑层方法获取所有的用户列表
                List<Users> list = bll.GetList();
                //int userId = Convert.ToInt32(Request.QueryString["UserId"]);
                int userId = 1;

                Student modell = blls.GetModel(userId);
                if (modell != null)
                {
                    //读取实体对象的各个属性值，并赋值给控件
                    //sb.Append("<td>" + modell.s_Post + "</td>");
                    //sb.Append("<td>" + modell.s_Phone + "</td>");
                    Response.Write("<script>alert('" + modell.s_Post + "');</script>");
                    //string s_Post = modell.s_Post;  //用户名
                    //string s_Phone = modell.s_Phone;   //密码
                }






                List<Student> lists = blls.GetList();

                //遍历列表中的元素



                //遍历列表中的元素
                foreach (Users model in list)
                {
                    sb.Append("<tr>");
                    sb.Append("<td>" + model.UserName + "</td>");
                    //sb.Append("<td>" + model.UserName + "</td>");
                    //去数据库中查询此用户编号的用户数据

                    sb.Append("<td>" + (model.Status == 1 ? "正常" : "禁用") + "</td>");
                    sb.Append("<td><a href=\"UsersEdit.aspx?UserId=" + model.UserId + "\">修改</a> | <a href=\"UsersDelete.ashx?UserId=" + model.UserId + "\" onClick=\"return confirm('确定删除?');\">删除</a></td>");
                    sb.Append("</tr>");
                }
            }
        }
    }
}
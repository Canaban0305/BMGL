using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMGL.BLL;
using BMGL.Model;

namespace BMGL.UI
{
    public partial class StudentList : System.Web.UI.Page
    {
        //创建各管理类的对象
        private DepartmentManager mm = new DepartmentManager();
        private StudentManager stm = new StudentManager();


        protected void Page_Load(object sender, EventArgs e)
        {
                //调用业务逻辑层方法获取学院数据
                List<Student> list = stm.GetList();
                //数据绑定
                rpData.DataSource = list;
                rpData.DataBind();

        }
    }
}
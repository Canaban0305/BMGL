using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMGL.Model
{
   public class Teacher
    {
       private string t_id;
       private string t_name;
       private string t_pwd;
       private int status;
       private string t_idcard;
        //编号
        public string t_ID
        {
            set { t_id = value; }
            get { return t_id; }

        }
        //姓名
        public string t_Name
        {
            set { t_name = value; }
            get { return t_name; }
        }
        //密码
        public string t_Pwd
        {
            set { t_pwd = value; }
            get { return t_pwd; }
        }
        //状态
        public int Status
        {
            set { status = value; }
            get { return status; }
        }
        //身份证号
        public string t_IDCard
        {
            set { t_idcard = value; }
            get { return t_idcard; }
        }
    }
}
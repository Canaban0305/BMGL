using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMGL.Model
{
    [Serializable]
    public class Student
    {
        #region Model
        private int d_deptid;
        private string s_name;
        private string s_post;
        private string s_num;
        private string s_class;
        private string s_phone;
        private string s_content;
        //部门编号
        public int d_DeptId 
        {
            set { d_deptid = value; }
            get { return d_deptid; }
            
        }
        //干事姓名
        public string s_Name 
        {
            set { s_name = value; }
            get { return s_name; }
        }    
        //职位
        public string s_Post
        {
            set { s_post = value; }
            get { return s_post; }
        }    
        //学号
        public string s_Num
        {
            set { s_num = value; }
            get { return s_num; }
        }    
        //班级
        public string s_Class
        {
            set { s_class = value; }
            get { return s_class; }
        }
        public string s_Phone
        {
            set { s_phone = value; }
            get { return s_phone; }
        }  
        //个人简介
        public string s_Content
        {
            set { s_content = value; }
            get { return s_content; }
        }
        #endregion Model
    }
}

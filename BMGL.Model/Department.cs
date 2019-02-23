using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMGL.Model
{
    public class Department
    {
        private int d_deptid;
        private string d_deptname;
        private string d_content;
        private string d_title;
        private string d_photo;
        private string d_abstact;
        //部门编号
        public int d_DeptId
        {
            set { d_deptid = value; }
            get { return d_deptid; }
        }
        //部门名称
        public string d_DeptName
        {
            set { d_deptname = value; }
            get { return d_deptname; }
        }
        //新闻活动
        public string d_Content
        {
            set { d_content = value; }
            get { return d_content; }
        }
        //新闻标题
        public string d_Title
        {
            set { d_title = value; }
            get { return d_title; }

        }
        //部徽
        public string d_Photo
        {
            set { d_photo = value; }
            get { return d_photo; }
        }
        //部门简介
        public string d_Abstact
        {
            set { d_abstact = value; }
            get { return d_abstact; }
        }
    }
}

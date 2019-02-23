using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMGL.Model;
using BMGL.DAL;

namespace BMGL.BLL
{
    public class StudentManager
    {
        private StudentService dal = new StudentService();

      
        public int Add(Student model)     //新增
        {

            //首先判断学号是否已存在
            Student entity = dal.GetModel(model.s_Num);

            if (entity != null)
            {
                return -1;    //学号已存在
            }
            else
            {
                return dal.Add(model);
            }
        }
        public int Update(Student model)      //更新
        {
            return dal.Update(model);
        }
        
        public int Delete(string d_DeptId)     // 删除
        {
            return dal.Delete(d_DeptId);
        }

        public Student GetModel(string userName)    // 得到一个对象实体
        {
            return dal.GetModel(userName);
        }
        public Student GetModel(int userId)    // 得到一个对象实体
        {
            return dal.GetModel(userId);
        }
        
        public List<Student> GetList()// 获得数据列表
        {
            return dal.GetList();
        }
        public List<Student> GetList(string s_Num)
        {
            return dal.GetList();
        }
        
        //public List<Student> GetList(string key, string value)
        //{
        //    return dal.GetList(key, value);
        //}

        //public List<Student> GetList(int pageIndex, int pageSize, out int totalCount, string s_Num)
        //{
        //    return dal.GetList(pageIndex, pageSize, out totalCount, s_Num);
        //}
    }
    
}

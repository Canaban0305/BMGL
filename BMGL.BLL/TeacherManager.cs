using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMGL.Model;
using BMGL.DAL;

namespace BMGL.BLL
{
    public class TeacherManager
    {
        private TeacherManager dal = new TeacherManager();

        public int Add(Teacher model)     //新增
        {
            return dal.Add(model);
        }
        public int Update(Teacher model)      //更新
        {
            return dal.Update(model);
        }

        public int Delete(string d_DeptId)     // 删除
        {
            return dal.Delete(d_DeptId);
        }

        public Teacher GetModel(string d_DeptId)    // 得到一个对象实体
        {
            return dal.GetModel(d_DeptId);
        }
        public List<Teacher> GetList()// 获得数据列表
        {
            return dal.GetList();
        }
        public List<Teacher> GetList(int d_DeptId)
        {
            return dal.GetList(d_DeptId);
        }

        public List<Teacher> GetList(string key, string value)
        {
            return dal.GetList(key, value);
        }

        public List<Teacher> GetList(int pageIndex, int pageSize, out int totalCount, int d_DeptId)
        {
            return dal.GetList(pageIndex, pageSize, out totalCount, d_DeptId);
        }
    }
}

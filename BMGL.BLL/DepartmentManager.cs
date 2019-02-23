using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMGL.Model;
using BMGL.DAL;

namespace BMGL.BLL
{
    public class DepartmentManager
    {
        private DepartmentService dal = new DepartmentService();

        public int Add(Department model)     //新增
        {

            //首先判断部门编号是否已存在
            Department entity = dal.GetModel(model.d_DeptName);

            if (entity != null)
            {
                return -1;    //编号已存在
            }
            else
            {
                return dal.Add(model);
            }
        }
        public int Update(Department model)      //更新
        {
            return dal.Update(model);
        }
        
        public int Delete(int d_DeptId)     // 删除
        {
            return dal.Delete(d_DeptId);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Department GetModel(string d_DeptName)
        {
            return dal.GetModel(d_DeptName);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Department> GetList()
        {
            return dal.GetList();
        }

        /// <summary>
        /// 根据条件模糊查询学生信息
        /// </summary>
        /// <param name="key">关键字</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        public List<Department> GetList(string key, string value)
        {
            return dal.GetList(key, value);
        }

        
        }
    }


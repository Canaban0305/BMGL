using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引入模型层
using BMGL.Model;
//引入ADO.NET命名空间
using System.Data;
using System.Data.SqlClient;
using BMGL.DAL;

namespace BMGL.DAL
{
    public class DepartmentService
    {
        //增加一条记录 Create
        public int Add(Department model)  //传入模型类对象
        {
            //1、构造SQL语句
            string sql = "insert into Department(d_DeptId,d_DeptName,d_Content,d_Title,d_Abstact) values(@d_DeptId,@d_DeptName,@d_Content,@d_Title,@d_Abstact)";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {
                                            new SqlParameter("@d_DeptId",model.d_DeptId),
                                            new SqlParameter("@d_DeptName",model.d_DeptName),
                                            new SqlParameter("@d_Title",model.d_Title),
                                            new SqlParameter("@d_Content",model.d_Content),
                                            new SqlParameter("@d_Abstact",model.d_Abstact)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        //删除一条记录 Delete
        public int Delete(int d_DeptId)
        {
            //1、构造SQL语句
            string sql = "delete from Department where d_DeptId = @d_DeptId";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {                                           
                                            new SqlParameter("@d_DeptId",d_DeptId)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        //查找记录 Retrieve
        public Department GetModel(int d_DeptId)  //根据用户编号获取用户对象
        {
            //1、构造SQL语句
            string sql = "select * from Department where d_DeptId = @d_DeptId";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {                                           
                                            new SqlParameter("@d_DeptId",d_DeptId)
                                        };
            //3、调用SqlHelper类中的方法
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, parameters);
            //判断数据集中是否有数据
            if (ds.Tables[0].Rows.Count > 0)  //执行查询语句后有数据返回
            {
                return Model(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        private Department Model(DataRow dataRow)
        {
            throw new NotImplementedException();
        }

        public Department GetModel(string d_DeptName)  //根据用户名称获取用户对象
        {
            //1、构造SQL语句
            string sql = "select * from Department where d_DeptName = @d_DeptName";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {                                           
                                            new SqlParameter("@d_DeptName",d_DeptName)
                                        };
            //3、调用SqlHelper类中的方法
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, parameters);
            //判断数据集中是否有数据
            if (ds.Tables[0].Rows.Count > 0)  //执行查询语句后有数据返回
            {
                return Model(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        public List<Department> GetList()  //获取所有的用户列表
        {
            //1、构造SQL语句
            string sql = "select * from Department";

            //3、调用SqlHelper类中的方法
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, null);
            DataTable dt = ds.Tables[0];
            //构造集合
            List<Department> list = null;
            //判断数据集中是否有数据
            if (dt.Rows.Count > 0)
            {
                list = new List<Department>();
                //循环遍历表中的所有行
                foreach (DataRow dr in dt.Rows)
                {
                    //数据行转换为类的实例
                    Department model = Model(dr);
                    //添加到列表中
                    //list.Add(model);
                }
            }
            return list;
        }

        public List<Department> GetList(int d_DeptId)
        {
            string sql = "select * from Department where d_DeptId = @d_DeptId";
            SqlParameter[] parameters = {
					new SqlParameter("@d_DeptId", d_DeptId)			
            };
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, parameters);
            DataTable dt = ds.Tables[0];
            List<Department> list = null;
            if (dt.Rows.Count > 0)
            {
                list = new List<Department>();
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(DataRowToModel(dr));
                }
            }
            return list;
        }




        //用于将数据行转换为类的实例
        private Department DataRowToModel(DataRow row)
        {
            //再次判断数据行是否为空
            if (row != null)
            {
                //创建实体对象
                Department model = new Department();
                if (row["d_DeptId"] != null)
                {
                    model.d_DeptId = (int)row["d_DeptId"];
                }
                if (row["d_DeptName"] != null)
                {
                    model.d_DeptName = row["d_DeptName"].ToString();
                }
                if (row["d_Abstact"] != null)
                {
                    model.d_Abstact = row["d_Abstact"].ToString();
                }
                if (row["d_Content"] != null)
                {
                    model.d_Content = row["d_Content"].ToString();
                }
                if (row["d_Title"] != null)
                {
                    model.d_Title = row["d_Title"].ToString();
                }
                //返回对象
                return model;
            }
            else
            {
                return null;
            }
        }

        public List<Department> GetList(string key, string value)
        {
            string sql = "select * from Department";
            SqlParameter[] parameters = null;
            if (key == "编号")
            {
                sql += " where d_DeptId like + '%' + @d_DeptId+ '%'";
                parameters = new SqlParameter[]{
					new SqlParameter("@d_DeptId", value)	
                };
            };
            if (key == "名字")
            {
                sql += " where d_DeptName like + '%' + @d_DeptName+ '%'";
                parameters = new SqlParameter[]{
					new SqlParameter("@d_DeptName", value)		
                };
            };
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, parameters);
            DataTable dt = ds.Tables[0];
            List<Department> list = null;
            if (dt.Rows.Count > 0)
            {
                list = new List<Department>();
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(DataRowToModel(dr));
                }
            }
            return list;
        }


        //修改记录 Update
        public int Update(Department model)
        {
            //1、构造SQL语句
            string sql = "update Department set d_DeptName = @d_DeptName, d_Abstact = @d_Abstact, d_Location = @d_Location where d_DeptId = @d_DeptId";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {
                                            new SqlParameter("@d_DeptId",model.d_DeptId),
                                            new SqlParameter("@d_DeptName",model.d_DeptName),
                                            new SqlParameter("@d_Content",model.d_Content),
                                            new SqlParameter("@d_Title",model.d_Title),
                                            new SqlParameter("@d_Abstact",model.d_Abstact)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
    }
}

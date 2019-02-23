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
    public class TeacherService
    {
        //增加一条记录 Create
        public int Add(Teacher model)  //传入模型类对象
        {
            //1、构造SQL语句
            string sql = "insert into Teacher(t_ID,t_Name,t_Pwd,Status,t_IDCard) values(@t_ID,@t_Name,@t_Pwd,@Status,@t_IDCard)";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {
                                            new SqlParameter("@t_ID",model.t_ID),
                                            new SqlParameter("@t_Name",model.t_Name),
                                            new SqlParameter("@t_Pwd",model.t_Pwd),
                                            new SqlParameter("@Status",model.Status),
                                            new SqlParameter("@t_IDCard",model.t_IDCard)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        //删除一条记录 Delete
        public int Delete(int d_DeptId)
        {
            //1、构造SQL语句
            string sql = "delete from Teacher where d_DeptId = @d_DeptId";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {                                           
                                            new SqlParameter("@d_DeptId",d_DeptId)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        //查找记录 Retrieve
        public Teacher GetModel(int d_DeptId)  //根据用户编号获取用户对象
        {
            //1、构造SQL语句
            string sql = "select * from Teacher where d_DeptId = @d_DeptId";
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

        private Teacher Model(DataRow dataRow)
        {
            throw new NotImplementedException();
        }

        public Teacher GetModel(string d_Name)  //根据用户名称获取用户对象
        {
            //1、构造SQL语句
            string sql = "select * from Teacher where d_Name = @d_Name";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {                                           
                                            new SqlParameter("@d_Name",d_Name)
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


        public List<Teacher> GetList()  //获取所有的用户列表
        {
            //1、构造SQL语句
            string sql = "select * from Teacher";

            //3、调用SqlHelper类中的方法
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, null);
            DataTable dt = ds.Tables[0];
            //构造集合
            List<Teacher> list = null;
            //判断数据集中是否有数据
            if (dt.Rows.Count > 0)
            {
                list = new List<Teacher>();
                //循环遍历表中的所有行
                foreach (DataRow dr in dt.Rows)
                {
                    //数据行转换为类的实例
                    Teacher model = Model(dr); ;
                    //添加到列表中
                    list.Add(model);
                }
            }
            return list;
        }


        //用于将数据行转换为类的实例
        private Teacher DataRowToModel(DataRow row)
        {
            //再次判断数据行是否为空
            if (row != null)
            {
                //创建实体对象
                Teacher model = new Teacher();
                if (row["t_ID"] != null)
                {
                    model.t_ID = (string)row["t_ID"];
                }
                if (row["t_Name"] != null)
                {
                    model.t_Name = row["t_Name"].ToString();
                }
                if (row["t_Pwd"] != null)
                {
                    model.t_Pwd = row["t_Pwd"].ToString();
                }
                if (row["Status"] != null)
                {
                    model.Status = (int)row["Status"];
                }
                if (row["t_IDCard"] != null)
                {
                    model.t_IDCard = (string)row["t_IDCard"];
                }
                //返回对象
                return model;
            }
            else
            {
                return null;
            }
        }
        //修改记录 Update
        public int Update(Teacher model)
        {
            //1、构造SQL语句
            string sql = "update Teacher set t_ID = @t_ID, t_Name = @t_Name, t_Pwd = @t_Pwd Status = @Status where t_IDCard = @t_IDCard";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {
                                            new SqlParameter("@t_ID",model.t_ID),
                                            new SqlParameter("@t_Name",model.t_Name),
                                            new SqlParameter("@t_Pwd",model.t_Pwd),
                                            new SqlParameter("@Status",model.Status),
                                            new SqlParameter("@t_IDCard",model.t_IDCard)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
    }
}

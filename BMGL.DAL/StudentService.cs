using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//引入模型层
using BMGL.Model;
//引入ADO.NET命名空间
using System.Data;
using System.Data.SqlClient;

namespace BMGL.DAL
{
    public class StudentService
    {
        //增加一条记录 Create
        public int Add(Student model)  //传入模型类对象
        {
            //1、构造SQL语句
            string sql = "insert into Student(s_Name,s_Post,s_Num,s_Content,s_Class,s_Phone) values(@s_Name, @s_Post, @s_Num,@s_Content,@s_Class,@s_Phone)";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {
                                            new SqlParameter("@s_Name",model.s_Name),
                                            new SqlParameter("@s_Post",model.s_Post),
                                            new SqlParameter("@s_Num",model.s_Num),
                                            new SqlParameter("@s_Content",model.s_Content),
                                            new SqlParameter("@s_Class",model.s_Class),
                                             new SqlParameter("@d_DeptId",model.s_Phone)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        //删除一条记录 Delete
        public int Delete(string s_Num)
        {
            //1、构造SQL语句
            string sql = "delete from Student where s_Num = @s_Num";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {                                           
                                            new SqlParameter("@s_Num",s_Num)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        //查找记录 Retrieve
        public Student GetModel(int UserId)  //根据用户编号获取用户对象
        {
            //1、构造SQL语句
            string sql = "select * from Student where UserId = @UserId";
            //2、构造SQL参数集合
            //string s_num = UserId.ToString();
            SqlParameter[] parameters = {                                           
                                            new SqlParameter("@UserId",UserId)
                                        };
            //3、调用SqlHelper类中的方法
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, parameters);
            //判断数据集中是否有数据
            if (ds.Tables[0].Rows.Count > 0)  //执行查询语句后有数据返回
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public Student GetModel(string s_Name)  //根据用户名称获取用户对象
        {
            //1、构造SQL语句
            string sql = "select * from Student where s_Name = @s_Name";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {                                           
                                            new SqlParameter("@s_Name",s_Name)
                                        };
            //3、调用SqlHelper类中的方法
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, parameters);
            //判断数据集中是否有数据
            if (ds.Tables[0].Rows.Count > 0)  //执行查询语句后有数据返回
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        public List<Student> GetList()  //获取所有的用户列表
        {
            //1、构造SQL语句
            string sql = "select * from Student";

            //3、调用SqlHelper类中的方法
            DataSet ds = SqlHelper.ExecuteDataset(sql, CommandType.Text, null);
            DataTable dt = ds.Tables[0];
            //构造集合
            List<Student> list = null;
            //判断数据集中是否有数据
            if (dt.Rows.Count > 0)
            {
                list = new List<Student>();
                //循环遍历表中的所有行
                foreach (DataRow dr in dt.Rows)
                {
                    //数据行转换为类的实例
                    Student model = DataRowToModel(dr); ;
                    //添加到列表中
                    list.Add(model);
                }
            }
            return list;
        }


        //用于将数据行转换为类的实例
        private Student DataRowToModel(DataRow row)
        {
            //再次判断数据行是否为空
            if (row != null)
            {
                //创建实体对象
                Student model = new Student();
                if (row["d_DeptId"] != null)
                {
                    model.d_DeptId = (int)row["d_DeptId"];
                }
                if (row["s_Name"] != null)
                {
                    model.s_Name = row["s_Name"].ToString();
                }
                if (row["s_Post"] != null)
                {
                    model.s_Post = row["s_Post"].ToString();
                }
                if (row["s_Num"] != null)
                {
                    model.s_Num = row["s_Num"].ToString();
                }
                if (row["s_Class"] != null)
                {
                    model.s_Class = row["s_Class"].ToString();
                }
                if (row["s_Phone"] != null)
                {
                    model.s_Phone = row["s_Phone"].ToString();
                }
                if (row["s_Content"] != null)
                {
                    model.s_Content = row["s_Content"].ToString();
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
        public int Update(Student model)
        {
            //1、构造SQL语句
            string sql = "update Student set s_Name = @s_Name, s_Post = @s_Post, s_Num = @s_Num, s_Class = @s_Class, s_Phone = @s_Phone where s_Content = @s_Content";
            //2、构造SQL参数集合
            SqlParameter[] parameters = {
                                            
                                            new SqlParameter("@s_Name",model.s_Name),
                                            new SqlParameter("@s_Post",model.s_Post),
                                            new SqlParameter("@s_Num",model.s_Num),
                                            new SqlParameter("@s_Class",model.s_Class),
                                            new SqlParameter("@s_Phone",model.s_Phone),
                                            new SqlParameter("@s_Content",model.s_Content)
                                        };
            //3、调用SqlHelper类中的方法
            return SqlHelper.ExecuteNonQuery(sql, CommandType.Text, parameters);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace BMGL.UI
{
    /// <summary>
    /// ValidateCode 的摘要说明
    /// </summary>
    public class ValidateCode : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {
        private string GetVcode(int cou)
        {
            //实例化           
            Random r = new Random();
            //定义返回字符串
            string code = string.Empty;
            //定义字符串组
            string str = "0123456789abcdefghijkmnpqrstuvwxyzABCDEFGHIJKLMNPQRSTUVWXYZ";
            //循环遍历
            for (int i = 0; i < cou; i++)
            {
                //随机获取索引
                int index = r.Next(str.Length);
                code += str[index];
            }
            //返回随机字符串
            return code;
        }

        public void ProcessRequest(HttpContext context)
        {
            //调用方法
            string vcode = GetVcode(4);

            // 将验证码保存到session
            context.Session["ValidateCode"] = vcode;
            int width = (int)(vcode.Length * 12.5);

            using (Image img = new Bitmap(width, 20))
            {
                using (Graphics g = Graphics.FromImage(img))
                {
                    g.Clear(Color.White);

                    g.DrawRectangle(Pens.Red, 0, 0, width, 20);

                    Font f = new Font("黑体", 13, FontStyle.Bold);

                    g.DrawString(vcode, f, Brushes.Red, 0, 0);

                }
                img.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
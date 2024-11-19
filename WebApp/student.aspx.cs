using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //窗体加载时即调用查询按钮的单击时间展示学生信息
            this.ButtonQuery_Click(this.ButtonQuery,e);
        }

        protected void ButtonQuery_Click(object sender, EventArgs e)
        {
            string sno = this.TextBoxSNO.Text.Trim();//学号
            string sname = this.TextBoxSName.Text.Trim();//学号

            studentMS.BLL.core bll = new studentMS.BLL.core();//实例化BLL层
            this.GridView1.DataSource = bll.GetList_student(sno, sname).Tables[0];//设置数据源

            //数据绑定
            this.GridView1.DataBind();
        }
    }
}
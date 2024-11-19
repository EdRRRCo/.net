using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class FormCourseEdit : Form
    {
        private string _cno = "";//保存学院代码

        /// <summary>
        /// 课程编码
        /// </summary>
        public string DeptNO
        {
            set { _cno = value; }
            get { return _cno; }
        }
        public FormCourseEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="cno">课程编码</param>
        public FormCourseEdit(string cno)
        {
            InitializeComponent();
            _cno = cno;//接受参数并保存到当前类中
        }

        private void buttonYES_Click(object sender, EventArgs e)
        {
            //1)数据校验
            string strException = "";
            if (this.textBoxCNO.Text.Trim() == "")
                strException += "课程编码不能为空!\n";
            if (this.textBoxCName.Text.Trim() == "")
                strException += "课程名称不能为空!\n";
            if (strException != "")
            {
                MessageBox.Show(this, strException, "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //2)从界面获取数据保存到model
            studentMS.Model.course model = new studentMS.Model.course();//实例化model
            model.CNO = this.textBoxCNO.Text.Trim();
            model.CName = this.textBoxCName.Text.Trim();


            //3)调用BLL层的方法把model中的数据提交到数据库
            studentMS.BLL.course bll = new studentMS.BLL.course();//实例化BLL
            try
            {
                //判断并提交数据到数据库
                if (_cno == "")
                {
                    bll.Add(model);//新增
                }
                else
                {
                    bll.Update(model);//修改更新
                }
                _cno = model.CNO;//更新属性的值

                this.DialogResult = DialogResult.OK;//弹出窗体的返回值
            }
            catch (Exception ex)
            {
                string str = _dno == "" ? "新增" : "修改";
                /*string str = "新增";
                if(_sno != "")
                {
                    str = "修改";
                }*/
                MessageBox.Show(this, str + "学院档案信息失败！\n" + ex.Message, "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

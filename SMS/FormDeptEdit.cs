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
    public partial class FormDeptEdit : Form
    {
        private string _dno = "";//保存学院代码

        /// <summary>
        /// 学院代码
        /// </summary>
        public string DeptNO
        {
            set { _dno = value; }
            get { return _dno; }
        }
        public FormDeptEdit()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="dno">学院代码</param>
        public FormDeptEdit(string dno)
        {
            InitializeComponent();
            _dno = dno;//接受参数并保存到当前类中
        }

        private void buttonYES_Click(object sender, EventArgs e)
        {
            //1)数据校验
            string strException = "";
            if (this.textBoxDeptNO.Text.Trim() == "")
                strException += "学院代码不能为空!\n";
            if (this.textBoxDeptName.Text.Trim() == "")
                strException += "学院名称不能为空!\n";
            if (strException != "")
            {
                MessageBox.Show(this, strException, "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //2)从界面获取数据保存到model
            studentMS.Model.department model = new studentMS.Model.department();//实例化model
            model.DeptNO = this.textBoxDeptNO.Text.Trim();
            model.DeptName = this.textBoxDeptName.Text.Trim();

            //3)调用BLL层的方法把model中的数据提交到数据库
            studentMS.BLL.department bll = new studentMS.BLL.department();//实例化BLL
            try
            {
                //判断并提交数据到数据库
                if (_dno == "")
                {
                    bll.Add(model);//新增
                }
                else
                {
                    bll.Update(model);//修改更新
                }
                _dno = model.DeptNO;//更新属性的值

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDeptEdit_Load(object sender, EventArgs e)
        {
            if (_dno == "")//新增
            {
                this.Text = "新增学院档案信息";
            }
            else//修改
            {
                this.Text = "修改学院档案信息";//动态修改窗体标题

                //依据学院代码号_dno从数据库中获取当前的值并展示到界面中
                studentMS.BLL.department bll = new studentMS.BLL.department();//实例化BLL层中的department类
                studentMS.Model.department model = bll.GetModel(_dno);//依据_dno获取学院档案的明细并保存到model
                if (model != null)//在界面上展示数据
                {
                    this.textBoxDeptNO.Text = model.DeptNO;
                    this.textBoxDeptName.Text = model.DeptName;
                }
            }
        }
    }
}

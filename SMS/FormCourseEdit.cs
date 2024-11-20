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
        private string _cno = "";//保存课程编码

        /// <summary>
        /// 课程编码
        /// </summary>
        public string CNO
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
            model.Credit = Convert.ToDecimal(this.comboBox1.SelectedItem);


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
                string str = _cno == "" ? "新增" : "修改";
                /*string str = "新增";
                if(_sno != "")
                {
                    str = "修改";
                }*/
                MessageBox.Show(this, str + "课程信息失败！\n" + ex.Message, "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FormCourseEdit_Load(object sender, EventArgs e)
        {
            //初始化学分下拉框
            studentMS.BLL.course bllCourse = new studentMS.BLL.course();//实例化
            this.comboBox1.DataSource = bllCourse.GetAllList().Tables[0];//设置ComboBox的数据源
            this.comboBox1.DisplayMember = "Credit";//展示的文本所对应的数据库中的列名
            this.comboBox1.ValueMember = "Credit";//下拉框对应的值

            if (_cno == "")//新增
            {
                this.Text = "新增课程信息";
            }
            else//修改
            {
                this.Text = "修改课程信息";//动态修改窗体标题
                this.textBoxCNO.ReadOnly = true;//课程编号不能修改

                //依据课程编号_cno从数据库中获取当前的值并展示到界面中
                studentMS.BLL.course bll = new studentMS.BLL.course();//实例化BLL层中的course类
                studentMS.Model.course model = bll.GetModel(_cno);//依据_cno获取课程信息明细并保存到model
                if (model != null)//在界面上展示数据
                {
                    this.textBoxCNO.Text = model.CNO;
                    this.textBoxCName.Text = model.CName;
                    this.comboBox1.SelectedValue = model.Credit.ToString();
                }
            }
        }
    }
}

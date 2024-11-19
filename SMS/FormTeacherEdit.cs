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
    public partial class FormTeacherEdit : Form
    {

        private string _tno = "";//保存学号
        /// <summary>
        /// 学号
        /// </summary>
        public string TNO
        {
            set { _tno = value; }
            get { return _tno; }
        }
        public FormTeacherEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="s\tno">工号</param>
        public FormTeacherEdit(string tno)
        {
            InitializeComponent();
            _tno = tno;//接受参数并保存到当前类中
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //1)数据校验
            string strException = "";
            if (this.textBoxTNO.Text.Trim() == "")
                strException += "工号不能为空!\n";
            if (this.textBoxTName.Text.Trim() == "")
                strException += "姓名不能为空!\n";
            if (this.textBoxAddress.Text.Trim() == "")
                strException += "地址不能为空!\n";
            if (strException != "")
            {
                MessageBox.Show(this, strException, "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //2)从界面获取数据保存到model
            studentMS.Model.teacher model = new studentMS.Model.teacher();//实例化model
            model.TNO = this.textBoxTNO.Text.Trim();
            model.TName = this.textBoxTName.Text.Trim();
            if (this.Male.Checked)
                model.TSex = "男";
            else
                model.TSex = "女";
            model.Address = this.textBoxAddress.Text.Trim();
            model.Tel = this.textBoxTel.Text.Trim();
            model.Tstatus = this.textBoxTstatus.Text.Trim();

            //3)调用BLL层的方法把model中的数据提交到数据库
            studentMS.BLL.teacher bll = new studentMS.BLL.teacher();//实例化BLL
            try
            {
                //判断并提交数据到数据库
                if (_tno == "")
                {
                    bll.Add(model);//新增
                }
                else
                {
                    bll.Update(model);//修改更新
                }
                _tno = model.TNO;//更新属性的值

                this.DialogResult = DialogResult.OK;//弹出窗体的返回值
            }
            catch (Exception ex)
            {
                string str = _tno == "" ? "新增" : "修改";
                /*string str = "新增";
                if(_sno != "")
                {
                    str = "修改";
                }*/
                MessageBox.Show(this, str + "教工档案信息失败！\n" + ex.Message, "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTeacherEdit_Load(object sender, EventArgs e)
        {
            if (_tno == "")//新增
            {
                this.Text = "新增教工档案信息";
            }
            else//修改
            {
                this.Text = "修改教工档案信息";//动态修改窗体标题
                this.textBoxTNO.ReadOnly = true;//工号不能修改

                //依据学号_sno从数据库中获取当前的值并展示到界面中
                studentMS.BLL.teacher bll = new studentMS.BLL.teacher();//实例化BLL层中的teacher类
                studentMS.Model.teacher model = bll.GetModel(_tno);//依据_tno获取教工档案的明细并保存到model
                if (model != null)//在界面上展示数据
                {
                    this.textBoxTNO.Text = model.TNO;
                    this.textBoxTName.Text = model.TName;
                    this.textBoxTel.Text = model.Tel;
                    this.textBoxAddress.Text = model.Address;
                    this.textBoxTstatus.Text = model.Tstatus;
                    if (model.TSex == "男")
                        this.Male.Checked = true;
                    else
                        this.Female.Checked = true;
                }
            }
        }
    }
}

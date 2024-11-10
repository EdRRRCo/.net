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
    public partial class FormStudentEdit : Form
    {
        private string _sno="";//保存学号
        /// <summary>
        /// 学号
        /// </summary>
        public string SNO
        {
            set { _sno = value; }
            get { return _sno; }
        }

        public FormStudentEdit()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="sno">学号</param>
        public FormStudentEdit(string sno)
        {
            InitializeComponent();
            _sno = sno;//接受参数并保存到当前类中
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            //1)数据校验
            string strException = "";
            if (this.textBoxSNO.Text.Trim() == "")
                strException += "学号不能为空!\n";
            if (this.textBoxSName.Text.Trim() == "")
                strException += "姓名不能为空!\n";
            if (this.textBoxAddress.Text.Trim() == "")
                strException += "地址不能为空!\n";
            if(strException !="")
            {
                MessageBox.Show(this, strException, "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //2)从界面获取数据保存到model
            studentMS.Model.student model = new studentMS.Model.student();//实例化model
            model.SNO = this.textBoxSNO.Text.Trim();
            model.SName = this.textBoxSName.Text.Trim();
            if (this.Male.Checked)
                model.SSex = "男";
            else
                model.SSex = "女";
            model.SBirthday = this.dateTimePickerBirthday.Value;//日期类型
            model.DeptNO = this.comboBoxDept.SelectedValue.ToString();
            model.Address = this.textBoxAddress.Text.Trim();

            //3)调用BLL层的方法把model中的数据提交到数据库
            studentMS.BLL.student bll = new studentMS.BLL.student();//实例化BLL
            try
            {
                //判断并提交数据到数据库
                if(_sno == "")
                {
                    bll.Add(model);//新增
                }
                else
                {
                    bll.Update(model);//修改更新
                }
                _sno = model.SNO;//更新属性的值

                this.DialogResult = DialogResult.OK;//弹出窗体的返回值
            }
            catch(Exception ex)
            {
                string str = _sno == "" ? "新增" : "修改";
                /*string str = "新增";
                if(_sno != "")
                {
                    str = "修改";
                }*/
                MessageBox.Show(this, str + "学生档案信息失败！\n" + ex.Message, "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        private void FormStudentEdit_Load(object sender, EventArgs e)
        {
            //初始化院系下拉框
            studentMS.BLL.department bllDept = new studentMS.BLL.department();//实例化
            this.comboBoxDept.DataSource = bllDept.GetAllList().Tables[0];//设置ComboBox的数据源
            this.comboBoxDept.DisplayMember = "DeptName";//展示的文本所对应的数据库中的列名
            this.comboBoxDept.ValueMember = "DeptNO";//下拉框对应的值

            if( _sno == "")//新增
            {
                this.Text = "新增学生档案信息";
            }else//修改
            {
                this.Text = "修改学生档案信息";//动态修改窗体标题
                this.textBoxSNO.ReadOnly = true;//学号不能修改

                //依据学号_sno从数据库中获取当前的值并展示到界面中
                studentMS.BLL.student bll = new studentMS.BLL.student();//实例化BLL层中的student类
                studentMS.Model.student model = bll.GetModel(_sno);//依据_sno获取学生档案的明细并保存到model
                if(model != null)//在界面上展示数据
                {
                    this.textBoxSNO.Text = model.SNO;
                    this.textBoxSName.Text = model.SName;
                    this.comboBoxDept.SelectedValue = model.DeptNO.ToString();
                    this.textBoxAddress.Text = model.Address;
                    try
                    {
                        this.dateTimePickerBirthday.Value = model.SBirthday.Value;
                    
                    }catch
                    {

                    }
                    if (model.SSex == "男")
                        this.Male.Checked = true;
                    else
                        this.Female.Checked = true;
                }
            }
        }
    }
}

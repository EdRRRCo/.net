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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string strError = "";
            if (this.textBoxUID.Text.Trim() == "")
                strError += "用户名不能为空！\n";
            if(this.textBoxUCode.Text.Trim()=="")
                strError += "密码不能为空！\n";
            
            if(strError != "")
            {
                MessageBox.Show(this, strError, "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            studentMS.BLL.core core = new studentMS.BLL.core();//实例化BLL层
            if (core.ExistUIDUCode(this.textBoxUID.Text.Trim(), this.textBoxUCode.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;//设置窗体返回值
                this.Close();//关闭登录界面并释放资源
            }
            else
            {
                MessageBox.Show(this, "用户名或者密码输入错误", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.textBoxUID.Select();//把焦点放在用户名编辑框
        }
    }
}

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
        public FormStudentEdit()
        {
            InitializeComponent();
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            //数据校验
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

            //从界面获取数据保存到model
            studentMS.Model.student model = new studentMS.Model.student();//实例化model
            model.SNO = this.textBoxSNO.Text.Trim();
            model.SName = this.textBoxSName.Text.Trim();
            if (this.Male.Checked)
                model.SSex = "男";
            else
                model.SSex = "女";
            model.SBirthday = this.dateTimePickerBirthday.Value;//日期类型
            model.DeptNO = this.textBoxDeptNO.Text.Trim();
            model.Address = this.Text.Trim();

            //调用BLL层的方法把model中的数据提交到数据库

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }
    }
}

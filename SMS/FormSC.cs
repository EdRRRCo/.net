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
    public partial class FormSC : Form
    {
        public FormSC()
        {
            InitializeComponent();
        }

        private void buttonQueryStu_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();//实例化BLL层的对象
            this.dataGridViewStu.DataSource = bll.GetList_student(this.textBoxSNO.Text.Trim(), this.textBoxSName.Text.Trim()).Tables[0].DefaultView;
        }
    }
}

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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            //调用core中的方法获取数据并赋给DataGridView1
            this.dataGridView1.DataSource = new studentMS.BLL.core().GetList_User(this.textBoxUID.Text.Trim()).Tables[0].DefaultView;
        }
    }
}

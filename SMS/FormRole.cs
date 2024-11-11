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
    public partial class FormRole : Form
    {
        public FormRole()
        {
            InitializeComponent();
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            //显示当前系统所有角色信息
            this.dataGridViewRole.DataSource = new studentMS.BLL.b_role().GetAllList().Tables[0].DefaultView;
        }
    }
}

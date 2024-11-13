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

        private void toolStripMenuItemSet_Click(object sender, EventArgs e)
        {
            //获取当前记录的RoleID和RoleName
            string roleid = this.dataGridViewRole.CurrentRow.Cells["RoleID"].Value.ToString();
            string rolename = this.dataGridViewRole.CurrentRow.Cells["RoleName"].Value.ToString();
            FormRoleRight temp = new FormRoleRight(roleid,rolename);
            temp.ShowDialog();//以对话框的方式展示

            if(temp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(this, "权限更新成功！", "系统提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

        }
    }
}

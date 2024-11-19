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
    public partial class FormCourse : Form
    {
        private bool rightAdd, rightDelete, rightEdit;//权限控制

        public FormCourse()
        {
            InitializeComponent();
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            //新增
            FormCourseEdit temp = new FormCourseEdit();//实例化
            temp.ShowDialog();//调用方法ShowDialog以对话框的方式输出

            if (temp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(this, "新增学院档案成功！\n", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.buttonQuery_Click(this.buttonQuery, e);//调用查询按钮的单击事件来刷新数据显示
                this.DataGridViewRelocation(this.dataGridView1, "DeptNO", temp.DeptNO);//刷新后重新定位
                return;
            }
        }

        /// <summary>
        /// 依据关键字和他的值在DataGridView中定位记录
        /// </summary>
        /// <param name="dataGrid">DataGridVIew</param>
        /// <param name="keyName">定位的关键字段</param>
        /// <param name="keyValue">定位的值</param>
        private void DataGridViewRelocation(DataGridView dataGrid, string keyName, string keyValue)
        {
            if (dataGrid == null || keyName == null || keyValue == null || keyValue == "")
                return;
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (dataGrid.Rows[i].Cells[keyName].Value.ToString() == keyValue)
                {
                    dataGrid.ClearSelection();//清空选择
                    dataGrid.Rows[i].Selected = true;
                    dataGrid.FirstDisplayedScrollingRowIndex = i;//自动滚动记录到所定位的记录所在屏
                    break;
                }
            }
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridView1.DataSource = bll.GetList_Course(this.textBoxCNO.Text.Trim(), this.textBoxCName.Text.Trim()).Tables[0].DefaultView;
        }




    }
}

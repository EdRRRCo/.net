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
    public partial class FormTeacher : Form
    {
        private bool rightAdd, rightDelete, rightEdit;//权限控制

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

        public FormTeacher()
        {
            InitializeComponent();
        }



        private void buttonQuery_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridView1.DataSource = bll.GetList_Teacher(this.textBoxTNO.Text.Trim(), this.textBoxTName.Text.Trim()).Tables[0].DefaultView;
        }

        private void MenuItemDel_Click(object sender, EventArgs e)
        {
            //删除
            //删除确认提示框
            if (MessageBox.Show(this, "您确定要删除您所选中的记录吗？\n", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //从数据库中删除记录
                studentMS.BLL.core bll = new studentMS.BLL.core();//实例化BLL层中的core类

                //获取dataGridView1中选中的工号tno
                string tno = this.dataGridView1.SelectedRows[0].Cells["TNO"].Value.ToString();

                // 检查是否可以删除
                if (!bll.CanDeleteTeacher(tno))
                {
                    MessageBox.Show(this, "该教师存在相关授课记录，无法删除！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    bll.DeleteTeacher(tno);//物理删除
                    MessageBox.Show(this, "删除成功！\n", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.buttonQuery_Click(this.buttonQuery, e);//调用查询功能实现刷新数据显示
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "删除失败!\n" + ex.Message, "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.X >= 0 && e.Y >= 0)//校验是否按下鼠标右键以及鼠标坐标在dataGridView的内部
            {
                this.dataGridView1.ClearSelection();//清空所有的选择
                //this.dataGridViewStu.CurrentRow.Selected = false;//清除当前选中的行
                this.dataGridView1.Rows[e.RowIndex].Selected = true;//选中当前鼠标所在行
            }
            else
            {
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //设置弹出类菜单的可用性
            this.MenuItemEdit.Enabled = this.dataGridView1.Rows.Count > 0 && rightEdit;//修改
            this.MenuItemDel.Enabled = this.dataGridView1.Rows.Count > 0 && rightDelete;//删除
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            studentMS.BLL.core core = new studentMS.BLL.core();//实例化BLL层

            //判断当前登录用户是否拥有教师档案（增删改）的三项权限
            rightAdd = core.haveRight("2301");
            rightDelete = core.haveRight("2303");
            rightEdit = core.haveRight("2302");

            this.MenuItemAdd.Enabled = rightAdd;//新增
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            //新增
            FormTeacherEdit temp = new FormTeacherEdit();//实例化
            temp.ShowDialog();//调用方法ShowDialog以对话框的方式输出

            if (temp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(this, "新增教师档案成功！\n", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.buttonQuery_Click(this.buttonQuery, e);//调用查询按钮的单击事件来刷新数据显示
                this.DataGridViewRelocation(this.dataGridView1, "TNO", temp.TNO);//刷新后重新定位
                return;
            }
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            //修改
            //获取dataGridView1中当前所选中的记录的工号并保存到tno中
            //索引超出范围，数组才会出现的错误，dataGridView1的seclectionMode改为整行选择
            string tno = this.dataGridView1.SelectedRows[0].Cells["TNO"].Value.ToString();


            FormTeacherEdit temp = new FormTeacherEdit(tno);//实例化，需要传参数
            temp.ShowDialog();//调用方法ShowDialog以对话框的方式输出

            if (temp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(this, "修改教师档案信息成功！\n", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.buttonQuery_Click(this.buttonQuery, e);//调用查询按钮的单击事件来刷新数据显示
                this.DataGridViewRelocation(this.dataGridView1, "TNO", tno);//数据刷新后选中项重新定位
                return;
            }
        }




    }
}

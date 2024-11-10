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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();//实例化BLL层的对象
            this.dataGridViewStu.DataSource = bll.GetList_student(this.textBoxSNO.Text.Trim(),this.textBoxSName.Text.Trim()).Tables[0].DefaultView;
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            //新增
            FormStudentEdit temp = new FormStudentEdit();//实例化
            temp.ShowDialog();//调用方法ShowDialog以对话框的方式输出

            if(temp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(this, "新增学生档案成功！\n", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.buttonQuery_Click(this.buttonQueryStu, e);//调用查询按钮的单击事件来刷新数据显示
                this.DataGridViewRelocation(this.dataGridViewStu,"SNO",temp.SNO);//刷新后重新定位
                return;
            }
        }

        private void ToolStripMenuItemStuEdit_Click(object sender, EventArgs e)
        {
            //修改
            //获取dataGridViewStu中当前所选中的记录的学号并保存到sno中
            //索引超出范围，数组才会出现的错误，dataGridViewStu的seclectionMode改为整行选择
            string sno = this.dataGridViewStu.SelectedRows[0].Cells["SNO"].Value.ToString();
            

            FormStudentEdit temp = new FormStudentEdit(sno);//实例化，需要传参数
            temp.ShowDialog();//调用方法ShowDialog以对话框的方式输出

            if (temp.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(this, "修改学生档案信息成功！\n", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.buttonQuery_Click(this.buttonQueryStu, e);//调用查询按钮的单击事件来刷新数据显示
                this.DataGridViewRelocation(this.dataGridViewStu, "SNO", sno);//数据刷新后选中项重新定位
                return;
            }
        }

        private void ToolStripMenuItemStuDel_Click(object sender, EventArgs e)
        {
            //删除
            //删除确认提示框
            if(MessageBox.Show(this,"您确定要删除您所选中的记录吗？\n","删除确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                //从数据库中删除记录
                studentMS.BLL.student bll = new studentMS.BLL.student();//实例化BLL层中的student类

                //获取dataGridViewStu中选中的学号sno
                string sno = this.dataGridViewStu.SelectedRows[0].Cells["SNO"].Value.ToString();
                try
                {
                    bll.Delete(sno);//物理删除
                    MessageBox.Show(this, "删除成功！\n", "友情提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.buttonQuery_Click(this.buttonQueryStu, e);//调用查询功能实现刷新数据显示
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, "删除失败!\n" + ex.Message, "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dataGridViewStu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //设置弹出类菜单的可用性
            this.MenuItemStuAdd.Enabled = true;//新增
            this.MenuItemStuEdit.Enabled = this.dataGridViewStu.Rows.Count > 0;//修改
            this.MenuItemStuDel.Enabled = this.dataGridViewStu.Rows.Count > 0;//删除
        }



        private void dataGridViewStu_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.X >= 0 && e.Y >= 0)//校验是否按下鼠标右键以及鼠标坐标在dataGridView的内部
            {
                this.dataGridViewStu.ClearSelection();//清空所有的选择
                //this.dataGridViewStu.CurrentRow.Selected = false;//清除当前选中的行
                this.dataGridViewStu.Rows[e.RowIndex].Selected = true;//选中当前鼠标所在行
            }
            else
            {
            }
        }

        /// <summary>
        /// 依据关键字和他的值在DataGridView中定位记录
        /// </summary>
        /// <param name="dataGrid">DataGridVIew</param>
        /// <param name="keyName">定位的关键字段</param>
        /// <param name="keyValue">定位的值</param>
        private void DataGridViewRelocation(DataGridView dataGrid, string keyName,string keyValue)
        {
            if(dataGrid == null || keyName == null || keyValue == null || keyValue == "")
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
    }
}

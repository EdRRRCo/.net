using System;
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


        private void dataGridViewStu_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewStu.Rows.Count <= 0)
                return;
            //获取当前被选中的学生的学号
            string sno = dataGridViewStu.CurrentRow.Cells["SNO"].Value.ToString();
            //调用BLL层的方法获取学号为sno的学生的已选课程
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridViewChoosed.DataSource = bll.GetList_CourseSelected(sno).Tables[0].DefaultView;
            //调用BLL层的方法获取学号为sno的学生的可选课程
            this.dataGridViewUnChoose.DataSource = bll.GetList_UnCourseSelected(sno).Tables[0].DefaultView;

            //设置按钮【选课】和【退选】可用性
            this.buttonSelected.Enabled = this.dataGridViewUnChoose.Rows.Count > 0;
            this.buttonNO.Enabled = this.dataGridViewChoosed.Rows.Count > 0;
        }


        //选课
        private void buttonSelected_Click(object sender, EventArgs e)
        {
            //获取学号
            string sno = this.dataGridViewStu.CurrentRow.Cells["SNO"].Value.ToString();
            //课程编号
            string cno = this.dataGridViewUnChoose.CurrentRow.Cells["CNO2"].Value.ToString();
            //
            studentMS.Model.s_c model = new studentMS.Model.s_c();
            model.SNO = sno;//学号
            model.CNO = cno;//课程编号
            /*    model.Score = DBNull;*/

            studentMS.BLL.s_c bll = new studentMS.BLL.s_c();
            try
            {
                bll.Add(model);//新增选课记录
                this.dataGridViewStu_SelectionChanged(this.dataGridViewStu, e);//调用SelectionChanged事件刷新数据显示
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "选课出错！\n" + ex.Message, "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        //退选
        private void buttonNO_Click(object sender, EventArgs e)
        {
            string sno = this.dataGridViewStu.CurrentRow.Cells["SNO"].Value.ToString();
            string cno = this.dataGridViewChoosed.CurrentRow.Cells["CNO"].Value.ToString();

            studentMS.BLL.s_c bll = new studentMS.BLL.s_c();

            try
            {
                bll.Delete(sno,cno);//删除选课记录
                this.dataGridViewStu_SelectionChanged(this.dataGridViewStu, e);//调用SelectionChanged事件刷新数据显示
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "退选出错！\n" + ex.Message, "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

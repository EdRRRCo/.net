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
    public partial class FormInputScore : Form
    {
        public FormInputScore()
        {
            InitializeComponent();
        }

        private void FormInputScore_Load(object sender, EventArgs e)
        {
            //初始化课程信息下拉框
            studentMS.BLL.course bll = new studentMS.BLL.course();//实例化
            this.comboBox1.DataSource = bll.GetAllList().Tables[0];
            this.comboBox1.DisplayMember = "CName";//显示课程名称
            this.comboBox1.ValueMember = "CNO";

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Items.Count <= 0 || this.comboBox1.SelectedValue.ToString() == "")
                return;

            //展示选了该课程的学生的学号、姓名、和成绩
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridView1.DataSource = bll.GetList_Score(this.comboBox1.SelectedValue.ToString()).Tables[0].DefaultView;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "您确定要提交成绩吗？", "提交确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string cno = this.comboBox1.SelectedValue.ToString();//下拉框当前选中的课程编号

                //遍历dataGridView中所有记录并更新到数据库
                studentMS.BLL.s_c bll = new studentMS.BLL.s_c();//BLL
                studentMS.Model.s_c model = new studentMS.Model.s_c();//Model
                model.CNO = cno;

                for(int i = 0; i < this.dataGridView1.Rows.Count; i++)
                {
                    model.SNO = this.dataGridView1.Rows[i].Cells["SNO"].Value.ToString();//获取第i行的学号
                    
                    try
                    {
                        model.Score = decimal.Parse(this.dataGridView1.Rows[i].Cells["Score"].Value.ToString());
                        bll.Update(model);//更新数据到数据库中
                    }
                    catch { }
                }
                MessageBox.Show(this, "更新完成\n", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }
    }
}

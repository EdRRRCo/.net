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
    public partial class FormTC : Form
    {
        public FormTC()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridViewTea.DataSource = bll.GetList_Teacher(this.textBoxTNO.Text.Trim(), this.textBoxTName.Text.Trim()).Tables[0].DefaultView;
        }

        private void dataGridViewTea_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewTea.Rows.Count <= 0)
                return;
            //获取当前被选中的教师的工号
            string tno = dataGridViewTea.CurrentRow.Cells["TNO"].Value.ToString();
            //调用BLL层的方法获取工号为tno的教师的授课课程
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridViewChoosed.DataSource = bll.GetList_TCSelected(tno).Tables[0].DefaultView;
            //调用BLL层的方法获取非工号为tno的教师的授课课程
            this.dataGridViewUnChoose.DataSource = bll.GetList_UnTeach(tno).Tables[0].DefaultView;

            //设置按钮【选课】和【退选】可用性
            this.buttonSelected.Enabled = this.dataGridViewUnChoose.Rows.Count > 0;
            this.buttonNO.Enabled = this.dataGridViewChoosed.Rows.Count > 0;
        }

        ////选择授课课程
        //private void buttonSelected_Click(object sender, EventArgs e)
        //{
        //    //获取教师工号
        //    string tno = this.dataGridViewTea.CurrentRow.Cells["TNO"].Value.ToString();
        //    //课程编号
        //    string cno = this.dataGridViewUnChoose.CurrentRow.Cells["CNO2"].Value.ToString();
        //    //
        //    studentMS.Model.t_c model = new studentMS.Model.t_c();
        //    model.TNO = tno;//工号
        //    model.CNO = cno;//课程编号
        //    /*    model.Score = DBNull;*/

        //    studentMS.BLL.s_c bll = new studentMS.BLL.s_c();
        //    try
        //    {
        //        bll.Add(model);//新增选课记录
        //        this.dataGridViewTea_SelectionChanged(this.dataGridViewTea, e);//调用SelectionChanged事件刷新数据显示
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, "选课出错！\n" + ex.Message, "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}
    }
}

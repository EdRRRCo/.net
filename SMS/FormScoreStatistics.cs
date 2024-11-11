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
    public partial class FormStuScoreStatistics : Form
    {
        public FormStuScoreStatistics()
        {
            InitializeComponent();
        }

        private void buttonQueryScore_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridView1.DataSource = bll.GetList_ScoreStatistics(this.textBox1.Text.Trim()).Tables[0].DefaultView;
        }
    }
}

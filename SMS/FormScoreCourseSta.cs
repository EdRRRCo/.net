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
    public partial class FormScoreCourseSta : Form
    {
        public FormScoreCourseSta()
        {
            InitializeComponent();
        }

        private void buttonQueryScore_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridViewCo.DataSource = bll.GetList_ScoreCourseSta(this.textBox1.Text.Trim()).Tables[0].DefaultView;
        }
    }


}

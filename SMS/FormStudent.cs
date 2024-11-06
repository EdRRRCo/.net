﻿using System;
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
            studentMS.BLL.student bll = new studentMS.BLL.student();//实例化BLL层的对象
            this.dataGridView1.DataSource = bll.GetAllList().Tables[0].DefaultView;
        }
    }
}

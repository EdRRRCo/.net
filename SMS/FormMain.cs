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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MenuItem22_Click(object sender, EventArgs e)
        {
            FormStudent temp = new FormStudent();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }

        private void MenuItem23_Click(object sender, EventArgs e)
        {
            FormTeacher temp = new FormTeacher();
            temp.MdiParent = this;
            temp.Show();
        }

        private void MenuItem32_Click(object sender, EventArgs e)
        {
            FormSC temp = new FormSC();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }

        private void MenuItem41_Click(object sender, EventArgs e)
        {
            FormInputScore temp = new FormInputScore();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }

        private void MenuItem42_Click(object sender, EventArgs e)
        {
            FormScoreQuery temp = new FormScoreQuery();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }

        private void MenuItem51_Click(object sender, EventArgs e)
        {
            FormStuScoreStatistics temp = new FormStuScoreStatistics();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }

        private void MenuItem81_Click(object sender, EventArgs e)
        {
            FormRole temp = new FormRole();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }

        private void MenuItem82_Click(object sender, EventArgs e)
        {
            FormUser temp = new FormUser();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }

        private void MenuItem21_Click(object sender, EventArgs e)
        {
            FormDept temp = new FormDept();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }

        private void MenuItem31_Click(object sender, EventArgs e)
        {
            FormCourse temp = new FormCourse();//实例化
            temp.MdiParent = this;//设置父窗体
            temp.Show();//调用方法Show把窗体展示到界面
        }
    }
}

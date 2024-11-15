using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //登录
            FormLogin login = new FormLogin();
            login.ShowDialog();

            if(login.DialogResult == DialogResult.OK)//用户密码校验成功后展示主界面
                Application.Run(new FormMain());
        }
    }
}

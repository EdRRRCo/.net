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
    public partial class FormLogin : Form
    {
        private string VerifyCode = "";//保存验证码

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string strError = "";
            if (this.textBoxUID.Text.Trim() == "")
                strError += "用户名不能为空！\n";
            if(this.textBoxUCode.Text.Trim()=="")
                strError += "密码不能为空！\n";
            
            if(strError != "")
            {
                MessageBox.Show(this, strError, "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if(this.textBoxVerify.Text.Trim() != VerifyCode)
            {
                MessageBox.Show(this, "验证码不正确", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                

            studentMS.BLL.core core = new studentMS.BLL.core();//实例化BLL层
            if (core.ExistUIDUCode(this.textBoxUID.Text.Trim(), this.textBoxUCode.Text.Trim()))
            {

                //或许用户权限
                new studentMS.BLL.core().Get_RightByUser(this.textBoxUID.Text.Trim());
                this.DialogResult = DialogResult.OK;//设置窗体返回值
                this.Close();//关闭登录界面并释放资源
            }
            else
            {
                MessageBox.Show(this, "用户名或者密码输入错误", "友情提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.textBoxUID.Select();//把焦点放在用户名编辑框

            this.CreateVerifyCode();//调用生成验证码的方法
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.CreateVerifyCode();//调用生成验证码的方法
        }

        private void CreateVerifyCode()
        {
            VerifyCode = this.createRandomCode(4);//界面展示的时候直接产生一个验证码
            this.pictureBox1.Image = this.createImage(VerifyCode);//生成验证码图片
        }

        /// <summary>
        /// 生成长度为iLength的验证码
        /// </summary>
        /// <param name="iLength">验证码长度</param>
        /// <returns>验证码字符串</returns>
        private string createRandomCode(int iLength)
        {
            int rand;
            char code;
            string randomCode = "";

            Random random = new Random();//实例化一个产生随机数的对象

            for (int i = 0; i < iLength; i++)
            {
                rand = random.Next();//获取一个随机数
                if (rand % 3 == 0)     //随机数能被3整除时，产生大写字母的概率为1/3
                    code = (char)('A' + (char)(rand % 26));//获取随机的大写字母
                else
                    code = (char)('0' + (char)(rand % 10));//获取随机数字
                randomCode += code.ToString();
            }
            return randomCode;
        }

        private Bitmap createImage(string strVerifyCode)
        {
            int iRandAngle = 45;//旋转最大角度
            int iMapWidth = strVerifyCode.Length * 21;//单个字符21个像素点
            Bitmap map = new Bitmap(iMapWidth, 28);//背景 实例化了一个位图

            try
            {
                Graphics graph = Graphics.FromImage(map);//画布
                graph.Clear(Color.AliceBlue);//填充背景
                //    画一个矩形          定义画笔                长宽减少一个像素
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);//边框

                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//抗锯齿模式

                //背景噪点
                Random rand = new Random();
                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i < 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }


                char[] chars = strVerifyCode.ToCharArray();//字符串转换成字符数组
                //对齐方式 居中
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                //定义颜色
                Color[] color = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
                //定义字体
                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
                //旋转
                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(8);//随机颜色
                    int findex = rand.Next(5);//随机字体
                    //字体
                    Font f = new Font(font[findex], 13, System.Drawing.FontStyle.Bold);
                    //刷子
                    Brush b = new System.Drawing.SolidBrush(color[cindex]);
                    Point dot = new Point(16, 16);
                    float angle = rand.Next(-iRandAngle, iRandAngle);//随机旋转角度
                    graph.TranslateTransform(dot.X, dot.Y);//移动光标到指定位置
                    graph.RotateTransform(angle);//旋转画布
                    graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);
                    graph.RotateTransform(-angle);//画布旋转回来
                    graph.TranslateTransform(2, -dot.Y);//移动光标，确定下一个字符的起始位置
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(this, "创建图片错误！\n" + ex.Message, "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return map;

        }


    }
}


namespace SMS
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUID = new System.Windows.Forms.Label();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.textBoxUCode = new System.Windows.Forms.TextBox();
            this.labelUCode = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxVerify = new System.Windows.Forms.TextBox();
            this.labelVerify = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Font = new System.Drawing.Font("宋体", 11F);
            this.labelUID.Location = new System.Drawing.Point(134, 82);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(66, 19);
            this.labelUID.TabIndex = 0;
            this.labelUID.Text = "用户名";
            // 
            // textBoxUID
            // 
            this.textBoxUID.Font = new System.Drawing.Font("宋体", 11F);
            this.textBoxUID.Location = new System.Drawing.Point(225, 73);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(210, 28);
            this.textBoxUID.TabIndex = 1;
            // 
            // textBoxUCode
            // 
            this.textBoxUCode.Font = new System.Drawing.Font("宋体", 11F);
            this.textBoxUCode.Location = new System.Drawing.Point(225, 146);
            this.textBoxUCode.Name = "textBoxUCode";
            this.textBoxUCode.PasswordChar = '*';
            this.textBoxUCode.Size = new System.Drawing.Size(210, 28);
            this.textBoxUCode.TabIndex = 3;
            // 
            // labelUCode
            // 
            this.labelUCode.AutoSize = true;
            this.labelUCode.Font = new System.Drawing.Font("宋体", 11F);
            this.labelUCode.Location = new System.Drawing.Point(153, 155);
            this.labelUCode.Name = "labelUCode";
            this.labelUCode.Size = new System.Drawing.Size(47, 19);
            this.labelUCode.TabIndex = 2;
            this.labelUCode.Text = "密码";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("宋体", 11F);
            this.buttonLogin.Location = new System.Drawing.Point(258, 318);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(132, 50);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxVerify
            // 
            this.textBoxVerify.Font = new System.Drawing.Font("宋体", 11F);
            this.textBoxVerify.Location = new System.Drawing.Point(225, 220);
            this.textBoxVerify.Name = "textBoxVerify";
            this.textBoxVerify.Size = new System.Drawing.Size(210, 28);
            this.textBoxVerify.TabIndex = 6;
            this.textBoxVerify.Tag = "";
            // 
            // labelVerify
            // 
            this.labelVerify.AutoSize = true;
            this.labelVerify.Font = new System.Drawing.Font("宋体", 11F);
            this.labelVerify.Location = new System.Drawing.Point(134, 229);
            this.labelVerify.Name = "labelVerify";
            this.labelVerify.Size = new System.Drawing.Size(66, 19);
            this.labelVerify.TabIndex = 5;
            this.labelVerify.Text = "验证码";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(468, 214);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 44);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxVerify);
            this.Controls.Add(this.labelVerify);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUCode);
            this.Controls.Add(this.labelUCode);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.labelUID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.TextBox textBoxUCode;
        private System.Windows.Forms.Label labelUCode;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxVerify;
        private System.Windows.Forms.Label labelVerify;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
    }
}
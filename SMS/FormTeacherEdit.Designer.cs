
namespace SMS
{
    partial class FormTeacherEdit
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SAd = new System.Windows.Forms.Label();
            this.SSex = new System.Windows.Forms.Label();
            this.textBoxTName = new System.Windows.Forms.TextBox();
            this.LabelTName = new System.Windows.Forms.Label();
            this.textBoxTNO = new System.Windows.Forms.TextBox();
            this.labelTNO = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTstatus = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(462, 347);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 32);
            this.Cancel.TabIndex = 42;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(193, 347);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 32);
            this.Submit.TabIndex = 41;
            this.Submit.Text = "确定";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(287, 140);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(43, 19);
            this.Female.TabIndex = 40;
            this.Female.TabStop = true;
            this.Female.Text = "女";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(210, 140);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(43, 19);
            this.Male.TabIndex = 39;
            this.Male.TabStop = true;
            this.Male.Text = "男";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(193, 185);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(488, 25);
            this.textBoxAddress.TabIndex = 38;
            // 
            // SAd
            // 
            this.SAd.AutoSize = true;
            this.SAd.Location = new System.Drawing.Point(149, 195);
            this.SAd.Name = "SAd";
            this.SAd.Size = new System.Drawing.Size(37, 15);
            this.SAd.TabIndex = 37;
            this.SAd.Text = "地址";
            // 
            // SSex
            // 
            this.SSex.AutoSize = true;
            this.SSex.Location = new System.Drawing.Point(149, 142);
            this.SSex.Name = "SSex";
            this.SSex.Size = new System.Drawing.Size(37, 15);
            this.SSex.TabIndex = 36;
            this.SSex.Text = "性别";
            // 
            // textBoxTName
            // 
            this.textBoxTName.Location = new System.Drawing.Point(517, 72);
            this.textBoxTName.Name = "textBoxTName";
            this.textBoxTName.Size = new System.Drawing.Size(150, 25);
            this.textBoxTName.TabIndex = 33;
            // 
            // LabelTName
            // 
            this.LabelTName.AutoSize = true;
            this.LabelTName.Location = new System.Drawing.Point(459, 82);
            this.LabelTName.Name = "LabelTName";
            this.LabelTName.Size = new System.Drawing.Size(37, 15);
            this.LabelTName.TabIndex = 32;
            this.LabelTName.Text = "姓名";
            // 
            // textBoxTNO
            // 
            this.textBoxTNO.Location = new System.Drawing.Point(192, 72);
            this.textBoxTNO.Name = "textBoxTNO";
            this.textBoxTNO.Size = new System.Drawing.Size(150, 25);
            this.textBoxTNO.TabIndex = 31;
            // 
            // labelTNO
            // 
            this.labelTNO.AutoSize = true;
            this.labelTNO.Location = new System.Drawing.Point(149, 82);
            this.labelTNO.Name = "labelTNO";
            this.labelTNO.Size = new System.Drawing.Size(37, 15);
            this.labelTNO.TabIndex = 30;
            this.labelTNO.Text = "工号";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(192, 234);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(488, 25);
            this.textBoxTel.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "联系方式";
            // 
            // textBoxTstatus
            // 
            this.textBoxTstatus.Location = new System.Drawing.Point(193, 287);
            this.textBoxTstatus.Name = "textBoxTstatus";
            this.textBoxTstatus.Size = new System.Drawing.Size(488, 25);
            this.textBoxTstatus.TabIndex = 46;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(119, 297);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 15);
            this.label.TabIndex = 45;
            this.label.Text = "在职状态";
            // 
            // FormTeacherEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.textBoxTstatus);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.SAd);
            this.Controls.Add(this.SSex);
            this.Controls.Add(this.textBoxTName);
            this.Controls.Add(this.LabelTName);
            this.Controls.Add(this.textBoxTNO);
            this.Controls.Add(this.labelTNO);
            this.Name = "FormTeacherEdit";
            this.Text = "FormTeacherEdit";
            this.Load += new System.EventHandler(this.FormTeacherEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label SAd;
        private System.Windows.Forms.Label SSex;
        private System.Windows.Forms.TextBox textBoxTName;
        private System.Windows.Forms.Label LabelTName;
        private System.Windows.Forms.TextBox textBoxTNO;
        private System.Windows.Forms.Label labelTNO;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTstatus;
        private System.Windows.Forms.Label label;
    }
}
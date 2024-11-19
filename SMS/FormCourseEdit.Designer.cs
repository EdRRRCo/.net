
namespace SMS
{
    partial class FormCourseEdit
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonYES = new System.Windows.Forms.Button();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.labelCName = new System.Windows.Forms.Label();
            this.textBoxCNO = new System.Windows.Forms.TextBox();
            this.labelCNO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCredit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(485, 336);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 35);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonYES
            // 
            this.buttonYES.Location = new System.Drawing.Point(255, 336);
            this.buttonYES.Name = "buttonYES";
            this.buttonYES.Size = new System.Drawing.Size(103, 35);
            this.buttonYES.TabIndex = 10;
            this.buttonYES.Text = "确定";
            this.buttonYES.UseVisualStyleBackColor = true;
            this.buttonYES.Click += new System.EventHandler(this.buttonYES_Click);
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(288, 157);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(333, 25);
            this.textBoxCName.TabIndex = 9;
            // 
            // labelCName
            // 
            this.labelCName.AutoSize = true;
            this.labelCName.Location = new System.Drawing.Point(185, 167);
            this.labelCName.Name = "labelCName";
            this.labelCName.Size = new System.Drawing.Size(67, 15);
            this.labelCName.TabIndex = 8;
            this.labelCName.Text = "课程名称";
            // 
            // textBoxCNO
            // 
            this.textBoxCNO.Location = new System.Drawing.Point(288, 84);
            this.textBoxCNO.Name = "textBoxCNO";
            this.textBoxCNO.Size = new System.Drawing.Size(333, 25);
            this.textBoxCNO.TabIndex = 7;
            // 
            // labelCNO
            // 
            this.labelCNO.AutoSize = true;
            this.labelCNO.Location = new System.Drawing.Point(185, 94);
            this.labelCNO.Name = "labelCNO";
            this.labelCNO.Size = new System.Drawing.Size(67, 15);
            this.labelCNO.TabIndex = 6;
            this.labelCNO.Text = "课程编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "学分";
            // 
            // comboBoxCredit
            // 
            this.comboBoxCredit.FormattingEnabled = true;
            this.comboBoxCredit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6"});
            this.comboBoxCredit.Location = new System.Drawing.Point(288, 241);
            this.comboBoxCredit.Name = "comboBoxCredit";
            this.comboBoxCredit.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCredit.TabIndex = 13;
            // 
            // FormCourseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 483);
            this.Controls.Add(this.comboBoxCredit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonYES);
            this.Controls.Add(this.textBoxCName);
            this.Controls.Add(this.labelCName);
            this.Controls.Add(this.textBoxCNO);
            this.Controls.Add(this.labelCNO);
            this.Name = "FormCourseEdit";
            this.Text = "FormCourseEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonYES;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label labelCName;
        private System.Windows.Forms.TextBox textBoxCNO;
        private System.Windows.Forms.Label labelCNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCredit;
    }
}

namespace SMS
{
    partial class FormDeptEdit
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
            this.labelDeptNO = new System.Windows.Forms.Label();
            this.textBoxDeptNO = new System.Windows.Forms.TextBox();
            this.textBoxDeptName = new System.Windows.Forms.TextBox();
            this.labelDeptName = new System.Windows.Forms.Label();
            this.buttonYES = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeptNO
            // 
            this.labelDeptNO.AutoSize = true;
            this.labelDeptNO.Location = new System.Drawing.Point(169, 123);
            this.labelDeptNO.Name = "labelDeptNO";
            this.labelDeptNO.Size = new System.Drawing.Size(67, 15);
            this.labelDeptNO.TabIndex = 0;
            this.labelDeptNO.Text = "学院代码";
            // 
            // textBoxDeptNO
            // 
            this.textBoxDeptNO.Location = new System.Drawing.Point(242, 113);
            this.textBoxDeptNO.Name = "textBoxDeptNO";
            this.textBoxDeptNO.Size = new System.Drawing.Size(333, 25);
            this.textBoxDeptNO.TabIndex = 1;
            // 
            // textBoxDeptName
            // 
            this.textBoxDeptName.Location = new System.Drawing.Point(242, 215);
            this.textBoxDeptName.Name = "textBoxDeptName";
            this.textBoxDeptName.Size = new System.Drawing.Size(333, 25);
            this.textBoxDeptName.TabIndex = 3;
            // 
            // labelDeptName
            // 
            this.labelDeptName.AutoSize = true;
            this.labelDeptName.Location = new System.Drawing.Point(169, 225);
            this.labelDeptName.Name = "labelDeptName";
            this.labelDeptName.Size = new System.Drawing.Size(67, 15);
            this.labelDeptName.TabIndex = 2;
            this.labelDeptName.Text = "学院名称";
            // 
            // buttonYES
            // 
            this.buttonYES.Location = new System.Drawing.Point(200, 338);
            this.buttonYES.Name = "buttonYES";
            this.buttonYES.Size = new System.Drawing.Size(103, 35);
            this.buttonYES.TabIndex = 4;
            this.buttonYES.Text = "确定";
            this.buttonYES.UseVisualStyleBackColor = true;
            this.buttonYES.Click += new System.EventHandler(this.buttonYES_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(432, 338);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormDeptEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonYES);
            this.Controls.Add(this.textBoxDeptName);
            this.Controls.Add(this.labelDeptName);
            this.Controls.Add(this.textBoxDeptNO);
            this.Controls.Add(this.labelDeptNO);
            this.Name = "FormDeptEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeptEdit";
            this.Load += new System.EventHandler(this.FormDeptEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeptNO;
        private System.Windows.Forms.TextBox textBoxDeptNO;
        private System.Windows.Forms.TextBox textBoxDeptName;
        private System.Windows.Forms.Label labelDeptName;
        private System.Windows.Forms.Button buttonYES;
        private System.Windows.Forms.Button buttonCancel;
    }
}
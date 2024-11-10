
namespace SMS
{
    partial class FormTeacher
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
            this.panelTeaSer = new System.Windows.Forms.Panel();
            this.buttonQueryTea = new System.Windows.Forms.Button();
            this.textTName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTea = new System.Windows.Forms.DataGridView();
            this.panelTeaSer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTea)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTeaSer
            // 
            this.panelTeaSer.Controls.Add(this.buttonQueryTea);
            this.panelTeaSer.Controls.Add(this.textTName);
            this.panelTeaSer.Controls.Add(this.label2);
            this.panelTeaSer.Controls.Add(this.textTNumber);
            this.panelTeaSer.Controls.Add(this.label1);
            this.panelTeaSer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTeaSer.Location = new System.Drawing.Point(0, 0);
            this.panelTeaSer.Name = "panelTeaSer";
            this.panelTeaSer.Size = new System.Drawing.Size(1093, 100);
            this.panelTeaSer.TabIndex = 0;
            this.panelTeaSer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonQueryTea
            // 
            this.buttonQueryTea.Location = new System.Drawing.Point(827, 28);
            this.buttonQueryTea.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQueryTea.Name = "buttonQueryTea";
            this.buttonQueryTea.Size = new System.Drawing.Size(100, 40);
            this.buttonQueryTea.TabIndex = 4;
            this.buttonQueryTea.Text = "查询";
            this.buttonQueryTea.UseVisualStyleBackColor = true;
            // 
            // textTName
            // 
            this.textTName.Location = new System.Drawing.Point(431, 35);
            this.textTName.Name = "textTName";
            this.textTName.Size = new System.Drawing.Size(200, 25);
            this.textTName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // textTNumber
            // 
            this.textTNumber.Location = new System.Drawing.Point(95, 35);
            this.textTNumber.Name = "textTNumber";
            this.textTNumber.Size = new System.Drawing.Size(201, 25);
            this.textTNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号";
            // 
            // dataGridViewTea
            // 
            this.dataGridViewTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTea.Location = new System.Drawing.Point(0, 100);
            this.dataGridViewTea.Name = "dataGridViewTea";
            this.dataGridViewTea.RowHeadersWidth = 51;
            this.dataGridViewTea.RowTemplate.Height = 27;
            this.dataGridViewTea.Size = new System.Drawing.Size(1093, 618);
            this.dataGridViewTea.TabIndex = 1;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 718);
            this.Controls.Add(this.dataGridViewTea);
            this.Controls.Add(this.panelTeaSer);
            this.Name = "FormTeacher";
            this.Text = "教师档案";
            this.panelTeaSer.ResumeLayout(false);
            this.panelTeaSer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTeaSer;
        private System.Windows.Forms.Button buttonQueryTea;
        private System.Windows.Forms.TextBox textTName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTea;
    }
}

namespace SMS
{
    partial class FormScoreCourseSta
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
            this.dataGridViewCo = new System.Windows.Forms.DataGridView();
            this.CNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQueryScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCo
            // 
            this.dataGridViewCo.AllowUserToAddRows = false;
            this.dataGridViewCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNO,
            this.CName,
            this.ScoreMax,
            this.ScoreMin,
            this.ScoreAvg});
            this.dataGridViewCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCo.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewCo.Name = "dataGridViewCo";
            this.dataGridViewCo.RowHeadersWidth = 51;
            this.dataGridViewCo.RowTemplate.Height = 27;
            this.dataGridViewCo.Size = new System.Drawing.Size(781, 385);
            this.dataGridViewCo.TabIndex = 4;
            // 
            // CNO
            // 
            this.CNO.DataPropertyName = "CNO";
            this.CNO.HeaderText = "课程编号";
            this.CNO.MinimumWidth = 6;
            this.CNO.Name = "CNO";
            this.CNO.Width = 125;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "课程名称";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.Width = 125;
            // 
            // ScoreMax
            // 
            this.ScoreMax.DataPropertyName = "ScoreMax";
            this.ScoreMax.HeaderText = "最高分";
            this.ScoreMax.MinimumWidth = 6;
            this.ScoreMax.Name = "ScoreMax";
            this.ScoreMax.Width = 125;
            // 
            // ScoreMin
            // 
            this.ScoreMin.DataPropertyName = "ScoreMin";
            this.ScoreMin.HeaderText = "最低分";
            this.ScoreMin.MinimumWidth = 6;
            this.ScoreMin.Name = "ScoreMin";
            this.ScoreMin.Width = 125;
            // 
            // ScoreAvg
            // 
            this.ScoreAvg.DataPropertyName = "ScoreAvg";
            this.ScoreAvg.HeaderText = "平均分";
            this.ScoreAvg.MinimumWidth = 6;
            this.ScoreAvg.Name = "ScoreAvg";
            this.ScoreAvg.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonQueryScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 66);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 25);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "课程名称";
            // 
            // buttonQueryScore
            // 
            this.buttonQueryScore.Location = new System.Drawing.Point(369, 15);
            this.buttonQueryScore.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQueryScore.Name = "buttonQueryScore";
            this.buttonQueryScore.Size = new System.Drawing.Size(93, 40);
            this.buttonQueryScore.TabIndex = 12;
            this.buttonQueryScore.Text = "查  询";
            this.buttonQueryScore.UseVisualStyleBackColor = true;
            this.buttonQueryScore.Click += new System.EventHandler(this.buttonQueryScore_Click);
            // 
            // FormScoreCourseSta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 451);
            this.Controls.Add(this.dataGridViewCo);
            this.Controls.Add(this.panel1);
            this.Name = "FormScoreCourseSta";
            this.Text = "成绩统计-课程";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQueryScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreAvg;
    }
}
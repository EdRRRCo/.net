
namespace SMS
{
    partial class FormSC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewStu = new System.Windows.Forms.DataGridView();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStuSer = new System.Windows.Forms.Panel();
            this.buttonQueryStu = new System.Windows.Forms.Button();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUnChoose = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChoosed = new System.Windows.Forms.DataGridView();
            this.CNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonNO = new System.Windows.Forms.Button();
            this.buttonSelected = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).BeginInit();
            this.panelStuSer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnChoose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoosed)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewStu);
            this.panel1.Controls.Add(this.panelStuSer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 551);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewStu
            // 
            this.dataGridViewStu.AllowUserToAddRows = false;
            this.dataGridViewStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.SName,
            this.SSex,
            this.DeptName,
            this.SBirthday,
            this.Address});
            this.dataGridViewStu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStu.Location = new System.Drawing.Point(0, 84);
            this.dataGridViewStu.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStu.MultiSelect = false;
            this.dataGridViewStu.Name = "dataGridViewStu";
            this.dataGridViewStu.RowHeadersWidth = 51;
            this.dataGridViewStu.RowTemplate.Height = 23;
            this.dataGridViewStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStu.Size = new System.Drawing.Size(453, 467);
            this.dataGridViewStu.TabIndex = 2;
            this.dataGridViewStu.SelectionChanged += new System.EventHandler(this.dataGridViewStu_SelectionChanged);
            // 
            // SNO
            // 
            this.SNO.DataPropertyName = "SNO";
            this.SNO.HeaderText = "学号";
            this.SNO.MinimumWidth = 6;
            this.SNO.Name = "SNO";
            this.SNO.Width = 125;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "姓名";
            this.SName.MinimumWidth = 6;
            this.SName.Name = "SName";
            this.SName.Width = 125;
            // 
            // SSex
            // 
            this.SSex.DataPropertyName = "SSex";
            this.SSex.HeaderText = "性别";
            this.SSex.MinimumWidth = 6;
            this.SSex.Name = "SSex";
            this.SSex.Width = 125;
            // 
            // DeptName
            // 
            this.DeptName.DataPropertyName = "DeptName";
            this.DeptName.HeaderText = "所在学院";
            this.DeptName.MinimumWidth = 6;
            this.DeptName.Name = "DeptName";
            this.DeptName.Width = 125;
            // 
            // SBirthday
            // 
            this.SBirthday.DataPropertyName = "SBirthday";
            this.SBirthday.HeaderText = "出生日期";
            this.SBirthday.MinimumWidth = 6;
            this.SBirthday.Name = "SBirthday";
            this.SBirthday.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "住址";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // panelStuSer
            // 
            this.panelStuSer.Controls.Add(this.buttonQueryStu);
            this.panelStuSer.Controls.Add(this.textBoxSName);
            this.panelStuSer.Controls.Add(this.label2);
            this.panelStuSer.Controls.Add(this.textBoxSNO);
            this.panelStuSer.Controls.Add(this.label1);
            this.panelStuSer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStuSer.Location = new System.Drawing.Point(0, 0);
            this.panelStuSer.Margin = new System.Windows.Forms.Padding(4);
            this.panelStuSer.Name = "panelStuSer";
            this.panelStuSer.Size = new System.Drawing.Size(453, 84);
            this.panelStuSer.TabIndex = 1;
            // 
            // buttonQueryStu
            // 
            this.buttonQueryStu.Location = new System.Drawing.Point(326, 23);
            this.buttonQueryStu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQueryStu.Name = "buttonQueryStu";
            this.buttonQueryStu.Size = new System.Drawing.Size(100, 40);
            this.buttonQueryStu.TabIndex = 4;
            this.buttonQueryStu.Text = "查  询";
            this.buttonQueryStu.UseVisualStyleBackColor = true;
            this.buttonQueryStu.Click += new System.EventHandler(this.buttonQueryStu_Click);
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(210, 33);
            this.textBoxSName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(88, 25);
            this.textBoxSName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // textBoxSNO
            // 
            this.textBoxSNO.Location = new System.Drawing.Point(67, 33);
            this.textBoxSNO.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSNO.Name = "textBoxSNO";
            this.textBoxSNO.Size = new System.Drawing.Size(72, 25);
            this.textBoxSNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(453, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 551);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(463, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 551);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewUnChoose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可选课程";
            // 
            // dataGridViewUnChoose
            // 
            this.dataGridViewUnChoose.AllowUserToAddRows = false;
            this.dataGridViewUnChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnChoose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewUnChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUnChoose.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewUnChoose.Name = "dataGridViewUnChoose";
            this.dataGridViewUnChoose.ReadOnly = true;
            this.dataGridViewUnChoose.RowHeadersWidth = 51;
            this.dataGridViewUnChoose.RowTemplate.Height = 27;
            this.dataGridViewUnChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnChoose.Size = new System.Drawing.Size(478, 238);
            this.dataGridViewUnChoose.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CNO";
            this.dataGridViewTextBoxColumn1.HeaderText = "课程编号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CName";
            this.dataGridViewTextBoxColumn2.HeaderText = "课程名称";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Credit";
            this.dataGridViewTextBoxColumn3.HeaderText = "学分";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 286);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(484, 3);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewChoosed);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已选课程";
            // 
            // dataGridViewChoosed
            // 
            this.dataGridViewChoosed.AllowUserToAddRows = false;
            this.dataGridViewChoosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChoosed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNO,
            this.CName,
            this.Credit});
            this.dataGridViewChoosed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewChoosed.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewChoosed.Name = "dataGridViewChoosed";
            this.dataGridViewChoosed.ReadOnly = true;
            this.dataGridViewChoosed.RowHeadersWidth = 51;
            this.dataGridViewChoosed.RowTemplate.Height = 27;
            this.dataGridViewChoosed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChoosed.Size = new System.Drawing.Size(478, 213);
            this.dataGridViewChoosed.TabIndex = 1;
            // 
            // CNO
            // 
            this.CNO.DataPropertyName = "CNO";
            this.CNO.HeaderText = "课程编号";
            this.CNO.MinimumWidth = 6;
            this.CNO.Name = "CNO";
            this.CNO.ReadOnly = true;
            this.CNO.Width = 125;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "课程名称";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 125;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "学分";
            this.Credit.MinimumWidth = 6;
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            this.Credit.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonNO);
            this.panel3.Controls.Add(this.buttonSelected);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 49);
            this.panel3.TabIndex = 0;
            // 
            // buttonNO
            // 
            this.buttonNO.Location = new System.Drawing.Point(309, 12);
            this.buttonNO.Name = "buttonNO";
            this.buttonNO.Size = new System.Drawing.Size(75, 27);
            this.buttonNO.TabIndex = 1;
            this.buttonNO.Text = "退选";
            this.buttonNO.UseVisualStyleBackColor = true;
            // 
            // buttonSelected
            // 
            this.buttonSelected.Location = new System.Drawing.Point(154, 12);
            this.buttonSelected.Name = "buttonSelected";
            this.buttonSelected.Size = new System.Drawing.Size(77, 27);
            this.buttonSelected.TabIndex = 0;
            this.buttonSelected.Text = "选课";
            this.buttonSelected.UseVisualStyleBackColor = true;
            this.buttonSelected.Click += new System.EventHandler(this.buttonSelected_Click);
            // 
            // FormSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "FormSC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生选课";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).EndInit();
            this.panelStuSer.ResumeLayout(false);
            this.panelStuSer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnChoose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoosed)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelStuSer;
        private System.Windows.Forms.Button buttonQueryStu;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridView dataGridViewChoosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonNO;
        private System.Windows.Forms.Button buttonSelected;
        private System.Windows.Forms.DataGridView dataGridViewUnChoose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
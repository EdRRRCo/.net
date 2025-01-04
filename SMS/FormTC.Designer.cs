
namespace SMS
{
    partial class FormTC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUnChoose = new System.Windows.Forms.DataGridView();
            this.CNO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewChoosed = new System.Windows.Forms.DataGridView();
            this.CNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonNO = new System.Windows.Forms.Button();
            this.buttonSelected = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTea = new System.Windows.Forms.DataGridView();
            this.TNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStuSer = new System.Windows.Forms.Panel();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxTName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnChoose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoosed)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTea)).BeginInit();
            this.panelStuSer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.splitter2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(463, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 551);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewUnChoose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "非此教师授课课程";
            // 
            // dataGridViewUnChoose
            // 
            this.dataGridViewUnChoose.AllowUserToAddRows = false;
            this.dataGridViewUnChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnChoose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNO2,
            this.CName2,
            this.Credit2});
            this.dataGridViewUnChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUnChoose.Location = new System.Drawing.Point(3, 21);
            this.dataGridViewUnChoose.Name = "dataGridViewUnChoose";
            this.dataGridViewUnChoose.ReadOnly = true;
            this.dataGridViewUnChoose.RowHeadersWidth = 51;
            this.dataGridViewUnChoose.RowTemplate.Height = 27;
            this.dataGridViewUnChoose.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnChoose.Size = new System.Drawing.Size(456, 238);
            this.dataGridViewUnChoose.TabIndex = 2;
            // 
            // CNO2
            // 
            this.CNO2.DataPropertyName = "CNO";
            this.CNO2.HeaderText = "课程编号";
            this.CNO2.MinimumWidth = 6;
            this.CNO2.Name = "CNO2";
            this.CNO2.ReadOnly = true;
            this.CNO2.Width = 125;
            // 
            // CName2
            // 
            this.CName2.DataPropertyName = "CName";
            this.CName2.HeaderText = "课程名称";
            this.CName2.MinimumWidth = 6;
            this.CName2.Name = "CName2";
            this.CName2.ReadOnly = true;
            this.CName2.Width = 125;
            // 
            // Credit2
            // 
            this.Credit2.DataPropertyName = "Credit";
            this.Credit2.HeaderText = "学分";
            this.Credit2.MinimumWidth = 6;
            this.Credit2.Name = "Credit2";
            this.Credit2.ReadOnly = true;
            this.Credit2.Width = 125;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 286);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(462, 3);
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
            this.groupBox1.Size = new System.Drawing.Size(462, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "授课课程";
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
            this.dataGridViewChoosed.Size = new System.Drawing.Size(456, 213);
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
            this.panel3.Size = new System.Drawing.Size(456, 49);
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
            this.buttonNO.Click += new System.EventHandler(this.buttonNO_Click);
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
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(453, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 551);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewTea);
            this.panel1.Controls.Add(this.panelStuSer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 551);
            this.panel1.TabIndex = 3;
            // 
            // dataGridViewTea
            // 
            this.dataGridViewTea.AllowUserToAddRows = false;
            this.dataGridViewTea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TNO,
            this.TName,
            this.TSex,
            this.Tel,
            this.Address,
            this.Status});
            this.dataGridViewTea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTea.Location = new System.Drawing.Point(0, 84);
            this.dataGridViewTea.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTea.MultiSelect = false;
            this.dataGridViewTea.Name = "dataGridViewTea";
            this.dataGridViewTea.ReadOnly = true;
            this.dataGridViewTea.RowHeadersWidth = 51;
            this.dataGridViewTea.RowTemplate.Height = 23;
            this.dataGridViewTea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTea.Size = new System.Drawing.Size(453, 467);
            this.dataGridViewTea.TabIndex = 2;
            this.dataGridViewTea.SelectionChanged += new System.EventHandler(this.dataGridViewTea_SelectionChanged);
            // 
            // TNO
            // 
            this.TNO.DataPropertyName = "TNO";
            this.TNO.HeaderText = "工号";
            this.TNO.MinimumWidth = 6;
            this.TNO.Name = "TNO";
            this.TNO.ReadOnly = true;
            this.TNO.Width = 125;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "TName";
            this.TName.HeaderText = "姓名";
            this.TName.MinimumWidth = 6;
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            this.TName.Width = 125;
            // 
            // TSex
            // 
            this.TSex.DataPropertyName = "TSex";
            this.TSex.HeaderText = "性别";
            this.TSex.MinimumWidth = 6;
            this.TSex.Name = "TSex";
            this.TSex.ReadOnly = true;
            this.TSex.Width = 125;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "联系方式";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "住址";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "在职状态";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // panelStuSer
            // 
            this.panelStuSer.Controls.Add(this.buttonQuery);
            this.panelStuSer.Controls.Add(this.textBoxTName);
            this.panelStuSer.Controls.Add(this.label2);
            this.panelStuSer.Controls.Add(this.textBoxTNO);
            this.panelStuSer.Controls.Add(this.label1);
            this.panelStuSer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStuSer.Location = new System.Drawing.Point(0, 0);
            this.panelStuSer.Margin = new System.Windows.Forms.Padding(4);
            this.panelStuSer.Name = "panelStuSer";
            this.panelStuSer.Size = new System.Drawing.Size(453, 84);
            this.panelStuSer.TabIndex = 1;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(326, 23);
            this.buttonQuery.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(100, 40);
            this.buttonQuery.TabIndex = 4;
            this.buttonQuery.Text = "查  询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxTName
            // 
            this.textBoxTName.Location = new System.Drawing.Point(210, 33);
            this.textBoxTName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTName.Name = "textBoxTName";
            this.textBoxTName.Size = new System.Drawing.Size(88, 25);
            this.textBoxTName.TabIndex = 3;
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
            // textBoxTNO
            // 
            this.textBoxTNO.Location = new System.Drawing.Point(67, 33);
            this.textBoxTNO.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTNO.Name = "textBoxTNO";
            this.textBoxTNO.Size = new System.Drawing.Size(72, 25);
            this.textBoxTNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号";
            // 
            // FormTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师授课";
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnChoose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChoosed)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTea)).EndInit();
            this.panelStuSer.ResumeLayout(false);
            this.panelStuSer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewUnChoose;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewChoosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonNO;
        private System.Windows.Forms.Button buttonSelected;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewTea;
        private System.Windows.Forms.Panel panelStuSer;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxTName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit2;
    }
}
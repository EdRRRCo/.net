
namespace SMS
{
    partial class FormCourse
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCNO = new System.Windows.Forms.TextBox();
            this.labelDeptNO = new System.Windows.Forms.Label();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.labelDeptName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNO,
            this.CName,
            this.Credit});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(863, 423);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // CNO
            // 
            this.CNO.DataPropertyName = "CNO";
            this.CNO.HeaderText = "课程编号";
            this.CNO.MinimumWidth = 6;
            this.CNO.Name = "CNO";
            this.CNO.ReadOnly = true;
            this.CNO.Width = 130;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "课程名称";
            this.CName.MinimumWidth = 6;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 200;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxCNO);
            this.panel1.Controls.Add(this.labelDeptNO);
            this.panel1.Controls.Add(this.buttonQuery);
            this.panel1.Controls.Add(this.textBoxCName);
            this.panel1.Controls.Add(this.labelDeptName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("宋体", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 79);
            this.panel1.TabIndex = 2;
            // 
            // textBoxCNO
            // 
            this.textBoxCNO.Location = new System.Drawing.Point(119, 26);
            this.textBoxCNO.Name = "textBoxCNO";
            this.textBoxCNO.Size = new System.Drawing.Size(178, 25);
            this.textBoxCNO.TabIndex = 4;
            // 
            // labelDeptNO
            // 
            this.labelDeptNO.AutoSize = true;
            this.labelDeptNO.Location = new System.Drawing.Point(46, 36);
            this.labelDeptNO.Name = "labelDeptNO";
            this.labelDeptNO.Size = new System.Drawing.Size(67, 15);
            this.labelDeptNO.TabIndex = 3;
            this.labelDeptNO.Text = "课程编号";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(667, 17);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(108, 39);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查 询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(410, 26);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(178, 25);
            this.textBoxCName.TabIndex = 1;
            // 
            // labelDeptName
            // 
            this.labelDeptName.AutoSize = true;
            this.labelDeptName.Location = new System.Drawing.Point(337, 36);
            this.labelDeptName.Name = "labelDeptName";
            this.labelDeptName.Size = new System.Drawing.Size(67, 15);
            this.labelDeptName.TabIndex = 0;
            this.labelDeptName.Text = "课程名称";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemEdit,
            this.MenuItemDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 76);
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(108, 24);
            this.MenuItemAdd.Text = "新增";
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(108, 24);
            this.MenuItemEdit.Text = "修改";
            this.MenuItemEdit.Click += new System.EventHandler(this.MenuItemEdit_Click);
            // 
            // MenuItemDel
            // 
            this.MenuItemDel.Name = "MenuItemDel";
            this.MenuItemDel.Size = new System.Drawing.Size(108, 24);
            this.MenuItemDel.Text = "删除";
            this.MenuItemDel.Click += new System.EventHandler(this.MenuItemDel_Click);
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 502);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCNO;
        private System.Windows.Forms.Label labelDeptNO;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label labelDeptName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDel;
    }
}
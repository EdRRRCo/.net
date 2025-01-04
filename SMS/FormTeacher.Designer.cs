
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStuSer = new System.Windows.Forms.Panel();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxTName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelStuSer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TNO,
            this.TName,
            this.TSex,
            this.Address,
            this.Tel,
            this.Tstatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 495);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
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
            this.TSex.Width = 80;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "住址";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 220;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "联系方式";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 180;
            // 
            // Tstatus
            // 
            this.Tstatus.DataPropertyName = "Tstatus";
            this.Tstatus.HeaderText = "在职状态";
            this.Tstatus.MinimumWidth = 6;
            this.Tstatus.Name = "Tstatus";
            this.Tstatus.ReadOnly = true;
            this.Tstatus.Width = 125;
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
            this.panelStuSer.Size = new System.Drawing.Size(1025, 95);
            this.panelStuSer.TabIndex = 2;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(827, 28);
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
            this.textBoxTName.Location = new System.Drawing.Point(431, 35);
            this.textBoxTName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTName.Name = "textBoxTName";
            this.textBoxTName.Size = new System.Drawing.Size(200, 25);
            this.textBoxTName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // textBoxTNO
            // 
            this.textBoxTNO.Location = new System.Drawing.Point(95, 35);
            this.textBoxTNO.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTNO.Name = "textBoxTNO";
            this.textBoxTNO.Size = new System.Drawing.Size(200, 25);
            this.textBoxTNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemEdit,
            this.MenuItemDel});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(211, 104);
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(210, 24);
            this.MenuItemAdd.Text = "新增";
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemEdit
            // 
            this.MenuItemEdit.Enabled = false;
            this.MenuItemEdit.Name = "MenuItemEdit";
            this.MenuItemEdit.Size = new System.Drawing.Size(210, 24);
            this.MenuItemEdit.Text = "修改";
            this.MenuItemEdit.Click += new System.EventHandler(this.MenuItemEdit_Click);
            // 
            // MenuItemDel
            // 
            this.MenuItemDel.Enabled = false;
            this.MenuItemDel.Name = "MenuItemDel";
            this.MenuItemDel.Size = new System.Drawing.Size(210, 24);
            this.MenuItemDel.Text = "删除";
            this.MenuItemDel.Click += new System.EventHandler(this.MenuItemDel_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 590);
            this.ContextMenuStrip = this.MenuStrip;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelStuSer);
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师档案";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelStuSer.ResumeLayout(false);
            this.panelStuSer.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelStuSer;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxTName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tstatus;
    }
}
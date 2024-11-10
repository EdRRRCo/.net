
namespace SMS
{
    partial class FormStudent
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
            this.panelStuSer = new System.Windows.Forms.Panel();
            this.buttonQueryStu = new System.Windows.Forms.Button();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStu = new System.Windows.Forms.DataGridView();
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripStuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemStuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStuSer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).BeginInit();
            this.contextMenuStripStuEdit.SuspendLayout();
            this.SuspendLayout();
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
            this.panelStuSer.Size = new System.Drawing.Size(1004, 95);
            this.panelStuSer.TabIndex = 0;
            // 
            // buttonQueryStu
            // 
            this.buttonQueryStu.Location = new System.Drawing.Point(827, 28);
            this.buttonQueryStu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQueryStu.Name = "buttonQueryStu";
            this.buttonQueryStu.Size = new System.Drawing.Size(100, 40);
            this.buttonQueryStu.TabIndex = 4;
            this.buttonQueryStu.Text = "查  询";
            this.buttonQueryStu.UseVisualStyleBackColor = true;
            this.buttonQueryStu.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(431, 35);
            this.textBoxSName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(200, 25);
            this.textBoxSName.TabIndex = 3;
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
            // textBoxSNO
            // 
            this.textBoxSNO.Location = new System.Drawing.Point(95, 35);
            this.textBoxSNO.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSNO.Name = "textBoxSNO";
            this.textBoxSNO.Size = new System.Drawing.Size(200, 25);
            this.textBoxSNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // dataGridViewStu
            // 
            this.dataGridViewStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.SName,
            this.SSex,
            this.DeptName,
            this.SBirthday,
            this.Address});
            this.dataGridViewStu.ContextMenuStrip = this.contextMenuStripStuEdit;
            this.dataGridViewStu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStu.Location = new System.Drawing.Point(0, 95);
            this.dataGridViewStu.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStu.MultiSelect = false;
            this.dataGridViewStu.Name = "dataGridViewStu";
            this.dataGridViewStu.RowHeadersWidth = 51;
            this.dataGridViewStu.RowTemplate.Height = 23;
            this.dataGridViewStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStu.Size = new System.Drawing.Size(1004, 405);
            this.dataGridViewStu.TabIndex = 1;
            this.dataGridViewStu.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewStu_CellMouseDown);
            this.dataGridViewStu.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewStu_DataBindingComplete);
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
            // contextMenuStripStuEdit
            // 
            this.contextMenuStripStuEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.contextMenuStripStuEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripStuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStuAdd,
            this.MenuItemStuEdit,
            this.MenuItemStuDel});
            this.contextMenuStripStuEdit.Name = "contextMenuStripStuEdit";
            this.contextMenuStripStuEdit.Size = new System.Drawing.Size(109, 76);
            // 
            // MenuItemStuAdd
            // 
            this.MenuItemStuAdd.Name = "MenuItemStuAdd";
            this.MenuItemStuAdd.Size = new System.Drawing.Size(108, 24);
            this.MenuItemStuAdd.Text = "新增";
            this.MenuItemStuAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemStuEdit
            // 
            this.MenuItemStuEdit.Enabled = false;
            this.MenuItemStuEdit.Name = "MenuItemStuEdit";
            this.MenuItemStuEdit.Size = new System.Drawing.Size(108, 24);
            this.MenuItemStuEdit.Text = "修改";
            this.MenuItemStuEdit.Click += new System.EventHandler(this.ToolStripMenuItemStuEdit_Click);
            // 
            // MenuItemStuDel
            // 
            this.MenuItemStuDel.Enabled = false;
            this.MenuItemStuDel.Name = "MenuItemStuDel";
            this.MenuItemStuDel.Size = new System.Drawing.Size(108, 24);
            this.MenuItemStuDel.Text = "删除";
            this.MenuItemStuDel.Click += new System.EventHandler(this.ToolStripMenuItemStuDel_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 500);
            this.Controls.Add(this.dataGridViewStu);
            this.Controls.Add(this.panelStuSer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生档案";
            this.panelStuSer.ResumeLayout(false);
            this.panelStuSer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStu)).EndInit();
            this.contextMenuStripStuEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStuSer;
        private System.Windows.Forms.Button buttonQueryStu;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStuDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridView dataGridViewStu;
    }
}
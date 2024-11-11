
namespace SMS
{
    partial class FormRole
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
            this.dataGridViewRole = new System.Windows.Forms.DataGridView();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripRoleEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemStuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSet = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).BeginInit();
            this.contextMenuStripRoleEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRole
            // 
            this.dataGridViewRole.AllowUserToAddRows = false;
            this.dataGridViewRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleID,
            this.RoleName,
            this.Status});
            this.dataGridViewRole.ContextMenuStrip = this.contextMenuStripRoleEdit;
            this.dataGridViewRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRole.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRole.MultiSelect = false;
            this.dataGridViewRole.Name = "dataGridViewRole";
            this.dataGridViewRole.ReadOnly = true;
            this.dataGridViewRole.RowHeadersWidth = 51;
            this.dataGridViewRole.RowTemplate.Height = 27;
            this.dataGridViewRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRole.Size = new System.Drawing.Size(626, 546);
            this.dataGridViewRole.TabIndex = 0;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "角色ID";
            this.RoleID.MinimumWidth = 6;
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            this.RoleID.Width = 125;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "角色名称";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "角色权限";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // contextMenuStripRoleEdit
            // 
            this.contextMenuStripRoleEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.contextMenuStripRoleEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRoleEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStuAdd,
            this.MenuItemStuEdit,
            this.MenuItemStuDel,
            this.toolStripMenuItemSet});
            this.contextMenuStripRoleEdit.Name = "contextMenuStripStuEdit";
            this.contextMenuStripRoleEdit.Size = new System.Drawing.Size(139, 100);
            // 
            // MenuItemStuAdd
            // 
            this.MenuItemStuAdd.Name = "MenuItemStuAdd";
            this.MenuItemStuAdd.Size = new System.Drawing.Size(138, 24);
            this.MenuItemStuAdd.Text = "新增";
            // 
            // MenuItemStuEdit
            // 
            this.MenuItemStuEdit.Enabled = false;
            this.MenuItemStuEdit.Name = "MenuItemStuEdit";
            this.MenuItemStuEdit.Size = new System.Drawing.Size(138, 24);
            this.MenuItemStuEdit.Text = "修改";
            // 
            // MenuItemStuDel
            // 
            this.MenuItemStuDel.Enabled = false;
            this.MenuItemStuDel.Name = "MenuItemStuDel";
            this.MenuItemStuDel.Size = new System.Drawing.Size(138, 24);
            this.MenuItemStuDel.Text = "删除";
            // 
            // toolStripMenuItemSet
            // 
            this.toolStripMenuItemSet.Enabled = false;
            this.toolStripMenuItemSet.Name = "toolStripMenuItemSet";
            this.toolStripMenuItemSet.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItemSet.Text = "权限设置";
            // 
            // FormRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 546);
            this.Controls.Add(this.dataGridViewRole);
            this.Name = "FormRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.FormRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).EndInit();
            this.contextMenuStripRoleEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRoleEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStuDel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSet;
    }
}
﻿
namespace SMS
{
    partial class FormUser
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
            this.buttonQuery = new System.Windows.Forms.Button();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPriorTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPriorIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonQuery);
            this.panel1.Controls.Add(this.textBoxUID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 94);
            this.panel1.TabIndex = 0;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(506, 21);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(101, 45);
            this.buttonQuery.TabIndex = 2;
            this.buttonQuery.Text = "查询";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(180, 33);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(222, 25);
            this.textBoxUID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.RoleID,
            this.RoleName,
            this.UPriorTime,
            this.UPriorIP,
            this.Remark});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 510);
            this.dataGridView1.TabIndex = 1;
            // 
            // UID
            // 
            this.UID.DataPropertyName = "UID";
            this.UID.HeaderText = "用户名";
            this.UID.MinimumWidth = 6;
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Width = 125;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "角色编号";
            this.RoleID.MinimumWidth = 6;
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            this.RoleID.Visible = false;
            this.RoleID.Width = 125;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "角色名称";
            this.RoleName.MinimumWidth = 6;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            this.RoleName.Width = 150;
            // 
            // UPriorTime
            // 
            this.UPriorTime.DataPropertyName = "UPriorTime";
            this.UPriorTime.HeaderText = "上次登录时间";
            this.UPriorTime.MinimumWidth = 6;
            this.UPriorTime.Name = "UPriorTime";
            this.UPriorTime.ReadOnly = true;
            this.UPriorTime.Width = 200;
            // 
            // UPriorIP
            // 
            this.UPriorIP.DataPropertyName = "UPriorIP";
            this.UPriorIP.HeaderText = "上次登录IP";
            this.UPriorIP.MinimumWidth = 6;
            this.UPriorIP.Name = "UPriorIP";
            this.UPriorIP.ReadOnly = true;
            this.UPriorIP.Width = 180;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 250;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 604);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPriorTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPriorIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}
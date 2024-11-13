using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class FormRoleRight : Form
    {
        private string _roleid;//保存从主窗体传过来的角色ID
        private string _rolename;//角色名称

        // 依据RoleID获取当前系统所有权限以及该角色以拥有的权限
        private DataTable db_tree = new DataTable();
        public FormRoleRight(string roleid,string rolename)
        {
            _roleid = roleid;
            _rolename = rolename;
            InitializeComponent();
        }

        private void FormRoleRight_Load(object sender, EventArgs e)
        {
            //设置窗体的标题
            this.Text = "角色：" + _rolename + "的权限设置";


            if (_roleid == null || _roleid == "")
                return;
            // 依据RoleID获取当前系统所有权限以及该角色以拥有的权限并保存到db_tree
            db_tree = new studentMS.BLL.core().GetList_RoleRight(_roleid).Tables[0];

            //创建根节点
            this.treeView1.Nodes.Clear();//清空所有节点
            TreeNode root = new TreeNode();
            root.Tag = "0";
            root.Text = "系统权限";
            this.treeView1.Nodes.Add(root);

            //创建父节点的所有子节点
            this.buildChildNode(root);
        }

        private void buildChildNode(TreeNode parentNode)
        {
            //获取节点parentNode的所有子节点的相关信息
            DataRow[] rowList = db_tree.Select(" ParentFID=" + parentNode.Tag);


            //循环 把所有的子节点都展示出来
            foreach (DataRow row in rowList)
            {
                TreeNode node = new TreeNode();
                node.Tag = row["FID"].ToString();
                node.Text = row["FName"].ToString();

                parentNode.Nodes.Add(node);

                //递归
                this.buildChildNode(node);
            }
        }
    }
}

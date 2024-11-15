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

            this.treeView1.ExpandAll();//展开所有节点
        }

        private void buildChildNode(TreeNode parentNode)
        {

            //foreach (DataColumn column in db_tree.Columns)
            //{
            //    Console.WriteLine("列名：" + column.ColumnName);
            //}


            //获取节点parentNode的所有子节点的相关信息
            DataRow[] rowList = db_tree.Select(" ParentFID=" + parentNode.Tag);


            //循环 把所有的子节点都展示出来
            foreach (DataRow row in rowList)
            {
                TreeNode node = new TreeNode();
                node.Tag = row["FID"].ToString();
                node.Text = row["FName"].ToString();

                node.Checked = row["Have"].ToString() != "";//是否已分配

                parentNode.Nodes.Add(node);

                //递归
                this.buildChildNode(node);
            }
        }

        private List<TreeNode> list_node = new List<TreeNode>();//保存所有子节点


        //递归获取所有的子节点并保存到list_node中
        private void getAllChild(TreeNode node)
        {
            list_node.Add(node);
            foreach (TreeNode temp in node.Nodes)
                getAllChild(temp);
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"您确定要提交权限更新吗？","提交确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                bool commited = true;//判断是否成功提交

                studentMS.BLL.b_roleright bll = new studentMS.BLL.b_roleright();
                studentMS.Model.b_roleright model = new studentMS.Model.b_roleright();


                this.getAllChild(this.treeView1.Nodes[0]);


                //遍历所有的节点
                foreach (TreeNode node in list_node)
                {
                    //当前节点被选中且在数据库中不存在，那么就新增并更新到数据库中
                    if(node.Checked)
                    {
                        if(!bll.Exists(int.Parse(_roleid), node.Tag.ToString()))
                        {
                            model.RoleID = int.Parse(_roleid);
                            model.FID = node.Tag.ToString();
                            try
                            {
                                bll.Add(model);
                            }
                            catch 
                            {
                                commited = false;
                            }

                        }

                    }
                    else
                    {
                        //如果当前节点灭有被选中且在数据库中存在，那么就删除并更新到数据库中
                        if(bll.Exists(int.Parse(_roleid), node.Tag.ToString()))
                        {
                            try
                            {
                                bll.Delete(int.Parse(_roleid), node.Tag.ToString());
                            }
                            catch
                            {
                                commited = false;
                            }
                        }
                    }
                    if (commited)
                        this.DialogResult = DialogResult.OK;//设置给主窗体的返回值
                }
            }

        }
    }
}

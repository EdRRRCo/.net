<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="WebApp.left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:steelblue">
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" Height="617px" ImageSet="Arrows">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode Text="系统" Value="系统">
                        <asp:TreeNode Text="重新登录" Value="新建节点"></asp:TreeNode>
                        <asp:TreeNode Text="安全退出" Value="新建节点"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="系统管理" Value="系统管理">
                        <asp:TreeNode Text="角色管理" Value="用户管理"></asp:TreeNode>
                        <asp:TreeNode Text="用户管理" Value="新建节点"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="档案管理" Value="新建节点">
                        <asp:TreeNode Text="学院信息" Value="学院信息"></asp:TreeNode>
                        <asp:TreeNode Text="学生档案" Value="学生档案"></asp:TreeNode>
                        <asp:TreeNode Text="教师档案" Value="教师档案"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="课程管理" Value="新建节点">
                        <asp:TreeNode Text="课程信息" Value="新建节点"></asp:TreeNode>
                        <asp:TreeNode Text="学生选课" Value="新建节点"></asp:TreeNode>
                        <asp:TreeNode Text="教师授课" Value="教师授课"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="成绩管理" Value="成绩管理">
                        <asp:TreeNode Text="成绩录入" Value="成绩录入"></asp:TreeNode>
                        <asp:TreeNode Text="成绩查询" Value="成绩查询"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="统计分析" Value="统计分析">
                        <asp:TreeNode Text="成绩统计--学生" Value="成绩统计--学生"></asp:TreeNode>
                        <asp:TreeNode Text="成绩统计--课程" Value="成绩统计--课程"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="报表管理" Value="报表管理">
                        <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                        <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="关于" Value="关于">
                        <asp:TreeNode Text="软件使用手册" Value="软件使用手册"></asp:TreeNode>
                        <asp:TreeNode Text="关于系统" Value="关于系统"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
    </form>
</body>
</html>

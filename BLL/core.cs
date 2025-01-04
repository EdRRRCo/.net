using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using studentMS.DAL;

namespace studentMS.BLL
{
    public class core
    {
		private readonly studentMS.DAL.core dal = new studentMS.DAL.core();

        private static string strUserRight = "";//保存登录用户的所有权限

        /// <summary>
        /// 依据学号和姓名查询所满足条件的学生信息列表
        /// </summary>
        /// <param name="SNO"></param>
        /// <param name="SName"></param>
        /// <returns></returns>
		public DataSet GetList_student(string SNO,string SName)
        {
            return dal.GetList_student(SNO, SName);
        }

        /// <summary>
        /// 依据工号和姓名查询所满足的老师信息列表
        /// </summary>
        /// <param name="TNO"></param>
        /// <param name="TName"></param>
        /// <returns></returns>
        public DataSet GetList_Teacher(string TNO, string TName)
        {
            return dal.GetList_Teacher(TNO,TName);
        }

        /// <summary>
        /// 依据课程编号和课程名称查询所满足的课程信息列表
        /// </summary>
        /// <param name="CNO"></param>
        /// <param name="CName"></param>
        /// <returns></returns>
        public DataSet GetList_Course(string CNO, string CName)
        {
            return dal.GetList_Course(CNO, CName);
        }

        /// <summary>
        /// 依据SNO获取学生已选课程列表
        /// </summary>
        /// <param name="SNO"></param>
        /// <returns></returns>
        public DataSet GetList_CourseSelected(string SNO)
        {
            return dal.GetList_CourseSelected(SNO);
        }

        /// <summary>
        /// 依据教师工号获取教师授课课程列表
        /// </summary>
        /// <param name="TNO">教师工号</param>
        /// <returns></returns>
        public DataSet GetList_TCSelected(string TNO)
        {
            return dal.GetList_TCSelected(TNO);
        }

        /// <summary>
        /// 依据SNO获取学生可选课程列表
        /// </summary>
        /// <param name="SNO"></param>
        /// <returns></returns>
        public DataSet GetList_UnCourseSelected(string SNO)
        {
            return dal.GetList_UnCourseSelected(SNO);
        }

        /// <summary>
        /// 依据教师工号获取非选择教师的授课课程
        /// </summary>
        /// <param name="TNO"></param>
        /// <returns></returns>
        public DataSet GetList_UnTeach(string TNO)
        {
            return dal.GetList_UnTeach(TNO);
        }

        /// <summary>
        /// 依据课程编号获取选了该课程的学生的学号、姓名和成绩
        /// </summary>
        /// <param name="CNO">课程编号</param>
        /// <returns>DataSet</returns>
        public DataSet GetList_Score(string CNO)
        {
            return dal.GetList_Score(CNO);
        }

        /// <summary>
        /// 依据学号姓名课程名称模糊查询满足条件的成绩记录
        /// </summary>
        /// <param name="SNO">学号</param>
        /// <param name="SName">姓名</param>
        /// <param name="CName">课程名称</param>
        /// <returns></returns>
        public DataSet GetList_Score2(string SNO, string SName, string CName)
        {
            return dal.GetList_Score2(SNO, SName, CName);
        }

        /// <summary>
        /// 依据学院代码和学院名称模糊查询学院信息
        /// </summary>
        /// <param name="DeptNO">学院代码</param>
        /// <param name="DeptName">学院名称</param>
        /// <returns></returns>
        public DataSet GetList_Dept(string DeptNO, string DeptName)
        {
            return dal.GetList_Dept(DeptNO,DeptName);
        }

        /// <summary>
        /// 依据课程名称获取学生成绩情况
        /// </summary>
        /// <param name="CName"></param>
        /// <returns></returns>
        public DataSet GetList_ScoreStatistics(string CName)
        {

            return dal.GetList_ScoreStatistics(CName);
        }

        /// <summary>
        /// 依据课程名称获取课程的成绩情况
        /// </summary>
        /// <param name="CName"></param>
        /// <returns></returns>
        public DataSet GetList_ScoreCourseSta(string CName)
        {
            return dal.GetList_ScoreCourseSta(CName);
        }

        /// <summary>
        /// 依据RoleID获取当前系统所有权限以及该角色以拥有的权限
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        /// <returns></returns>
        public DataSet GetList_RoleRight(string RoleID)
        {
            return dal.GetList_RoleRight(RoleID);
        }


        /// <summary>
        /// 依据uid模糊查询符合条件的数据集
        /// </summary>
        /// <param name="UID">用户名</param>
        /// <returns></returns>
        public DataSet GetList_User(string UID)
        {
            return dal.GetList_User(UID);
        }

        /// <summary>
        /// 依据用户名和密码查询该用户是否存在
        /// </summary>
        /// <param name="UID">用户名</param>
        /// <param name="UCode">密码</param>
        /// <returns></returns>
        public bool ExistUIDUCode(string UID, string UCode)
        {
            return dal.ExistUIDUCode(UID,UCode);
        }


        /// <summary>
        /// 获取用户user的权限列表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public void Get_RightByUser(string user)
        {
            strUserRight = ",";//初始化


            //从数据库中获取登录用户的所有权限列表
            DataTable tb_right = new studentMS.DAL.core().Get_RightByUser(user).Tables[0];

            //遍历DataTable中所有记录，八FID累加到字符串=石头人UserRIght中
            foreach(DataRow row in tb_right.Rows)
            {
                strUserRight += row["FID"].ToString() + ",";
            }

        }

        /// <summary>
        /// 判断当前登录用户名是否拥有编号为FID的权限
        /// </summary>
        /// <param name="FID">权限编号</param>
        /// <returns></returns>
        public bool haveRight(string FID)
        {
            return strUserRight.Contains("," + FID + ",");
        }
    }
}

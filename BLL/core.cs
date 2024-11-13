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
        /// 依据SNO获取学生已选课程列表
        /// </summary>
        /// <param name="SNO"></param>
        /// <returns></returns>
        public DataSet GetList_CourseSelected(string SNO)
        {
            return dal.GetList_CourseSelected(SNO);
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
        /// 依据课程名称获取学生成绩情况
        /// </summary>
        /// <param name="CName"></param>
        /// <returns></returns>
        public DataSet GetList_ScoreStatistics(string CName)
        {

            return dal.GetList_ScoreStatistics(CName);
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

    }
}

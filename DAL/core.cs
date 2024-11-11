using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	public class core
	{
		public core()
		{}

        /// <summary>
        /// 依据学号和姓名查询所满足条件的学生信息列表
        /// </summary>
        /// <param name="SNO"></param>
        /// <param name="SName"></param>
        /// <returns></returns>
        public DataSet GetList_student(string SNO, string SName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.*,b.DeptName from student a,department b ");
            strSql.Append(" where a.DeptNO =b.DeptNO and SNO like ?SNO and SName like ?SName");
            MySqlParameter[] parameters = {
                    new MySqlParameter("?SNO", MySqlDbType.VarChar),
                    new MySqlParameter("?SName", MySqlDbType.VarChar)};
            parameters[0].Value = "%" + SNO + "%";
            parameters[1].Value = "%" + SName + "%";

            return DbHelperMySQL.Query(strSql.ToString(), parameters);
        }
        
        /// <summary>
        /// 依据学号SNO获取学生已选课程列表
        /// </summary>
        /// <param name="SNO"></param>
        /// <returns></returns>
        public DataSet GetList_CourseSelected(string SNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CNO,CName,Credit FROM course ");
            strSql.Append(" where CNO in (select CNO from s_c where SNO = '" + SNO + " ')");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 依据学号SNO获取学生可选课程列表
        /// </summary>
        /// <param name="SNO"></param>
        /// <returns></returns>
        public DataSet GetList_UnCourseSelected(string SNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CNO,CName,Credit FROM course ");
            strSql.Append(" where CNO not in (select CNO from s_c where SNO = '" + SNO + " ')");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 依据课程编号获取选了该课程的学生的学号、姓名和成绩
        /// </summary>
        /// <param name="CNO">课程编号</param>
        /// <returns>DataSet</returns>
        public DataSet GetList_Score(string CNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.SNO,b.SName,a.Score from s_c a,student b ");
            strSql.Append(" where a.SNO = b.SNO and a.CNO = '" + CNO + "'");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 依据学号姓名课程名称模糊查询满足条件的成绩记录
        /// </summary>
        /// <param name="SNO">学号</param>
        /// <param name="SName">姓名</param>
        /// <param name="CName">课程名称</param>
        /// <returns></returns>
        public DataSet GetList_Score2(string SNO,string SName,string CName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.SNO,b.SName,b.SSex,a.CNO,c.CName,a.Score ");
            strSql.Append(" from s_c a,student b，course ");
            strSql.Append(" where a.SNO = b.SNO and a.CNO = c.CNO ");

            if(!(SNO != null || SNO ==""))
                strSql.Append(" and a.SNO like '%" + SNO + "%'");
            if (!(SName != null || SName == ""))
                strSql.Append(" and a.SName like '%" + SName + "%'");
            if (!(CName != null || CName == ""))
                strSql.Append(" and a.CName like '%" + CName + "%'");

            return DbHelperMySQL.Query(strSql.ToString());
        }



        /// <summary>
        /// 依据课程名称获取学生成绩情况
        /// </summary>
        /// <param name="CName"></param>
        /// <returns></returns>
        public DataSet GetList_ScoreStatistics(string CName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.SNO,b.SName,b.SSex, ");
            strSql.Append(" Max(Score) as ScoreMax,Min(Score) as ScoreMin, avg(Score) as ScoreAvg ");
            strSql.Append(" FROM student.s_c a,student b ");

            if (!(CName != null || CName == ""))
                strSql.Append(" where a.CNO in(select CNO from course where CName like '%" + CName + "%')");
            strSql.Append(" group by a.SNO,b.SName,b.SSex; ");


            return DbHelperMySQL.Query(strSql.ToString());
        }
            
    }
}

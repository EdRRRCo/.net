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
    }
}

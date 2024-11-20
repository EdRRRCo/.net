using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	/// <summary>
	/// 教师授课
	/// </summary>
	public class t_c
	{
		public t_c()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string TNO,string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from t_c");
			strSql.Append(" where TNO=?TNO and CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar),
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = TNO;
			parameters[1].Value = CNO;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.t_c model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into t_c(");
			strSql.Append("TNO,CNO)");
			strSql.Append(" values (");
			strSql.Append("?TNO,?CNO)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar,25),
					new MySqlParameter("?CNO", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.TNO;
			parameters[1].Value = model.CNO;

			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.t_c model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update t_c set ");

			#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！
			strSql.Append("TNO=?TNO,");
			strSql.Append("CNO=?CNO");
			strSql.Append(" where TNO=?TNO and CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar,25),
					new MySqlParameter("?CNO", MySqlDbType.VarChar,50)};
			parameters[0].Value = model.TNO;
			parameters[1].Value = model.CNO;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string TNO,string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from t_c ");
			strSql.Append(" where TNO=?TNO and CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar),
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = TNO;
			parameters[1].Value = CNO;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.t_c GetModel(string TNO,string CNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TNO,CNO from t_c ");
			strSql.Append(" where TNO=?TNO and CNO=?CNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar),
					new MySqlParameter("?CNO", MySqlDbType.VarChar)};
			parameters[0].Value = TNO;
			parameters[1].Value = CNO;

			studentMS.Model.t_c model=new studentMS.Model.t_c();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.TNO=ds.Tables[0].Rows[0]["TNO"].ToString();
				model.CNO=ds.Tables[0].Rows[0]["CNO"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获取数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TNO,CNO ");
			strSql.Append(" FROM t_c ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		#endregion  Method
	}
}


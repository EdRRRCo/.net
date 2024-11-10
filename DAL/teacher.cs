using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Maticsoft.DBUtility;
namespace studentMS.DAL
{
	/// <summary>
	/// 教工信息
	/// </summary>
	public class teacher
	{
		public teacher()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string TNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from teacher");
			strSql.Append(" where TNO=?TNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar)};
			parameters[0].Value = TNO;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.teacher model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into teacher(");
			strSql.Append("TNO,TName,TSex,Address,Tel,Tstatus)");
			strSql.Append(" values (");
			strSql.Append("?TNO,?TName,?TSex,?Address,?Tel,?Tstatus)");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar,25),
					new MySqlParameter("?TName", MySqlDbType.VarChar,45),
					new MySqlParameter("?TSex", MySqlDbType.VarChar,10),
					new MySqlParameter("?Address", MySqlDbType.VarChar,200),
					new MySqlParameter("?Tel", MySqlDbType.VarChar,45),
					new MySqlParameter("?Tstatus", MySqlDbType.VarChar,45)};
			parameters[0].Value = model.TNO;
			parameters[1].Value = model.TName;
			parameters[2].Value = model.TSex;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.Tel;
			parameters[5].Value = model.Tstatus;

			return DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.teacher model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update teacher set ");
			strSql.Append("TName=?TName,");
			strSql.Append("TSex=?TSex,");
			strSql.Append("Address=?Address,");
			strSql.Append("Tel=?Tel,");
			strSql.Append("Tstatus=?Tstatus");
			strSql.Append(" where TNO=?TNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar,25),
					new MySqlParameter("?TName", MySqlDbType.VarChar,45),
					new MySqlParameter("?TSex", MySqlDbType.VarChar,10),
					new MySqlParameter("?Address", MySqlDbType.VarChar,200),
					new MySqlParameter("?Tel", MySqlDbType.VarChar,45),
					new MySqlParameter("?Tstatus", MySqlDbType.VarChar,45)};
			parameters[0].Value = model.TNO;
			parameters[1].Value = model.TName;
			parameters[2].Value = model.TSex;
			parameters[3].Value = model.Address;
			parameters[4].Value = model.Tel;
			parameters[5].Value = model.Tstatus;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string TNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from teacher ");
			strSql.Append(" where TNO=?TNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar)};
			parameters[0].Value = TNO;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			return (rows > 0);
		}

		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string TNOlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from teacher ");
			strSql.Append(" where TNO in ("+TNOlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			return (rows > 0);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.teacher GetModel(string TNO)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TNO,TName,TSex,Address,Tel,Tstatus from teacher ");
			strSql.Append(" where TNO=?TNO");
			MySqlParameter[] parameters = {
					new MySqlParameter("?TNO", MySqlDbType.VarChar)};
			parameters[0].Value = TNO;

			studentMS.Model.teacher model=new studentMS.Model.teacher();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				model.TNO=ds.Tables[0].Rows[0]["TNO"].ToString();
				model.TName=ds.Tables[0].Rows[0]["TName"].ToString();
				model.TSex=ds.Tables[0].Rows[0]["TSex"].ToString();
				model.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				model.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				model.Tstatus=ds.Tables[0].Rows[0]["Tstatus"].ToString();
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
			strSql.Append("select TNO,TName,TSex,Address,Tel,Tstatus ");
			strSql.Append(" FROM teacher ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}
		#endregion  Method
	}
}


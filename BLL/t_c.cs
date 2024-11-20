using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using studentMS.DAL;
namespace studentMS.BLL
{
	/// <summary>
	/// 教师授课
	/// </summary>
	public class t_c
	{
		private readonly studentMS.DAL.t_c dal=new studentMS.DAL.t_c();
		public t_c()
		{}
		#region  Method

		/// <summary>
		/// 是否存在
		/// </summary>
		public bool Exists(string TNO,string CNO)
		{
			return dal.Exists(TNO,CNO);
		}

		/// <summary>
		/// 新增一条数据
		/// </summary>
		public int Add(studentMS.Model.t_c model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(studentMS.Model.t_c model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string TNO,string CNO)
		{
			return dal.Delete(TNO,CNO);
		}

		/// <summary>
		/// 获取单条记录详细信息
		/// </summary>
		public studentMS.Model.t_c GetModel(string TNO,string CNO)
		{
				return dal.GetModel(TNO,CNO);
		}

		/// <summary>
		/// 获取数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		/// <summary>
		/// 获取数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return dal.GetList("");
		}
		#endregion  Method
	}
}


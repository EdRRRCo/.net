using System;

namespace studentMS.Model
{
	/// <summary>
	/// 教工信息
	/// </summary>
	[Serializable]
	public class teacher
	{
		public teacher()
		{}
		#region Model
		private string _tno;
		private string _tname;
		private string _tsex;
		private string _address;
		private string _tel;
		private string _tstatus;
		/// <summary>
		/// 教工工号
		/// </summary>
		public string TNO
		{
			set{ _tno=value;}
			get{return _tno;}
		}
		/// <summary>
		/// 教工姓名
		/// </summary>
		public string TName
		{
			set{ _tname=value;}
			get{return _tname;}
		}
		/// <summary>
		/// 教工性别
		/// </summary>
		public string TSex
		{
			set{ _tsex=value;}
			get{return _tsex;}
		}
		/// <summary>
		/// 教工地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 教工电话
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 教工在职状态
		/// </summary>
		public string Tstatus
		{
			set{ _tstatus=value;}
			get{return _tstatus;}
		}
		#endregion Model
	}
}


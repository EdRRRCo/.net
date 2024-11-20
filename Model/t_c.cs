using System;

namespace studentMS.Model
{
	/// <summary>
	/// 教师授课
	/// </summary>
	[Serializable]
	public class t_c
	{
		public t_c()
		{}
		#region Model
		private string _tno;
		private string _cno;
		/// <summary>
		/// 教工工号
		/// </summary>
		public string TNO
		{
			set{ _tno=value;}
			get{return _tno;}
		}
		/// <summary>
		/// 课程编号
		/// </summary>
		public string CNO
		{
			set{ _cno=value;}
			get{return _cno;}
		}
		#endregion Model
	}
}


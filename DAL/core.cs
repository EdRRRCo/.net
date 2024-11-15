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
        /// ����ѧ�ź�������ѯ������������ѧ����Ϣ�б�
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
        /// ����ѧ��SNO��ȡѧ����ѡ�γ��б�
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
        /// ����ѧ��SNO��ȡѧ����ѡ�γ��б�
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
        /// ���ݿγ̱�Ż�ȡѡ�˸ÿγ̵�ѧ����ѧ�š������ͳɼ�
        /// </summary>
        /// <param name="CNO">�γ̱��</param>
        /// <returns>DataSet</returns>
        public DataSet GetList_Score(string CNO)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.SNO,b.SName,a.Score from s_c a,student b ");
            strSql.Append(" where a.SNO = b.SNO and a.CNO = '" + CNO + "'");

            return DbHelperMySQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ����ѧ�������γ�����ģ����ѯ���������ĳɼ���¼
        /// </summary>
        /// <param name="SNO">ѧ��</param>
        /// <param name="SName">����</param>
        /// <param name="CName">�γ�����</param>
        /// <returns></returns>
        public DataSet GetList_Score2(string SNO,string SName,string CName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.SNO,b.SName,b.SSex,a.CNO,c.CName,a.Score ");
            strSql.Append(" from s_c a,student b��course ");
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
        /// ���ݿγ����ƻ�ȡѧ���ɼ����
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

        /// <summary>
        /// ����RoleID��ȡ��ǰϵͳ����Ȩ���Լ��ý�ɫ��ӵ�е�Ȩ��
        /// </summary>
        /// <param name="RoleID">��ɫID</param>
        /// <returns></returns>
        public DataSet GetList_RoleRight(string RoleID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.FID,a.FName,a.ParentFID,b.FID as Have from b_sysfunction a ");
            strSql.Append(" left join b_roleright b on a.FID = b.FID and b.RoleID =" + RoleID);

            return DbHelperMySQL.Query(strSql.ToString());
        }
            

        /// <summary>
        /// ����uidģ����ѯ�������������ݼ�
        /// </summary>
        /// <param name="UID">�û���</param>
        /// <returns></returns>
        public DataSet GetList_User(string UID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT a.UID,a.RoleID,a.UPriorTime,a.UPriorIP,a.Remark,b.RoleName ");
            strSql.Append(" FROM b_user a,b_role b where a.RoleID=b.RoleID " );

            if(UID != "")
            {
                strSql.Append(" and UID like '%" + UID +"%'");
            }

            return DbHelperMySQL.Query(strSql.ToString());
        }


        /// <summary>
        /// �����û����������ѯ���û��Ƿ����
        /// </summary>
        /// <param name="UID">�û���</param>
        /// <param name="UCode">����</param>
        /// <returns></returns>
        public bool ExistUIDUCode(string UID, string UCode)
        {
            string strsql = "SELECT count(UID) FROM b_user where UID = '"
                + UID + "' and UCode = '" + UCode + "'";
            Object obj = DbHelperMySQL.GetSingle(strsql);

            if (obj == null || obj.ToString() == "" || obj.ToString() == "0")
                return false;
            else
                return true;
        }
    }
}

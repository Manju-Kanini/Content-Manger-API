using System;
using CM_Login.Models;
using System.Data.SqlClient;
using System.Data;  



namespace CM_Login.Repository
{
    public class CM_Repo:ICM_Repo<Content_Manager>
    {


        public static SqlConnection con;
        public static SqlCommand cmd;
        public static void getcon()
        {

            con = new SqlConnection("Data Source=LAPTOP-6MJE97ED\\SQLSERVER2019G3;Initial Catalog=learningportaldb;Integrated Security=true");
            con.Open();
        }
        public List<Content_Manager> GetAllCM()
        {

            List<Content_Manager> cm = new List<Content_Manager>();
            CM_Repo.getcon();
            cmd = new SqlCommand("SelectallContentmanager");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Content_Manager c = new Content_Manager();
                c.CM_id = Convert.ToInt32(dr[0]);
                c.CM_name = dr[1].ToString();
                c.CM_age = Convert.ToInt32(dr[2]);
                c.CM_email = dr[3].ToString();
                c.CM_password = dr[4].ToString();
                c.CM_phoneno = dr[5].ToString();
                c.CM_image = dr[6].ToString();
                c.CM_role_id = Convert.ToInt32(dr[7]);
                cm.Add(c);
            }
            return cm;

        }


        public  void insertCM(Content_Manager C)
        {
            CM_Repo.getcon();
            cmd = new SqlCommand("insertcm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@CM_id", C.CM_id);
            cmd.Parameters.AddWithValue("@CM_name", C.CM_name);
            cmd.Parameters.AddWithValue("@CM_age", C.CM_age);
            cmd.Parameters.AddWithValue("@CM_Email", C.CM_email);
            cmd.Parameters.AddWithValue("@CM_pass", C.CM_password);
            cmd.Parameters.AddWithValue("@CM_phoneno", C.CM_phoneno);
            cmd.Parameters.AddWithValue("@CM_image", C.CM_image);
            cmd.Parameters.AddWithValue("@role_id", C.CM_role_id);
            cmd.ExecuteNonQuery();

        }

        public  void UpdateCM(Content_Manager C, int CM_id)
        {
            CM_Repo.getcon();
            cmd = new SqlCommand("updatecm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@CM_id", C.CM_id);
            cmd.Parameters.AddWithValue("@CM_pass", C.CM_password);
            cmd.ExecuteNonQuery();
        }


        public  bool DeleteCM(int CM_id)
        {

            CM_Repo.getcon();
            cmd = new SqlCommand("deletecm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@CM_id", CM_id);
            if (cmd.ExecuteNonQuery() == 1)
                return true;
            else
                return false;

        }

        public List<Content_Manager> SelectBy_CM_id(int CM_id)
        {
            List<Content_Manager> cm = new List<Content_Manager>();
            CM_Repo.getcon();
            cmd = new SqlCommand("SelectCM_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CM_id", CM_id);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Content_Manager c = new Content_Manager();
                c.CM_id = Convert.ToInt32(dr[0]);
                c.CM_name = dr[1].ToString();
                c.CM_age = Convert.ToInt32(dr[2]);
                c.CM_email = dr[3].ToString();
                c.CM_password = dr[4].ToString();
                c.CM_phoneno = dr[5].ToString();
                c.CM_image = dr[6].ToString();
                c.CM_role_id = Convert.ToInt32(dr[7]);
                cm.Add(c);
            }
            return cm;

        }
    }
}


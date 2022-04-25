using System.Data.SqlClient;
using System.Data;


namespace CM_Login.Models
{
    public class Content_Manager
    {

        public int CM_id { get; set; }
        public string CM_name { get; set; }

        public int CM_age { get; set; }

        public string CM_email { get; set; }

        public string CM_password { get; set; }

        public string CM_phoneno { get; set; }

        public string CM_image { get; set; }

        public int CM_role_id { get; set; }

        public Content_Manager()
        {

        }
    }
}

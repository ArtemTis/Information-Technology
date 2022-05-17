using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication5
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void AddGuest(String name, String email, String phone, Boolean? agree)
        {
            string str = System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ConnectionString;
           
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                string sql; 
                SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM Guests WHERE ([Phone] = @phone)", con);
                checkUser.Parameters.AddWithValue("@phone", phone);
                int UserExist = (int)checkUser.ExecuteScalar();

                if (UserExist > 0)
                {
                    sql = string.Format("UPDATE Guests" + " SET Email = @Email, Agreement = @Agreement, Name = @Name WHERE Phone = @Phone");
                }
                else
                {
                    sql = string.Format("INSERT INTO Guests" + "(Name, Email, Phone, Agreement) VALUES (@Name, @Email, @Phone, @Agreement)");
                }
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Agreement", agree);

                    cmd.ExecuteNonQuery();
                }


            }

        }
    }
}


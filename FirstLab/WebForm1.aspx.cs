using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstLab
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitForm_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dataBase = new Dictionary<string, string>();
            dataBase.Add("alex", "qwerty");
            dataBase.Add("tom", "zxc123");
            dataBase.Add("ivan", "12345");

            if (dataBase.ContainsKey(TextBoxLogin.Text.ToLower())){
                if (dataBase[TextBoxLogin.Text.ToLower()] == TextBoxPassword.Text)
                {
                    Response.Redirect("WebForm2.aspx");
                }
                else Validity.Text = "Неверный логин или пароль";
            }
            else Validity.Text = "Неверный логин или пароль";

            /*Dictionary<string, string> dataBase = new Dictionary<string, string>
            {
                {"Kate", "wwq" },
                {"Ann", "rrr"},
                {"Alex", "http" }
            };*/
        }
    }
}
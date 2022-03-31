using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstLab
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged()
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String url = "TextBox: " + Input.Text;
            url += "<br/> ListBox: " + InputList.SelectedValue;
            url += "<br/> DropDownList: " + DropDownList.SelectedValue;
            if (Processor.Checked)
            {
                url += "<br/> RadioButton1: " + Processor.Text;
            }
            if (GraficCard.Checked)
            {
                url += "<br/> RadioButton2: " + GraficCard.Text;
            }
            if (MotherBoard.Checked)
            {
                url += "<br/> RadioButton3: " + MotherBoard.Text;
            }
            Label1.Text = url;
        }
    }
}
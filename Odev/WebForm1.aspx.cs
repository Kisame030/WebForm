using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            string kAd = TextBox1.Text;
            string sif = TextBox2.Text;
            

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\21100001065\\Pictures\\Odev.accdb";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Login WHERE kAd=? AND sifre=?";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", TextBox1.Text);
                    cmd.Parameters.AddWithValue("?", TextBox2.Text);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        Session["username"] = TextBox1.Text;
                        Response.Redirect("WebForm2.aspx");
                    }
                    else
                    {
                        Label2.Text = "Kullanıcı adı veya şifre yanlış.";
                        Label2.Visible = true;
                    }

                }
            }
        }


    }
}
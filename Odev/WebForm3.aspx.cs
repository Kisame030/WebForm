using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Style["float"] = "right";
            Label1.Text = "Oguzhan Türkdoğan";
            if (!IsPostBack)
            {
                string Ders = Session["Ders"].ToString();
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\21100001065\\Pictures\\Odev.accdb");
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Dersler WHERE DersAdi = @DersAdi", con);
                cmd.Parameters.AddWithValue("@DersAdi", Ders);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                reader.Close();
                con.Close();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}
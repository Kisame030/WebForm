using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            Label1.Text = "Kullanıcı Adı: " + username;

            if (!IsPostBack)
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\21100001065\\Pictures\\Odev.accdb");
                OleDbCommand cmd = new OleDbCommand("SELECT DersAdi FROM Dersler",con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListBox1.Items.Add(reader["DersAdi"].ToString());
                }
                reader.Close();
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\21100001065\\Pictures\\Odev.accdb");
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Dersler (DersAdi, Ogretmen, Gun, Saat) VALUES (@DersAdi, @Ogretmen, @Gun, @Saat)", con);
            cmd.Parameters.AddWithValue("@DersAdi", DropDownList4.SelectedValue);
            cmd.Parameters.AddWithValue("@Ogretmen", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("@Gun", DropDownList2.SelectedValue);
            cmd.Parameters.AddWithValue("@Saat", DropDownList3.SelectedValue);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            ListBox1.Items.Add(DropDownList4.SelectedValue.ToString());

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try {
                Session["Ders"] = ListBox1.SelectedValue;
                Response.Redirect("WebForm3.aspx");
            }catch (Exception ex) 
            {
                Response.Write("İtem seçin");
            }
            
        }
    }
}
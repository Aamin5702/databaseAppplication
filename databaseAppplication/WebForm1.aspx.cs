using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace databaseAppplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aamin\source\repos\databaseAppplication\databaseAppplication\App_Data\Database1.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string InsertQuery = "insert into Author values(@Author_Name, @Author_ID, @Author_Adrs, @Author_PhoneNo)";
            SqlCommand cmd = new SqlCommand(InsertQuery, con);
            cmd.Parameters.AddWithValue("@Author_Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Author_ID", txtID.Text);
            cmd.Parameters.AddWithValue("@Author_PhoneNo", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Author_Adrs", txtAdd.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Record Inserted Successfully !!";
            con.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string DeleteQuery = "delete from Author where Author_ID=@Author_ID";
            SqlCommand cmd = new SqlCommand(DeleteQuery, con);
            cmd.Parameters.AddWithValue("@Author_ID", txtID.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Record Deleted Successfuly.";
            con.Close();

        }

        protected void btnView_Click1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Author", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebADOo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                Response.Write("<center><h1>Read data from database</h1></center><hr/>");
                Response.Write("<br/>");
                // read connection string
                string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

                // create sqlconnection
                SqlConnection con = new SqlConnection(s);
                // setup query string
                string qry = "select * from customers";
                //setup sql command obj
                SqlCommand cmd = new SqlCommand(qry, con);
                // open connection
                con.Open();
                //execute

                SqlDataReader reader = cmd.ExecuteReader();

                //use cmd.ExecuteNonQuery() for Insert Update Delete
                // setup and bind data source to view
                GridView1.DataSource = reader;
                GridView1.DataBind();

                //close reader
                reader.Close();

                string sqlStringDropDownList = "select Country from customers";
                SqlCommand cmd2 = new SqlCommand(sqlStringDropDownList, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read() == true)
                {
                    DropDownList1.Items.Add(new ListItem(dr2["Country"].ToString(), dr2["Country"].ToString()));
                }

                dr2.Close();
                con.Close();

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            String txtValue = TextBox1.Text;
            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            string sqlString = "select * from customers where Country=@Country";
            SqlCommand cmd = new SqlCommand(sqlString, con);

            //sanitisastion
            cmd.Parameters.AddWithValue("@Country", txtValue);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();

            dr.Close();
            con.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Write("<br/>");
                string txtValue = DropDownList1.SelectedValue.ToString();
                string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
                SqlConnection con = new SqlConnection(s);
                string sqlString = "select * from customers where Country=@Country";
                SqlCommand cmd = new SqlCommand( sqlString, con);
                cmd.Parameters.AddWithValue("@Country", txtValue);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Close();
                con.Close();
            }
        }
    }
}
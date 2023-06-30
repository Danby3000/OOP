using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
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
                string qry = "select * from Playing";
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

                string sqlStringDropDownList = "select suit from Playing";
                SqlCommand cmd2 = new SqlCommand(sqlStringDropDownList, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read() == true)
                {
                    DropDownList1.Items.Add(new ListItem(dr2["suit"].ToString(), dr2["suit"].ToString()));
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
            string sqlString = "select * from Playing where suit=@suit";
            SqlCommand cmd = new SqlCommand(sqlString, con);

            //sanitisastion
            cmd.Parameters.AddWithValue("@suit", txtValue);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();

            dr.Close();
            con.Close();
        }

        protected void fullTable()
        {
            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            string sqlString = "select * from Playing";
            SqlCommand cmd = new SqlCommand(sqlString, con);
           
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
                string sqlString = "select * from Playing where suit=@suit";
                SqlCommand cmd = new SqlCommand( sqlString, con);
                cmd.Parameters.AddWithValue("@suit", txtValue);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Close();
                con.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
                String txtValue = TextBox2.Text;
                string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
                SqlConnection con = new SqlConnection(s);
                string sqlString = "delete from Playing where cardID=@cardID";
                SqlCommand cmd = new SqlCommand(sqlString, con);

                //sanitisastion
                cmd.Parameters.AddWithValue("@cardID", txtValue);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();

                dr.Close();
                con.Close();
                fullTable();
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string txtValue1 = TextBox3.Text;
            string txtValue2 = TextBox4.Text;
            String index = TextBox2.Text;
            bool check = Update.Checked;

            //check inputs

            string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            string sqlString = "insert into Playing values (@value, @suit)";
            if (check)
            {
                sqlString = "update Playing set value=@value, suit=@suit where cardID=@cardID";
            } 
                
            SqlCommand cmd = new SqlCommand(sqlString, con);

            //sanitisastion
            cmd.Parameters.AddWithValue("@value", txtValue1);
            cmd.Parameters.AddWithValue("@suit", txtValue2);
            if (check)
            {
                cmd.Parameters.AddWithValue("@cardID", index);
            }
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();

            dr.Close();
            con.Close();
            fullTable();
        }
    }
}
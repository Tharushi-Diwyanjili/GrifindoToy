using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S28DADF;Initial Catalog=Grifindo_Toy;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Clear()
        {

            
            salcyDrngtxt.Clear();
            salcyBdte.Text = "";
            salcyEdte.Text = "";
            NoOflvstxt.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string sqlsearch;
                sqlsearch = "Select * from Setting";
                SqlCommand cmd = new SqlCommand(sqlsearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    salcyDrngtxt.Text = dr["SalCycle_DateRange"].ToString();
                    salcyBdte.Text = dr["SalCycle_Bdate"].ToString();
                    salcyEdte.Text = dr["SalCycle_Edate"].ToString();
                    NoOflvstxt.Text = dr["No_Of_Leaves"].ToString();
                    taxtxt.Text = dr["Goverment_Tax"].ToString();

                }


                else
                {}

                con.Close();


            }//end of try
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdate;
                sqlUpdate = "update Setting set SalCycle_DateRange= '" + salcyDrngtxt.Text + "' , SalCycle_Bdate  = '" + salcyBdte.Value + "' ,SalCycle_Edate  = '" + salcyEdte.Value + "', No_Of_Leaves = '" + NoOflvstxt.Text + "', Goverment_tax = '" + taxtxt.Text+ "' ";
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
                con.Close();
                Clear();

                

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);


            }
        }
    }
}

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
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S28DADF;Initial Catalog=Grifindo_Toy;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqllogin;
                sqllogin = "Select * from Login where User_Name = '" + usernametxt.Text + "'";
                sqllogin = "Select * from Login where Password = '" + passwordtxt.Text + "'";
                SqlCommand cmd = new SqlCommand(sqllogin, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    var newform = new Home_menu();
                    newform.Show();


                }


                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    usernametxt.Clear();
                    passwordtxt.Clear();
                    usernametxt.Focus();


                }

                con.Close();


            }//end of try
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}

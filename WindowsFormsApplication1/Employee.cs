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
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S28DADF;Initial Catalog=Grifindo_Toy;Integrated Security=True");
        
        public Employee()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fillcombo();
           

        }

        private void Clear()
        {
            
            
            nametxt.Clear();
            agetxt.Clear();
            contacttxt.Clear();
            emailtxt.Clear();
            saltxt.Clear();
            otrtxt.Clear();
            allwnstxt.Clear();
            dateTimePicker1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            empidcombo.Focus();



        }

        

        private void fillcombo()
        {
            string sqlcombo;
            sqlcombo = "select EmpID from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlcombo, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            empidcombo.DataSource = dt;
            empidcombo.ValueMember = "EmpID";
            empidcombo.DisplayMember = "EmpID";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsearch;
                sqlsearch = "Select * from Employee where EmpID = '" + empidcombo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlsearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    if (dr["Gender"].Equals("M"))
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    nametxt.Text = dr["EmpName"].ToString();
                    agetxt.Text = dr["Age"].ToString();
                    contacttxt.Text = dr["Contact_Number"].ToString();
                    emailtxt.Text = dr["Email"].ToString();
                    dateTimePicker1.Text = dr["Joined_Date"].ToString();
                    saltxt.Text = dr["Salary"].ToString();
                    otrtxt.Text = dr["OT_Rate"].ToString();
                    allwnstxt.Text = dr["Allowance"].ToString();

                }


                else
                {
                    MessageBox.Show("Invalid EmpID");
                    Clear();


                }

                con.Close();


            }//end of try
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void insrtbtn_Click(object sender, EventArgs e)
        {
            try
            {
                String gen;
                if (radioButton1.Checked == true)
                    gen = "M";

                else gen = "F";
                string sqlInsert;
                sqlInsert = "insert into Employee (EmPID,EmpName,Age,Gender,Contact_Number,Email,Joined_Date,Salary, OT_Rate,Allowance) values ('" + empidcombo.Text + "','" + nametxt.Text + "','" + agetxt.Text + "','" + gen + "','" + contacttxt.Text + "','" + emailtxt.Text + "','" + dateTimePicker1.Value + "','" + saltxt.Text + "','" + otrtxt.Text + "','" + allwnstxt.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted");
                con.Close();
                Clear();
                fillcombo();
                

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
   
            }
        }

        private void updtbtn_Click(object sender, EventArgs e)
        {
            try
            {
                String gen;
                if (radioButton1.Checked == true)
                    gen = "M";
                else
                    gen = "F";
                string sqlUpdate;
                sqlUpdate = "update Employee set EmpID= '" + empidcombo.Text + "', EmpName= '" + nametxt.Text + "', Age = '" + agetxt.Text + "' , Gender = '" + "" + gen + "' ,Contact_Number = '" + contacttxt.Text + "', Email = '" + emailtxt.Text + "' , joined_Date  = '" + dateTimePicker1.Value + "' , Salary = '" + saltxt.Text + "',OT_Rate= '" + otrtxt.Text + "' , Allowance= '" + allwnstxt.Text + "' Where EmpID = '" + empidcombo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
                con.Close();
                Clear();
                
                fillcombo();

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);


            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Are you sure to delete this records?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ans == DialogResult.Yes)
            {
                string sqlDel;
                sqlDel = "delete from Employee where EmpID ='" + empidcombo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlDel, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Deleted");


            }
            con.Close();
            Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            var showall = new AllemployeeDetails();
            showall.Show();
   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home_menu menuform = new Home_menu();
            menuform.Show();
        }
    }
}

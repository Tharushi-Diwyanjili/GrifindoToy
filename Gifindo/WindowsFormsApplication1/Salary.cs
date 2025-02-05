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
    public partial class Salary : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S28DADF;Initial Catalog=Grifindo_Toy;Integrated Security=True");

        float salary, nopay , salcycledays , absentdays, basepay, allowances, OT_rate, OT_hours, tax, grosspay;


       

        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            { 
                string sqlInsert;
                sqlInsert = "insert into Salary (EmPID,EmpName,Month, No_pay_value,Base_pay_value,Gross_pay_value) values ('" + empidtxt.Text + "','" + nametxt.Text + "','" + salcyBdte.Value.ToString("MMM")  + "','" + nopaytxt.Text  + "','" + basepaytxt.Text + "','" + grosspaytxt.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted in to salary Table");
                con.Close();
                
                


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }
        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salgrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void salcyBdte_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void salary_calculation()
        {
            salary = float.Parse(saltxt.Text);
            salcycledays = float.Parse(salcyDrngtxt.Text);
            absentdays = float.Parse(absenttxt.Text);
            allowances=float.Parse(allwnstxt.Text);
            OT_rate = float.Parse(otrtxt.Text);
            OT_hours = float.Parse(othourstxt.Text);
            tax = float.Parse((taxtxt.Text).ToString());
        }
        

        public Salary()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void otrtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void validatetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlvalidate;
                sqlvalidate = "Select * from Setting where SalCycle_Bdate = '" + salcyBdte.Value + "'";
                sqlvalidate = "Select * from Setting where SalCycle_Edate = '" + salcyEdte.Value + "'" ;
                SqlCommand cmd = new SqlCommand(sqlvalidate, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    salcyDrngtxt.Text = dr["SalCycle_DateRange"].ToString();
                    NoOflvstxt.Text = dr["No_Of_Leaves"].ToString();
                    taxtxt.Text = dr["Goverment_tax"].ToString();
 

                }


                else
                {
                    MessageBox.Show("Invalid Date");
                    salcyDrngtxt.Clear();
                    NoOflvstxt.Clear();
                    taxtxt.Clear();


                }

                con.Close();


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsearch;
                sqlsearch = "Select * from Employee where EmpID = '" + empidtxt.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlsearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nametxt.Text = dr["EmpName"].ToString();
                    otrtxt.Text = dr["OT_Rate"].ToString();
                    allwnstxt.Text = dr["Allowance"].ToString();
                    saltxt.Text = dr["Salary"].ToString();
                }


                else
                {
                    MessageBox.Show("Invalid EmpID");
                    empidtxt.Clear();
                    nametxt.Clear();
                    otrtxt.Clear();
                    allwnstxt.Clear();
                    saltxt.Clear();


                }

                con.Close();


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void calbtn_Click(object sender, EventArgs e)
        {
            salary_calculation();

            //No_Pay_Value
            nopay = (salary / salcycledays) * absentdays;
            nopaytxt.Text = nopay.ToString();

            //Base_Pay_Value
            basepay = salary + allowances + (OT_rate * OT_hours);
            basepaytxt.Text = basepay.ToString();

            //Gross_Pay_Value
            grosspay = basepay - (nopay + basepay * tax);
            grosspaytxt.Text = grosspay.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

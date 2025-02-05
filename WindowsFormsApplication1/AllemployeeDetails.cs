using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AllemployeeDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S28DADF;Initial Catalog=Grifindo_Toy;Integrated Security=True");
        public AllemployeeDetails()
        {
            InitializeComponent();
        }
        private void displayGrid()
        {
            string sqlGrid;
            sqlGrid = "select * from Employee";
            SqlCommand cmdGrid = new SqlCommand(sqlGrid, con);
            con.Open();
            SqlDataAdapter dagrid = new SqlDataAdapter(cmdGrid);
            DataTable dtgrid = new DataTable();
            dagrid.Fill(dtgrid);
            dataGridView1.DataSource = dtgrid;
            con.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Home_menu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S28DADF;Initial Catalog=Grifindo_Toy;Integrated Security=True");
        public Home_menu()
        {
            InitializeComponent();
        }

        private void employeebtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Employee empform = new Employee();
            empform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Setting setform = new Setting();
            setform.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Salary salform = new Salary();
            salform.Show();
        }

        private void Home_menu_Load(object sender, EventArgs e)
        {

        }

        private void Allsaldetailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Details showall = new Salary_Details();
            showall.Show();
        }
    }
}

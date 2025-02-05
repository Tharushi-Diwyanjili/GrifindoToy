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
            var newform = new Employee();
            newform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var newform = new Setting();
            newform.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var newform = new Salary();
            newform.Show();
        }

        private void Home_menu_Load(object sender, EventArgs e)
        {

        }

        private void Allsaldetailsbtn_Click(object sender, EventArgs e)
        {
            var showall = new Salary_Details();
            showall.Show();
        }
    }
}

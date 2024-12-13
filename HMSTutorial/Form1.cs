using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HMSTutorial
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\USERS\DELL\ONEDRIVE - ENGUG.RUH.AC.LK\DOCUMENTS\HMSDB.MDF"";Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Text == "" || PassTb.Text == "")
                MessageBox.Show("Enter a Username and Password");
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTbl where DocName='"+DocNameTb.Text+"' and DocPass='"+PassTb.Text+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    Home H = new Home();
                    H.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");

                }
                Con.Close();
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

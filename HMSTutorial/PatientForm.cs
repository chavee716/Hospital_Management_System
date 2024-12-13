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
using System.Data.SqlClient;

namespace HMSTutorial
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\USERS\DELL\ONEDRIVE - ENGUG.RUH.AC.LK\DOCUMENTS\HMSDB.MDF"";Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAd.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || GenderCb.Text == "" || BloodCb.Text == "" || MajorTb.Text == "")
                MessageBox.Show("No Empty Fill accepted");
            else
            {

                Con.Open();
                string query = "insert into PatientTbl values(" + PatId.Text + ",'" + PatName.Text + "','" + PatAd.Text + "','" + PatPhone.Text + "','" + PatAge.Text + "','" + GenderCb.SelectedItem.ToString() + "','" + BloodCb.SelectedItem.ToString() + "','" + MajorTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully added");
                Con.Close();
                populate();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAd.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            MajorTb.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

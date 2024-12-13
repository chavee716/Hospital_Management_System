using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMSTutorial
{
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\USERS\DELL\ONEDRIVE - ENGUG.RUH.AC.LK\DOCUMENTS\HMSDB.MDF"";Integrated Security=True;Connect Timeout=30");
        void populatecombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        string patname;
        void fetchpatientname()
        {
            Con.Open();
            string mysql = "select * from PatientTbl where PatId = " + PatientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatieName.Text = patname;
            }


            Con.Close();
        }
        void populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || Medicines.Text == "" || Diagnosis.Text == "" || PatieName.Text == "" || Symptoms.Text == "")
                MessageBox.Show("No Empty Fill accepted");
            else
            {

                Con.Open();
                string query = "insert into DiagnosisTbl values(" + DiagId.Text + ",'" + PatientIdCb.SelectedValue.ToString() + "','" + PatieName.Text + "','" + Symptoms.Text + "','" + Diagnosis.Text + "','" + Medicines.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully added");
                Con.Close();
                populate();
            }
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatientname();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
                MessageBox.Show("Enter the Diagnosis Id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTbl set PatId = " + PatientIdCb.SelectedValue.ToString() + ",PatName ='" + PatieName.Text + "',Symptoms='" + Symptoms.Text + "',Diagnosis='" + Diagnosis.Text + "',Medicines ='" + Medicines.Text + "'where DiagId=" + DiagId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Successfully Updated");
            Con.Close();
            populate();

        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatieName.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptoms.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosis.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicines.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label3.Text + "\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(230));
            e.Graphics.DrawString(label3.Text + PatientNamelbl.Text + "\n" + Diagnosislbl.Text + "\n" + Symptomslbl.Text + "\n" + Medicineslbl.Text + label8.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(130));
            e.Graphics.DrawString(label3.Text + "\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Black, new Point(230));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
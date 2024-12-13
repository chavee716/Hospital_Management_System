
using System.Data.SqlClient;

namespace HMSTutorial
{
    partial class PatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            PatId = new TextBox();
            PatName = new TextBox();
            PatPhone = new TextBox();
            PatAd = new TextBox();
            PatAge = new TextBox();
            GenderCb = new ComboBox();
            BloodCb = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            PatientGV = new DataGridView();
            MajorTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(881, 125);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(851, 9);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 11;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(409, 65);
            label2.Name = "label2";
            label2.Size = new Size(127, 41);
            label2.TabIndex = 2;
            label2.Text = "PATIENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(246, 24);
            label1.Name = "label1";
            label1.Size = new Size(475, 41);
            label1.TabIndex = 1;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // PatId
            // 
            PatId.Location = new Point(46, 148);
            PatId.Name = "PatId";
            PatId.Size = new Size(294, 27);
            PatId.TabIndex = 2;
            PatId.Text = "PatientID";
            // 
            // PatName
            // 
            PatName.Location = new Point(46, 181);
            PatName.Name = "PatName";
            PatName.Size = new Size(294, 27);
            PatName.TabIndex = 3;
            PatName.Text = "PatientName";
            // 
            // PatPhone
            // 
            PatPhone.Location = new Point(46, 247);
            PatPhone.Name = "PatPhone";
            PatPhone.Size = new Size(294, 27);
            PatPhone.TabIndex = 4;
            PatPhone.Text = "PatientContactNo";
            // 
            // PatAd
            // 
            PatAd.Location = new Point(46, 214);
            PatAd.Name = "PatAd";
            PatAd.Size = new Size(294, 27);
            PatAd.TabIndex = 5;
            PatAd.Text = "PatientAddress";
            // 
            // PatAge
            // 
            PatAge.Location = new Point(46, 280);
            PatAge.Name = "PatAge";
            PatAge.Size = new Size(294, 27);
            PatAge.TabIndex = 6;
            PatAge.Text = "PatientAge";
            // 
            // GenderCb
            // 
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(46, 313);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(294, 28);
            GenderCb.TabIndex = 7;
            GenderCb.Text = "Gender";
            // 
            // BloodCb
            // 
            BloodCb.FormattingEnabled = true;
            BloodCb.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-" });
            BloodCb.Location = new Point(46, 347);
            BloodCb.Name = "BloodCb";
            BloodCb.Size = new Size(294, 28);
            BloodCb.TabIndex = 8;
            BloodCb.Text = "Blood Group";
            BloodCb.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(142, 454);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(246, 415);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(146, 415);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(46, 415);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PatientGV
            // 
            PatientGV.AllowUserToResizeColumns = false;
            PatientGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientGV.Location = new Point(368, 170);
            PatientGV.Name = "PatientGV";
            PatientGV.RowHeadersVisible = false;
            PatientGV.RowHeadersWidth = 51;
            PatientGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PatientGV.Size = new Size(452, 274);
            PatientGV.TabIndex = 14;
            PatientGV.CellContentClick += PatientGV_CellContentClick;
            // 
            // MajorTb
            // 
            MajorTb.Location = new Point(46, 382);
            MajorTb.Name = "MajorTb";
            MajorTb.Size = new Size(294, 27);
            MajorTb.TabIndex = 15;
            MajorTb.Text = "MajorDis";
            MajorTb.TextChanged += textBox1_TextChanged;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 507);
            Controls.Add(MajorTb);
            Controls.Add(PatientGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BloodCb);
            Controls.Add(GenderCb);
            Controls.Add(PatAge);
            Controls.Add(PatAd);
            Controls.Add(PatPhone);
            Controls.Add(PatName);
            Controls.Add(PatId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            Load += PatientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTbl set PatName = '" + PatName.Text + "',PatAd='" + PatAd.Text + "',PatPhone='" + PatPhone.Text + "',PatAge='" + PatAge.Text + "',PatGender='" + GenderCb.SelectedItem.ToString() + "',PatBlood='" + BloodCb.SelectedItem.ToString() + "'where PatId=" + PatId.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Successfully Updated");
            Con.Close();
            populate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Enter the Patient Id");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId=" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                Con.Close();
                populate();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Home h = new Home();
            h.Show();
            this.Hide();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox PatId;
        private TextBox PatName;
        private TextBox PatPhone;
        private TextBox PatAd;
        private TextBox PatAge;
        private ComboBox GenderCb;
        private ComboBox BloodCb;
        private DataGridView PatientGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox MajorTb;
        private Label label4;
    }
}
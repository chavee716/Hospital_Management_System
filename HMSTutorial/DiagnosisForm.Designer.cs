namespace HMSTutorial
{
    partial class DiagnosisForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            DiagId = new TextBox();
            PatientIdCb = new ComboBox();
            Symptoms = new TextBox();
            Diagnosis = new TextBox();
            PatieName = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            diagsummary = new Panel();
            label9 = new Label();
            label8 = new Label();
            Medicineslbl = new Label();
            Diagnosislbl = new Label();
            Symptomslbl = new Label();
            PatientNamelbl = new Label();
            label3 = new Label();
            Medicines = new TextBox();
            DiagnosisGV = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            diagsummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 106);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(851, 9);
            label4.Name = "label4";
            label4.Size = new Size(25, 28);
            label4.TabIndex = 10;
            label4.Text = "X";
            label4.Click += label4_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OldLace;
            label2.Location = new Point(365, 65);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 2;
            label2.Text = "DIAGNOSIS";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(217, 24);
            label1.Name = "label1";
            label1.Size = new Size(511, 41);
            label1.TabIndex = 1;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DiagId
            // 
            DiagId.Location = new Point(51, 143);
            DiagId.Name = "DiagId";
            DiagId.Size = new Size(190, 27);
            DiagId.TabIndex = 3;
            DiagId.Text = "DiagnosisID";
            // 
            // PatientIdCb
            // 
            PatientIdCb.FormattingEnabled = true;
            PatientIdCb.Items.AddRange(new object[] { "Male", "Female" });
            PatientIdCb.Location = new Point(51, 176);
            PatientIdCb.Name = "PatientIdCb";
            PatientIdCb.Size = new Size(190, 28);
            PatientIdCb.TabIndex = 8;
            PatientIdCb.Text = "PatientId";
            PatientIdCb.SelectionChangeCommitted += PatientIdCb_SelectionChangeCommitted;
            // 
            // Symptoms
            // 
            Symptoms.Location = new Point(251, 143);
            Symptoms.Name = "Symptoms";
            Symptoms.Size = new Size(190, 27);
            Symptoms.TabIndex = 9;
            Symptoms.Text = "Symptoms";
            // 
            // Diagnosis
            // 
            Diagnosis.Location = new Point(251, 176);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Size = new Size(190, 27);
            Diagnosis.TabIndex = 10;
            Diagnosis.Text = "Diagnosis";
            // 
            // PatieName
            // 
            PatieName.Enabled = false;
            PatieName.Location = new Point(51, 210);
            PatieName.Name = "PatieName";
            PatieName.Size = new Size(190, 27);
            PatieName.TabIndex = 11;
            PatieName.Text = "PatientName";
            // 
            // button4
            // 
            button4.BackColor = Color.Purple;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(183, 305);
            button4.Name = "button4";
            button4.Size = new Size(128, 29);
            button4.TabIndex = 16;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Purple;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(317, 270);
            button3.Name = "button3";
            button3.Size = new Size(124, 29);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(183, 270);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 14;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(51, 270);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // diagsummary
            // 
            diagsummary.Controls.Add(label9);
            diagsummary.Controls.Add(label8);
            diagsummary.Controls.Add(Medicineslbl);
            diagsummary.Controls.Add(Diagnosislbl);
            diagsummary.Controls.Add(Symptomslbl);
            diagsummary.Controls.Add(PatientNamelbl);
            diagsummary.Controls.Add(label3);
            diagsummary.Location = new Point(473, 143);
            diagsummary.Name = "diagsummary";
            diagsummary.Size = new Size(374, 191);
            diagsummary.TabIndex = 17;
            diagsummary.Paint += panel2_Paint_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Purple;
            label9.Location = new Point(281, 15);
            label9.Name = "label9";
            label9.Size = new Size(25, 12);
            label9.TabIndex = 9;
            label9.Text = "Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Purple;
            label8.Location = new Point(90, 140);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 8;
            label8.Click += label8_Click;
            // 
            // Medicineslbl
            // 
            Medicineslbl.AutoSize = true;
            Medicineslbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Medicineslbl.ForeColor = Color.DodgerBlue;
            Medicineslbl.Location = new Point(250, 104);
            Medicineslbl.Name = "Medicineslbl";
            Medicineslbl.Size = new Size(78, 20);
            Medicineslbl.TabIndex = 7;
            Medicineslbl.Text = "Medicines";
            // 
            // Diagnosislbl
            // 
            Diagnosislbl.AutoSize = true;
            Diagnosislbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Diagnosislbl.ForeColor = Color.DodgerBlue;
            Diagnosislbl.Location = new Point(250, 41);
            Diagnosislbl.Name = "Diagnosislbl";
            Diagnosislbl.Size = new Size(75, 20);
            Diagnosislbl.TabIndex = 6;
            Diagnosislbl.Text = "Diagnosis";
            // 
            // Symptomslbl
            // 
            Symptomslbl.AutoSize = true;
            Symptomslbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Symptomslbl.ForeColor = Color.DodgerBlue;
            Symptomslbl.Location = new Point(46, 104);
            Symptomslbl.Name = "Symptomslbl";
            Symptomslbl.Size = new Size(80, 20);
            Symptomslbl.TabIndex = 5;
            Symptomslbl.Text = "Symptoms";
            // 
            // PatientNamelbl
            // 
            PatientNamelbl.AutoSize = true;
            PatientNamelbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PatientNamelbl.ForeColor = Color.DodgerBlue;
            PatientNamelbl.Location = new Point(46, 41);
            PatientNamelbl.Name = "PatientNamelbl";
            PatientNamelbl.Size = new Size(98, 20);
            PatientNamelbl.TabIndex = 4;
            PatientNamelbl.Text = "PatientName";
            PatientNamelbl.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(90, 4);
            label3.Name = "label3";
            label3.Size = new Size(185, 23);
            label3.TabIndex = 3;
            label3.Text = "DIAGNOSIS SUMMARY";
            label3.Click += label3_Click;
            // 
            // Medicines
            // 
            Medicines.Location = new Point(251, 209);
            Medicines.Name = "Medicines";
            Medicines.Size = new Size(190, 27);
            Medicines.TabIndex = 18;
            Medicines.Text = "Medicines";
            // 
            // DiagnosisGV
            // 
            DiagnosisGV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            DiagnosisGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DiagnosisGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DiagnosisGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DiagnosisGV.Location = new Point(51, 359);
            DiagnosisGV.Name = "DiagnosisGV";
            DiagnosisGV.RowHeadersVisible = false;
            DiagnosisGV.RowHeadersWidth = 51;
            DiagnosisGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DiagnosisGV.Size = new Size(796, 135);
            DiagnosisGV.TabIndex = 19;
            DiagnosisGV.CellContentClick += DiagnosisGV_CellContentClick;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // DiagnosisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(888, 549);
            Controls.Add(DiagnosisGV);
            Controls.Add(Medicines);
            Controls.Add(diagsummary);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PatieName);
            Controls.Add(Diagnosis);
            Controls.Add(Symptoms);
            Controls.Add(PatientIdCb);
            Controls.Add(DiagId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "DiagnosisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiagnosisForm";
            Load += DiagnosisForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            diagsummary.ResumeLayout(false);
            diagsummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox DiagId;
        private ComboBox PatientIdCb;
        private TextBox Symptoms;
        private TextBox Diagnosis;
        private TextBox PatieName;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel diagsummary;
        private Label label3;
        private Label PatientNamelbl;
        private Label Symptomslbl;
        private Label label8;
        private Label Medicineslbl;
        private Label Diagnosislbl;
        private Label label9;
        private TextBox Medicines;
        private DataGridView DiagnosisGV;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label4;
    }
}
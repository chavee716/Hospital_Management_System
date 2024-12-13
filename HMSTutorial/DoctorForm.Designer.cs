
namespace HMSTutorial
{
    partial class DoctorForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            DocName = new TextBox();
            DocExp = new TextBox();
            DocPass = new TextBox();
            DoctorGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            DocId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).BeginInit();
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
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(851, 9);
            label4.Name = "label4";
            label4.Size = new Size(24, 23);
            label4.TabIndex = 11;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(373, 60);
            label2.Name = "label2";
            label2.Size = new Size(137, 41);
            label2.TabIndex = 2;
            label2.Text = "DOCTOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(205, 23);
            label1.Name = "label1";
            label1.Size = new Size(511, 41);
            label1.TabIndex = 1;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // DocName
            // 
            DocName.Font = new Font("Lucida Sans", 9F);
            DocName.Location = new Point(28, 209);
            DocName.Name = "DocName";
            DocName.Size = new Size(222, 25);
            DocName.TabIndex = 2;
            DocName.Text = "DoctorName";
            DocName.TextChanged += textBox2_TextChanged;
            // 
            // DocExp
            // 
            DocExp.Font = new Font("Lucida Sans", 9F);
            DocExp.Location = new Point(28, 259);
            DocExp.Name = "DocExp";
            DocExp.Size = new Size(222, 25);
            DocExp.TabIndex = 3;
            DocExp.Text = "YearsOfExperience";
            // 
            // DocPass
            // 
            DocPass.Font = new Font("Lucida Sans", 9F);
            DocPass.Location = new Point(28, 301);
            DocPass.Name = "DocPass";
            DocPass.Size = new Size(223, 25);
            DocPass.TabIndex = 4;
            DocPass.Text = "Password";
            // 
            // DoctorGV
            // 
            DoctorGV.BackgroundColor = Color.LightGray;
            DoctorGV.BorderStyle = BorderStyle.None;
            DoctorGV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            DoctorGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DoctorGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Black;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DoctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DoctorGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.LightGray;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DoctorGV.DefaultCellStyle = dataGridViewCellStyle6;
            DoctorGV.GridColor = Color.DarkGray;
            DoctorGV.ImeMode = ImeMode.Disable;
            DoctorGV.Location = new Point(332, 165);
            DoctorGV.Name = "DoctorGV";
            DoctorGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Black;
            dataGridViewCellStyle7.Font = new Font("Lucida Sans", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DoctorGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DoctorGV.RowHeadersVisible = false;
            DoctorGV.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = Color.LightGray;
            dataGridViewCellStyle8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            DoctorGV.RowsDefaultCellStyle = dataGridViewCellStyle8;
            DoctorGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DoctorGV.Size = new Size(499, 283);
            DoctorGV.TabIndex = 5;
            DoctorGV.CellContentClick += DoctorGV_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(27, 341);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(141, 341);
            button2.Name = "button2";
            button2.Size = new Size(109, 29);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AllowDrop = true;
            button3.BackColor = SystemColors.Control;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(27, 376);
            button3.Name = "button3";
            button3.Size = new Size(223, 29);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.ImageAlign = ContentAlignment.BottomLeft;
            button4.Location = new Point(27, 411);
            button4.Name = "button4";
            button4.Size = new Size(222, 29);
            button4.TabIndex = 9;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // DocId
            // 
            DocId.Font = new Font("Lucida Sans", 9F);
            DocId.Location = new Point(27, 165);
            DocId.Name = "DocId";
            DocId.Size = new Size(223, 25);
            DocId.TabIndex = 1;
            DocId.Text = "DoctorID";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 507);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DoctorGV);
            Controls.Add(DocPass);
            Controls.Add(DocExp);
            Controls.Add(DocName);
            Controls.Add(DocId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorForm";
            Load += DoctorForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox DocName;
        private TextBox DocExp;
        private TextBox DocPass;
        private DataGridView DoctorGV;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox DocId;
        private Label label3;
        private Label label4;
    }
}
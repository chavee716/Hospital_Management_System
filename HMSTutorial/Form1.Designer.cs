namespace HMSTutorial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            DocNameTb = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            PassTb = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 94);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(332, 9);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 11;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(146, 34);
            label1.Name = "label1";
            label1.Size = new Size(63, 31);
            label1.TabIndex = 0;
            label1.Text = "HMS";
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(146, 298);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DocNameTb
            // 
            DocNameTb.Location = new Point(47, 159);
            DocNameTb.Margin = new Padding(3, 4, 3, 4);
            DocNameTb.Name = "DocNameTb";
            DocNameTb.Size = new Size(287, 27);
            DocNameTb.TabIndex = 2;
            DocNameTb.Text = "DocName";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // PassTb
            // 
            PassTb.Location = new Point(46, 218);
            PassTb.Margin = new Padding(3, 4, 3, 4);
            PassTb.Name = "PassTb";
            PassTb.ScrollBars = ScrollBars.Vertical;
            PassTb.Size = new Size(287, 27);
            PassTb.TabIndex = 4;
            PassTb.Text = "DocPassword";
            PassTb.UseSystemPasswordChar = true;
            PassTb.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(181, 331);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 5;
            label2.Text = "Clear";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 372);
            Controls.Add(label2);
            Controls.Add(PassTb);
            Controls.Add(DocNameTb);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox DocNameTb;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox PassTb;
        private Label label2;
        private Label label4;
    }
}

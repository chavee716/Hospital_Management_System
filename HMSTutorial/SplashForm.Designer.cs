﻿namespace HMSTutorial
{
    partial class SplashForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            MyProgressBar = new ProgressBar();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OldLace;
            label1.Location = new Point(185, 32);
            label1.Name = "label1";
            label1.Size = new Size(475, 41);
            label1.TabIndex = 2;
            label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.OldLace;
            label2.Location = new Point(368, 85);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 3;
            // 
            // MyProgressBar
            // 
            MyProgressBar.ForeColor = Color.Cyan;
            MyProgressBar.Location = new Point(182, 182);
            MyProgressBar.Name = "MyProgressBar";
            MyProgressBar.Size = new Size(478, 43);
            MyProgressBar.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OldLace;
            label3.Location = new Point(309, 403);
            label3.Name = "label3";
            label3.Size = new Size(253, 23);
            label3.TabIndex = 5;
            label3.Text = "Creators Dias C. | H.L.U.Diluksha";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(843, 503);
            Controls.Add(label3);
            Controls.Add(MyProgressBar);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashForm";
            Load += SplashForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ProgressBar MyProgressBar;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
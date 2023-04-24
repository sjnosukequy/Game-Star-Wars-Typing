using System.Windows.Forms;

namespace Game
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.ONEPLY = new System.Windows.Forms.Button();
            this.TWOPLY = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ONEPLY
            // 
            this.ONEPLY.BackColor = System.Drawing.Color.Transparent;
            this.ONEPLY.FlatAppearance.BorderSize = 0;
            this.ONEPLY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ONEPLY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONEPLY.ForeColor = System.Drawing.Color.IndianRed;
            this.ONEPLY.Location = new System.Drawing.Point(506, 163);
            this.ONEPLY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ONEPLY.Name = "ONEPLY";
            this.ONEPLY.Size = new System.Drawing.Size(295, 81);
            this.ONEPLY.TabIndex = 0;
            this.ONEPLY.Text = "1 PLAYER";
            this.ONEPLY.UseVisualStyleBackColor = false;
            this.ONEPLY.Click += new System.EventHandler(this.ONEPLY_Click);
            // 
            // TWOPLY
            // 
            this.TWOPLY.BackColor = System.Drawing.Color.Transparent;
            this.TWOPLY.FlatAppearance.BorderSize = 0;
            this.TWOPLY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TWOPLY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TWOPLY.ForeColor = System.Drawing.Color.IndianRed;
            this.TWOPLY.Location = new System.Drawing.Point(506, 328);
            this.TWOPLY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TWOPLY.Name = "TWOPLY";
            this.TWOPLY.Size = new System.Drawing.Size(295, 81);
            this.TWOPLY.TabIndex = 1;
            this.TWOPLY.Text = "2 PLAYERS";
            this.TWOPLY.UseVisualStyleBackColor = false;
            this.TWOPLY.Click += new System.EventHandler(this.TWOPLY_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(831, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "STAR WARS TYPING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TWOPLY);
            this.Controls.Add(this.ONEPLY);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STAR WARS TYPING";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ONEPLY;
        private Button TWOPLY;
        private Timer timer1;
        private Label label1;
    }
}
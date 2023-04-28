using System.Windows.Forms;

namespace Game.GAMES
{
    partial class GAME1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.POINTS = new System.Windows.Forms.Label();
            this.BONUS = new System.Windows.Forms.Label();
            this.Waitlabel = new System.Windows.Forms.Label();
            this.CONTBUTT = new System.Windows.Forms.Button();
            this.EXITBUTT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // POINTS
            // 
            this.POINTS.AutoSize = true;
            this.POINTS.BackColor = System.Drawing.Color.Transparent;
            this.POINTS.Font = new System.Drawing.Font("ROG Fonts", 15F);
            this.POINTS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.POINTS.Location = new System.Drawing.Point(1344, 3);
            this.POINTS.Name = "POINTS";
            this.POINTS.Size = new System.Drawing.Size(170, 30);
            this.POINTS.TabIndex = 1;
            this.POINTS.Text = "POINTS: 0";
            this.POINTS.Paint += new System.Windows.Forms.PaintEventHandler(this.POREF);
            this.POINTS.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyDW);
            // 
            // BONUS
            // 
            this.BONUS.AutoSize = true;
            this.BONUS.BackColor = System.Drawing.Color.Transparent;
            this.BONUS.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.BONUS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BONUS.Location = new System.Drawing.Point(12, 319);
            this.BONUS.Name = "BONUS";
            this.BONUS.Size = new System.Drawing.Size(97, 35);
            this.BONUS.TabIndex = 2;
            this.BONUS.Text = "BONUS";
            this.BONUS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BONUS.Visible = false;
            this.BONUS.Paint += new System.Windows.Forms.PaintEventHandler(this.BOREF);
            // 
            // Waitlabel
            // 
            this.Waitlabel.AutoSize = true;
            this.Waitlabel.BackColor = System.Drawing.Color.Transparent;
            this.Waitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Waitlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Waitlabel.Location = new System.Drawing.Point(732, 170);
            this.Waitlabel.Name = "Waitlabel";
            this.Waitlabel.Size = new System.Drawing.Size(173, 189);
            this.Waitlabel.TabIndex = 3;
            this.Waitlabel.Text = "3";
            this.Waitlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CONTBUTT
            // 
            this.CONTBUTT.BackColor = System.Drawing.Color.Transparent;
            this.CONTBUTT.FlatAppearance.BorderSize = 0;
            this.CONTBUTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CONTBUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONTBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTBUTT.ForeColor = System.Drawing.Color.IndianRed;
            this.CONTBUTT.Location = new System.Drawing.Point(598, 363);
            this.CONTBUTT.Name = "CONTBUTT";
            this.CONTBUTT.Size = new System.Drawing.Size(426, 112);
            this.CONTBUTT.TabIndex = 4;
            this.CONTBUTT.Text = "COUNTINUE";
            this.CONTBUTT.UseVisualStyleBackColor = false;
            this.CONTBUTT.Click += new System.EventHandler(this.CONTBUTT_Click);
            // 
            // EXITBUTT
            // 
            this.EXITBUTT.BackColor = System.Drawing.Color.Transparent;
            this.EXITBUTT.FlatAppearance.BorderSize = 0;
            this.EXITBUTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.EXITBUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXITBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXITBUTT.ForeColor = System.Drawing.Color.IndianRed;
            this.EXITBUTT.Location = new System.Drawing.Point(598, 481);
            this.EXITBUTT.Name = "EXITBUTT";
            this.EXITBUTT.Size = new System.Drawing.Size(426, 112);
            this.EXITBUTT.TabIndex = 5;
            this.EXITBUTT.Text = "MENU";
            this.EXITBUTT.UseVisualStyleBackColor = false;
            this.EXITBUTT.Click += new System.EventHandler(this.EXITBUTT_Click);
            // 
            // GAME1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1661, 709);
            this.Controls.Add(this.EXITBUTT);
            this.Controls.Add(this.CONTBUTT);
            this.Controls.Add(this.Waitlabel);
            this.Controls.Add(this.POINTS);
            this.Controls.Add(this.BONUS);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GAME1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GAME1_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.REFRESH);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label POINTS;
        private Label BONUS;
        private Label Waitlabel;
        private Button CONTBUTT;
        private Button EXITBUTT;
    }
}
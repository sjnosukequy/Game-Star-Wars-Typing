using System.Windows.Forms;

namespace Game.GAMES
{
    partial class GAME2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LOADINGBOX = new System.Windows.Forms.PictureBox();
            this.HEALTHBAR1 = new System.Windows.Forms.PictureBox();
            this.HEALTHBAR2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EXITBUTT = new System.Windows.Forms.Button();
            this.CONTBUTT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.COUNTER = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LOADINGBOX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HEALTHBAR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HEALTHBAR2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(808, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KEYDW);
            // 
            // LOADINGBOX
            // 
            this.LOADINGBOX.BackColor = System.Drawing.Color.Transparent;
            this.LOADINGBOX.Location = new System.Drawing.Point(101, 58);
            this.LOADINGBOX.Name = "LOADINGBOX";
            this.LOADINGBOX.Size = new System.Drawing.Size(1455, 50);
            this.LOADINGBOX.TabIndex = 4;
            this.LOADINGBOX.TabStop = false;
            this.LOADINGBOX.Paint += new System.Windows.Forms.PaintEventHandler(this.LOADREF);
            // 
            // HEALTHBAR1
            // 
            this.HEALTHBAR1.BackColor = System.Drawing.Color.DimGray;
            this.HEALTHBAR1.Location = new System.Drawing.Point(0, 0);
            this.HEALTHBAR1.Name = "HEALTHBAR1";
            this.HEALTHBAR1.Size = new System.Drawing.Size(244, 38);
            this.HEALTHBAR1.TabIndex = 5;
            this.HEALTHBAR1.TabStop = false;
            this.HEALTHBAR1.Paint += new System.Windows.Forms.PaintEventHandler(this.HEALTHREF1);
            // 
            // HEALTHBAR2
            // 
            this.HEALTHBAR2.BackColor = System.Drawing.Color.DimGray;
            this.HEALTHBAR2.Location = new System.Drawing.Point(1214, 0);
            this.HEALTHBAR2.Name = "HEALTHBAR2";
            this.HEALTHBAR2.Size = new System.Drawing.Size(244, 38);
            this.HEALTHBAR2.TabIndex = 7;
            this.HEALTHBAR2.TabStop = false;
            this.HEALTHBAR2.Paint += new System.Windows.Forms.PaintEventHandler(this.HEALTHREF2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.EXITBUTT);
            this.panel1.Controls.Add(this.CONTBUTT);
            this.panel1.Controls.Add(this.HEALTHBAR1);
            this.panel1.Controls.Add(this.HEALTHBAR2);
            this.panel1.Location = new System.Drawing.Point(41, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 286);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelREF);
            // 
            // EXITBUTT
            // 
            this.EXITBUTT.FlatAppearance.BorderSize = 0;
            this.EXITBUTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.EXITBUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXITBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXITBUTT.ForeColor = System.Drawing.Color.IndianRed;
            this.EXITBUTT.Location = new System.Drawing.Point(572, 130);
            this.EXITBUTT.Name = "EXITBUTT";
            this.EXITBUTT.Size = new System.Drawing.Size(301, 105);
            this.EXITBUTT.TabIndex = 11;
            this.EXITBUTT.Text = "MENU";
            this.EXITBUTT.UseVisualStyleBackColor = true;
            this.EXITBUTT.Click += new System.EventHandler(this.EXITBUTT_Click);
            // 
            // CONTBUTT
            // 
            this.CONTBUTT.FlatAppearance.BorderSize = 0;
            this.CONTBUTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CONTBUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CONTBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTBUTT.ForeColor = System.Drawing.Color.IndianRed;
            this.CONTBUTT.Location = new System.Drawing.Point(572, 19);
            this.CONTBUTT.Name = "CONTBUTT";
            this.CONTBUTT.Size = new System.Drawing.Size(301, 105);
            this.CONTBUTT.TabIndex = 10;
            this.CONTBUTT.Text = "COUNTINUE";
            this.CONTBUTT.UseVisualStyleBackColor = true;
            this.CONTBUTT.Click += new System.EventHandler(this.CONTBUTT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.COUNTER);
            this.panel2.Location = new System.Drawing.Point(41, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1458, 192);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.BUTTREF);
            // 
            // COUNTER
            // 
            this.COUNTER.AutoSize = true;
            this.COUNTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COUNTER.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.COUNTER.Location = new System.Drawing.Point(638, 15);
            this.COUNTER.Name = "COUNTER";
            this.COUNTER.Size = new System.Drawing.Size(173, 189);
            this.COUNTER.TabIndex = 0;
            this.COUNTER.Text = "3";
            this.COUNTER.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.COUNTER.Paint += new System.Windows.Forms.PaintEventHandler(this.WAIT);
            // 
            // GAME2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.BG1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LOADINGBOX);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GAME2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LOADINGBOX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HEALTHBAR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HEALTHBAR2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox LOADINGBOX;
        private PictureBox HEALTHBAR1;
        private PictureBox HEALTHBAR2;
        private Panel panel1;
        private Panel panel2;
        private Label COUNTER;
        private Button CONTBUTT;
        private Button EXITBUTT;
    }
}
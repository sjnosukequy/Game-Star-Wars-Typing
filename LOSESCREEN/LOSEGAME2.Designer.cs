namespace Game.LOSESCREEN
{
    partial class LOSEGAME2
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.AGAINBUTT = new System.Windows.Forms.Button();
            this.MENUBUTT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // AGAINBUTT
            // 
            this.AGAINBUTT.BackColor = System.Drawing.Color.Transparent;
            this.AGAINBUTT.FlatAppearance.BorderSize = 0;
            this.AGAINBUTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AGAINBUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AGAINBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGAINBUTT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AGAINBUTT.Location = new System.Drawing.Point(583, 373);
            this.AGAINBUTT.Name = "AGAINBUTT";
            this.AGAINBUTT.Size = new System.Drawing.Size(375, 94);
            this.AGAINBUTT.TabIndex = 0;
            this.AGAINBUTT.Text = "TRY AGAIN";
            this.AGAINBUTT.Hide();
            this.AGAINBUTT.Click += new System.EventHandler(this.AGAINCLICK);
            this.AGAINBUTT.UseVisualStyleBackColor = false;
            // 
            // MENUBUTT
            // 
            this.MENUBUTT.BackColor = System.Drawing.Color.Transparent;
            this.MENUBUTT.FlatAppearance.BorderSize = 0;
            this.MENUBUTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.MENUBUTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MENUBUTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENUBUTT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MENUBUTT.Location = new System.Drawing.Point(583, 499);
            this.MENUBUTT.Name = "MENUBUTT";
            this.MENUBUTT.Size = new System.Drawing.Size(375, 94);
            this.MENUBUTT.TabIndex = 1;
            this.MENUBUTT.Text = "MENU";
            this.MENUBUTT.Hide();
            this.MENUBUTT.Click += new System.EventHandler(this.MENUCLICK);
            this.MENUBUTT.UseVisualStyleBackColor = false;
            // 
            // LOSEGAME1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1540, 709);
            this.Controls.Add(this.MENUBUTT);
            this.Controls.Add(this.AGAINBUTT);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LOSEGAME1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOSEGAME1";
            this.ResumeLayout(false);

        }

        private void AGAINBUTT_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button AGAINBUTT;
        private System.Windows.Forms.Button MENUBUTT;
    }
}
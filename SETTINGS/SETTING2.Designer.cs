namespace Game.SETTINGS
{
    partial class SETTING2
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
            this.HEALTH = new System.Windows.Forms.ComboBox();
            this.DMG = new System.Windows.Forms.ComboBox();
            this.START = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HEALTH
            // 
            this.HEALTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HEALTH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HEALTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HEALTH.FormattingEnabled = true;
            this.HEALTH.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.HEALTH.Location = new System.Drawing.Point(133, 83);
            this.HEALTH.Name = "HEALTH";
            this.HEALTH.Size = new System.Drawing.Size(277, 33);
            this.HEALTH.TabIndex = 0;
            this.HEALTH.TabStop = false;
            this.HEALTH.SelectedIndexChanged += new System.EventHandler(this.HEALTH_SelectedIndexChanged);
            // 
            // DMG
            // 
            this.DMG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DMG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMG.FormattingEnabled = true;
            this.DMG.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.DMG.Location = new System.Drawing.Point(133, 193);
            this.DMG.Name = "DMG";
            this.DMG.Size = new System.Drawing.Size(277, 33);
            this.DMG.TabIndex = 1;
            this.DMG.TabStop = false;
            this.DMG.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Transparent;
            this.START.FlatAppearance.BorderSize = 0;
            this.START.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.Location = new System.Drawing.Point(133, 254);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(277, 88);
            this.START.TabIndex = 2;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.Transparent;
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.Location = new System.Drawing.Point(133, 371);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(277, 82);
            this.BACK.TabIndex = 3;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "HEALTH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "DMG";
            // 
            // SETTING2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 510);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.START);
            this.Controls.Add(this.DMG);
            this.Controls.Add(this.HEALTH);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SETTING2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SETTING";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HEALTH;
        private System.Windows.Forms.ComboBox DMG;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
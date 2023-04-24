namespace Game.SETTINGS
{
    partial class SETTING1
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
            this.DIFF = new System.Windows.Forms.ComboBox();
            this.START = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DIFF
            // 
            this.DIFF.BackColor = System.Drawing.Color.White;
            this.DIFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DIFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DIFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIFF.FormattingEnabled = true;
            this.DIFF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DIFF.Items.AddRange(new object[] {
            "EASY",
            "NORMAL",
            "HARD"});
            this.DIFF.Location = new System.Drawing.Point(133, 152);
            this.DIFF.Name = "DIFF";
            this.DIFF.Size = new System.Drawing.Size(277, 33);
            this.DIFF.TabIndex = 0;
            this.DIFF.TabStop = false;
            this.DIFF.SelectedIndexChanged += new System.EventHandler(this.DIFF_SelectedIndexChanged);
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.Transparent;
            this.START.FlatAppearance.BorderSize = 0;
            this.START.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.START.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.START.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.Location = new System.Drawing.Point(133, 229);
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
            this.BACK.Location = new System.Drawing.Point(133, 346);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(277, 88);
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
            this.label1.Location = new System.Drawing.Point(127, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIFFICULTY";
            // 
            // SETTING1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 510);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.START);
            this.Controls.Add(this.DIFF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SETTING1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SETTING";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox DIFF;
    private System.Windows.Forms.Button START;
    private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Label label1;
    }
}
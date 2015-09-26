namespace proWork
{
    partial class Calculate
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
            this.CalcBtn = new System.Windows.Forms.Button();
            this.LWCLabel = new System.Windows.Forms.Label();
            this.LMCLabel = new System.Windows.Forms.Label();
            this.LYCLabel = new System.Windows.Forms.Label();
            this.TxtBoxLW = new System.Windows.Forms.TextBox();
            this.TxtBoxLM = new System.Windows.Forms.TextBox();
            this.TxtBoxLY = new System.Windows.Forms.TextBox();
            this.CalcLM = new System.Windows.Forms.Button();
            this.CalcLY = new System.Windows.Forms.Button();
            this.ImpBtn = new System.Windows.Forms.Button();
            this.SuccLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(379, 61);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 0;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // LWCLabel
            // 
            this.LWCLabel.AutoSize = true;
            this.LWCLabel.Location = new System.Drawing.Point(173, 67);
            this.LWCLabel.Name = "LWCLabel";
            this.LWCLabel.Size = new System.Drawing.Size(75, 17);
            this.LWCLabel.TabIndex = 1;
            this.LWCLabel.Text = "Last Week";
            // 
            // LMCLabel
            // 
            this.LMCLabel.AutoSize = true;
            this.LMCLabel.Location = new System.Drawing.Point(173, 114);
            this.LMCLabel.Name = "LMCLabel";
            this.LMCLabel.Size = new System.Drawing.Size(78, 17);
            this.LMCLabel.TabIndex = 2;
            this.LMCLabel.Text = "Last Month";
            // 
            // LYCLabel
            // 
            this.LYCLabel.AutoSize = true;
            this.LYCLabel.Location = new System.Drawing.Point(173, 175);
            this.LYCLabel.Name = "LYCLabel";
            this.LYCLabel.Size = new System.Drawing.Size(69, 17);
            this.LYCLabel.TabIndex = 3;
            this.LYCLabel.Text = "Last Year";
            // 
            // TxtBoxLW
            // 
            this.TxtBoxLW.Location = new System.Drawing.Point(254, 67);
            this.TxtBoxLW.Name = "TxtBoxLW";
            this.TxtBoxLW.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxLW.TabIndex = 4;
            // 
            // TxtBoxLM
            // 
            this.TxtBoxLM.Location = new System.Drawing.Point(254, 114);
            this.TxtBoxLM.Name = "TxtBoxLM";
            this.TxtBoxLM.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxLM.TabIndex = 5;
            // 
            // TxtBoxLY
            // 
            this.TxtBoxLY.Location = new System.Drawing.Point(254, 170);
            this.TxtBoxLY.Name = "TxtBoxLY";
            this.TxtBoxLY.Size = new System.Drawing.Size(100, 22);
            this.TxtBoxLY.TabIndex = 6;
            // 
            // CalcLM
            // 
            this.CalcLM.Location = new System.Drawing.Point(379, 114);
            this.CalcLM.Name = "CalcLM";
            this.CalcLM.Size = new System.Drawing.Size(75, 23);
            this.CalcLM.TabIndex = 7;
            this.CalcLM.Text = "Calculate";
            this.CalcLM.UseVisualStyleBackColor = true;
            this.CalcLM.Click += new System.EventHandler(this.CalcLM_Click);
            // 
            // CalcLY
            // 
            this.CalcLY.Location = new System.Drawing.Point(379, 169);
            this.CalcLY.Name = "CalcLY";
            this.CalcLY.Size = new System.Drawing.Size(75, 23);
            this.CalcLY.TabIndex = 8;
            this.CalcLY.Text = "Calculate";
            this.CalcLY.UseVisualStyleBackColor = true;
            this.CalcLY.Click += new System.EventHandler(this.CalcLY_Click);
            // 
            // ImpBtn
            // 
            this.ImpBtn.Location = new System.Drawing.Point(254, 256);
            this.ImpBtn.Name = "ImpBtn";
            this.ImpBtn.Size = new System.Drawing.Size(75, 23);
            this.ImpBtn.TabIndex = 9;
            this.ImpBtn.Text = "Import";
            this.ImpBtn.UseVisualStyleBackColor = true;
            this.ImpBtn.Click += new System.EventHandler(this.ImpBtn_Click);
            // 
            // SuccLabel
            // 
            this.SuccLabel.AutoSize = true;
            this.SuccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuccLabel.ForeColor = System.Drawing.Color.Lime;
            this.SuccLabel.Location = new System.Drawing.Point(185, 9);
            this.SuccLabel.Name = "SuccLabel";
            this.SuccLabel.Size = new System.Drawing.Size(246, 25);
            this.SuccLabel.TabIndex = 10;
            this.SuccLabel.Text = "Your import  is successfully";
            this.SuccLabel.Visible = false;
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 316);
            this.Controls.Add(this.SuccLabel);
            this.Controls.Add(this.ImpBtn);
            this.Controls.Add(this.CalcLY);
            this.Controls.Add(this.CalcLM);
            this.Controls.Add(this.TxtBoxLY);
            this.Controls.Add(this.TxtBoxLM);
            this.Controls.Add(this.TxtBoxLW);
            this.Controls.Add(this.LYCLabel);
            this.Controls.Add(this.LMCLabel);
            this.Controls.Add(this.LWCLabel);
            this.Controls.Add(this.CalcBtn);
            this.Name = "Calculate";
            this.Text = "Calculate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Label LWCLabel;
        private System.Windows.Forms.Label LMCLabel;
        private System.Windows.Forms.Label LYCLabel;
        private System.Windows.Forms.TextBox TxtBoxLW;
        private System.Windows.Forms.TextBox TxtBoxLM;
        private System.Windows.Forms.TextBox TxtBoxLY;
        private System.Windows.Forms.Button CalcLM;
        private System.Windows.Forms.Button CalcLY;
        private System.Windows.Forms.Button ImpBtn;
        private System.Windows.Forms.Label SuccLabel;
    }
}
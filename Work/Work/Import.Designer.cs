namespace Work
{
    partial class Import
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
            this.ImportLabel = new System.Windows.Forms.Label();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImportLabel
            // 
            this.ImportLabel.AutoSize = true;
            this.ImportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportLabel.Location = new System.Drawing.Point(351, 110);
            this.ImportLabel.Name = "ImportLabel";
            this.ImportLabel.Size = new System.Drawing.Size(124, 29);
            this.ImportLabel.TabIndex = 0;
            this.ImportLabel.Text = "Import file";
            // 
            // ImportBtn
            // 
            this.ImportBtn.Location = new System.Drawing.Point(372, 181);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(75, 29);
            this.ImportBtn.TabIndex = 1;
            this.ImportBtn.Text = "Import";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuccessLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.SuccessLabel.Location = new System.Drawing.Point(256, 29);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(312, 39);
            this.SuccessLabel.TabIndex = 2;
            this.SuccessLabel.Text = "You success import";
            this.SuccessLabel.Visible = false;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 335);
            this.Controls.Add(this.SuccessLabel);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.ImportLabel);
            this.Name = "Import";
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImportLabel;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Label SuccessLabel;
    }
}
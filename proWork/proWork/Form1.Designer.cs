namespace proWork
{
    partial class Form1
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
            this.Txtboxcost = new System.Windows.Forms.TextBox();
            this.Txtboxprize = new System.Windows.Forms.TextBox();
            this.Datalabel = new System.Windows.Forms.Label();
            this.costlabel = new System.Windows.Forms.Label();
            this.PrizeLabel = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SuccLabel = new System.Windows.Forms.Label();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Txtboxcost
            // 
            this.Txtboxcost.Location = new System.Drawing.Point(528, 215);
            this.Txtboxcost.Name = "Txtboxcost";
            this.Txtboxcost.Size = new System.Drawing.Size(100, 22);
            this.Txtboxcost.TabIndex = 0;
            // 
            // Txtboxprize
            // 
            this.Txtboxprize.Location = new System.Drawing.Point(528, 271);
            this.Txtboxprize.Name = "Txtboxprize";
            this.Txtboxprize.Size = new System.Drawing.Size(100, 22);
            this.Txtboxprize.TabIndex = 2;
            // 
            // Datalabel
            // 
            this.Datalabel.AutoSize = true;
            this.Datalabel.Location = new System.Drawing.Point(411, 140);
            this.Datalabel.Name = "Datalabel";
            this.Datalabel.Size = new System.Drawing.Size(38, 17);
            this.Datalabel.TabIndex = 3;
            this.Datalabel.Text = "Date";
            // 
            // costlabel
            // 
            this.costlabel.AutoSize = true;
            this.costlabel.Location = new System.Drawing.Point(414, 220);
            this.costlabel.Name = "costlabel";
            this.costlabel.Size = new System.Drawing.Size(69, 17);
            this.costlabel.TabIndex = 4;
            this.costlabel.Text = "Expenses";
            // 
            // PrizeLabel
            // 
            this.PrizeLabel.AutoSize = true;
            this.PrizeLabel.Location = new System.Drawing.Point(414, 271);
            this.PrizeLabel.Name = "PrizeLabel";
            this.PrizeLabel.Size = new System.Drawing.Size(40, 17);
            this.PrizeLabel.TabIndex = 5;
            this.PrizeLabel.Text = "Price";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(461, 348);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // SuccLabel
            // 
            this.SuccLabel.AutoSize = true;
            this.SuccLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuccLabel.ForeColor = System.Drawing.Color.Red;
            this.SuccLabel.Location = new System.Drawing.Point(458, 60);
            this.SuccLabel.Name = "SuccLabel";
            this.SuccLabel.Size = new System.Drawing.Size(0, 25);
            this.SuccLabel.TabIndex = 7;
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(552, 347);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 8;
            this.CalcBtn.Text = "Calc";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(482, 140);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 420);
            this.Controls.Add(this.date);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.SuccLabel);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.PrizeLabel);
            this.Controls.Add(this.costlabel);
            this.Controls.Add(this.Datalabel);
            this.Controls.Add(this.Txtboxprize);
            this.Controls.Add(this.Txtboxcost);
            this.Name = "Form1";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtboxcost;
        private System.Windows.Forms.TextBox Txtboxprize;
        private System.Windows.Forms.Label Datalabel;
        private System.Windows.Forms.Label costlabel;
        private System.Windows.Forms.Label PrizeLabel;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label SuccLabel;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.DateTimePicker date;
    }
}


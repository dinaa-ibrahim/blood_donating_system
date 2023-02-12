namespace BloodDonation
{
    partial class HospitalOrReaserch
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
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Firebrick;
            this.label13.Location = new System.Drawing.Point(124, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 31);
            this.label13.TabIndex = 19;
            this.label13.Text = "Continue as a...";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(37, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 71);
            this.button5.TabIndex = 25;
            this.button5.Text = "Researcher";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(259, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 71);
            this.button4.TabIndex = 24;
            this.button4.Text = "Hospital";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // HospitalOrReaserch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 187);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label13);
            this.Name = "HospitalOrReaserch";
            this.Text = "HospitalOrReaserch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}
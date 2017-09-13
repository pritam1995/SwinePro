namespace Swine_Pro
{
    partial class DataReport
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
            this.form2button1 = new System.Windows.Forms.Button();
            this.form2button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form2button1
            // 
            this.form2button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2button1.Location = new System.Drawing.Point(232, 70);
            this.form2button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form2button1.Name = "form2button1";
            this.form2button1.Size = new System.Drawing.Size(347, 57);
            this.form2button1.TabIndex = 0;
            this.form2button1.Text = "DATA ENTRY";
            this.form2button1.UseVisualStyleBackColor = true;
            this.form2button1.Click += new System.EventHandler(this.form2button1_Click);
            // 
            // form2button2
            // 
            this.form2button2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2button2.Location = new System.Drawing.Point(232, 172);
            this.form2button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form2button2.Name = "form2button2";
            this.form2button2.Size = new System.Drawing.Size(347, 57);
            this.form2button2.TabIndex = 1;
            this.form2button2.Text = "REPORT GENERATION";
            this.form2button2.UseVisualStyleBackColor = true;
            this.form2button2.Click += new System.EventHandler(this.form2button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 321);
            this.Controls.Add(this.form2button2);
            this.Controls.Add(this.form2button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button form2button1;
        private System.Windows.Forms.Button form2button2;
    }
}
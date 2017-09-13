namespace Swine_Pro
{
    partial class Welcome
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
            this.form1label1 = new System.Windows.Forms.Label();
            this.form1label2 = new System.Windows.Forms.Label();
            this.form1button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form1label1
            // 
            this.form1label1.AutoSize = true;
            this.form1label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1label1.Location = new System.Drawing.Point(323, 31);
            this.form1label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1label1.Name = "form1label1";
            this.form1label1.Size = new System.Drawing.Size(234, 40);
            this.form1label1.TabIndex = 0;
            this.form1label1.Text = "SWINE PRO ";
            this.form1label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // form1label2
            // 
            this.form1label2.AutoSize = true;
            this.form1label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1label2.Location = new System.Drawing.Point(281, 82);
            this.form1label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1label2.Name = "form1label2";
            this.form1label2.Size = new System.Drawing.Size(327, 23);
            this.form1label2.TabIndex = 1;
            this.form1label2.Text = "A Pig Farm Management Software";
            // 
            // form1button1
            // 
            this.form1button1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1button1.Location = new System.Drawing.Point(360, 156);
            this.form1button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form1button1.Name = "form1button1";
            this.form1button1.Size = new System.Drawing.Size(156, 69);
            this.form1button1.TabIndex = 2;
            this.form1button1.Text = "ENTER";
            this.form1button1.UseVisualStyleBackColor = true;
            this.form1button1.Click += new System.EventHandler(this.form1button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 321);
            this.Controls.Add(this.form1button1);
            this.Controls.Add(this.form1label2);
            this.Controls.Add(this.form1label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form1label1;
        private System.Windows.Forms.Label form1label2;
        private System.Windows.Forms.Button form1button1;
    }
}


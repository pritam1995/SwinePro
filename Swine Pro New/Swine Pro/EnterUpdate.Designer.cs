namespace Swine_Pro
{
    partial class EnterUpdate
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
            this.form3button1 = new System.Windows.Forms.Button();
            this.form3button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form3button1
            // 
            this.form3button1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form3button1.Location = new System.Drawing.Point(38, 36);
            this.form3button1.Name = "form3button1";
            this.form3button1.Size = new System.Drawing.Size(153, 36);
            this.form3button1.TabIndex = 2;
            this.form3button1.Text = "ENTER NEW ANIMAL";
            this.form3button1.UseVisualStyleBackColor = true;
            this.form3button1.Click += new System.EventHandler(this.form3button1_Click);
            // 
            // form3button2
            // 
            this.form3button2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form3button2.Location = new System.Drawing.Point(38, 112);
            this.form3button2.Name = "form3button2";
            this.form3button2.Size = new System.Drawing.Size(153, 36);
            this.form3button2.TabIndex = 5;
            this.form3button2.Text = "UPDATE OLD ANIMAL";
            this.form3button2.UseVisualStyleBackColor = true;
            this.form3button2.Click += new System.EventHandler(this.form3button2_Click);
            // 
            // MaleFemale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 191);
            this.Controls.Add(this.form3button2);
            this.Controls.Add(this.form3button1);
            this.Name = "MaleFemale";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button form3button1;
        private System.Windows.Forms.Button form3button2;
    }
}
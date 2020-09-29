namespace HospitalManagementSystemCSharp
{
    partial class Medicine
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Common Cold";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CommonCold_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Diabetes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Diabetes_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Migraine";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Migraine_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Mouth Ulcer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MouthUlcer_click);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Medicine";
            this.Text = "Medications";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
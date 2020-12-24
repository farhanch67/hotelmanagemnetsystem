namespace Final_Assignment
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
            this.buttoncus = new System.Windows.Forms.Button();
            this.Buttonroom = new System.Windows.Forms.Button();
            this.buttonemp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttoncus
            // 
            this.buttoncus.Location = new System.Drawing.Point(72, 74);
            this.buttoncus.Name = "buttoncus";
            this.buttoncus.Size = new System.Drawing.Size(116, 34);
            this.buttoncus.TabIndex = 0;
            this.buttoncus.Text = "Customer";
            this.buttoncus.UseVisualStyleBackColor = true;
            // 
            // Buttonroom
            // 
            this.Buttonroom.Location = new System.Drawing.Point(72, 124);
            this.Buttonroom.Name = "Buttonroom";
            this.Buttonroom.Size = new System.Drawing.Size(116, 34);
            this.Buttonroom.TabIndex = 1;
            this.Buttonroom.Text = "Rooms";
            this.Buttonroom.UseVisualStyleBackColor = true;
            // 
            // buttonemp
            // 
            this.buttonemp.Location = new System.Drawing.Point(72, 171);
            this.buttonemp.Name = "buttonemp";
            this.buttonemp.Size = new System.Drawing.Size(116, 34);
            this.buttonemp.TabIndex = 2;
            this.buttonemp.Text = "Employes";
            this.buttonemp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hotel Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonemp);
            this.Controls.Add(this.Buttonroom);
            this.Controls.Add(this.buttoncus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncus;
        private System.Windows.Forms.Button Buttonroom;
        private System.Windows.Forms.Button buttonemp;
        private System.Windows.Forms.Label label1;
    }
}


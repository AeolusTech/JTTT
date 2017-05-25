namespace JTTT
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
            this.urlAddress = new System.Windows.Forms.TextBox();
            this.tagToSearch = new System.Windows.Forms.TextBox();
            this.AdresEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.przycisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlAddress
            // 
            this.urlAddress.Location = new System.Drawing.Point(96, 65);
            this.urlAddress.Name = "urlAddress";
            this.urlAddress.Size = new System.Drawing.Size(531, 20);
            this.urlAddress.TabIndex = 0;
            this.urlAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tagToSearch
            // 
            this.tagToSearch.Location = new System.Drawing.Point(96, 158);
            this.tagToSearch.Name = "tagToSearch";
            this.tagToSearch.Size = new System.Drawing.Size(531, 20);
            this.tagToSearch.TabIndex = 1;
            // 
            // AdresEmail
            // 
            this.AdresEmail.Location = new System.Drawing.Point(96, 414);
            this.AdresEmail.Name = "AdresEmail";
            this.AdresEmail.Size = new System.Drawing.Size(531, 20);
            this.AdresEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adres URL strony";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tekst";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // przycisk
            // 
            this.przycisk.Location = new System.Drawing.Point(293, 485);
            this.przycisk.Name = "przycisk";
            this.przycisk.Size = new System.Drawing.Size(128, 23);
            this.przycisk.TabIndex = 6;
            this.przycisk.Text = "Ustaw";
            this.przycisk.UseVisualStyleBackColor = true;
            this.przycisk.Click += new System.EventHandler(this.przycisk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 536);
            this.Controls.Add(this.przycisk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdresEmail);
            this.Controls.Add(this.tagToSearch);
            this.Controls.Add(this.urlAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlAddress;
        private System.Windows.Forms.TextBox tagToSearch;
        private System.Windows.Forms.TextBox AdresEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button przycisk;
    }
}


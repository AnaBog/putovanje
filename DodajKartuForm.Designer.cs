namespace Putovanje2
{
    partial class DodajKartuForm
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
            this.mestoPolaska = new System.Windows.Forms.Label();
            this.rastojanje = new System.Windows.Forms.Label();
            this.mestoDolaska = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mestoPolBox = new System.Windows.Forms.TextBox();
            this.mestoDolBox = new System.Windows.Forms.TextBox();
            this.rastojanjeBox = new System.Windows.Forms.TextBox();
            this.masaKoferaBox = new System.Windows.Forms.TextBox();
            this.duzinaPutBox = new System.Windows.Forms.TextBox();
            this.tipKarteBox = new System.Windows.Forms.ComboBox();
            this.sacuvajKartu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mestoPolaska
            // 
            this.mestoPolaska.AutoSize = true;
            this.mestoPolaska.Location = new System.Drawing.Point(47, 23);
            this.mestoPolaska.Name = "mestoPolaska";
            this.mestoPolaska.Size = new System.Drawing.Size(117, 13);
            this.mestoPolaska.TabIndex = 0;
            this.mestoPolaska.Text = "Unesite mesto polaska:";
            // 
            // rastojanje
            // 
            this.rastojanje.AutoSize = true;
            this.rastojanje.Location = new System.Drawing.Point(70, 107);
            this.rastojanje.Name = "rastojanje";
            this.rastojanje.Size = new System.Drawing.Size(94, 13);
            this.rastojanje.TabIndex = 1;
            this.rastojanje.Text = "Unesite rastojanje:";
            // 
            // mestoDolaska
            // 
            this.mestoDolaska.AutoSize = true;
            this.mestoDolaska.Location = new System.Drawing.Point(47, 65);
            this.mestoDolaska.Name = "mestoDolaska";
            this.mestoDolaska.Size = new System.Drawing.Size(117, 13);
            this.mestoDolaska.TabIndex = 2;
            this.mestoDolaska.Text = "Unesite mesto dolaska:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unesite duzinu putovanja (h):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unesite masu kofera:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Izaberite tip karte:";
            // 
            // mestoPolBox
            // 
            this.mestoPolBox.Location = new System.Drawing.Point(170, 20);
            this.mestoPolBox.Name = "mestoPolBox";
            this.mestoPolBox.Size = new System.Drawing.Size(150, 20);
            this.mestoPolBox.TabIndex = 6;
            // 
            // mestoDolBox
            // 
            this.mestoDolBox.Location = new System.Drawing.Point(170, 62);
            this.mestoDolBox.Name = "mestoDolBox";
            this.mestoDolBox.Size = new System.Drawing.Size(150, 20);
            this.mestoDolBox.TabIndex = 7;
            // 
            // rastojanjeBox
            // 
            this.rastojanjeBox.Location = new System.Drawing.Point(170, 104);
            this.rastojanjeBox.Name = "rastojanjeBox";
            this.rastojanjeBox.Size = new System.Drawing.Size(150, 20);
            this.rastojanjeBox.TabIndex = 8;
            // 
            // masaKoferaBox
            // 
            this.masaKoferaBox.Location = new System.Drawing.Point(170, 188);
            this.masaKoferaBox.Name = "masaKoferaBox";
            this.masaKoferaBox.Size = new System.Drawing.Size(150, 20);
            this.masaKoferaBox.TabIndex = 9;
            // 
            // duzinaPutBox
            // 
            this.duzinaPutBox.Location = new System.Drawing.Point(170, 146);
            this.duzinaPutBox.Name = "duzinaPutBox";
            this.duzinaPutBox.Size = new System.Drawing.Size(150, 20);
            this.duzinaPutBox.TabIndex = 10;
            // 
            // tipKarteBox
            // 
            this.tipKarteBox.FormattingEnabled = true;
            this.tipKarteBox.Items.AddRange(new object[] {
            "Avionska",
            "Vozna"});
            this.tipKarteBox.Location = new System.Drawing.Point(170, 230);
            this.tipKarteBox.Name = "tipKarteBox";
            this.tipKarteBox.Size = new System.Drawing.Size(150, 21);
            this.tipKarteBox.TabIndex = 11;
            this.tipKarteBox.Text = "Avionska";
            this.tipKarteBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // sacuvajKartu
            // 
            this.sacuvajKartu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sacuvajKartu.Location = new System.Drawing.Point(170, 279);
            this.sacuvajKartu.Name = "sacuvajKartu";
            this.sacuvajKartu.Size = new System.Drawing.Size(150, 23);
            this.sacuvajKartu.TabIndex = 12;
            this.sacuvajKartu.Text = "ok";
            this.sacuvajKartu.UseVisualStyleBackColor = true;
            this.sacuvajKartu.Click += new System.EventHandler(this.SacuvajKartu_Click);
            // 
            // DodajKartuForm
            // 
            this.AcceptButton = this.sacuvajKartu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(354, 314);
            this.Controls.Add(this.sacuvajKartu);
            this.Controls.Add(this.tipKarteBox);
            this.Controls.Add(this.duzinaPutBox);
            this.Controls.Add(this.masaKoferaBox);
            this.Controls.Add(this.rastojanjeBox);
            this.Controls.Add(this.mestoDolBox);
            this.Controls.Add(this.mestoPolBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mestoDolaska);
            this.Controls.Add(this.rastojanje);
            this.Controls.Add(this.mestoPolaska);
            this.Name = "DodajKartuForm";
            this.Text = "DodajKartuForm";
            this.Load += new System.EventHandler(this.DodajKartuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mestoPolaska;
        private System.Windows.Forms.Label rastojanje;
        private System.Windows.Forms.Label mestoDolaska;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mestoPolBox;
        private System.Windows.Forms.TextBox mestoDolBox;
        private System.Windows.Forms.TextBox rastojanjeBox;
        private System.Windows.Forms.TextBox masaKoferaBox;
        private System.Windows.Forms.TextBox duzinaPutBox;
        private System.Windows.Forms.ComboBox tipKarteBox;
        private System.Windows.Forms.Button sacuvajKartu;
    }
}
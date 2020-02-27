namespace Putovanje2
{
    partial class PutovanjeForm
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
            this.ime = new System.Windows.Forms.TextBox();
            this.prez = new System.Windows.Forms.TextBox();
            this.novac = new System.Windows.Forms.TextBox();
            this.ListaKarata = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(12, 38);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(174, 20);
            this.ime.TabIndex = 0;
            this.ime.Text = "t";
            // 
            // prez
            // 
            this.prez.Location = new System.Drawing.Point(192, 38);
            this.prez.Name = "prez";
            this.prez.Size = new System.Drawing.Size(180, 20);
            this.prez.TabIndex = 1;
            // 
            // novac
            // 
            this.novac.Location = new System.Drawing.Point(12, 96);
            this.novac.Name = "novac";
            this.novac.Size = new System.Drawing.Size(360, 20);
            this.novac.TabIndex = 2;
            // 
            // ListaKarata
            // 
            this.ListaKarata.FormattingEnabled = true;
            this.ListaKarata.Location = new System.Drawing.Point(12, 163);
            this.ListaKarata.Name = "ListaKarata";
            this.ListaKarata.Size = new System.Drawing.Size(225, 134);
            this.ListaKarata.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Snimi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ucitaj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(243, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Obrisi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Obrisi_Kartu);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Dodaj_Kartu);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(243, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "Azuriraj";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Azuriraj_Kartu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Location = new System.Drawing.Point(193, 22);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(44, 13);
            this.Prezime.TabIndex = 10;
            this.Prezime.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Novac putnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Karte";
            // 
            // PutovanjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaKarata);
            this.Controls.Add(this.novac);
            this.Controls.Add(this.prez);
            this.Controls.Add(this.ime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PutovanjeForm";
            this.Text = "Put";
            this.Load += new System.EventHandler(this.PutovanjeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.TextBox prez;
        private System.Windows.Forms.TextBox novac;
        private System.Windows.Forms.ListBox ListaKarata;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}


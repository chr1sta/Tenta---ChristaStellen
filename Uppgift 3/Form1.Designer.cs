namespace Uppgift_3
{
    partial class tbArtist
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
            this.tbLand = new System.Windows.Forms.TextBox();
            this.tbSång = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.Artist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbAntalRöster = new System.Windows.Forms.TextBox();
            this.btnSpara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLand
            // 
            this.tbLand.Location = new System.Drawing.Point(89, 91);
            this.tbLand.Name = "tbLand";
            this.tbLand.Size = new System.Drawing.Size(121, 20);
            this.tbLand.TabIndex = 0;
            // 
            // tbSång
            // 
            this.tbSång.Location = new System.Drawing.Point(89, 138);
            this.tbSång.Name = "tbSång";
            this.tbSång.Size = new System.Drawing.Size(121, 20);
            this.tbSång.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(89, 52);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(121, 20);
            this.textBoxArtist.TabIndex = 3;
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Location = new System.Drawing.Point(86, 36);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(30, 13);
            this.Artist.TabIndex = 4;
            this.Artist.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Land";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sång";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Språk";
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(89, 234);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(75, 23);
            this.btnLäggTill.TabIndex = 8;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(244, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 186);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbAntalRöster
            // 
            this.tbAntalRöster.Location = new System.Drawing.Point(443, 202);
            this.tbAntalRöster.Name = "tbAntalRöster";
            this.tbAntalRöster.Size = new System.Drawing.Size(121, 20);
            this.tbAntalRöster.TabIndex = 10;
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(443, 234);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 11;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Antal röster";
            // 
            // tbArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.tbAntalRöster);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.textBoxArtist);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbSång);
            this.Controls.Add(this.tbLand);
            this.Name = "tbArtist";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tbArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLand;
        private System.Windows.Forms.TextBox tbSång;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbAntalRöster;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Label label1;
    }
}


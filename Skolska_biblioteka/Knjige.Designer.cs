
namespace Skolska_biblioteka
{
    partial class Knjige
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
            this.cmb_izdavac = new System.Windows.Forms.ComboBox();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.btn_sledeci = new System.Windows.Forms.Button();
            this.btn_prethodni = new System.Windows.Forms.Button();
            this.btn_prvi = new System.Windows.Forms.Button();
            this.btn_poslednji = new System.Windows.Forms.Button();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_tekst = new System.Windows.Forms.Label();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.txt_kolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_izdavac
            // 
            this.cmb_izdavac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_izdavac.FormattingEnabled = true;
            this.cmb_izdavac.Location = new System.Drawing.Point(311, 215);
            this.cmb_izdavac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_izdavac.Name = "cmb_izdavac";
            this.cmb_izdavac.Size = new System.Drawing.Size(436, 33);
            this.cmb_izdavac.TabIndex = 88;
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uloga.Location = new System.Drawing.Point(201, 218);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(96, 25);
            this.lbl_uloga.TabIndex = 87;
            this.lbl_uloga.Text = "Издавач:";
            // 
            // btn_sledeci
            // 
            this.btn_sledeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sledeci.Location = new System.Drawing.Point(655, 329);
            this.btn_sledeci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sledeci.Name = "btn_sledeci";
            this.btn_sledeci.Size = new System.Drawing.Size(84, 64);
            this.btn_sledeci.TabIndex = 86;
            this.btn_sledeci.Text = ">";
            this.btn_sledeci.UseVisualStyleBackColor = true;
            this.btn_sledeci.Click += new System.EventHandler(this.btn_sledeci_Click);
            // 
            // btn_prethodni
            // 
            this.btn_prethodni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prethodni.Location = new System.Drawing.Point(303, 329);
            this.btn_prethodni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prethodni.Name = "btn_prethodni";
            this.btn_prethodni.Size = new System.Drawing.Size(84, 64);
            this.btn_prethodni.TabIndex = 85;
            this.btn_prethodni.Text = "<";
            this.btn_prethodni.UseVisualStyleBackColor = true;
            this.btn_prethodni.Click += new System.EventHandler(this.btn_prethodni_Click);
            // 
            // btn_prvi
            // 
            this.btn_prvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prvi.Location = new System.Drawing.Point(27, 329);
            this.btn_prvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prvi.Name = "btn_prvi";
            this.btn_prvi.Size = new System.Drawing.Size(84, 64);
            this.btn_prvi.TabIndex = 84;
            this.btn_prvi.Text = "<<";
            this.btn_prvi.UseVisualStyleBackColor = true;
            this.btn_prvi.Click += new System.EventHandler(this.btn_prvi_Click);
            // 
            // btn_poslednji
            // 
            this.btn_poslednji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_poslednji.Location = new System.Drawing.Point(889, 329);
            this.btn_poslednji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_poslednji.Name = "btn_poslednji";
            this.btn_poslednji.Size = new System.Drawing.Size(84, 64);
            this.btn_poslednji.TabIndex = 83;
            this.btn_poslednji.Text = ">>";
            this.btn_poslednji.UseVisualStyleBackColor = true;
            this.btn_poslednji.Click += new System.EventHandler(this.btn_poslednji_Click);
            // 
            // txt_naziv
            // 
            this.txt_naziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_naziv.Location = new System.Drawing.Point(311, 163);
            this.txt_naziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(435, 30);
            this.txt_naziv.TabIndex = 79;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_isbn.Location = new System.Drawing.Point(311, 104);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(435, 30);
            this.txt_isbn.TabIndex = 78;
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(224, 166);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(73, 25);
            this.lbl_prezime.TabIndex = 76;
            this.lbl_prezime.Text = "Назив:";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(233, 107);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(64, 25);
            this.lbl_ime.TabIndex = 75;
            this.lbl_ime.Text = "ISBN:";
            // 
            // lbl_tekst
            // 
            this.lbl_tekst.AutoSize = true;
            this.lbl_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tekst.Location = new System.Drawing.Point(414, 40);
            this.lbl_tekst.Name = "lbl_tekst";
            this.lbl_tekst.Size = new System.Drawing.Size(190, 25);
            this.lbl_tekst.TabIndex = 72;
            this.lbl_tekst.Text = "Подаци о књигама:";
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi.Location = new System.Drawing.Point(687, 415);
            this.btn_obrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(292, 64);
            this.btn_obrisi.TabIndex = 91;
            this.btn_obrisi.Text = "Обриши књигу";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(33, 415);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(292, 64);
            this.btn_dodaj.TabIndex = 90;
            this.btn_dodaj.Text = "Додај књигу";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(358, 415);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(292, 64);
            this.btn_izmeni.TabIndex = 89;
            this.btn_izmeni.Text = "Измени податке";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // txt_kolicina
            // 
            this.txt_kolicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kolicina.Location = new System.Drawing.Point(311, 271);
            this.txt_kolicina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kolicina.Name = "txt_kolicina";
            this.txt_kolicina.Size = new System.Drawing.Size(435, 30);
            this.txt_kolicina.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 92;
            this.label1.Text = "Количина:";
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 509);
            this.Controls.Add(this.txt_kolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.cmb_izdavac);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.btn_sledeci);
            this.Controls.Add(this.btn_prethodni);
            this.Controls.Add(this.btn_prvi);
            this.Controls.Add(this.btn_poslednji);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.lbl_tekst);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.Load += new System.EventHandler(this.Knjige_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_izdavac;
        private System.Windows.Forms.Label lbl_uloga;
        private System.Windows.Forms.Button btn_sledeci;
        private System.Windows.Forms.Button btn_prethodni;
        private System.Windows.Forms.Button btn_prvi;
        private System.Windows.Forms.Button btn_poslednji;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_tekst;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.TextBox txt_kolicina;
        private System.Windows.Forms.Label label1;
    }
}
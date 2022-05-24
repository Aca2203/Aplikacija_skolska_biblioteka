
namespace Skolska_biblioteka
{
    partial class Administrator
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
            this.cmb_uloga = new System.Windows.Forms.ComboBox();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.btn_sledeci = new System.Windows.Forms.Button();
            this.btn_prethodni = new System.Windows.Forms.Button();
            this.btn_prvi = new System.Windows.Forms.Button();
            this.btn_poslednji = new System.Windows.Forms.Button();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.txt_lozinka = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.lbl_jmbg = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_tekst = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.књигеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издавачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ауториToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_uloga
            // 
            this.cmb_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_uloga.FormattingEnabled = true;
            this.cmb_uloga.Location = new System.Drawing.Point(420, 404);
            this.cmb_uloga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_uloga.Name = "cmb_uloga";
            this.cmb_uloga.Size = new System.Drawing.Size(436, 33);
            this.cmb_uloga.TabIndex = 71;
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uloga.Location = new System.Drawing.Point(335, 407);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(71, 25);
            this.lbl_uloga.TabIndex = 70;
            this.lbl_uloga.Text = "Улога:";
            // 
            // btn_sledeci
            // 
            this.btn_sledeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sledeci.Location = new System.Drawing.Point(774, 496);
            this.btn_sledeci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sledeci.Name = "btn_sledeci";
            this.btn_sledeci.Size = new System.Drawing.Size(84, 64);
            this.btn_sledeci.TabIndex = 68;
            this.btn_sledeci.Text = ">";
            this.btn_sledeci.UseVisualStyleBackColor = true;
            this.btn_sledeci.Click += new System.EventHandler(this.btn_sledeci_Click);
            // 
            // btn_prethodni
            // 
            this.btn_prethodni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prethodni.Location = new System.Drawing.Point(422, 496);
            this.btn_prethodni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prethodni.Name = "btn_prethodni";
            this.btn_prethodni.Size = new System.Drawing.Size(84, 64);
            this.btn_prethodni.TabIndex = 67;
            this.btn_prethodni.Text = "<";
            this.btn_prethodni.UseVisualStyleBackColor = true;
            this.btn_prethodni.Click += new System.EventHandler(this.btn_prethodni_Click);
            // 
            // btn_prvi
            // 
            this.btn_prvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prvi.Location = new System.Drawing.Point(146, 496);
            this.btn_prvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prvi.Name = "btn_prvi";
            this.btn_prvi.Size = new System.Drawing.Size(84, 64);
            this.btn_prvi.TabIndex = 66;
            this.btn_prvi.Text = "<<";
            this.btn_prvi.UseVisualStyleBackColor = true;
            this.btn_prvi.Click += new System.EventHandler(this.btn_prvi_Click);
            // 
            // btn_poslednji
            // 
            this.btn_poslednji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_poslednji.Location = new System.Drawing.Point(1008, 496);
            this.btn_poslednji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_poslednji.Name = "btn_poslednji";
            this.btn_poslednji.Size = new System.Drawing.Size(84, 64);
            this.btn_poslednji.TabIndex = 65;
            this.btn_poslednji.Text = ">>";
            this.btn_poslednji.UseVisualStyleBackColor = true;
            this.btn_poslednji.Click += new System.EventHandler(this.btn_poslednji_Click);
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi.Location = new System.Drawing.Point(800, 576);
            this.btn_obrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(292, 64);
            this.btn_obrisi.TabIndex = 64;
            this.btn_obrisi.Text = "Обриши особу";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            this.btn_obrisi.Click += new System.EventHandler(this.btn_obrisi_Click);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(146, 576);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(292, 64);
            this.btn_dodaj.TabIndex = 63;
            this.btn_dodaj.Text = "Додај особу";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(471, 576);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(292, 64);
            this.btn_izmeni.TabIndex = 62;
            this.btn_izmeni.Text = "Измени податке";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jmbg.Location = new System.Drawing.Point(422, 348);
            this.txt_jmbg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(435, 30);
            this.txt_jmbg.TabIndex = 61;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lozinka.Location = new System.Drawing.Point(422, 288);
            this.txt_lozinka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.Size = new System.Drawing.Size(435, 30);
            this.txt_lozinka.TabIndex = 60;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(422, 228);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(435, 30);
            this.txt_email.TabIndex = 59;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prezime.Location = new System.Drawing.Point(422, 171);
            this.txt_prezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(435, 30);
            this.txt_prezime.TabIndex = 58;
            // 
            // txt_ime
            // 
            this.txt_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ime.Location = new System.Drawing.Point(422, 112);
            this.txt_ime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(435, 30);
            this.txt_ime.TabIndex = 57;
            // 
            // lbl_jmbg
            // 
            this.lbl_jmbg.AutoSize = true;
            this.lbl_jmbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jmbg.Location = new System.Drawing.Point(337, 351);
            this.lbl_jmbg.Name = "lbl_jmbg";
            this.lbl_jmbg.Size = new System.Drawing.Size(69, 25);
            this.lbl_jmbg.TabIndex = 56;
            this.lbl_jmbg.Text = "ЈМБГ:";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(302, 174);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(104, 25);
            this.lbl_prezime.TabIndex = 55;
            this.lbl_prezime.Text = "Презиме:";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(346, 115);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(60, 25);
            this.lbl_ime.TabIndex = 54;
            this.lbl_ime.Text = "Име:";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lozinka.Location = new System.Drawing.Point(309, 291);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(97, 25);
            this.lbl_lozinka.TabIndex = 53;
            this.lbl_lozinka.Text = "Лозинка:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(261, 231);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(145, 25);
            this.lbl_email.TabIndex = 52;
            this.lbl_email.Text = "Имејл адреса:";
            // 
            // lbl_tekst
            // 
            this.lbl_tekst.AutoSize = true;
            this.lbl_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tekst.Location = new System.Drawing.Point(506, 48);
            this.lbl_tekst.Name = "lbl_tekst";
            this.lbl_tekst.Size = new System.Drawing.Size(234, 25);
            this.lbl_tekst.TabIndex = 51;
            this.lbl_tekst.Text = "Подаци о корисницима:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.књигеToolStripMenuItem,
            this.издавачиToolStripMenuItem,
            this.ауториToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // књигеToolStripMenuItem
            // 
            this.књигеToolStripMenuItem.Name = "књигеToolStripMenuItem";
            this.књигеToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.књигеToolStripMenuItem.Text = "Књиге";
            this.књигеToolStripMenuItem.Click += new System.EventHandler(this.књигеToolStripMenuItem_Click);
            // 
            // издавачиToolStripMenuItem
            // 
            this.издавачиToolStripMenuItem.Name = "издавачиToolStripMenuItem";
            this.издавачиToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.издавачиToolStripMenuItem.Text = "Издавачи";
            this.издавачиToolStripMenuItem.Click += new System.EventHandler(this.издавачиToolStripMenuItem_Click);
            // 
            // ауториToolStripMenuItem
            // 
            this.ауториToolStripMenuItem.Name = "ауториToolStripMenuItem";
            this.ауториToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ауториToolStripMenuItem.Text = "Аутори";
            this.ауториToolStripMenuItem.Click += new System.EventHandler(this.ауториToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 674);
            this.Controls.Add(this.cmb_uloga);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.btn_sledeci);
            this.Controls.Add(this.btn_prethodni);
            this.Controls.Add(this.btn_prvi);
            this.Controls.Add(this.btn_poslednji);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.txt_lozinka);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.lbl_jmbg);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_tekst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrator_FormClosed);
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_uloga;
        private System.Windows.Forms.Label lbl_uloga;
        private System.Windows.Forms.Button btn_sledeci;
        private System.Windows.Forms.Button btn_prethodni;
        private System.Windows.Forms.Button btn_prvi;
        private System.Windows.Forms.Button btn_poslednji;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.TextBox txt_lozinka;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.Label lbl_jmbg;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_tekst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem књигеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem издавачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ауториToolStripMenuItem;
    }
}
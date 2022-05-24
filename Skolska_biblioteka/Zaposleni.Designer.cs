
namespace Skolska_biblioteka
{
    partial class Zaposleni
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
            this.cmb_datum_uzimanja = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_datum_vracanja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_knjiga = new System.Windows.Forms.ComboBox();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.cmb_clan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_obrisi = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_datum_uzimanja
            // 
            this.cmb_datum_uzimanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_datum_uzimanja.Location = new System.Drawing.Point(233, 20);
            this.cmb_datum_uzimanja.Name = "cmb_datum_uzimanja";
            this.cmb_datum_uzimanja.Size = new System.Drawing.Size(332, 30);
            this.cmb_datum_uzimanja.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Датум узимања:";
            // 
            // cmb_datum_vracanja
            // 
            this.cmb_datum_vracanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_datum_vracanja.Location = new System.Drawing.Point(233, 56);
            this.cmb_datum_vracanja.Name = "cmb_datum_vracanja";
            this.cmb_datum_vracanja.Size = new System.Drawing.Size(332, 30);
            this.cmb_datum_vracanja.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Датум враћања:";
            // 
            // cmb_knjiga
            // 
            this.cmb_knjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_knjiga.FormattingEnabled = true;
            this.cmb_knjiga.Location = new System.Drawing.Point(767, 61);
            this.cmb_knjiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_knjiga.Name = "cmb_knjiga";
            this.cmb_knjiga.Size = new System.Drawing.Size(436, 33);
            this.cmb_knjiga.TabIndex = 73;
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uloga.Location = new System.Drawing.Point(682, 64);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(74, 25);
            this.lbl_uloga.TabIndex = 72;
            this.lbl_uloga.Text = "Књига:";
            // 
            // cmb_clan
            // 
            this.cmb_clan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clan.FormattingEnabled = true;
            this.cmb_clan.Location = new System.Drawing.Point(767, 21);
            this.cmb_clan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_clan.Name = "cmb_clan";
            this.cmb_clan.Size = new System.Drawing.Size(436, 33);
            this.cmb_clan.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Члан:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 379);
            this.dataGridView1.TabIndex = 78;
            // 
            // btn_obrisi
            // 
            this.btn_obrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi.Location = new System.Drawing.Point(832, 140);
            this.btn_obrisi.Name = "btn_obrisi";
            this.btn_obrisi.Size = new System.Drawing.Size(213, 34);
            this.btn_obrisi.TabIndex = 80;
            this.btn_obrisi.Text = "Обриши резервацију";
            this.btn_obrisi.UseVisualStyleBackColor = true;
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj.Location = new System.Drawing.Point(237, 140);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(198, 34);
            this.btn_dodaj.TabIndex = 79;
            this.btn_dodaj.Text = "Додај резервацију";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(533, 140);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(213, 34);
            this.btn_izmeni.TabIndex = 81;
            this.btn_izmeni.Text = "Измени резервацију";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            // 
            // Zaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 618);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_obrisi);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_clan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_knjiga);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.cmb_datum_vracanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_datum_uzimanja);
            this.Controls.Add(this.label6);
            this.Name = "Zaposleni";
            this.Text = "Zaposleni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Zaposleni_FormClosed);
            this.Load += new System.EventHandler(this.Zaposleni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cmb_datum_uzimanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker cmb_datum_vracanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_knjiga;
        private System.Windows.Forms.Label lbl_uloga;
        private System.Windows.Forms.ComboBox cmb_clan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_obrisi;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_izmeni;
    }
}
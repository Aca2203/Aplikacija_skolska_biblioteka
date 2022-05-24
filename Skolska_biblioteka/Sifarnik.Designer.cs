
namespace Skolska_biblioteka
{
    partial class Sifarnik
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
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.grid_podaci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_podaci)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni.Location = new System.Drawing.Point(226, 291);
            this.btn_izmeni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(292, 64);
            this.btn_izmeni.TabIndex = 15;
            this.btn_izmeni.Text = "Измени податке";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // grid_podaci
            // 
            this.grid_podaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_podaci.Location = new System.Drawing.Point(15, 15);
            this.grid_podaci.Margin = new System.Windows.Forms.Padding(4);
            this.grid_podaci.Name = "grid_podaci";
            this.grid_podaci.RowHeadersWidth = 51;
            this.grid_podaci.Size = new System.Drawing.Size(701, 233);
            this.grid_podaci.TabIndex = 14;
            // 
            // Sifarnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 397);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.grid_podaci);
            this.Name = "Sifarnik";
            this.Text = "Sifarnik";
            this.Load += new System.EventHandler(this.Sifarnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_podaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.DataGridView grid_podaci;
    }
}
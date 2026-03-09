namespace Forme
{
    partial class IzvođačForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblIzvodjaci;
        private System.Windows.Forms.Label lblZanrovi;
        private System.Windows.Forms.DataGridView dgvIzvodjaci;
        private System.Windows.Forms.DataGridView dgvZanrovi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOsvezi;

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
            lblIzvodjaci = new Label();
            lblZanrovi = new Label();
            dgvIzvodjaci = new DataGridView();
            dgvZanrovi = new DataGridView();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnOsvezi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIzvodjaci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvZanrovi).BeginInit();
            SuspendLayout();
            // 
            // lblIzvodjaci
            // 
            lblIzvodjaci.AutoSize = true;
            lblIzvodjaci.Location = new Point(30, 20);
            lblIzvodjaci.Name = "lblIzvodjaci";
            lblIzvodjaci.Size = new Size(97, 15);
            lblIzvodjaci.TabIndex = 0;
            lblIzvodjaci.Text = "Lista izvođača:";
            // 
            // lblZanrovi
            // 
            lblZanrovi.AutoSize = true;
            lblZanrovi.Location = new Point(700, 20);
            lblZanrovi.Name = "lblZanrovi";
            lblZanrovi.Size = new Size(122, 15);
            lblZanrovi.TabIndex = 1;
            lblZanrovi.Text = "Žanrovi izvođača:";
            // 
            // dgvIzvodjaci
            // 
            dgvIzvodjaci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIzvodjaci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIzvodjaci.Location = new Point(30, 50);
            dgvIzvodjaci.MultiSelect = false;
            dgvIzvodjaci.Name = "dgvIzvodjaci";
            dgvIzvodjaci.ReadOnly = true;
            dgvIzvodjaci.RowHeadersVisible = false;
            dgvIzvodjaci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIzvodjaci.Size = new Size(620, 330);
            dgvIzvodjaci.TabIndex = 2;
            dgvIzvodjaci.CellClick += dgvIzvodjaci_CellClick;
            dgvIzvodjaci.AutoGenerateColumns = false;
            dgvIzvodjaci.DataBindingComplete += dgvIzvodjaci_DataBindingComplete;
            // 
            // dgvZanrovi
            // 
            dgvZanrovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZanrovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZanrovi.Location = new Point(700, 50);
            dgvZanrovi.MultiSelect = false;
            dgvZanrovi.Name = "dgvZanrovi";
            dgvZanrovi.ReadOnly = true;
            dgvZanrovi.RowHeadersVisible = false;
            dgvZanrovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZanrovi.Size = new Size(250, 330);
            dgvZanrovi.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(30, 400);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(100, 35);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(150, 400);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(100, 35);
            btnIzmeni.TabIndex = 5;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(270, 400);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(100, 35);
            btnObrisi.TabIndex = 6;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnOsvezi
            // 
            btnOsvezi.Location = new Point(390, 400);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(100, 35);
            btnOsvezi.TabIndex = 7;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = true;
            btnOsvezi.Click += btnOsvezi_Click;
            // 
            // IzvodjacForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(btnOsvezi);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(dgvZanrovi);
            Controls.Add(dgvIzvodjaci);
            Controls.Add(lblZanrovi);
            Controls.Add(lblIzvodjaci);
            Name = "IzvodjacForma";
            Text = "Rad sa izvođačima";
            Load += IzvodjacForma_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIzvodjaci).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvZanrovi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
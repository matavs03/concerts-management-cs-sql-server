namespace Forme
{
    partial class ŽanrForma
    {
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOsvezi;
        private System.Windows.Forms.DataGridView dgvZanrovi;
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
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnOsvezi = new Button();
            dgvZanrovi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvZanrovi).BeginInit();
            SuspendLayout();
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(30, 30);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(70, 15);
            lblNaziv.TabIndex = 0;
            lblNaziv.Text = "Naziv žanra:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(130, 27);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(200, 23);
            txtNaziv.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(350, 25);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(90, 30);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(450, 25);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(90, 30);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(550, 25);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(90, 30);
            btnObrisi.TabIndex = 4;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnOsvezi
            // 
            btnOsvezi.Location = new Point(650, 25);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(90, 30);
            btnOsvezi.TabIndex = 5;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = true;
            btnOsvezi.Click += btnOsvezi_Click;
            // 
            // dgvZanrovi
            // 
            dgvZanrovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZanrovi.Location = new Point(30, 80);
            dgvZanrovi.MultiSelect = false;
            dgvZanrovi.Name = "dgvZanrovi";
            dgvZanrovi.ReadOnly = true;
            dgvZanrovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZanrovi.Size = new Size(740, 320);
            dgvZanrovi.TabIndex = 6;
            dgvZanrovi.CellClick += dgvZanrovi_CellClick;
            // 
            // ŽanrForma
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(btnOsvezi);
            Controls.Add(dgvZanrovi);
            Name = "ŽanrForma";
            Text = "Rad sa žanrovima";
            Load += ŽanrForma_Load;
            ((System.ComponentModel.ISupportInitialize)dgvZanrovi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
namespace Forme
{
    partial class GradForma
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
            lblNaziv.Location = new Point(30, 43);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(70, 15);
            lblNaziv.TabIndex = 7;
            lblNaziv.Text = "Naziv žanra:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(130, 40);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(200, 23);
            txtNaziv.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(350, 38);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(90, 30);
            btnDodaj.TabIndex = 9;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(450, 38);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(90, 30);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(550, 38);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(90, 30);
            btnObrisi.TabIndex = 11;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnOsvezi
            // 
            btnOsvezi.Location = new Point(650, 38);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(90, 30);
            btnOsvezi.TabIndex = 12;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = true;
            btnOsvezi.Click += btnOsvezi_Click;
            // 
            // dgvZanrovi
            // 
            dgvZanrovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZanrovi.Location = new Point(30, 93);
            dgvZanrovi.MultiSelect = false;
            dgvZanrovi.Name = "dgvZanrovi";
            dgvZanrovi.ReadOnly = true;
            dgvZanrovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZanrovi.Size = new Size(740, 320);
            dgvZanrovi.TabIndex = 13;
            // 
            // GradForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(btnOsvezi);
            Controls.Add(dgvZanrovi);
            Name = "GradForma";
            Text = "GradForma";
            Load += GradForma_Load;
            ((System.ComponentModel.ISupportInitialize)dgvZanrovi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNaziv;
        private TextBox txtNaziv;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Button btnOsvezi;
        private DataGridView dgvZanrovi;
    }
}
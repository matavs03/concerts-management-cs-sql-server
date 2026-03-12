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
            lblNaziv.Location = new Point(34, 57);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(92, 20);
            lblNaziv.TabIndex = 7;
            lblNaziv.Text = "Naziv grada:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(149, 53);
            txtNaziv.Margin = new Padding(3, 4, 3, 4);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(228, 27);
            txtNaziv.TabIndex = 8;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(400, 51);
            btnDodaj.Margin = new Padding(3, 4, 3, 4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(103, 40);
            btnDodaj.TabIndex = 9;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(514, 51);
            btnIzmeni.Margin = new Padding(3, 4, 3, 4);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(103, 40);
            btnIzmeni.TabIndex = 10;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(629, 51);
            btnObrisi.Margin = new Padding(3, 4, 3, 4);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(103, 40);
            btnObrisi.TabIndex = 11;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnOsvezi
            // 
            btnOsvezi.Location = new Point(743, 51);
            btnOsvezi.Margin = new Padding(3, 4, 3, 4);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(103, 40);
            btnOsvezi.TabIndex = 12;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = true;
            btnOsvezi.Click += btnOsvezi_Click;
            // 
            // dgvZanrovi
            // 
            dgvZanrovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZanrovi.ColumnHeadersHeight = 29;
            dgvZanrovi.Location = new Point(34, 124);
            dgvZanrovi.Margin = new Padding(3, 4, 3, 4);
            dgvZanrovi.MultiSelect = false;
            dgvZanrovi.Name = "dgvZanrovi";
            dgvZanrovi.ReadOnly = true;
            dgvZanrovi.RowHeadersWidth = 51;
            dgvZanrovi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZanrovi.Size = new Size(846, 427);
            dgvZanrovi.TabIndex = 13;
            dgvZanrovi.CellClick += dgvZanrovi_CellClick;
            dgvZanrovi.CellContentClick += dgvZanrovi_CellClick;
            // 
            // GradForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblNaziv);
            Controls.Add(txtNaziv);
            Controls.Add(btnDodaj);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(btnOsvezi);
            Controls.Add(dgvZanrovi);
            Margin = new Padding(3, 4, 3, 4);
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
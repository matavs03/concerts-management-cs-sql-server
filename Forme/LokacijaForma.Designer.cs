namespace Forme
{
    partial class LokacijaForma
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLokacije;
        private System.Windows.Forms.DataGridView dgvLokacije;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOsvezi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblLokacije = new Label();
            dgvLokacije = new DataGridView();
            btnDodaj = new Button();
            btnIzmeni = new Button();
            btnObrisi = new Button();
            btnOsvezi = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLokacije).BeginInit();
            SuspendLayout();
            // 
            // lblLokacije
            // 
            lblLokacije.AutoSize = true;
            lblLokacije.Location = new Point(30, 20);
            lblLokacije.Name = "lblLokacije";
            lblLokacije.Size = new Size(77, 15);
            lblLokacije.TabIndex = 0;
            lblLokacije.Text = "Lista lokacija:";
            // 
            // dgvLokacije
            // 
            dgvLokacije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLokacije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLokacije.Location = new Point(30, 50);
            dgvLokacije.MultiSelect = false;
            dgvLokacije.Name = "dgvLokacije";
            dgvLokacije.ReadOnly = true;
            dgvLokacije.RowHeadersVisible = false;
            dgvLokacije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLokacije.Size = new Size(620, 330);
            dgvLokacije.TabIndex = 1;

            dgvLokacije.DataBindingComplete += dgvLokacije_DataBindingComplete;


            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(30, 400);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(100, 35);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(150, 400);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(100, 35);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.Location = new Point(270, 400);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(100, 35);
            btnObrisi.TabIndex = 4;
            btnObrisi.Text = "Obriši";
            btnObrisi.UseVisualStyleBackColor = true;
            btnObrisi.Click += btnObrisi_Click;
            // 
            // btnOsvezi
            // 
            btnOsvezi.Location = new Point(390, 400);
            btnOsvezi.Name = "btnOsvezi";
            btnOsvezi.Size = new Size(100, 35);
            btnOsvezi.TabIndex = 5;
            btnOsvezi.Text = "Osveži";
            btnOsvezi.UseVisualStyleBackColor = true;
            btnOsvezi.Click += btnOsvezi_Click;
            // 
            // LokacijaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(btnOsvezi);
            Controls.Add(btnObrisi);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodaj);
            Controls.Add(dgvLokacije);
            Controls.Add(lblLokacije);
            Name = "LokacijaForma";
            Text = "Rad sa lokacijama";
            Load += LokacijaForma_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLokacije).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

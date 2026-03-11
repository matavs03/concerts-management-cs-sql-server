namespace Forme
{
    partial class LokacijaDetaljiForma
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblNaslov;
        private Label lblNaziv;
        private TextBox txtNaziv;
        private Label lblAdresa;
        private TextBox txtAdresa;
        private Label lblKapacitet;
        private NumericUpDown numKapacitet;
        private Label lblGrad;
        private ComboBox cmbGrad;
        private Button btnSacuvaj;
        private Button btnOdustani;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNaslov = new Label();
            lblNaziv = new Label();
            txtNaziv = new TextBox();
            lblAdresa = new Label();
            txtAdresa = new TextBox();
            lblKapacitet = new Label();
            numKapacitet = new NumericUpDown();
            lblGrad = new Label();
            cmbGrad = new ComboBox();
            btnSacuvaj = new Button();
            btnOdustani = new Button();
            ((System.ComponentModel.ISupportInitialize)numKapacitet).BeginInit();
            SuspendLayout();
            // 
            // lblNaslov
            // 
            lblNaslov.AutoSize = true;
            lblNaslov.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNaslov.Location = new Point(30, 20);
            lblNaslov.Name = "lblNaslov";
            lblNaslov.Size = new Size(114, 20);
            lblNaslov.TabIndex = 0;
            lblNaslov.Text = "Unos podataka";
            // 
            // lblNaziv
            // 
            lblNaziv.AutoSize = true;
            lblNaziv.Location = new Point(30, 60);
            lblNaziv.Name = "lblNaziv";
            lblNaziv.Size = new Size(39, 15);
            lblNaziv.TabIndex = 1;
            lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(150, 57);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(220, 23);
            txtNaziv.TabIndex = 2;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(30, 100);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(46, 15);
            lblAdresa.TabIndex = 3;
            lblAdresa.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(150, 97);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(220, 23);
            txtAdresa.TabIndex = 4;
            // 
            // lblKapacitet
            // 
            lblKapacitet.AutoSize = true;
            lblKapacitet.Location = new Point(30, 140);
            lblKapacitet.Name = "lblKapacitet";
            lblKapacitet.Size = new Size(59, 15);
            lblKapacitet.TabIndex = 5;
            lblKapacitet.Text = "Kapacitet:";
            // 
            // numKapacitet
            // 
            numKapacitet.Location = new Point(150, 137);
            numKapacitet.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numKapacitet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numKapacitet.Name = "numKapacitet";
            numKapacitet.Size = new Size(220, 23);
            numKapacitet.TabIndex = 6;
            numKapacitet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblGrad
            // 
            lblGrad.AutoSize = true;
            lblGrad.Location = new Point(30, 180);
            lblGrad.Name = "lblGrad";
            lblGrad.Size = new Size(35, 15);
            lblGrad.TabIndex = 7;
            lblGrad.Text = "Grad:";
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(150, 177);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(220, 23);
            cmbGrad.TabIndex = 8;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(150, 220);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(100, 35);
            btnSacuvaj.TabIndex = 9;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(270, 220);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(100, 35);
            btnOdustani.TabIndex = 10;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // LokacijaDetaljiForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 338);
            Controls.Add(btnOdustani);
            Controls.Add(btnSacuvaj);
            Controls.Add(cmbGrad);
            Controls.Add(lblGrad);
            Controls.Add(numKapacitet);
            Controls.Add(lblKapacitet);
            Controls.Add(txtAdresa);
            Controls.Add(lblAdresa);
            Controls.Add(txtNaziv);
            Controls.Add(lblNaziv);
            Controls.Add(lblNaslov);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LokacijaDetaljiForma";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalji lokacije";
            Load += LokacijaDetaljiForma_Load;
            ((System.ComponentModel.ISupportInitialize)numKapacitet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

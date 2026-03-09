namespace Forme
{
    partial class KoncertForma
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
            labelPretraga = new Label();
            dataGridView1 = new DataGridView();
            buttonKupiKartu = new Button();
            buttonIzmeni = new Button();
            buttonObrisi = new Button();
            buttonDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelPretraga
            // 
            labelPretraga.AutoSize = true;
            labelPretraga.Location = new Point(12, 32);
            labelPretraga.Name = "labelPretraga";
            labelPretraga.Size = new Size(149, 25);
            labelPretraga.TabIndex = 1;
            labelPretraga.Text = "Pretrazite koncert";
            labelPretraga.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(925, 376);
            dataGridView1.TabIndex = 4;
            // 
            // buttonKupiKartu
            // 
            buttonKupiKartu.Location = new Point(900, 515);
            buttonKupiKartu.Name = "buttonKupiKartu";
            buttonKupiKartu.Size = new Size(112, 34);
            buttonKupiKartu.TabIndex = 5;
            buttonKupiKartu.Text = "Kupi kartu";
            buttonKupiKartu.UseVisualStyleBackColor = true;
            buttonKupiKartu.Click += button1_Click;
            // 
            // buttonIzmeni
            // 
            buttonIzmeni.Location = new Point(427, 29);
            buttonIzmeni.Name = "buttonIzmeni";
            buttonIzmeni.Size = new Size(112, 34);
            buttonIzmeni.TabIndex = 6;
            buttonIzmeni.Text = "Izmeni";
            buttonIzmeni.UseVisualStyleBackColor = true;
            buttonIzmeni.Click += buttonIzmeni_Click;
            // 
            // buttonObrisi
            // 
            buttonObrisi.Location = new Point(578, 32);
            buttonObrisi.Name = "buttonObrisi";
            buttonObrisi.Size = new Size(112, 34);
            buttonObrisi.TabIndex = 7;
            buttonObrisi.Text = "Obrisi";
            buttonObrisi.UseVisualStyleBackColor = true;
            buttonObrisi.Click += buttonObrisi_Click;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(723, 28);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(112, 34);
            buttonDodaj.TabIndex = 8;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // KoncertForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 615);
            Controls.Add(buttonDodaj);
            Controls.Add(buttonObrisi);
            Controls.Add(buttonIzmeni);
            Controls.Add(buttonKupiKartu);
            Controls.Add(dataGridView1);
            Controls.Add(labelPretraga);
            Name = "KoncertForma";
            Text = "KoncertForma";
            Load += KoncertForma_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelPretraga;
        private DataGridView dataGridView1;
        private Button buttonKupiKartu;
        private Button buttonIzmeni;
        private Button buttonObrisi;
        private Button buttonDodaj;
    }
}
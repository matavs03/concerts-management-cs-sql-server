namespace Forme
{
    partial class IzborTipaIzvodjacaForma
    {

        
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPitanje;
        private System.Windows.Forms.Button btnMuzicar;
        private System.Windows.Forms.Button btnBend;
        private System.Windows.Forms.Button btnOdustani;
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
            lblPitanje = new Label();
            btnMuzicar = new Button();
            btnBend = new Button();
            btnOdustani = new Button();
            SuspendLayout();
            // 
            // lblPitanje
            // 
            lblPitanje.AutoSize = true;
            lblPitanje.Location = new Point(32, 22);
            lblPitanje.Name = "lblPitanje";
            lblPitanje.Size = new Size(181, 15);
            lblPitanje.TabIndex = 0;
            lblPitanje.Text = "Koju vrstu izvođača želite da dodate?";
            // 
            // btnMuzicar
            // 
            btnMuzicar.Location = new Point(32, 60);
            btnMuzicar.Name = "btnMuzicar";
            btnMuzicar.Size = new Size(90, 35);
            btnMuzicar.TabIndex = 1;
            btnMuzicar.Text = "Muzičar";
            btnMuzicar.UseVisualStyleBackColor = true;
            btnMuzicar.Click += btnMuzicar_Click;
            // 
            // btnBend
            // 
            btnBend.Location = new Point(138, 60);
            btnBend.Name = "btnBend";
            btnBend.Size = new Size(90, 35);
            btnBend.TabIndex = 2;
            btnBend.Text = "Bend";
            btnBend.UseVisualStyleBackColor = true;
            btnBend.Click += btnBend_Click;
            // 
            // btnOdustani
            // 
            btnOdustani.Location = new Point(85, 110);
            btnOdustani.Name = "btnOdustani";
            btnOdustani.Size = new Size(90, 32);
            btnOdustani.TabIndex = 3;
            btnOdustani.Text = "Odustani";
            btnOdustani.UseVisualStyleBackColor = true;
            btnOdustani.Click += btnOdustani_Click;
            // 
            // IzborTipaIzvodjacaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 161);
            Controls.Add(btnOdustani);
            Controls.Add(btnBend);
            Controls.Add(btnMuzicar);
            Controls.Add(lblPitanje);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IzborTipaIzvodjacaForma";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Izbor tipa izvođača";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
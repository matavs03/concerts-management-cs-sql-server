namespace Forme
{
    partial class KartaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnKupi = new Button();
            numericUpDownRed = new NumericUpDown();
            numericUpDownSediste = new NumericUpDown();
            txtCena = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSediste).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 24);
            label1.Name = "label1";
            label1.Size = new Size(20, 25);
            label1.TabIndex = 0;
            label1.Text = "jj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 105);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Sedište";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 177);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 2;
            label3.Text = "Red";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 254);
            label4.Name = "label4";
            label4.Size = new Size(51, 25);
            label4.TabIndex = 3;
            label4.Text = "Cena";
            // 
            // btnKupi
            // 
            btnKupi.Location = new Point(151, 310);
            btnKupi.Name = "btnKupi";
            btnKupi.Size = new Size(112, 34);
            btnKupi.TabIndex = 4;
            btnKupi.Text = "Kupi kartu";
            btnKupi.UseVisualStyleBackColor = true;
            btnKupi.Click += btnKupi_Click;
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.Location = new Point(134, 175);
            numericUpDownRed.Maximum = new decimal(new int[] { 80, 0, 0, 0 });
            numericUpDownRed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(180, 31);
            numericUpDownRed.TabIndex = 5;
            numericUpDownRed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRed.ValueChanged += numericUpDownRed_ValueChanged;
            // 
            // numericUpDownSediste
            // 
            numericUpDownSediste.Location = new Point(134, 105);
            numericUpDownSediste.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownSediste.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSediste.Name = "numericUpDownSediste";
            numericUpDownSediste.Size = new Size(180, 31);
            numericUpDownSediste.TabIndex = 6;
            numericUpDownSediste.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtCena
            // 
            txtCena.Location = new Point(135, 248);
            txtCena.Name = "txtCena";
            txtCena.ReadOnly = true;
            txtCena.Size = new Size(179, 31);
            txtCena.TabIndex = 7;
            txtCena.TextAlign = HorizontalAlignment.Right;
            // 
            // KartaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 378);
            Controls.Add(txtCena);
            Controls.Add(numericUpDownSediste);
            Controls.Add(numericUpDownRed);
            Controls.Add(btnKupi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KartaForm";
            Text = "KartaForm";
            Load += KartaForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSediste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnKupi;
        private NumericUpDown numericUpDownRed;
        private NumericUpDown numericUpDownSediste;
        private TextBox txtCena;
    }
}
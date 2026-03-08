namespace Forme
{
    partial class GlavnaForma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            žanrToolStripMenuItem = new ToolStripMenuItem();
            gradToolStripMenuItem = new ToolStripMenuItem();
            lokacijaToolStripMenuItem = new ToolStripMenuItem();
            izvođačToolStripMenuItem = new ToolStripMenuItem();
            koncertToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { žanrToolStripMenuItem, gradToolStripMenuItem, lokacijaToolStripMenuItem, izvođačToolStripMenuItem, koncertToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // žanrToolStripMenuItem
            // 
            žanrToolStripMenuItem.Name = "žanrToolStripMenuItem";
            žanrToolStripMenuItem.Size = new Size(43, 20);
            žanrToolStripMenuItem.Text = "Žanr";
            žanrToolStripMenuItem.Click += žanrToolStripMenuItem_Click;
            // 
            // gradToolStripMenuItem
            // 
            gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            gradToolStripMenuItem.Size = new Size(44, 20);
            gradToolStripMenuItem.Text = "Grad";
            // 
            // lokacijaToolStripMenuItem
            // 
            lokacijaToolStripMenuItem.Name = "lokacijaToolStripMenuItem";
            lokacijaToolStripMenuItem.Size = new Size(62, 20);
            lokacijaToolStripMenuItem.Text = "Lokacija";
            // 
            // izvođačToolStripMenuItem
            // 
            izvođačToolStripMenuItem.Name = "izvođačToolStripMenuItem";
            izvođačToolStripMenuItem.Size = new Size(59, 20);
            izvođačToolStripMenuItem.Text = "Izvođač";
            izvođačToolStripMenuItem.Click += izvođačToolStripMenuItem_Click;
            // 
            // koncertToolStripMenuItem
            // 
            koncertToolStripMenuItem.Name = "koncertToolStripMenuItem";
            koncertToolStripMenuItem.Size = new Size(60, 20);
            koncertToolStripMenuItem.Text = "Koncert";
            // 
            // GlavnaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GlavnaForma";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem žanrToolStripMenuItem;
        private ToolStripMenuItem gradToolStripMenuItem;
        private ToolStripMenuItem lokacijaToolStripMenuItem;
        private ToolStripMenuItem izvođačToolStripMenuItem;
        private ToolStripMenuItem koncertToolStripMenuItem;
    }
}

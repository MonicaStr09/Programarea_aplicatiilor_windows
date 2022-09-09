
namespace Stirbescu_Monica_Proiect_Paw
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniulPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareGraficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAfisareInregistrari = new System.Windows.Forms.Button();
            this.buttonSalvareInregistrari = new System.Windows.Forms.Button();
            this.buttonCitireInregistrari = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniulPrincipalToolStripMenuItem,
            this.vizualizareGraficaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniulPrincipalToolStripMenuItem
            // 
            this.meniulPrincipalToolStripMenuItem.Name = "meniulPrincipalToolStripMenuItem";
            this.meniulPrincipalToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.meniulPrincipalToolStripMenuItem.Text = "Meniul principal";
            // 
            // vizualizareGraficaToolStripMenuItem
            // 
            this.vizualizareGraficaToolStripMenuItem.Name = "vizualizareGraficaToolStripMenuItem";
            this.vizualizareGraficaToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.vizualizareGraficaToolStripMenuItem.Text = "Vizualizare grafica";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 154);
            this.textBox1.TabIndex = 1;
            // 
            // buttonAfisareInregistrari
            // 
            this.buttonAfisareInregistrari.Location = new System.Drawing.Point(47, 219);
            this.buttonAfisareInregistrari.Name = "buttonAfisareInregistrari";
            this.buttonAfisareInregistrari.Size = new System.Drawing.Size(189, 53);
            this.buttonAfisareInregistrari.TabIndex = 2;
            this.buttonAfisareInregistrari.Text = "&Afisare inregistrari";
            this.buttonAfisareInregistrari.UseVisualStyleBackColor = false;
            this.buttonAfisareInregistrari.Click += new System.EventHandler(this.buttonAfisareInregistrari_Click);
            // 
            // buttonSalvareInregistrari
            // 
            this.buttonSalvareInregistrari.Location = new System.Drawing.Point(47, 306);
            this.buttonSalvareInregistrari.Name = "buttonSalvareInregistrari";
            this.buttonSalvareInregistrari.Size = new System.Drawing.Size(189, 53);
            this.buttonSalvareInregistrari.TabIndex = 3;
            this.buttonSalvareInregistrari.Text = "&Salvare inregistrari";
            this.buttonSalvareInregistrari.UseVisualStyleBackColor = false;
            this.buttonSalvareInregistrari.Click += new System.EventHandler(this.buttonSalvareInregistrari_Click);
            // 
            // buttonCitireInregistrari
            // 
            this.buttonCitireInregistrari.Location = new System.Drawing.Point(47, 389);
            this.buttonCitireInregistrari.Name = "buttonCitireInregistrari";
            this.buttonCitireInregistrari.Size = new System.Drawing.Size(189, 49);
            this.buttonCitireInregistrari.TabIndex = 4;
            this.buttonCitireInregistrari.Text = "&Citire inregistrari";
            this.buttonCitireInregistrari.UseVisualStyleBackColor = false;
            this.buttonCitireInregistrari.Click += new System.EventHandler(this.buttonCitireInregistrari_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(272, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 219);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puteti aduce inregistrari aici prin drag and drop pentru a le adauga";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCitireInregistrari);
            this.Controls.Add(this.buttonSalvareInregistrari);
            this.Controls.Add(this.buttonAfisareInregistrari);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniulPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareGraficaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAfisareInregistrari;
        private System.Windows.Forms.Button buttonSalvareInregistrari;
        private System.Windows.Forms.Button buttonCitireInregistrari;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
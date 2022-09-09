
namespace Stirbescu_Monica_Proiect_Paw
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSchimbaCuloarea = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSchimbaFontul = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSalvare = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSchimbaCuloarea,
            this.toolStripMenuItemSchimbaFontul,
            this.toolStripMenuItemSalvare});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 76);
            // 
            // toolStripMenuItemSchimbaCuloarea
            // 
            this.toolStripMenuItemSchimbaCuloarea.Name = "toolStripMenuItemSchimbaCuloarea";
            this.toolStripMenuItemSchimbaCuloarea.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItemSchimbaCuloarea.Text = "Schimba Culoarea";
            this.toolStripMenuItemSchimbaCuloarea.Click += new System.EventHandler(this.toolStripMenuItemSchimbaCuloarea_Click);
            // 
            // toolStripMenuItemSchimbaFontul
            // 
            this.toolStripMenuItemSchimbaFontul.Name = "toolStripMenuItemSchimbaFontul";
            this.toolStripMenuItemSchimbaFontul.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItemSchimbaFontul.Text = "Schimba Fontul";
            this.toolStripMenuItemSchimbaFontul.Click += new System.EventHandler(this.toolStripMenuItemSchimbaFontul_Click);
            // 
            // toolStripMenuItemSalvare
            // 
            this.toolStripMenuItemSalvare.Name = "toolStripMenuItemSalvare";
            this.toolStripMenuItemSalvare.Size = new System.Drawing.Size(198, 24);
            this.toolStripMenuItemSalvare.Text = "Salvare";
            this.toolStripMenuItemSalvare.Click += new System.EventHandler(this.toolStripMenuItemSalvare_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaDateToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.meniuPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.incarcaDateToolStripMenuItem.Text = "Incarca Date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // meniuPrincipalToolStripMenuItem
            // 
            this.meniuPrincipalToolStripMenuItem.Name = "meniuPrincipalToolStripMenuItem";
            this.meniuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.meniuPrincipalToolStripMenuItem.Text = "Meniu Principal";
            this.meniuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.meniuPrincipalToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 418);
            this.panel1.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meniuPrincipalToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSchimbaCuloarea;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSchimbaFontul;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSalvare;
    }
}
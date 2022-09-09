
namespace Stirbescu_Monica_Proiect_Paw
{
    partial class Form4
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNrCamere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCapacitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLuna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPreluaredate = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInserare = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNrCamere,
            this.columnHeaderCapacitate,
            this.columnHeaderPret,
            this.columnHeaderNume,
            this.columnHeaderPrenume,
            this.columnHeaderZi,
            this.columnHeaderLuna,
            this.columnHeaderAn});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(751, 232);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNrCamere
            // 
            this.columnHeaderNrCamere.Text = "NrCamera";
            this.columnHeaderNrCamere.Width = 90;
            // 
            // columnHeaderCapacitate
            // 
            this.columnHeaderCapacitate.Text = "Capacitate";
            this.columnHeaderCapacitate.Width = 86;
            // 
            // columnHeaderPret
            // 
            this.columnHeaderPret.Text = "Pret";
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 65;
            // 
            // columnHeaderPrenume
            // 
            this.columnHeaderPrenume.Text = "Prenume";
            this.columnHeaderPrenume.Width = 80;
            // 
            // columnHeaderZi
            // 
            this.columnHeaderZi.Text = "Zi";
            // 
            // columnHeaderLuna
            // 
            this.columnHeaderLuna.Text = "Luna";
            // 
            // columnHeaderAn
            // 
            this.columnHeaderAn.Text = "An";
            // 
            // buttonPreluaredate
            // 
            this.buttonPreluaredate.Location = new System.Drawing.Point(43, 266);
            this.buttonPreluaredate.Name = "buttonPreluaredate";
            this.buttonPreluaredate.Size = new System.Drawing.Size(129, 45);
            this.buttonPreluaredate.TabIndex = 1;
            this.buttonPreluaredate.Text = "&Preluare date";
            this.buttonPreluaredate.UseVisualStyleBackColor = true;
            this.buttonPreluaredate.Click += new System.EventHandler(this.buttonPreluaredate_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(43, 331);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(129, 46);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "&Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInserare
            // 
            this.buttonInserare.Location = new System.Drawing.Point(43, 396);
            this.buttonInserare.Name = "buttonInserare";
            this.buttonInserare.Size = new System.Drawing.Size(129, 41);
            this.buttonInserare.TabIndex = 3;
            this.buttonInserare.Text = "&Inserare";
            this.buttonInserare.UseVisualStyleBackColor = true;
            this.buttonInserare.Click += new System.EventHandler(this.buttonInserare_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSterge});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 28);
            // 
            // toolStripMenuItemSterge
            // 
            this.toolStripMenuItemSterge.Name = "toolStripMenuItemSterge";
            this.toolStripMenuItemSterge.Size = new System.Drawing.Size(121, 24);
            this.toolStripMenuItemSterge.Text = "Sterge";
            this.toolStripMenuItemSterge.Click += new System.EventHandler(this.toolStripMenuItemSterge_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInserare);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonPreluaredate);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNrCamere;
        private System.Windows.Forms.ColumnHeader columnHeaderCapacitate;
        private System.Windows.Forms.ColumnHeader columnHeaderPret;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderPrenume;
        private System.Windows.Forms.ColumnHeader columnHeaderZi;
        private System.Windows.Forms.ColumnHeader columnHeaderLuna;
        private System.Windows.Forms.ColumnHeader columnHeaderAn;
        private System.Windows.Forms.Button buttonPreluaredate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInserare;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSterge;
    }
}
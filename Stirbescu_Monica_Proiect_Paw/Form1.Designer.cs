
namespace Stirbescu_Monica_Proiect_Paw
{
    partial class Form1
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
            this.buttonRezervaCamera = new System.Windows.Forms.Button();
            this.buttonVizualizareBD = new System.Windows.Forms.Button();
            this.buttonVizualizareGrafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRezervaCamera
            // 
            this.buttonRezervaCamera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRezervaCamera.Location = new System.Drawing.Point(73, 65);
            this.buttonRezervaCamera.Name = "buttonRezervaCamera";
            this.buttonRezervaCamera.Size = new System.Drawing.Size(209, 85);
            this.buttonRezervaCamera.TabIndex = 0;
            this.buttonRezervaCamera.Text = "&Rezerva o camera";
            this.buttonRezervaCamera.UseVisualStyleBackColor = false;
            this.buttonRezervaCamera.Click += new System.EventHandler(this.buttonRezervaCamera_Click);
            // 
            // buttonVizualizareBD
            // 
            this.buttonVizualizareBD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVizualizareBD.Location = new System.Drawing.Point(73, 223);
            this.buttonVizualizareBD.Name = "buttonVizualizareBD";
            this.buttonVizualizareBD.Size = new System.Drawing.Size(209, 85);
            this.buttonVizualizareBD.TabIndex = 1;
            this.buttonVizualizareBD.Text = "&Vizualizare baza de date";
            this.buttonVizualizareBD.UseVisualStyleBackColor = false;
            this.buttonVizualizareBD.Click += new System.EventHandler(this.buttonVizualizareBD_Click);
            // 
            // buttonVizualizareGrafica
            // 
            this.buttonVizualizareGrafica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVizualizareGrafica.Location = new System.Drawing.Point(73, 379);
            this.buttonVizualizareGrafica.Name = "buttonVizualizareGrafica";
            this.buttonVizualizareGrafica.Size = new System.Drawing.Size(209, 85);
            this.buttonVizualizareGrafica.TabIndex = 2;
            this.buttonVizualizareGrafica.Text = "&Vizualizare grafica\r\n";
            this.buttonVizualizareGrafica.UseVisualStyleBackColor = false;
            this.buttonVizualizareGrafica.Click += new System.EventHandler(this.buttonVizualizareGrafica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stirbescu_Monica_Proiect_Paw.Properties.Resources.paw1;
            this.ClientSize = new System.Drawing.Size(1056, 586);
            this.Controls.Add(this.buttonVizualizareGrafica);
            this.Controls.Add(this.buttonVizualizareBD);
            this.Controls.Add(this.buttonRezervaCamera);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRezervaCamera;
        private System.Windows.Forms.Button buttonVizualizareBD;
        private System.Windows.Forms.Button buttonVizualizareGrafica;
    }
}


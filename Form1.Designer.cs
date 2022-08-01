
namespace Termomacchine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inserisci = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_apertura = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.Browser_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clicca il bottone per creare il file di  una commessa";
            // 
            // btn_inserisci
            // 
            this.btn_inserisci.Location = new System.Drawing.Point(106, 27);
            this.btn_inserisci.Name = "btn_inserisci";
            this.btn_inserisci.Size = new System.Drawing.Size(75, 23);
            this.btn_inserisci.TabIndex = 2;
            this.btn_inserisci.Text = "Crea";
            this.btn_inserisci.UseVisualStyleBackColor = true;
            this.btn_inserisci.Click += new System.EventHandler(this.btn_inserisci_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altrimenti clicca qui per aprire una commessa";
            // 
            // btn_apertura
            // 
            this.btn_apertura.Location = new System.Drawing.Point(106, 74);
            this.btn_apertura.Name = "btn_apertura";
            this.btn_apertura.Size = new System.Drawing.Size(75, 23);
            this.btn_apertura.TabIndex = 4;
            this.btn_apertura.Text = "Apri";
            this.btn_apertura.UseVisualStyleBackColor = true;
            this.btn_apertura.Click += new System.EventHandler(this.btn_apertura_Click);
            // 
            // open_file
            // 
            this.open_file.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 109);
            this.Controls.Add(this.btn_apertura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_inserisci);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creazione file macchina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inserisci;
        private System.Windows.Forms.SaveFileDialog save_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_apertura;
        private System.Windows.Forms.OpenFileDialog open_file;
        private System.Windows.Forms.FolderBrowserDialog Browser_dialog;
    }
}


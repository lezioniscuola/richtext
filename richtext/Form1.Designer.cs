namespace richtext
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grassetto = new System.Windows.Forms.CheckBox();
            this.sottolineato = new System.Windows.Forms.CheckBox();
            this.corsivo = new System.Windows.Forms.CheckBox();
            this.scrivi = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.scelta_colore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(184, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(443, 193);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 23);
            this.textBox1.TabIndex = 2;
            // 
            // grassetto
            // 
            this.grassetto.AutoSize = true;
            this.grassetto.Location = new System.Drawing.Point(184, 275);
            this.grassetto.Name = "grassetto";
            this.grassetto.Size = new System.Drawing.Size(75, 19);
            this.grassetto.TabIndex = 5;
            this.grassetto.Text = "Grassetto";
            this.grassetto.UseVisualStyleBackColor = true;
            // 
            // sottolineato
            // 
            this.sottolineato.AutoSize = true;
            this.sottolineato.Location = new System.Drawing.Point(302, 275);
            this.sottolineato.Name = "sottolineato";
            this.sottolineato.Size = new System.Drawing.Size(90, 19);
            this.sottolineato.TabIndex = 6;
            this.sottolineato.Text = "Sottolineato";
            this.sottolineato.UseVisualStyleBackColor = true;
            // 
            // corsivo
            // 
            this.corsivo.AutoSize = true;
            this.corsivo.Location = new System.Drawing.Point(433, 274);
            this.corsivo.Name = "corsivo";
            this.corsivo.Size = new System.Drawing.Size(66, 19);
            this.corsivo.TabIndex = 7;
            this.corsivo.Text = "Corsivo";
            this.corsivo.UseVisualStyleBackColor = true;
            this.corsivo.CheckedChanged += new System.EventHandler(this.corsivo_CheckedChanged);
            // 
            // scrivi
            // 
            this.scrivi.Location = new System.Drawing.Point(184, 349);
            this.scrivi.Name = "scrivi";
            this.scrivi.Size = new System.Drawing.Size(443, 23);
            this.scrivi.TabIndex = 8;
            this.scrivi.Text = "Scrivi";
            this.scrivi.UseVisualStyleBackColor = true;
            this.scrivi.Click += new System.EventHandler(this.scrivi_Click);
            // 
            // scelta_colore
            // 
            this.scelta_colore.Location = new System.Drawing.Point(539, 272);
            this.scelta_colore.Name = "scelta_colore";
            this.scelta_colore.Size = new System.Drawing.Size(88, 23);
            this.scelta_colore.TabIndex = 9;
            this.scelta_colore.Text = "scelta_colore";
            this.scelta_colore.UseVisualStyleBackColor = true;
            this.scelta_colore.Click += new System.EventHandler(this.scelta_colore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 407);
            this.Controls.Add(this.scelta_colore);
            this.Controls.Add(this.scrivi);
            this.Controls.Add(this.corsivo);
            this.Controls.Add(this.sottolineato);
            this.Controls.Add(this.grassetto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private CheckBox grassetto;
        private CheckBox sottolineato;
        private CheckBox corsivo;
        private Button scrivi;
        private ColorDialog colorDialog1;
        private Button scelta_colore;
    }
}
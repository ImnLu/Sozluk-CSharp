namespace Sözlük
{
    partial class Sozluk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sozluk));
            this.label1 = new System.Windows.Forms.Label();
            this.textGirilenKelime = new System.Windows.Forms.TextBox();
            this.buttonKelimeBul = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime giriniz:";
            // 
            // textGirilenKelime
            // 
            this.textGirilenKelime.Location = new System.Drawing.Point(162, 22);
            this.textGirilenKelime.Name = "textGirilenKelime";
            this.textGirilenKelime.Size = new System.Drawing.Size(241, 31);
            this.textGirilenKelime.TabIndex = 1;
            this.textGirilenKelime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textGirilenKelime_KeyDown);
            // 
            // buttonKelimeBul
            // 
            this.buttonKelimeBul.Location = new System.Drawing.Point(437, 22);
            this.buttonKelimeBul.Name = "buttonKelimeBul";
            this.buttonKelimeBul.Size = new System.Drawing.Size(111, 31);
            this.buttonKelimeBul.TabIndex = 3;
            this.buttonKelimeBul.Text = "Bul";
            this.buttonKelimeBul.UseVisualStyleBackColor = true;
            this.buttonKelimeBul.Click += new System.EventHandler(this.buttonKelimeBul_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(516, 147);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Sozluk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 234);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonKelimeBul);
            this.Controls.Add(this.textGirilenKelime);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Sozluk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözlük";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textGirilenKelime;
        private System.Windows.Forms.Button buttonKelimeBul;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}



namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.FileNameText = new System.Windows.Forms.TextBox();
            this.Pobieszbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.Deszyfrowanie = new System.Windows.Forms.Button();
            this.Szyfrowanie = new System.Windows.Forms.Button();
            this.richText = new System.Windows.Forms.TextBox();
            this.Zapiszjako = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key";
            // 
            // FileNameText
            // 
            this.FileNameText.Location = new System.Drawing.Point(66, 12);
            this.FileNameText.Name = "FileNameText";
            this.FileNameText.Size = new System.Drawing.Size(410, 23);
            this.FileNameText.TabIndex = 1;
            // 
            // Pobieszbutton
            // 
            this.Pobieszbutton.Location = new System.Drawing.Point(482, 12);
            this.Pobieszbutton.Name = "Pobieszbutton";
            this.Pobieszbutton.Size = new System.Drawing.Size(137, 23);
            this.Pobieszbutton.TabIndex = 2;
            this.Pobieszbutton.Text = "Pobiesz";
            this.Pobieszbutton.UseVisualStyleBackColor = true;
            this.Pobieszbutton.Click += new System.EventHandler(this.Pobieszbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "File";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // KeyText
            // 
            this.KeyText.Location = new System.Drawing.Point(66, 52);
            this.KeyText.Name = "KeyText";
            this.KeyText.Size = new System.Drawing.Size(329, 23);
            this.KeyText.TabIndex = 4;
            // 
            // Deszyfrowanie
            // 
            this.Deszyfrowanie.Location = new System.Drawing.Point(501, 52);
            this.Deszyfrowanie.Name = "Deszyfrowanie";
            this.Deszyfrowanie.Size = new System.Drawing.Size(118, 23);
            this.Deszyfrowanie.TabIndex = 5;
            this.Deszyfrowanie.Text = "Deszyfrowanie";
            this.Deszyfrowanie.UseVisualStyleBackColor = true;
            this.Deszyfrowanie.Click += new System.EventHandler(this.Deszyfrowanie_Click);
            // 
            // Szyfrowanie
            // 
            this.Szyfrowanie.Location = new System.Drawing.Point(401, 51);
            this.Szyfrowanie.Name = "Szyfrowanie";
            this.Szyfrowanie.Size = new System.Drawing.Size(94, 23);
            this.Szyfrowanie.TabIndex = 6;
            this.Szyfrowanie.Text = "Szyfrowanie";
            this.Szyfrowanie.UseVisualStyleBackColor = true;
            this.Szyfrowanie.Click += new System.EventHandler(this.Szyfrowanie_Click);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(66, 95);
            this.richText.Multiline = true;
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(429, 219);
            this.richText.TabIndex = 7;
            // 
            // Zapiszjako
            // 
            this.Zapiszjako.Location = new System.Drawing.Point(501, 151);
            this.Zapiszjako.Name = "Zapiszjako";
            this.Zapiszjako.Size = new System.Drawing.Size(118, 123);
            this.Zapiszjako.TabIndex = 8;
            this.Zapiszjako.Text = "Zapisz jako";
            this.Zapiszjako.UseVisualStyleBackColor = true;
            this.Zapiszjako.Click += new System.EventHandler(this.Zapiszjako_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 347);
            this.Controls.Add(this.Zapiszjako);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.Szyfrowanie);
            this.Controls.Add(this.Deszyfrowanie);
            this.Controls.Add(this.KeyText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pobieszbutton);
            this.Controls.Add(this.FileNameText);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(9, 58);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileNameText;
        private System.Windows.Forms.Button Pobieszbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.Button Deszyfrowanie;
        private System.Windows.Forms.Button Szyfrowanie;
        private System.Windows.Forms.TextBox richText;
        private System.Windows.Forms.Button Zapiszjako;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}



namespace practic
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncryptCaesar = new System.Windows.Forms.Button();
            this.btnDecryptCaesar = new System.Windows.Forms.Button();
            this.numShift = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncryptVigenere = new System.Windows.Forms.Button();
            this.btnDecryptVigenere = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numShift)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(360, 100);
            this.txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 118);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(360, 100);
            this.txtOutput.TabIndex = 1;
            // 
            // btnEncryptCaesar
            // 
            this.btnEncryptCaesar.Location = new System.Drawing.Point(378, 12);
            this.btnEncryptCaesar.Name = "btnEncryptCaesar";
            this.btnEncryptCaesar.Size = new System.Drawing.Size(120, 30);
            this.btnEncryptCaesar.TabIndex = 2;
            this.btnEncryptCaesar.Text = "Шифр Цезаря (+)";
            this.btnEncryptCaesar.UseVisualStyleBackColor = true;
            this.btnEncryptCaesar.Click += new System.EventHandler(this.btnEncryptCaesar_Click);
            // 
            // btnDecryptCaesar
            // 
            this.btnDecryptCaesar.Location = new System.Drawing.Point(378, 48);
            this.btnDecryptCaesar.Name = "btnDecryptCaesar";
            this.btnDecryptCaesar.Size = new System.Drawing.Size(120, 30);
            this.btnDecryptCaesar.TabIndex = 3;
            this.btnDecryptCaesar.Text = "Шифр Цезаря (-)";
            this.btnDecryptCaesar.UseVisualStyleBackColor = true;
            this.btnDecryptCaesar.Click += new System.EventHandler(this.btnDecryptCaesar_Click);
            // 
            // numShift
            // 
            this.numShift.Location = new System.Drawing.Point(378, 84);
            this.numShift.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numShift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numShift.Name = "numShift";
            this.numShift.Size = new System.Drawing.Size(120, 20);
            this.numShift.TabIndex = 4;
            this.numShift.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Сдвиг (n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ключ";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(51, 221);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(321, 20);
            this.txtKey.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шифр Виженера";
            // 
            // btnEncryptVigenere
            // 
            this.btnEncryptVigenere.Location = new System.Drawing.Point(378, 240);
            this.btnEncryptVigenere.Name = "btnEncryptVigenere";
            this.btnEncryptVigenere.Size = new System.Drawing.Size(120, 30);
            this.btnEncryptVigenere.TabIndex = 9;
            this.btnEncryptVigenere.Text = "Зашифровать";
            this.btnEncryptVigenere.UseVisualStyleBackColor = true;
            this.btnEncryptVigenere.Click += new System.EventHandler(this.btnEncryptVigenere_Click);
            // 
            // btnDecryptVigenere
            // 
            this.btnDecryptVigenere.Location = new System.Drawing.Point(378, 276);
            this.btnDecryptVigenere.Name = "btnDecryptVigenere";
            this.btnDecryptVigenere.Size = new System.Drawing.Size(120, 30);
            this.btnDecryptVigenere.TabIndex = 10;
            this.btnDecryptVigenere.Text = "Расшифровать";
            this.btnDecryptVigenere.UseVisualStyleBackColor = true;
            this.btnDecryptVigenere.Click += new System.EventHandler(this.btnDecryptVigenere_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(378, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 318);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecryptVigenere);
            this.Controls.Add(this.btnEncryptVigenere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numShift);
            this.Controls.Add(this.btnDecryptCaesar);
            this.Controls.Add(this.btnEncryptCaesar);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Name = "MainForm";
            this.Text = "Шифры Цезаря и Виженера";
            ((System.ComponentModel.ISupportInitialize)(this.numShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncryptCaesar;
        private System.Windows.Forms.Button btnDecryptCaesar;
        private System.Windows.Forms.NumericUpDown numShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncryptVigenere;
        private System.Windows.Forms.Button btnDecryptVigenere;
        private System.Windows.Forms.Button btnClear;
    }
}
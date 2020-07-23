namespace SimpleSteganography
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MSELabel = new System.Windows.Forms.Label();
            this.PSNRLabel = new System.Windows.Forms.Label();
            this.mesajLabel = new System.Windows.Forms.Label();
            this.buttonRGB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(119, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(235, 293);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilePath.TabIndex = 2;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(661, 87);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 3;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(661, 180);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 4;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(521, 129);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(100, 20);
            this.textBoxMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "MSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "PSNR";
            // 
            // MSELabel
            // 
            this.MSELabel.AutoSize = true;
            this.MSELabel.Location = new System.Drawing.Point(235, 348);
            this.MSELabel.Name = "MSELabel";
            this.MSELabel.Size = new System.Drawing.Size(0, 13);
            this.MSELabel.TabIndex = 9;
            // 
            // PSNRLabel
            // 
            this.PSNRLabel.AutoSize = true;
            this.PSNRLabel.Location = new System.Drawing.Point(235, 388);
            this.PSNRLabel.Name = "PSNRLabel";
            this.PSNRLabel.Size = new System.Drawing.Size(0, 13);
            this.PSNRLabel.TabIndex = 10;
            // 
            // mesajLabel
            // 
            this.mesajLabel.AutoSize = true;
            this.mesajLabel.Location = new System.Drawing.Point(12, 428);
            this.mesajLabel.Name = "mesajLabel";
            this.mesajLabel.Size = new System.Drawing.Size(0, 13);
            this.mesajLabel.TabIndex = 11;
            // 
            // buttonRGB
            // 
            this.buttonRGB.Location = new System.Drawing.Point(521, 293);
            this.buttonRGB.Name = "buttonRGB";
            this.buttonRGB.Size = new System.Drawing.Size(129, 42);
            this.buttonRGB.TabIndex = 12;
            this.buttonRGB.Text = "RGB Değerleri";
            this.buttonRGB.UseVisualStyleBackColor = true;
            this.buttonRGB.Click += new System.EventHandler(this.buttonRGB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRGB);
            this.Controls.Add(this.mesajLabel);
            this.Controls.Add(this.PSNRLabel);
            this.Controls.Add(this.MSELabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MSELabel;
        private System.Windows.Forms.Label PSNRLabel;
        private System.Windows.Forms.Label mesajLabel;
        private System.Windows.Forms.Button buttonRGB;
    }
}
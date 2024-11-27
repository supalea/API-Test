namespace Füchse
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
            pictureBox1 = new PictureBox();
            btnFuchs = new Button();
            btnEnte = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 545);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnFuchs
            // 
            btnFuchs.AutoSize = true;
            btnFuchs.Location = new Point(726, 128);
            btnFuchs.Margin = new Padding(3, 4, 3, 4);
            btnFuchs.Name = "btnFuchs";
            btnFuchs.Size = new Size(86, 33);
            btnFuchs.TabIndex = 1;
            btnFuchs.Text = "Fox";
            btnFuchs.UseVisualStyleBackColor = true;
            btnFuchs.Click += btnFuchs_Click;
            // 
            // btnEnte
            // 
            btnEnte.AutoSize = true;
            btnEnte.Location = new Point(726, 228);
            btnEnte.Margin = new Padding(3, 4, 3, 4);
            btnEnte.Name = "btnEnte";
            btnEnte.Size = new Size(86, 33);
            btnEnte.TabIndex = 2;
            btnEnte.Text = "Ente";
            btnEnte.UseVisualStyleBackColor = true;
            btnEnte.Click += btnEnte_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEnte);
            Controls.Add(btnFuchs);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "API Test";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnFuchs;
        private Button btnEnte;
    }
}

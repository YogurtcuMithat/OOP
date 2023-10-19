namespace OOPGiris
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
            button1 = new Button();
            button2 = new Button();
            txtOyuncu = new TextBox();
            txtIrk = new TextBox();
            txtBrans = new TextBox();
            txtSilah = new TextBox();
            button3 = new Button();
            label1 = new Label();
            btnSaldir = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(13, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(13, 37);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Kitap Yaz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtOyuncu
            // 
            txtOyuncu.Location = new Point(19, 96);
            txtOyuncu.Name = "txtOyuncu";
            txtOyuncu.Size = new Size(100, 23);
            txtOyuncu.TabIndex = 2;
            // 
            // txtIrk
            // 
            txtIrk.Location = new Point(19, 125);
            txtIrk.Name = "txtIrk";
            txtIrk.Size = new Size(100, 23);
            txtIrk.TabIndex = 3;
            // 
            // txtBrans
            // 
            txtBrans.Location = new Point(19, 154);
            txtBrans.Name = "txtBrans";
            txtBrans.Size = new Size(100, 23);
            txtBrans.TabIndex = 4;
            // 
            // txtSilah
            // 
            txtSilah.Location = new Point(19, 183);
            txtSilah.Name = "txtSilah";
            txtSilah.Size = new Size(100, 23);
            txtSilah.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(19, 212);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 6;
            button3.Text = "Seç";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Location = new Point(233, 145);
            label1.Name = "label1";
            label1.Size = new Size(300, 15);
            label1.TabIndex = 7;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // btnSaldir
            // 
            btnSaldir.Location = new Point(125, 212);
            btnSaldir.Name = "btnSaldir";
            btnSaldir.Size = new Size(100, 23);
            btnSaldir.TabIndex = 8;
            btnSaldir.Text = "Saldır";
            btnSaldir.UseVisualStyleBackColor = true;
            btnSaldir.Click += btnSaldir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaldir);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(txtSilah);
            Controls.Add(txtBrans);
            Controls.Add(txtIrk);
            Controls.Add(txtOyuncu);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtOyuncu;
        private TextBox txtIrk;
        private TextBox txtBrans;
        private TextBox txtSilah;
        private Button button3;
        private Label label1;
        private Button btnSaldir;
    }
}
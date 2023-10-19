namespace CONSTRUCTOR
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            trackBarR = new TrackBar();
            trackBarG = new TrackBar();
            trackBarB = new TrackBar();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(15, 70);
            button1.Name = "button1";
            button1.Size = new Size(289, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBarR
            // 
            trackBarR.Location = new Point(12, 123);
            trackBarR.Maximum = 255;
            trackBarR.Name = "trackBarR";
            trackBarR.Size = new Size(292, 45);
            trackBarR.TabIndex = 3;
            // 
            // trackBarG
            // 
            trackBarG.Location = new Point(15, 174);
            trackBarG.Maximum = 255;
            trackBarG.Name = "trackBarG";
            trackBarG.Size = new Size(292, 45);
            trackBarG.TabIndex = 4;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(15, 225);
            trackBarB.Maximum = 255;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(292, 45);
            trackBarB.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(313, 123);
            button2.Name = "button2";
            button2.Size = new Size(178, 147);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(trackBarB);
            Controls.Add(trackBarG);
            Controls.Add(trackBarR);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarR).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarG).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TrackBar trackBarR;
        private TrackBar trackBarG;
        private TrackBar trackBarB;
        private Button button2;
    }
}
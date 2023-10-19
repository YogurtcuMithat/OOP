namespace Encapsulation
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
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            btnSignIn = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(140, 28);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(321, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(140, 57);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(321, 23);
            txtUserPassword.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(140, 102);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(321, 23);
            btnSignIn.TabIndex = 2;
            btnSignIn.Text = "btnSignIn";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignIn);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private Button btnSignIn;
    }
}
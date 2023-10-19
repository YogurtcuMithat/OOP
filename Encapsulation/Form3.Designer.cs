namespace Encapsulation
{
    partial class Form3
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
            btnSignIn = new Button();
            txtUserPassword = new TextBox();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(190, 108);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(321, 23);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "btnSignIn";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(190, 63);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(321, 23);
            txtUserPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(190, 34);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(321, 23);
            txtUserName.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignIn);
            Controls.Add(txtUserPassword);
            Controls.Add(txtUserName);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private TextBox txtUserPassword;
        private TextBox txtUserName;
    }
}
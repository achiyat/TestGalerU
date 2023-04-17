namespace TestGalerU
{
    partial class Form1
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
            this.button_Login = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.button_Continue = new System.Windows.Forms.Button();
            this.buttonGoogle = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(51, 33);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(119, 61);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(51, 174);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(136, 22);
            this.textEmail.TabIndex = 1;
            this.textEmail.Text = "achiya@gmail.com";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(48, 146);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(40, 16);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "email";
            // 
            // button_Continue
            // 
            this.button_Continue.Location = new System.Drawing.Point(51, 215);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(78, 39);
            this.button_Continue.TabIndex = 3;
            this.button_Continue.Text = "Continue";
            this.button_Continue.UseVisualStyleBackColor = true;
            this.button_Continue.Click += new System.EventHandler(this.button_Continue_Click);
            // 
            // buttonGoogle
            // 
            this.buttonGoogle.Location = new System.Drawing.Point(153, 215);
            this.buttonGoogle.Name = "buttonGoogle";
            this.buttonGoogle.Size = new System.Drawing.Size(149, 39);
            this.buttonGoogle.TabIndex = 4;
            this.buttonGoogle.Text = "Continue with Google";
            this.buttonGoogle.UseVisualStyleBackColor = true;
            this.buttonGoogle.Click += new System.EventHandler(this.buttonGoogle_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(241, 146);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 16);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(244, 174);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(136, 22);
            this.textPassword.TabIndex = 1;
            this.textPassword.Text = "Abcd!2#$";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(326, 215);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(92, 39);
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonGoogle);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.button_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.Button buttonGoogle;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonSignUp;
    }
}


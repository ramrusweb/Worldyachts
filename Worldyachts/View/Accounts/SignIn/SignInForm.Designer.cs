namespace Worldyachts.View.Accounts.SignIn
{
    partial class SignInForm
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
            this.signInLoginTextBox = new System.Windows.Forms.TextBox();
            this.signInLoginLabel = new System.Windows.Forms.Label();
            this.userLoginPictureBox = new System.Windows.Forms.PictureBox();
            this.userPasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.signInPasswordLabel = new System.Windows.Forms.Label();
            this.signInPasswordTextBox = new System.Windows.Forms.TextBox();
            this.signInEnterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPasswordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signInLoginTextBox
            // 
            this.signInLoginTextBox.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.signInLoginTextBox.Location = new System.Drawing.Point(186, 28);
            this.signInLoginTextBox.Multiline = true;
            this.signInLoginTextBox.Name = "signInLoginTextBox";
            this.signInLoginTextBox.Size = new System.Drawing.Size(250, 30);
            this.signInLoginTextBox.TabIndex = 0;
            // 
            // signInLoginLabel
            // 
            this.signInLoginLabel.AutoSize = true;
            this.signInLoginLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.signInLoginLabel.Location = new System.Drawing.Point(82, 33);
            this.signInLoginLabel.Name = "signInLoginLabel";
            this.signInLoginLabel.Size = new System.Drawing.Size(81, 20);
            this.signInLoginLabel.TabIndex = 1;
            this.signInLoginLabel.Text = "Логин:";
            // 
            // userLoginPictureBox
            // 
            this.userLoginPictureBox.Image = global::Worldyachts.Properties.Resources.userLoginImage;
            this.userLoginPictureBox.Location = new System.Drawing.Point(12, 12);
            this.userLoginPictureBox.Name = "userLoginPictureBox";
            this.userLoginPictureBox.Size = new System.Drawing.Size(64, 64);
            this.userLoginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userLoginPictureBox.TabIndex = 2;
            this.userLoginPictureBox.TabStop = false;
            // 
            // userPasswordPictureBox
            // 
            this.userPasswordPictureBox.Image = global::Worldyachts.Properties.Resources.userPasswordImage;
            this.userPasswordPictureBox.Location = new System.Drawing.Point(12, 97);
            this.userPasswordPictureBox.Name = "userPasswordPictureBox";
            this.userPasswordPictureBox.Size = new System.Drawing.Size(64, 64);
            this.userPasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPasswordPictureBox.TabIndex = 5;
            this.userPasswordPictureBox.TabStop = false;
            // 
            // signInPasswordLabel
            // 
            this.signInPasswordLabel.AutoSize = true;
            this.signInPasswordLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.signInPasswordLabel.Location = new System.Drawing.Point(82, 118);
            this.signInPasswordLabel.Name = "signInPasswordLabel";
            this.signInPasswordLabel.Size = new System.Drawing.Size(93, 20);
            this.signInPasswordLabel.TabIndex = 4;
            this.signInPasswordLabel.Text = "Пароль:";
            // 
            // signInPasswordTextBox
            // 
            this.signInPasswordTextBox.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.signInPasswordTextBox.Location = new System.Drawing.Point(186, 113);
            this.signInPasswordTextBox.Multiline = true;
            this.signInPasswordTextBox.Name = "signInPasswordTextBox";
            this.signInPasswordTextBox.PasswordChar = '•';
            this.signInPasswordTextBox.Size = new System.Drawing.Size(250, 30);
            this.signInPasswordTextBox.TabIndex = 3;
            // 
            // signInEnterButton
            // 
            this.signInEnterButton.BackColor = System.Drawing.SystemColors.Control;
            this.signInEnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInEnterButton.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.signInEnterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.signInEnterButton.Location = new System.Drawing.Point(162, 171);
            this.signInEnterButton.Name = "signInEnterButton";
            this.signInEnterButton.Size = new System.Drawing.Size(129, 40);
            this.signInEnterButton.TabIndex = 6;
            this.signInEnterButton.Text = "Войти";
            this.signInEnterButton.UseVisualStyleBackColor = false;
            // 
            // SignInForm
            // 
            this.AcceptButton = this.signInEnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(452, 223);
            this.Controls.Add(this.signInEnterButton);
            this.Controls.Add(this.userPasswordPictureBox);
            this.Controls.Add(this.signInPasswordLabel);
            this.Controls.Add(this.signInPasswordTextBox);
            this.Controls.Add(this.userLoginPictureBox);
            this.Controls.Add(this.signInLoginLabel);
            this.Controls.Add(this.signInLoginTextBox);
            this.MaximumSize = new System.Drawing.Size(470, 270);
            this.MinimumSize = new System.Drawing.Size(470, 270);
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.userLoginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPasswordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox signInLoginTextBox;
        private System.Windows.Forms.Label signInLoginLabel;
        private System.Windows.Forms.PictureBox userLoginPictureBox;
        private System.Windows.Forms.PictureBox userPasswordPictureBox;
        private System.Windows.Forms.Label signInPasswordLabel;
        private System.Windows.Forms.TextBox signInPasswordTextBox;
        private System.Windows.Forms.Button signInEnterButton;
    }
}
namespace Admin
{
    partial class NewUser
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
            this.RegUsername = new System.Windows.Forms.Label();
            this.RegPassword = new System.Windows.Forms.Label();
            this.RegRole = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.UserRegTextBox = new System.Windows.Forms.TextBox();
            this.UserRegPasswordBox = new System.Windows.Forms.TextBox();
            this.RegUserBox = new System.Windows.Forms.ComboBox();
            this.RegUserID = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegUserIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegUsername
            // 
            this.RegUsername.AutoSize = true;
            this.RegUsername.Location = new System.Drawing.Point(107, 84);
            this.RegUsername.Name = "RegUsername";
            this.RegUsername.Size = new System.Drawing.Size(83, 20);
            this.RegUsername.TabIndex = 0;
            this.RegUsername.Text = "Username";
            // 
            // RegPassword
            // 
            this.RegPassword.AutoSize = true;
            this.RegPassword.Location = new System.Drawing.Point(112, 147);
            this.RegPassword.Name = "RegPassword";
            this.RegPassword.Size = new System.Drawing.Size(78, 20);
            this.RegPassword.TabIndex = 1;
            this.RegPassword.Text = "Password";
            // 
            // RegRole
            // 
            this.RegRole.AutoSize = true;
            this.RegRole.Location = new System.Drawing.Point(148, 255);
            this.RegRole.Name = "RegRole";
            this.RegRole.Size = new System.Drawing.Size(42, 20);
            this.RegRole.TabIndex = 2;
            this.RegRole.Text = "Role";
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(257, 381);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(86, 35);
            this.RegButton.TabIndex = 3;
            this.RegButton.Text = "Register";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(473, 381);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(86, 35);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UserRegTextBox
            // 
            this.UserRegTextBox.Location = new System.Drawing.Point(225, 84);
            this.UserRegTextBox.Name = "UserRegTextBox";
            this.UserRegTextBox.Size = new System.Drawing.Size(100, 26);
            this.UserRegTextBox.TabIndex = 5;
            // 
            // UserRegPasswordBox
            // 
            this.UserRegPasswordBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UserRegPasswordBox.Location = new System.Drawing.Point(225, 147);
            this.UserRegPasswordBox.Name = "UserRegPasswordBox";
            this.UserRegPasswordBox.Size = new System.Drawing.Size(100, 26);
            this.UserRegPasswordBox.TabIndex = 6;
            this.UserRegPasswordBox.TextChanged += new System.EventHandler(this.UserRegPasswordBox_TextChanged);
            // 
            // RegUserBox
            // 
            this.RegUserBox.FormattingEnabled = true;
            this.RegUserBox.Items.AddRange(new object[] {
            "Student",
            "Worker",
            "Admin"});
            this.RegUserBox.Location = new System.Drawing.Point(225, 252);
            this.RegUserBox.Name = "RegUserBox";
            this.RegUserBox.Size = new System.Drawing.Size(100, 28);
            this.RegUserBox.TabIndex = 8;
            // 
            // RegUserID
            // 
            this.RegUserID.AutoSize = true;
            this.RegUserID.Location = new System.Drawing.Point(130, 205);
            this.RegUserID.Name = "RegUserID";
            this.RegUserID.Size = new System.Drawing.Size(60, 20);
            this.RegUserID.TabIndex = 9;
            this.RegUserID.Text = "UserID";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(225, 320);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(100, 26);
            this.PhoneBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phone Number";
            // 
            // RegUserIDLabel
            // 
            this.RegUserIDLabel.AutoSize = true;
            this.RegUserIDLabel.Location = new System.Drawing.Point(221, 205);
            this.RegUserIDLabel.Name = "RegUserIDLabel";
            this.RegUserIDLabel.Size = new System.Drawing.Size(14, 20);
            this.RegUserIDLabel.TabIndex = 13;
            this.RegUserIDLabel.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "New User Registration";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegUserIDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.RegUserID);
            this.Controls.Add(this.RegUserBox);
            this.Controls.Add(this.UserRegPasswordBox);
            this.Controls.Add(this.UserRegTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.RegRole);
            this.Controls.Add(this.RegPassword);
            this.Controls.Add(this.RegUsername);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegUsername;
        private System.Windows.Forms.Label RegPassword;
        private System.Windows.Forms.Label RegRole;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox UserRegTextBox;
        private System.Windows.Forms.ComboBox RegUserBox;
        private System.Windows.Forms.Label RegUserID;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RegUserIDLabel;
        private System.Windows.Forms.TextBox UserRegPasswordBox;
        private System.Windows.Forms.Label label2;
    }
}
namespace Admin
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegNewRadio = new System.Windows.Forms.RadioButton();
            this.UpdateRadio = new System.Windows.Forms.RadioButton();
            this.RequestRadio = new System.Windows.Forms.RadioButton();
            this.TotalIncomeRadio = new System.Windows.Forms.RadioButton();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Menu";
            // 
            // RegNewRadio
            // 
            this.RegNewRadio.AutoSize = true;
            this.RegNewRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegNewRadio.Location = new System.Drawing.Point(194, 103);
            this.RegNewRadio.Name = "RegNewRadio";
            this.RegNewRadio.Size = new System.Drawing.Size(175, 24);
            this.RegNewRadio.TabIndex = 1;
            this.RegNewRadio.TabStop = true;
            this.RegNewRadio.Text = "Register New Users";
            this.RegNewRadio.UseVisualStyleBackColor = true;
            this.RegNewRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // UpdateRadio
            // 
            this.UpdateRadio.AutoSize = true;
            this.UpdateRadio.Location = new System.Drawing.Point(194, 150);
            this.UpdateRadio.Name = "UpdateRadio";
            this.UpdateRadio.Size = new System.Drawing.Size(243, 24);
            this.UpdateRadio.TabIndex = 2;
            this.UpdateRadio.TabStop = true;
            this.UpdateRadio.Text = "Update/Delete Existing Users";
            this.UpdateRadio.UseVisualStyleBackColor = true;
            this.UpdateRadio.CheckedChanged += new System.EventHandler(this.UpdateRadio_CheckedChanged);
            // 
            // RequestRadio
            // 
            this.RequestRadio.AutoSize = true;
            this.RequestRadio.Location = new System.Drawing.Point(194, 203);
            this.RequestRadio.Name = "RequestRadio";
            this.RequestRadio.Size = new System.Drawing.Size(258, 24);
            this.RequestRadio.TabIndex = 3;
            this.RequestRadio.TabStop = true;
            this.RequestRadio.Text = "View/Generate Request Report";
            this.RequestRadio.UseVisualStyleBackColor = true;
            this.RequestRadio.CheckedChanged += new System.EventHandler(this.RequestRadio_CheckedChanged);
            // 
            // TotalIncomeRadio
            // 
            this.TotalIncomeRadio.AutoSize = true;
            this.TotalIncomeRadio.Location = new System.Drawing.Point(194, 254);
            this.TotalIncomeRadio.Name = "TotalIncomeRadio";
            this.TotalIncomeRadio.Size = new System.Drawing.Size(236, 24);
            this.TotalIncomeRadio.TabIndex = 4;
            this.TotalIncomeRadio.TabStop = true;
            this.TotalIncomeRadio.Text = "View/Generate Total Income";
            this.TotalIncomeRadio.UseVisualStyleBackColor = true;
            this.TotalIncomeRadio.CheckedChanged += new System.EventHandler(this.TotalIncomeRadio_CheckedChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(194, 346);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(88, 44);
            this.ConfirmButton.TabIndex = 5;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(349, 346);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 44);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Back";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.TotalIncomeRadio);
            this.Controls.Add(this.RequestRadio);
            this.Controls.Add(this.UpdateRadio);
            this.Controls.Add(this.RegNewRadio);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RegNewRadio;
        private System.Windows.Forms.RadioButton UpdateRadio;
        private System.Windows.Forms.RadioButton RequestRadio;
        private System.Windows.Forms.RadioButton TotalIncomeRadio;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ExitButton;
    }
}
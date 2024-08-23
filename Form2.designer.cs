namespace IOOP1
{
    partial class WorkRequest
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
            this.lblReceiptID = new System.Windows.Forms.Label();
            this.lblReceiptIDData = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.checkBoxUrgent = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtServicetype = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblReceiptID
            // 
            this.lblReceiptID.AutoSize = true;
            this.lblReceiptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptID.Location = new System.Drawing.Point(125, 59);
            this.lblReceiptID.Name = "lblReceiptID";
            this.lblReceiptID.Size = new System.Drawing.Size(100, 20);
            this.lblReceiptID.TabIndex = 0;
            this.lblReceiptID.Text = "ReceiptID :";
            // 
            // lblReceiptIDData
            // 
            this.lblReceiptIDData.AutoSize = true;
            this.lblReceiptIDData.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReceiptIDData.Location = new System.Drawing.Point(280, 59);
            this.lblReceiptIDData.Name = "lblReceiptIDData";
            this.lblReceiptIDData.Size = new System.Drawing.Size(0, 20);
            this.lblReceiptIDData.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(125, 138);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(115, 20);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "CustomerID :";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(125, 216);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(121, 20);
            this.lblServiceType.TabIndex = 4;
            this.lblServiceType.Text = "Service Type :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(606, 216);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(86, 20);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity :";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(125, 319);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(59, 20);
            this.lblFees.TabIndex = 8;
            this.lblFees.Text = "Fees :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(125, 409);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 20);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status :";
            // 
            // checkBoxUrgent
            // 
            this.checkBoxUrgent.AutoSize = true;
            this.checkBoxUrgent.Enabled = false;
            this.checkBoxUrgent.Location = new System.Drawing.Point(610, 59);
            this.checkBoxUrgent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxUrgent.Name = "checkBoxUrgent";
            this.checkBoxUrgent.Size = new System.Drawing.Size(84, 24);
            this.checkBoxUrgent.TabIndex = 12;
            this.checkBoxUrgent.Text = "Urgent";
            this.checkBoxUrgent.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(284, 399);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(136, 28);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(496, 478);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 54);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(706, 478);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(165, 54);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtReceiptID
            // 
            this.txtReceiptID.Location = new System.Drawing.Point(284, 56);
            this.txtReceiptID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.ReadOnly = true;
            this.txtReceiptID.Size = new System.Drawing.Size(112, 26);
            this.txtReceiptID.TabIndex = 16;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(284, 134);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(112, 26);
            this.txtCustomerID.TabIndex = 17;
            // 
            // txtServicetype
            // 
            this.txtServicetype.Location = new System.Drawing.Point(284, 216);
            this.txtServicetype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServicetype.Name = "txtServicetype";
            this.txtServicetype.ReadOnly = true;
            this.txtServicetype.Size = new System.Drawing.Size(112, 26);
            this.txtServicetype.TabIndex = 18;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(706, 209);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(112, 26);
            this.txtQuantity.TabIndex = 19;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(284, 311);
            this.txtFees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFees.Name = "txtFees";
            this.txtFees.ReadOnly = true;
            this.txtFees.Size = new System.Drawing.Size(112, 26);
            this.txtFees.TabIndex = 20;
            // 
            // WorkRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtServicetype);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtReceiptID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.checkBoxUrgent);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblReceiptIDData);
            this.Controls.Add(this.lblReceiptID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorkRequest";
            this.Text = "Work Request";
            this.Load += new System.EventHandler(this.WorkRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceiptID;
        private System.Windows.Forms.Label lblReceiptIDData;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox checkBoxUrgent;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtReceiptID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtServicetype;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtFees;
    }
}
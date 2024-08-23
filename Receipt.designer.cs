namespace Customer
{
    partial class Receipt
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
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_RECEIPT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_RID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_DATE = new System.Windows.Forms.Label();
            this.lb_UR2 = new System.Windows.Forms.Label();
            this.lb_TOTAL2 = new System.Windows.Forms.Label();
            this.btn_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(41, 141);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(734, 156);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Service Type";
            this.columnHeader2.Width = 245;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fees (RM)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 82;
            // 
            // lb_RECEIPT
            // 
            this.lb_RECEIPT.AutoSize = true;
            this.lb_RECEIPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RECEIPT.Location = new System.Drawing.Point(336, 21);
            this.lb_RECEIPT.Name = "lb_RECEIPT";
            this.lb_RECEIPT.Size = new System.Drawing.Size(118, 32);
            this.lb_RECEIPT.TabIndex = 2;
            this.lb_RECEIPT.Text = "Receipt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Receipt ID :";
            // 
            // lb_RID
            // 
            this.lb_RID.AutoSize = true;
            this.lb_RID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_RID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RID.Location = new System.Drawing.Point(159, 64);
            this.lb_RID.Name = "lb_RID";
            this.lb_RID.Size = new System.Drawing.Size(2, 22);
            this.lb_RID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date :";
            // 
            // lb_DATE
            // 
            this.lb_DATE.AutoSize = true;
            this.lb_DATE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DATE.Location = new System.Drawing.Point(115, 95);
            this.lb_DATE.Name = "lb_DATE";
            this.lb_DATE.Size = new System.Drawing.Size(2, 22);
            this.lb_DATE.TabIndex = 6;
            // 
            // lb_UR2
            // 
            this.lb_UR2.AutoSize = true;
            this.lb_UR2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_UR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UR2.Location = new System.Drawing.Point(41, 312);
            this.lb_UR2.Name = "lb_UR2";
            this.lb_UR2.Size = new System.Drawing.Size(2, 22);
            this.lb_UR2.TabIndex = 7;
            // 
            // lb_TOTAL2
            // 
            this.lb_TOTAL2.AutoSize = true;
            this.lb_TOTAL2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_TOTAL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TOTAL2.Location = new System.Drawing.Point(41, 345);
            this.lb_TOTAL2.Name = "lb_TOTAL2";
            this.lb_TOTAL2.Size = new System.Drawing.Size(2, 22);
            this.lb_TOTAL2.TabIndex = 8;
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CLOSE.Location = new System.Drawing.Point(342, 389);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(85, 38);
            this.btn_CLOSE.TabIndex = 9;
            this.btn_CLOSE.Text = "Close";
            this.btn_CLOSE.UseVisualStyleBackColor = true;
            this.btn_CLOSE.Click += new System.EventHandler(this.btn_CLOSE_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CLOSE);
            this.Controls.Add(this.lb_TOTAL2);
            this.Controls.Add(this.lb_UR2);
            this.Controls.Add(this.lb_DATE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_RID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_RECEIPT);
            this.Controls.Add(this.listView2);
            this.Name = "Receipt";
            this.Text = "APU Printing Services";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lb_RECEIPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_RID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_DATE;
        private System.Windows.Forms.Label lb_UR2;
        private System.Windows.Forms.Label lb_TOTAL2;
        private System.Windows.Forms.Button btn_CLOSE;
    }
}
namespace IOOP1
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newRequestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            //this.iOOPDataSet = new IOOP1.IOOPDataSet();
            this.newRequestBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            //this.newRequestTableAdapter2 = new IOOP1.IOOPDataSet2TableAdapters.NewRequestTableAdapter();
            //this.tableAdapterManager1 = new IOOP1.IOOPDataSet2TableAdapters.TableAdapterManager();
           // this.newRequestTableAdapter1 = new IOOP1.IOOPDataSetTableAdapters.NewRequestTableAdapter();
            this.receiptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgentRequestDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
           // this.newRequest = new IOOP1.NewRequest();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
           // this.newRequestTableAdapter = new IOOP1.NewRequestTableAdapters.NewRequestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRequestBindingSource1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.iOOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRequestBindingSource2)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.newRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receiptIDDataGridViewTextBoxColumn,
            this.servicetypeDataGridViewTextBoxColumn,
            this.feesDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.urgentRequestDataGridViewCheckBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(118, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // newRequestBindingSource1
            // 
            this.newRequestBindingSource1.DataMember = "NewRequest";
            //this.newRequestBindingSource1.DataSource = this.iOOPDataSet;
            // 
            // iOOPDataSet
            // 
           // this.iOOPDataSet.DataSetName = "IOOPDataSet";
          //  this.iOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(345, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // newRequestTableAdapter2
            // 
           // this.newRequestTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
          //  this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager1.NewRequestTableAdapter = this.newRequestTableAdapter2;
          //  this.tableAdapterManager1.UpdateOrder = IOOP1.IOOPDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // newRequestTableAdapter1
            // 
           // this.newRequestTableAdapter1.ClearBeforeFill = true;
            // 
            // receiptIDDataGridViewTextBoxColumn
            // 
            this.receiptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceiptID";
            this.receiptIDDataGridViewTextBoxColumn.HeaderText = "ReceiptID";
            this.receiptIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptIDDataGridViewTextBoxColumn.Name = "receiptIDDataGridViewTextBoxColumn";
            this.receiptIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicetypeDataGridViewTextBoxColumn
            // 
            this.servicetypeDataGridViewTextBoxColumn.DataPropertyName = "Servicetype";
            this.servicetypeDataGridViewTextBoxColumn.HeaderText = "Servicetype";
            this.servicetypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicetypeDataGridViewTextBoxColumn.Name = "servicetypeDataGridViewTextBoxColumn";
            this.servicetypeDataGridViewTextBoxColumn.Visible = false;
            this.servicetypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // feesDataGridViewTextBoxColumn
            // 
            this.feesDataGridViewTextBoxColumn.DataPropertyName = "Fees";
            this.feesDataGridViewTextBoxColumn.HeaderText = "Fees";
            this.feesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feesDataGridViewTextBoxColumn.Name = "feesDataGridViewTextBoxColumn";
            this.feesDataGridViewTextBoxColumn.Visible = false;
            this.feesDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Visible = false;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // urgentRequestDataGridViewCheckBoxColumn
            // 
            this.urgentRequestDataGridViewCheckBoxColumn.DataPropertyName = "UrgentRequest";
            this.urgentRequestDataGridViewCheckBoxColumn.HeaderText = "UrgentRequest";
            this.urgentRequestDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.urgentRequestDataGridViewCheckBoxColumn.Name = "urgentRequestDataGridViewCheckBoxColumn";
            this.urgentRequestDataGridViewCheckBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // newRequest
            // 
           // this.newRequest.DataSetName = "NewRequest";
           // this.newRequest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "NewRequest";
           // this.bindingSource1.DataSource = this.newRequest;
            // 
            // newRequestTableAdapter
            // 
           // this.newRequestTableAdapter.ClearBeforeFill = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 457);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRequestBindingSource1)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.iOOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRequestBindingSource2)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.newRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.BindingSource newRequestBindingSource;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource newRequestBindingSource2;
       // private IOOPDataSet2TableAdapters.NewRequestTableAdapter newRequestTableAdapter2;
       // private IOOPDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        //private IOOP1DataSet iOOP1DataSet;
        private System.Windows.Forms.BindingSource newRequestBindingSource;
        //private IOOP1DataSetTableAdapters.NewRequestTableAdapter newRequestTableAdapter;
       // private IOOPDataSet iOOPDataSet;
        private System.Windows.Forms.BindingSource newRequestBindingSource1;
       // private IOOPDataSetTableAdapters.NewRequestTableAdapter newRequestTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urgentRequestDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
       // private NewRequest newRequest;
        private System.Windows.Forms.BindingSource bindingSource1;
       // private NewRequestTableAdapters.NewRequestTableAdapter newRequestTableAdapter;
    }
}


namespace ProProkat
{
    partial class AddNewDiskData
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
            this.lblData = new System.Windows.Forms.Label();
            this.txtboxData = new System.Windows.Forms.TextBox();
            this.btnAddData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemoveData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 288);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 13);
            this.lblData.TabIndex = 27;
            this.lblData.Text = "Текст";
            // 
            // txtboxData
            // 
            this.txtboxData.Location = new System.Drawing.Point(133, 285);
            this.txtboxData.Name = "txtboxData";
            this.txtboxData.Size = new System.Drawing.Size(166, 20);
            this.txtboxData.TabIndex = 26;
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(133, 308);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(166, 45);
            this.btnAddData.TabIndex = 28;
            this.btnAddData.Text = "Добавить ";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(287, 208);
            this.dataGridView1.TabIndex = 29;
            // 
            // btnRemoveData
            // 
            this.btnRemoveData.Location = new System.Drawing.Point(12, 230);
            this.btnRemoveData.Name = "btnRemoveData";
            this.btnRemoveData.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveData.TabIndex = 30;
            this.btnRemoveData.Text = "Удалить";
            this.btnRemoveData.UseVisualStyleBackColor = true;
            this.btnRemoveData.Click += new System.EventHandler(this.btnRemoveData_Click);
            // 
            // AddNewDiskData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 365);
            this.Controls.Add(this.btnRemoveData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtboxData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddNewDiskData";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.AddNewDiskData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblData;
        public System.Windows.Forms.TextBox txtboxData;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemoveData;
    }
}
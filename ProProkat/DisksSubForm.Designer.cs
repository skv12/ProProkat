namespace ProProkat
{
    partial class DisksSubForm
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
            this.btnAddDisk = new System.Windows.Forms.Button();
            this.btnRemoveDisk = new System.Windows.Forms.Button();
            this.btnSearchDisk = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DiskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiskPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiskCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddDisk
            // 
            this.btnAddDisk.Location = new System.Drawing.Point(459, 12);
            this.btnAddDisk.Name = "btnAddDisk";
            this.btnAddDisk.Size = new System.Drawing.Size(75, 23);
            this.btnAddDisk.TabIndex = 0;
            this.btnAddDisk.Text = "Добавить";
            this.btnAddDisk.UseVisualStyleBackColor = true;
            this.btnAddDisk.Click += new System.EventHandler(this.btnAddDisk_Click);
            // 
            // btnRemoveDisk
            // 
            this.btnRemoveDisk.Location = new System.Drawing.Point(540, 12);
            this.btnRemoveDisk.Name = "btnRemoveDisk";
            this.btnRemoveDisk.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveDisk.TabIndex = 1;
            this.btnRemoveDisk.Text = "Списать";
            this.btnRemoveDisk.UseVisualStyleBackColor = true;
            // 
            // btnSearchDisk
            // 
            this.btnSearchDisk.Location = new System.Drawing.Point(621, 12);
            this.btnSearchDisk.Name = "btnSearchDisk";
            this.btnSearchDisk.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDisk.TabIndex = 2;
            this.btnSearchDisk.Text = "Поиск";
            this.btnSearchDisk.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DiskName,
            this.DiskPrice,
            this.DiskCount});
            this.listView1.Location = new System.Drawing.Point(63, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(655, 302);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // DiskName
            // 
            this.DiskName.Text = "Название";
            this.DiskName.Width = 467;
            // 
            // DiskPrice
            // 
            this.DiskPrice.Text = "Цена";
            this.DiskPrice.Width = 92;
            // 
            // DiskCount
            // 
            this.DiskCount.Text = "Количество";
            this.DiskCount.Width = 92;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisksSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSearchDisk);
            this.Controls.Add(this.btnRemoveDisk);
            this.Controls.Add(this.btnAddDisk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisksSubForm";
            this.Text = "DisksSubForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddDisk;
        private System.Windows.Forms.Button btnRemoveDisk;
        private System.Windows.Forms.Button btnSearchDisk;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DiskName;
        private System.Windows.Forms.ColumnHeader DiskPrice;
        private System.Windows.Forms.ColumnHeader DiskCount;
        private System.Windows.Forms.Button button1;
    }
}
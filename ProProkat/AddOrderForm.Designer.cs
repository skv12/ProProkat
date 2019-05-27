namespace ProProkat
{
    partial class AddOrderForm
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
            this.cmbxClient = new System.Windows.Forms.ComboBox();
            this.chkNewClient = new System.Windows.Forms.CheckBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxDisk = new System.Windows.Forms.ComboBox();
            this.btnAddDisk = new System.Windows.Forms.Button();
            this.txtboxDiskCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxRent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblcontact = new System.Windows.Forms.Label();
            this.lblbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldskcount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbxClient
            // 
            this.cmbxClient.FormattingEnabled = true;
            this.cmbxClient.Location = new System.Drawing.Point(113, 363);
            this.cmbxClient.Name = "cmbxClient";
            this.cmbxClient.Size = new System.Drawing.Size(148, 21);
            this.cmbxClient.TabIndex = 0;
            this.cmbxClient.SelectedIndexChanged += new System.EventHandler(this.cmbxClient_SelectedIndexChanged);
            this.cmbxClient.Click += new System.EventHandler(this.cmbxClient_Click);
            this.cmbxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxClient_KeyPress);
            // 
            // chkNewClient
            // 
            this.chkNewClient.AutoSize = true;
            this.chkNewClient.Location = new System.Drawing.Point(40, 34);
            this.chkNewClient.Name = "chkNewClient";
            this.chkNewClient.Size = new System.Drawing.Size(98, 17);
            this.chkNewClient.TabIndex = 1;
            this.chkNewClient.Text = "Новый клиент";
            this.chkNewClient.UseVisualStyleBackColor = true;
            this.chkNewClient.CheckedChanged += new System.EventHandler(this.chkNewClient_CheckedChanged);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(40, 58);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(709, 279);
            this.panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Диски";
            // 
            // cmbxDisk
            // 
            this.cmbxDisk.FormattingEnabled = true;
            this.cmbxDisk.Location = new System.Drawing.Point(113, 407);
            this.cmbxDisk.Name = "cmbxDisk";
            this.cmbxDisk.Size = new System.Drawing.Size(148, 21);
            this.cmbxDisk.TabIndex = 5;
            this.cmbxDisk.SelectedIndexChanged += new System.EventHandler(this.cmbxDisk_SelectedIndexChanged);
            this.cmbxDisk.Click += new System.EventHandler(this.cmbxDisk_Click);
            this.cmbxDisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxDisk_KeyPress);
            // 
            // btnAddDisk
            // 
            this.btnAddDisk.Location = new System.Drawing.Point(479, 405);
            this.btnAddDisk.Name = "btnAddDisk";
            this.btnAddDisk.Size = new System.Drawing.Size(75, 23);
            this.btnAddDisk.TabIndex = 6;
            this.btnAddDisk.Text = "Добавить";
            this.btnAddDisk.UseVisualStyleBackColor = true;
            this.btnAddDisk.Click += new System.EventHandler(this.btnAddDisk_Click);
            // 
            // txtboxDiskCount
            // 
            this.txtboxDiskCount.Location = new System.Drawing.Point(349, 407);
            this.txtboxDiskCount.Name = "txtboxDiskCount";
            this.txtboxDiskCount.Size = new System.Drawing.Size(100, 20);
            this.txtboxDiskCount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество";
            // 
            // txtboxRent
            // 
            this.txtboxRent.Location = new System.Drawing.Point(113, 482);
            this.txtboxRent.Name = "txtboxRent";
            this.txtboxRent.Size = new System.Drawing.Size(148, 20);
            this.txtboxRent.TabIndex = 9;
            this.txtboxRent.TextChanged += new System.EventHandler(this.txtboxRent_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Срок заказа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Сумма заказа";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(487, 524);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 12;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(643, 554);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(106, 23);
            this.btnAddOrder.TabIndex = 13;
            this.btnAddOrder.Text = "Оформить заказ";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Сумма залога";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(488, 489);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(0, 13);
            this.lblDeposit.TabIndex = 15;
            // 
            // lblcontact
            // 
            this.lblcontact.AutoSize = true;
            this.lblcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcontact.Location = new System.Drawing.Point(433, 371);
            this.lblcontact.Name = "lblcontact";
            this.lblcontact.Size = new System.Drawing.Size(0, 16);
            this.lblcontact.TabIndex = 16;
            // 
            // lblbl
            // 
            this.lblbl.AutoSize = true;
            this.lblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblbl.Location = new System.Drawing.Point(488, 557);
            this.lblbl.Name = "lblbl";
            this.lblbl.Size = new System.Drawing.Size(0, 20);
            this.lblbl.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(277, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Контактный телефон:";
            // 
            // lbldskcount
            // 
            this.lbldskcount.AutoSize = true;
            this.lbldskcount.Location = new System.Drawing.Point(144, 449);
            this.lbldskcount.Name = "lbldskcount";
            this.lbldskcount.Size = new System.Drawing.Size(0, 13);
            this.lbldskcount.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Дисков в наличии";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(43, 554);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 13);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "lblTime";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(43, 567);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(35, 13);
            this.lblRent.TabIndex = 22;
            this.lblRent.Text = "lblrent";
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbldskcount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblbl);
            this.Controls.Add(this.lblcontact);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxRent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxDiskCount);
            this.Controls.Add(this.btnAddDisk);
            this.Controls.Add(this.cmbxDisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.chkNewClient);
            this.Controls.Add(this.cmbxClient);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.Activated += new System.EventHandler(this.AddOrderForm_Activated);
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbxClient;
        public System.Windows.Forms.CheckBox chkNewClient;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbxDisk;
        public System.Windows.Forms.Button btnAddDisk;
        public System.Windows.Forms.TextBox txtboxDiskCount;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtboxRent;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Button btnAddOrder;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblDeposit;
        public System.Windows.Forms.Label lblcontact;
        public System.Windows.Forms.Label lblbl;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbldskcount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRent;
    }
}
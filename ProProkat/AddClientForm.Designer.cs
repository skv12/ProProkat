namespace ProProkat
{
    partial class AddClientForm
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
            this.lblBL = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.chkbxBL = new System.Windows.Forms.CheckBox();
            this.txtBoxname = new System.Windows.Forms.TextBox();
            this.txtboxphone = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBL
            // 
            this.lblBL.AutoSize = true;
            this.lblBL.Location = new System.Drawing.Point(26, 169);
            this.lblBL.Name = "lblBL";
            this.lblBL.Size = new System.Drawing.Size(59, 13);
            this.lblBL.TabIndex = 14;
            this.lblBL.Text = "Статус ЧС";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(26, 127);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(114, 13);
            this.lblContact.TabIndex = 13;
            this.lblContact.Text = "Контактный телефон";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(26, 82);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Адрес";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "ФИО";
            // 
            // chkbxBL
            // 
            this.chkbxBL.AutoSize = true;
            this.chkbxBL.Location = new System.Drawing.Point(205, 169);
            this.chkbxBL.Name = "chkbxBL";
            this.chkbxBL.Size = new System.Drawing.Size(15, 14);
            this.chkbxBL.TabIndex = 5;
            this.chkbxBL.UseVisualStyleBackColor = true;
            // 
            // txtBoxname
            // 
            this.txtBoxname.Location = new System.Drawing.Point(205, 36);
            this.txtBoxname.Name = "txtBoxname";
            this.txtBoxname.Size = new System.Drawing.Size(349, 20);
            this.txtBoxname.TabIndex = 0;
            // 
            // txtboxphone
            // 
            this.txtboxphone.Location = new System.Drawing.Point(205, 124);
            this.txtboxphone.Name = "txtboxphone";
            this.txtboxphone.Size = new System.Drawing.Size(226, 20);
            this.txtboxphone.TabIndex = 2;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(205, 79);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(349, 20);
            this.txtboxAddress.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 250);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxphone);
            this.Controls.Add(this.txtBoxname);
            this.Controls.Add(this.chkbxBL);
            this.Controls.Add(this.lblBL);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddClientForm";
            this.Text = "Добавление клиента";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblBL;
        public System.Windows.Forms.Label lblContact;
        public System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.CheckBox chkbxBL;
        public System.Windows.Forms.TextBox txtBoxname;
        public System.Windows.Forms.TextBox txtboxphone;
        public System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Button btnAdd;
    }
}
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
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblNameDisk = new System.Windows.Forms.Label();
            this.chkbxBL = new System.Windows.Forms.CheckBox();
            this.txtBoxname = new System.Windows.Forms.TextBox();
            this.txtboxphone = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(26, 169);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(59, 13);
            this.lblDirector.TabIndex = 14;
            this.lblDirector.Text = "Статус ЧС";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(26, 127);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(114, 13);
            this.lblGenre.TabIndex = 13;
            this.lblGenre.Text = "Контактный телефон";
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(26, 82);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(38, 13);
            this.lblSynopsis.TabIndex = 12;
            this.lblSynopsis.Text = "Адрес";
            // 
            // lblNameDisk
            // 
            this.lblNameDisk.AutoSize = true;
            this.lblNameDisk.Location = new System.Drawing.Point(26, 36);
            this.lblNameDisk.Name = "lblNameDisk";
            this.lblNameDisk.Size = new System.Drawing.Size(34, 13);
            this.lblNameDisk.TabIndex = 11;
            this.lblNameDisk.Text = "ФИО";
            // 
            // chkbxBL
            // 
            this.chkbxBL.AutoSize = true;
            this.chkbxBL.Location = new System.Drawing.Point(205, 169);
            this.chkbxBL.Name = "chkbxBL";
            this.chkbxBL.Size = new System.Drawing.Size(15, 14);
            this.chkbxBL.TabIndex = 16;
            this.chkbxBL.UseVisualStyleBackColor = true;
            // 
            // txtBoxname
            // 
            this.txtBoxname.Location = new System.Drawing.Point(205, 36);
            this.txtBoxname.Name = "txtBoxname";
            this.txtBoxname.Size = new System.Drawing.Size(349, 20);
            this.txtBoxname.TabIndex = 17;
            // 
            // txtboxphone
            // 
            this.txtboxphone.Location = new System.Drawing.Point(205, 124);
            this.txtboxphone.Name = "txtboxphone";
            this.txtboxphone.Size = new System.Drawing.Size(226, 20);
            this.txtboxphone.TabIndex = 18;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(205, 79);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(349, 20);
            this.txtboxAddress.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(364, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 279);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxphone);
            this.Controls.Add(this.txtBoxname);
            this.Controls.Add(this.chkbxBL);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblSynopsis);
            this.Controls.Add(this.lblNameDisk);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDirector;
        public System.Windows.Forms.Label lblGenre;
        public System.Windows.Forms.Label lblSynopsis;
        public System.Windows.Forms.Label lblNameDisk;
        public System.Windows.Forms.CheckBox chkbxBL;
        public System.Windows.Forms.TextBox txtBoxname;
        public System.Windows.Forms.TextBox txtboxphone;
        public System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Button btnAdd;
    }
}
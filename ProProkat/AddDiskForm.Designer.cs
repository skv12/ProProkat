namespace ProProkat
{
    partial class AddDiskForm
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
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.lblDiskPrice = new System.Windows.Forms.Label();
            this.lblCountDisk = new System.Windows.Forms.Label();
            this.lblNameDisk = new System.Windows.Forms.Label();
            this.txtboxCount = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblAgeRating = new System.Windows.Forms.Label();
            this.rTxtBoxSynopsis = new System.Windows.Forms.RichTextBox();
            this.txtboxDirector = new System.Windows.Forms.TextBox();
            this.txtboxYear = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.cmbxCounrty = new System.Windows.Forms.ComboBox();
            this.cmbxAgerating = new System.Windows.Forms.ComboBox();
            this.lnkNewGenre = new System.Windows.Forms.LinkLabel();
            this.lnkNewCountry = new System.Windows.Forms.LinkLabel();
            this.lnkNewAgeRating = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(350, 217);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtboxPrice.TabIndex = 0;
            this.txtboxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxPrice_KeyPress);
            // 
            // lblDiskPrice
            // 
            this.lblDiskPrice.AutoSize = true;
            this.lblDiskPrice.Location = new System.Drawing.Point(347, 201);
            this.lblDiskPrice.Name = "lblDiskPrice";
            this.lblDiskPrice.Size = new System.Drawing.Size(33, 13);
            this.lblDiskPrice.TabIndex = 1;
            this.lblDiskPrice.Text = "Цена";
            // 
            // lblCountDisk
            // 
            this.lblCountDisk.AutoSize = true;
            this.lblCountDisk.Location = new System.Drawing.Point(347, 251);
            this.lblCountDisk.Name = "lblCountDisk";
            this.lblCountDisk.Size = new System.Drawing.Size(66, 13);
            this.lblCountDisk.TabIndex = 2;
            this.lblCountDisk.Text = "Количество";
            // 
            // lblNameDisk
            // 
            this.lblNameDisk.AutoSize = true;
            this.lblNameDisk.Location = new System.Drawing.Point(24, 64);
            this.lblNameDisk.Name = "lblNameDisk";
            this.lblNameDisk.Size = new System.Drawing.Size(57, 13);
            this.lblNameDisk.TabIndex = 3;
            this.lblNameDisk.Text = "Название";
            // 
            // txtboxCount
            // 
            this.txtboxCount.Location = new System.Drawing.Point(350, 267);
            this.txtboxCount.Name = "txtboxCount";
            this.txtboxCount.Size = new System.Drawing.Size(100, 20);
            this.txtboxCount.TabIndex = 4;
            this.txtboxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCount_KeyPress);
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(111, 61);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtboxName.Size = new System.Drawing.Size(213, 20);
            this.txtboxName.TabIndex = 5;
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(24, 93);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(57, 13);
            this.lblSynopsis.TabIndex = 8;
            this.lblSynopsis.Text = "Описание";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(24, 204);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Жанр";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(24, 308);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(58, 13);
            this.lblDirector.TabIndex = 10;
            this.lblDirector.Text = "Режиссер";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(24, 282);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(71, 13);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Год выпуска";
            // 
            // lblAgeRating
            // 
            this.lblAgeRating.AutoSize = true;
            this.lblAgeRating.Location = new System.Drawing.Point(24, 256);
            this.lblAgeRating.Name = "lblAgeRating";
            this.lblAgeRating.Size = new System.Drawing.Size(78, 13);
            this.lblAgeRating.TabIndex = 12;
            this.lblAgeRating.Text = "Возр. рейтинг";
            // 
            // rTxtBoxSynopsis
            // 
            this.rTxtBoxSynopsis.Location = new System.Drawing.Point(111, 93);
            this.rTxtBoxSynopsis.Name = "rTxtBoxSynopsis";
            this.rTxtBoxSynopsis.Size = new System.Drawing.Size(213, 96);
            this.rTxtBoxSynopsis.TabIndex = 14;
            this.rTxtBoxSynopsis.Text = "";
            // 
            // txtboxDirector
            // 
            this.txtboxDirector.Location = new System.Drawing.Point(111, 305);
            this.txtboxDirector.Name = "txtboxDirector";
            this.txtboxDirector.Size = new System.Drawing.Size(100, 20);
            this.txtboxDirector.TabIndex = 15;
            // 
            // txtboxYear
            // 
            this.txtboxYear.Location = new System.Drawing.Point(111, 279);
            this.txtboxYear.Name = "txtboxYear";
            this.txtboxYear.Size = new System.Drawing.Size(100, 20);
            this.txtboxYear.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(350, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(24, 230);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Страна";
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Location = new System.Drawing.Point(111, 199);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(121, 21);
            this.cmbxGenre.Sorted = true;
            this.cmbxGenre.TabIndex = 21;
            this.cmbxGenre.Click += new System.EventHandler(this.cmbxGenre_Click);
            this.cmbxGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxGenre_KeyPress);
            // 
            // cmbxCounrty
            // 
            this.cmbxCounrty.FormattingEnabled = true;
            this.cmbxCounrty.Location = new System.Drawing.Point(111, 225);
            this.cmbxCounrty.Name = "cmbxCounrty";
            this.cmbxCounrty.Size = new System.Drawing.Size(121, 21);
            this.cmbxCounrty.Sorted = true;
            this.cmbxCounrty.TabIndex = 22;
            this.cmbxCounrty.Click += new System.EventHandler(this.cmbxCounrty_Click);
            this.cmbxCounrty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxCounrty_KeyPress);
            // 
            // cmbxAgerating
            // 
            this.cmbxAgerating.FormattingEnabled = true;
            this.cmbxAgerating.Location = new System.Drawing.Point(111, 252);
            this.cmbxAgerating.Name = "cmbxAgerating";
            this.cmbxAgerating.Size = new System.Drawing.Size(121, 21);
            this.cmbxAgerating.Sorted = true;
            this.cmbxAgerating.TabIndex = 23;
            this.cmbxAgerating.Click += new System.EventHandler(this.cmbxAgerating_Click);
            this.cmbxAgerating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxAgerating_KeyPress);
            // 
            // lnkNewGenre
            // 
            this.lnkNewGenre.AutoSize = true;
            this.lnkNewGenre.Location = new System.Drawing.Point(238, 204);
            this.lnkNewGenre.Name = "lnkNewGenre";
            this.lnkNewGenre.Size = new System.Drawing.Size(84, 13);
            this.lnkNewGenre.TabIndex = 29;
            this.lnkNewGenre.TabStop = true;
            this.lnkNewGenre.Text = "Редактировать";
            this.lnkNewGenre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkNewGenre_LinkClicked);
            // 
            // lnkNewCountry
            // 
            this.lnkNewCountry.AutoSize = true;
            this.lnkNewCountry.Location = new System.Drawing.Point(238, 230);
            this.lnkNewCountry.Name = "lnkNewCountry";
            this.lnkNewCountry.Size = new System.Drawing.Size(84, 13);
            this.lnkNewCountry.TabIndex = 30;
            this.lnkNewCountry.TabStop = true;
            this.lnkNewCountry.Text = "Редактировать";
            this.lnkNewCountry.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkNewCountry_LinkClicked);
            // 
            // lnkNewAgeRating
            // 
            this.lnkNewAgeRating.AutoSize = true;
            this.lnkNewAgeRating.Location = new System.Drawing.Point(238, 256);
            this.lnkNewAgeRating.Name = "lnkNewAgeRating";
            this.lnkNewAgeRating.Size = new System.Drawing.Size(84, 13);
            this.lnkNewAgeRating.TabIndex = 31;
            this.lnkNewAgeRating.TabStop = true;
            this.lnkNewAgeRating.Text = "Редактировать";
            this.lnkNewAgeRating.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkNewAgeRating_LinkClicked);
            // 
            // AddDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 351);
            this.Controls.Add(this.lnkNewAgeRating);
            this.Controls.Add(this.lnkNewCountry);
            this.Controls.Add(this.lnkNewGenre);
            this.Controls.Add(this.cmbxAgerating);
            this.Controls.Add(this.cmbxCounrty);
            this.Controls.Add(this.cmbxGenre);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxYear);
            this.Controls.Add(this.txtboxDirector);
            this.Controls.Add(this.rTxtBoxSynopsis);
            this.Controls.Add(this.lblAgeRating);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblSynopsis);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.txtboxCount);
            this.Controls.Add(this.lblNameDisk);
            this.Controls.Add(this.lblCountDisk);
            this.Controls.Add(this.lblDiskPrice);
            this.Controls.Add(this.txtboxPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddDiskForm";
            this.Text = "Добавление диска";
            this.Load += new System.EventHandler(this.AddDiskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtboxPrice;
        public System.Windows.Forms.Label lblDiskPrice;
        public System.Windows.Forms.Label lblCountDisk;
        public System.Windows.Forms.Label lblNameDisk;
        public System.Windows.Forms.TextBox txtboxCount;
        public System.Windows.Forms.TextBox txtboxName;
        public System.Windows.Forms.Label lblSynopsis;
        public System.Windows.Forms.Label lblGenre;
        public System.Windows.Forms.Label lblDirector;
        public System.Windows.Forms.Label lblYear;
        public System.Windows.Forms.Label lblAgeRating;
        public System.Windows.Forms.RichTextBox rTxtBoxSynopsis;
        public System.Windows.Forms.TextBox txtboxDirector;
        public System.Windows.Forms.TextBox txtboxYear;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.ComboBox cmbxGenre;
        public System.Windows.Forms.ComboBox cmbxCounrty;
        public System.Windows.Forms.ComboBox cmbxAgerating;
        private System.Windows.Forms.LinkLabel lnkNewGenre;
        private System.Windows.Forms.LinkLabel lnkNewCountry;
        private System.Windows.Forms.LinkLabel lnkNewAgeRating;
    }
}
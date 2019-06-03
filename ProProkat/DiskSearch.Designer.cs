namespace ProProkat
{
    partial class DiskSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSearchDirector = new System.Windows.Forms.TextBox();
            this.tbSearchYear = new System.Windows.Forms.TextBox();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.cmbxPageRating = new System.Windows.Forms.ComboBox();
            this.cmbxCounrty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(205, 240);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(131, 31);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(345, 20);
            this.tbSearchName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Жанр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Режиссер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Год выпуска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Возрастной рейтинг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Страна";
            // 
            // tbSearchDirector
            // 
            this.tbSearchDirector.Location = new System.Drawing.Point(131, 85);
            this.tbSearchDirector.Name = "tbSearchDirector";
            this.tbSearchDirector.Size = new System.Drawing.Size(345, 20);
            this.tbSearchDirector.TabIndex = 9;
            // 
            // tbSearchYear
            // 
            this.tbSearchYear.Location = new System.Drawing.Point(131, 111);
            this.tbSearchYear.Name = "tbSearchYear";
            this.tbSearchYear.Size = new System.Drawing.Size(345, 20);
            this.tbSearchYear.TabIndex = 10;
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Location = new System.Drawing.Point(131, 58);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(345, 21);
            this.cmbxGenre.TabIndex = 11;
            // 
            // cmbxPageRating
            // 
            this.cmbxPageRating.FormattingEnabled = true;
            this.cmbxPageRating.Location = new System.Drawing.Point(131, 137);
            this.cmbxPageRating.Name = "cmbxPageRating";
            this.cmbxPageRating.Size = new System.Drawing.Size(345, 21);
            this.cmbxPageRating.TabIndex = 12;
            // 
            // cmbxCounrty
            // 
            this.cmbxCounrty.FormattingEnabled = true;
            this.cmbxCounrty.Location = new System.Drawing.Point(131, 164);
            this.cmbxCounrty.Name = "cmbxCounrty";
            this.cmbxCounrty.Size = new System.Drawing.Size(345, 21);
            this.cmbxCounrty.TabIndex = 13;
            // 
            // DiskSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 291);
            this.Controls.Add(this.cmbxCounrty);
            this.Controls.Add(this.cmbxPageRating);
            this.Controls.Add(this.cmbxGenre);
            this.Controls.Add(this.tbSearchYear);
            this.Controls.Add(this.tbSearchDirector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.btnSearch);
            this.Name = "DiskSearch";
            this.Text = "DiskSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearchDirector;
        private System.Windows.Forms.TextBox tbSearchYear;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private System.Windows.Forms.ComboBox cmbxPageRating;
        private System.Windows.Forms.ComboBox cmbxCounrty;
    }
}
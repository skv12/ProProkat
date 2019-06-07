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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbxCounrty = new System.Windows.Forms.ComboBox();
            this.cmbxPageRating = new System.Windows.Forms.ComboBox();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.tbSearchYear = new System.Windows.Forms.TextBox();
            this.tbSearchDirector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddDisk
            // 
            this.btnAddDisk.Location = new System.Drawing.Point(548, 12);
            this.btnAddDisk.Name = "btnAddDisk";
            this.btnAddDisk.Size = new System.Drawing.Size(75, 25);
            this.btnAddDisk.TabIndex = 0;
            this.btnAddDisk.Text = "Добавить";
            this.btnAddDisk.UseVisualStyleBackColor = true;
            this.btnAddDisk.Click += new System.EventHandler(this.btnAddDisk_Click);
            // 
            // btnRemoveDisk
            // 
            this.btnRemoveDisk.Location = new System.Drawing.Point(548, 43);
            this.btnRemoveDisk.Name = "btnRemoveDisk";
            this.btnRemoveDisk.Size = new System.Drawing.Size(75, 25);
            this.btnRemoveDisk.TabIndex = 1;
            this.btnRemoveDisk.Text = "Списать";
            this.btnRemoveDisk.UseVisualStyleBackColor = true;
            this.btnRemoveDisk.Click += new System.EventHandler(this.btnRemoveDisk_Click);
            // 
            // btnSearchDisk
            // 
            this.btnSearchDisk.Location = new System.Drawing.Point(688, 43);
            this.btnSearchDisk.Name = "btnSearchDisk";
            this.btnSearchDisk.Size = new System.Drawing.Size(75, 25);
            this.btnSearchDisk.TabIndex = 2;
            this.btnSearchDisk.Text = "Поиск";
            this.btnSearchDisk.UseVisualStyleBackColor = true;
            this.btnSearchDisk.Click += new System.EventHandler(this.btnSearchDisk_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 420);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(688, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 25);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbxCounrty
            // 
            this.cmbxCounrty.FormattingEnabled = true;
            this.cmbxCounrty.Location = new System.Drawing.Point(548, 322);
            this.cmbxCounrty.Name = "cmbxCounrty";
            this.cmbxCounrty.Size = new System.Drawing.Size(215, 21);
            this.cmbxCounrty.TabIndex = 26;
            this.cmbxCounrty.Visible = false;
            this.cmbxCounrty.Click += new System.EventHandler(this.cmbxCounrty_Click);
            this.cmbxCounrty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxCounrty_KeyPress);
            // 
            // cmbxPageRating
            // 
            this.cmbxPageRating.FormattingEnabled = true;
            this.cmbxPageRating.Location = new System.Drawing.Point(548, 282);
            this.cmbxPageRating.Name = "cmbxPageRating";
            this.cmbxPageRating.Size = new System.Drawing.Size(215, 21);
            this.cmbxPageRating.TabIndex = 25;
            this.cmbxPageRating.Visible = false;
            this.cmbxPageRating.Click += new System.EventHandler(this.cmbxPageRating_Click);
            this.cmbxPageRating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxPageRating_KeyPress);
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Location = new System.Drawing.Point(548, 163);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(215, 21);
            this.cmbxGenre.TabIndex = 24;
            this.cmbxGenre.Visible = false;
            this.cmbxGenre.Click += new System.EventHandler(this.cmbxGenre_Click);
            this.cmbxGenre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbxGenre_KeyPress);
            // 
            // tbSearchYear
            // 
            this.tbSearchYear.Location = new System.Drawing.Point(548, 243);
            this.tbSearchYear.Name = "tbSearchYear";
            this.tbSearchYear.Size = new System.Drawing.Size(215, 20);
            this.tbSearchYear.TabIndex = 23;
            this.tbSearchYear.Visible = false;
            // 
            // tbSearchDirector
            // 
            this.tbSearchDirector.Location = new System.Drawing.Point(548, 204);
            this.tbSearchDirector.Name = "tbSearchDirector";
            this.tbSearchDirector.Size = new System.Drawing.Size(215, 20);
            this.tbSearchDirector.TabIndex = 22;
            this.tbSearchDirector.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Страна";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Возрастной рейтинг";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Год выпуска";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Режиссер";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Жанр";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название";
            this.label1.Visible = false;
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(548, 124);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(215, 20);
            this.tbSearchName.TabIndex = 15;
            this.tbSearchName.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(688, 409);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DisksSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 480);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearchDisk);
            this.Controls.Add(this.btnRemoveDisk);
            this.Controls.Add(this.btnAddDisk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisksSubForm";
            this.Text = "DisksSubForm";
            this.Load += new System.EventHandler(this.DisksSubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDisk;
        private System.Windows.Forms.Button btnRemoveDisk;
        private System.Windows.Forms.Button btnSearchDisk;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbxCounrty;
        private System.Windows.Forms.ComboBox cmbxPageRating;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private System.Windows.Forms.TextBox tbSearchYear;
        private System.Windows.Forms.TextBox tbSearchDirector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btnSearch;
    }
}
namespace ProProkat
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.BtnClientList = new System.Windows.Forms.Button();
            this.BtnOrderList = new System.Windows.Forms.Button();
            this.BtnDiskList = new System.Windows.Forms.Button();
            this.BtnCreateReport = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Location = new System.Drawing.Point(661, 452);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(127, 23);
            this.BtnNewOrder.TabIndex = 1;
            this.BtnNewOrder.Text = "Новый заказ";
            this.BtnNewOrder.UseVisualStyleBackColor = true;
            // 
            // BtnClientList
            // 
            this.BtnClientList.Location = new System.Drawing.Point(27, 51);
            this.BtnClientList.Name = "BtnClientList";
            this.BtnClientList.Size = new System.Drawing.Size(109, 23);
            this.BtnClientList.TabIndex = 2;
            this.BtnClientList.Text = "Список клиентов";
            this.BtnClientList.UseVisualStyleBackColor = true;
            this.BtnClientList.Click += new System.EventHandler(this.BtnClientList_Click);
            // 
            // BtnOrderList
            // 
            this.BtnOrderList.Location = new System.Drawing.Point(27, 80);
            this.BtnOrderList.Name = "BtnOrderList";
            this.BtnOrderList.Size = new System.Drawing.Size(109, 23);
            this.BtnOrderList.TabIndex = 3;
            this.BtnOrderList.Text = "Список заказов";
            this.BtnOrderList.UseVisualStyleBackColor = true;
            this.BtnOrderList.Click += new System.EventHandler(this.BtnOrderList_Click);
            // 
            // BtnDiskList
            // 
            this.BtnDiskList.Location = new System.Drawing.Point(27, 109);
            this.BtnDiskList.Name = "BtnDiskList";
            this.BtnDiskList.Size = new System.Drawing.Size(109, 23);
            this.BtnDiskList.TabIndex = 4;
            this.BtnDiskList.Text = "Список дисков";
            this.BtnDiskList.UseVisualStyleBackColor = true;
            this.BtnDiskList.Click += new System.EventHandler(this.BtnDiskList_Click);
            // 
            // BtnCreateReport
            // 
            this.BtnCreateReport.Location = new System.Drawing.Point(27, 452);
            this.BtnCreateReport.Name = "BtnCreateReport";
            this.BtnCreateReport.Size = new System.Drawing.Size(152, 23);
            this.BtnCreateReport.TabIndex = 5;
            this.BtnCreateReport.Text = "Создать отчет по работе";
            this.BtnCreateReport.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(157, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(631, 410);
            this.panel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.BtnCreateReport);
            this.Controls.Add(this.BtnDiskList);
            this.Controls.Add(this.BtnOrderList);
            this.Controls.Add(this.BtnClientList);
            this.Controls.Add(this.BtnNewOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ProProkat";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.Button BtnClientList;
        private System.Windows.Forms.Button BtnOrderList;
        private System.Windows.Forms.Button BtnDiskList;
        private System.Windows.Forms.Button BtnCreateReport;
        private System.Windows.Forms.Panel panel;
    }
}


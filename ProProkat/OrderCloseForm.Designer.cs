namespace ProProkat
{
    partial class OrderCloseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcl = new System.Windows.Forms.Label();
            this.lbldsk = new System.Windows.Forms.Label();
            this.lblrent = new System.Windows.Forms.Label();
            this.lbldeposit = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заказанные диски:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(59, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Крайный срок сдачи заказа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма залога:";
            // 
            // lblcl
            // 
            this.lblcl.AutoSize = true;
            this.lblcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblcl.Location = new System.Drawing.Point(133, 41);
            this.lblcl.Name = "lblcl";
            this.lblcl.Size = new System.Drawing.Size(69, 20);
            this.lblcl.TabIndex = 4;
            this.lblcl.Text = "Клиент:";
            // 
            // lbldsk
            // 
            this.lbldsk.AutoSize = true;
            this.lbldsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldsk.Location = new System.Drawing.Point(218, 70);
            this.lbldsk.Name = "lbldsk";
            this.lbldsk.Size = new System.Drawing.Size(154, 20);
            this.lbldsk.TabIndex = 5;
            this.lbldsk.Text = "Заказанные диски:";
            // 
            // lblrent
            // 
            this.lblrent.AutoSize = true;
            this.lblrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblrent.Location = new System.Drawing.Point(287, 101);
            this.lblrent.Name = "lblrent";
            this.lblrent.Size = new System.Drawing.Size(222, 20);
            this.lblrent.TabIndex = 6;
            this.lblrent.Text = "Крайный срок сдачи заказа:";
            // 
            // lbldeposit
            // 
            this.lbldeposit.AutoSize = true;
            this.lbldeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbldeposit.Location = new System.Drawing.Point(183, 131);
            this.lbldeposit.Name = "lbldeposit";
            this.lbldeposit.Size = new System.Drawing.Size(118, 20);
            this.lbldeposit.TabIndex = 7;
            this.lbldeposit.Text = "Сумма залога:";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(523, 239);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 23);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "Закрыть заказ";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(59, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер заказа";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblid.Location = new System.Drawing.Point(183, 239);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(114, 20);
            this.lblid.TabIndex = 10;
            this.lblid.Text = "Номер заказа";
            // 
            // OrderCloseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 294);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lbldeposit);
            this.Controls.Add(this.lblrent);
            this.Controls.Add(this.lbldsk);
            this.Controls.Add(this.lblcl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderCloseForm";
            this.Text = "OrderCloseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblcl;
        public System.Windows.Forms.Label lbldsk;
        public System.Windows.Forms.Label lblrent;
        public System.Windows.Forms.Label lbldeposit;
        public System.Windows.Forms.Button btnclose;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblid;
    }
}
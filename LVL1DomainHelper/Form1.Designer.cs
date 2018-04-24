namespace LVL1DomainHelper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.domainNameLabel = new System.Windows.Forms.Label();
            this.domainName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.mxRecordLabel = new System.Windows.Forms.Label();
            this.mxRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nsRecords = new System.Windows.Forms.RichTextBox();
            this.changeBackground = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // domainNameLabel
            // 
            this.domainNameLabel.AutoSize = true;
            this.domainNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainNameLabel.Location = new System.Drawing.Point(50, 30);
            this.domainNameLabel.Name = "domainNameLabel";
            this.domainNameLabel.Size = new System.Drawing.Size(87, 26);
            this.domainNameLabel.TabIndex = 0;
            this.domainNameLabel.Text = "Домен:";
            this.domainNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // domainName
            // 
            this.domainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domainName.Location = new System.Drawing.Point(55, 59);
            this.domainName.Name = "domainName";
            this.domainName.Size = new System.Drawing.Size(284, 26);
            this.domainName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(381, 59);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(149, 60);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Определить";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipAddressLabel.Location = new System.Drawing.Point(50, 93);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(106, 26);
            this.ipAddressLabel.TabIndex = 3;
            this.ipAddressLabel.Text = "IP-адрес:";
            // 
            // ipAddress
            // 
            this.ipAddress.BackColor = System.Drawing.Color.White;
            this.ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ipAddress.Location = new System.Drawing.Point(55, 122);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.ReadOnly = true;
            this.ipAddress.Size = new System.Drawing.Size(284, 26);
            this.ipAddress.TabIndex = 4;
            // 
            // mxRecordLabel
            // 
            this.mxRecordLabel.AutoSize = true;
            this.mxRecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mxRecordLabel.Location = new System.Drawing.Point(50, 160);
            this.mxRecordLabel.Name = "mxRecordLabel";
            this.mxRecordLabel.Size = new System.Drawing.Size(210, 26);
            this.mxRecordLabel.TabIndex = 5;
            this.mxRecordLabel.Text = "Почта (MX-запись):";
            // 
            // mxRecord
            // 
            this.mxRecord.BackColor = System.Drawing.Color.White;
            this.mxRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mxRecord.Location = new System.Drawing.Point(55, 189);
            this.mxRecord.Name = "mxRecord";
            this.mxRecord.ReadOnly = true;
            this.mxRecord.Size = new System.Drawing.Size(284, 26);
            this.mxRecord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "DNS-серверы (NS-записи):";
            // 
            // nsRecords
            // 
            this.nsRecords.BackColor = System.Drawing.Color.White;
            this.nsRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nsRecords.Location = new System.Drawing.Point(55, 260);
            this.nsRecords.Name = "nsRecords";
            this.nsRecords.ReadOnly = true;
            this.nsRecords.Size = new System.Drawing.Size(284, 96);
            this.nsRecords.TabIndex = 9;
            this.nsRecords.Text = "";
            // 
            // changeBackground
            // 
            this.changeBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBackground.Location = new System.Drawing.Point(381, 122);
            this.changeBackground.Name = "changeBackground";
            this.changeBackground.Size = new System.Drawing.Size(149, 62);
            this.changeBackground.TabIndex = 10;
            this.changeBackground.Text = "Сделать красиво";
            this.changeBackground.UseVisualStyleBackColor = true;
            this.changeBackground.Click += new System.EventHandler(this.changeBackground_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 421);
            this.Controls.Add(this.changeBackground);
            this.Controls.Add(this.nsRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mxRecord);
            this.Controls.Add(this.mxRecordLabel);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.domainName);
            this.Controls.Add(this.domainNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DAPAMOGA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label domainNameLabel;
        private System.Windows.Forms.TextBox domainName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.TextBox ipAddress;
        private System.Windows.Forms.Label mxRecordLabel;
        private System.Windows.Forms.TextBox mxRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox nsRecords;
        private System.Windows.Forms.Button changeBackground;
    }
}


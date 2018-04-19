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
            this.domainNameLabel = new System.Windows.Forms.Label();
            this.domainName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.ipAddress = new System.Windows.Forms.TextBox();
            this.mxRecordLabel = new System.Windows.Forms.Label();
            this.mxRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nsRecords = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // domainNameLabel
            // 
            this.domainNameLabel.AutoSize = true;
            this.domainNameLabel.Location = new System.Drawing.Point(52, 42);
            this.domainNameLabel.Name = "domainNameLabel";
            this.domainNameLabel.Size = new System.Drawing.Size(69, 13);
            this.domainNameLabel.TabIndex = 0;
            this.domainNameLabel.Text = "domainName";
            // 
            // domainName
            // 
            this.domainName.Location = new System.Drawing.Point(55, 59);
            this.domainName.Name = "domainName";
            this.domainName.Size = new System.Drawing.Size(100, 20);
            this.domainName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(281, 59);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(57, 118);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(72, 13);
            this.ipAddressLabel.TabIndex = 3;
            this.ipAddressLabel.Text = "IP-ADDRESS";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(60, 144);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(223, 20);
            this.ipAddress.TabIndex = 4;
            // 
            // mxRecordLabel
            // 
            this.mxRecordLabel.AutoSize = true;
            this.mxRecordLabel.Location = new System.Drawing.Point(60, 186);
            this.mxRecordLabel.Name = "mxRecordLabel";
            this.mxRecordLabel.Size = new System.Drawing.Size(61, 13);
            this.mxRecordLabel.TabIndex = 5;
            this.mxRecordLabel.Text = "MX-Record";
            // 
            // mxRecord
            // 
            this.mxRecord.Location = new System.Drawing.Point(60, 203);
            this.mxRecord.Name = "mxRecord";
            this.mxRecord.Size = new System.Drawing.Size(245, 20);
            this.mxRecord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NS Records";
            // 
            // nsRecords
            // 
            this.nsRecords.Location = new System.Drawing.Point(63, 291);
            this.nsRecords.Name = "nsRecords";
            this.nsRecords.Size = new System.Drawing.Size(254, 96);
            this.nsRecords.TabIndex = 9;
            this.nsRecords.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nsRecords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mxRecord);
            this.Controls.Add(this.mxRecordLabel);
            this.Controls.Add(this.ipAddress);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.domainName);
            this.Controls.Add(this.domainNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}


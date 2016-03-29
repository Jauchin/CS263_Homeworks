namespace Example03
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.baseSalaryLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryTextBox = new System.Windows.Forms.TextBox();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.employeeCatagory = new System.Windows.Forms.ComboBox();
            this.employeeTypeLabel = new System.Windows.Forms.Label();
            this.performanceLabel = new System.Windows.Forms.Label();
            this.performanceTextBox = new System.Windows.Forms.TextBox();
            this.toalSalaryLabel = new System.Windows.Forms.Label();
            this.totalSalaryTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(258, 127);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 32);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "新增員工";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(10, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(58, 13);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "員工編號:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 59);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "員工姓名:";
            // 
            // baseSalaryLabel
            // 
            this.baseSalaryLabel.AutoSize = true;
            this.baseSalaryLabel.Location = new System.Drawing.Point(10, 95);
            this.baseSalaryLabel.Name = "baseSalaryLabel";
            this.baseSalaryLabel.Size = new System.Drawing.Size(58, 13);
            this.baseSalaryLabel.TabIndex = 3;
            this.baseSalaryLabel.Text = "基本薪資:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(74, 21);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(54, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(74, 56);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(54, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // baseSalaryTextBox
            // 
            this.baseSalaryTextBox.Location = new System.Drawing.Point(74, 92);
            this.baseSalaryTextBox.Name = "baseSalaryTextBox";
            this.baseSalaryTextBox.Size = new System.Drawing.Size(54, 20);
            this.baseSalaryTextBox.TabIndex = 6;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Location = new System.Drawing.Point(36, 199);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(268, 101);
            this.infoRichTextBox.TabIndex = 7;
            this.infoRichTextBox.Text = "";
            this.infoRichTextBox.TextChanged += new System.EventHandler(this.infoRichTextBox_TextChanged);
            // 
            // employeeCatagory
            // 
            this.employeeCatagory.FormattingEnabled = true;
            this.employeeCatagory.Items.AddRange(new object[] {
            "一般員工",
            "業務",
            "經理"});
            this.employeeCatagory.Location = new System.Drawing.Point(240, 21);
            this.employeeCatagory.Name = "employeeCatagory";
            this.employeeCatagory.Size = new System.Drawing.Size(100, 21);
            this.employeeCatagory.TabIndex = 8;
            this.employeeCatagory.SelectedIndexChanged += new System.EventHandler(this.employeeCatagory_SelectedIndexChanged);
            // 
            // employeeTypeLabel
            // 
            this.employeeTypeLabel.AutoSize = true;
            this.employeeTypeLabel.Location = new System.Drawing.Point(162, 24);
            this.employeeTypeLabel.Name = "employeeTypeLabel";
            this.employeeTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.employeeTypeLabel.TabIndex = 9;
            this.employeeTypeLabel.Text = "員工類型:";
            // 
            // performanceLabel
            // 
            this.performanceLabel.AutoSize = true;
            this.performanceLabel.Location = new System.Drawing.Point(10, 130);
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(58, 13);
            this.performanceLabel.TabIndex = 10;
            this.performanceLabel.Text = "業績獎金:";
            // 
            // performanceTextBox
            // 
            this.performanceTextBox.Location = new System.Drawing.Point(76, 127);
            this.performanceTextBox.Name = "performanceTextBox";
            this.performanceTextBox.Size = new System.Drawing.Size(54, 20);
            this.performanceTextBox.TabIndex = 11;
            // 
            // toalSalaryLabel
            // 
            this.toalSalaryLabel.AutoSize = true;
            this.toalSalaryLabel.Location = new System.Drawing.Point(10, 164);
            this.toalSalaryLabel.Name = "toalSalaryLabel";
            this.toalSalaryLabel.Size = new System.Drawing.Size(58, 13);
            this.toalSalaryLabel.TabIndex = 12;
            this.toalSalaryLabel.Text = "薪水總計:";
            // 
            // totalSalaryTextBox
            // 
            this.totalSalaryTextBox.Location = new System.Drawing.Point(74, 161);
            this.totalSalaryTextBox.Name = "totalSalaryTextBox";
            this.totalSalaryTextBox.Size = new System.Drawing.Size(54, 20);
            this.totalSalaryTextBox.TabIndex = 13;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(175, 127);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(64, 32);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "清除";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 326);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.totalSalaryTextBox);
            this.Controls.Add(this.toalSalaryLabel);
            this.Controls.Add(this.performanceTextBox);
            this.Controls.Add(this.performanceLabel);
            this.Controls.Add(this.employeeTypeLabel);
            this.Controls.Add(this.employeeCatagory);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.baseSalaryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.baseSalaryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label baseSalaryLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox baseSalaryTextBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.ComboBox employeeCatagory;
        private System.Windows.Forms.Label employeeTypeLabel;
        private System.Windows.Forms.Label performanceLabel;
        private System.Windows.Forms.TextBox performanceTextBox;
        private System.Windows.Forms.Label toalSalaryLabel;
        private System.Windows.Forms.TextBox totalSalaryTextBox;
        private System.Windows.Forms.Button resetButton;
    }
}


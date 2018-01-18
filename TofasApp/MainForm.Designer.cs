namespace TofasApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.folderLocationTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newFolderNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.oldFolderNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.logsListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.networkAdapterTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.computerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gatewayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subnetTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshComputersButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.computerListComboBox = new System.Windows.Forms.ComboBox();
            this.restartPcButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.folderLocationTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.newFolderNameTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.oldFolderNameTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.logsListBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.networkAdapterTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.computerNameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gatewayTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.subnetTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ipAddressTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.refreshComputersButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.computerListComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontroller";
            // 
            // folderLocationTextBox
            // 
            this.folderLocationTextBox.Enabled = false;
            this.folderLocationTextBox.Location = new System.Drawing.Point(496, 138);
            this.folderLocationTextBox.Name = "folderLocationTextBox";
            this.folderLocationTextBox.Size = new System.Drawing.Size(196, 20);
            this.folderLocationTextBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Dosya Konumu";
            // 
            // newFolderNameTextBox
            // 
            this.newFolderNameTextBox.Enabled = false;
            this.newFolderNameTextBox.Location = new System.Drawing.Point(496, 112);
            this.newFolderNameTextBox.Name = "newFolderNameTextBox";
            this.newFolderNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.newFolderNameTextBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Yeni Dosya Adı";
            // 
            // oldFolderNameTextBox
            // 
            this.oldFolderNameTextBox.Enabled = false;
            this.oldFolderNameTextBox.Location = new System.Drawing.Point(496, 86);
            this.oldFolderNameTextBox.Name = "oldFolderNameTextBox";
            this.oldFolderNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.oldFolderNameTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Eski Dosya Adı";
            // 
            // logsListBox
            // 
            this.logsListBox.FormattingEnabled = true;
            this.logsListBox.Location = new System.Drawing.Point(6, 261);
            this.logsListBox.Name = "logsListBox";
            this.logsListBox.Size = new System.Drawing.Size(699, 121);
            this.logsListBox.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Green;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(202, 178);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(310, 77);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Kaydet";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // networkAdapterTextBox
            // 
            this.networkAdapterTextBox.Enabled = false;
            this.networkAdapterTextBox.Location = new System.Drawing.Point(496, 60);
            this.networkAdapterTextBox.Name = "networkAdapterTextBox";
            this.networkAdapterTextBox.Size = new System.Drawing.Size(196, 20);
            this.networkAdapterTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ağ Adaptörü";
            // 
            // computerNameTextBox
            // 
            this.computerNameTextBox.Enabled = false;
            this.computerNameTextBox.Location = new System.Drawing.Point(123, 60);
            this.computerNameTextBox.Name = "computerNameTextBox";
            this.computerNameTextBox.Size = new System.Drawing.Size(196, 20);
            this.computerNameTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bilgisayar Adı";
            // 
            // gatewayTextBox
            // 
            this.gatewayTextBox.Enabled = false;
            this.gatewayTextBox.Location = new System.Drawing.Point(123, 138);
            this.gatewayTextBox.Name = "gatewayTextBox";
            this.gatewayTextBox.Size = new System.Drawing.Size(196, 20);
            this.gatewayTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gateway";
            // 
            // subnetTextBox
            // 
            this.subnetTextBox.Enabled = false;
            this.subnetTextBox.Location = new System.Drawing.Point(123, 112);
            this.subnetTextBox.Name = "subnetTextBox";
            this.subnetTextBox.Size = new System.Drawing.Size(196, 20);
            this.subnetTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subnet";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Enabled = false;
            this.ipAddressTextBox.Location = new System.Drawing.Point(123, 86);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(196, 20);
            this.ipAddressTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ip Adresi";
            // 
            // refreshComputersButton
            // 
            this.refreshComputersButton.Location = new System.Drawing.Point(202, 17);
            this.refreshComputersButton.Name = "refreshComputersButton";
            this.refreshComputersButton.Size = new System.Drawing.Size(75, 23);
            this.refreshComputersButton.TabIndex = 2;
            this.refreshComputersButton.Text = "Yenile";
            this.refreshComputersButton.UseVisualStyleBackColor = true;
            this.refreshComputersButton.Click += new System.EventHandler(this.refreshComputersButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilgisayarlar";
            // 
            // computerListComboBox
            // 
            this.computerListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.computerListComboBox.Enabled = false;
            this.computerListComboBox.FormattingEnabled = true;
            this.computerListComboBox.Location = new System.Drawing.Point(74, 19);
            this.computerListComboBox.Name = "computerListComboBox";
            this.computerListComboBox.Size = new System.Drawing.Size(122, 21);
            this.computerListComboBox.TabIndex = 0;
            this.computerListComboBox.SelectedIndexChanged += new System.EventHandler(this.computerListComboBox_SelectedIndexChanged);
            // 
            // restartPcButton
            // 
            this.restartPcButton.BackColor = System.Drawing.Color.Red;
            this.restartPcButton.ForeColor = System.Drawing.Color.White;
            this.restartPcButton.Location = new System.Drawing.Point(214, 420);
            this.restartPcButton.Name = "restartPcButton";
            this.restartPcButton.Size = new System.Drawing.Size(310, 72);
            this.restartPcButton.TabIndex = 1;
            this.restartPcButton.Text = "Bilgisayarı Yeniden Başlat";
            this.restartPcButton.UseVisualStyleBackColor = false;
            this.restartPcButton.Click += new System.EventHandler(this.restartPcButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 501);
            this.Controls.Add(this.restartPcButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tofaş ISRA PC - By Mehmet Nuri ABACI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button restartPcButton;
        private System.Windows.Forms.Button refreshComputersButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox computerListComboBox;
        private System.Windows.Forms.TextBox networkAdapterTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox computerNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gatewayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subnetTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox logsListBox;
        private System.Windows.Forms.TextBox newFolderNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox oldFolderNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox folderLocationTextBox;
        private System.Windows.Forms.Label label9;
    }
}


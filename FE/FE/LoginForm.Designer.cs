using System.Windows.Forms;

namespace FE
{
    partial class LoginForm
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
        /// 
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cboDriverType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrainingCenter = new System.Windows.Forms.ComboBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.picUserPhoto = new System.Windows.Forms.PictureBox();
            this.btnPractice = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelFullNameValue = new System.Windows.Forms.Label();
            this.labelIDNumber = new System.Windows.Forms.Label();
            this.labelIDNumberValue = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelAddressValue = new System.Windows.Forms.Label();
            this.labelLicenseType = new System.Windows.Forms.Label();
            this.labelLicenseTypeValue = new System.Windows.Forms.Label();
            this.listBoxExamIDs = new System.Windows.Forms.ListBox();
            this.headerPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(612, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(463, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TỔNG CỤC ĐƯỜNG BỘ VIỆT NAM";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.cboDriverType);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.cboUnit);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.cboTrainingCenter);
            this.mainPanel.Controls.Add(this.cboCourse);
            this.mainPanel.Controls.Add(this.picUserPhoto);
            this.mainPanel.Controls.Add(this.btnPractice);
            this.mainPanel.Controls.Add(this.labelFullName);
            this.mainPanel.Controls.Add(this.labelFullNameValue);
            this.mainPanel.Controls.Add(this.labelIDNumber);
            this.mainPanel.Controls.Add(this.labelIDNumberValue);
            this.mainPanel.Controls.Add(this.labelAddress);
            this.mainPanel.Controls.Add(this.labelAddressValue);
            this.mainPanel.Controls.Add(this.labelLicenseType);
            this.mainPanel.Controls.Add(this.labelLicenseTypeValue);
            this.mainPanel.Controls.Add(this.listBoxExamIDs);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(612, 456);
            this.mainPanel.TabIndex = 1;
            // 
            // cboDriverType
            // 
            this.cboDriverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDriverType.Location = new System.Drawing.Point(259, 212);
            this.cboDriverType.Name = "cboDriverType";
            this.cboDriverType.Size = new System.Drawing.Size(108, 24);
            this.cboDriverType.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hạng GPLX:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(259, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 22);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kiểm tra thông tin thí sinh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số báo danh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khóa:";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Location = new System.Drawing.Point(259, 95);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(317, 24);
            this.cboUnit.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đơn vị:";
            // 
            // cboTrainingCenter
            // 
            this.cboTrainingCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrainingCenter.Location = new System.Drawing.Point(150, 20);
            this.cboTrainingCenter.Name = "cboTrainingCenter";
            this.cboTrainingCenter.Size = new System.Drawing.Size(300, 24);
            this.cboTrainingCenter.TabIndex = 0;
            // 
            // cboCourse
            // 
            this.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCourse.Location = new System.Drawing.Point(259, 128);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(155, 24);
            this.cboCourse.TabIndex = 1;
            // 
            // picUserPhoto
            // 
            this.picUserPhoto.BackColor = System.Drawing.Color.LightGray;
            this.picUserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUserPhoto.Location = new System.Drawing.Point(20, 100);
            this.picUserPhoto.Name = "picUserPhoto";
            this.picUserPhoto.Size = new System.Drawing.Size(100, 120);
            this.picUserPhoto.TabIndex = 2;
            this.picUserPhoto.TabStop = false;
            // 
            // btnPractice
            // 
            this.btnPractice.Location = new System.Drawing.Point(207, 403);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(100, 30);
            this.btnPractice.TabIndex = 3;
            this.btnPractice.Text = "Vào Ôn luyện";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(160, 260);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(67, 16);
            this.labelFullName.TabIndex = 10;
            this.labelFullName.Text = "Họ và tên:";
            this.labelFullName.Visible = false;
            // 
            // labelFullNameValue
            // 
            this.labelFullNameValue.AutoSize = true;
            this.labelFullNameValue.Location = new System.Drawing.Point(259, 260);
            this.labelFullNameValue.Name = "labelFullNameValue";
            this.labelFullNameValue.Size = new System.Drawing.Size(0, 16);
            this.labelFullNameValue.TabIndex = 11;
            this.labelFullNameValue.Visible = false;
            // 
            // labelIDNumber
            // 
            this.labelIDNumber.AutoSize = true;
            this.labelIDNumber.Location = new System.Drawing.Point(160, 295);
            this.labelIDNumber.Name = "labelIDNumber";
            this.labelIDNumber.Size = new System.Drawing.Size(59, 16);
            this.labelIDNumber.TabIndex = 12;
            this.labelIDNumber.Text = "Số CMT:";
            this.labelIDNumber.Visible = false;
            // 
            // labelIDNumberValue
            // 
            this.labelIDNumberValue.AutoSize = true;
            this.labelIDNumberValue.Location = new System.Drawing.Point(259, 295);
            this.labelIDNumberValue.Name = "labelIDNumberValue";
            this.labelIDNumberValue.Size = new System.Drawing.Size(0, 16);
            this.labelIDNumberValue.TabIndex = 13;
            this.labelIDNumberValue.Visible = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(160, 330);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(50, 16);
            this.labelAddress.TabIndex = 14;
            this.labelAddress.Text = "Địa chỉ:";
            this.labelAddress.Visible = false;
            // 
            // labelAddressValue
            // 
            this.labelAddressValue.AutoSize = true;
            this.labelAddressValue.Location = new System.Drawing.Point(259, 330);
            this.labelAddressValue.Name = "labelAddressValue";
            this.labelAddressValue.Size = new System.Drawing.Size(0, 16);
            this.labelAddressValue.TabIndex = 15;
            this.labelAddressValue.Visible = false;
            // 
            // labelLicenseType
            // 
            this.labelLicenseType.AutoSize = true;
            this.labelLicenseType.Location = new System.Drawing.Point(160, 365);
            this.labelLicenseType.Name = "labelLicenseType";
            this.labelLicenseType.Size = new System.Drawing.Size(73, 16);
            this.labelLicenseType.TabIndex = 16;
            this.labelLicenseType.Text = "Loại GPLX:";
            this.labelLicenseType.Visible = false;
            // 
            // labelLicenseTypeValue
            // 
            this.labelLicenseTypeValue.AutoSize = true;
            this.labelLicenseTypeValue.Location = new System.Drawing.Point(259, 365);
            this.labelLicenseTypeValue.Name = "labelLicenseTypeValue";
            this.labelLicenseTypeValue.Size = new System.Drawing.Size(0, 16);
            this.labelLicenseTypeValue.TabIndex = 17;
            this.labelLicenseTypeValue.Visible = false;
            // 
            // listBoxExamIDs
            // 
            this.listBoxExamIDs.FormattingEnabled = true;
            this.listBoxExamIDs.ItemHeight = 16;
            this.listBoxExamIDs.Location = new System.Drawing.Point(439, 158);
            this.listBoxExamIDs.Name = "listBoxExamIDs";
            this.listBoxExamIDs.Size = new System.Drawing.Size(150, 84);
            this.listBoxExamIDs.TabIndex = 20;
            this.listBoxExamIDs.SelectedIndexChanged += new System.EventHandler(this.listBoxExamIDs_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(612, 456);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thi trắc nghiệm lý thuyết trên máy tính";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private Label lblTitle;
        private Panel mainPanel;
        private ComboBox cboUnit;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private ComboBox cboTrainingCenter;
        private ComboBox cboCourse;
        private Button btnPractice;
        private PictureBox picUserPhoto;
        private Label labelFullName;
        private Label labelFullNameValue;
        private Label labelIDNumber;
        private Label labelAddress;
        private Label labelIDNumberValue;
        private Label labelLicenseType;
        private Label labelLicenseTypeValue;
        private Label txtLicenseType;
        private Label labelAddressValue;
        private Label label4;
        private ComboBox cboDriverType;
        private ListBox listBoxExamIDs;
    }
}


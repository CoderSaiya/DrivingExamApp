using FE.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FE
{
    public partial class LoginForm : Form
    {
        
        private TextBox txtExamCode;
        private ComboBox cboLicenseType;
        private TextBox txtName;
        private TextBox txtDOB;
        private TextBox txtID;
        private TextBox txtAddress;
        private Button btnReview;
        private Button btnCancel;

        private Dictionary<(string, string), Candidate> candidates = new Dictionary<(string, string), Candidate>
        {
            { ("Hạng A", "1"), new Candidate { FullName = "THÍ SINH SỐ 1", IDNumber = "123456789", Address = "VIỆT NAM", DriverType = "A1" } },
            { ("Hạng A", "2"), new Candidate { FullName = "THÍ SINH SỐ 2", IDNumber = "123456789", Address = "VIỆT NAM", DriverType = "A2" } },
            { ("Hạng A", "3"), new Candidate { FullName = "THÍ SINH SỐ 3", IDNumber = "123456789", Address = "VIỆT NAM", DriverType = "A3" } },
            { ("Hạng A", "4"), new Candidate { FullName = "THÍ SINH SỐ 4", IDNumber = "123456789", Address = "VIỆT NAM", DriverType = "A4" } }
        };

        private Dictionary<string, List<DriverType>> examIDsByLicenseType = new Dictionary<string, List<DriverType>>
        {
            { "Hạng A", new List<DriverType>
                {
                    new DriverType { NameType = "Hạng A1", Description = "Số báo danh 1" },
                    new DriverType { NameType = "Hạng A2", Description = "Số báo danh 2" },
                    new DriverType { NameType = "Hạng A1", Description = "Số báo danh 3" }
                }
            },
            { "Hạng B", new List<DriverType>
                {
                    new DriverType { NameType = "Hạng B1", Description = "Số báo danh 1" },
                    new DriverType { NameType = "Hạng B2", Description = "Số báo danh 2" },
                    new DriverType { NameType = "Hạng B3", Description = "Số báo danh 3" }
                }
            },
            { "Hạng C", new List<DriverType>
                {
                    new DriverType { NameType = "Hạng C1", Description = "Số báo danh 1" },
                    new DriverType { NameType = "Hạng C2", Description = "Số báo danh 2" },
                    new DriverType { NameType = "Hạng C3", Description = "Số báo danh 3" }
                }
            },
            { "Hạng D", new List<DriverType>
                {
                    new DriverType { NameType = "Hạng D1", Description = "Số báo danh 1" },
                    new DriverType { NameType = "Hạng D2", Description = "Số báo danh 2" },
                    new DriverType { NameType = "Hạng D3", Description = "Số báo danh 3" }
                }
            }
        };

        public LoginForm()
        {
            InitializeComponent();
            LoadData();
            button1.Click += CheckCandidateInfo;

            cboDriverType.SelectedIndexChanged += listBoxExamIDs_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            cboUnit.Items.Add("Trung tâm Đào tạo & SHLX");
            cboCourse.Items.Add("Tự Luyện Mô tô");
            cboDriverType.Items.Add("Hạng A");
            cboDriverType.Items.Add("Hạng B");
            cboDriverType.Items.Add("Hạng C");
            cboDriverType.Items.Add("Hạng D");
            cboUnit.SelectedIndex = 0;
            cboCourse.SelectedIndex = 0;
        }

        private void CheckCandidateInfo(object sender, EventArgs e)
        {
            string driverType = cboDriverType.SelectedItem.ToString();
            string examCode = textBox1.Text.Trim();

            // Kiểm tra nếu chưa chọn loại GPLX
            if (string.IsNullOrEmpty(driverType))
            {
                MessageBox.Show("Vui lòng chọn loại GPLX!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HideCandidateInfo();
                return;
            }

            // Kiểm tra nếu số báo danh rỗng
            if (string.IsNullOrEmpty(examCode))
            {
                MessageBox.Show("Vui lòng nhập số báo danh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HideCandidateInfo();
                return;
            }

            // Kiểm tra thông tin trong dữ liệu giả lập
            if (candidates.TryGetValue((driverType, examCode), out Candidate candidate))
            {
                // Hiển thị thông tin thí sinh
                labelFullName.Visible = true;
                labelFullNameValue.Visible = true;
                labelFullNameValue.Text = candidate.FullName;

                labelIDNumber.Visible = true;
                labelIDNumberValue.Visible = true;
                labelIDNumberValue.Text = candidate.IDNumber;

                labelAddress.Visible = true;
                labelAddressValue.Visible = true;
                labelAddressValue.Text = candidate.Address;

                labelLicenseType.Visible = true;
                labelLicenseTypeValue.Visible = true;
                labelLicenseTypeValue.Text = candidate.DriverType;
            }
            else
            {
                HideCandidateInfo();
                MessageBox.Show("Không tìm thấy thông tin thí sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HideCandidateInfo()
        {
            labelFullName.Visible = false;
            labelFullNameValue.Visible = false;

            labelIDNumber.Visible = false;
            labelIDNumberValue.Visible = false;

            labelAddress.Visible = false;
            labelAddressValue.Visible = false;

            labelLicenseType.Visible = false;
            labelLicenseTypeValue.Visible = false;
        }

        private void listBoxExamIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDriverType = cboDriverType.SelectedItem?.ToString();
            if (examIDsByLicenseType.TryGetValue(selectedDriverType, out List<DriverType> driverTypes))
            {
                listBoxExamIDs.Items.Clear();
                foreach (var driverType in driverTypes)
                {
                    listBoxExamIDs.Items.Add(driverType.NameType + ": " +driverType.Description);
                }
            }
            else
            {
                listBoxExamIDs.Items.Clear();
            }
        }
    }
}

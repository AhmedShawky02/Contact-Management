using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;
using CountryBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contacts___WinForms
{
    public partial class AddEditContact : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _ContactID;
        private clsContact _Contact;
        public AddEditContact(int ContactID)
        {
            InitializeComponent();
            this._ContactID = ContactID;

            if (_ContactID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }
        private void _LoadData()
        {
            _FillCountriesInComoboBox();
            comboBoxCountry.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                _Contact = new clsContact();
                label1.Text = "Add New Contact";
                this.Text = "Add New Contact";
                this.Icon = new Icon("E:\\ADO.NET\\Contacts - WinForms\\icons\\editing.ico");
                return;
            }

            this.Text = "Edit Contact";
            this.Icon = new Icon("C:\\Users\\Osama-Pc\\Downloads\\add-user-_4_.ico");
            _Contact = clsContact.Find(_ContactID);

            if (_Contact == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _ContactID);
                this.Close();
                return;
            }

            label1.Text = "   Edit Contact ID = " + _ContactID;
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Padding = new Padding(5,0,0,0);
            label1.Size = new Size(350, 60);
            label1.Image = Image.FromFile("C:\\Users\\Osama-Pc\\Downloads\\edit (1).png");
            label1.ImageAlign = ContentAlignment.MiddleLeft;

            textBoxID.Text = _ContactID.ToString();
            textBoxFirstName.Text = _Contact.FirstName;
            textBoxLastName.Text = _Contact.LastName;
            textBoxPhone.Text = _Contact.Phone;
            textBoxEmail.Text = _Contact.Email;
            textBoxAddress.Text = _Contact.Address;
            dateTimePickerDOB.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath != "")
            {
                pictureBox1.Load(_Contact.ImagePath);
            }

            buttonRemoveImage.Visible = (_Contact.ImagePath != "");

            comboBoxCountry.SelectedIndex = comboBoxCountry.FindString(clsCountry.Find(_Contact.CountryID).CountryName);

        }
        private void _FillCountriesInComoboBox()
        {
            DataTable dataTable = clsCountry.GetAllCountry();

            foreach (DataRow row in dataTable.Rows)
            {
                comboBoxCountry.Items.Add(row["CountryName"]);
            }
        }
        private void AddEditContact_Load(object sender, EventArgs e)
        {
             _LoadData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int country = clsCountry.Find(comboBoxCountry.Text).CountryID;

            _Contact.FirstName = textBoxFirstName.Text;
            _Contact.LastName = textBoxLastName.Text;
            _Contact.Email = textBoxEmail.Text;
            _Contact.Phone = textBoxPhone.Text;
            _Contact.Address = textBoxAddress.Text;
            _Contact.DateOfBirth = dateTimePickerDOB.Value;
            _Contact.CountryID = country;

            if (pictureBox1.Image != null)
                _Contact.ImagePath = pictureBox1.ImageLocation;
            else
                _Contact.ImagePath = "";

            if (_Contact.Save())
                MessageBox.Show("Data Saved Successfully.", "Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Mistake", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            _Mode = enMode.Update;


            label1.Text = "   Edit Contact ID = " + _Contact.ContactID.ToString(); 
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Padding = new Padding(5, 0, 0, 0);
            label1.Size = new Size(350, 60);
            label1.Image = Image.FromFile("E:\\ADO.NET\\Contacts - WinForms\\icons\\edit (1).png");
            label1.ImageAlign = ContentAlignment.MiddleLeft;


            textBoxID.Text = _Contact.ContactID.ToString();

        }



        private void buttonRemoveImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            buttonRemoveImage.Visible = false;
        }

        private void buttonSetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Filter = "Image Files|*.jpeg;";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;

                pictureBox1.Load(selectedFilePath);

                buttonRemoveImage.Visible = true;
            }
        }
    }
}
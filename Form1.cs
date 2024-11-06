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

namespace Contacts___WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void _RefreshContactsList()
        {
            dataGridView1.DataSource = clsContact.GetAllContacts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditContact frm = new AddEditContact((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            _RefreshContactsList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditContact frm = new AddEditContact(-1);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            _RefreshContactsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete contact [ " + dataGridView1.CurrentRow.Cells[0].Value + " ]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                //Perform Delele and refresh
                if (clsContact.DeleteContact((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Data Saved Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshContactsList();
                }

                else
                    MessageBox.Show("Contact is not deleted.", "Mistake", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}

namespace Contacts___WinForms
{
    partial class AddEditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditContact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbDoB = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.buttonSetImage = new System.Windows.Forms.Button();
            this.buttonRemoveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(139, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            this.lbID.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbID.Location = new System.Drawing.Point(446, 113);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(77, 39);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID : ";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstName.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbFirstName.Location = new System.Drawing.Point(446, 188);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(195, 39);
            this.lbFirstName.TabIndex = 2;
            this.lbFirstName.Text = "First Name :";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.Color.Transparent;
            this.lbLastName.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbLastName.Location = new System.Drawing.Point(785, 188);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(187, 39);
            this.lbLastName.TabIndex = 3;
            this.lbLastName.Text = "Last Name :";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbEmail.Location = new System.Drawing.Point(446, 263);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(121, 39);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email :";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.Transparent;
            this.lbPhone.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPhone.Location = new System.Drawing.Point(785, 263);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(124, 39);
            this.lbPhone.TabIndex = 5;
            this.lbPhone.Text = "Phone :";
            // 
            // lbDoB
            // 
            this.lbDoB.AutoSize = true;
            this.lbDoB.BackColor = System.Drawing.Color.Transparent;
            this.lbDoB.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbDoB.Location = new System.Drawing.Point(446, 338);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(225, 39);
            this.lbDoB.TabIndex = 6;
            this.lbDoB.Text = "Date Of Birth :";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.BackColor = System.Drawing.Color.Transparent;
            this.lbCountry.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCountry.Location = new System.Drawing.Point(785, 338);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(151, 39);
            this.lbCountry.TabIndex = 7;
            this.lbCountry.Text = "Country :";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbAddress.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAddress.Location = new System.Drawing.Point(446, 413);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(152, 39);
            this.lbAddress.TabIndex = 9;
            this.lbAddress.Text = "Address :";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(453, 229);
            this.textBoxFirstName.MaxLength = 10;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(270, 31);
            this.textBoxFirstName.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(792, 229);
            this.textBoxLastName.MaxLength = 10;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(270, 31);
            this.textBoxLastName.TabIndex = 11;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(792, 305);
            this.textBoxPhone.MaxLength = 11;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(270, 31);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(453, 305);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(270, 31);
            this.textBoxEmail.TabIndex = 12;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(453, 457);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(270, 101);
            this.textBoxAddress.TabIndex = 16;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(453, 155);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(270, 31);
            this.textBoxID.TabIndex = 8;
            this.textBoxID.Text = "???";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Baloo", 18F, System.Drawing.FontStyle.Bold);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(954, 450);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(149, 51);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(415, 33);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(337, 60);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add New Contact";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Baloo", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(781, 450);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(149, 51);
            this.button3.TabIndex = 21;
            this.button3.Text = "Save";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(453, 384);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(270, 31);
            this.dateTimePickerDOB.TabIndex = 22;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(792, 383);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(270, 33);
            this.comboBoxCountry.TabIndex = 23;
            // 
            // buttonSetImage
            // 
            this.buttonSetImage.AutoSize = true;
            this.buttonSetImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetImage.Font = new System.Drawing.Font("Baloo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetImage.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetImage.Image")));
            this.buttonSetImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetImage.Location = new System.Drawing.Point(187, 136);
            this.buttonSetImage.Name = "buttonSetImage";
            this.buttonSetImage.Padding = new System.Windows.Forms.Padding(5);
            this.buttonSetImage.Size = new System.Drawing.Size(154, 50);
            this.buttonSetImage.TabIndex = 25;
            this.buttonSetImage.Text = "Set Image";
            this.buttonSetImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSetImage.UseVisualStyleBackColor = true;
            this.buttonSetImage.Click += new System.EventHandler(this.buttonSetImage_Click);
            // 
            // buttonRemoveImage
            // 
            this.buttonRemoveImage.AutoSize = true;
            this.buttonRemoveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveImage.Font = new System.Drawing.Font("Baloo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveImage.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveImage.Image")));
            this.buttonRemoveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveImage.Location = new System.Drawing.Point(163, 450);
            this.buttonRemoveImage.Name = "buttonRemoveImage";
            this.buttonRemoveImage.Padding = new System.Windows.Forms.Padding(5);
            this.buttonRemoveImage.Size = new System.Drawing.Size(203, 50);
            this.buttonRemoveImage.TabIndex = 26;
            this.buttonRemoveImage.Text = "Remove Image";
            this.buttonRemoveImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRemoveImage.UseVisualStyleBackColor = true;
            this.buttonRemoveImage.Visible = false;
            this.buttonRemoveImage.Click += new System.EventHandler(this.buttonRemoveImage_Click);
            // 
            // AddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 597);
            this.Controls.Add(this.buttonRemoveImage);
            this.Controls.Add(this.buttonSetImage);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbDoB);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddEditContact";
            this.Text = "AddEditContact";
            this.Load += new System.EventHandler(this.AddEditContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbDoB;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Button buttonSetImage;
        private System.Windows.Forms.Button buttonRemoveImage;
    }
}
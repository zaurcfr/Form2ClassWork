using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2ClassWork
{
    public partial class Form1 : Form
    {
        void ClearTextbox()
        {
            nameTxtb.Clear();
            surnameTxtb.Clear();
            emailTxtb.Clear();
            phoneMtxtb.Clear();
        }
        void ChangeButtons(string btn)
        {
            if (btn == "add")
            {
                addBtn.Location = new Point(269, 355);
                changeBtn.Location = new Point(295, 290);
                addBtn.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                changeBtn.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                addBtn.Size = new Size(131, 66);
                changeBtn.Size = new Size(105, 42);
                addBtn.AutoSize = true;
                changeBtn.AutoSize = true;
            }
            else if (btn=="change")
            {
                changeBtn.Location = new Point(269, 355);
                addBtn.Location = new Point(295, 290);
                changeBtn.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                addBtn.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                changeBtn.Size = new Size(131, 66);
                addBtn.Size = new Size(105, 42);
                changeBtn.AutoSize = true;
                addBtn.AutoSize = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            usersLstb.DisplayMember = "Name";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            usersLstb.Items.Add(new User
            {
                Name = nameTxtb.Text,
                Surname = surnameTxtb.Text,
                Email = emailTxtb.Text,
                Phone = phoneMtxtb.Text,
                BirthDate = birthdateDtp.Value
            });
            ClearTextbox();
            ChangeButtons("add");
        }

        private void usersLstb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = usersLstb.SelectedItem;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (fileTxtb.Text != "") FileHelper.JsonSerialize(fileTxtb.Text, usersLstb.SelectedItem as User);
            else FileHelper.JsonSerialize((usersLstb.SelectedItem as User)?.Name, usersLstb.SelectedItem as User);
            ClearTextbox();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var obj = usersLstb.SelectedItem as User;
            var p = FileHelper.JsonDeserialize((obj)?.Name);
            nameTxtb.Text = p.Name;
            surnameTxtb.Text = p.Surname;
            emailTxtb.Text = p.Email;
            phoneMtxtb.Text = p.Phone;
            birthdateDtp.Value = p.BirthDate;
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = nameTxtb.Text,
                Surname = surnameTxtb.Text,
                Email = emailTxtb.Text,
                Phone = phoneMtxtb.Text,
                BirthDate = birthdateDtp.Value
            };
            FileHelper.JsonSerialize(nameTxtb.Text, user);
            ClearTextbox();
            ChangeButtons("change");
        }
    }
}

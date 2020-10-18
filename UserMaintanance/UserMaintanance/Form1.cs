﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintanance.Entities;

namespace UserMaintanance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource.FullName; // label1
            //lblFirstName.Text = Resource.FirstName; // label2
            btnAdd.Text = Resource.Add; // button1
            btnWriteToFile.Text = Resource.WriteToFile;
            btnDelete.Text = Resource.Delete;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text,
            //    FirstName = txtFirstName.Text
            };
            users.Add(u);
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.DefaultExt = "csv";
            sfd.FileName = ".csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var s in users)
                {
                    sw.Write(s.ID);
                    sw.Write(";");
                    sw.WriteLine(s.FullName);

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedIndex != -1)
            {
                users.RemoveAt(listUsers.SelectedIndex);
            }
        }
    }
}

using Project.BLL.GenericReporsitory.ConcRep;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI.Admin.User
{
    public partial class Guncelle : Form
    {
        AppUserReporsitory _auRep;
        public Guncelle()
        {
            _auRep = new AppUserReporsitory();
            InitializeComponent();
        }

        private void Guncelle_Load(object sender, EventArgs e)
        {
            AppUserRole[] roleDizisi = (AppUserRole[])Enum.GetValues(typeof(AppUserRole));

            foreach (AppUserRole renk in roleDizisi)
            {
                comboBox1.Items.Add(renk);
            }
        }

        AppUser secim;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secim.FirstName=txtFirsName.Text;
            secim.LastName=txtLastName.Text;
            secim.UserName=txtUserName.Text;
            secim.Passaword=txtPassword.Text;
            secim.Role = (AppUserRole)comboBox1.SelectedItem;
            _auRep.Update(secim);
        }
        

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                secim = listBox1.SelectedItem as AppUser;
                txtFirsName.Text = secim.FirstName;
                txtLastName.Text = secim.LastName;
                txtUserName.Text = secim.UserName;
                txtPassword.Text = secim.Passaword;
                comboBox1.Text = secim.Role.ToString();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = _auRep.GetAll().ToList();
        }

        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = $"{(e.ListItem as AppUser).UserName} {(e.ListItem as AppUser).Status}";
        }
    }
}

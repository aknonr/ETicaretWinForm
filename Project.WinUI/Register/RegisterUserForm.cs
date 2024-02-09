using Project.BLL.GenericReporsitory.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI.RegisterUser
{
    public partial class RegisterUserForm : Form
    {
        AppUserReporsitory _auRep;
        public RegisterUserForm()
        {
            InitializeComponent();
            _auRep = new AppUserReporsitory();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_auRep.Any(x => x.UserName == txtUserNamr.Text.ToLower()))
                    MessageBox.Show("Bu UserName Mevcut farklı bir UserName giriniz");
                else
                {
                    AppUserEkle(txtUserNamr.Text.ToLower(), txtPassaword.Text, txtFirstName.Text, txtLastName.Text);
                    Close();
                }
            }
            catch 
            {

                MessageBox.Show("Boş alan birakma kanka");
            }


        }
        public void AppUserEkle(string userName,string passaword,string firstName,string lastName)
        {
            AppUser appUser = new AppUser { UserName = userName, Passaword = passaword, FirstName = firstName, LastName = lastName, Role = ENTITIES.Enums.AppUserRole.UserSilver };
            _auRep.Add(appUser);
        }
    }
}

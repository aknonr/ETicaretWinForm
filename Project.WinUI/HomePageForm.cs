using Project.BLL.GenericReporsitory.ConcRep;
using Project.ENTITIES.Models;
using Project.WinUI.Admin;
using Project.WinUI.Register;
using Project.WinUI.RegisterUser;
using Project.WinUI.Seller;
using Project.WinUI.SilverUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project.WinUI.NewFolder1
{
    public partial class HomePageForm : Form
    {
        AppUserReporsitory _auRep;
        public HomePageForm()
        {
            _auRep = new AppUserReporsitory();
            InitializeComponent();
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUserForm registerUserForm = new RegisterUserForm();
            registerUserForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_auRep.Any(x => x.UserName == txtUserNamr.Text) && _auRep.Any(x => x.Passaword == txtPassaword.Text))
            {
                if (_auRep.UserNameAra(txtUserNamr.Text).Role == ENTITIES.Enums.AppUserRole.UserAdmin)
                {
                    AdminKullaniciForm admin = new AdminKullaniciForm();
                    admin.ShowDialog();
                }
                else if (_auRep.UserNameAra(txtUserNamr.Text).Role == ENTITIES.Enums.AppUserRole.UserSeller)
                {
                    SellerForm seller = new SellerForm();
                    seller.ShowDialog();
                }
                else if (_auRep.UserNameAra(txtUserNamr.Text).Role == ENTITIES.Enums.AppUserRole.UserSilver)
                {
                    SilverUserForm user = new SilverUserForm();
                    user.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Boyle Bir kullanıcı bulunamadı");
            }
        }

        private void btnFirmaKayit_Click(object sender, EventArgs e)
        {
            RegisterSeller registerSeller = new RegisterSeller();
            registerSeller.ShowDialog();
        }
    }
}

using Project.BLL.GenericReporsitory.ConcRep;
using Project.ENTITIES.Models;
using Project.WinUI.Admin.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI.Admin
{
    public partial class AdminKullaniciForm : Form
    {

        AppUserReporsitory _auRep;
        public AdminKullaniciForm()
        {

            _auRep = new AppUserReporsitory();
            InitializeComponent();
        }

        private void btnAktifKullanici_Click(object sender, EventArgs e)
        {
            AktifKullanici();
        }
        public void AktifKullanici()
        {
            dataGridView1.DataSource = _auRep.GetActives();
            listBox1.DataSource = _auRep.GetActives().ToList();

        }

        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = $"{(e.ListItem as AppUser).UserName}";
        }

        private void btnKullaniciAyar_Click(object sender, EventArgs e)
        {
            Guncelle guncelle = new Guncelle();
            guncelle.ShowDialog();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _auRep.GetAll();
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _auRep.GetPassives();
        }
    }
}

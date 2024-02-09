using Project.BLL.GenericReporsitory.ConcRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI.Seller
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
            _cRep = new CategoryReporsitory();
            _pRep = new ProductRepository();
        }
        CategoryReporsitory _cRep;
        ProductRepository _pRep;

        public void UrunEkle(int id, string product,decimal  price  )
        {
            Product p = new Product {
                ID = id,
                ProductName = product ,
                UnitPrice = price ,
               
            };
            _pRep.Add(p);

        }
        public void KategoryEkle(string name)
        {

            Category c = new Category { CategoryName = name };
            _cRep.Add(c);

        }

        private void btnCategoryEkle_Click(object sender, EventArgs e)
        {
            KategoryEkle(txtCategoryEkle.Text);
            
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUrunID.Text);    
           string product=txtUrunName.Text;
            decimal price=decimal.Parse(txtUrunFiyat.Text);
            UrunEkle(id, product, price);

        }

       

        private void KategoriGoster()
        {
            lstSeller.DataSource = _cRep.GetActives();
        }
        private void btnEklemeleriGor_Click(object sender, EventArgs e)
        {
            Category c = new Category
            {
                CategoryName = txtCategoryEkle.Text
            };
            _cRep.Add(c);
            KategoriGoster();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          
            KategoriGoster();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNorthwind.DataAccess;

namespace TheNorthwind.CategoryAndProduct
{
    public partial class CategoryAndProductForm : Form
    {
        public CategoryAndProductForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var context = new NorthWindContext();

            var category = new Category()
            {
                CategoryName = txtCategoryName.Text.Trim()
            };

            //context.Categories.Add(category);
            //context.SaveChanges();

            var product = new Product()
            {
                ProductName = txtProductName.Text.Trim(),
                UnitPrice = numUnitPrice.Value,

                // Henüz veritabanında olmayan, SaveChanges ile oluşacak olan bu Category'ye ürün
                // kaydedebilirim. Bu işlem için Product üzerindeki Category navigation property'sini
                // kullanırım. CategoryId property'sini kullanamam çünkü veritabanında o kategori
                // henüz yok!!
                Category = category
                //CategoryId = category.CategoryId
            };

            // Biz her ne kadar product nesnesini context ChangeTracker'a tanıtmış olsak da
            // product üzerindeki Category nesnesi context için yine yeni bir nesne olmasından dolayı
            // ChangeTracker category nesnesini de izlemeye başlar
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}

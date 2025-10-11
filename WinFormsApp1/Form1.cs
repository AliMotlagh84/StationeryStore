using StationeryStore.DataLayer.Models;
using StationeryStoreDataLayer.UnitOfWorks;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BindGrid()
        {
            using (EfUnitOfWork EfDb = new EfUnitOfWork())
            {
                dataGridView1.DataSource = EfDb.ProductsRepository.GetAll();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
            //using (EfUnitOfWork EfDb = new EfUnitOfWork())
            //{
            //    BrandsTable firstBrand = new BrandsTable()
            //    {
            //        BrandName = "FabelCastle",
            //    };
            //    EfDb.BrandRepository.Add(firstBrand);
            //    EfDb.Save();
            //}
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (EfUnitOfWork EfDb = new EfUnitOfWork())
            {
                var x = new ProductsTable()
                {
                    BrandId = 1,
                    BrandName = "FabelCastle",
                    Amount = 120000000,
                    Count = 4,
                    ProductName = "Test",

                };
                EfDb.ProductsRepository.Add(x);
                EfDb.Save();
                BindGrid();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (EfUnitOfWork EfDb = new EfUnitOfWork())
            {
                //var x = new ProductsTable()
                //{
                //    BrandId = 1,
                //    BrandName = "FabelCastle",
                //    Amount = 120000000,
                //    Count = 4,
                //    ProductName = "Test",

                //};
                EfDb.ProductsRepository.Delete(2);
                EfDb.Save();
                BindGrid();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (EfUnitOfWork EfDb = new EfUnitOfWork())
            {
                var x = new ProductsTable()
                {
                    BrandId = 1,
                    BrandName = "FabelCastle",
                    Amount = 12000,
                    Count = 2,
                    ProductName = "Pencil",
                    ProductId = 3,

                };
                EfDb.ProductsRepository.Update(x);
                EfDb.Save();
                BindGrid();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (EfUnitOfWork EfDb = new EfUnitOfWork())
            {
                dataGridView1.DataSource = EfDb.ProductsRepository.GetAll(c => c.Count ==int.Parse(textBox1.Text));
            }
        }
    }
}

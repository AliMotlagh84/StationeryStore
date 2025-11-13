using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Deleters.BrandDeleters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreAppLayer.Forms.ManagerForms.BrandsManagerForm
{
    public partial class BrandsManagerForm : Form, IBrandManagerForm,
        IBrandDeleter,
        IDgFiller
    {
        private IBrandDataGeter _brandDataGeter;
        private IBrandDeleter _brandDeleter;
        private IDgFiller _dgFiller;
        public BrandsManagerForm(
            IBrandDataGeter brandDataGeter,
            IBrandDeleter brandDeleter,
            IDgFiller dgFiller
            )
        {
            _brandDataGeter = brandDataGeter;
            _brandDeleter = brandDeleter;
            _dgFiller = dgFiller;
            InitializeComponent();
        }

        public List<BrandsTable> GetBrandsData()
        {
            return _brandDataGeter.GetBrandsData();
        }

        private void BrandsManagerForm_Load(object sender, EventArgs e)
        {
            FillDg(BrandsDg, GetBrandsData());
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public void DeleteBrand(BrandsTable brand)
        {
            _brandDeleter.DeleteBrand(brand);
        }

        public void DeleteBrand(object brandId)
        {
            _brandDeleter.DeleteBrand(brandId);
        }

        private void DeleteBrandBtn_Click(object sender, EventArgs e)
        {
            if (BrandsDg.CurrentRow != null)
            {

                if (MessageBox.Show($"از حذف {(string)BrandsDg.CurrentRow.Cells[1].Value} مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteBrand((int)BrandsDg.CurrentRow.Cells[0].Value);

                }
            }
            else
            {
                MessageBox.Show("برندی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

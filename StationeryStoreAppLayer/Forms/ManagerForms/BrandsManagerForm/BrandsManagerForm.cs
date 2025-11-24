using StationeryStoreAppLayer.Forms.ManagerForms.BrandsManagerForm.BrandManagerHelpers.FormOpeners;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.BrandDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.BrandsDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Deleters.BrandDeleters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreAppLayer.PublicHelpers.Restartors.TextBoxRestartors;
using StationeryStoreAppLayer.PublicHelpers.Searchers.BrandsSearcher;
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
        IBrandSearcher,
        IBrandDataBuilder,
        IDgFiller,
        ITextBoxRestartor,
        IBrandAdderOrEditorFormOpener
    {
        private IBrandDataGeter _brandDataGeter;
        private IBrandDataBuilder _brandDataBuilder;
        private IBrandDeleter _brandDeleter;
        private IBrandSearcher _brandSearcher;
        private IDgFiller _dgFiller;
        private ITextBoxRestartor _textBoxRestartor;
        private IBrandAdderOrEditorFormOpener _brandAdderOrEditorFormOpener;
        public BrandsManagerForm(
            IBrandDataGeter brandDataGeter,
            IBrandDataBuilder brandDataBuilder,
            IBrandDeleter brandDeleter,
            IBrandSearcher brandSearcher,
            IDgFiller dgFiller,
            ITextBoxRestartor textBoxRestartor,
            IBrandAdderOrEditorFormOpener brandAdderOrEditorFormOpener
            )
        {
            InitializeComponent();
            _brandDataGeter = brandDataGeter;
            _brandDataBuilder = brandDataBuilder;
            _brandSearcher = brandSearcher;
            _brandDeleter = brandDeleter;
            _dgFiller = dgFiller;
            _textBoxRestartor = textBoxRestartor;
            _brandAdderOrEditorFormOpener = brandAdderOrEditorFormOpener;

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
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("برندی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BrandsSearchBtn_Click(object sender, EventArgs e)
        {
            FillDg(BrandsDg, SearchInBrands(GetBrandsData(), null, txtBrandName.Text));
        }

        public List<BrandsTable> SearchInBrands(IEnumerable<BrandsTable> brands, int? brandId = null, string? brandName = null)
        {
            return _brandSearcher.SearchInBrands(brands, brandId, brandName);
        }

        public void RestartTextBox(params TextBox[] textBoxes)
        {
            _textBoxRestartor.RestartTextBox(textBoxes);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        void RefreshForm()
        {
            FillDg(BrandsDg, GetBrandsData());
            RestartTextBox(txtBrandName);
        }

        private void BrandUpdateBtn_Click(object sender, EventArgs e)
        {
            if (BrandsDg.CurrentRow != null)
            {
                var brandData = BuildBrandData((string)BrandsDg.CurrentRow.Cells[1].Value, (int)BrandsDg.CurrentRow.Cells[0].Value);
                OpenBrandAdderOrEditorForm(this,true,brandData);
                RefreshForm();
            }
            else
            {
                MessageBox.Show("برندی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public BrandsTable BuildBrandData(string brandName, int? BrandIdForEdit = null)
        {
            return _brandDataBuilder.BuildBrandData(brandName, BrandIdForEdit);
        }

        private void AddBrandBtn_Click(object sender, EventArgs e)
        {
            if (BrandsDg.CurrentRow != null)
            {
                OpenBrandAdderOrEditorForm(this,false);
                RefreshForm();
            }
            else
            {
                MessageBox.Show("برندی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void OpenBrandAdderOrEditorForm(Form senderForm, bool editMode, BrandsTable brandInfoForTrueEditMode = null)
        {
            _brandAdderOrEditorFormOpener.OpenBrandAdderOrEditorForm(senderForm, editMode, brandInfoForTrueEditMode);
        }
    }
}

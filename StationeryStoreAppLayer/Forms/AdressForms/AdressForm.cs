using StationeryStoreUILayer.Forms.AdressForms.AdressFormHelpers.FormOpeners;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.AdressDataBuilders;
using StationeryStoreUILayer.PublicHelpers.DataDeleter.AdressDataDeleters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.AdressForms
{
    public partial class AdressForm : Form, IAdressForm,
        IAdressesDataGeter,
        IAdressSearcher,
        IAdressDataBuilder,
        IAdressDataDeleter,
        IDgFiller,
        IAdressAdderOrEditorFormOpener
    {
        private IAdressesDataGeter _adressesDataGeter;
        private IAdressDataBuilder _adressDataBuilder;
        private IAdressSearcher _adressSearcher;
        private IAdressDataDeleter _adressDataDeleter;
        private IDgFiller _dgFiller;
        private IAdressAdderOrEditorFormOpener _adressAdderOrEditorFormOpener;
        public AdressForm(
            IAdressDataBuilder adressDataBuilder,
            IAdressesDataGeter adressesDataGeter,
            IAdressSearcher adressSearcher,
            IAdressDataDeleter adressDataDeleter,
            IDgFiller dgFiller,
            IAdressAdderOrEditorFormOpener adressAdderOrEditorFormOpener
            )
        {
            InitializeComponent();
            _adressesDataGeter = adressesDataGeter;
            _adressDataBuilder = adressDataBuilder;
            _adressSearcher = adressSearcher;
            _adressDataDeleter = adressDataDeleter;
            _dgFiller = dgFiller;
            _adressAdderOrEditorFormOpener = adressAdderOrEditorFormOpener;

        }

        private UserTable userInfo { get; set; }
        UserTable IAdressForm.UserInfo { get => userInfo; set => userInfo = value; }

        private void AdressForm_Load(object sender, EventArgs e)
        {
            FillDg(AdressDG, SearchInAdresses(GetAdressesData(), null, userInfo.UserId));

        }

        private void AddNewAdressBtn_Click(object sender, EventArgs e)
        {
            OpenAdressAdderOrEditorForm(this, userInfo, false);
            RefreshForm();
        }

        private void RefreshForm()
        {
            FillDg(AdressDG, SearchInAdresses(GetAdressesData(), null, userInfo.UserId));

        }

        public void OpenAdressAdderOrEditorForm(Form senderForm, UserTable userInfo, bool editMode, AdressTable adressTableForTrueEditMode = null)
        {
            _adressAdderOrEditorFormOpener.OpenAdressAdderOrEditorForm(senderForm, userInfo, editMode, adressTableForTrueEditMode);
        }

        public AdressTable BuildAdressData(int userId, string userName, string city, string street, string alley, string houseNumber, long postalCode, int? adressIdForEdit = null)
        {
            return _adressDataBuilder.BuildAdressData(userId, userName, city, street, alley, houseNumber, postalCode, adressIdForEdit);
        }

        public List<AdressTable> GetAdressesData()
        {
            return _adressesDataGeter.GetAdressesData();
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }

        public List<AdressTable> SearchInAdresses(IEnumerable<AdressTable> adresses, object? adressId = null, object? userId = null, string? userName = null, string? city = null, string? street = null, string? alley = null, string? houseNumber = null, long? postalCode = null)
        {
            return _adressSearcher.SearchInAdresses(adresses, adressId, userId, userName, city, street, alley, houseNumber, postalCode);
        }

        private void DeleteAdressBtn_Click(object sender, EventArgs e)
        {
            if (AdressDG.CurrentRow != null)
            {
                var DgcurrentRowCells = AdressDG.CurrentRow.Cells;
                if (MessageBox.Show($"از حذف این آدرس مطمئن هستید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteAdressData(DgcurrentRowCells[0].Value);
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("آدرسی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteAdressData(object id)
        {
            _adressDataDeleter.DeleteAdressData(id);
        }

        public void DeleteAdressData(AdressTable adress)
        {
            _adressDataDeleter.DeleteAdressData(adress);

        }

        private void DeleteAllAdressesBtn_Click(object sender, EventArgs e)
        {
            if (AdressDG.CurrentRow != null)
            {

                if (MessageBox.Show($"آیا میخواهید همه ی آدرس ها را حذف کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    var Adresses = SearchInAdresses(GetAdressesData(), null, userInfo.UserId);
                    foreach (var Adress in Adresses)
                    {
                        DeleteAdressData(Adress);
                    }
                    RefreshForm();
                }
            }
            else
            {
                MessageBox.Show("آدرسی وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAdressBtn_Click(object sender, EventArgs e)
        {
            if (AdressDG.CurrentRow != null)
            {
                var DgCurrentRowCells = AdressDG.CurrentRow.Cells;
                AdressTable adressInfo = BuildAdressData((int)DgCurrentRowCells[1].Value, (string)DgCurrentRowCells[2].Value, (string)DgCurrentRowCells[3].Value,(string)DgCurrentRowCells[4].Value, (string)DgCurrentRowCells[5].Value,(string)DgCurrentRowCells[6].Value,(long)DgCurrentRowCells[7].Value, (int)DgCurrentRowCells[0].Value);
                OpenAdressAdderOrEditorForm(this, userInfo, true, adressInfo);
                RefreshForm();
            }
            else{
                MessageBox.Show("آدرسی انتخاب نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

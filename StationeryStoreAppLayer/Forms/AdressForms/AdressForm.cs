using StationeryStoreAppLayer.Forms.AdressForms.AdressFormHelpers.FormOpeners;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.AdressDataBuilders;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.AdressDataGeters;
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

namespace StationeryStoreAppLayer.Forms.AdressForms
{
    public partial class AdressForm : Form, IAdressForm,
        IAdressesDataGeter,
        IAdressDataBuilder,
        IDgFiller,
        IAdressAdderOrEditorFormOpener
    {
        private IAdressesDataGeter _adressesDataGeter;
        private IAdressDataBuilder _adressDataBuilder;
        private IDgFiller _dgFiller;
        private IAdressAdderOrEditorFormOpener _adressAdderOrEditorFormOpener;
        public AdressForm(
            IAdressDataBuilder adressDataBuilder,
            IAdressesDataGeter adressesDataGeter,
            IDgFiller dgFiller,
            IAdressAdderOrEditorFormOpener adressAdderOrEditorFormOpener
            )
        {
            InitializeComponent();
            _adressesDataGeter = adressesDataGeter;
            _adressDataBuilder = adressDataBuilder;
            _dgFiller = dgFiller;
            _adressAdderOrEditorFormOpener = adressAdderOrEditorFormOpener;
            
        }

        private UserTable userInfo { get; set; }
        UserTable IAdressForm.UserInfo { get => userInfo; set => userInfo = value; }

        private void AdressForm_Load(object sender, EventArgs e)
        {
            FillDg(AdressDG, GetAdressesData());
        }

        private void AddNewAdressBtn_Click(object sender, EventArgs e)
        {
            OpenAdressAdderOrEditorForm(this, userInfo,false);
            RefreshForm();
        }

        private void RefreshForm()
        {
            FillDg(AdressDG, GetAdressesData());

        }

        public void OpenAdressAdderOrEditorForm(Form senderForm, UserTable userInfo, bool editMode, AdressTable adressTableForTrueEditMode = null)
        {
            _adressAdderOrEditorFormOpener.OpenAdressAdderOrEditorForm(senderForm, userInfo, editMode, adressTableForTrueEditMode);
        }

        public AdressTable BuildAdressData(int userId, string userName, string city, string street, string alley, string houseNumber, long postalCode, int? adressIdForEdit = null)
        {
           return _adressDataBuilder.BuildAdressData(userId,userName,city,street,alley,houseNumber,postalCode,adressIdForEdit);
        }

        public List<AdressTable> GetAdressesData()
        {
           return _adressesDataGeter.GetAdressesData();
        }

        public void FillDg<T>(DataGridView dg, List<T> data)
        {
            _dgFiller.FillDg(dg, data);
        }
    }
}

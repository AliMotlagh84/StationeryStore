using StationeryStoreAppLayer.Forms.AdressForms.AdressFormHelpers.FormOpeners;
using StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreAppLayer.PublicHelpers.Searchers.AdressSearchers;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ShoppingCartForms.SoppingCartHelpers.AdressFormChooserOpeningHandlers
{
    public class AdressChooserFormOpeningHandler : IAdressChooserFormOpeningHandler,
        IAdressAdderOrEditorFormOpener,
        IAdressChooserFormOpener,
        IAdressesDataGeter,
        IAdressSearcher
    {
        private IAdressAdderOrEditorFormOpener _adressAdderOrEditorFormOpener;
        private IAdressChooserFormOpener _adressChooserFormOpener;
        private IAdressesDataGeter _adressesDataGeter;
        private IAdressSearcher _adressesSearcher;

        public AdressChooserFormOpeningHandler(
            IAdressAdderOrEditorFormOpener adressAdderOrEditorFormOpener,
            IAdressChooserFormOpener adressChooserFormOpener,
            IAdressesDataGeter adressesDataGeter,
            IAdressSearcher adressesSearcher
            )
        {
            _adressAdderOrEditorFormOpener = adressAdderOrEditorFormOpener;
            _adressChooserFormOpener = adressChooserFormOpener;
            _adressesDataGeter = adressesDataGeter;
            _adressesSearcher = adressesSearcher;
        }

        public List<AdressTable> GetAdressesData()
        {
            return _adressesDataGeter.GetAdressesData();
        }

        public void HandleAdressChooserFormOpening(Form HandlerForm, UserTable userInfo)
        {
            var adresses = SearchInAdresses(GetAdressesData(), null, userInfo.UserId);
            if (adresses.Count <= 0)
            {
                OpenAdressAdderOrEditorForm(HandlerForm, userInfo, false);
                adresses = SearchInAdresses(GetAdressesData(), null, userInfo.UserId);
                if (adresses.Count > 0)
                {
                    HandlerForm.Hide();
                    OpenAdressChooserForm(HandlerForm, userInfo);
                }
                else{
                   MessageBox.Show("باید حداقل یک آدرس داشته باشید تا بتوانید سفارش خود را ثبت کنید","توجه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                OpenAdressChooserForm(HandlerForm, userInfo);
            }
        }

        public void OpenAdressAdderOrEditorForm(Form senderForm, UserTable userInfo, bool editMode, AdressTable adressTableForTrueEditMode = null)
        {
            _adressAdderOrEditorFormOpener.OpenAdressAdderOrEditorForm(senderForm, userInfo, editMode, adressTableForTrueEditMode);
        }

        public void OpenAdressChooserForm(Form senderForm, UserTable userInfo)
        {
            _adressChooserFormOpener.OpenAdressChooserForm(senderForm, userInfo);
        }

        public List<AdressTable> SearchInAdresses(IEnumerable<AdressTable> adresses, object? adressId = null, object? userId = null, string? userName = null, string? city = null, string? street = null, string? alley = null, string? houseNumber = null, long? postalCode = null)
        {
            return _adressesSearcher.SearchInAdresses(adresses, adressId, userId, userName, city, street, alley, houseNumber, postalCode);
        }
    }
}

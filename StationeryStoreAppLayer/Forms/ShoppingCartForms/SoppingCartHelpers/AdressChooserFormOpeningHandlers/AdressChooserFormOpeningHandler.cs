using StationeryStoreUILayer.Forms.AdressForms.AdressFormHelpers.FormOpeners;
using StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.FormOpeners;
using StationeryStoreUILayer.PublicHelpers.DataGeters.AdressDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.AdressSearchers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StationeryStoreUILayer.PublicHelpers.DataGeters.DraftOrderDataGeters;
using StationeryStoreUILayer.PublicHelpers.Searchers.DraftOrderSearchers;

namespace StationeryStoreUILayer.Forms.ShoppingCartForms.SoppingCartHelpers.AdressFormChooserOpeningHandlers
{
    public class AdressChooserFormOpeningHandler : IAdressChooserFormOpeningHandler,
        IAdressAdderOrEditorFormOpener,
        IAdressChooserFormOpener,
        IAdressesDataGeter,
        IAdressSearcher,
        IDraftOrderDataGeter,
        IDraftOrderSearcher
    {
        private IAdressAdderOrEditorFormOpener _adressAdderOrEditorFormOpener;
        private IAdressChooserFormOpener _adressChooserFormOpener;
        private IAdressesDataGeter _adressesDataGeter;
        private IAdressSearcher _adressesSearcher;
        private IDraftOrderDataGeter _draftOrderDataGeter;
        private IDraftOrderSearcher _draftOrderSearcher;
        

        public AdressChooserFormOpeningHandler(
            IAdressAdderOrEditorFormOpener adressAdderOrEditorFormOpener,
            IAdressChooserFormOpener adressChooserFormOpener,
            IAdressesDataGeter adressesDataGeter,
            IAdressSearcher adressesSearcher,
            IDraftOrderDataGeter draftOrderDataGeter,
            IDraftOrderSearcher draftOrderSearcher
            )
        {
            _adressAdderOrEditorFormOpener = adressAdderOrEditorFormOpener;
            _adressChooserFormOpener = adressChooserFormOpener;
            _adressesDataGeter = adressesDataGeter;
            _adressesSearcher = adressesSearcher;
            _draftOrderDataGeter = draftOrderDataGeter;
            _draftOrderSearcher = draftOrderSearcher;
        }

        public List<AdressTable> GetAdressesData()
        {
            return _adressesDataGeter.GetAdressesData();
        }

        public List<DraftOrdersTable> GetDraftOrderData()
        {
            return _draftOrderDataGeter.GetDraftOrderData();
        }

        public void HandleAdressChooserFormOpening(Form HandlerForm, UserTable userInfo)
        {
            var adresses = SearchInAdresses(GetAdressesData(), null, userInfo.UserId);
            var draftOrders = SearchInDraftOrders(GetDraftOrderData(), null, userInfo.UserId);
            if (draftOrders.Count <= 0)
            {
                MessageBox.Show("محصولی در سبد خرید شما وجود ندارد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (adresses.Count <= 0)
            {
                OpenAdressAdderOrEditorForm(HandlerForm, userInfo, false);
                adresses = SearchInAdresses(GetAdressesData(), null, userInfo.UserId);
                if (adresses.Count > 0)
                {
                    HandlerForm.Hide();
                    OpenAdressChooserForm(HandlerForm, userInfo);
                }
                else
                {
                    MessageBox.Show("باید حداقل یک آدرس داشته باشید تا بتوانید سفارش خود را ثبت کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public List<DraftOrdersTable> SearchInDraftOrders(IEnumerable<DraftOrdersTable> draftOrders, int? id = null, int? userId = null, string? userName = null, int? prductId = null, string? productName = null, int? brandId = null, string? brandName = null, int? minRequestedCount = null, int? maxRequestedCount = null, long? minAmount = null, long? maxAmount = null, long? minTotalAmount = null, long? maxTotalAmount = null)
        {
            return _draftOrderSearcher.SearchInDraftOrders(draftOrders,id,userId,userName,prductId,productName,brandId,brandName,minRequestedCount,maxRequestedCount,minAmount,maxAmount,minTotalAmount,maxTotalAmount);
        }
    }
}

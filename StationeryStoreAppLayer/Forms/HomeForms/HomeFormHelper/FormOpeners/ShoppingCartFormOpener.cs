using StationeryStoreAppLayer.Forms.ShoppingCartForms;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormOpeners
{
    public class ShoppingCartFormOpener<TShoppingCartForm> : IShoppingCartFormOpener where TShoppingCartForm:Form,IShoppingCartForm
    {
        private TShoppingCartForm _shoppingCartForm;
        public ShoppingCartFormOpener(TShoppingCartForm shoppingCartForm)
        {
            _shoppingCartForm = shoppingCartForm;
        }
        public void OpenShoppingCartForm(Form senderForm, UserTable userInfo)
        {
            senderForm.Hide();
            _shoppingCartForm.UserInfo = userInfo;
            _shoppingCartForm.ShowDialog();
            senderForm.Show();
        }
    }
}

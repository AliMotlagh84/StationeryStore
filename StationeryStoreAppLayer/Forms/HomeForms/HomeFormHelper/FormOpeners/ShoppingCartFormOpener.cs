using StationeryStoreUILayer.Forms.ShoppingCartForms;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormOpeners
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

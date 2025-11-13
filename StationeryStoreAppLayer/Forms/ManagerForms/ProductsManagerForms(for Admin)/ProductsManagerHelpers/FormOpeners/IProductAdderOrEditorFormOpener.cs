using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.ProductsAdderOrEditorFormOpeners
{
    public interface IProductAdderOrEditorFormOpener
    {
        void OpenProductAdderOrEditorForm(ProductsTable productInfo , bool editMode,Form senderForm);
    }
}

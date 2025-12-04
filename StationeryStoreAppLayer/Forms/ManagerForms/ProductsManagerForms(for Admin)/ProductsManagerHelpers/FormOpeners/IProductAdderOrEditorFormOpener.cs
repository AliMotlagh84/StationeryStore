using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ProductsManagerForms_for_Admin_.ProductsManagerHelpers.ProductsAdderOrEditorFormOpeners
{
    public interface IProductAdderOrEditorFormOpener
    {
        void OpenProductAdderOrEditorForm(Form senderForm, bool editMode, ProductsTable productInfoForTrueEditMode = null);
    }
}

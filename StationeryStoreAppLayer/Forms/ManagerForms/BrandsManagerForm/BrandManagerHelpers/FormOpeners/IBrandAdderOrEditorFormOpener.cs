using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.ManagerForms.BrandsManagerForm.BrandManagerHelpers.FormOpeners
{
    public interface IBrandAdderOrEditorFormOpener
    {
        void OpenBrandAdderOrEditorForm(Form senderForm, BrandsTable brand, bool editMode);
    }
}
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.ManagerForms.BrandsManagerForm.BrandManagerHelpers.FormOpeners
{
    public interface IBrandAdderOrEditorFormOpener
    {
        void OpenBrandAdderOrEditorForm(Form senderForm, bool editMode, BrandsTable brandInfoForTrueEditMode = null);
    }
}
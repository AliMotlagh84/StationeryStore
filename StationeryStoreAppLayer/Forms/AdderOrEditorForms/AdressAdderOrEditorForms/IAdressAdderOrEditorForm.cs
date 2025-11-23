using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms
{
    public interface IAdressAdderOrEditorForm
    {
        AdressTable AdressInfo { get; set; }
    }
}

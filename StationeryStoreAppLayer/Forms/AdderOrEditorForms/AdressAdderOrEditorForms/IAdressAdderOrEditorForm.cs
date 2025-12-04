using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.AdderOrEditorForms.AdressAdderOrEditorForms
{
    public interface IAdressAdderOrEditorForm
    {
        bool EditMode { get; set; }
        AdressTable AdressInfo { get; set; }
        UserTable UserInfo { get; set; }
    }
}

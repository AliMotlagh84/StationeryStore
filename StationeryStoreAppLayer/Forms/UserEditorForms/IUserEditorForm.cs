using StationeryStoreAppLayer.Forms.HomeForms;
using StationeryStoreAppLayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreAppLayer.PublicHelpers.DataEditors.UserDataEditors;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.UserEditorForms
{
    public interface IUserEditorForm : IUserDataEditor,IUserDataBuilder
    {
         UserTable UserInfo { get; set; }
    }
}

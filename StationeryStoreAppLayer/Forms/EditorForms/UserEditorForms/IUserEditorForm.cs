using StationeryStoreUILayer.Forms.HomeForms;
using StationeryStoreUILayer.PublicHelpers.DataBuilders.UserDataBuilder;
using StationeryStoreUILayer.PublicHelpers.DataEditors.UserDataEditors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.EditorForms.UserEditorForms
{
    public interface IUserEditorForm : IUserDataEditor,IUserDataBuilder
    {
         UserTable UserInfo { get; set; }
    }
}

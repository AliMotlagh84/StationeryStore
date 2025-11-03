using StationeryStoreAppLayer.AppManagers.FormManagers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreAppLayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreAppLayer.PublicHelpers.DgFillers;
using StationeryStoreDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.Forms.HomeForms
{
    public interface IHomeForm : IProductManagementAccessController,
        IDateLabelSeter,
        ITimeLabelSeter,
        IAdminLabelSeter,
        IIntroducingLabelSeter,
        IFormCloser,
        IFormManager       
    {
        public UserTable UserInfo { get; set; }
        public Form SenderForm { get; set; }
    }
}

using StationeryStoreUILayer.AppManagers.FormManagers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreUILayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
using StationeryStoreUILayer.PublicHelpers.DataGeters.OrdersGeters;
using StationeryStoreUILayer.PublicHelpers.DataGeters.ProductGeters;
using StationeryStoreUILayer.PublicHelpers.DgFillers;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.HomeForms
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

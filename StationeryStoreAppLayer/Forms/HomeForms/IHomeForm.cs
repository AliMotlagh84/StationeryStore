using StationeryStoreAppLayer.FormManagers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.FormClosers;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.LableSeters;
using StationeryStoreAppLayer.Forms.HomeForms.HomeFormHelper.ProductManagemenAccessControllers;
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
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public Form SenderForm { get; set; }
    }
}

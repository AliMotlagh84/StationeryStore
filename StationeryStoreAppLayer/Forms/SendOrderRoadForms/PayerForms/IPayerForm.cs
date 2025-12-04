using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms
{
    public interface IPayerForm
    {
        AdressTable AdressInfo { get; set; }
        UserTable UserInfo { get; set; }
        Random CaptchaRnd { get; set; }
        string CaptchaCode { get; set; }

    }
}

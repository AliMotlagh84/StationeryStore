using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreUILayer.Forms.OrdersForms
{
    public interface IOrdersForm
    {
        UserTable UserInfo { get; set; }
    }
}

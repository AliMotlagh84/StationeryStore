using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.AppManagers.AppRestartors
{
    public class AppRestartor : IAppRestartor
    {
        public void ResetApp()
        {
            Application.Restart();
        }
    }
}

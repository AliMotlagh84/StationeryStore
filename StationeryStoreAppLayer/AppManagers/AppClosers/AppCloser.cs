using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.AppManagers.AppClosers
{
    public class AppCloser : IAppCloser
    {
        public void CloseApp()
        {
            Application.Exit();
        }
    }
}

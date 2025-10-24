using StationeryStore.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreAppLayer.PublicHelpers.DgFillers
{
    public interface IDgFiller
    {
        void FillDg<T>(DataGridView dg, Func<List<T>> dataGeterMethod);
    }
}

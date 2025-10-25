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
        public void FillDg<T>(DataGridView dg, List<T> data);

    }
}

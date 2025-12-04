using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryStoreInfrastructureLayer.Repositories.EfRepositories.DraftOrderRepository
{
    public interface IDarftOrderRepository : IGenericRepository<DraftOrdersTable>
    {
        long GetTotalAmountsSumByUserId(int userId);
    }
}

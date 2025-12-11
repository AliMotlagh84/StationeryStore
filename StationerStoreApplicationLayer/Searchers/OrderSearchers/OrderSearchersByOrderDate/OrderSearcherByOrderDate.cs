using StationaryStoreUtility.Convertores.DateConvertors;
using StationeryStoreInfrastructureLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationerStoreApplicationLayer.Searchers.OrderSearchers.OrderSearchersByOrderDate
{
    public class OrderSearcherByOrderDate : IOrderSearcherByOrderDate
    {
        IPersianToMiladiDateConvertor _persianToMiladiDateConvertor;

        public OrderSearcherByOrderDate(IPersianToMiladiDateConvertor persianToMiladiDateConvertor)
        {
            _persianToMiladiDateConvertor = persianToMiladiDateConvertor;
        }
        public IEnumerable<OrdersTable> SearchInOrdersByOrderDate(IEnumerable<OrdersTable> orders, string? minDate = null, string? maxDate = null)
        {
            DateTime _minDate;
            DateTime _maxDate;
            if (((maxDate == null) || (maxDate == "    /  /")) && ((minDate == null) || (minDate == "    /  /")))
            {
                return orders;
            }
            if (((maxDate == null) || (maxDate == "    /  /")))
            {
                _minDate = PersianToMiladi(minDate);

                return orders.Where(o => _minDate <= o.Date);
            }
            else if (((minDate == null) || (minDate == "    /  /")))
            {
                _maxDate = PersianToMiladi(maxDate);
                return orders.Where(o => o.Date <= _maxDate);

            }
            else
            {
                _minDate = PersianToMiladi(minDate);
                _maxDate = PersianToMiladi(maxDate);
                return orders.Where(o => _minDate <= o.Date).Where(o => o.Date <= _maxDate);

            }


        }

        private DateTime PersianToMiladi(string date)
        {
            return _persianToMiladiDateConvertor.PersianToMiladi(date);
        }
    }
    
}

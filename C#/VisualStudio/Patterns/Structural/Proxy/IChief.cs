using System.Collections.Generic;

namespace Proxy
{
    interface IChief
    {
        IDictionary<int, string> GetStatuses();

        IEnumerable<Order> GetOrders();
    }
}


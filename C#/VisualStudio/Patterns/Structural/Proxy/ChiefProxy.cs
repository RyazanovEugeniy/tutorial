using System;
using System.Collections.Generic;

namespace Proxy
{
    class ChiefProxy : IChief
    {
        private readonly Chief chief;

        private IDictionary<int, string>? statuses;

        public ChiefProxy(Chief chief) => this.chief = chief;

        public IEnumerable<Order> GetOrders()
        {
            Console.WriteLine($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()\n");

            return chief.GetOrders();
        }

        public IDictionary<int, string> GetStatuses()
        {
            if (statuses is null)
                statuses = chief.GetStatuses();
            return statuses;
        }
    }
}



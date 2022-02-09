using System;

namespace Proxy
{
    public struct Order
    {
        public Guid id { get; set; }

        public string? name { get; set; }

        public int statusId { get; set; }
    }
}

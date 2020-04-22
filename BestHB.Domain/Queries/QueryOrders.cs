using BestHB.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestHB.Domain.Queries
{
    public class QueryOrders
    {
        public int UserId { get; set; }
        public string Instrument { get; set; }
        public OrderType? Type { get; set; }
        public OrderSide? Side { get; set; }
    }
}

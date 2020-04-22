using BestHB.Domain.Commands;
using System;

namespace BestHB.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string Symbol { get; set; }
        public decimal Quantity { get; set; }
        public OrderSide Side { get; set; }
        public OrderType Type { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }
        public decimal TriggerPrice { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }

        public string ToCSV(string delimiter)
        {
            var csv1 = this.Id + delimiter + this.Symbol + delimiter + this.Quantity + delimiter + Side + delimiter + Type + delimiter + Price;
            var csv2 = $"{this.Id}{delimiter}{this.Symbol}{delimiter}{this.Quantity}{delimiter}{Side}{delimiter}{Type}{delimiter}{Price}";

            //Qual das duas abordagens acima é mais performática? Por que?

            return csv1;
        }
    }

    public enum OrderStatus
    {
        Open = 0,
        Executed,
        PartialExecuted,
        Cancelled
    }
}

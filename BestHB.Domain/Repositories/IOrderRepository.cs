using BestHB.Domain.Entities;
using BestHB.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestHB.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<int> Add(Order order);
        Task<List<Order>> Get(QueryOrders queryOrders);
    }
}

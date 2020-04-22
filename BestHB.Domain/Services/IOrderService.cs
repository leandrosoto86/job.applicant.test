using BestHB.Domain.Commands;
using BestHB.Domain.Entities;
using BestHB.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestHB.Domain.Service
{
    public interface IOrderService
    {
        int Create(CreateOrderCommand createOrderCommand);
        Task<int> Update(UpdateOrderCommand updateOrderCommand);
        Task<DeleteOrderStatus> Delete(DeleteOrderCommand deleteOrderCommand);
        Task<List<string>> AsCSV(QueryOrders queryOrders);
    }
}

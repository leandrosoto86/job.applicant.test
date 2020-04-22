using BestHB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BestHB.Domain.Repositories
{
    public interface IInstrumentInfoRepository
    {
        Task<InstrumentInfo> Get(string symbol);
    }
}

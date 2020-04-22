using BestHB.Domain.Entities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace BestHB.Repository.InMemory
{
    internal static class InMemoryIntrumentInfoRepository
    {
        private static readonly ConcurrentDictionary<string, InstrumentInfo> _instrumentsInfo;
        private static readonly object _readLock;
        private static readonly object _writeLock;

        static InMemoryIntrumentInfoRepository()
        {
            _readLock = new object();
            _writeLock = new object();
            _instrumentsInfo = new ConcurrentDictionary<string, InstrumentInfo>();
        }

        public static void Add(InstrumentInfo instrumentInfo)
        {
            if (Get(instrumentInfo.Symbol) == null)
            {
                lock (_writeLock)
                {
                    _instrumentsInfo.TryAdd(instrumentInfo.Symbol, instrumentInfo);
                }
            }
        }

        public static InstrumentInfo Get(string symbol)
        {
            lock(_readLock)
            {
                if(_instrumentsInfo.ContainsKey(symbol))
                {
                    return _instrumentsInfo[symbol];
                }
                else
                {
                    return null;
                }
            }
        }

    }
}

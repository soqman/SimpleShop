using System;

namespace Core
{
    public interface ISpendable
    {
        public event Action OnCountUpdated;
        public bool TrySpend();
        public bool HasEnough();
        public int Count { get; }
    }
}
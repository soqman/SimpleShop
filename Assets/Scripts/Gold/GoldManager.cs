using System;
using Core;

namespace Gold
{
    public class GoldManager : Singleton<GoldManager>
    {
        public static event Action OnGoldCountChanged;

        private int count;
        
        public int Count
        {
            get => count;
            private set
            {
                count = value;
                OnGoldCountChanged?.Invoke();
            }
        }

        public bool TrySpend(int value)
        {
            if (Count < value) return false;

            Count -= value;
            return true;
        }

        public void Add(int value)
        {
            Count += value;
        }
        
        public bool HasEnough(int value)
        {
            return Count >= value;
        }
    }
}
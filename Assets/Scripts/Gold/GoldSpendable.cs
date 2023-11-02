using System;
using Core;
using UnityEngine;

namespace Gold
{
    public class GoldSpendable : ISpendable
    {
        public event Action OnCountUpdated;
        
        [SerializeField] private int count;
        
        public int Count => count;

        public GoldSpendable()
        {
            // it's not the best solution. better to use smth like global events;
            GoldManager.OnGoldCountChanged += () => OnCountUpdated?.Invoke();
        }
        
        public bool TrySpend()
        {
            return GoldManager.Instance.TrySpend(count);
        }

        public bool HasEnough()
        {   
            return GoldManager.Instance.HasEnough(count);
        }
    }
}
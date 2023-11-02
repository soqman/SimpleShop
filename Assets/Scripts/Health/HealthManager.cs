using System;
using Core;
using UnityEngine;

namespace Health
{
    public class HealthManager : Singleton<HealthManager>
    {
        public static event Action OnHealthChanged;

        [SerializeField] private int initialHealth;

        private int count;
        
        public int Count
        {
            get => count;
            private set
            {
                count = Math.Max(value, 0);
                OnHealthChanged?.Invoke();
            }
        }
        
        protected override void Awake()
        {
            base.Awake();
            count = initialHealth;
        }

        public void Remove(int value)
        {
            Count -= value;
        }

        public void Add(int value)
        {
            Count += value;
        }
        
        public void AddPercent(float percentage)
        {
            percentage = Math.Clamp(percentage, 0f, 1f);
            Count += (int) (Count * percentage);
        }
    }
}
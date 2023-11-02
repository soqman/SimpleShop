using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class HealthAddReward : IReward
    {
        [SerializeField] private int count;
        
        public string DisplayName => $"+{count} health";
        
        public void Claim()
        {
            HealthManager.Instance.Add(count);
        }
    }
}
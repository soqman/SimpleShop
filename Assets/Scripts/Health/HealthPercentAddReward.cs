using System;
using Core;
using UnityEngine;

namespace Health
{
    [Serializable]
    public class HealthPercentAddReward : IReward
    {
        [SerializeField] private float percentage;
        
        public string DisplayName => $"+{percentage}% health";
        
        public void Claim()
        {
            HealthManager.Instance.AddPercent(percentage);
        }
    }
}
using System;
using Core;
using UnityEngine;

namespace Location
{
    [Serializable]
    public class LocationReward :  IReward
    {
        [SerializeField] private string locationId;

        public string DisplayName => $"New {locationId} location";
        
        public void Claim()
        {
            LocationManager.Instance.Change(locationId);
        }
    }
}
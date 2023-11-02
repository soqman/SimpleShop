using System;
using Core;
using UnityEngine;

namespace Location
{
    public class LocationManager : Singleton<LocationManager>
    {
        public static event Action OnLocationChanged;
        
        [SerializeField] private string initialLocation;

        private string location;

        protected override void Awake()
        {
            base.Awake();
            location = initialLocation;
        }

        public string Location
        {
            get => location;
            private set
            {
                location = value;
                OnLocationChanged?.Invoke();
            }
        }

        public void Change(string value)
        {
            Location = value;
        }

        public void Reset()
        {
            Location = initialLocation;
        }
    }
}
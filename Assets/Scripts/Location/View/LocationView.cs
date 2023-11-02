using TMPro;
using UnityEngine;

namespace Location.View
{
    public class LocationView : MonoBehaviour
    {
        [SerializeField] private TMP_Text displayText;

        private void OnEnable()
        {
            LocationManager.OnLocationChanged += OnLocationChanged;
            RefreshView();
        }

        private void OnDisable()
        {
            LocationManager.OnLocationChanged -= OnLocationChanged;
        }

        private void OnLocationChanged()
        {
            RefreshView();
        }

        private void RefreshView()
        {
            displayText.text = LocationManager.Instance.Location;
        }
    }
}
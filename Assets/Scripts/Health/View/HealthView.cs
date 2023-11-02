using TMPro;
using UnityEngine;

namespace Health.View
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private TMP_Text displayText;

        private void OnEnable()
        {
            HealthManager.OnHealthChanged += OnHealthChanged;
            RefreshView();
        }

        private void OnDisable()
        {
            HealthManager.OnHealthChanged -= OnHealthChanged;
        }

        private void Start()
        {
            RefreshView();
        }

        private void OnHealthChanged()
        {
            RefreshView();
        }

        private void RefreshView()
        {
            displayText.text = HealthManager.Instance.Count.ToString();
        }
    }
}
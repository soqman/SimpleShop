using TMPro;
using UnityEngine;

namespace Gold.View
{
    public class GoldView : MonoBehaviour
    {
        [SerializeField] private TMP_Text displayText;

        private void OnEnable()
        {
            GoldManager.OnGoldCountChanged += OnGoldCountChanged;
            RefreshView();
        }

        private void OnDisable()
        {
            GoldManager.OnGoldCountChanged -= OnGoldCountChanged;
        }

        private void OnGoldCountChanged()
        {
            RefreshView();
        }

        private void RefreshView()
        {
            displayText.text = GoldManager.Instance.Count.ToString();
        }
    }
}
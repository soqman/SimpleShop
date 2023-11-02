using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    [RequireComponent(typeof(Button))]
    public abstract class CheatButton : MonoBehaviour
    {
        private Button button;

        private void Awake()
        {
            button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDisable()
        {
           button.onClick.RemoveListener(OnButtonClicked);
        }

        protected abstract void OnButtonClicked();
    }
}
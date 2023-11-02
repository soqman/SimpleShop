using Core;
using UnityEngine;

namespace Health.View
{
    public class HealthAddCheatButton : CheatButton
    {
        [SerializeField] private int extraHealthCount;
        
        protected override void OnButtonClicked()
        {
            HealthManager.Instance.Add(extraHealthCount);
        }
    }
}
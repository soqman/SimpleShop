using Core;
using UnityEngine;

namespace Gold.View
{
    public class GoldAddCheatView : CheatButton
    {
        [SerializeField] private int extraGoldCount;
        
        protected override void OnButtonClicked()
        {
            GoldManager.Instance.Add(extraGoldCount);
        }
    }
}
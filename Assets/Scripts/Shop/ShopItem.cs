using Core;
using UnityEngine;

namespace Shop
{
    [CreateAssetMenu(fileName = "ShopItem", menuName = "Configs/Shop/ShopItem", order = 0)]
    public class ShopItem : ScriptableObject
    {
        [SerializeReference] private IReward reward;
        [SerializeReference] private ISpendable currency;

        public IReward Reward => reward;
        public ISpendable Currency => currency;
    }
}
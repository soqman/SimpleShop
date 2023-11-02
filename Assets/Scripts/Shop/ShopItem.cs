using Core;
using UnityEngine;

namespace Shop
{
    [CreateAssetMenu(fileName = "ShopItem", menuName = "Configs/ShopItem", order = 0)]
    public class ShopItem : ScriptableObject
    {
        [SerializeReference] private IReward reward;
        [SerializeReference] private ISpendable currency;
        [SerializeField] private int price;
    }
}
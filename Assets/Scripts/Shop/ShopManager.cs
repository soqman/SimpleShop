using Core;
using UnityEngine;

namespace Shop
{
    public class ShopManager : Singleton<ShopManager>
    {
        [SerializeField] private ShopItem[] items;
        [SerializeField] private ShopItemView shopItemViewPrefab;
        [SerializeField] private Transform shopItemsRoot;

        private void Start()
        {
            InitShop();
        }

        private void InitShop()
        {
            foreach (var item in items)
            {
                var view = Instantiate(shopItemViewPrefab, shopItemsRoot);
                view.Init(item);
            }
        }

        public void TryBuy(ShopItem item)
        {
            if (item.Currency.TrySpend())
            {
                item.Reward.Claim();
            }
        }
    }
}
using Shop;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemView : MonoBehaviour
{
    private const string PriceFormat = "{0}$";
    
    [SerializeField] private TMP_Text labelText;
    [SerializeField] private TMP_Text priceText;
    [SerializeField] private Button buyButton;

    private ShopItem shopItem;

    public void Init(ShopItem shopItem)
    {
        labelText.text = shopItem.Reward.DisplayName;
        priceText.text = string.Format(PriceFormat, shopItem.Currency.Count);
        
        shopItem.Currency.OnCountUpdated += OnCurrencyCountUpdated;
        
        this.shopItem = shopItem;
        UpdateButtonAvailability();
    }

    private void OnEnable()
    {
        buyButton.onClick.AddListener(OnBuyButtonClick);
        UpdateButtonAvailability();
    }

    private void OnDisable()
    {
        buyButton.onClick.RemoveListener(OnBuyButtonClick);
    }

    private void OnDestroy()
    {
        if (shopItem != null)
        {
            shopItem.Currency.OnCountUpdated -= OnCurrencyCountUpdated;
        }
    }

    private void OnBuyButtonClick()
    {
        ShopManager.Instance.TryBuy(shopItem);
    }
    
    private void OnCurrencyCountUpdated()
    {
        UpdateButtonAvailability();
    }

    private void UpdateButtonAvailability()
    {
        if (shopItem == null) return;
        
        buyButton.interactable = shopItem.Currency.HasEnough();
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    private const string PriceFormat = "{0}$";
    
    [SerializeField] private TMP_Text labelText;
    [SerializeField] private TMP_Text priceText;
    [SerializeField] private Button buyButton;

    public void Init(string label, int price)
    {
        labelText.text = label;
        priceText.text = string.Format(PriceFormat, price);
        RefreshView();
    }

    private void OnEnable()
    {
        buyButton.onClick.AddListener(OnBuyButtonClick);
        //
    }

    private void OnDisable()
    {
        buyButton.onClick.RemoveListener(OnBuyButtonClick);
        //
    }

    private void RefreshView()
    {
        buyButton.interactable = IsAvailable();
    }

    private bool IsAvailable()
    {
        //
        return true;
    }

    private void OnBuyButtonClick()
    {
        
    }

    private void OnCurrencyUpdated()
    {
        RefreshView();
    }
}

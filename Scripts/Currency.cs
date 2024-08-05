using TMPro;
using UnityEngine;



public class Currency : MonoBehaviour, IDataPersistence
{
    [SerializeField] private int currency = 0;
    [SerializeField] private TextMeshProUGUI currencyText;



    private void OnEnable()
    {
        GameManager.OnCurrencyUpdated += IncreaseCurrency;
    }


    private void OnDisable()
    {
        GameManager.OnCurrencyUpdated -= IncreaseCurrency;
    }


    public void LoadData(GameData data)
    {
        this.currency = data.currency;
    }


    public void SaveData(ref GameData data)
    {
        data.currency = this.currency;
    }


    public void IncreaseCurrency()
    {
        currency++;
        Debug.Log(currency);
        currencyText.text = currency.ToString();
    }
}

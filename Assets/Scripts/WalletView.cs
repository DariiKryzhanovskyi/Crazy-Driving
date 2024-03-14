using TMPro;
using UnityEngine;

public class WalletView : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        DisplayMoney();
    }
    private void OnEnable()
    {
        _wallet.OnMoneyChanged += DisplayMoney;
    }
    private void OnDisable()
    {
        _wallet.OnMoneyChanged -= DisplayMoney;
    }
    private void DisplayMoney()
    {
        _text.text = _wallet.GetMoney().ToString();
    }
}

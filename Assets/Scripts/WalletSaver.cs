using UnityEngine;

public class WalletSaver : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;

    private void OnEnable()
    {
        _wallet.OnMoneyChanged += SaveMoney;
    }
    private void OnDisable()
    {
        _wallet.OnMoneyChanged -= SaveMoney;
    }
    private void Awake()
    {
        GetMoney();
    }
    private void SaveMoney()
    {
        PlayerPrefs.SetFloat("Money", _wallet.GetMoney());
        PlayerPrefs.Save();
    }
    private void GetMoney()
    {
        _wallet.SetMoney(PlayerPrefs.GetFloat("Money", 200));
    }
}

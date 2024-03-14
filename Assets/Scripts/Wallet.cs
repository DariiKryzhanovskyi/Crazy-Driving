using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Wallet", menuName = "ScriptableObjects/Wallet")]
public class Wallet : ScriptableObject
{
    [SerializeField] private float _money = 200;

    public UnityAction OnMoneyChanged;

    public void TakeMoney(float amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount));

        _money += amount;
        OnMoneyChanged?.Invoke();
    }
    public bool TrySpendMoney(float amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount));
        }
        if (amount > _money)
        {
            Debug.Log("Не достаточно денег");
            return false;
        }

        _money -= amount;
        OnMoneyChanged?.Invoke();
        return true;
    }
    public void SetMoney(float amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException(nameof(amount));
        
        _money = amount;
        OnMoneyChanged?.Invoke();
    }
    public float GetMoney()
    {
        return _money;
    }
}

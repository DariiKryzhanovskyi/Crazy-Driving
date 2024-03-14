using TMPro;
using UnityEngine;

public class DataRedactor : MonoBehaviour
{
    [SerializeField] private Finish _finish;
    [SerializeField] private Level _level;
    [SerializeField] private Wallet _wallet;
    [SerializeField] private LevelsCollection _data;
    [SerializeField] private CoinsView _coinsView;

    private void OnEnable()
    {
        _finish.OnFinished += PassLevel;
    }
    private void OnDisable()
    {
        _finish.OnFinished -= PassLevel;
    }
    private void PassLevel()
    {
        if (_data.GetCollection() <= _level.SceneId)
        {
            _data.AddLevel();
            GiveMoney();
        }
        else
        {
            _coinsView.StopDisplaing();
        }
    }
    private void GiveMoney()
    {
        _wallet.TakeMoney(_level.Coins);
    }
}
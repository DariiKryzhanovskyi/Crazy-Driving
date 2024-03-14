using TMPro;
using UnityEngine;
public class CoinsView : MonoBehaviour
{
    [SerializeField] private Level _level;

    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
    }
    public void DisplayCoins()
    {
        _text.text = "+ " + _level.Coins.ToString() + "$";
    }
    public void StopDisplaing()
    {
        _text.text = "";
    }
}

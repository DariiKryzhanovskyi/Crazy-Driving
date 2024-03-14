using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class FinishTimerView : MonoBehaviour
{
    private TMP_Text _timerText;

    private void Awake()
    {
        _timerText = GetComponent<TMP_Text>();
    }
    public void DisplayTimer(string text)
    {
        _timerText.text = text;
    }
}

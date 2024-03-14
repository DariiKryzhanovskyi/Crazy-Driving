using UnityEngine;
using TMPro;
using System;

public class SpeedView : MonoBehaviour
{
    [SerializeField] private TMP_Text _speedText;

    private RCC_CarControllerV3 _rcc;

    private void Start()
    {
        _rcc = FindObjectOfType<RCC_CarControllerV3>();
    }
    private void LateUpdate()
    {
        DisplayText();
    }
    private void DisplayText()
    {
        float speed = _rcc.speed;

        _speedText.SetText($"{Math.Floor(speed)}");
    }
}

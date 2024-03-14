using System;
using UnityEngine;
using UnityEngine.Events;

public class FinishTimer : MonoBehaviour
{
    private const float END_TIME = 0;

    [SerializeField] private float _seconds = 3f;
    [SerializeField] private FinishTimerView _timerView;

    public UnityAction TimeOut;

    private bool _startTimer = false;
    private float _currentTime = 0;

    private void Start()
    {
        _currentTime = _seconds;
    }
    private void Update()
    {
        if (_startTimer)
        {
            StartCount();
        }
    }
    private void StartCount()
    {
        _currentTime -= Time.deltaTime;

        _timerView.DisplayTimer(Math.Floor(_currentTime + 1).ToString());

        if (_currentTime <= END_TIME)
        {
            TimeOut.Invoke();
            DisableTimer();
        }
    }
    public void EnableTimer()
    {
        _startTimer = true;
    }
    public void DisableTimer()
    {
        _startTimer = false;
        _currentTime = _seconds;

        _timerView.DisplayTimer("");
    }
}

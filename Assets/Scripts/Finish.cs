using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    [SerializeField] private FinishTrigger _finishTrigger;
    [SerializeField] private FinishTimer _timer;

    public UnityAction OnFinished;

    private void OnEnable()
    {
        _finishTrigger.TriggerDetected += FinishTimer;
        _timer.TimeOut += FinishLevel;
    }
    private void OnDisable()
    {
        _finishTrigger.TriggerDetected -= FinishTimer;
        _timer.TimeOut -= FinishLevel;
    }
    private void FinishTimer(bool enable)
    {
        if (enable)
            _timer.EnableTimer();
        else
            _timer.DisableTimer();
    }
    private void FinishLevel()
    {
        OnFinished?.Invoke();
    }
}

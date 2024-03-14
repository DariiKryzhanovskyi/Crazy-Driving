using UnityEngine;

public class Fps : MonoBehaviour
{
    [SerializeField] private int _targetFps = 120;
    public float CurrentFrameRate {  get; private set; }

    private void Awake()
    {
        Application.targetFrameRate = _targetFps;
    }
    private void Update()
    {
        CurrentFrameRate = (int)(1f / Time.deltaTime);
    }
}

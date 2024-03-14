using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    [SerializeField] private Finish _finish;
    [SerializeField] private PauseScreen _pausePanel;

    private bool _canInput = true;

    private void OnEnable()
    {
        _finish.OnFinished += DisableInput;
    }
    private void OnDisable()
    {
        _finish.OnFinished -= DisableInput;
    }
    private void Update()
    {
        if (_canInput)
        {
            Restart();
            Pause();
        }
    }
    private void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _pausePanel.OpenPauseMenu();
        }
    }
    private void Restart()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Level.RestartLevel();   
        }
    }
    private void DisableInput()
    {
        _canInput = false;
    }
}

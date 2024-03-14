using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _interface;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    public void OpenPauseMenu()
    {
        _interface.SetActive(false);
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue()
    {
        _pausePanel.SetActive(false);
        _interface.SetActive(true);
        Time.timeScale = 1f;
    }
    public void ExitAtMainMenu()
    {
        _pausePanel.SetActive(false);
        SceneChanger.LoadScene(0);
        Time.timeScale = 1f;
    }
}

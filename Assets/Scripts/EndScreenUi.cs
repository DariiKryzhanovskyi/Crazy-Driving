using UnityEngine;
public class EndScreenUi : MonoBehaviour
{
    [SerializeField] private GameObject _endScreen;
    [SerializeField] private GameObject _interface;
    [SerializeField] private Level _level;
    [SerializeField] private RCC_Camera _camera;
    [SerializeField] private Finish _finish;
    [SerializeField] private CoinsView _coinsView;

    private void OnEnable()
    {
        _finish.OnFinished += OpenPassedPanel;
    }
    private void OnDisable()
    {
        _finish.OnFinished -= OpenPassedPanel;
    }
    private void OpenPassedPanel()
    {
        _camera.enabled = false;
        _interface.SetActive(false);
        _endScreen.SetActive(true);
        _coinsView.DisplayCoins();
    }   
    public void NextLevel()
    {
        int nextSceneId = _level.SceneId + 1;

        SceneChanger.LoadScene(nextSceneId);
    }
    public void ExitAtMainMenu()
    {
        SceneChanger.LoadScene(0);
    }
    public void RestartLevel()
    {
        Level.RestartLevel();
    }
}

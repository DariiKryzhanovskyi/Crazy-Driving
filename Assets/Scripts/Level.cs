using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] private int _sceneId;
    [SerializeField] private int _coins;

    public int Coins => _coins;
    public int SceneId => _sceneId;

    private static Level _instance;
    private void Awake()
    {
        _instance = this;
    }
    static public int RestartLevel()
    {
        int _currentSceneId = _instance.SceneId;
        SceneManager.LoadScene(_currentSceneId);

        return _currentSceneId;
    }
}

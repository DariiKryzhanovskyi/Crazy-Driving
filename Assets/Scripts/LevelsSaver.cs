using UnityEngine;

public class LevelsSaver : MonoBehaviour
{
    [SerializeField] private LevelsCollection _levelsCollection;

    private void OnEnable()
    {
        _levelsCollection.OnCollectionsChanged += Save;
    }
    private void OnDisable()
    {
        _levelsCollection.OnCollectionsChanged -= Save;
    }
    private void Awake()
    {
        GetSaves();
    }
    private void Save()
    {
        PlayerPrefs.SetInt("Levels", _levelsCollection.GetCollection());
        PlayerPrefs.Save();
    }
    private void GetSaves()
    {
        _levelsCollection.SetCollection(PlayerPrefs.GetInt("Levels", 1));
    }
}
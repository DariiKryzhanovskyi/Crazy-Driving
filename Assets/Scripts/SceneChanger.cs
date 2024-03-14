using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private TMP_Text _percentageText;
    [SerializeField] private GameObject _loadingScreen;

    private static SceneChanger _instance;
    private AsyncOperation _asyncOperation;

    private void Awake()
    {
        _instance = this;
    }
    public static void LoadScene(int sceneId)
    {
        _instance.StartCoroutine(_instance.LoadSceneAsync(sceneId));
    }
    public IEnumerator LoadSceneAsync(int sceneId)
    {
        _asyncOperation = SceneManager.LoadSceneAsync(sceneId);
        _loadingScreen.SetActive(true);

        while (!_asyncOperation.isDone) 
        {
            int percentage = 100;

            _percentageText.text = Mathf.FloorToInt(_asyncOperation.progress * percentage).ToString() + "%";

            yield return null;
        }
    }
}

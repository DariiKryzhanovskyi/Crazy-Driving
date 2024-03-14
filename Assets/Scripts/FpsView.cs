using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class FpsView : MonoBehaviour
{
    [SerializeField] private float _showInterval;
    [SerializeField] private Fps _fps;

    private TMP_Text _fpsText;

    private void Awake()
    {
        _fpsText = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        StartCoroutine(DisplayFps());
    }
    private IEnumerator DisplayFps()
    {
        while (true)
        {
            _fpsText.text = "Fps: " + _fps.CurrentFrameRate.ToString();
            yield return new WaitForSeconds(_showInterval);
        }
    }

}

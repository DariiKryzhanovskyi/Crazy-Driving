using System.Collections;
using UnityEngine;

public class Info : MonoBehaviour
{
    [SerializeField] private GameObject _infoText;
    [SerializeField] private float _waitSeconds;

    public void ShowInfo()
    {
        StartCoroutine(ShowTriggerInfo(_waitSeconds));
    }
    private IEnumerator ShowTriggerInfo(float wait)
    {
        _infoText.SetActive(true);

        yield return new WaitForSeconds(wait);

        _infoText.SetActive(false);
    }
}

using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class LevelIcon : MonoBehaviour
{
    [SerializeField] private int _sceneId;
    [SerializeField] private bool _isLockedLevel = true;
    [SerializeField] private Sprite _lvlUnLockedSprite;
    [SerializeField] private TMP_Text _levelNumer;
    [SerializeField] private GameObject _lockImage;

    private Image _lvlIcon;

    public UnityEvent<int> OnPreesed;

    public bool IsLockedLevel => _isLockedLevel;
    private void Awake()
    {
        _lvlIcon = GetComponent<Image>();
    }
    private void Start()
    {
        if (!_isLockedLevel)
        {
            UnLockLvl();
        }
    }
    public void UnLockLvl()
    {
        _isLockedLevel = false;
        _lockImage.SetActive(false);
        _lvlIcon.sprite = _lvlUnLockedSprite;
        _levelNumer.gameObject.SetActive(true);
    }
    public void LoadLevel()
    {
        if (!_isLockedLevel)
        {
            OnPreesed?.Invoke(_sceneId);
        }
    }
}

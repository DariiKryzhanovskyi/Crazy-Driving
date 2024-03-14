using UnityEngine;

public class IconRender : MonoBehaviour
{
    [SerializeField] private LevelsCollection _data;
    [SerializeField] private LevelIcon[] _icons;

    private void Start()
    {
        for (int i = 0; i < _data.GetCollection(); i++)
        {
            _icons[i].UnLockLvl();
        }
    }
}

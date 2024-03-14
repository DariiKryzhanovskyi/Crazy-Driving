using Unity.VisualScripting;
using UnityEngine;

public class BoundController : MonoBehaviour
{
    [SerializeField] private float _boundY = -15;
    [SerializeField] private Level _level;
    
    private Player _key;

    private void Start()
    {
        _key = FindObjectOfType<Player>();
    }
    private void Update()
    {
        CheckPosition();
    }
    private void CheckPosition()
    {
        if (_key != null)
        {
            float positionY = _key.transform.position.y;

            if(positionY <= _boundY)
            {
                Level.RestartLevel();
            }
        }
    }
}

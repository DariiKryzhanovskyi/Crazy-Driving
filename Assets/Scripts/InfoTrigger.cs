using UnityEngine;
using UnityEngine.Events;

public class InfoTrigger : MonoBehaviour
{
    public UnityEvent TriggerEntered;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Player>())
        {
            TriggerEntered?.Invoke();
        }
    }
}

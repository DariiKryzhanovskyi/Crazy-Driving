using UnityEngine;
using UnityEngine.Events;

public class FinishTrigger : MonoBehaviour
{
    public UnityAction<bool> TriggerDetected;

    private bool IsTrigger(Collider collider)
    {
        if (collider.gameObject.GetComponentInParent<Player>())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (IsTrigger(other))
        {
            TriggerDetected?.Invoke(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (IsTrigger(other))
        {
            TriggerDetected?.Invoke(false);
        }
    }
}

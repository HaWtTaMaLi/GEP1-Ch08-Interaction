using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    public bool debugEnabled = false;

    private IInteractable targetInteractable;

    [SerializeField] private GameObject debugCurrentInteractable;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = foundInteractable;
            debugCurrentInteractable = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = null;
            debugCurrentInteractable = null;
        }
    }
}

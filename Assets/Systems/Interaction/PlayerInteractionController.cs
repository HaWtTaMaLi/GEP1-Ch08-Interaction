using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractionController : MonoBehaviour
{
    [SerializeField] bool debugEnabled = false;

    private IInteractable targetInteractable;

    [SerializeField] private GameObject debugCurrentInteractable;

    private UIManager UIManager;


    private void Start()
    {
        UIManager = ServiceHub.Instance.UIManager;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = foundInteractable;
            debugCurrentInteractable = other.gameObject;

            UIManager.ShowPrompt();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractable foundInteractable))
        {
            targetInteractable = null;
            debugCurrentInteractable = null;

            UIManager.HidePrompt();
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (debugEnabled) Debug.Log("Interacted with");

            if (targetInteractable != null)
            {
                targetInteractable.Interact();
            }
        } 
    }

}


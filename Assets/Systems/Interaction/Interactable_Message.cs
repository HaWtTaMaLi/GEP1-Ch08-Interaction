using UnityEngine;

public class Interactable_Message : MonoBehaviour, IInteractable
{
    [SerializeField] bool debugEnabled = false;

    [SerializeField] private UIManager uiManager;

    [SerializeField] private string message;

    private void Start()
    {
        uiManager = ServiceHub.Instance.UIManager;

        if (uiManager == null) Debug.LogError("UIManager not found in serviceHub. Please Ensure it is properly set up.");
    }

    public void Interact()
    {
        if (debugEnabled) Debug.Log("Interacted with Interactable_Message");
        uiManager.DisplayMessage(message);
     
    }

    public void Focused()
    {
        //change color or highlight
        //if inside interactable do something
    }

    public void UnFocused()
    {
        
    }

}

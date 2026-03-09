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
        uiManager.DisplayMessage(message);
        Debug.Log("Tester");
    }

    public void Focused()
    {

    }

    public void UnFocused()
    {
        
    }

}

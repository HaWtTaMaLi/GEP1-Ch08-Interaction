using UnityEngine;

public class Interactable_PickUp : MonoBehaviour, IInteractable
{
    [SerializeField] bool debugEnabled = false;


    public void Interact()
    {
        if (debugEnabled) Debug.Log("Interacted with" + gameObject.name);

        //add logic to add items to inventory
        Destroy(gameObject);
    }
    public void Focused()
    {

    }

    public void UnFocused()
    {
        
    }
}

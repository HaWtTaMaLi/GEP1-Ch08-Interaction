using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] bool debugEnabled = false;

    [SerializeField] private TMP_Text messageText;

    private string currentMessage = "";

    public void DisplayMessage(string message)
    {
        //passes message through the ui manager to the display
        currentMessage = message;
        messageText.text = currentMessage;
    }

}

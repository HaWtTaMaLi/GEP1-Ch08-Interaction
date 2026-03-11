using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] bool debugEnabled = false;

    [SerializeField] private TMP_Text messageText;

    private string currentMessage = "";

    public void DisplayMessage(string message)
    {
        //passes message through the ui manager to the display
        currentMessage = message;
        StartCoroutine(FadeOutInfoText());

    }

    private IEnumerator FadeOutInfoText()
    {
        messageText.text = currentMessage;

        yield return new WaitForSeconds(3f);

        messageText.text = "'Text vanishes'";
    }
}

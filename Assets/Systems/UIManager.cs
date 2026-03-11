using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] bool debugEnabled = false;

    private Coroutine fadeCoroutine;

    [Header("Interact Message")]
    [SerializeField] float messageDurration = 3.0f;
    [SerializeField] float fadeOutTime = 0.5f;
    [SerializeField] private TMP_Text messageText;

    [SerializeField] private string prompt;
    [SerializeField] private TMP_Text promptText;

    public void DisplayMessage(string message)
    {
        //passes message through the ui manager to the display

        if(fadeCoroutine != null)
        {
            StopCoroutine(fadeCoroutine);
        }

        fadeCoroutine = StartCoroutine(DisplayMessageAndFade(message));
    }

    public void ShowPrompt()
    {
        if (debugEnabled) Debug.Log("Showing Prompt");

        promptText.text = prompt;
    }

    public void HidePrompt()
    {
        if (debugEnabled) Debug.Log("Hiding Prompt");

        promptText.text = "";
    }

    private IEnumerator DisplayMessageAndFade(string message)
    {
        messageText.text = message;
        messageText.alpha = 1;

        float elapsedTime = 0f;

        yield return new WaitForSeconds(messageDurration);

        Color OrigionalColor = messageText.color;

        while (elapsedTime < messageDurration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeOutTime);

            messageText.color = new Color(OrigionalColor.r, OrigionalColor.g, OrigionalColor.b, alpha);
            yield return null;
        }

        messageText.text = "";
    }
}

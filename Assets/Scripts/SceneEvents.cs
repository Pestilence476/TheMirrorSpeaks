using System.Collections;
using UnityEngine;

public class SceneEvents : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject character;
    public GameObject mirror;
    public GameObject textbox;


    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;

    void Update()
    {
        textLength = TextCreator.charCount;
    }

    void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        character.SetActive(true);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        textToSpeak = "Insert Text once the script has been completed.";
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);


        textbox.SetActive(true);
        yield return new WaitForSeconds(2);
        mirror.SetActive(true);
    }

}

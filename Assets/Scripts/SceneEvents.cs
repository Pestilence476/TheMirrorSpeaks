using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class SceneEvents : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject fadeScreenOut;
    public GameObject character;
    public GameObject mirror;
    public GameObject textbox;
    public GameObject charname;
    public GameObject endScreen;
    public GameObject options;
    public GameObject Lipstick;
    public GameObject Mascara;
    public GameObject Scissors;
    public GameObject Syringe;
    public GameObject Brush;
    public GameObject Compact;
    public GameObject Earrings;
    public GameObject Necklace;
    public GameObject Eyeliner;
    [SerializeField] string textToSpeak;
    [SerializeField] string textToChar;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;
    public MultipleEndings endGame;
    public ChoicesScript choicesScript;

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
        // event 0
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        character.SetActive(true);
        yield return new WaitForSeconds(3);
        mainTextObject.SetActive(true);
        textToChar = "You";
        textToSpeak = "Why can't I be like the girls online? They are so pretty but I am just a mess...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 1;

    }

    IEnumerator EventOne()
    {
        nextButton.SetActive(false);
        textbox.SetActive(true);
        yield return new WaitForSeconds(2);
        mirror.SetActive(true);
        yield return new WaitForSeconds(2);
        textToChar = "Mirror";
        textToSpeak = "We can fix you... Just do what we say and you will be a celebrity.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 2;
    }


    IEnumerator EventTwo()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(2);
        textToChar = "Mirror";
        textToSpeak = "Why don't you make your lips bigger... People will listen to you if you are pretty.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Lipstick.SetActive(false);
        Syringe.SetActive(false);
        options.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventOneGood()
    {
        nextButton.SetActive(false);
        textbox.SetActive(true);
        yield return new WaitForSeconds(2);
        mirror.SetActive(true);
        yield return new WaitForSeconds(2);
        textToChar = "Mirror";
        textToSpeak = "This is proof that it works";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventThree()
    {
        Lipstick.SetActive(true);
        Syringe.SetActive(true);
        yield return new WaitForSeconds(2);
        textToChar = "Mirror";
        textToSpeak = "No one likes messy hair...  CuT It OFf....";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        Scissors.SetActive(false);
        Brush.SetActive(false);
        options.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 5;
    }

    IEnumerator EventFive()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 6;
    }

    IEnumerator EventSix()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 100;
    }

    IEnumerator EventFinal()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);
        fadeScreenOut.SetActive(true);
        yield return new WaitForSeconds(2);
        endScreen.SetActive(true);

        
        endGame.EndGame();
    }

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(EventOne());
        }
        if (eventPos == 2)
        {
            StartCoroutine(EventTwo()); 
        }


        if (eventPos == 3)
        {
            if (choicesScript.removecalled == true)
            {
                StartCoroutine(EventThree());
                choicesScript.removecalled = false;
            }
            if (choicesScript.addcalled == true)
            {
                StartCoroutine(EventOneGood());
                choicesScript.addcalled = false;
            }
        }


        if (eventPos == 4)
        {
            StartCoroutine(EventFour());
        }
        if (eventPos == 5)
        {
            StartCoroutine(EventFive());
        }
        if (eventPos == 6)
        {
            StartCoroutine(EventSix());
        }
        if (eventPos == 100)
        {
            StartCoroutine(EventFinal());
        }
    }
}

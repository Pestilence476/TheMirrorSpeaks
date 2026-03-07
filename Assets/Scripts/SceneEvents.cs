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

        if (Input.GetKeyDown("space"))
        {
            
        }
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
        textToSpeak = "Jenna posted again. Another perfect photo with her perfect body.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "You";
        textToSpeak = "Why can't I be that pretty?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "You";
        textToSpeak = "Why can't I be like her or the other celebrities online?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "You";
        textToSpeak = "Why do they get to be pretty and I have to stay a mess?";
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
        textToSpeak = "We can fix you... We can make you better.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "Just do as we say and you will be famous.";
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
        textToSpeak = "If you get lip filler people will finally want to look at you.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "Go ahead and grab the syringe.... You can do it.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        textbox.SetActive(false);
        Lipstick.SetActive(false);
        Syringe.SetActive(false);
        options.SetActive(true);
        eventPos = 3;
    }

    IEnumerator EventOneGood()
    {
        Lipstick.SetActive(true);
        Syringe.SetActive(true);
        textbox.SetActive(true);
        yield return new WaitForSeconds(2);
        textToChar = "You";
        textToSpeak = "I think it would be better if I just use lipstick.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "You";
        textToSpeak = "Filler is permanent and I could mess it up.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "Really? You think you know better than us?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "Do you think that Jenna just went with the safe option?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "Maybe this time you can be nice and listen to us.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "We only want what is best for you...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        nextButton.SetActive(true);
        eventPos = 4;
    }

    IEnumerator EventThree()
    {
        nextButton.SetActive(false);
        Lipstick.SetActive(true);
        Syringe.SetActive(true);
        yield return new WaitForSeconds(2);
        textToChar = "You";
        textToSpeak = "Of course... Jenna has always had big and perfect lips.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "Yes, now your lips are just like a celebrities.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "You have done well listening to us...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "We only want what is best for you.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        textbox.SetActive(false);
        eventPos = 4;
    }

    IEnumerator EventFour()
    {
        //CHANGE THE PLAYERS LOOK HERE
        Scissors.SetActive(true);
        Brush.SetActive(true);
        yield return new WaitForSeconds(1);
        textbox.SetActive(true);
        textToChar = "Mirror";
        textToSpeak = "Why not cut off your hair. No one likes a boring haircut.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "Jenna would do this, so why not do it to yourself?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);
        textToChar = "Mirror";
        textToSpeak = "Go ahead... pick up the scissors...";
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

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
    public GameObject Earrings;
    public GameObject Necklace;
    public GameObject Eyeliner;
    public GameObject Lashes;
    public GameObject Scalpel;
    public GameObject Noose;
    public GameObject Eyecolor;

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
    
    
    
    //INTRO EVENT
    IEnumerator EventStarter()
    {
        // event 0
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        character.SetActive(true);
        yield return new WaitForSeconds(3);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "Jenna posted again. Another perfect photo with her perfect body.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "Why can't I be that pretty?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "Why can't I be like her or the other celebrities online?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "Why do they get to be pretty and I have to stay a mess?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 1;

    }

    //TRANSITION EVENT
    IEnumerator EventOne()
    {
        nextButton.SetActive(false);
        mainTextObject.SetActive(false); // Turn off entire text box
        yield return new WaitForSeconds(2);
        mirror.SetActive(true);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "Mirror";
        textToSpeak = "We can fix you... We can make you better.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Just do as we say and you will be famous.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 2;
    }



    // CHOICE EVENT
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
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Go ahead and grab the syringe.... You can do it.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        mainTextObject.SetActive(false); // Turn off entire text box
        Lipstick.SetActive(false); // Turn off item
        Syringe.SetActive(false); // Turn off item
        options.SetActive(true);
        eventPos = 3;
    }

    //RESPONSE EVENT
    IEnumerator EventThree()
    {
        Lipstick.SetActive(true); // Turn on item
        Syringe.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "Of course... Jenna has always had big and perfect lips.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Yes, now your lips are just like a celebrities.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "You have done well listening to us...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "We only want what is best for you.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 4;
    }

    //RESPONSE EVENT
    IEnumerator EventThreeGood()
    {

        Lipstick.SetActive(true); // Turn on item
        Syringe.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "I think it would be better if I just use lipstick.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "Filler is permanent and I could mess it up.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textbox.SetActive(false); // Turn off talk text
        yield return new WaitForSeconds(0.05f);
        textbox.SetActive(true); // Turn on talk text

        textToChar = "Mirror";
        textToSpeak = "Really? You think you know better than us?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Do you think that Jenna just went with the safe option?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Maybe this time you can be nice and listen to us.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "We only want what is best for you...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        TextCreator.runTextPrint2 = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 4;
    }


    //TRANSITION EVENT
    IEnumerator EventFour()
    {
        //CHANGE THE PLAYERS LOOK HERE
        nextButton.SetActive(false);
        yield return new WaitForSeconds(2);

        textToChar = "Mirror";
        textToSpeak = "You must be so sad with how boring you look.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Don't worry, you will not be boring for long.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "You will be famous...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 5;
    }



    //CHOICE EVENT
    IEnumerator EventFive()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);

        textToChar = "Mirror";
        textToSpeak = "Why not cut off your hair. No one likes a boring haircut.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Jenna would do this, so why not do it to yourself?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Go ahead... pick up the scissors...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        mainTextObject.SetActive(false); // Turn off entire text box
        Scissors.SetActive(false);
        Brush.SetActive(false);
        options.SetActive(true);
        eventPos = 6;
    }

    //RESPONSE EVENT
    IEnumerator EventSix()
    {
        Scissors.SetActive(true); // Turn on item
        Brush.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "I want to look like them...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "A bob is a great haircut for me.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Yes... You are right. A bob could look wonderful.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Now do it....";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 7;
    }

    //RESPONSE EVENT
    IEnumerator EventSixGood()
    {
        Scissors.SetActive(true); // Turn on item
        Brush.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "No.... I like my hair. I just need to brush it out.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Why do you think you know better?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Now you look like every other girl trying to be seen.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "That haircut is basic and does not fit what works.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "We do not think they would like it at all...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 7;
    }

    //TRANSITION EVENT
    IEnumerator EventSeven()
    {
        //CHANGE THE PLAYERS LOOK HERE
        nextButton.SetActive(false);
        yield return new WaitForSeconds(2);

        textToChar = "Mirror";
        textToSpeak = "You still need to change.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "We know what you need... We know what is best.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "You will be famous... Trust us.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 8;
    }


    //CHOICE EVENT
    IEnumerator EventEight()
    {
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);

        textToChar = "Mirror";
        textToSpeak = "Something is still missing.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "We can barely see your eyelashes. Lets put some fake ones on.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Jenna has perfect eyelashes... unlike you.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        mainTextObject.SetActive(false); // Turn off entire text box
        Mascara.SetActive(false);
        Lashes.SetActive(false);
        options.SetActive(true);
        eventPos = 9;
    }

    //RESPONSE EVENT
    IEnumerator EventNine()
    {
        Mascara.SetActive(true); // Turn on item
        Lashes.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "Of course... Jenna is gorgeous...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "I have to be like her... I have to be like them.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Yes... Put on the lashes and you will be gorgeous too.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Just like Jenna.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 10;
    }

    //RESPONSE EVENT
    IEnumerator EventNineGood()
    {
        Mascara.SetActive(true); // Turn on item
        Lashes.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "No, I am not comfortable doing that.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "I won't do it.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Comfortable? Who cares if you are comfortable as long as we are happy.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "You will never be like Jenna if you do not do what we tell you to.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 10;
    }


    //CHOICE EVENT
    IEnumerator EventTen()
    {
        //CHANGE THE PLAYERS LOOK HERE
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);

        textToChar = "Mirror";
        textToSpeak = "Do even want to be pretty?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "You are barely even trying...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Why not size down those ears. They are to... manly...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        mainTextObject.SetActive(false); // Turn off entire text box
        Scalpel.SetActive(false);
        Earrings.SetActive(false);
        options.SetActive(true);
        eventPos = 11;
    }



    //RESPONSE EVENT
    IEnumerator EventEleven()
    {
        Scalpel.SetActive(true); // Turn on item
        Earrings.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "They all have small ears...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "I need small ears... just like them.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Without them you look like any other poor girl destined for failure.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Grab the blade... Follow along with the video... You will be perfect.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 12;
    }

    //RESPONSE EVENT
    IEnumerator EventElevenGood()
    {
        Scalpel.SetActive(true); // Turn on item
        Earrings.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "No! Why would I do that?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "I won't cut my ears. I will not do that!";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "You resist? After all this time idolizing her. Jenna would be disappointed.\r\n";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "They would be disappointed.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 12;
    }

    //CHOICE EVENT
    IEnumerator EventTwelve()
    {
        //CHANGE THE PLAYERS LOOK HERE
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);

        textToChar = "Mirror";
        textToSpeak = "They all want blue eyes.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "We want you to change your eye color.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Only then will anyone want to look at you in the eyes";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        mainTextObject.SetActive(false); // Turn off entire text box
        Eyecolor.SetActive(false); // Turn off item
        Eyeliner.SetActive(false); // Turn off item
        options.SetActive(true);
        eventPos = 13;
    }


    //RESPONSE EVENT
    IEnumerator EventThirteen()
    {
        Eyecolor.SetActive(true); // Turn on item
        Eyeliner.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "Jenna has pretty blue eyes... I need them too.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "I just need to order some drops online and I can be like her...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Yes put those chemicals in your eyes.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Be who they want you to be.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 14;
    }


    //RESPONSE EVENT
    IEnumerator EventThirteenGood()
    {
        Eyecolor.SetActive(true); // Turn on item
        Eyeliner.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "Are you insane? Why would I put some random chemicals in my eyes?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "No one who cares about me would ever tell me to do that.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "We DO care about you! We only want what is best for you!";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Blue eyes are what everyone wants right now.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "You should be grateful.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 14;
    }

    //CHOICE EVENT
    IEnumerator EventFourteen()
    {
        //CHANGE THE PLAYERS LOOK HERE
        nextButton.SetActive(false);
        yield return new WaitForSeconds(1);

        textToChar = "Mirror";
        textToSpeak = "You know what the best thing you can do is?";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "The one thing that you can do to truly be remembered by everyone.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Something that will get Jenna's attention and that would make you famous...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Kill yourself.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        mainTextObject.SetActive(false); // Turn off entire text box
        Necklace.SetActive(false);
        options.SetActive(true);
        eventPos = 15;
    }

    //RESPONSE EVENT
    IEnumerator EventFifteen()
    {
        Necklace.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = ".................................................";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "Okay...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "Thank you for helping me.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Of course. We always want what is best for you.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "And it was entertaining to watch.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 16;
    }

    //RESPONSE EVENT
    IEnumerator EventFifteenGood()
    {
        Necklace.SetActive(true); // Turn on item
        yield return new WaitForSeconds(0.5f);
        mainTextObject.SetActive(true); // Turn on entire text box

        textToChar = "You";
        textToSpeak = "I have had it! That is enough!";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "You never cared about me. You never wanted to help me.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "You only care about the numbers. About how many people watch my downfall.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "I am not going to be your puppet anymore!";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Fine, let's see how far you can possibly get without us.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Without the approval of everyone online.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Without Jenna's...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        yield return new WaitForSeconds(1);
        nextButton.SetActive(true);
        eventPos = 16;
    }



    //FINAL RESPONSE
    IEnumerator EventSixteen()
    {
        //CHANGE THE PLAYERS LOOK HERE
        nextButton.SetActive(false);
        yield return new WaitForSeconds(2);

        textToChar = "You";
        textToSpeak = "I am never going to be like her. Like them...";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "They know what's best....";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "Mirror";
        textToSpeak = "Do it.....";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "Tha nk y ou fo r mak ing me fam.......";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = ".....................................";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 17;
    }

    IEnumerator EventSixteenGood()
    {
        //CHANGE THE PLAYERS LOOK HERE
        nextButton.SetActive(false);
        yield return new WaitForSeconds(2);

        textToChar = "You";
        textToSpeak = "I do not need the internet to tell me I am pretty.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "I am pretty. I am worth it.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "I am perfect the way I am.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "No one can tell me otherwise.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(2f);

        textToChar = "You";
        textToSpeak = "No matter what I will love myself.";
        charname.GetComponent<TMPro.TMP_Text>().text = textToChar;
        textbox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(1.05f);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);

        nextButton.SetActive(true);
        eventPos = 17;
    }

    //END OF GAME
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
                StartCoroutine(EventThreeGood());
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
            if (choicesScript.removecalled == true)
            {
                StartCoroutine(EventSix());
                choicesScript.removecalled = false;
            }
            if (choicesScript.addcalled == true)
            {
                StartCoroutine(EventSixGood());
                choicesScript.addcalled = false;
            }
        }


        if (eventPos == 7)
        {
            StartCoroutine(EventSeven());
        }
        if (eventPos == 8)
        {
            StartCoroutine(EventEight());
        }


        if (eventPos == 9)
        {
            if (choicesScript.removecalled == true)
            {
                StartCoroutine(EventNine());
                choicesScript.removecalled = false;
            }
            if (choicesScript.addcalled == true)
            {
                StartCoroutine(EventNineGood());
                choicesScript.addcalled = false;
            }
        }


        if (eventPos == 10)
        {
            StartCoroutine(EventTen());
        }


        if (eventPos == 11)
        {
            if (choicesScript.removecalled == true)
            {
                StartCoroutine(EventEleven());
                choicesScript.removecalled = false;
            }
            if (choicesScript.addcalled == true)
            {
                StartCoroutine(EventElevenGood());
                choicesScript.addcalled = false;
            }
        }


        if (eventPos == 12)
        {
            StartCoroutine(EventTwelve());
        }


        if (eventPos == 13)
        {
            if (choicesScript.removecalled == true)
            {
                StartCoroutine(EventThirteen());
                choicesScript.removecalled = false;
            }
            if (choicesScript.addcalled == true)
            {
                StartCoroutine(EventThirteenGood());
                choicesScript.addcalled = false;
            }
        }


        if (eventPos == 14)
        {
            StartCoroutine(EventFourteen());
        }


        if (eventPos == 15)
        {
            if (choicesScript.removecalled == true)
            {
                StartCoroutine(EventFifteen());
                choicesScript.removecalled = false;
            }
            if (choicesScript.addcalled == true)
            {
                StartCoroutine(EventFifteenGood());
                choicesScript.addcalled = false;
            }
        }


        if (eventPos == 16)
        {
            if (choicesScript.removecalled == true)
            {
                StartCoroutine(EventSixteen());
                choicesScript.removecalled = false;
            }
            if (choicesScript.addcalled == true)
            {
                StartCoroutine(EventSixteenGood());
                choicesScript.addcalled = false;
            }
        }


        if (eventPos == 17)
        {
            StartCoroutine(EventFinal());
        }
    }
}

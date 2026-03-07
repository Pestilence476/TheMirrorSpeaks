using System;
using System.Collections;
using UnityEngine;

public class TextCreator : MonoBehaviour
{
    public static TMPro.TMP_Text viewText;
    public static TMPro.TMP_Text viewText2;
    public static bool runTextPrint;
    public static bool runTextPrint2;
    public static int charCount;
    [SerializeField] string transferText;
    [SerializeField] string transferText2;
    [SerializeField] int internalCount;
    public float speed;
    public float oldnumber;


    TextSpeedDropdown dropdown;



    private void Start()
    {
        dropdown = FindFirstObjectByType<TextSpeedDropdown>();
        speed = GameData.GetTextSpeed();
        oldnumber = speed;
    }


    // Update is called once per frame
    void Update()
    {
        

        if (gameObject.name == "SpeakText")
        {
            internalCount = charCount;
            charCount = GetComponent<TMPro.TMP_Text>().text.Length;
            if (runTextPrint == true)
            {
                runTextPrint = false;
                viewText = GetComponent<TMPro.TMP_Text>();
                transferText = viewText.text;
                viewText.text = "";
                StartCoroutine(RollText()); 
                
            }
            GameData.SetTextSpeed(oldnumber);
        }
        if (gameObject.name == "CharName")
        {
            if (runTextPrint2 == true)
            {
                runTextPrint2 = false;
                viewText2 = GetComponent<TMPro.TMP_Text>();
                transferText2 = viewText2.text;
                viewText2.text = "";
                StartCoroutine(PlaceText());
            }
        }
    }
    IEnumerator SkipText()
    {
        GameData.SetTextSpeed(-5000);
        Debug.Log("SPACEEEE");
        yield return new WaitForSeconds(0);
    }

    IEnumerator PlaceText()
    {
        foreach (char c in transferText2)
        {
            viewText2.text += c;
            yield return new WaitForSeconds(0);
        }
    }

    IEnumerator RollText()
    {
        foreach (char c in transferText)
        {
            viewText.text += c;
            yield return new WaitForSeconds(speed);
        }
    } 
}
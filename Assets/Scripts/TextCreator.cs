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
    public bool keyHasBeenPressed = false;
    [SerializeField] string transferText;
    [SerializeField] string transferText2;
    [SerializeField] int internalCount;
    public float speed;


    TextSpeedDropdown dropdown;



    private void Start()
    {
        dropdown = FindFirstObjectByType<TextSpeedDropdown>();
        speed = 0.03f;
        
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            speed = -5000;
        }

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
            keyHasBeenPressed = false;
        }
        ChangeTextSpeed();
    }

    public void ChangeTextSpeed()
    {
        // Check which option is selected
        if (dropdown.textbox.text == "Normal")
        {
            Debug.Log("Normal speed selected");
            speed = 0.03f;
            PlayerPrefs.SetFloat("Speed", speed);
        }
        if (dropdown.textbox.text == "Medium")
        {
            Debug.Log("Medium speed selected");
            speed = 50f;
            PlayerPrefs.SetFloat("Speed", speed);
        }
        if (dropdown.textbox.text == "Fast")
        {
            Debug.Log("Fast speed selected");
            speed = 500f;
            PlayerPrefs.SetFloat("Speed", speed);
        }
    }
}

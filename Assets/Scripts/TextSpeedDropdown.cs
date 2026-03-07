using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class TextSpeedDropdown : MonoBehaviour
{
    public TMP_Text textbox;
    public static TextSpeedDropdown Instance;
    

    void Start()
    {
        
        var dropdown = transform.GetComponent<TMP_Dropdown>();

        dropdown.options.Clear();

        List<string> items = new List<string>();
        items.Add("Normal");
        items.Add("Medium");
        items.Add("Fast");


        // Fill dropdown with items
        foreach(var item in items)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = item });
        }

        DropdownItemSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }



    public void DropdownItemSelected(TMP_Dropdown dropdown)
    {
        int index = dropdown.value;
        textbox.text = dropdown.options[index].text;
        UpdateTextSpeed();
    }

    public void UpdateTextSpeed()
    {
        if (textbox.text == "Normal")
        {
            GameData.SetTextSpeed(0.03f);
        }
        if (textbox.text == "Medium")
        {
            GameData.SetTextSpeed(-50f);
        }
        if (textbox.text == "Fast")
        {
            GameData.SetTextSpeed(-500f);
        }
    }
}
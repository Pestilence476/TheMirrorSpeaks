using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


[RequireComponent(typeof(UnityEngine.UI.Slider))]
public class TextSpeedSlider : MonoBehaviour
{

    [SerializeField] UnityEngine.UI.Slider slider;
    [SerializeField] TextMeshProUGUI label;
    private const string SpeedPrefKey = "TextSpeed";
    private TextCreator textCreator;

    private void OnValidate()
    {
        if (slider == null)
        {
            slider = GetComponent<UnityEngine.UI.Slider>();
        }
    }

    private void Start()
    {
       
        float speed = PlayerPrefs.HasKey(SpeedPrefKey) ? PlayerPrefs.GetFloat(SpeedPrefKey) : 0.5f;
        slider.value = speed;
        UpdateSpeed(speed);

       
        label.text = $"{(float)(speed)}";
        
    }

    private void OnDestroy()
    {
        slider.onValueChanged.RemoveListener(OnSpeedChange);
    }

    private void OnSpeedChange(float value)
    {
        UpdateSpeed(value);
        PlayerPrefs.SetFloat(SpeedPrefKey, value);
        PlayerPrefs.Save();
        label.text = $"{(int)(value)}";
    }

    private void UpdateSpeed(float value)
    {
        textCreator.speed = (1- (value));
    }
}

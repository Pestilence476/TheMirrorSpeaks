using UnityEngine;
using System.Collections;

[System.Serializable]
public class GameData
{
    public float textSpeed = 0.05f;
    public static int option = 1;

    private static GameData _instance;
    private const string KEY = "GameData";


    void Start()
    {
        option = 1;
    }

    private static GameData Instance
    {
        get
        {
            if (_instance == null)
                Load();
            return _instance;
        }
    }

    public static void SaveOption()
    {
        if (GetTextSpeed() == 0.05f)
        {
            option = 1;
        }
        if (GetTextSpeed() == 0.03f)
        {
            option = 2;
        }
        if (GetTextSpeed() == -5f)
        {
            option = 3;
        }
    }


    public static float GetTextSpeed() => Instance.textSpeed;

    public static void SetTextSpeed(float value)
    {
        Instance.textSpeed = value;
        Save();
        SaveOption();
    }

    private static void Save()
    {
        string json = JsonUtility.ToJson(Instance);
        PlayerPrefs.SetString(KEY, json);
        PlayerPrefs.Save();
    }

    private static void Load()
    {
        if (PlayerPrefs.HasKey(KEY))
        {
            string json = PlayerPrefs.GetString(KEY);
            _instance = JsonUtility.FromJson<GameData>(json);
        }
        else
        {
            _instance = new GameData();
        }
    }
}
using UnityEngine;
using System.Collections;

[System.Serializable]
public class GameData
{
    public float textSpeed = 0.03f;

    private static GameData _instance;
    private const string KEY = "GameData";

    private static GameData Instance
    {
        get
        {
            if (_instance == null)
                Load();
            return _instance;
        }
    }

    public static float GetTextSpeed() => Instance.textSpeed;

    public static void SetTextSpeed(float value)
    {
        Instance.textSpeed = value;
        Save();
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
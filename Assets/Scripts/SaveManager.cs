using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SavePointsForLevel(int points, int level)
    {
        int currentPointsInLevel = PlayerPrefs.GetInt("level" + level + "points");

        if (points > currentPointsInLevel)
        {
            PlayerPrefs.SetInt("level" + level + "points", points);
        }
    }

    public int LoadPointsForLevel(int level)
    {
        int totalPointsForLevel = 0;

        for (int i = 1; i < level; i++)
        {
            if (PlayerPrefs.HasKey("level" + i + "points"))
            {
                totalPointsForLevel += PlayerPrefs.GetInt("level" + i + "points");
            }
        }

        return totalPointsForLevel;
    }

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }

    public void SaveGoodEnding()
    {
        PlayerPrefs.SetInt("GoodEnding", 1);
        PlayerPrefs.SetInt("Background", 0);
    }
}

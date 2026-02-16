using UnityEngine;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    public Button[] buttons;
    public IntroMovie introMovie;

    private void OnEnable()
    {
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 0);
        if (unlockedLevel < 0)
        {
            unlockedLevel = 0;
        }

        if (unlockedLevel >= buttons.Length)
        {
            unlockedLevel = buttons.Length - 1;
        }

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        buttons[unlockedLevel].interactable = true;

        for (int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void OpenLevel(int levelId)
    {
        if (levelId == 1)
        {
            introMovie.gameObject.SetActive(true);
            introMovie.PlayVideo(() => { SceneController.Instance.LoadLevel(levelId); });
        }
        else
        {
            SceneController.Instance.LoadLevel(levelId);
        }
    }

}

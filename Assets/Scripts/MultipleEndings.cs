using UnityEngine;
using UnityEngine.SceneManagement;

public class MultipleEndings : MonoBehaviour
{
    public PlayerInventory inventory;
    int endState = -1;
    bool isActive = true;

    public void EndGame()
    {
        if (isActive)
        {
            if (CheckInventory())
            {
                EndingScene();
                isActive = false;
            }
        }
        
    }


    private bool CheckInventory()
    {
        if (inventory != null)
        {
            if (inventory.TotalGood >= 10)
            {
                endState = 0;
                SaveManager.Instance?.SaveGoodEnding();
            }
            else if (inventory.TotalGood >= 5)
            {
                endState = 1;
            }
            else
            {
                endState = 2;
            }
        }
        // Figure out how to get rid of this
        return inventory.Key > 0;
        // ---------------------------------
    }

    private void EndingScene()
    {
        switch (endState)
        {
            case 2:
                SceneManager.LoadScene("BadEnding");
                break;

            case 1:
                SceneManager.LoadScene("MehEnding");
                break;

            case 0:
                SceneManager.LoadScene("GoodEnding");
                break;

            default:
                SceneManager.LoadScene("BadEnding");
                break;
        }
    }
}
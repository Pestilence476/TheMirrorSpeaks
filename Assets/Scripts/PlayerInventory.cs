using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour
{

    //Change to new words and stuff



    // Figure out how to get rid of this ------------------------
    public int Key { get => _Key; set => _Key = value; }

    private int _Key = 0;
    // ----------------------------------------------------------




    public int CurrentGood { get => _CurrentGood; set => _CurrentGood = value; }

    private int _CurrentGood = 0;

    public int TotalGood { get => _TotalGood; set => _TotalGood = value; }

    private int _TotalGood = 0;




    private void Start()
    {
        _TotalGood = SaveManager.Instance.LoadPointsForLevel(SceneManager.GetActiveScene().buildIndex);
    }
}



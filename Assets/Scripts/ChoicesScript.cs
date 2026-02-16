using UnityEngine;
using UnityEngine.UI;

public class ChoicesScript : MonoBehaviour
{
    PlayerInventory inventory;
    public int GoodValue = 1;


    public void AddGood()
    {
        inventory.CurrentGood = inventory.CurrentGood + GoodValue;
        inventory.TotalGood = inventory.TotalGood + GoodValue;
        Debug.Log("GoodValue is now" + GoodValue);
    }

    public void MinusGood()
    {
        inventory.CurrentGood = inventory.CurrentGood - GoodValue;
        inventory.TotalGood = inventory.TotalGood - GoodValue;
        Debug.Log("GoodValue is now" + GoodValue);
    }

}

using UnityEngine;


public class ChoicesScript : MonoBehaviour
{
    public int GoodValue = 1;
    public PlayerInventory inventory;


    public void AddPoint()
    {
        if (inventory != null)
        {
            inventory.CurrentGood = inventory.CurrentGood + GoodValue;
            inventory.TotalGood = inventory.TotalGood + GoodValue;
            Debug.Log("GoodValue is now " + inventory.CurrentGood);
        }
    }

    public void MinusPoint()
    {
        if (inventory != null)
        {
            inventory.CurrentGood = inventory.CurrentGood - GoodValue;
            inventory.TotalGood = inventory.TotalGood - GoodValue;
            Debug.Log("GoodValue is now " + inventory.CurrentGood);
        }
    }
}

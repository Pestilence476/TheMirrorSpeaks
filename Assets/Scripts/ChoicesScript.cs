using UnityEngine;


public class ChoicesScript : MonoBehaviour
{
    public int GoodValue = 1;
    public PlayerInventory inventory;
    public SpriteChanger changer1;
    public SpriteChanger changer2;

    public void AddPoint()
    {
        if (inventory != null)
        {
            inventory.CurrentGood = inventory.CurrentGood + GoodValue;
            inventory.TotalGood = inventory.TotalGood + GoodValue;
            changer1.imageIndex = changer1.imageIndex + 1;
            changer2.imageIndex = changer2.imageIndex + 1;
            changer1.UpdateSprite();
            changer2.UpdateSprite();

            Debug.Log("GoodValue is now " + inventory.CurrentGood);
        }
    }

    public void MinusPoint()
    {
        if (inventory != null)
        {
            inventory.CurrentGood = inventory.CurrentGood - GoodValue;
            inventory.TotalGood = inventory.TotalGood - GoodValue;
            changer1.imageIndex = changer1.imageIndex + 1;
            changer2.imageIndex = changer2.imageIndex + 1;
            changer1.UpdateSprite();
            changer2.UpdateSprite();
            Debug.Log("GoodValue is now " + inventory.CurrentGood);
        }
    }
}

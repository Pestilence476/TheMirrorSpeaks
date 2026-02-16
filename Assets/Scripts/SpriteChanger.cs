using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    public Sprite[] images;
    public int imageIndex = 0;

    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
        UpdateSprite();
    }

    public void UpdateSprite()
    {
        if (imageIndex >= 0 && imageIndex < images.Length)
        {
            image.sprite = images[imageIndex];
        }
        else
        {
            Debug.LogError("Image index is out of range!");
        }
    }

    public void ChangeIndex(int newIndex)
    {
        imageIndex = newIndex;
        UpdateSprite();
    }
}

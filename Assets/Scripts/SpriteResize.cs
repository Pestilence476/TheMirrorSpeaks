using UnityEngine;

public class SpriteResize : MonoBehaviour
{
    public RectTransform rectTransform;
    public SpriteChanger spriteChanger;


    void Start()
    {
        UpdateSize();
    }

    private void Update()
    {
        UpdateSize();
    }

    public void UpdateSize()
    {
        rectTransform = GetComponent<RectTransform>();
        // Lipstick and Syringe
        if (spriteChanger.imageIndex == 0)
        {
            // Good Option
            if (gameObject.name == "Option 1")
            {
                // Height
                rectTransform.sizeDelta = new Vector2(116, rectTransform.sizeDelta.y);
                // Width
                rectTransform.sizeDelta = new Vector2(25, rectTransform.sizeDelta.x);
            }
            // Bad Option
            if (gameObject.name == "Option 2")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
        }

        // Brush and Scissors
        if (spriteChanger.imageIndex == 1)
        {
            if (gameObject.name == "Option 1")
            {
                rectTransform.sizeDelta = new Vector2(90, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(250, rectTransform.sizeDelta.x);
            }
            if (gameObject.name == "Option 2")
            {
                rectTransform.sizeDelta = new Vector2(225, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(95, rectTransform.sizeDelta.x);
            }
        }

        // Mascara and fake lashes
        if (spriteChanger.imageIndex == 2)
        {
            if (gameObject.name == "Option 1")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
            if (gameObject.name == "Option 2")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
        }

        // Earrings and Scalpel
        if (spriteChanger.imageIndex == 3)
        {
            if (gameObject.name == "Option 1")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
            if (gameObject.name == "Option 2")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
        }

        // Eyeliner and Eye color change
        if (spriteChanger.imageIndex == 4)
        {
            if (gameObject.name == "Option 1")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
            if (gameObject.name == "Option 2")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
        }

        // Necklace or Noose
        if (spriteChanger.imageIndex == 5)
        {
            if (gameObject.name == "Option 1")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
            if (gameObject.name == "Option 2")
            {
                rectTransform.sizeDelta = new Vector2(170, rectTransform.sizeDelta.y);
                rectTransform.sizeDelta = new Vector2(40, rectTransform.sizeDelta.x);
            }
        }

    }
}

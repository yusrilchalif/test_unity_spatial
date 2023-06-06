using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageCarousel : MonoBehaviour
{
    public List<Sprite> sprites;
    public Image image;
    public Button nextButton;
    public Button previousButton;

    private int currentIndex = 0;

    void Start()
    {
        ShowImage(currentIndex);

        nextButton.onClick.AddListener(NextImage);
        previousButton.onClick.AddListener(PreviousImage);
    }

    private void ShowImage(int index)
    {
        image.sprite = sprites[index];
    }

    public void NextImage()
    {
        currentIndex++;
        if (currentIndex >= sprites.Count)
        {
            currentIndex = sprites.Count - 1;
        }
        ShowImage(currentIndex);
    }

    public void PreviousImage()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = 0;
        }
        ShowImage(currentIndex);
    }
}

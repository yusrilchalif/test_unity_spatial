using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageSlider : MonoBehaviour
{
    [Tooltip("UI Reference")]
    [SerializeField] Image imgShow;
    [SerializeField] Button btnNext;
    [SerializeField] Button btnPrev;

    [SerializeField] private List<Sprite> imageToShow;
    private int indexImageForShow;

    public bool isEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        btnNext.onClick.AddListener(OnBtnPrevClicked);
        btnPrev.onClick.AddListener(OnBtnNextClicked);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBtnPrevClicked()
    {
        indexImageForShow--;
        print("button left clicked");
        if (indexImageForShow < 0)
            indexImageForShow = imageToShow.Count - 1;

        imgShow.sprite = imageToShow[indexImageForShow];
    }

    public void OnBtnNextClicked()
    {
        indexImageForShow++;
        print("button right clicked");
        if (indexImageForShow > imageToShow.Count - 1)
            indexImageForShow = 0;

        imgShow.sprite = imageToShow[indexImageForShow];
    }
}

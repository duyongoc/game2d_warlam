using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_Gallary : MonoBehaviour
{

    public Image imgContent;
    public Sprite[] objImage;
    SoundManager soundManager;


    private int currentIndex = 0;


    private void Start()
    {
        soundManager = FindObjectOfType<SoundManager>();
    }


    public void OnClickButton(int index)
    {
        if (currentIndex == index)
        {
            SoundManager.PlaySfx(soundManager.soundClick);
        }
        else
        {
            SoundManager.PlaySfx(soundManager.soundClickGallary);
        }

        imgContent.sprite = objImage[index];
        currentIndex = index;
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_Gallary : MonoBehaviour
{

    public Image imgContent;
    public Sprite[] objImage;


    public void OnClickButton(int index)
    {
        imgContent.sprite = objImage[index];
    }


}

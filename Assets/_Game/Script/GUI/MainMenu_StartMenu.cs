using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu_StartMenu : MonoBehaviour
{

    // public string facebookLink;
    // public string twitterLink;
    // public string moreGameLink;
    public GameObject panelExit;

    public Image soundImage;
    public Sprite soundOn;
    public Sprite soundOff;

    public Image musicImage;
    public Sprite musicOn;
    public Sprite musicOff;


    SoundManager soundManager;


    private void Start()
    {
        if (AudioListener.volume == 0)
            soundImage.sprite = soundOff;
        else
            soundImage.sprite = soundOn;

        soundManager = FindObjectOfType<SoundManager>();

    }


    public void TurnSound()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            soundImage.sprite = soundOn;
        }
        else
        {
            AudioListener.volume = 0;
            soundImage.sprite = soundOff;
        }

        SoundManager.PlaySfx(soundManager.soundClick);
    }
    
    
    public void TurnMusic()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            musicImage.sprite = musicOn;
        }
        else
        {
            AudioListener.volume = 0;
            musicImage.sprite = musicOff;
        }

        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OpenTwitter()
    {
        // Application.OpenURL(twitterLink);
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OpenFacebook()
    {
        // Application.OpenURL(facebookLink);
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void ShowPanelExit(bool value)
    {
        panelExit.SetActive(value);
    }

}

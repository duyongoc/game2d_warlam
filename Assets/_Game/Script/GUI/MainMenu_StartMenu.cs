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
        CheckMusic();
        soundManager = FindObjectOfType<SoundManager>();
    }


    private void CheckMusic()
    {
        if (SoundManager.SoundVolume == 0)
        {
            soundImage.sprite = soundOff;
        }
        else
        {
            soundImage.sprite = soundOn;
        }

        if (SoundManager.MusicVolume == 0)
        {
            musicImage.sprite = musicOff;
        }
        else
        {
            musicImage.sprite = musicOn;
        }

    }

    // public void TurnSound()
    // {
    //     if (AudioListener.volume == 0)
    //     {
    //         AudioListener.volume = 1;
    //         soundImage.sprite = soundOn;
    //     }
    //     else
    //     {
    //         AudioListener.volume = 0;
    //         soundImage.sprite = soundOff;
    //     }
    //     SoundManager.PlaySfx(soundManager.soundClick);
    // }


    // public void TurnMusic()
    // {
    //     if (AudioListener.volume == 0)
    //     {
    //         AudioListener.volume = 1;
    //         musicImage.sprite = musicOn;
    //     }
    //     else
    //     {
    //         AudioListener.volume = 0;
    //         musicImage.sprite = musicOff;
    //     }
    //     SoundManager.PlaySfx(soundManager.soundClick);
    // }


    public void TurnSound()
    {
        if (SoundManager.SoundVolume == 0)
        {
            SoundManager.SoundVolume = 1f;
            soundImage.sprite = soundOn;
        }
        else
        {
            SoundManager.SoundVolume = 0;
            soundImage.sprite = soundOff;
        }
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void TurnMusic()
    {
        if (SoundManager.MusicVolume == 0)
        {
            SoundManager.MusicVolume = 0.5f;
            musicImage.sprite = musicOn;
        }
        else
        {
            SoundManager.MusicVolume = 0;
            musicImage.sprite = musicOff;
        }
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OpenTwitter()
    {
        // Application.OpenURL(twitterLink);
        // SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OpenFacebook()
    {
        // Application.OpenURL(facebookLink);
        // SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void ShowPanelExit(bool value)
    {
        panelExit.SetActive(value);
    }

}

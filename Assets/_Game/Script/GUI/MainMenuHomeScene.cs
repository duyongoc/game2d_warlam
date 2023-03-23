using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;

public class MainMenuHomeScene : MonoBehaviour
{
    public static MainMenuHomeScene Instance;

    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private string videoFileName;

    [Header("[Setting]")]
    public List<GameObject> views;


    public GameObject StartMenu;
    public GameObject WorldsChoose;
    public GameObject LoadingScreen;
    public GameObject LevelsChoose;
    public GameObject CharacterChoose;
    public GameObject[] WorldLevel;



    SoundManager soundManager;


    private void Awake()
    {
        Instance = this;
        soundManager = FindObjectOfType<SoundManager>();
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, $"{videoFileName}.mp4");
    }

    private void Start()
    {
        // StartMenu.SetActive(true);
        // WorldsChoose.SetActive(false);
        // LevelsChoose.SetActive(false);
        // LoadingScreen.SetActive(true);
        // CharacterChoose.SetActive(false);



        videoPlayer.Play();
        ShowInitGame();
        // Debug.Log(videoPlayer.url);

    }


    private void ShowInitGame()
    {
        ShowView("FlashScene");
        DG.Tweening.DOVirtual.DelayedCall(6, () => ShowView("StartMenu"));

        // ShowView("StartMenu");
    }


    public void ShowView(string viewName)
    {
        views.ForEach(x => x.SetActive(false));
        views.Find(x => x.name.Contains(viewName))?.SetActive(true);
    }


    public void OpenWorld(int world)
    {
        // WorldsChoose.SetActive(false);
        // LevelsChoose.SetActive(true);

        for (int i = 0; i < WorldLevel.Length; i++)
        {
            if (i == (world - 1))
            {
                WorldLevel[i].SetActive(true);
            }
            else
                WorldLevel[i].SetActive(false);
        }

        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OpenWorldChoose()
    {
        // StartMenu.SetActive(false);
        // WorldsChoose.SetActive(true);
        // LevelsChoose.SetActive(false);
        ShowView("WorldsChoose");
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OpenStartMenu()
    {
        // StartMenu.SetActive(true);
        // WorldsChoose.SetActive(false);
        // CharacterChoose.SetActive(false);
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OpenCharacterChoose()
    {
        // StartMenu.SetActive(false);
        // CharacterChoose.SetActive(true);
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OnClickButtonExit()
    {
        Application.Quit();
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OnClickButtonShop()
    {
        ShowView("Shop");
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OnClickButtonStartMenu()
    {
        ShowView("StartMenu");
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OnClickButtonSetting()
    {
        ShowView("Setting");
        SoundManager.PlaySfx(soundManager.soundClick);
    }


    public void OnClickButtonGallary()
    {
        ShowView("Gallary");
        SoundManager.PlaySfx(soundManager.soundClick);
    }

}

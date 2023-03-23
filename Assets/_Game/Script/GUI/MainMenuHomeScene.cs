using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MainMenuHomeScene : MonoBehaviour
{
    public static MainMenuHomeScene Instance;


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
    }

    private void Start()
    {
        // StartMenu.SetActive(true);
        // WorldsChoose.SetActive(false);
        // LevelsChoose.SetActive(false);
        // LoadingScreen.SetActive(true);
        // CharacterChoose.SetActive(false);
        ShowInitGame();
    }


    private void ShowInitGame()
    {
        // ShowView("FlashScene");
        // DG.Tweening.DOVirtual.DelayedCall(6, () => ShowView("StartMenu"));

        ShowView("StartMenu");
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
    }


    public void OnClickButtonShop()
    {
        ShowView("Shop");
    }


    public void OnClickButtonStartMenu()
    {
        ShowView("StartMenu");
    }


    public void OnClickButtonSetting()
    {
        ShowView("Setting");
    }


    public void OnClickButtonGallary()
    {
        ShowView("Gallary");
    }

}

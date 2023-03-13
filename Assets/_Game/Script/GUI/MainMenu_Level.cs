using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_Level : MonoBehaviour
{


    public int worldNumber = 0;
    public int levelNumber = 0;
    public string loadscene = "Level Name";
    public Text TextLevel;
    public GameObject Locked;


    private void Start()
    {
        var levelReached = PlayerPrefs.GetInt(worldNumber.ToString(), 1);
        if (levelNumber <= levelReached && worldNumber <= PlayerPrefs.GetInt(GlobalValue.WorldReached, 1))
        {
            // TextLevel.gameObject.SetActive(true);
            // Locked.SetActive(false);
            TextLevel.text = levelNumber.ToString();
        }
        else
        {
            // TextLevel.gameObject.SetActive(false);
            // Locked.SetActive(true);
            GetComponent<Button>().interactable = false;
        }
    }

    public void LoadScene()
    {
        GlobalValue.worldPlaying = worldNumber;
        GlobalValue.levelPlaying = levelNumber;

        LoadingSreen.Show();

        SceneManager.LoadSceneAsync(loadscene);
    }
}

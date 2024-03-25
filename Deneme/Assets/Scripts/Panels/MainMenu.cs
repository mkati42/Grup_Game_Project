using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject settingPanel;
    public GameObject mainPanel;
    // Start is called before the first frame update
    void Start()
    {
        settingPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        settingPanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void TrainingScene()
    {
        SceneManager.LoadScene("Training Menu");
    }
}

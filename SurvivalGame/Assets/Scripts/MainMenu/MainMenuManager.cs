using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager: MonoBehaviour
{
     public GameObject settingsPanel;
     public GameObject mainMenuPanel;
     
     public GameObject soundsPanel;
     public GameObject developerPanel;

     public GameObject copyrightTxt;

     public void DefaultMainMenu()
     {
          mainMenuPanel.SetActive(true);
          settingsPanel.SetActive(false);
          soundsPanel.SetActive(false);
          developerPanel.SetActive(false);
          copyrightTxt.SetActive(true);
     }

    public void Play()
    {
     SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
        copyrightTxt.SetActive(false);
    }

    public void Quit()
    {
     Application.Quit();
    }
}

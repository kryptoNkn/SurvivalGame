using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager: MonoBehaviour
{
     public GameObject settingsPanel;
     public GameObject mainMenuPanel;
     
     public GameObject soundsPanel;
     public GameObject developerPanel;

     public void DefaultMainMenu()
     {
          mainMenuPanel.SetActive(true);
          settingsPanel.SetActive(false);
          soundsPanel.SetActive(false);
          developerPanel.SetActive(false);
     }

    public void Play()
    {
     SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void Quit()
    {
     Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager: MonoBehaviour
{
     public GameObject settingsPanel;
     public GameObject playButton;
     public GameObject settingsButton;
     public GameObject quitButton;
     
     public GameObject soundsPanel;
     public GameObject gameplayPanel;
     public GameObject developerPanel;

     public void DefaultMainMenu()
     {
          playButton.SetActive(true);
          settingsButton.SetActive(true);
          quitButton.SetActive(true);
          settingsPanel.SetActive(false);
          soundsPanel.SetActive(false);
          gameplayPanel.SetActive(false);
          developerPanel.SetActive(false);
     }

    public void Play()
    {
     SceneManager.LoadScene(1);
    }

    public void Settings()
    {
          playButton.SetActive(false);
          settingsButton.SetActive(false);
          quitButton.SetActive(false);
          settingsPanel.SetActive(true);
    }

    public void Quit()
    {
     Application.Quit();
    }
}

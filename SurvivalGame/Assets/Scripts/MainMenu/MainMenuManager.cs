using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager: MonoBehaviour
{
     public GameObject settingsPanel;
     public GameObject playButton;
     public GameObject settingsButton;
     public GameObject quitButton;

     public void DefaultMainMenu()
     {
          playButton.SetActive(true);
          settingsButton.SetActive(true);
          quitButton.SetActive(true);
          settingsPanel.SetActive(false);
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

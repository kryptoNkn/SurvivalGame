using UnityEngine;

public class SettingsLogic : MonoBehaviour
{
    public GameObject graphicsPanel;
    public GameObject soundsPanel;
    public GameObject gameplayPanel;
    public GameObject developerPanel;
        
    public void Graphics()
    {
        graphicsPanel.SetActive(true);
        soundsPanel.SetActive(false);
        gameplayPanel.SetActive(false);
        developerPanel.SetActive(false);
    }
    
    public void Sounds()
    {
        graphicsPanel.SetActive(false);
        soundsPanel.SetActive(true);
        gameplayPanel.SetActive(false);
        developerPanel.SetActive(false);
    }
    
    public void Gameplay()
    {
        graphicsPanel.SetActive(false);
        soundsPanel.SetActive(false);
        gameplayPanel.SetActive(true);
        developerPanel.SetActive(false);
    }
    
    public void Developer()
    {
        graphicsPanel.SetActive(false);
        soundsPanel.SetActive(false);
        gameplayPanel.SetActive(false);
        developerPanel.SetActive(true);
    }
}

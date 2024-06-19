using UnityEngine;

public class SettingsLogic : MonoBehaviour
{
    public GameObject graphicsPanel;
    public GameObject soundsPanel;
    public GameObject developerPanel;
        
    public void Graphics()
    {
        graphicsPanel.SetActive(true);
        soundsPanel.SetActive(false);
        developerPanel.SetActive(false);
    }
    
    public void Sounds()
    {
        graphicsPanel.SetActive(false);
        soundsPanel.SetActive(true);
        developerPanel.SetActive(false);
    }
    
    public void Developer()
    {
        graphicsPanel.SetActive(false);
        soundsPanel.SetActive(false);
        developerPanel.SetActive(true);
    }
}

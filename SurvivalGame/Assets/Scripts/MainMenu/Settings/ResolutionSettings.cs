using TMPro;
using UnityEngine;

public class ResolutionSettings : MonoBehaviour
{
    public TMP_Dropdown resolution;
    
    public void Resolution()
    {
        switch (resolution.value)
        {
            case 0:
                Screen.SetResolution(1920, 1080, true);
                break;
            case 1:
                Screen.SetResolution(1280, 720, true);
                break;
            case 2:
                Screen.SetResolution(854, 480, true);
                break;
            case 3:
                Screen.SetResolution(640, 360, true);
                break;
        }
    }
}

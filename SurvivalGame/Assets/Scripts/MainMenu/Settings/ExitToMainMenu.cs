using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitToMainMenu : MonoBehaviour
{
 private void Start()
 {
  Cursor.visible = true;
  Cursor.lockState = CursorLockMode.None;
 }

 public void ExitToMenu()
 {
  SceneManager.LoadScene(0);
 }
}

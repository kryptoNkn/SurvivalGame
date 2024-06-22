using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerInteractionUI : MonoBehaviour
{
   public void InteractionUITrue()
   {
      GetComponent<FirstPersonController>().enabled = false;
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
   }
   
   public void InteractionUIFalse()
   {
      GetComponent<FirstPersonController>().enabled = true; 
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Locked;
   }
}

using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ItemInventory : MonoBehaviour
{
   Button button;
   public static int playerHealth;
   public TMP_Text playerHealthTxt;
   public bool gameOver;

   private void Start()
   {
      button = GetComponent<Button>();
      button.onClick.AddListener(ItemInteraction);
      playerHealth = 100;
      gameOver = false;
   }

   private void Update()
   {
      playerHealthTxt.text = "" + playerHealth;
      if (gameOver)
      {
         SceneManager.LoadScene(0);
      }
   }

   void ItemInteraction()
   {
      playerHealth += 50;
      Destroy(gameObject);
   }
}

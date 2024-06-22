using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static int playerHealth = 100;
    public static bool gameOver = false;
    public TextMeshProUGUI playerHealthTxt;
    public GameObject bloodOverlay;
    private Button button;
    
    
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ItemInteraction);
    }

    private void Update()
    {
        playerHealthTxt.text = "" + playerHealth.ToString();
        if (gameOver) {SceneManager.LoadScene(0);}
        if (playerHealth <= 20) {playerHealthTxt.color = Color.red;}
    }

    public IEnumerator Damage(int damageCount)
    {
        playerHealth -= damageCount;
        bloodOverlay.SetActive(true);
        if (playerHealth <= 0) {gameOver = true;}

        yield return new WaitForSeconds(0.5f);
        bloodOverlay.SetActive(false);
    }

    private void ItemInteraction()
    {
        playerHealth = Mathf.Min(playerHealth + 50, 100);
        Destroy(gameObject);
    }
}

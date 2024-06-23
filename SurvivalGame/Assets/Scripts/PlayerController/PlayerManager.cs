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

    public static int aidKitValue = 50;
    public static int bandageValue = 20;

    public int itemId;
    
    private void Start()
    {
        button = GetComponent<Button>();
        if (itemId == 1)
        {
        button.onClick.AddListener(FirstAidKitInteraction);
        }

        if (itemId == 2)
        {
            button.onClick.AddListener(BandageInteraction);
        }
    }

    private void Update()
    {
        playerHealthTxt.text = "" + playerHealth.ToString();
        if (gameOver) {SceneManager.LoadScene(0);}
        if (playerHealth <= 20) {playerHealthTxt.color = Color.red;}
        if (playerHealth > 20) {playerHealthTxt.color = Color.white;}
    }

    public IEnumerator Damage(int damageCount)
    {
        playerHealth -= damageCount;
        bloodOverlay.SetActive(true);
        if (playerHealth <= 0) {gameOver = true;}

        yield return new WaitForSeconds(0.5f);
        bloodOverlay.SetActive(false);
    }

    private void FirstAidKitInteraction()
    {
        itemId = 1;
        playerHealth = Mathf.Min(playerHealth + aidKitValue, 100);
        Destroy(gameObject);
    }

    private void BandageInteraction()
    {
        itemId = 2;
        playerHealth = Mathf.Min(playerHealth + bandageValue, 100);
        Destroy(gameObject);
    }
}

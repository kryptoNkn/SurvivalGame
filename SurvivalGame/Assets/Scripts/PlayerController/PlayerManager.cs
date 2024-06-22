using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static int playerHealt;
    public static bool gameOver;
    public TextMeshProUGUI playerHealthTxt;
    public GameObject bloodOverlay;
    
    private void Start()
    {
        playerHealt = 100;
        gameOver = false;
    }

    private void Update()
    {
        playerHealthTxt.text = "" + playerHealt;
        if (gameOver) {SceneManager.LoadScene(0);}
        if (playerHealt <= 20) {playerHealthTxt.color = Color.red;}
    }

    public IEnumerator Damage(int damageCount)
    {
        playerHealt -= damageCount;
        bloodOverlay.SetActive(true);
        if (playerHealt <= 0) {gameOver = true;}

        yield return new WaitForSeconds(0.5f);
        bloodOverlay.SetActive(false);
    }
}

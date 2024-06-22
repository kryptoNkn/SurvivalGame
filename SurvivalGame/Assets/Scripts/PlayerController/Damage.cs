using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageCount = 10;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(FindObjectOfType<PlayerManager>().Damage(damageCount));
    }
}

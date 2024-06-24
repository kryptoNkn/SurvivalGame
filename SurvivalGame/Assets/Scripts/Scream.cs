using UnityEngine;

public class Scream : MonoBehaviour
{
    public Collider myCollider;
    public AudioClip myClip;
    public GameObject mySoundSource;
    
    private void OnTriggerEnter(Collider myCollider)
    {
       mySoundSource.GetComponent<AudioSource>().PlayOneShot(myClip);
       Destroy(gameObject);
    }
}

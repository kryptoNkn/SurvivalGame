using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject light;
    public GameObject light1;
    public AudioClip myClip;
    public GameObject mySoundSource;

    private void OnTriggerEnter(Collider other)
    {
        if (player)
        {
            light.SetActive(true);
            light1.SetActive(true);
            mySoundSource.GetComponent<AudioSource>().PlayOneShot(myClip);
            Destroy(gameObject);
        }
    }
}

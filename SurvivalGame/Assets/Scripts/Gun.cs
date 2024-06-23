using TMPro;
using UnityEngine;

public class Gun : MonoBehaviour
{
   private RaycastHit hit;
   public AudioClip myClip;
   private AudioSource mySource;
   public int quantityPatron = 0;
   public TMP_Text patronCounter;
   public GameObject gun;
   

   private void Start()
   {
      gun.SetActive(false);
      patronCounter.text = "" + quantityPatron;
      mySource = Camera.main.GetComponent<AudioSource>();
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Mouse0))
      {
         Shoot();
      }
   }

   public void Shoot()
   {
      if (quantityPatron >= 1)
      {
         mySource.PlayOneShot(myClip);
         quantityPatron -= 1;
         if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
         {
            if (hit.collider.tag == "Enemy")
            {
               hit.collider.GetComponentInParent<EnemyController>().EnemyDeath();
            }
         }
      }

      if (quantityPatron < 1)
      {
         patronCounter.enabled = false;
      }

      PatronCounterUpdate();
   }

   public void PatronCounterUpdate()
   {
      patronCounter.text = "" + quantityPatron;
   }
}

using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
   public Transform target;
   private float distance;
   private NavMeshAgent myAgent;
   private Animator myAnim;

   private Rigidbody[] rigidbodies;
   public int enemyHealth = 100;
   
      
   private void Start()
   {
      rigidbodies = GetComponentsInChildren<Rigidbody>();
      foreach (Rigidbody rigidbody in rigidbodies)
      {
         rigidbody.isKinematic = true;
         rigidbody.tag = "Enemy";
      }
      myAnim = GetComponent<Animator>();
      myAgent = GetComponent<NavMeshAgent>();
   }

   private void Update()
   {
       Enemy();
   }

   private void Enemy()
   {
      Vector3 lookDirection = new Vector3(target.position.x, transform.position.y, target.position.z) - transform.position;
      transform.rotation = Quaternion.LookRotation(lookDirection);
      distance = Vector3.Distance(transform.position, target.transform.position);
      if (distance > 10)
      {
         myAgent.enabled = false;
         myAnim.SetBool("ZombieIdle", true);
         myAnim.SetBool("ZombieRun", false);
         myAnim.SetBool("ZombieAttack", false);
      }
      if (distance <= 10 && distance > 1.5f)
      {
         myAgent.enabled = true;
         myAgent.SetDestination(target.position);
         myAnim.SetBool("ZombieIdle", false);
         myAnim.SetBool("ZombieRun", true);
         myAnim.SetBool("ZombieAttack", false);
      }
      if (distance <= 1.5f)
      {
         myAgent.enabled = false;
         myAnim.SetBool("ZombieIdle", false);
         myAnim.SetBool("ZombieRun", false);
         myAnim.SetBool("ZombieAttack", true);
      }
   }

   public void EnemyDeath()
   {
      myAnim.enabled = false;
      myAgent.enabled = false;
      foreach (Rigidbody rigidbody in rigidbodies)
      {
         rigidbody.isKinematic = false;   
      }

      this.enabled = false;
   }
   
}

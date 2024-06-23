using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{
   public Transform target;
   private float distance;
   private NavMeshAgent myAgent;
   private Animator myAnim;

   private void Start()
   {
      myAnim = GetComponent<Animator>();
      myAgent = GetComponent<NavMeshAgent>();
   }

   private void Update()
   {
       Enemy();
   }

   private void Enemy()
   {
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
}

using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    [SerializeField] private Transform target;
    private int pathIndex = 0;
    public bool chosePath = false;
    public Transform path;
    public int enemyHealth;
    public bool isDead = false;
    private UnityEngine.AI.NavMeshAgent agent;
   
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
    }

    private void Update()
    {
        //if (Vector2.Distance(target.position, transform.position) <= 0.1f)
       // {
        //    pathIndex++;
        //    AudioManager.Instance.PlaySFX(AudioManager.Instance.enemymoveSFX);

        //    if (pathIndex == LevelManager.main.path.Length)
        //    {
        //        Destroy(gameObject);
        //    }
        //}

        //if (enemyHealth <= 0)
        //{ this.isDead = true;
        //  AudioManager.Instance.PlaySFX(AudioManager.Instance.enemydeathSFX);
        //  Destroy(gameObject);
        //  Instantiate(corpsePrefab, transform.position, transform.rotation);
        //}
    }

}
